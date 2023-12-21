namespace QLNhaKhoa.General_Form
{
    partial class Appointment
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
            filterDButton = new Button();
            filterRButton = new Button();
            filterPButton = new Button();
            refreshButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            customerBox = new TextBox();
            roomBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label = new Label();
            statusBox = new TextBox();
            dentistBox = new TextBox();
            assistantBox = new TextBox();
            label6 = new Label();
            appIDBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            appointTime = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            appointDate = new DateTimePicker();
            appointmentData = new DataGridView();
            noteBox = new TextBox();
            label7 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(filterDButton);
            panel3.Controls.Add(filterRButton);
            panel3.Controls.Add(filterPButton);
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(appointmentData);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 13;
            // 
            // filterDButton
            // 
            filterDButton.BackColor = Color.SteelBlue;
            filterDButton.FlatAppearance.BorderSize = 0;
            filterDButton.FlatStyle = FlatStyle.Flat;
            filterDButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterDButton.ForeColor = Color.White;
            filterDButton.Location = new Point(388, 350);
            filterDButton.Name = "filterDButton";
            filterDButton.Size = new Size(120, 40);
            filterDButton.TabIndex = 21;
            filterDButton.Text = "Filter dentist";
            filterDButton.UseVisualStyleBackColor = false;
            filterDButton.Click += filterDButton_Click;
            // 
            // filterRButton
            // 
            filterRButton.BackColor = Color.SteelBlue;
            filterRButton.FlatAppearance.BorderSize = 0;
            filterRButton.FlatStyle = FlatStyle.Flat;
            filterRButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterRButton.ForeColor = Color.White;
            filterRButton.Location = new Point(262, 350);
            filterRButton.Name = "filterRButton";
            filterRButton.Size = new Size(120, 40);
            filterRButton.TabIndex = 20;
            filterRButton.Text = "Filter room";
            filterRButton.UseVisualStyleBackColor = false;
            filterRButton.Click += filterRButton_Click;
            // 
            // filterPButton
            // 
            filterPButton.BackColor = Color.SteelBlue;
            filterPButton.FlatAppearance.BorderSize = 0;
            filterPButton.FlatStyle = FlatStyle.Flat;
            filterPButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterPButton.ForeColor = Color.White;
            filterPButton.Location = new Point(136, 350);
            filterPButton.Name = "filterPButton";
            filterPButton.Size = new Size(120, 40);
            filterPButton.TabIndex = 19;
            filterPButton.Text = "Filter patient";
            filterPButton.UseVisualStyleBackColor = false;
            filterPButton.Click += filterPButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(50, 350);
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
            panel4.Controls.Add(customerBox);
            panel4.Controls.Add(roomBox);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label);
            panel4.Controls.Add(statusBox);
            panel4.Controls.Add(dentistBox);
            panel4.Controls.Add(assistantBox);
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
            // roomBox
            // 
            roomBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomBox.Location = new Point(550, 115);
            roomBox.Name = "roomBox";
            roomBox.PlaceholderText = "Room";
            roomBox.ReadOnly = true;
            roomBox.Size = new Size(150, 27);
            roomBox.TabIndex = 18;
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
            // statusBox
            // 
            statusBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusBox.Location = new Point(225, 45);
            statusBox.Name = "statusBox";
            statusBox.PlaceholderText = "Status";
            statusBox.ReadOnly = true;
            statusBox.Size = new Size(150, 27);
            statusBox.TabIndex = 14;
            // 
            // dentistBox
            // 
            dentistBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentistBox.Location = new Point(100, 185);
            dentistBox.Name = "dentistBox";
            dentistBox.PlaceholderText = "Dentist name";
            dentistBox.ReadOnly = true;
            dentistBox.Size = new Size(275, 27);
            dentistBox.TabIndex = 13;
            // 
            // assistantBox
            // 
            assistantBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assistantBox.Location = new Point(425, 185);
            assistantBox.Name = "assistantBox";
            assistantBox.PlaceholderText = "Assistant name";
            assistantBox.ReadOnly = true;
            assistantBox.Size = new Size(275, 27);
            assistantBox.TabIndex = 12;
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
            appointTime.Enabled = false;
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
            appointDate.Enabled = false;
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
            // noteBox
            // 
            noteBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteBox.Location = new Point(100, 255);
            noteBox.Name = "noteBox";
            noteBox.PlaceholderText = "Note";
            noteBox.ReadOnly = true;
            noteBox.Size = new Size(600, 27);
            noteBox.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(100, 229);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 26;
            label7.Text = "Note";
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Appointment";
            Text = "Appointment";
            Load += Appointment_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button filterDButton;
        private Button filterRButton;
        private Button filterPButton;
        private Button refreshButton;
        private Label label1;
        private Panel panel4;
        private TextBox customerBox;
        private TextBox roomBox;
        private Label label8;
        private Label label9;
        private Label label;
        private TextBox statusBox;
        private TextBox dentistBox;
        private TextBox assistantBox;
        private Label label6;
        private TextBox appIDBox;
        private Label label5;
        private Label label4;
        private DateTimePicker appointTime;
        private Label label3;
        private Label label2;
        private DateTimePicker appointDate;
        private DataGridView appointmentData;
        private Label label7;
        private TextBox noteBox;
    }
}