using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_Main : Form
    {
        public string CurrentAdmin { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Admin_Main()
        {
            InitializeComponent();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentAdmin;
            f.CurrentPass = CurrentPass;
            Helper.loadform(f, this.mainPanel);
        }

        private void AccountMngrButton_Click(object sender, EventArgs e)
        {
            Admin_AccManager f = new Admin_AccManager();
            f.CurrentAdmin = CurrentAdmin;
            Helper.loadform(f, this.mainPanel);
        }

        private void MedicationButton_Click(object sender, EventArgs e)
        {
            Admin_Medication f = new Admin_Medication();
            f.CurrentAdmin = CurrentAdmin;
            Helper.loadform(f, this.mainPanel);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Admin_Main_Load(object sender, EventArgs e)
        {
            AdminID.Text = CurrentAdmin;
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from NHANVIEN where MANHANVIEN='" + CurrentAdmin + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    AdminName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }
    }
}
