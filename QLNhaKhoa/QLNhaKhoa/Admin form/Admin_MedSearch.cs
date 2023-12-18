using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_MedSearch : Form
    {
        public event EventHandler FormClosedEvent;
        private Admin_Medication f;
        public Admin_MedSearch(Admin_Medication f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình tỉm thuốc?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
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

        private void searchMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                int unit = 0;
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_THUOC_SEARCH", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                string? medID = medIDBox.Text;
                if (medIDBox.Text == "") medID = null;
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", medID));

                string? medName = medNameBox.Text;
                if (medNameBox.Text == "") medName = null;
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medName));

                if (cboUnit.Text == "")
                {
                    cmd.Parameters.Add(new SqlParameter("@DONVITINH", DBNull.Value));
                }
                else
                {
                    if (cboUnit.Text == "Gói")
                    {
                        unit = 1;
                    }
                    else if (cboUnit.Text == "Hộp")
                    {
                        unit = 2;
                    }
                    cmd.Parameters.Add(new SqlParameter("@DONVITINH", unit));
                }

                string? prescr = prescriptionBox.Text;
                if (prescriptionBox.Text == "") prescr = null;
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescr));

                string? instock = instockBox.Text;
                if (instockBox.Text == "") instock = null;
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instock));

                string? dateVal = expDateBox.Text;
                if (expDateBox.Value.Date <= DateTime.Today) dateVal = null;
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", dateVal));

                string? price = priceBox.Text;
                if (priceBox.Text == "") price = null;
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", price));

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    f.searchData = new DataTable();
                    adapter.Fill(f.searchData);
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                }
                this.Close();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm dữ liệu thuốc thất bại! " + ex.Message);
            }
        }
    }
}