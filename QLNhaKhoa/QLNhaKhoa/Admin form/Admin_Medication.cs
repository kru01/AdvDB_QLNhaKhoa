using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_Medication : Form
    {
        private Admin_Medication_AddForm f;
        private Admin_MedSearch fs;
        public DataTable searchData;
        public Admin_Medication()
        {
            InitializeComponent();
        }

        private void instockBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void refresh()
        {
            Helper.refreshData("select * from THUOC", medData);
        }

        private void Admin_Medication_Load(object sender, EventArgs e)
        {
            medData.DataSource = Helper.getData("select * from THUOC").Tables[0];
        }

        private void medData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = medData.Rows[e.RowIndex];
                medIDBox.Text = dgvr.Cells["IDTHUOC"].Value.ToString();
                medNameBox.Text = dgvr.Cells["TENTHUOC"].Value.ToString();
                prescribeBox.Text = dgvr.Cells["CHIDINH"].Value.ToString();
                instockBox.Text = dgvr.Cells["SOLUONGTONKHO"].Value.ToString();
                expDateBox.Text = dgvr.Cells["NGAYHETHAN"].Value.ToString();
                priceBox.Text = dgvr.Cells["GIATIEN"].Value.ToString();
                if (dgvr.Cells["DONVITINH"].Value.ToString() == "0")
                {
                    cboUnit.Text = "Viên";
                }
                if (dgvr.Cells["DONVITINH"].Value.ToString() == "1")
                {
                    cboUnit.Text = "Gói";
                }
                else cboUnit.Text = "Hộp";
            }
        }

        private void addMedButton_Click(object sender, EventArgs e)
        {
            f = new Admin_Medication_AddForm();
            f.FormClosedEvent += AdminFormClosedEvent;
            f.Show();
        }
        private void AdminFormClosedEvent(object sender, EventArgs e)
        {
            refresh();
        }

        private void deleteMedButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa loại thuốc này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                if (medIDBox.Text == "")
                {
                    MessageBox.Show("Không có dữ liệu thuốc để xóa!");
                }
                else
                {
                    try
                    {
                        SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("delete from THUOC where IDTHUOC='" + medIDBox.Text + "'", sqlCon);
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thuốc thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa dữ liệu thuốc thất bại!");
                        }
                        refresh();
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa dữ liệu thuốc thất bại! " + ex.Message);
                    }
                }
            }
            else { }
        }

        private void updateMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_THUOC_UPD", sqlCon);
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
                cmd.Parameters.Add(new SqlParameter("@IDTHUOC", medIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", unit));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thuốc thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dữ liệu thuốc thất bại! " + ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            fs = new Admin_MedSearch(this);
            fs.FormClosedEvent += AdminFormClosedEventS;
            fs.Show();
        }

        private void AdminFormClosedEventS(object sender, EventArgs e)
        {
            medData.DataSource = searchData;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
