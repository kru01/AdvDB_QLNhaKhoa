using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_record : Form
    {
        private string query = "select * from HOSOBENHNHAN";

        public Admin_record()
        {
            InitializeComponent();
        }

        private void Admin_record_Load(object sender, EventArgs e)
        {
            recordData.DataSource = Helper.getData(query).Tables[0];
        }

        private void recordData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = recordData.Rows[e.RowIndex];
                IDBox.Text = dgvr.Cells["IDHOSO"].Value.ToString();
                phoneBox.Text = dgvr.Cells["SDT"].Value.ToString();
                addressBox.Text = dgvr.Cells["SDT"].Value.ToString();
                emailBox.Text = dgvr.Cells["EMAIL"].Value.ToString();
                nameBox.Text = dgvr.Cells["HOTEN"].Value.ToString();
                bdayBox.Text = dgvr.Cells["NGAYSINH"].Value.ToString();
                costBox.Text = dgvr.Cells["TONGTIENDIEUTRI"].Value.ToString();
                paidBox.Text = dgvr.Cells["TONGTIENDATHANHTOAN"].Value.ToString();
                infoBox.Text = dgvr.Cells["THONGTINTONGQUAN"].Value.ToString();
                if (dgvr.Cells["GIOITINH"].Value.ToString() == "0")
                {
                    cboGender.Text = "Male";
                }
                else cboGender.Text = "Female";
                ageBox.Text = (DateTime.Now.Year - ((DateTime)dgvr.Cells["NGAYSINH"].Value).Year).ToString();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, this.recordData);
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                int gender = 0;
                if (cboGender.Text == "Female")
                {
                    gender = 1;
                }

                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_HOSOBENHNHAN_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IDHOSO", IDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bdayBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", gender));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", emailBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", phoneBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox));
                cmd.Parameters.Add(new SqlParameter("@THONGTINTONGQUAN", infoBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật hồ sơ bệnh nhân thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật hồ sơ bệnh nhân thất bại!");
                }
                sqlCon.Close();
                Helper.refreshData(query, recordData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật hồ sơ bệnh nhân thất bại! " + ex.Message);
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
