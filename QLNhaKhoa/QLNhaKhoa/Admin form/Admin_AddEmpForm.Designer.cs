namespace QLNhaKhoa.Admin_form
{
    partial class Admin_AddEmpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AddEmpForm));
            cancelButton = new Button();
            AddEmpButton = new Button();
            txtAddress = new TextBox();
            label4 = new Label();
            medNameBox = new TextBox();
            txtPhone = new TextBox();
            txtName = new Label();
            label6 = new Label();
            txtBday = new DateTimePicker();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            label1 = new Label();
            cboGender = new ComboBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            cboEmpType = new ComboBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(311, 504);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 50);
            cancelButton.TabIndex = 32;
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
            AddEmpButton.Location = new Point(71, 504);
            AddEmpButton.Name = "AddEmpButton";
            AddEmpButton.Size = new Size(200, 50);
            AddEmpButton.TabIndex = 31;
            AddEmpButton.Text = "Add Employee";
            AddEmpButton.UseVisualStyleBackColor = false;
            AddEmpButton.Click += AddEmpButton_Click;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(71, 360);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(440, 27);
            txtAddress.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(71, 174);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 35;
            label4.Text = "Date of birth";
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(71, 120);
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Name";
            medNameBox.Size = new Size(300, 27);
            medNameBox.TabIndex = 36;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(311, 200);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone number";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 38;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.SteelBlue;
            txtName.Location = new Point(71, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(57, 23);
            txtName.TabIndex = 39;
            txtName.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(311, 174);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 40;
            label6.Text = "Phone number";
            // 
            // txtBday
            // 
            txtBday.CustomFormat = "yyyy-MM-dd";
            txtBday.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBday.Format = DateTimePickerFormat.Custom;
            txtBday.Location = new Point(71, 200);
            txtBday.Name = "txtBday";
            txtBday.Size = new Size(200, 27);
            txtBday.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(71, 254);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 42;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(71, 280);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(71, 334);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 44;
            label8.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(195, 34);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 45;
            label1.Text = "Add Employee";
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(411, 120);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(100, 27);
            cboGender.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(411, 94);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 47;
            label2.Text = "Gender";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(71, 440);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(71, 414);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 49;
            label3.Text = "Username";
            // 
            // cboEmpType
            // 
            cboEmpType.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEmpType.FormattingEnabled = true;
            cboEmpType.Items.AddRange(new object[] { "Dentist", "Employee" });
            cboEmpType.Location = new Point(411, 280);
            cboEmpType.Name = "cboEmpType";
            cboEmpType.Size = new Size(100, 27);
            cboEmpType.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(411, 254);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 51;
            label5.Text = "Emp type";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(311, 440);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(311, 414);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 53;
            label9.Text = "Password";
            // 
            // Admin_AddEmpForm
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
            Name = "Admin_AddEmpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelButton;
        private Button AddEmpButton;
        private TextBox txtAddress;
        private Label label4;
        private TextBox medNameBox;
        private TextBox txtPhone;
        private Label txtName;
        private Label label6;
        private DateTimePicker txtBday;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private Label label1;
        private ComboBox cboGender;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private ComboBox cboEmpType;
        private Label label5;
        private TextBox txtPassword;
        private Label label9;
    }
}