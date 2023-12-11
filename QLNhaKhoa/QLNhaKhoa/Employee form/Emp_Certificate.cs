using System.Data;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Certificate : Form
    {
        private int nRow;
        public Emp_Certificate()
        {
            InitializeComponent();
        }

        private void Emp_Certificate_Load(object sender, EventArgs e)
        {
            certificateData.DataSource = Helper.getData("select * from GIAYKHAMBENH").Tables[0];
            nRow = certificateData.CurrentCell.RowIndex;
        }

        private void certificateData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = certificateData.Rows[e.RowIndex];
                certificateIDBox.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();
                recordIDBox.Text = dgvr.Cells["MAHSBA"].Value.ToString();
                examDateBox.Text = dgvr.Cells["NGAYKHAM"].Value.ToString();
                medTotalBox.Text = dgvr.Cells["TONGTIENTHUOC"].Value.ToString();
                serviceTotalBox.Text = dgvr.Cells["TONGTIENDICHVU"].Value.ToString();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from GIAYKHAMBENH", certificateData);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            (certificateData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MAGIAYKHAMBENH like '%" + searchIDBox.Text + "%'");
        }
    }
}
