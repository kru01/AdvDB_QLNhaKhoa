using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class AddRecord : Form
    {
        public event EventHandler FormClosedEvent;
        public AddRecord()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình thêm hồ sơ bệnh nhân?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                int gender;
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_HOSOBENHNHAN_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bdayBox.Text));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", emailBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", phoneBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox.Text));
                if (infoBox.Text == "")
                {
                    cmd.Parameters.Add(new SqlParameter("@THONGTINTONGQUAN", DBNull.Value));
                }
                else cmd.Parameters.Add(new SqlParameter("@THONGTINTONGQUAN", infoBox.Text));

                if (cboGender.Text.Equals("Nam"))
                {
                    gender = 1;
                }
                else { gender = 0; }
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", gender));
                cmd.Parameters.Add("@IDHOSO", SqlDbType.VarChar, 7).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm hồ sơ bệnh án thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Thêm hồ sơ bệnh án thất bại!");
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hồ sơ bệnh án thất bại! " + ex.Message);
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
    }
}
