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

namespace QLNhaKhoa.Filter_folder
{
    public partial class Filter_Dentist : Form
    {
        public event EventHandler FormClosedEvent;
        public Filter_Dentist()
        {
            InitializeComponent();
        }

        private void Filter_Dentist_Load(object sender, EventArgs e)
        {
            cboDentist.DisplayMember = "HOTEN";
            cboDentist.ValueMember = "IDTAIKHOAN";
            cboDentist.DataSource = Helper.getData("select HOTEN, IDTAIKHOAN from TAIKHOAN where LOAITAIKHOAN = 1").Tables[0];
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            Admin_Appointment.instance.filter_dentist = ((DataRowView)cboDentist.SelectedItem)["IDTAIKHOAN"].ToString();
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
