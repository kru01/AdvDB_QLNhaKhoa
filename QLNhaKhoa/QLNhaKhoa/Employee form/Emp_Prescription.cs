using System.Data;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Prescription : Form
    {
        private static string query = "select TT.*, T.TENTHUOC, KH.GHICHU " +
                                      "from TOATHUOC TT join KEHOACHDIEUTRI KH on TT.IDKEHOACH = KH.IDKEHOACH " +
                                      "join THUOC T on TT.IDTHUOC = T.IDTHUOC";
        public Emp_Prescription()
        {
            InitializeComponent();
        }

        private void Emp_Prescription_Load(object sender, EventArgs e)
        {
            prescriptionData.DataSource = Helper.getData(query).Tables[0];
        }

        private void prescriptionData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = prescriptionData.Rows[e.RowIndex];
                medicationIDBox.Text = dgvr.Cells["MATHUOC"].Value.ToString();
                quantityBox.Text = dgvr.Cells["SOLUONG"].Value.ToString();
                medNameBox.Text = dgvr.Cells["TENTHUOC"].Value.ToString();
                recordIDBox.Text = dgvr.Cells["MAHSBA"].Value.ToString();
                certificateIDBox.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, prescriptionData);
        }
    }
}
