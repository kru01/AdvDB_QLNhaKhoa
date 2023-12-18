using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_Main : Form
    {
        public string CurrentAdmin { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public string CurrentUsername { get; set; } = string.Empty;
        public Admin_Main()
        {
            InitializeComponent();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentAdmin;
            f.CurrentPass = CurrentPass;
            f.CurrentUsername = CurrentUsername;
            Helper.loadform(f, this.mainPanel);
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Admin_EmpList f = new Admin_EmpList();
            f.CurrentAdmin = CurrentAdmin;
            Helper.loadform(f, this.mainPanel);
        }

        private void empScheduleButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Schedule(), this.mainPanel);
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_record(), this.mainPanel);
        }

        public void Admin_Main_Load(object sender, EventArgs e)
        {
            AdminID.Text = CurrentAdmin;
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN='" + CurrentAdmin + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    AdminName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn đăng xuất?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();
            }
            else { }
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Appointment(), this.mainPanel);
        }

        private void MedicationButton_Click_1(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Medication(), this.mainPanel);
        }
    }
}
