namespace QLNhaKhoa.Appointment_Setup_Emp
{
    partial class Add_Appointment
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
            label1 = new Label();
            panel4 = new Panel();
            recordlabel = new Label();
            recordBox = new TextBox();
            label10 = new Label();
            roomBox = new TextBox();
            label9 = new Label();
            label = new Label();
            statusBox = new TextBox();
            dentistBox = new TextBox();
            assistantBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            appointTime = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            appointDate = new DateTimePicker();
            AddButton = new Button();
            cancelButton = new Button();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(442, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 42);
            label1.TabIndex = 1;
            label1.Text = "Add Appointment";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(recordlabel);
            panel4.Controls.Add(recordBox);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(roomBox);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label);
            panel4.Controls.Add(statusBox);
            panel4.Controls.Add(dentistBox);
            panel4.Controls.Add(assistantBox);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(appointTime);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(appointDate);
            panel4.Location = new Point(75, 51);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 407);
            panel4.TabIndex = 2;
            // 
            // recordlabel
            // 
            recordlabel.AutoSize = true;
            recordlabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordlabel.ForeColor = Color.SteelBlue;
            recordlabel.Location = new Point(126, 76);
            recordlabel.Margin = new Padding(4, 0, 4, 0);
            recordlabel.Name = "recordlabel";
            recordlabel.Size = new Size(98, 28);
            recordlabel.TabIndex = 26;
            recordlabel.Text = "IDRecord";
            // 
            // recordBox
            // 
            recordBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordBox.Location = new Point(126, 108);
            recordBox.Margin = new Padding(4);
            recordBox.Name = "recordBox";
            recordBox.PlaceholderText = "Record";
            recordBox.ReadOnly = true;
            recordBox.Size = new Size(186, 31);
            recordBox.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(126, 63);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 28);
            label10.TabIndex = 24;
            // 
            // roomBox
            // 
            roomBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomBox.Location = new Point(126, 271);
            roomBox.Margin = new Padding(4);
            roomBox.Name = "roomBox";
            roomBox.PlaceholderText = "Room ID";
            roomBox.ReadOnly = true;
            roomBox.Size = new Size(186, 31);
            roomBox.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(126, 239);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 28);
            label9.TabIndex = 16;
            label9.Text = "Room ID";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.SteelBlue;
            label.Location = new Point(126, 153);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(70, 28);
            label.TabIndex = 15;
            label.Text = "Status";
            // 
            // statusBox
            // 
            statusBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusBox.Location = new Point(126, 185);
            statusBox.Margin = new Padding(4);
            statusBox.Name = "statusBox";
            statusBox.PlaceholderText = "Status";
            statusBox.ReadOnly = true;
            statusBox.Size = new Size(186, 31);
            statusBox.TabIndex = 14;
            // 
            // dentistBox
            // 
            dentistBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentistBox.Location = new Point(126, 353);
            dentistBox.Margin = new Padding(4);
            dentistBox.Name = "dentistBox";
            dentistBox.PlaceholderText = "ID Dentist";
            dentistBox.ReadOnly = true;
            dentistBox.Size = new Size(343, 31);
            dentistBox.TabIndex = 13;
            // 
            // assistantBox
            // 
            assistantBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assistantBox.Location = new Point(532, 353);
            assistantBox.Margin = new Padding(4);
            assistantBox.Name = "assistantBox";
            assistantBox.PlaceholderText = "ID Assistant";
            assistantBox.ReadOnly = true;
            assistantBox.Size = new Size(343, 31);
            assistantBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(126, 140);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(532, 320);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 9;
            label5.Text = "ID Assistant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(126, 320);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 8;
            label4.Text = "ID Dentist";
            // 
            // appointTime
            // 
            appointTime.CustomFormat = "HH:mm";
            appointTime.Enabled = false;
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Format = DateTimePickerFormat.Custom;
            appointTime.Location = new Point(376, 185);
            appointTime.Margin = new Padding(4);
            appointTime.Name = "appointTime";
            appointTime.ShowUpDown = true;
            appointTime.Size = new Size(124, 31);
            appointTime.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(533, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 4;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(376, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 3;
            label2.Text = "Time";
            // 
            // appointDate
            // 
            appointDate.CustomFormat = "yyyy-MM-dd";
            appointDate.Enabled = false;
            appointDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointDate.Format = DateTimePickerFormat.Custom;
            appointDate.Location = new Point(533, 185);
            appointDate.Margin = new Padding(4);
            appointDate.Name = "appointDate";
            appointDate.Size = new Size(186, 31);
            appointDate.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SteelBlue;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(586, 478);
            AddButton.Margin = new Padding(4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(188, 50);
            AddButton.TabIndex = 20;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.SteelBlue;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(372, 478);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(188, 50);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // Add_Appointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 541);
            Controls.Add(cancelButton);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Appointment";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel4;
        private TextBox roomBox;
        private Label label9;
        private Label label;
        private TextBox statusBox;
        private TextBox dentistBox;
        private TextBox assistantBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker appointTime;
        private Label label3;
        private Label label2;
        private DateTimePicker appointDate;
        private Button AddButton;
        private Label recordlabel;
        private TextBox recordBox;
        private Label label10;
        private Button cancelButton;
    }
}