namespace QLNhaKhoa
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LeftPanel = new Panel();
            credit = new Label();
            label1 = new Label();
            Logo = new PictureBox();
            RightPanel = new Panel();
            minimizeButton = new Button();
            txtPassword = new TextBox();
            txtID = new TextBox();
            registerSwap = new Button();
            panel1 = new Panel();
            divider1 = new Panel();
            password = new PictureBox();
            userID = new PictureBox();
            loginButton = new Button();
            label2 = new Label();
            ExitButton = new Button();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userID).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(label1);
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
            credit.TabIndex = 3;
            credit.Text = "Developed by Group 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 275);
            label1.Name = "label1";
            label1.Size = new Size(162, 54);
            label1.TabIndex = 1;
            label1.Text = "AZURE";
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
            RightPanel.Controls.Add(minimizeButton);
            RightPanel.Controls.Add(txtPassword);
            RightPanel.Controls.Add(txtID);
            RightPanel.Controls.Add(registerSwap);
            RightPanel.Controls.Add(panel1);
            RightPanel.Controls.Add(divider1);
            RightPanel.Controls.Add(password);
            RightPanel.Controls.Add(userID);
            RightPanel.Controls.Add(loginButton);
            RightPanel.Controls.Add(label2);
            RightPanel.Controls.Add(ExitButton);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(350, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(450, 550);
            RightPanel.TabIndex = 1;
            // 
            // minimizeButton
            // 
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("VNI-Lithos", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimizeButton.Location = new Point(370, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(40, 40);
            minimizeButton.TabIndex = 12;
            minimizeButton.Text = "-";
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(86, 291);
            txtPassword.MaxLength = 50;
            txtPassword.MinimumSize = new Size(314, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(314, 25);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.None;
            txtID.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(86, 192);
            txtID.MaxLength = 10;
            txtID.MinimumSize = new Size(314, 25);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Enter your ID";
            txtID.Size = new Size(314, 25);
            txtID.TabIndex = 10;
            txtID.KeyDown += txtID_KeyDown;
            // 
            // registerSwap
            // 
            registerSwap.FlatAppearance.BorderSize = 0;
            registerSwap.FlatStyle = FlatStyle.Flat;
            registerSwap.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerSwap.ForeColor = Color.SteelBlue;
            registerSwap.Location = new Point(178, 430);
            registerSwap.Name = "registerSwap";
            registerSwap.Size = new Size(94, 29);
            registerSwap.TabIndex = 7;
            registerSwap.Text = "Register";
            registerSwap.UseVisualStyleBackColor = true;
            registerSwap.Click += registerSwap_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(50, 322);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 1);
            panel1.TabIndex = 6;
            // 
            // divider1
            // 
            divider1.BackColor = Color.Black;
            divider1.Location = new Point(50, 223);
            divider1.Name = "divider1";
            divider1.Size = new Size(350, 1);
            divider1.TabIndex = 5;
            // 
            // password
            // 
            password.Image = Properties.Resources._lock;
            password.Location = new Point(50, 286);
            password.Name = "password";
            password.Size = new Size(30, 30);
            password.SizeMode = PictureBoxSizeMode.Zoom;
            password.TabIndex = 4;
            password.TabStop = false;
            // 
            // userID
            // 
            userID.Image = Properties.Resources.ID;
            userID.Location = new Point(50, 187);
            userID.Name = "userID";
            userID.Size = new Size(30, 30);
            userID.SizeMode = PictureBoxSizeMode.Zoom;
            userID.TabIndex = 3;
            userID.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SteelBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(50, 370);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(350, 50);
            loginButton.TabIndex = 2;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(164, 100);
            label2.Name = "label2";
            label2.Size = new Size(122, 43);
            label2.TabIndex = 1;
            label2.Text = "LOGIN";
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(410, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 550);
            ControlBox = false;
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)password).EndInit();
            ((System.ComponentModel.ISupportInitialize)userID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Panel RightPanel;
        private Button ExitButton;
        private PictureBox Logo;
        private Label label1;
        private Label label2;
        private Button loginButton;
        private PictureBox password;
        private PictureBox userID;
        private Panel panel1;
        private Panel divider1;
        private Button registerSwap;
        private TextBox txtID;
        private TextBox txtPassword;
        private Label credit;
        private Button minimizeButton;
    }
}