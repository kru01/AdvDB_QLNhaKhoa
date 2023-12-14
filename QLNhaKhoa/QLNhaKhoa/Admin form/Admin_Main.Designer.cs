namespace QLNhaKhoa.Admin_form
{
    partial class Admin_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Main));
            LeftPanel = new Panel();
            signOutButton = new Button();
            credit = new Label();
            AdminID = new Label();
            AdminName = new Label();
            IDLabel = new Label();
            HomepageIcon = new PictureBox();
            MedicationButton = new Button();
            EmployeeButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(signOutButton);
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(AdminID);
            LeftPanel.Controls.Add(AdminName);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(HomepageIcon);
            LeftPanel.Controls.Add(MedicationButton);
            LeftPanel.Controls.Add(EmployeeButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(300, 700);
            LeftPanel.TabIndex = 3;
            // 
            // signOutButton
            // 
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(25, 500);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(250, 50);
            signOutButton.TabIndex = 9;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            credit.ForeColor = Color.White;
            credit.Location = new Point(101, 677);
            credit.Name = "credit";
            credit.Size = new Size(199, 23);
            credit.TabIndex = 8;
            credit.Text = "Developed by Group 3";
            // 
            // AdminID
            // 
            AdminID.AutoSize = true;
            AdminID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminID.ForeColor = Color.White;
            AdminID.Location = new Point(84, 0);
            AdminID.Name = "AdminID";
            AdminID.Size = new Size(65, 23);
            AdminID.TabIndex = 7;
            AdminID.Text = "AB123";
            // 
            // AdminName
            // 
            AdminName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminName.ForeColor = Color.White;
            AdminName.Location = new Point(0, 210);
            AdminName.Name = "AdminName";
            AdminName.Size = new Size(300, 28);
            AdminName.TabIndex = 6;
            AdminName.Text = "<Admin Name>";
            AdminName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(0, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(85, 23);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "Admin ID:";
            // 
            // HomepageIcon
            // 
            HomepageIcon.Image = Properties.Resources.account1;
            HomepageIcon.Location = new Point(100, 100);
            HomepageIcon.Name = "HomepageIcon";
            HomepageIcon.Size = new Size(100, 100);
            HomepageIcon.SizeMode = PictureBoxSizeMode.Zoom;
            HomepageIcon.TabIndex = 4;
            HomepageIcon.TabStop = false;
            // 
            // MedicationButton
            // 
            MedicationButton.FlatAppearance.BorderSize = 0;
            MedicationButton.FlatStyle = FlatStyle.Flat;
            MedicationButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedicationButton.ForeColor = Color.White;
            MedicationButton.Location = new Point(25, 425);
            MedicationButton.Name = "MedicationButton";
            MedicationButton.Size = new Size(250, 50);
            MedicationButton.TabIndex = 3;
            MedicationButton.Text = "Medication";
            MedicationButton.UseVisualStyleBackColor = true;
            MedicationButton.Click += MedicationButton_Click;
            // 
            // EmployeeButton
            // 
            EmployeeButton.FlatAppearance.BorderSize = 0;
            EmployeeButton.FlatStyle = FlatStyle.Flat;
            EmployeeButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeButton.ForeColor = Color.White;
            EmployeeButton.Location = new Point(25, 350);
            EmployeeButton.Name = "EmployeeButton";
            EmployeeButton.Size = new Size(250, 50);
            EmployeeButton.TabIndex = 2;
            EmployeeButton.Text = "Employee List";
            EmployeeButton.UseVisualStyleBackColor = true;
            EmployeeButton.Click += EmployeeButton_Click;
            // 
            // AccountButton
            // 
            AccountButton.FlatAppearance.BorderSize = 0;
            AccountButton.FlatStyle = FlatStyle.Flat;
            AccountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountButton.ForeColor = Color.White;
            AccountButton.Location = new Point(25, 275);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(250, 50);
            AccountButton.TabIndex = 1;
            AccountButton.Text = "Account";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 700);
            mainPanel.TabIndex = 4;
            // 
            // Admin_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(mainPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += Admin_Main_Load;
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label credit;
        private Label AdminID;
        private Label AdminName;
        private Label IDLabel;
        private PictureBox HomepageIcon;
        private Button MedicationButton;
        private Button EmployeeButton;
        private Button AccountButton;
        private Panel mainPanel;
        private Button signOutButton;
    }
}