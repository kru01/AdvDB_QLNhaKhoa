namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dentist_Main));
            LeftPanel = new Panel();
            signOutButton = new Button();
            PrecriptionButton = new Button();
            certificateButton = new Button();
            credit = new Label();
            DentistID = new Label();
            dentistName = new Label();
            IDLabel = new Label();
            HomepageIcon = new PictureBox();
            RecordButton = new Button();
            AppointmentButton = new Button();
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
            LeftPanel.Controls.Add(PrecriptionButton);
            LeftPanel.Controls.Add(certificateButton);
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(DentistID);
            LeftPanel.Controls.Add(dentistName);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(HomepageIcon);
            LeftPanel.Controls.Add(RecordButton);
            LeftPanel.Controls.Add(AppointmentButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(300, 700);
            LeftPanel.TabIndex = 2;
            // 
            // signOutButton
            // 
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(25, 550);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(250, 40);
            signOutButton.TabIndex = 11;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
            // 
            // PrecriptionButton
            // 
            PrecriptionButton.FlatAppearance.BorderSize = 0;
            PrecriptionButton.FlatStyle = FlatStyle.Flat;
            PrecriptionButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecriptionButton.ForeColor = Color.White;
            PrecriptionButton.Location = new Point(25, 490);
            PrecriptionButton.Name = "PrecriptionButton";
            PrecriptionButton.Size = new Size(250, 40);
            PrecriptionButton.TabIndex = 10;
            PrecriptionButton.Text = "Prescription";
            PrecriptionButton.UseVisualStyleBackColor = true;
            PrecriptionButton.Click += PrecriptionButton_Click;
            // 
            // certificateButton
            // 
            certificateButton.FlatAppearance.BorderSize = 0;
            certificateButton.FlatStyle = FlatStyle.Flat;
            certificateButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            certificateButton.ForeColor = Color.White;
            certificateButton.Location = new Point(25, 430);
            certificateButton.Name = "certificateButton";
            certificateButton.Size = new Size(250, 40);
            certificateButton.TabIndex = 9;
            certificateButton.Text = "Medical ceritificate";
            certificateButton.UseVisualStyleBackColor = true;
            certificateButton.Click += certificateButton_Click;
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
            // DentistID
            // 
            DentistID.AutoSize = true;
            DentistID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DentistID.ForeColor = Color.White;
            DentistID.Location = new Point(84, 0);
            DentistID.Name = "DentistID";
            DentistID.Size = new Size(65, 23);
            DentistID.TabIndex = 7;
            DentistID.Text = "AB123";
            // 
            // dentistName
            // 
            dentistName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dentistName.ForeColor = Color.White;
            dentistName.Location = new Point(0, 200);
            dentistName.Name = "dentistName";
            dentistName.Size = new Size(300, 28);
            dentistName.TabIndex = 6;
            dentistName.Text = "<Dentist Name>";
            dentistName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(0, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(88, 23);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "Dentist ID:";
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
            // RecordButton
            // 
            RecordButton.FlatAppearance.BorderSize = 0;
            RecordButton.FlatStyle = FlatStyle.Flat;
            RecordButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordButton.ForeColor = Color.White;
            RecordButton.Location = new Point(25, 370);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(250, 40);
            RecordButton.TabIndex = 3;
            RecordButton.Text = "Patient record";
            RecordButton.UseVisualStyleBackColor = true;
            RecordButton.Click += RecordButton_Click;
            // 
            // AppointmentButton
            // 
            AppointmentButton.FlatAppearance.BorderSize = 0;
            AppointmentButton.FlatStyle = FlatStyle.Flat;
            AppointmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.White;
            AppointmentButton.Location = new Point(25, 310);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(250, 40);
            AppointmentButton.TabIndex = 2;
            AppointmentButton.Text = "Appointment";
            AppointmentButton.UseVisualStyleBackColor = true;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // AccountButton
            // 
            AccountButton.FlatAppearance.BorderSize = 0;
            AccountButton.FlatStyle = FlatStyle.Flat;
            AccountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountButton.ForeColor = Color.White;
            AccountButton.Location = new Point(25, 250);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(250, 40);
            AccountButton.TabIndex = 1;
            AccountButton.Text = "Account";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 700);
            mainPanel.TabIndex = 3;
            // 
            // Dentist_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(mainPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dentist_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentist Dashboard";
            Load += Dentist_Main_Load;
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label credit;
        private Label DentistID;
        private Label dentistName;
        private Label IDLabel;
        private PictureBox HomepageIcon;
        private Button RecordButton;
        private Button AppointmentButton;
        private Button AccountButton;
        private Button signOutButton;
        private Button PrecriptionButton;
        private Button certificateButton;
        private Panel mainPanel;
    }
}