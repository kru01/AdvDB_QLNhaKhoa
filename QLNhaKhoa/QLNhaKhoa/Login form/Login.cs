using System.Data;
using System.Data.SqlClient;
using QLNhaKhoa.Employee_form;
using QLNhaKhoa.Dentist_form;
using QLNhaKhoa.Admin_form;

namespace QLNhaKhoa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
            txtUsername.Focus();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                loginButton.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtUsername.Focus();
            }
        }
        private void registerSwap_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_MISC_LOGIN", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@TENDANGNHAP", txtUsername.Text));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtPassword.Text));

                    cmd.Parameters.Add("@LOAITAIKHOAN", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IDTAIKHOAN", SqlDbType.Char, 7).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    int user_type = (int)cmd.Parameters["@LOAITAIKHOAN"].Value;
                    string user_id = (string)cmd.Parameters["@IDTAIKHOAN"].Value;
                    if (user_type == 0)
                    {
                        Emp_Main f = new Emp_Main();
                        f.CurrentEmp = user_id;
                        f.CurrentPass = txtPassword.Text;
                        f.CurrentUsername = txtUsername.Text;
                        f.Show();
                        this.Hide();
                    }
                    else if (user_type == 1)
                    {
                        Dentist_Main f = new Dentist_Main();
                        f.CurrentDentist = user_id;
                        f.CurrentPass = txtPassword.Text;
                        f.CurrentUsername = txtUsername.Text;
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        Admin_Main f = new Admin_Main();
                        f.CurrentAdmin = user_id;
                        f.CurrentPass = txtPassword.Text;
                        f.CurrentUsername = txtUsername.Text;
                        f.Show();
                        this.Hide(); ;
                    }
                    sqlCon.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        }
    }
}