using QLNhaKhoa.Employee_form;
using System.Data;

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
            General_Form.Appointment.instance.filter_dentist = ((DataRowView)cboDentist.SelectedItem)["IDTAIKHOAN"].ToString();
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
