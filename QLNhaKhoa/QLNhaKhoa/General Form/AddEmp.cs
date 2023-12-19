using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.General_Form
{
    public partial class AddEmp : Form
    {
        public event EventHandler FormClosedEvent;

        public AddEmp()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình thêm nhân viên?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void AddEmpButton_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||
                txtPhone.Text == "" ||
                txtAddress.Text == "" ||
                txtEmail.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_TAIKHOAN_INS", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int gender = 0, empType = 0;
                    if (cboGender.Text == "Female")
                    {
                        gender = 1;
                    }
                    if (cboEmpType.Text == "Dentist")
                    {
                        empType = 1;
                    }
                    cmd.Parameters.Add(new SqlParameter("@TENDANGNHAP", txtUsername.Text));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtPassword.Text));
                    cmd.Parameters.Add(new SqlParameter("@LOAITAIKHOAN", empType));
                    cmd.Parameters.Add(new SqlParameter("@HOTEN", txtName.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYSINH", txtBday.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIOITINH", gender));
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@SDT", txtPhone.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", txtAddress.Text));

                    cmd.Parameters.Add("@IDTAIKHOAN", SqlDbType.Char, 7).Direction = ParameterDirection.Output;
                    int i = cmd.ExecuteNonQuery();
                    string userID = (string)cmd.Parameters["@IDTAIKHOAN"].Value;
                    if (i > 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công! Mã của nhân viên đó là " + userID);
                        FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thất bại!");
                    }
                    sqlCon.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tạo tài khoản thất bại! " + ex.Message);
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
