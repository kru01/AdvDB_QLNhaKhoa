using QLNhaKhoa.Admin_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.General_Form
{
    public partial class EmpList : Form
    {
        private static string query = "select * from TAIKHOAN where LOAITAIKHOAN != 2";
        public static AddEmp f;
        public EmpList()
        {
            InitializeComponent();
        }

        private void EmpList_Load(object sender, EventArgs e)
        {
            employeeData.DataSource = Helper.getData(query).Tables[0];
        }

        private void employeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = employeeData.Rows[e.RowIndex];
                IDBox.Text = dgvr.Cells["IDTAIKHOAN"].Value.ToString();
                bdayBox.Text = dgvr.Cells["NGAYSINH"].Value.ToString();
                nameBox.Text = dgvr.Cells["HOTEN"].Value.ToString();
                addressBox.Text = dgvr.Cells["DIACHI"].Value.ToString();
                phoneBox.Text = dgvr.Cells["SDT"].Value.ToString();
                emailBox.Text = dgvr.Cells["EMAIL"].Value.ToString();
                usernameBox.Text = dgvr.Cells["TENDANGNHAP"].Value.ToString();
                passwordBox.Text = dgvr.Cells["MATKHAU"].Value.ToString();
                if (dgvr.Cells["LOAITAIKHOAN"].Value.ToString() == "0")
                {
                    cboEmpType.Text = "Employee";
                }
                else cboEmpType.Text = "Dentist";

                if (dgvr.Cells["GIOITINH"].Value.ToString() == "0")
                {
                    cboGender.Text = "Male";
                }
                else cboGender.Text = "Female";
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData(query, employeeData);
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                int empType = 0, gender = 0;
                if (cboGender.Text == "Female")
                {
                    gender = 1;
                }
                if (cboEmpType.Text == "Dentist")
                {
                    empType = 1;
                }

                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_TAIKHOAN_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IDTAIKHOAN", IDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@TENDANGNHAP", usernameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MATKHAU", passwordBox.Text));
                cmd.Parameters.Add(new SqlParameter("@LOAITAIKHOAN", empType));
                cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bdayBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIOITINH", gender));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", emailBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", phoneBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại!");
                }
                sqlCon.Close();
                Helper.refreshData(query, employeeData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tài khoản thất bại! " + ex);
            }
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            f = new AddEmp();
            f.FormClosedEvent += AdminFormClosedEvent;
            f.Show();
        }

        private void AdminFormClosedEvent(object sender, EventArgs e)
        {
            Helper.refreshData(query, employeeData);
        }
    }
}
