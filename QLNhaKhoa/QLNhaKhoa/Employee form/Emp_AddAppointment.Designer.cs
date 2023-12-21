namespace QLNhaKhoa.Employee_form
{
    partial class Emp_AddAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_AddAppointment));
            label1 = new Label();
            cboName = new ComboBox();
            label6 = new Label();
            appointTime = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            appointDate = new DateTimePicker();
            label7 = new Label();
            cboAssistant = new ComboBox();
            cboDentist = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            noteBox = new TextBox();
            cboRoom = new ComboBox();
            cboStatus = new ComboBox();
            label9 = new Label();
            label = new Label();
            cancelButton = new Button();
            makeAppButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(248, 20);
            label1.Name = "label1";
            label1.Size = new Size(289, 35);
            label1.TabIndex = 0;
            label1.Text = "Make an appointment";
            // 
            // cboName
            // 
            cboName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboName.FormattingEnabled = true;
            cboName.Location = new Point(90, 90);
            cboName.Name = "cboName";
            cboName.Size = new Size(275, 27);
            cboName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(90, 64);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 12;
            label6.Text = "Customer name";
            // 
            // appointTime
            // 
            appointTime.CustomFormat = "HH:mm";
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Format = DateTimePickerFormat.Custom;
            appointTime.Location = new Point(400, 90);
            appointTime.Name = "appointTime";
            appointTime.ShowUpDown = true;
            appointTime.Size = new Size(100, 27);
            appointTime.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(540, 64);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 15;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(400, 64);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 14;
            label2.Text = "Time";
            // 
            // appointDate
            // 
            appointDate.CustomFormat = "yyyy-MM-dd";
            appointDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointDate.Format = DateTimePickerFormat.Custom;
            appointDate.Location = new Point(540, 90);
            appointDate.Name = "appointDate";
            appointDate.Size = new Size(150, 27);
            appointDate.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(90, 289);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 30;
            label7.Text = "Note";
            // 
            // cboAssistant
            // 
            cboAssistant.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAssistant.FormattingEnabled = true;
            cboAssistant.Location = new Point(90, 240);
            cboAssistant.Name = "cboAssistant";
            cboAssistant.Size = new Size(410, 27);
            cboAssistant.TabIndex = 29;
            // 
            // cboDentist
            // 
            cboDentist.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentist.FormattingEnabled = true;
            cboDentist.Location = new Point(91, 165);
            cboDentist.Name = "cboDentist";
            cboDentist.Size = new Size(409, 27);
            cboDentist.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(90, 214);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 27;
            label5.Text = "Assistant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(90, 139);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 26;
            label4.Text = "Dentist";
            // 
            // noteBox
            // 
            noteBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteBox.Location = new Point(90, 315);
            noteBox.Name = "noteBox";
            noteBox.PlaceholderText = "Note";
            noteBox.Size = new Size(600, 27);
            noteBox.TabIndex = 31;
            // 
            // cboRoom
            // 
            cboRoom.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoom.FormattingEnabled = true;
            cboRoom.Items.AddRange(new object[] { "Chọn tình trạng", "Cuộc hẹn mới", "Tái khám" });
            cboRoom.Location = new Point(540, 165);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(150, 27);
            cboRoom.TabIndex = 35;
            // 
            // cboStatus
            // 
            cboStatus.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Cuộc hẹn mới", "Tái khám" });
            cboStatus.Location = new Point(540, 240);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(150, 27);
            cboStatus.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(540, 139);
            label9.Name = "label9";
            label9.Size = new Size(53, 23);
            label9.TabIndex = 33;
            label9.Text = "Room";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.SteelBlue;
            label.Location = new Point(540, 214);
            label.Name = "label";
            label.Size = new Size(57, 23);
            label.TabIndex = 32;
            label.Text = "Status";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(414, 371);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 50);
            cancelButton.TabIndex = 37;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // makeAppButton
            // 
            makeAppButton.BackColor = Color.SteelBlue;
            makeAppButton.FlatAppearance.BorderSize = 0;
            makeAppButton.FlatStyle = FlatStyle.Flat;
            makeAppButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeAppButton.ForeColor = Color.White;
            makeAppButton.Location = new Point(158, 371);
            makeAppButton.Name = "makeAppButton";
            makeAppButton.Size = new Size(250, 50);
            makeAppButton.TabIndex = 36;
            makeAppButton.Text = "Make an appointment";
            makeAppButton.UseVisualStyleBackColor = false;
            makeAppButton.Click += makeAppButton_Click;
            // 
            // Emp_AddAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 453);
            Controls.Add(cancelButton);
            Controls.Add(makeAppButton);
            Controls.Add(cboRoom);
            Controls.Add(cboStatus);
            Controls.Add(label9);
            Controls.Add(label);
            Controls.Add(noteBox);
            Controls.Add(label7);
            Controls.Add(cboAssistant);
            Controls.Add(cboDentist);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(appointTime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(appointDate);
            Controls.Add(label6);
            Controls.Add(cboName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Emp_AddAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Make an appointment";
            Load += Emp_AddAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboName;
        private Label label6;
        private DateTimePicker appointTime;
        private Label label3;
        private Label label2;
        private DateTimePicker appointDate;
        private Label label7;
        private ComboBox cboAssistant;
        private ComboBox cboDentist;
        private Label label5;
        private Label label4;
        private TextBox noteBox;
        private ComboBox cboRoom;
        private ComboBox cboStatus;
        private Label label9;
        private Label label;
        private Button cancelButton;
        private Button makeAppButton;
    }
}