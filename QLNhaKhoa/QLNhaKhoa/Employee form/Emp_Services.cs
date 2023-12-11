using System.Data;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Services : Form
    {
        private static string query = "select DVK.MADICHVU, DVK.TENDICHVU, DVK.GIATIEN " +
                                      "from DICHVUSUDUNG AS DVSD, DICHVUKHAM AS DVK " +
                                      "where DVSD.MADICHVU = DVK.MADICHVU";
        public Emp_Services()
        {
            InitializeComponent();
        }

        private void Emp_Services_Load(object sender, EventArgs e)
        {
            serviceData.DataSource = Helper.getData(query).Tables[0];
        }

        private void serviceData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = serviceData.Rows[e.RowIndex];
                servicesIDBox.Text = dgvr.Cells["MADICHVU"].Value.ToString();
                priceBox.Text = dgvr.Cells["GIATIEN"].Value.ToString();
                serviceNameBox.Text = dgvr.Cells["TENDICHVU"].Value.ToString();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, serviceData);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            (serviceData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MADICHVU like '%" + searchIDBox.Text + "%'");
        }
    }
}
