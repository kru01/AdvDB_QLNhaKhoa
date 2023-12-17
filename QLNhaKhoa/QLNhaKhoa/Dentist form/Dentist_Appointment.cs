using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Appointment : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Appointment()
        {
            InitializeComponent();
        }
        private void Dentist_Appointment_Load(object sender, EventArgs e)
        {
            string appointment_query = "select * from LICHHEN where IDNHASI='" + CurrentDentist + "'";
            string customer_query = "select HOTEN, IDHOSO from HOSOBENHNHAN";
            string otherDentists_query = "select HOTEN, IDTAIKHOAN from TAIKHOAN where LOAITAIKHOAN = 1";
            string clinics_query = "select * from PHONGKHAM";
            string staffs_query = "select * from TAIKHOAN where LOAITAIKHOAN = 0";
            appointmentData.DataSource = Helper.getData(appointment_query).Tables[0];

            cboCustomer.DisplayMember = "HOTEN";
            cboCustomer.ValueMember = "IDHOSO";
            cboCustomer.DataSource = Helper.getData(customer_query).Tables[0];

            comboBox_TroKham.DisplayMember = "HOTEN";
            comboBox_TroKham.ValueMember = "IDTAIKHOAN";
            comboBox_TroKham.DataSource = Helper.getData(otherDentists_query).Tables[0];

            comboBox_PhongKham.DisplayMember = "DIACHI";
            comboBox_PhongKham.ValueMember = "IDPHONGKHAM";
            comboBox_PhongKham.DataSource = Helper.getData(clinics_query).Tables[0];

            comboBox_staffs.DisplayMember = "HOTEN";
            comboBox_staffs.ValueMember = "IDTAIKHOAN";
            comboBox_staffs.DataSource = Helper.getData(staffs_query).Tables[0];

            empIDBox.Text = CurrentDentist;
        }
        private void appointmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != appointmentData.RowCount)
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

                    timeBox.Text = hour + ":" + minutes;
                    dateBox.Text = dgvr.Cells["NGAY"].Value.ToString();
                    appIDBox.Text = dgvr.Cells["IDLICHHEN"].Value.ToString();
                    textBox_GhiChu.Text = dgvr.Cells["GHICHU"].Value.ToString();
                    int x;
                    Int32.TryParse(dgvr.Cells["TINHTRANG"].Value.ToString(), out x);
                    numericUpDown_TinhTrang.Value = x;
                    SqlCommand cmd1 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN = '" + dgvr.Cells["IDTROKHAM"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            comboBox_TroKham.Text = reader.GetString(0);
                        }
                    }

                    SqlCommand cmd = new SqlCommand("select HOTEN from HOSOBENHNHAN where IDHOSO='" + dgvr.Cells["IDHOSO"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cboCustomer.Text = reader.GetString(0);
                        }
                    }

                    SqlCommand cmd2 = new SqlCommand("select DIACHI from PHONGKHAM where IDPHONGKHAM='" + dgvr.Cells["IDPHONGKHAM"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            comboBox_PhongKham.Text = reader.GetString(0);
                        }
                    }

                    SqlCommand cmd3 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN='" + dgvr.Cells["IDNHANVIENDAT"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd3.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            comboBox_staffs.Text = reader.GetString(0);
                        }
                    }
                }
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            string[] parts = timeBox.Text.Split(":");
            int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
            if (time < 480 || time > 1020)
            {
                 MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_LICHHEN_UPD", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    var item = (DataRowView)cboCustomer.SelectedItem;
                    var assistant = (DataRowView)comboBox_TroKham.SelectedItem;
                    var clinic = (DataRowView)comboBox_PhongKham.SelectedItem;
                    var responsibleStaff = (DataRowView)comboBox_staffs.SelectedItem;
                    cmd.Parameters.Add(new SqlParameter("@IDLICHHEN", appIDBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAY", dateBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIO", time));
                    cmd.Parameters.Add(new SqlParameter("@IDHOSO", item["IDHOSO"].ToString()));
                    cmd.Parameters.Add(new SqlParameter("@IDNHASI", CurrentDentist));
                    cmd.Parameters.Add(new SqlParameter("@NGUOIUPDATE", CurrentDentist));
                    cmd.Parameters.Add(new SqlParameter("@IDPHONGKHAM", clinic["IDPHONGKHAM"]));
                    cmd.Parameters.Add(new SqlParameter("@GHICHU", textBox_GhiChu.Text));
                    cmd.Parameters.Add(new SqlParameter("@TINHTRANG", numericUpDown_TinhTrang.Value));
                    cmd.Parameters.Add(new SqlParameter("@IDTROKHAM", assistant["IDTAIKHOAN"]));
                    cmd.Parameters.Add(new SqlParameter("@IDNHANVIENDAT", responsibleStaff["IDTAIKHOAN"]));

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cập nhật lịch hẹn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật lịch hẹn thất bại!");
                    }
                    Helper.refreshData("select * from LICHHEN where IDNHASI='" + CurrentDentist + "'", appointmentData);
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                        MessageBox.Show("Cập nhật lịch hẹn thất bại! " + ex.Message);
                }       
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa lịch hẹn này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                try
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
                    Helper.refreshData("select * from LICHHEN where IDNHASI='" + CurrentDentist + "'", appointmentData);
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lịch hẹn thất bại! " + ex.Message);
                }
            }
            else { }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from LICHHEN where IDNHASI='" + CurrentDentist + "'", appointmentData);
        }
        private void makeAppButton_Click(object sender, EventArgs e)
        {
            string[] parts = timeBox.Text.Split(":");
            int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
            if (time < 480 || time > 1020)
            {
                MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_LICHHEN_INS", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    var item = (DataRowView)cboCustomer.SelectedItem;
                    cmd.Parameters.Add(new SqlParameter("@NGAY", dateBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIO", time));
                    cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", item["MAKHACHHANG"].ToString()));
                    cmd.Parameters.Add(new SqlParameter("@MANHASI", CurrentDentist));
                    cmd.Parameters.Add("@MALICHHEN", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Đặt lịch hẹn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đặt lịch hẹn thất bại!");
                    }
                    Helper.refreshData("select * from LICHHEN where MANHASI='" + CurrentDentist + "'", appointmentData);
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đặt lịch hẹn thất bại! " + ex.Message);
                }
            }       
        }
    }
}
