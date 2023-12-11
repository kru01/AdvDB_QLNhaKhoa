using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Certificate : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Certificate()
        {
            InitializeComponent();
        }

        private void Dentist_Certificate_Load(object sender, EventArgs e)
        {
            certificateData.DataSource = Helper.getData("select * from GIAYKHAMBENH").Tables[0];

            cboRecord.DisplayMember = "MAHSBA";
            cboRecord.ValueMember = "MAHSBA";
            cboRecord.DataSource = Helper.getData("select MAHSBA from HOSOBENHAN").Tables[0];
        }

        private void refresh()
        {
            Helper.refreshData("select * from GIAYKHAMBENH", certificateData);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void certificateData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = certificateData.Rows[e.RowIndex];
                certificateIDBox.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();
                examDateBox.Text = dgvr.Cells["NGAYKHAM"].Value.ToString();
                cboRecord.Text = dgvr.Cells["MAHSBA"].Value.ToString();
            }
        }

        private void addCertButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_GIAYKHAMBENH_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MAHSBA", cboRecord.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYKHAM", examDateBox.Text));

                cmd.Parameters.Add("@MAGIAYKHAMBENH", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm giấy khám bệnh thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm giấy khám bệnh thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm giấy khám bệnh thất bại! " + ex.Message);
            }
        }
    }
}
