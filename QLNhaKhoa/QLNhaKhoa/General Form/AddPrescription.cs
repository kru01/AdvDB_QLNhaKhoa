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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLNhaKhoa.General_Form
{
    public partial class AddPrescription : Form
    {
        public event EventHandler FormClosedEvent;
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình thêm toa thuốc?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            cboName.DisplayMember = "HOTEN";
            cboName.ValueMember = "IDHOSO";
            cboName.DataSource = Helper.getData("select IDHOSO, HOTEN from HOSOBENHNHAN").Tables[0];
            cboName.DropDownStyle = ComboBoxStyle.DropDownList;

            cboMed.DisplayMember = "TENTHUOC";
            cboMed.ValueMember = "IDTHUOC";
            cboMed.DataSource = Helper.getData("select IDTHUOC, TENTHUOC from THUOC").Tables[0];
            cboMed.DropDownStyle = ComboBoxStyle.DropDownList;

            cboPlan.DisplayMember = "IDKEHOACH";
            cboPlan.ValueMember = "IDKEHOACH";
            cboPlan.DataSource = Helper.getData("select DISTINCT IDKEHOACH from KEHOACHDIEUTRI").Tables[0];
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void addPreButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_TOATHUOC_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var itemN = (DataRowView)cboName.SelectedItem;
                var itemM = (DataRowView)cboMed.SelectedItem;
                cmd.Parameters.Add(new SqlParameter("@IDHOSO", itemN["IDHOSO"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@IDKEHOACH", cboPlan.Text));
                cmd.Parameters.Add(new SqlParameter("@IDTHUOC", itemM["IDTHUOC"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", quantityBox.Text));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm toa thuốc thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Thêm toa thuốc thất bại!");
                }
                sqlCon.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm toa thuốc thất bại! " + ex.Message);
            }
        }

        private void quantityBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
