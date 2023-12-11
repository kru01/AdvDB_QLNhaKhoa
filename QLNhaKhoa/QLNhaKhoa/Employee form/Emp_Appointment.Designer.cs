namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Appointment
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
            panel3 = new Panel();
            searchIDBox = new TextBox();
            searchButton = new Button();
            refreshButton = new Button();
            updateAppButton = new Button();
            makeAppButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            appIDBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cboCustomer = new ComboBox();
            cboDentists = new ComboBox();
            appointTime = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            appointDate = new DateTimePicker();
            appointmentData = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(searchIDBox);
            panel3.Controls.Add(searchButton);
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(updateAppButton);
            panel3.Controls.Add(makeAppButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(appointmentData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 10;
            // 
            // searchIDBox
            // 
            searchIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchIDBox.Location = new Point(569, 311);
            searchIDBox.MaxLength = 10;
            searchIDBox.Name = "searchIDBox";
            searchIDBox.PlaceholderText = "Enter appointment ID to search";
            searchIDBox.Size = new Size(200, 27);
            searchIDBox.TabIndex = 18;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SteelBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Tw Cen MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(775, 311);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 27);
            searchButton.TabIndex = 19;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
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
            refreshButton.TabIndex = 15;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
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
            updateAppButton.TabIndex = 5;
            updateAppButton.Text = "Update";
            updateAppButton.UseVisualStyleBackColor = false;
            updateAppButton.Click += updateAppButton_Click;
            // 
            // makeAppButton
            // 
            makeAppButton.BackColor = Color.SteelBlue;
            makeAppButton.FlatAppearance.BorderSize = 0;
            makeAppButton.FlatStyle = FlatStyle.Flat;
            makeAppButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeAppButton.ForeColor = Color.White;
            makeAppButton.Location = new Point(50, 300);
            makeAppButton.Name = "makeAppButton";
            makeAppButton.Size = new Size(200, 40);
            makeAppButton.TabIndex = 3;
            makeAppButton.Text = "Make an appointment";
            makeAppButton.UseVisualStyleBackColor = false;
            makeAppButton.Click += makeAppButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(367, 25);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 0;
            label1.Text = "Appointment";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(appIDBox);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(cboCustomer);
            panel4.Controls.Add(cboDentists);
            panel4.Controls.Add(appointTime);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(appointDate);
            panel4.Location = new Point(50, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(100, 50);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 11;
            label6.Text = "Appointment ID";
            // 
            // appIDBox
            // 
            appIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appIDBox.Location = new Point(100, 78);
            appIDBox.Name = "appIDBox";
            appIDBox.PlaceholderText = "Appointment ID";
            appIDBox.ReadOnly = true;
            appIDBox.Size = new Size(125, 27);
            appIDBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(425, 139);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 9;
            label5.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 139);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 8;
            label4.Text = "Dentist";
            // 
            // cboCustomer
            // 
            cboCustomer.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(425, 165);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(275, 27);
            cboCustomer.TabIndex = 7;
            // 
            // cboDentists
            // 
            cboDentists.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentists.FormattingEnabled = true;
            cboDentists.Location = new Point(100, 165);
            cboDentists.Name = "cboDentists";
            cboDentists.Size = new Size(275, 27);
            cboDentists.TabIndex = 6;
            // 
            // appointTime
            // 
            appointTime.CustomFormat = "HH:mm";
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Format = DateTimePickerFormat.Custom;
            appointTime.Location = new Point(263, 76);
            appointTime.Name = "appointTime";
            appointTime.ShowUpDown = true;
            appointTime.Size = new Size(200, 27);
            appointTime.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(500, 50);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 4;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(263, 50);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 3;
            label2.Text = "Time (8h - 17h)";
            // 
            // appointDate
            // 
            appointDate.CustomFormat = "yyyy-MM-dd";
            appointDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointDate.Format = DateTimePickerFormat.Custom;
            appointDate.Location = new Point(500, 76);
            appointDate.Name = "appointDate";
            appointDate.Size = new Size(200, 27);
            appointDate.TabIndex = 2;
            // 
            // appointmentData
            // 
            appointmentData.AllowUserToAddRows = false;
            appointmentData.AllowUserToDeleteRows = false;
            appointmentData.AllowUserToResizeColumns = false;
            appointmentData.AllowUserToResizeRows = false;
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentData.BorderStyle = BorderStyle.None;
            appointmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentData.Dock = DockStyle.Bottom;
            appointmentData.Location = new Point(0, 350);
            appointmentData.Name = "appointmentData";
            appointmentData.RowHeadersWidth = 51;
            appointmentData.Size = new Size(900, 350);
            appointmentData.TabIndex = 2;
            appointmentData.CellClick += appointmentData_CellClick;
            // 
            // Emp_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp_Appointment";
            Text = "Emp_Appointment";
            Load += Emp_Appointment_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button updateAppButton;
        private Button makeAppButton;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private DateTimePicker appointDate;
        private DataGridView appointmentData;
        private Button refreshButton;
        private TextBox searchIDBox;
        private Button searchButton;
        private DateTimePicker appointTime;
        private ComboBox cboCustomer;
        private ComboBox cboDentists;
        private Label label5;
        private Label label4;
        private TextBox appIDBox;
        private Label label6;
    }
}