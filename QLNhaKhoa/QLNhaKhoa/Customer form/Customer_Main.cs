using QLNhaKhoa.General_form;
using System.Data.SqlClient;

namespace QLNhaKhoa
{
    public partial class Customer_Main : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Customer_Main()
        {
            InitializeComponent();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentUser;
            f.CurrentPass = CurrentPass;
            Helper.loadform(f, this.mainPanel);
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Customer_Appointment f = new Customer_Appointment();
            f.CurrentUser = CurrentUser;
            Helper.loadform(f, this.mainPanel);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Customer_Record f = new Customer_Record();
            f.CurrentUser = CurrentUser;
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

        private void Customer_Main_Load(object sender, EventArgs e)
        {
            CustomerID.Text = CurrentUser;
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from KHACHHANG where MAKHACHHANG = '" + CurrentUser + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    CustomerName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }
    }
}
