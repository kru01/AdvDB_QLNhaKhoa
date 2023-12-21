using QLNhaKhoa.Admin_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.General_Form
{
    public partial class Medication : Form
    {
        public DataTable searchData;
        public Medication()
        {
            InitializeComponent();
        }

        private void Medication_Load(object sender, EventArgs e)
        {
            medData.DataSource = Helper.getData("select * from THUOC").Tables[0];
        }

        private void medData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = medData.Rows[e.RowIndex];
                medIDBox.Text = dgvr.Cells["IDTHUOC"].Value.ToString();
                medNameBox.Text = dgvr.Cells["TENTHUOC"].Value.ToString();
                prescribeBox.Text = dgvr.Cells["CHIDINH"].Value.ToString();
                instockBox.Text = dgvr.Cells["SOLUONGTONKHO"].Value.ToString();
                expDateBox.Text = dgvr.Cells["NGAYHETHAN"].Value.ToString();
                priceBox.Text = dgvr.Cells["GIATIEN"].Value.ToString();
                if (dgvr.Cells["DONVITINH"].Value.ToString() == "0")
                {
                    unitBox.Text = "Viên";
                }
                if (dgvr.Cells["DONVITINH"].Value.ToString() == "1")
                {
                    unitBox.Text = "Gói";
                }
                else unitBox.Text = "Hộp";
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from THUOC", medData);
        }
    }
}
