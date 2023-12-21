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
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            refreshButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            noteBox = new TextBox();
            cboAssistant = new ComboBox();
            cboDentist = new ComboBox();
            cboRoom = new ComboBox();
            cboStatus = new ComboBox();
            customerBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label = new Label();
            label6 = new Label();
            appIDBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
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
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(updateButton);
            panel3.Controls.Add(addButton);
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(appointmentData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 14;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.SteelBlue;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(222, 350);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(80, 40);
            deleteButton.TabIndex = 24;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(136, 350);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(80, 40);
            updateButton.TabIndex = 23;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.SteelBlue;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(50, 350);
            addButton.Name = "addButton";
            addButton.Size = new Size(80, 40);
            addButton.TabIndex = 22;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(308, 350);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(80, 40);
            refreshButton.TabIndex = 15;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
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
            panel4.Controls.Add(label7);
            panel4.Controls.Add(noteBox);
            panel4.Controls.Add(cboAssistant);
            panel4.Controls.Add(cboDentist);
            panel4.Controls.Add(cboRoom);
            panel4.Controls.Add(cboStatus);
            panel4.Controls.Add(customerBox);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(appIDBox);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(appointTime);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(appointDate);
            panel4.Location = new Point(50, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 300);
            panel4.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(100, 229);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 25;
            label7.Text = "Note";
            // 
            // noteBox
            // 
            noteBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteBox.Location = new Point(100, 255);
            noteBox.Name = "noteBox";
            noteBox.PlaceholderText = "Note";
            noteBox.Size = new Size(600, 27);
            noteBox.TabIndex = 24;
            // 
            // cboAssistant
            // 
            cboAssistant.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAssistant.FormattingEnabled = true;
            cboAssistant.Location = new Point(425, 185);
            cboAssistant.Name = "cboAssistant";
            cboAssistant.Size = new Size(275, 27);
            cboAssistant.TabIndex = 23;
            // 
            // cboDentist
            // 
            cboDentist.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentist.FormattingEnabled = true;
            cboDentist.Location = new Point(100, 185);
            cboDentist.Name = "cboDentist";
            cboDentist.Size = new Size(275, 27);
            cboDentist.TabIndex = 22;
            // 
            // cboRoom
            // 
            cboRoom.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoom.FormattingEnabled = true;
            cboRoom.Location = new Point(550, 115);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(150, 27);
            cboRoom.TabIndex = 21;
            // 
            // cboStatus
            // 
            cboStatus.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Cuộc hẹn mới", "Tái khám" });
            cboStatus.Location = new Point(225, 45);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(175, 27);
            cboStatus.TabIndex = 20;
            // 
            // customerBox
            // 
            customerBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerBox.Location = new Point(100, 115);
            customerBox.Name = "customerBox";
            customerBox.PlaceholderText = "Customer name";
            customerBox.ReadOnly = true;
            customerBox.Size = new Size(425, 27);
            customerBox.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(100, 89);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 17;
            label8.Text = "Customer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(550, 89);
            label9.Name = "label9";
            label9.Size = new Size(53, 23);
            label9.TabIndex = 16;
            label9.Text = "Room";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.SteelBlue;
            label.Location = new Point(225, 19);
            label.Name = "label";
            label.Size = new Size(57, 23);
            label.TabIndex = 15;
            label.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(100, 19);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 11;
            label6.Text = "Appoint ID";
            // 
            // appIDBox
            // 
            appIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appIDBox.Location = new Point(100, 45);
            appIDBox.Name = "appIDBox";
            appIDBox.PlaceholderText = "Appoint ID";
            appIDBox.ReadOnly = true;
            appIDBox.Size = new Size(100, 27);
            appIDBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(425, 159);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 9;
            label5.Text = "Assistant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 159);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 8;
            label4.Text = "Dentist";
            // 
            // appointTime
            // 
            appointTime.CustomFormat = "HH:mm";
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Format = DateTimePickerFormat.Custom;
            appointTime.Location = new Point(425, 45);
            appointTime.Name = "appointTime";
            appointTime.ShowUpDown = true;
            appointTime.Size = new Size(100, 27);
            appointTime.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(550, 19);
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
            label2.Location = new Point(425, 19);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 3;
            label2.Text = "Time";
            // 
            // appointDate
            // 
            appointDate.CustomFormat = "yyyy-MM-dd";
            appointDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointDate.Format = DateTimePickerFormat.Custom;
            appointDate.Location = new Point(550, 45);
            appointDate.Name = "appointDate";
            appointDate.Size = new Size(150, 27);
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
            appointmentData.Location = new Point(0, 400);
            appointmentData.Name = "appointmentData";
            appointmentData.RowHeadersWidth = 51;
            appointmentData.Size = new Size(900, 300);
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
        private Button refreshButton;
        private Label label1;
        private Panel panel4;
        private TextBox customerBox;
        private Label label8;
        private Label label9;
        private Label label;
        private Label label6;
        private TextBox appIDBox;
        private Label label5;
        private Label label4;
        private DateTimePicker appointTime;
        private Label label3;
        private Label label2;
        private DateTimePicker appointDate;
        private DataGridView appointmentData;
        private Button addButton;
        private Button deleteButton;
        private Button updateButton;
        private ComboBox cboStatus;
        private ComboBox cboRoom;
        private ComboBox cboAssistant;
        private ComboBox cboDentist;
        private TextBox noteBox;
        private Label label7;
    }
}