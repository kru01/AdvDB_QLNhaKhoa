namespace QLNhaKhoa.General_Form
{
    partial class AddEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmp));
            label9 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            cboEmpType = new ComboBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            cboGender = new ComboBox();
            label1 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtBday = new DateTimePicker();
            label6 = new Label();
            txtName = new Label();
            txtPhone = new TextBox();
            medNameBox = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            cancelButton = new Button();
            AddEmpButton = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(311, 421);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 74;
            label9.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(311, 447);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(411, 261);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 72;
            label5.Text = "Emp type";
            // 
            // cboEmpType
            // 
            cboEmpType.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEmpType.FormattingEnabled = true;
            cboEmpType.Items.AddRange(new object[] { "Dentist", "Employee" });
            cboEmpType.Location = new Point(411, 287);
            cboEmpType.Name = "cboEmpType";
            cboEmpType.Size = new Size(100, 27);
            cboEmpType.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(71, 421);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 70;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(71, 447);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(411, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 68;
            label2.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(411, 127);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(100, 27);
            cboGender.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(195, 41);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 66;
            label1.Text = "Add Employee";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(71, 341);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 65;
            label8.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(71, 287);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(71, 261);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 63;
            label7.Text = "Email";
            // 
            // txtBday
            // 
            txtBday.CustomFormat = "yyyy-MM-dd";
            txtBday.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBday.Format = DateTimePickerFormat.Custom;
            txtBday.Location = new Point(71, 207);
            txtBday.Name = "txtBday";
            txtBday.Size = new Size(200, 27);
            txtBday.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(311, 181);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 61;
            label6.Text = "Phone number";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.SteelBlue;
            txtName.Location = new Point(71, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(57, 23);
            txtName.TabIndex = 60;
            txtName.Text = "Name";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(311, 207);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone number";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 59;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(71, 127);
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Name";
            medNameBox.Size = new Size(300, 27);
            medNameBox.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(71, 181);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 57;
            label4.Text = "Date of birth";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(71, 367);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(440, 27);
            txtAddress.TabIndex = 56;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(311, 511);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 50);
            cancelButton.TabIndex = 55;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddEmpButton
            // 
            AddEmpButton.BackColor = Color.SteelBlue;
            AddEmpButton.FlatAppearance.BorderSize = 0;
            AddEmpButton.FlatStyle = FlatStyle.Flat;
            AddEmpButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddEmpButton.ForeColor = Color.White;
            AddEmpButton.Location = new Point(71, 511);
            AddEmpButton.Name = "AddEmpButton";
            AddEmpButton.Size = new Size(200, 50);
            AddEmpButton.TabIndex = 54;
            AddEmpButton.Text = "Add Employee";
            AddEmpButton.UseVisualStyleBackColor = false;
            AddEmpButton.Click += AddEmpButton_Click;
            // 
            // AddEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 603);
            Controls.Add(label9);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(cboEmpType);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(cboGender);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(txtBday);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(medNameBox);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(cancelButton);
            Controls.Add(AddEmpButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddEmp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtPassword;
        private Label label5;
        private ComboBox cboEmpType;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private ComboBox cboGender;
        private Label label1;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private DateTimePicker txtBday;
        private Label label6;
        private Label txtName;
        private TextBox txtPhone;
        private TextBox medNameBox;
        private Label label4;
        private TextBox txtAddress;
        private Button cancelButton;
        private Button AddEmpButton;
    }
}