using QLNhaKhoa.Admin_form;
using System.Data;

namespace QLNhaKhoa.Filter_folder
{
    public partial class Filter_Patient : Form
    {
        public event EventHandler FormClosedEvent;
        public Filter_Patient()
        {
            InitializeComponent();
        }

        private void Filter_Patient_Load(object sender, EventArgs e)
        {
            cboPatient.DisplayMember = "HOTEN";
            cboPatient.ValueMember = "IDHOSO";
            cboPatient.DataSource = Helper.getData("select HOTEN, IDHOSO from HOSOBENHNHAN").Tables[0];
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            General_Form.Appointment.instance.filter_patient = ((DataRowView)cboPatient.SelectedItem)["IDHOSO"].ToString();
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
