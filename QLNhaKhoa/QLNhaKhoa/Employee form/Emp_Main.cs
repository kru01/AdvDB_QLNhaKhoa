using System.Data.SqlClient;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Main : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Emp_Main()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentEmp;
            f.CurrentPass = CurrentPass;
            Helper.loadform(f, this.mainPanel);
        }
        private void BillButton_Click(object sender, EventArgs e)
        {
            Emp_Bill f = new Emp_Bill();
            f.CurrentEmp = CurrentEmp;
            Helper.loadform(f, this.mainPanel);
        }
        private void MedRecdButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Record(), this.mainPanel);
        }
        private void MedCertButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Certificate(), this.mainPanel);
        }
        private void CusSerButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Services(), this.mainPanel);
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
            Emp_Appointment f = new Emp_Appointment();
            f.CurrentEmp = CurrentEmp;
            Helper.loadform(f, this.mainPanel);
        }
        private void Emp_Main_Load(object sender, EventArgs e)
        {
            EmpID.Text = CurrentEmp;
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from NHANVIEN where MANHANVIEN = '" + CurrentEmp + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    EmpName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }
    }
}
