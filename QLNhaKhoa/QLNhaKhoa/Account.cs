using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaKhoa
{
    public partial class Account : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public string CurrentUsername { get; set; } = string.Empty;
        public Account()
        {
            InitializeComponent();
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

        private void Account_Load(object sender, EventArgs e)
        {
            string query = "select HOTEN,NGAYSINH,DIACHI,SDT,GIOITINH,EMAIL from TAIKHOAN where IDTAIKHOAN='" + CurrentUser + "'";
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    bdayBox.Text = reader["NGAYSINH"].ToString();
                    nameBox.Text = reader["HOTEN"].ToString();
                    addressBox.Text = reader["DIACHI"].ToString();
                    phoneBox.Text = reader["SDT"].ToString();
                    emailBox.Text = reader["EMAIL"].ToString();
                    if (reader["GIOITINH"].ToString() == "1")
                    {
                        cboGender.Text = "Nữ";
                    }
                    else cboGender.Text = "Nam";
                    passwordBox.Text = CurrentPass;
                    IDBox.Text = CurrentUser;
                    sqlCon.Close();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string CurrentUserTrim = CurrentUser.Trim();
            int empType = 0, gender = 0;

            if (CurrentUserTrim.StartsWith("NS"))
            {
                empType = 1;
            }
            else if (CurrentUserTrim.StartsWith("AD"))
            {
                empType = 2;
            }
            if (cboGender.Text == "Nữ")
            {
                gender = 1;
            }
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_TAIKHOAN_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IDTAIKHOAN", CurrentUser));
                cmd.Parameters.Add(new SqlParameter("@TENDANGNHAP", CurrentUsername));
                cmd.Parameters.Add(new SqlParameter("@MATKHAU", passwordBox.Text));
                cmd.Parameters.Add(new SqlParameter("LOAITAIKHOAN", empType));
                cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bdayBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", gender));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", emailBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", phoneBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox.Text));

                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại! " + ex.Message);
            }
        }
    }
}
