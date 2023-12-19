using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_AddMed : Form
    {
        public event EventHandler FormClosedEvent;

        public Admin_AddMed()
        {
            InitializeComponent();
        }

        private void AddMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_THUOC_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                int unit = 0; // 0: Viên, 1: Hộp, 2: Gói
                if (cboUnit.Text == "Gói")
                {
                    unit = 1;
                }
                else if (cboUnit.Text == "Gói")
                {
                    unit = 2;
                }
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", unit));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));

                cmd.Parameters.Add("@IDTHUOC", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thất bại!");
                }
                sqlCon.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thuốc thất bại! " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình thêm thuốc?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }
    }
}
