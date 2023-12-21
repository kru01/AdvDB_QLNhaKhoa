using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_AddAppointment : Form
    {
        public event EventHandler FormClosedEvent;
        public string CurrentEmp { get; set; } = string.Empty;
        public Emp_AddAppointment()
        {
            InitializeComponent();
        }

        private void Emp_AddAppointment_Load(object sender, EventArgs e)
        {
            string dentist = "select IDTAIKHOAN, HOTEN from TAIKHOAN where LOAITAIKHOAN=1";

            cboRoom.DisplayMember = "IDPHONGKHAM";
            cboRoom.ValueMember = "IDPHONGKHAM";
            cboRoom.DataSource = Helper.getData("select IDPHONGKHAM from PHONGKHAM").Tables[0];

            cboDentist.DisplayMember = "HOTEN";
            cboDentist.ValueMember = "IDTAIKHOAN";
            cboDentist.DataSource = Helper.getData(dentist).Tables[0];

            cboAssistant.DisplayMember = "HOTEN";
            cboAssistant.ValueMember = "IDTAIKHOAN";
            cboAssistant.DataSource = Helper.getData(dentist).Tables[0];

            cboName.DisplayMember = "HOTEN";
            cboName.ValueMember = "IDHOSO";
            cboName.DataSource = Helper.getData("select IDHOSO, HOTEN from HOSOBENHNHAN").Tables[0];
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình lập lịch hẹn?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void makeAppButton_Click(object sender, EventArgs e)
        {
            string[] parts = appointTime.Text.Split(":");
            int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
            string record_id = ((DataRowView)cboName.SelectedItem)["IDHOSO"].ToString();
            string dentist_id = ((DataRowView)cboDentist.SelectedItem)["IDTAIKHOAN"].ToString();
            string assistant_id = ((DataRowView)cboAssistant.SelectedItem)["IDTAIKHOAN"].ToString();
            if (time < 480 || time > 1020)
            {
                MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
            }
            else if (cboName.Text == "-- Chọn bệnh nhân --" ||
                    cboDentist.Text == "-- Chọn nha sĩ --" ||
                    cboRoom.Text == "-- Chọn phòng --")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để đặt lịch hẹn!");
            }
            else if (appointDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày hẹn không hợp lệ! Vui lòng chọn ngày trong tương lai");
            }
            else if (dentist_id == assistant_id)
            {
                MessageBox.Show("Nha sĩ chính và trợ khám không thể là cùng một người!");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_LICHHEN_INS", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int status = 0; // 0: Cuộc hẹn mới, 1: Tái khám
                    if (cboStatus.Text == "Gói")
                    {
                        status = 1;
                    }

                    cmd.Parameters.Add(new SqlParameter("@IDHOSO", record_id));
                    cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIO", time));
                    cmd.Parameters.Add(new SqlParameter("@TINHTRANG", status));
                    cmd.Parameters.Add(new SqlParameter("@GHICHU", noteBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@IDPHONGKHAM", cboRoom.Text));
                    cmd.Parameters.Add(new SqlParameter("@IDNHASI", dentist_id));
                    if (assistant_id == "")
                    {
                        cmd.Parameters.Add(new SqlParameter("@IDTROKHAM", DBNull.Value));
                    }
                    else cmd.Parameters.Add(new SqlParameter("@IDTROKHAM", assistant_id));
                    cmd.Parameters.Add(new SqlParameter("@IDNHANVIENDAT", CurrentEmp));

                    cmd.Parameters.Add("@IDLICHHEN", SqlDbType.Char, 7).Direction = ParameterDirection.Output;
                    int i = cmd.ExecuteNonQuery();
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
}
