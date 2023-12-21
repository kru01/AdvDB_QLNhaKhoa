using System.Data.SqlClient;

namespace QLNhaKhoa.General_Form
{
    public partial class Treatment : Form
    {
        private readonly string query = "select KH.*, LT.TENLIEUTRINH, HS.HOTEN" +
                                        "from KEHOACHDIEUTRI KH join LIEUTRINH LT on KH.IDLIEUTRINH = LT.IDLIEUTRINH " +
                                        "join HOSOBENHNHAN HS on HS.IDHOSO = KH.IDHOSO";
        public Treatment()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, planData);
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            planData.DataSource = Helper.getData(query).Tables[0];
        }

        private void planData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = planData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                IDBox.Text = dgvr.Cells["IDKEHOACH"].Value.ToString();
                nameBox.Text = dgvr.Cells["HOTEN"].Value.ToString();
                if (dgvr.Cells["TRANGTHAIDIEUTRI"].Value.ToString() == "0")
                {
                    statusBox.Text = "Kế hoạch";
                }
                else if (dgvr.Cells["TRANGTHAIDIEUTRI"].Value.ToString() == "1")
                {
                    statusBox.Text = "Đã hoàn thành";
                }
                else statusBox.Text = "Đã hủy";

                dateBox.Text = dgvr.Cells["NGAYDIEUTRI"].Value.ToString();
                desBox.Text = dgvr.Cells["MOTA"].Value.ToString();
                noteBox.Text = dgvr.Cells["GHICHU"].Value.ToString();

                SqlCommand cmd = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN = '" + dgvr.Cells["IDNHASI"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dentistBox.Text = reader.GetString(0);
                    }
                }

                SqlCommand cmd2 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN = '" + dgvr.Cells["IDTROKHAM"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        assistantBox.Text = reader.GetString(0);
                    }
                }


                SqlCommand cmd3 = new SqlCommand("select TENLIEUTRINH from LIEUTRINH where IDLIEUTRINH = '" + dgvr.Cells["IDLIEUTRINH"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd3.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        treatmentBox.Text = reader.GetString(0);
                        sqlCon.Close();
                    }
                }
            }
        }
    }
}
