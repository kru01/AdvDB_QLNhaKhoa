using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Record : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Record()
        {
            InitializeComponent();
        }

        private void Dentist_Record_Load(object sender, EventArgs e)
        {
            string record_query = "select * from HOSOBENHAN where MANHASI='" + CurrentDentist + "'";
            recordData.DataSource = Helper.getData(record_query).Tables[0];

            cboCustomer.DisplayMember = "HOTEN";
            cboCustomer.ValueMember = "MAKHACHHANG";
            cboCustomer.DataSource = Helper.getData("select HOTEN, MAKHACHHANG from KHACHHANG").Tables[0];
        }

        private void refresh()
        {
            Helper.refreshData("select * from HOSOBENHAN where MANHASI='" + CurrentDentist + "'", recordData);
        }

        private void recordData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = recordData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                recordIDBox.Text = dgvr.Cells["MAHSBA"].Value.ToString();

                SqlCommand cmd1 = new SqlCommand("select HOTEN from NHANVIEN where MANHANVIEN='" + CurrentDentist + "'", sqlCon);
                SqlCommand cmd2 = new SqlCommand("select HOTEN from KHACHHANG where MAKHACHHANG='" + dgvr.Cells["MAKHACHHANG"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dentistNameBox.Text = reader.GetString(0);
                    }
                }
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cboCustomer.Text = reader.GetString(0);
                    }
                }
                sqlCon.Close();
            }
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_HSBA_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var item = (DataRowView)cboCustomer.SelectedItem;
                cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", item["MAKHACHHANG"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@MANHASI", CurrentDentist));

                cmd.Parameters.Add("@MAHSBA", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm hồ sơ bệnh án thành công!");
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
                MessageBox.Show("Thêm hồ sơ bệnh án thất bại! " + ex.Message);
            }
        }

        private void deleteRecordButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa hồ sơ bệnh án này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("delete from HOSOBENHAN where MAHSBA='" + recordIDBox.Text + "'", sqlCon);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa hồ sơ bệnh án thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa hồ sơ bệnh án thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            else { }
        }
    }
}
