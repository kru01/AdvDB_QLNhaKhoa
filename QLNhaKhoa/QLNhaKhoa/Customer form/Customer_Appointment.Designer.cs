namespace QLNhaKhoa.General_form
{
    partial class Customer_Appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            updateAppButton = new Button();
            makeAppointBtn = new Button();
            panel2 = new Panel();
            label4 = new Label();
            empIDBox = new TextBox();
            label5 = new Label();
            appIDBox = new TextBox();
            appointTime = new DateTimePicker();
            label3 = new Label();
            appointDate = new DateTimePicker();
            label2 = new Label();
            cboDentists = new ComboBox();
            label1 = new Label();
            appointmentData = new DataGridView();
            serviceTitle = new Label();
            refreshButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(updateAppButton);
            panel1.Controls.Add(makeAppointBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(appointmentData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 3;
            // 
            // updateAppButton
            // 
            updateAppButton.BackColor = Color.SteelBlue;
            updateAppButton.FlatAppearance.BorderSize = 0;
            updateAppButton.FlatStyle = FlatStyle.Flat;
            updateAppButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateAppButton.ForeColor = Color.White;
            updateAppButton.Location = new Point(256, 300);
            updateAppButton.Name = "updateAppButton";
            updateAppButton.Size = new Size(100, 40);
            updateAppButton.TabIndex = 4;
            updateAppButton.Text = "Update";
            updateAppButton.UseVisualStyleBackColor = false;
            updateAppButton.Click += updateAppButton_Click;
            // 
            // makeAppointBtn
            // 
            makeAppointBtn.BackColor = Color.SteelBlue;
            makeAppointBtn.FlatAppearance.BorderSize = 0;
            makeAppointBtn.FlatStyle = FlatStyle.Flat;
            makeAppointBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeAppointBtn.ForeColor = Color.White;
            makeAppointBtn.Location = new Point(50, 300);
            makeAppointBtn.Name = "makeAppointBtn";
            makeAppointBtn.Size = new Size(200, 40);
            makeAppointBtn.TabIndex = 1;
            makeAppointBtn.Text = "Make an appointment";
            makeAppointBtn.UseVisualStyleBackColor = false;
            makeAppointBtn.Click += makeAppointBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(empIDBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(appIDBox);
            panel2.Controls.Add(appointTime);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(appointDate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cboDentists);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(50, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(500, 36);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 13;
            label4.Text = "Employee ID";
            // 
            // empIDBox
            // 
            empIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empIDBox.Location = new Point(500, 62);
            empIDBox.Name = "empIDBox";
            empIDBox.PlaceholderText = "Employee ID";
            empIDBox.ReadOnly = true;
            empIDBox.Size = new Size(150, 27);
            empIDBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(150, 145);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 11;
            label5.Text = "Appointment ID";
            // 
            // appIDBox
            // 
            appIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appIDBox.Location = new Point(150, 170);
            appIDBox.Name = "appIDBox";
            appIDBox.PlaceholderText = "Appointment ID";
            appIDBox.ReadOnly = true;
            appIDBox.Size = new Size(125, 27);
            appIDBox.TabIndex = 10;
            // 
            // appointTime
            // 
            appointTime.CustomFormat = "HH:mm";
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Format = DateTimePickerFormat.Custom;
            appointTime.Location = new Point(150, 62);
            appointTime.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            appointTime.Name = "appointTime";
            appointTime.ShowUpDown = true;
            appointTime.Size = new Size(150, 27);
            appointTime.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(326, 36);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 6;
            label3.Text = "Date";
            // 
            // appointDate
            // 
            appointDate.CustomFormat = "yyyy-MM-dd";
            appointDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointDate.Format = DateTimePickerFormat.Custom;
            appointDate.Location = new Point(326, 62);
            appointDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            appointDate.Name = "appointDate";
            appointDate.Size = new Size(150, 27);
            appointDate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(300, 144);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 4;
            label2.Text = "Dentist";
            // 
            // cboDentists
            // 
            cboDentists.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentists.FormattingEnabled = true;
            cboDentists.Location = new Point(300, 170);
            cboDentists.MinimumSize = new Size(350, 0);
            cboDentists.Name = "cboDentists";
            cboDentists.Size = new Size(350, 27);
            cboDentists.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(150, 36);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 2;
            label1.Text = "Time (8h - 17h)";
            // 
            // appointmentData
            // 
            appointmentData.AllowUserToAddRows = false;
            appointmentData.AllowUserToDeleteRows = false;
            appointmentData.AllowUserToResizeColumns = false;
            appointmentData.AllowUserToResizeRows = false;
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            appointmentData.BorderStyle = BorderStyle.None;
            appointmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentData.Dock = DockStyle.Bottom;
            appointmentData.Location = new Point(0, 350);
            appointmentData.Name = "appointmentData";
            appointmentData.RowHeadersWidth = 51;
            appointmentData.Size = new Size(900, 350);
            appointmentData.TabIndex = 0;
            appointmentData.CellClick += appointmentData_CellClick;
            // 
            // serviceTitle
            // 
            serviceTitle.AutoSize = true;
            serviceTitle.BackColor = Color.White;
            serviceTitle.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceTitle.ForeColor = Color.SteelBlue;
            serviceTitle.Location = new Point(367, 20);
            serviceTitle.Name = "serviceTitle";
            serviceTitle.Size = new Size(166, 35);
            serviceTitle.TabIndex = 6;
            serviceTitle.Text = "Appointment";
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(362, 300);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 5;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // Customer_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(serviceTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_Appointment";
            Text = "Appointment";
            Load += Appointment_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button updateAppButton;
        private Button makeAppointBtn;
        private Panel panel2;
        private Label label3;
        private DateTimePicker appointDate;
        private Label label2;
        private ComboBox cboDentists;
        private Label label1;
        private Label serviceTitle;
        public DataGridView appointmentData;
        private DateTimePicker appointTime;
        private Label label5;
        private TextBox appIDBox;
        private TextBox empIDBox;
        private Label label4;
        private Button refreshButton;
    }
}