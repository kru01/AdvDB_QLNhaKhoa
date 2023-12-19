using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaKhoa.Filter_folder;
using System.Data.SqlClient;
using QLNhaKhoa.Appointment_Setup_Emp;


namespace QLNhaKhoa.General_Form
{
    public partial class AppointmentForEmp : Form
    {
        private string query = "select IDHOSO, IDLICHHEN, NGAY, GIO, TINHTRANG, IDPHONGKHAM, IDNHASI, IDTROKHAM from LICHHEN";
        public static AppointmentForEmp instance;
        public string filter_patient, filter_room, filter_dentist;
        private Filter_Patient f1;
        private Filter_Room f2;
        private Filter_Dentist f3;
        private Add_Appointment f4;
        //private Edit_Appointment f5;
        //private Del_Appointment f5;

        public AppointmentForEmp()
        {
            InitializeComponent();
            instance = this;
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            appointmentData.DataSource = Helper.getData(query).Tables[0];
        }

        private void appointmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = appointmentData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                string time_str = dgvr.Cells["GIO"].Value.ToString();

                if (time_str.All(char.IsDigit))
                {
                    int time = int.Parse(time_str);
                    int hour = time / 60;
                    int minutes = time - hour * 60;

                    appIDBox.Text = dgvr.Cells["IDLICHHEN"].Value.ToString();
                    appointTime.Text = hour + ":" + minutes;
                    appointDate.Text = dgvr.Cells["NGAY"].Value.ToString();
                    roomBox.Text = dgvr.Cells["IDPHONGKHAM"].Value.ToString();
                    if (dgvr.Cells["TINHTRANG"].Value.ToString() == "0")
                    {
                        statusBox.Text = "Cuộc hẹn mới";
                    }
                    else statusBox.Text = "Tái khám";

                    SqlCommand cmd1 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN='" + dgvr.Cells["IDNHASI"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dentistBox.Text = reader.GetString(0);
                        }
                    }

                    SqlCommand cmd2 = new SqlCommand("select HOTEN from TAIKHOAN where IDTAIKHOAN='" + dgvr.Cells["IDTROKHAM"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            assistantBox.Text = reader.GetString(0);
                        }
                    }

                    SqlCommand cmd3 = new SqlCommand("select HOTEN from HOSOBENHNHAN where IDHOSO='" + dgvr.Cells["IDHOSO"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd3.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerBox.Text = reader.GetString(0);
                        }
                    }
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, appointmentData);
        }

        private void filterPButton_Click(object sender, EventArgs e)
        {
            f1 = new Filter_Patient();
            f1.FormClosedEvent += AdminFormClosedEventP;
            f1.Show();
        }

        private void AdminFormClosedEventP(object sender, EventArgs e)
        {
            ((DataTable)appointmentData.DataSource).DefaultView.RowFilter = String.Format("IDHOSO like '%" + filter_patient + "%'");
        }

        private void filterRButton_Click(object sender, EventArgs e)
        {
            f2 = new Filter_Room();
            f2.FormClosedEvent += AdminFormClosedEventR;
            f2.Show();
        }

        private void AdminFormClosedEventR(object sender, EventArgs e)
        {
            ((DataTable)appointmentData.DataSource).DefaultView.RowFilter = String.Format("IDPHONGKHAM like '%" + filter_room + "%'");
        }

        private void filterDButton_Click(object sender, EventArgs e)
        {
            f3 = new Filter_Dentist();
            f3.FormClosedEvent += AdminFormClosedEventD;
            f3.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            f4 = new Add_Appointment();
            f3.FormClosedEvent += AdminFormClosedEventD;
            f3.Show();
        }

        private void AdminFormClosedEventD(object sender, EventArgs e)
        {
            ((DataTable)appointmentData.DataSource).DefaultView.RowFilter = String.Format("IDNHASI like '%" + filter_dentist + "%'");
        }
    }
}
