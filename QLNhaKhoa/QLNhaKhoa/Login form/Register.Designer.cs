


namespace QLNhaKhoa
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            LeftPanel = new Panel();
            credit = new Label();
            Title = new Label();
            Logo = new PictureBox();
            RightPanel = new Panel();
            panel3 = new Panel();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            txtEmail = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            cboGender = new ComboBox();
            pictureBox1 = new PictureBox();
            txtBday = new DateTimePicker();
            txtUsername = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            div5 = new Panel();
            div4 = new Panel();
            div3 = new Panel();
            div2 = new Panel();
            div1 = new Panel();
            passIcon = new PictureBox();
            phoneIcon = new PictureBox();
            addressIcon = new PictureBox();
            birthdayIcon = new PictureBox();
            nameIcon = new PictureBox();
            loginSwap = new Button();
            registerButton = new Button();
            label1 = new Label();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phoneIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addressIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)birthdayIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nameIcon).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(Title);
            LeftPanel.Controls.Add(Logo);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(350, 550);
            LeftPanel.TabIndex = 0;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            credit.ForeColor = Color.White;
            credit.Location = new Point(151, 527);
            credit.Name = "credit";
            credit.Size = new Size(199, 23);
            credit.TabIndex = 2;
            credit.Text = "Developed by Group 3";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Tw Cen MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(94, 275);
            Title.Name = "Title";
            Title.Size = new Size(162, 54);
            Title.TabIndex = 1;
            Title.Text = "AZURE";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(115, 150);
            Logo.Name = "Logo";
            Logo.Size = new Size(120, 120);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.White;
            RightPanel.Controls.Add(panel3);
            RightPanel.Controls.Add(txtPassword);
            RightPanel.Controls.Add(pictureBox3);
            RightPanel.Controls.Add(txtEmail);
            RightPanel.Controls.Add(pictureBox2);
            RightPanel.Controls.Add(panel2);
            RightPanel.Controls.Add(panel1);
            RightPanel.Controls.Add(cboGender);
            RightPanel.Controls.Add(pictureBox1);
            RightPanel.Controls.Add(txtBday);
            RightPanel.Controls.Add(txtUsername);
            RightPanel.Controls.Add(txtPhone);
            RightPanel.Controls.Add(txtAddress);
            RightPanel.Controls.Add(txtName);
            RightPanel.Controls.Add(div5);
            RightPanel.Controls.Add(div4);
            RightPanel.Controls.Add(div3);
            RightPanel.Controls.Add(div2);
            RightPanel.Controls.Add(div1);
            RightPanel.Controls.Add(passIcon);
            RightPanel.Controls.Add(phoneIcon);
            RightPanel.Controls.Add(addressIcon);
            RightPanel.Controls.Add(birthdayIcon);
            RightPanel.Controls.Add(nameIcon);
            RightPanel.Controls.Add(loginSwap);
            RightPanel.Controls.Add(registerButton);
            RightPanel.Controls.Add(label1);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(350, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(450, 550);
            RightPanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(50, 426);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 1);
            panel3.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(85, 395);
            txtPassword.MaxLength = 20;
            txtPassword.MinimumSize = new Size(314, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password (max 20)";
            txtPassword.Size = new Size(314, 25);
            txtPassword.TabIndex = 25;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.person;
            pictureBox3.Location = new Point(50, 325);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(85, 265);
            txtEmail.MaxLength = 20;
            txtEmail.MinimumSize = new Size(314, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(314, 25);
            txtEmail.TabIndex = 23;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.email;
            pictureBox2.Location = new Point(50, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(291, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 1);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(219, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 1);
            panel1.TabIndex = 11;
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(327, 67);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(73, 27);
            cboGender.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gender;
            pictureBox1.Location = new Point(291, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // txtBday
            // 
            txtBday.CustomFormat = "yyyy-MM-dd";
            txtBday.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBday.Format = DateTimePickerFormat.Custom;
            txtBday.Location = new Point(86, 133);
            txtBday.MaxDate = new DateTime(2023, 11, 28, 0, 0, 0, 0);
            txtBday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            txtBday.Name = "txtBday";
            txtBday.Size = new Size(110, 27);
            txtBday.TabIndex = 19;
            txtBday.Value = new DateTime(2023, 11, 28, 0, 0, 0, 0);
            txtBday.KeyDown += txtBday_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(86, 330);
            txtUsername.MaxLength = 25;
            txtUsername.MinimumSize = new Size(314, 25);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username (max 25)";
            txtUsername.Size = new Size(314, 25);
            txtUsername.TabIndex = 18;
            txtUsername.KeyDown += txtPassword_KeyDown;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(255, 135);
            txtPhone.MaxLength = 11;
            txtPhone.MinimumSize = new Size(130, 25);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone number";
            txtPhone.Size = new Size(145, 25);
            txtPhone.TabIndex = 17;
            txtPhone.KeyDown += txtPhone_KeyDown;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(86, 200);
            txtAddress.MaxLength = 100;
            txtAddress.MinimumSize = new Size(314, 25);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(314, 25);
            txtAddress.TabIndex = 16;
            txtAddress.KeyDown += txtAddress_KeyDown;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(86, 70);
            txtName.MaxLength = 50;
            txtName.MinimumSize = new Size(180, 25);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(180, 25);
            txtName.TabIndex = 14;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // div5
            // 
            div5.BackColor = Color.Black;
            div5.Location = new Point(50, 361);
            div5.Name = "div5";
            div5.Size = new Size(350, 1);
            div5.TabIndex = 13;
            // 
            // div4
            // 
            div4.BackColor = Color.Black;
            div4.Location = new Point(50, 296);
            div4.Name = "div4";
            div4.Size = new Size(350, 1);
            div4.TabIndex = 12;
            // 
            // div3
            // 
            div3.BackColor = Color.Black;
            div3.Location = new Point(50, 231);
            div3.Name = "div3";
            div3.Size = new Size(350, 1);
            div3.TabIndex = 11;
            // 
            // div2
            // 
            div2.BackColor = Color.Black;
            div2.Location = new Point(50, 166);
            div2.Name = "div2";
            div2.Size = new Size(150, 1);
            div2.TabIndex = 10;
            // 
            // div1
            // 
            div1.BackColor = Color.Black;
            div1.Location = new Point(50, 101);
            div1.Name = "div1";
            div1.Size = new Size(220, 1);
            div1.TabIndex = 9;
            // 
            // passIcon
            // 
            passIcon.Image = Properties.Resources._lock;
            passIcon.Location = new Point(50, 390);
            passIcon.Name = "passIcon";
            passIcon.Size = new Size(30, 30);
            passIcon.SizeMode = PictureBoxSizeMode.Zoom;
            passIcon.TabIndex = 8;
            passIcon.TabStop = false;
            // 
            // phoneIcon
            // 
            phoneIcon.Image = Properties.Resources.phone;
            phoneIcon.Location = new Point(219, 130);
            phoneIcon.Name = "phoneIcon";
            phoneIcon.Size = new Size(30, 30);
            phoneIcon.SizeMode = PictureBoxSizeMode.Zoom;
            phoneIcon.TabIndex = 7;
            phoneIcon.TabStop = false;
            // 
            // addressIcon
            // 
            addressIcon.Image = Properties.Resources.address;
            addressIcon.Location = new Point(50, 195);
            addressIcon.Name = "addressIcon";
            addressIcon.Size = new Size(30, 30);
            addressIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addressIcon.TabIndex = 6;
            addressIcon.TabStop = false;
            // 
            // birthdayIcon
            // 
            birthdayIcon.Image = Properties.Resources.date;
            birthdayIcon.Location = new Point(50, 130);
            birthdayIcon.Name = "birthdayIcon";
            birthdayIcon.Size = new Size(30, 30);
            birthdayIcon.SizeMode = PictureBoxSizeMode.Zoom;
            birthdayIcon.TabIndex = 5;
            birthdayIcon.TabStop = false;
            // 
            // nameIcon
            // 
            nameIcon.Image = Properties.Resources.person;
            nameIcon.Location = new Point(50, 65);
            nameIcon.Name = "nameIcon";
            nameIcon.Size = new Size(30, 30);
            nameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            nameIcon.TabIndex = 4;
            nameIcon.TabStop = false;
            // 
            // loginSwap
            // 
            loginSwap.BackColor = Color.White;
            loginSwap.FlatAppearance.BorderSize = 0;
            loginSwap.FlatStyle = FlatStyle.Flat;
            loginSwap.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginSwap.ForeColor = Color.SteelBlue;
            loginSwap.Location = new Point(178, 500);
            loginSwap.Name = "loginSwap";
            loginSwap.Size = new Size(94, 29);
            loginSwap.TabIndex = 3;
            loginSwap.Text = "Log in";
            loginSwap.UseVisualStyleBackColor = false;
            loginSwap.Click += loginSwap_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.SteelBlue;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(50, 450);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(350, 50);
            registerButton.TabIndex = 2;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(140, 20);
            label1.Name = "label1";
            label1.Size = new Size(170, 43);
            label1.TabIndex = 1;
            label1.Text = "REGISTER";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)passIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)phoneIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)addressIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)birthdayIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nameIcon).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel LeftPanel;
        private Panel RightPanel;
        private PictureBox Logo;
        private Label Title;
        private Label label1;
        private Button registerButton;
        private Button loginSwap;
        private PictureBox nameIcon;
        private PictureBox addressIcon;
        private PictureBox birthdayIcon;
        private PictureBox passIcon;
        private PictureBox phoneIcon;
        private Panel div3;
        private Panel div2;
        private Panel div1;
        private Panel div5;
        private Panel div4;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private DateTimePicker txtBday;
        private Label credit;
        private Panel panel1;
        private ComboBox cboGender;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtEmail;
        private PictureBox pictureBox2;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private Panel panel3;
    }
}