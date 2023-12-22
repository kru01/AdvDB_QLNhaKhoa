using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_AddTreatment : Form
    {
        public event EventHandler FormClosedEvent;
        public Dentist_AddTreatment()
        {
            InitializeComponent();
        }

        private void Dentist_AddTreatment_Load(object sender, EventArgs e)
        {
            cboName.DisplayMember = "HOTEN";
            cboName.ValueMember = "IDHOSO";
            cboName.DataSource = Helper.getData("select IDHOSO, HOTEN from HOSOBENHNHAN").Tables[0];

            cboDentist.DisplayMember = "HOTEN";
            cboDentist.ValueMember = "IDTAIKHOAN";
            cboDentist.DataSource = Helper.getData("select IDTAIKHOAN, HOTEN from TAIKHOAN where LOAITAIKHOAN = 1").Tables[0];

            cboAssistant.DisplayMember = "HOTEN";
            cboAssistant.ValueMember = "IDTAIKHOAN";
            cboAssistant.DataSource = Helper.getData("select IDTAIKHOAN, HOTEN from TAIKHOAN where LOAITAIKHOAN = 1").Tables[0];

            cboTreatment.DisplayMember = "TENLIEUTRINH";
            cboTreatment.ValueMember = "IDLIEUTRINH";
            cboTreatment.DataSource = Helper.getData("select IDLIEUTRINH, TENLIEUTRINH from LIEUTRINH").Tables[0];

            cboTooth.DisplayMember = "TENRANG";
            cboTooth.ValueMember = "IDRANG";
            cboTooth.DataSource = Helper.getData("select IDRANG, CONCAT(TENRANG, ' - ', CAST(VITRI AS NVARCHAR(2))) AS 'TENRANG' from RANG").Tables[0];

            cboTSurface.DisplayMember = "TENBEMAT";
            cboTSurface.ValueMember = "IDBEMAT";
            cboTSurface.DataSource = Helper.getData("select IDBEMAT, TENBEMAT from BEMATRANG").Tables[0];
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình tạo kế hoạch điều trị?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void addTreatmentButton_Click(object sender, EventArgs e)
        {
            string record_id = ((DataRowView)cboName.SelectedItem)["IDHOSO"].ToString();
            string dentist_id = ((DataRowView)cboDentist.SelectedItem)["IDTAIKHOAN"].ToString();
            string assistant_id = ((DataRowView)cboAssistant.SelectedItem)["IDTAIKHOAN"].ToString();
            string treatment_id = ((DataRowView)cboTreatment.SelectedItem)["IDLIEUTRINH"].ToString();
            string tooth = ((DataRowView)cboTooth.SelectedItem)["IDRANG"].ToString();
            string tooth_surface = ((DataRowView)cboTSurface.SelectedItem)["IDBEMAT"].ToString();
            int payment = 0;
            if (cboPayment.Text == "Online")
            {
                payment = 1;
            }
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_KEHOACHDIEUTRI_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IDHOSO", record_id));
                cmd.Parameters.Add(new SqlParameter("@MOTA", descriptionBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYDIEUTRI", dateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GHICHU", noteBox.Text));
                cmd.Parameters.Add(new SqlParameter("@LOAITHANHTOAN", payment));
                cmd.Parameters.Add(new SqlParameter("@IDNHASI", dentist_id));
                cmd.Parameters.Add(new SqlParameter("@IDTROKHAM", assistant_id));
                cmd.Parameters.Add(new SqlParameter("@IDLIEUTRINH", treatment_id));
                cmd.Parameters.Add("@IDKEHOACH", SqlDbType.Char, 7).Direction = ParameterDirection.Output;

                int i1 = cmd.ExecuteNonQuery();
                string planid = (string)cmd.Parameters["@IDKEHOACH"].Value;

                addToothTreatment(record_id, planid, tooth, tooth_surface);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đặt lịch hẹn thất bại! " + ex.Message);
            }
        }

        private void addToothTreatment(string record_id, string planid, string tooth, string tooth_surface)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd2 = new SqlCommand("USP_CHITIETRANG_INS", sqlCon);
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add(new SqlParameter("@IDHOSO", record_id));
                cmd2.Parameters.Add(new SqlParameter("@IDKEHOACH", planid));
                cmd2.Parameters.Add(new SqlParameter("@IDRANG", tooth));
                cmd2.Parameters.Add(new SqlParameter("@IDBEMAT", tooth_surface));

                int i = cmd2.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Đặt lịch hẹn thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Đặt lịch hẹn thất bại!");
                }
                sqlCon.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đặt lịch hẹn thất bại! " + ex.Message);
            }
        }
    }
}
