using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Prescription : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Prescription()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            Helper.refreshData("select * from TOATHUOC", prescriptionData);
        }

        private void Dentist_Prescription_Load(object sender, EventArgs e)
        {
            prescriptionData.DataSource = Helper.getData("select * from TOATHUOC").Tables[0];

            cboRecord.DisplayMember = "HOTEN";
            cboRecord.ValueMember = "MAHSBA";
            cboRecord.DataSource = Helper.getData("select KH.HOTEN, HSBA.MAHSBA from HOSOBENHAN HSBA JOIN KHACHHANG KH ON HSBA.MAKHACHHANG = KH.MAKHACHHANG").Tables[0];

            cboMedication.DisplayMember = "TENTHUOC";
            cboMedication.ValueMember = "MATHUOC";
            cboMedication.DataSource = Helper.getData("select MATHUOC, TENTHUOC from THUOC").Tables[0];

            cboCertificate.DisplayMember = "MAGIAYKHAMBENH";
            cboCertificate.ValueMember = "MAGIAYKHAMBENH";
            cboCertificate.DataSource = Helper.getData("select DISTINCT MAGIAYKHAMBENH from GIAYKHAMBENH").Tables[0];
        }
        private void prescriptionData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = prescriptionData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();

                quantityBox.Text = dgvr.Cells["SOLUONG"].Value.ToString();
                cboCertificate.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();

                SqlCommand cmd = new SqlCommand("select KH.HOTEN from HOSOBENHAN HSBA JOIN KHACHHANG KH ON HSBA.MAKHACHHANG = KH.MAKHACHHANG where HSBA.MAHSBA='" + dgvr.Cells["MAHSBA"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cboRecord.Text = reader.GetString(0);
                    }
                }

                SqlCommand cmd2 = new SqlCommand("select TENTHUOC from THUOC where MATHUOC='" + dgvr.Cells["MATHUOC"].Value.ToString() + "'", sqlCon);
                using (SqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        cboMedication.Text = reader2.GetString(0);
                    }
                }
                sqlCon.Close();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void addPreButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_TOATHUOC_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var itemR = (DataRowView)cboRecord.SelectedItem;
                var itemM = (DataRowView)cboMedication.SelectedItem;

                cmd.Parameters.Add(new SqlParameter("@MAHSBA", itemR["MAHSBA"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@MAGIAYKHAMBENH", cboCertificate.Text));
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", itemM["MATHUOC"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", quantityBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm toa thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm toa thuốc thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm toa thuốc thất bại! " + ex.Message);
            }
        }

        private void updatePreButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_TOATHUOC_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var itemR = (DataRowView)cboRecord.SelectedItem;
                var itemM = (DataRowView)cboMedication.SelectedItem;

                cmd.Parameters.Add(new SqlParameter("@MAHSBA", itemR["MAHSBA"].ToString().Trim()));
                cmd.Parameters.Add(new SqlParameter("@MAGIAYKHAMBENH", cboCertificate.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", itemM["MATHUOC"].ToString().Trim()));
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", quantityBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật toa thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật toa thuốc thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật toa thuốc thất bại! " + ex.Message);
            }
        }

        private void deletePreButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa toa thuốc này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_TOATHUOC_DEL", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    var itemR = (DataRowView)cboRecord.SelectedItem;
                    var itemM = (DataRowView)cboMedication.SelectedItem;

                    cmd.Parameters.Add(new SqlParameter("@MAHSBA", itemR["MAHSBA"].ToString()));
                    cmd.Parameters.Add(new SqlParameter("@MAGIAYKHAMBENH", cboCertificate.Text));
                    cmd.Parameters.Add(new SqlParameter("@MATHUOC", itemM["MATHUOC"].ToString()));

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Xóa toa thuốc thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa toa thuốc thất bại!");
                    }
                    refresh();
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa toa thuốc thất bại! " + ex.Message);
                }
            }
            else { }
        }
    }
}
