using QLNhaKhoa.Employee_form;

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
            General_Form.Appointment.instance.filter_room = cboRoom.Text;
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
