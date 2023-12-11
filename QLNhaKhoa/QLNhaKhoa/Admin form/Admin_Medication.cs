using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_Medication : Form
    {
        public string CurrentAdmin { get; set; } = string.Empty;
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
            Helper.refreshData("select * from THUOC where MANVQUANLY='" + CurrentAdmin + "'", medData);
        }

        private void Admin_Medication_Load(object sender, EventArgs e)
        {
            string med_query = "select * from THUOC where MANVQUANLY='" + CurrentAdmin + "'";
            string admin_query = "select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 2";
            medData.DataSource = Helper.getData(med_query).Tables[0];

            cboEmp.DisplayMember = "HOTEN";
            cboEmp.ValueMember = "MANHANVIEN";
            cboEmp.DataSource = Helper.getData(admin_query).Tables[0];
        }

        private void medData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = medData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();

                medIDBox.Text = dgvr.Cells["MATHUOC"].Value.ToString();
                cboUnit.Text = dgvr.Cells["DONVITINH"].Value.ToString();
                instockBox.Text = dgvr.Cells["SOLUONGTONKHO"].Value.ToString();
                medNameBox.Text = dgvr.Cells["TENTHUOC"].Value.ToString();
                priceBox.Text = dgvr.Cells["GIATIEN"].Value.ToString();
                expDateBox.Text = dgvr.Cells["NGAYHETHAN"].Value.ToString();
                prescribeBox.Text = dgvr.Cells["CHIDINH"].Value.ToString();

                SqlCommand cmd = new SqlCommand("select HOTEN from NHANVIEN where MANHANVIEN='" + dgvr.Cells["MANVQUANLY"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cboEmp.Text = reader.GetString(0);
                    }
                }
                sqlCon.Close();
            }
        }

        private void addMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_THUOC_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var item = (DataRowView)cboEmp.SelectedItem;
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", cboUnit.Text));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MANVQUANLY", item["MANHANVIEN"].ToString()));

                cmd.Parameters.Add("@MATHUOC", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thuốc thất bại! " + ex.Message);
            }

        }

        private void deleteMedButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa loại thuốc này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("delete from THUOC where MATHUOC='" + medIDBox.Text + "'", sqlCon);
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

                var item = (DataRowView)cboEmp.SelectedItem;
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", medIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", cboUnit.Text));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MANVQUANLY", item["MANHANVIEN"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@NGUOIUPDATE", CurrentAdmin));

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
            (medData.DataSource as DataTable).DefaultView.RowFilter = String.Format("TENTHUOC like '%" + searchIDBox.Text + "%'");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
