using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Main : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public string CurrentUsername { get; set; } = string.Empty;
        public Dentist_Main()
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
            f.CurrentUser = CurrentDentist;
            f.CurrentPass = CurrentPass;
            Helper.loadform(f, this.mainPanel);
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

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Dentist_Appointment f = new Dentist_Appointment();
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }

        private void PrecriptionButton_Click(object sender, EventArgs e)
        {
            Dentist_Prescription f = new Dentist_Prescription();
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Dentist_Record f = new Dentist_Record();
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }
        private void certificateButton_Click(object sender, EventArgs e)
        {
            Dentist_Certificate f = new Dentist_Certificate();
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }
        private void Dentist_Main_Load(object sender, EventArgs e)
        {
            DentistID.Text = CurrentDentist;
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN = '" + CurrentDentist + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dentistName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }
    }
}
