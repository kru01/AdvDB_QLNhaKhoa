using System.Data;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Medication : Form
    {
        public Emp_Medication()
        {
            InitializeComponent();
        }

        private void Emp_Medication_Load(object sender, EventArgs e)
        {
            medData.DataSource = Helper.getData("select * from THUOC").Tables[0];
        }

        private void medData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = medData.Rows[e.RowIndex];
                medIDBox.Text = dgvr.Cells["MATHUOC"].Value.ToString();
                medNameBox.Text = dgvr.Cells["TENTHUOC"].Value.ToString();
                unitBox.Text = dgvr.Cells["DONVITINH"].Value.ToString();
                prescriptionBox.Text = dgvr.Cells["CHIDINH"].Value.ToString();
                instockBox.Text = dgvr.Cells["SOLUONGTONKHO"].Value.ToString();
                expDateBox.Text = dgvr.Cells["NGAYHETHAN"].Value.ToString();
                priceBox.Text = dgvr.Cells["GIATIEN"].Value.ToString();
                empIDBox.Text = dgvr.Cells["MANVQUANLY"].Value.ToString();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from THUOC", medData);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            (medData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MATHUOC like '%" + searchIDBox.Text + "%'");
        }
    }
}
