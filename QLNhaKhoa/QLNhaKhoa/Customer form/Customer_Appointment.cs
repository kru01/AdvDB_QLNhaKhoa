using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.General_form
{
    public partial class Customer_Appointment : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public Customer_Appointment()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            Helper.refreshData("select * from LICHHEN where MAKHACHHANG='" + CurrentUser + "'", appointmentData);
        }
        private void Appointment_Load(object sender, EventArgs e)
        {
            string appointment_query = "select * from LICHHEN where MAKHACHHANG='" + CurrentUser + "'";
            string dentist_query = "select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 1";
            appointmentData.DataSource = Helper.getData(appointment_query).Tables[0];

            cboDentists.DisplayMember = "HOTEN";
            cboDentists.ValueMember = "MANHANVIEN";
            cboDentists.DataSource = Helper.getData(dentist_query).Tables[0];
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
                    appointTime.Text = hour + ":" + minutes;
                    appointDate.Text = dgvr.Cells["NGAY"].Value.ToString();
                    appIDBox.Text = dgvr.Cells["MALICHHEN"].Value.ToString();
                    empIDBox.Text = dgvr.Cells["MANVDATLICH"].Value.ToString();

                    SqlCommand cmd = new SqlCommand("select HOTEN from NHANVIEN where MANHANVIEN='" + dgvr.Cells["MANHASI"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cboDentists.Text = reader.GetString(0);
                        }
                    }
                }
                sqlCon.Close();
            }
        }
        private void makeAppointBtn_Click(object sender, EventArgs e)
        {
            string[] parts = appointTime.Text.Split(":");
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

                    var item = (DataRowView)cboDentists.SelectedItem;
                    cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIO", time));
                    cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", CurrentUser));
                    cmd.Parameters.Add(new SqlParameter("@MANHASI", item["MANHANVIEN"].ToString()));
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
                    refresh();
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đặt lịch hẹn thất bại! " + ex.Message);
                }
            }
        }
        private void updateAppButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = appointTime.Text.Split(":");
                int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
                if (time < 480 || time > 1020)
                {
                    MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
                }

                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_LICHHEN_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var item = (DataRowView)cboDentists.SelectedItem;
                cmd.Parameters.Add(new SqlParameter("@MALICHHEN", appIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                cmd.Parameters.Add(new SqlParameter("@GIO", time));
                cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", CurrentUser));
                cmd.Parameters.Add(new SqlParameter("@MANHASI", item["MANHANVIEN"].ToString()));
                if (!string.IsNullOrEmpty(empIDBox.Text))
                {
                    cmd.Parameters.Add(new SqlParameter("@MANVDATLICH", empIDBox.Text));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@MANVDATLICH", DBNull.Value));
                }
                cmd.Parameters.Add(new SqlParameter("@NGUOIUPDATE", CurrentUser));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Đặt lịch hẹn thành công");
                }
                else
                {
                    MessageBox.Show("Đặt lịch hẹn thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật lịch hẹn thất bại! " + ex.Message);
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
