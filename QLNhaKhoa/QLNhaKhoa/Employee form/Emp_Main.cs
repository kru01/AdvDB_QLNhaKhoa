using System.Data.SqlClient;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Main : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public string CurrentUsername { get; set; } = string.Empty;
        public Emp_Main()
        {
            InitializeComponent();
        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentEmp;
            f.CurrentPass = CurrentPass;
            f.CurrentUsername = CurrentUsername;
            Helper.loadform(f, this.mainPanel);
        }
        private void MedRecdButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new General_Form.Record(), this.mainPanel);
        }
        private void PrescriptionButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Prescription(), this.mainPanel);
        }
        private void MedicationButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Medication(), this.mainPanel);
        }
        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new General_Form.Appointment(), this.mainPanel);
        }
        private void Emp_Main_Load(object sender, EventArgs e)
        {
            EmpID.Text = CurrentEmp;
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN = '" + CurrentEmp + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    EmpName.Text = reader.GetString(0);
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
    }
}
