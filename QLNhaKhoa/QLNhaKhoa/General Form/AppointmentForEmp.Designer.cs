namespace QLNhaKhoa.General_Form
{
    partial class AppointmentForEmp
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
            addButton = new Button();
            deleteButton = new Button();
            button1 = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(addButton);
            panel3.Controls.Add(filterDButton);
            panel3.Controls.Add(filterRButton);
            panel3.Controls.Add(filterPButton);
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(appointmentData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1125, 875);
            panel3.TabIndex = 14;
            // 
            // filterDButton
            // 
            filterDButton.BackColor = Color.SteelBlue;
            filterDButton.FlatAppearance.BorderSize = 0;
            filterDButton.FlatStyle = FlatStyle.Flat;
            filterDButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterDButton.ForeColor = Color.White;
            filterDButton.Location = new Point(459, 372);
            filterDButton.Margin = new Padding(4);
            filterDButton.Name = "filterDButton";
            filterDButton.Size = new Size(139, 81);
            filterDButton.TabIndex = 21;
            filterDButton.Text = "Filter by dentist";
            filterDButton.UseVisualStyleBackColor = false;
            // 
            // filterRButton
            // 
            filterRButton.BackColor = Color.SteelBlue;
            filterRButton.FlatAppearance.BorderSize = 0;
            filterRButton.FlatStyle = FlatStyle.Flat;
            filterRButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterRButton.ForeColor = Color.White;
            filterRButton.Location = new Point(303, 372);
            filterRButton.Margin = new Padding(4);
            filterRButton.Name = "filterRButton";
            filterRButton.Size = new Size(139, 81);
            filterRButton.TabIndex = 20;
            filterRButton.Text = "Filter by room";
            filterRButton.UseVisualStyleBackColor = false;
            // 
            // filterPButton
            // 
            filterPButton.BackColor = Color.SteelBlue;
            filterPButton.FlatAppearance.BorderSize = 0;
            filterPButton.FlatStyle = FlatStyle.Flat;
            filterPButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterPButton.ForeColor = Color.White;
            filterPButton.Location = new Point(141, 372);
            filterPButton.Margin = new Padding(4);
            filterPButton.Name = "filterPButton";
            filterPButton.Size = new Size(139, 81);
            filterPButton.TabIndex = 19;
            filterPButton.Text = "Filter by patient";
            filterPButton.UseVisualStyleBackColor = false;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(8, 387);
            refreshButton.Margin = new Padding(4);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(125, 50);
            refreshButton.TabIndex = 15;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(459, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 42);
            label1.TabIndex = 0;
            label1.Text = "Appointment";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
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
            panel4.Location = new Point(62, 50);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 312);
            panel4.TabIndex = 0;
            // 
            // customerBox
            // 
            customerBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerBox.Location = new Point(125, 150);
            customerBox.Margin = new Padding(4);
            customerBox.Name = "customerBox";
            customerBox.PlaceholderText = "Customer name";
            customerBox.ReadOnly = true;
            customerBox.Size = new Size(530, 31);
            customerBox.TabIndex = 19;
            // 
            // roomBox
            // 
            roomBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomBox.Location = new Point(688, 150);
            roomBox.Margin = new Padding(4);
            roomBox.Name = "roomBox";
            roomBox.PlaceholderText = "Room";
            roomBox.ReadOnly = true;
            roomBox.Size = new Size(186, 31);
            roomBox.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(125, 118);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 17;
            label8.Text = "Customer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(688, 118);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(64, 28);
            label9.TabIndex = 16;
            label9.Text = "Room";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.SteelBlue;
            label.Location = new Point(281, 30);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(70, 28);
            label.TabIndex = 15;
            label.Text = "Status";
            // 
            // statusBox
            // 
            statusBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusBox.Location = new Point(281, 62);
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
            dentistBox.Location = new Point(125, 238);
            dentistBox.Margin = new Padding(4);
            dentistBox.Name = "dentistBox";
            dentistBox.PlaceholderText = "Dentist name";
            dentistBox.ReadOnly = true;
            dentistBox.Size = new Size(343, 31);
            dentistBox.TabIndex = 13;
            // 
            // assistantBox
            // 
            assistantBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assistantBox.Location = new Point(531, 238);
            assistantBox.Margin = new Padding(4);
            assistantBox.Name = "assistantBox";
            assistantBox.PlaceholderText = "Assistant name";
            assistantBox.ReadOnly = true;
            assistantBox.Size = new Size(343, 31);
            assistantBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(125, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 28);
            label6.TabIndex = 11;
            label6.Text = "Appoint ID";
            // 
            // appIDBox
            // 
            appIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appIDBox.Location = new Point(125, 62);
            appIDBox.Margin = new Padding(4);
            appIDBox.Name = "appIDBox";
            appIDBox.PlaceholderText = "Appoint ID";
            appIDBox.ReadOnly = true;
            appIDBox.Size = new Size(124, 31);
            appIDBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(531, 205);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 9;
            label5.Text = "Assistant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(125, 205);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 8;
            label4.Text = "Dentist";
            // 
            // appointTime
            // 
            appointTime.CustomFormat = "HH:mm";
            appointTime.Enabled = false;
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Format = DateTimePickerFormat.Custom;
            appointTime.Location = new Point(531, 62);
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
            label3.Location = new Point(688, 30);
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
            label2.Location = new Point(531, 30);
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
            appointDate.Location = new Point(688, 62);
            appointDate.Margin = new Padding(4);
            appointDate.Name = "appointDate";
            appointDate.Size = new Size(186, 31);
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
            appointmentData.Location = new Point(0, 525);
            appointmentData.Margin = new Padding(4);
            appointmentData.Name = "appointmentData";
            appointmentData.RowHeadersWidth = 51;
            appointmentData.Size = new Size(1125, 350);
            appointmentData.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.BackColor = Color.SteelBlue;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(615, 372);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(139, 81);
            addButton.TabIndex = 22;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.SteelBlue;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(923, 372);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(139, 81);
            deleteButton.TabIndex = 24;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(772, 372);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(139, 81);
            button1.TabIndex = 25;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            // 
            // AppointmentForEmp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 875);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppointmentForEmp";
            Text = "AppointmentForEmp";
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
        private Button addButton;
        private Button deleteButton;
        private Button button1;
    }
}