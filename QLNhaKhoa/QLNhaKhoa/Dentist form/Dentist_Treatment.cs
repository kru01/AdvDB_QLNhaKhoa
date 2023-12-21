using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Treatment : Form
    {
        private readonly string query = "select * from KEHOACHDIEUTRI";
        private static Dentist_AddTreatment f;

        public Dentist_Treatment()
        {
            InitializeComponent();
        }

        private void Dentist_Treatment_Load(object sender, EventArgs e)
        {
            planData.DataSource = Helper.getData(query).Tables[0];

            cboDentist.DisplayMember = "HOTEN";
            cboDentist.ValueMember = "IDTAIKHOAN";
            cboDentist.DataSource = Helper.getData("select IDTAIKHOAN, HOTEN from TAIKHOAN where LOAITAIKHOAN = 1").Tables[0];

            cboAssistant.DisplayMember = "HOTEN";
            cboAssistant.ValueMember = "IDTAIKHOAN";
            cboAssistant.DataSource = Helper.getData("select IDTAIKHOAN, HOTEN from TAIKHOAN where LOAITAIKHOAN = 1").Tables[0];

            cboTreatment.DisplayMember = "TENLIEUTRINH";
            cboTreatment.ValueMember = "IDLIEUTRINH";
            cboTreatment.DataSource = Helper.getData("select IDLIEUTRINH, TENLIEUTRINH from LIEUTRINH").Tables[0];
        }

        private void refresh()
        {
            Helper.refreshData(query, planData);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void planData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = planData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                IDBox.Text = dgvr.Cells["IDKEHOACH"].Value.ToString();
                if (dgvr.Cells["TRANGTHAIDIEUTRI"].Value.ToString() == "0")
                {
                    cboStatus.Text = "Kế hoạch";
                }
                else if (dgvr.Cells["TRANGTHAIDIEUTRI"].Value.ToString() == "1")
                {
                    cboStatus.Text = "Đã hoàn thành";
                }
                else cboStatus.Text = "Đã hủy";

                dateBox.Text = dgvr.Cells["NGAYDIEUTRI"].Value.ToString();
                desBox.Text = dgvr.Cells["MOTA"].Value.ToString();
                noteBox.Text = dgvr.Cells["GHICHU"].Value.ToString();

                SqlCommand cmd = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN = '" + dgvr.Cells["IDNHASI"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cboDentist.Text = reader.GetString(0);
                    }
                }

                SqlCommand cmd2 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN = '" + dgvr.Cells["IDTROKHAM"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cboAssistant.Text = reader.GetString(0);
                    }
                }

                SqlCommand cmd3 = new SqlCommand("select TENLIEUTRINH from LIEUTRINH where IDLIEUTRINH = '" + dgvr.Cells["IDLIEUTRINH"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd3.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cboTreatment.Text = reader.GetString(0);
                    }
                }

                SqlCommand cmd4 = new SqlCommand("select HOTEN from HOSOBENHNHAN where IDHOSO = '" + dgvr.Cells["IDHOSO"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd4.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nameBox.Text = reader.GetString(0);
                        sqlCon.Close();
                    }
                }
            }
        }

        private void addPlanButton_Click(object sender, EventArgs e)
        {
            f = new Dentist_AddTreatment();
            f.FormClosedEvent += DentistFormClosedEvent;
            f.Show();
        }

        private void DentistFormClosedEvent(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
