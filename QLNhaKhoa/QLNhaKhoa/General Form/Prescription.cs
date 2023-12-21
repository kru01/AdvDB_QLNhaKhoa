using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.General_Form
{
    public partial class Prescription : Form
    {
        private readonly string query = "select DISTINCT TT.*, T.TENTHUOC, KH.GHICHU " +
                                        "from TOATHUOC TT join KEHOACHDIEUTRI KH on TT.IDKEHOACH = KH.IDKEHOACH " +
                                        "join THUOC T on TT.IDTHUOC = T.IDTHUOC";
        private string idplan = string.Empty;
        private static AddPrescription f;
        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            prescriptionData.DataSource = Helper.getData(query).Tables[0];

            cboMed.DisplayMember = "TENTHUOC";
            cboMed.ValueMember = "IDTHUOC";
            cboMed.DataSource = Helper.getData("select IDTHUOC, TENTHUOC from THUOC").Tables[0];
            cboMed.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void prescriptionData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = prescriptionData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                quantityBox.Text = dgvr.Cells["SOLUONG"].Value.ToString();
                cboMed.Text = dgvr.Cells["TENTHUOC"].Value.ToString();
                recordIDBox.Text = dgvr.Cells["IDHOSO"].Value.ToString();
                noteBox.Text = dgvr.Cells["GHICHU"].Value.ToString();
                idplan = dgvr.Cells["IDKEHOACH"].Value.ToString();

                SqlCommand cmd1 = new SqlCommand("select HOTEN from HOSOBENHNHAN where IDHOSO='" + recordIDBox.Text + "'", sqlCon);
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nameBox.Text = reader.GetString(0);
                    }
                }
            }
        }

        private void quantityBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, prescriptionData);
        }

        private void updateBox_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_TOATHUOC_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var item = (DataRowView)cboMed.SelectedItem;
                cmd.Parameters.Add(new SqlParameter("@IDHOSO", recordIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@IDKEHOACH", idplan));
                cmd.Parameters.Add(new SqlParameter("@IDTHUOC", item["IDTHUOC"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", quantityBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật toa thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật toa thuốc thất bại!");
                }
                Helper.refreshData(query, prescriptionData);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật toa thuốc thất bại! " + ex.Message);
            }
        }

        private void addPreButton_Click(object sender, EventArgs e)
        {
            f = new AddPrescription();
            f.FormClosedEvent += FormClosedEvent;
            f.Show();
        }

        private void FormClosedEvent(object sender, EventArgs e)
        {
            Helper.refreshData(query, prescriptionData);
        }
    }
}
