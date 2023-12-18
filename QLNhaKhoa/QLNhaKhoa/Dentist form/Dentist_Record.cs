using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            string record_query = "select * from HOSOBENHNHAN";
            recordData.DataSource = Helper.getData(record_query).Tables[0];


        }

        private void refresh()
        {
            Helper.refreshData("select * from HOSOBENHNHAN", recordData);
        }

        private void recordData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = recordData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                recordIDBox.Text = dgvr.Cells["IDHOSO"].Value.ToString();
                textBox_Name.Text = dgvr.Cells["HOTEN"].Value.ToString();
                dateTimePicker_DoB.Text = dgvr.Cells["NGAYSINH"].Value.ToString();
                textBox_Email.Text = dgvr.Cells["EMAIL"].Value.ToString();
                textBox_PhoneNumber.Text = dgvr.Cells["SDT"].Value.ToString();
                textBox_Address.Text = dgvr.Cells["DIACHI"].Value.ToString();
                textBox_GeneralInformation.Text = dgvr.Cells["THONGTINTONGQUAN"].Value.ToString();
                textBox_TotalCost.Text = dgvr.Cells["TONGTIENDIEUTRI"].Value.ToString();
                textBox_PaidAmount.Text = dgvr.Cells["TONGTIENDATHANHTOAN"].Value.ToString();
                if (dgvr.Cells["GIOITINH"].Value.ToString().Equals("1"))
                {
                    textBox_Gender.Text = "Nam";
                }
                else
                {
                    textBox_Gender.Text = "Nữ";
                    //textBox_Gender.Text = dgvr.Cells["NGAYSINH"].Value.ToString();
                }
                //SqlCommand cmd1 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN='" + CurrentDentist + "'", sqlCon);
                //SqlCommand cmd2 = new SqlCommand("select HOTEN from HOSOBENHNHAN where IDHOSO='" + dgvr.Cells["IDHOSO"].Value.ToString() + "'", sqlCon);
                //using (SqlDataReader reader = cmd1.ExecuteReader())
                //{
                //    if (reader.Read())
                //    {
                //        
                //    }
                //}
                //using (SqlDataReader reader = cmd2.ExecuteReader())
                //{
                //    if (reader.Read())
                //    {
                //        cboCustomer.Text = reader.GetString(0);
                //    }
                //}
                sqlCon.Close();
            }
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_HOSOBENHNHAN_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@HOTEN", textBox_Name.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", dateTimePicker_DoB.Value.ToShortDateString()));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", textBox_Email.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", textBox_PhoneNumber.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", textBox_Address.Text));
                cmd.Parameters.Add(new SqlParameter("@THONGTINTONGQUAN", textBox_GeneralInformation.Text));
                int gender;
                if (textBox_Gender.Text.Equals("Nam"))
                {
                    gender = 1;
                }
                else { gender = 0; }
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", gender.ToString()));

                cmd.Parameters.Add("@IDHOSO", SqlDbType.VarChar, 7).Direction = ParameterDirection.Output;
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
                SqlCommand cmd = new SqlCommand("delete from HOSOBENHNHAN where IDHOSO='" + recordIDBox.Text + "'", sqlCon);
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

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_HOSOBENHNHAN_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@HOTEN", textBox_Name.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", dateTimePicker_DoB.Value.ToShortDateString()));
                cmd.Parameters.Add(new SqlParameter("@IDHOSO", recordIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", textBox_Email.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", textBox_PhoneNumber.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", textBox_Address.Text));
                cmd.Parameters.Add(new SqlParameter("@THONGTINTONGQUAN", textBox_GeneralInformation.Text));
                int gender;
                if (textBox_Gender.Text.Equals("Nam"))
                {
                    gender = 1;
                }
                else { gender = 0; }
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", gender.ToString()));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật hồ sơ thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật hồ sơ thất bại!");
                }
                Helper.refreshData("select * from HOSOBENHNHAN", recordData);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật hồ sơ thất bại! " + ex.Message);
            }
        }
    }
}
