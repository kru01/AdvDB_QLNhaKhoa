using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace QLNhaKhoa.Appointment_Setup_Emp
{
    public partial class Add_Appointment : Form
    {
        public event EventHandler FormClosedEvent;
        public Add_Appointment()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_LICHHEN_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IDHOSO", recordBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                cmd.Parameters.Add(new SqlParameter("@GIO", appointDate.Text));
                cmd.Parameters.Add(new SqlParameter("@TINHTRANG", statusBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GHICHU", null));
                cmd.Parameters.Add(new SqlParameter("@IDPHONGKHAM", recordBox.Text));
                cmd.Parameters.Add(new SqlParameter("@IDNHASI", dentistBox.Text));
                cmd.Parameters.Add(new SqlParameter("@IDNHANVIENDAT", assistantBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm lịch hẹn thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Thêm lịch hẹn thất bại!");
                }
                sqlCon.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm lịch hẹn thất bại! " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình thêm cuộc hẹn?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }
    }
}
