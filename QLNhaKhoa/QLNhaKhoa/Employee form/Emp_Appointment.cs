using QLNhaKhoa.Filter_folder;
using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Appointment : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        private readonly string query = "select * from LICHHEN order by IDPHONGKHAM, NGAY, IDHOSO, IDLICHHEN";
        private string record_id = string.Empty, emp_id = string.Empty;
        private static Emp_AddAppointment f;

        public Emp_Appointment()
        {
            InitializeComponent();
        }

        private void Emp_Appointment_Load(object sender, EventArgs e)
        {
            string dentist = "select IDTAIKHOAN, HOTEN from TAIKHOAN where LOAITAIKHOAN=1";
            appointmentData.DataSource = Helper.getData(query).Tables[0];

            DataTable dt1 = Helper.getData("select IDPHONGKHAM from PHONGKHAM").Tables[0];
            DataRow dr1 = dt1.NewRow();
            dr1[0] = "-- Phòng khám -- ";
            dt1.Rows.InsertAt(dr1, 0);
            cboRoom.DisplayMember = "IDPHONGKHAM";
            cboRoom.ValueMember = "IDPHONGKHAM";
            cboRoom.DataSource = dt1;

            DataTable dt2 = Helper.getData(dentist).Tables[0];
            DataRow dr2 = dt2.NewRow();
            dr2[1] = "-- Chọn nha sĩ -- ";
            dt2.Rows.InsertAt(dr2, 0);
            cboDentist.DisplayMember = "HOTEN";
            cboDentist.ValueMember = "IDTAIKHOAN";
            cboDentist.DataSource = dt2;

            DataTable dt3 = Helper.getData(dentist).Tables[0];
            DataRow dr3 = dt3.NewRow();
            dr3[1] = "-- Chọn trợ khám -- ";
            dt3.Rows.InsertAt(dr3, 0);
            cboAssistant.DisplayMember = "HOTEN";
            cboAssistant.ValueMember = "IDTAIKHOAN";
            cboAssistant.DataSource = dt3;
        }

        private void appointmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = appointmentData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                string time_str = dgvr.Cells["GIO"].Value.ToString();

                if (time_str.All(char.IsDigit))
                {
                    int time = int.Parse(time_str);
                    int hour = time / 60;
                    int minutes = time - hour * 60;

                    appIDBox.Text = dgvr.Cells["IDLICHHEN"].Value.ToString();
                    appointTime.Text = hour + ":" + minutes;
                    appointDate.Text = dgvr.Cells["NGAY"].Value.ToString();
                    cboRoom.Text = dgvr.Cells["IDPHONGKHAM"].Value.ToString();
                    noteBox.Text = dgvr.Cells["GHICHU"].Value.ToString();
                    emp_id = dgvr.Cells["IDNHANVIENDAT"].Value.ToString();
                    record_id = dgvr.Cells["IDHOSO"].Value.ToString();
                    if (dgvr.Cells["TINHTRANG"].Value.ToString() == "0")
                    {
                        cboStatus.Text = "Cuộc hẹn mới";
                    }
                    else cboStatus.Text = "Tái khám";

                    SqlCommand cmd1 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN='" + dgvr.Cells["IDNHASI"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cboDentist.Text = reader.GetString(0);
                        }
                    }

                    SqlCommand cmd2 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN='" + dgvr.Cells["IDTROKHAM"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetString(0) == "")
                            {
                                cboAssistant.SelectedIndex = cboAssistant.Items.IndexOf("-- Chọn trợ khám -- ");
                            }
                            else cboAssistant.Text = reader.GetString(0);
                        }
                    }

                    SqlCommand cmd3 = new SqlCommand("select HOTEN from HOSOBENHNHAN where IDHOSO='" + record_id + "'", sqlCon);
                    using (SqlDataReader reader = cmd3.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerBox.Text = reader.GetString(0);
                        }
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int status = 0;
            string[] parts = appointTime.Text.Split(":");
            int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
            string dentist_id = ((DataRowView)cboDentist.SelectedItem)["IDTAIKHOAN"].ToString();
            string assistant_id = ((DataRowView)cboAssistant.SelectedItem)["IDTAIKHOAN"].ToString();
            if (time < 480 || time > 1020)
            {
                MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
            }
            else if (dentist_id == assistant_id)
            {
                MessageBox.Show("Nha sĩ chính và trợ khám không thể là cùng một người!");
            }
            else if (appointDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày hẹn không hợp lệ! Vui lòng chọn ngày trong tương lai");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_LICHHEN_UPD", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cboStatus.Text == "Tái khám")
                    {
                        status = 1;
                    }

                    cmd.Parameters.Add(new SqlParameter("@IDHOSO", record_id));
                    cmd.Parameters.Add(new SqlParameter("@IDLICHHEN", appIDBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIO", time));
                    cmd.Parameters.Add(new SqlParameter("@TINHTRANG", status));
                    cmd.Parameters.Add(new SqlParameter("@GHICHU", noteBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@IDPHONGKHAM", cboRoom.Text));
                    cmd.Parameters.Add(new SqlParameter("@IDNHASI", dentist_id));
                    cmd.Parameters.Add(new SqlParameter("@IDTROKHAM", assistant_id));
                    cmd.Parameters.Add(new SqlParameter("@IDNHANVIENDAT", emp_id));
                    cmd.Parameters.Add(new SqlParameter("@NGUOIUPDATE", CurrentEmp));

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cập nhật lịch hẹn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật lịch hẹn thất bại!");
                    }
                    Helper.refreshData(query, appointmentData);
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật lịch hẹn thất bại! " + ex.Message);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, appointmentData);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa lịch hẹn này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("delete from LICHHEN where IDLICHHEN='" + appIDBox.Text + "'", sqlCon);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa lịch hẹn thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa lịch hẹn thất bại!");
                }
                Helper.refreshData(query, appointmentData);
                sqlCon.Close();
            }
            else { }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            f = new Emp_AddAppointment();
            f.CurrentEmp = CurrentEmp;
            f.FormClosedEvent += AdminFormClosedEvent;
            f.Show();
        }

        private void AdminFormClosedEvent(object sender, EventArgs e)
        {
            Helper.refreshData(query, appointmentData);
        }
    }
}
