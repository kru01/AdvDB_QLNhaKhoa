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
            this.ActiveControl = txtID;
            txtID.Focus();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                txtID.Focus();
            }
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void registerSwap_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_MISC_LOGIN", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@MAUSER", txtID.Text));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtPassword.Text));

                    cmd.Parameters.Add("@LOAIUSER", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    int user_type = (int)cmd.Parameters["@LOAIUSER"].Value;
                    if (user_type == -1)
                    {
                        Customer_Main f = new Customer_Main();
                        f.CurrentUser = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide();
                    }
                    else if (user_type == 0)
                    {
                        Emp_Main f = new Emp_Main();
                        f.CurrentEmp = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide();
                    }
                    else if (user_type == 1)
                    {
                        Dentist_Main f = new Dentist_Main();
                        f.CurrentDentist = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        Admin_Main f = new Admin_Main();
                        f.CurrentAdmin = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide(); ;
                    }
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID hoặc mật khẩu sai! " + ex.Message);
                }
            }
        }
    }
}