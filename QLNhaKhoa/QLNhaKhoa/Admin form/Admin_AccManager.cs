using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_AccManager : Form
    {
        private static string query = "select * from NHANVIEN";
        public string CurrentAdmin { get; set; } = string.Empty;
        public Admin_AccManager()
        {
            InitializeComponent();
        }

        private void Admin_AccManager_Load(object sender, EventArgs e)
        {
            accountData.DataSource = Helper.getData(query).Tables[0];
        }

        private void accountData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = accountData.Rows[e.RowIndex];
                IDBox.Text = dgvr.Cells["MANHANVIEN"].Value.ToString();
                passwordBox.Text = dgvr.Cells["MATKHAU"].Value.ToString();
                bdayBox.Text = dgvr.Cells["NGAYSINH"].Value.ToString();
                nameBox.Text = dgvr.Cells["HOTEN"].Value.ToString();
                addressBox.Text = dgvr.Cells["DIACHI"].Value.ToString();
                phoneBox.Text = dgvr.Cells["SODT"].Value.ToString();

                if (dgvr.Cells["LOAINHANVIEN"].Value.ToString() == "0")
                {
                    cboEmpType.Text = "Employee";
                }
                else if (dgvr.Cells["LOAINHANVIEN"].Value.ToString() == "1")
                {
                    cboEmpType.Text = "Dentist";
                }
                else if (dgvr.Cells["LOAINHANVIEN"].Value.ToString() == "2")
                {
                    cboEmpType.Text = "Admin";
                }
            }
        }

        private void createAccButton_Click(object sender, EventArgs e)
        {
            try
            {
                int empType = 0;
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_NHANVIEN_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bdayBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SODT", phoneBox.Text));
                if (cboEmpType.Text == "Dentist")
                {
                    empType = 1;
                }
                else if (cboEmpType.Text == "Admin")
                {
                    empType = 2;
                }
                cmd.Parameters.Add(new SqlParameter("@LOAINHANVIEN", empType));
                cmd.Parameters.Add(new SqlParameter("@MATKHAU", passwordBox.Text));

                cmd.Parameters.Add("@MANHANVIEN", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại!");
                }
                Helper.refreshData(query, accountData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo tài khoản thất bại! " + ex);
            }
        }
        private void updateAccButton_Click(object sender, EventArgs e)
        {
            try
            {
                int empType = 0;
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_NHANVIEN_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MANHANVIEN", IDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bdayBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SODT", phoneBox.Text));
                if (cboEmpType.Text == "Dentist")
                {
                    empType = 1;
                }
                else if (cboEmpType.Text == "Admin")
                {
                    empType = 2;
                }
                cmd.Parameters.Add(new SqlParameter("@LOAINHANVIEN", empType));
                cmd.Parameters.Add(new SqlParameter("@MATKHAU", passwordBox.Text));

                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại!");
                }
                Helper.refreshData(query, accountData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tài khoản thất bại! " + ex);
            }
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void deleteAccButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa tài khoản này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("delete from NHANVIEN where MANHANVIEN='" + IDBox.Text + "'", sqlCon);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!");
                }
                Helper.refreshData(query, accountData);
                sqlCon.Close();
            }
            else { }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, accountData);
        }
    }
}
