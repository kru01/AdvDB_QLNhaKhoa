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
    public partial class Filter_Room : Form
    {
        public event EventHandler FormClosedEvent;
        public Filter_Room()
        {
            InitializeComponent();
        }

        private void Filter_Room_Load(object sender, EventArgs e)
        {
            cboRoom.DisplayMember = "IDPHONGKHAM";
            cboRoom.ValueMember = "IDPHONGKHAM";
            cboRoom.DataSource = Helper.getData("select IDPHONGKHAM from PHONGKHAM").Tables[0];
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            Admin_Appointment.instance.filter_room = cboRoom.Text;
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
