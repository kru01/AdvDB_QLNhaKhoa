﻿namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_Main));
            LeftPanel = new Panel();
            prescriptionButton = new Button();
            signOutButton = new Button();
            AppointmentButton = new Button();
            medButton = new Button();
            credit = new Label();
            EmpID = new Label();
            EmpName = new Label();
            IDLabel = new Label();
            HomepageIcon = new PictureBox();
            recordButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            planButton = new Button();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(planButton);
            LeftPanel.Controls.Add(prescriptionButton);
            LeftPanel.Controls.Add(signOutButton);
            LeftPanel.Controls.Add(AppointmentButton);
            LeftPanel.Controls.Add(medButton);
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(EmpID);
            LeftPanel.Controls.Add(EmpName);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(HomepageIcon);
            LeftPanel.Controls.Add(recordButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(300, 700);
            LeftPanel.TabIndex = 4;
            // 
            // prescriptionButton
            // 
            prescriptionButton.FlatAppearance.BorderSize = 0;
            prescriptionButton.FlatStyle = FlatStyle.Flat;
            prescriptionButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prescriptionButton.ForeColor = Color.White;
            prescriptionButton.Location = new Point(25, 450);
            prescriptionButton.Name = "prescriptionButton";
            prescriptionButton.Size = new Size(250, 40);
            prescriptionButton.TabIndex = 15;
            prescriptionButton.Text = "Prescription";
            prescriptionButton.UseVisualStyleBackColor = true;
            prescriptionButton.Click += prescriptionButton_Click;
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
            signOutButton.TabIndex = 14;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
            // 
            // AppointmentButton
            // 
            AppointmentButton.FlatAppearance.BorderSize = 0;
            AppointmentButton.FlatStyle = FlatStyle.Flat;
            AppointmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.White;
            AppointmentButton.Location = new Point(25, 350);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(250, 40);
            AppointmentButton.TabIndex = 13;
            AppointmentButton.Text = "Appointment";
            AppointmentButton.UseVisualStyleBackColor = true;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // medButton
            // 
            medButton.FlatAppearance.BorderSize = 0;
            medButton.FlatStyle = FlatStyle.Flat;
            medButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medButton.ForeColor = Color.White;
            medButton.Location = new Point(25, 400);
            medButton.Name = "medButton";
            medButton.Size = new Size(250, 40);
            medButton.TabIndex = 10;
            medButton.Text = "Medication";
            medButton.UseVisualStyleBackColor = true;
            medButton.Click += medButton_Click;
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
            // EmpID
            // 
            EmpID.AutoSize = true;
            EmpID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpID.ForeColor = Color.White;
            EmpID.Location = new Point(109, 0);
            EmpID.Name = "EmpID";
            EmpID.Size = new Size(65, 23);
            EmpID.TabIndex = 7;
            EmpID.Text = "AB123";
            // 
            // EmpName
            // 
            EmpName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpName.ForeColor = Color.White;
            EmpName.Location = new Point(0, 210);
            EmpName.Name = "EmpName";
            EmpName.Size = new Size(300, 28);
            EmpName.TabIndex = 6;
            EmpName.Text = "<Employee Name>";
            EmpName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(0, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(113, 23);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "Employee ID:";
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
            // recordButton
            // 
            recordButton.FlatAppearance.BorderSize = 0;
            recordButton.FlatStyle = FlatStyle.Flat;
            recordButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordButton.ForeColor = Color.White;
            recordButton.Location = new Point(25, 300);
            recordButton.Name = "recordButton";
            recordButton.Size = new Size(250, 40);
            recordButton.TabIndex = 2;
            recordButton.Text = "Patient record";
            recordButton.UseVisualStyleBackColor = true;
            recordButton.Click += recordButton_Click;
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
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 700);
            mainPanel.TabIndex = 5;
            // 
            // planButton
            // 
            planButton.FlatAppearance.BorderSize = 0;
            planButton.FlatStyle = FlatStyle.Flat;
            planButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planButton.ForeColor = Color.White;
            planButton.Location = new Point(25, 500);
            planButton.Name = "planButton";
            planButton.Size = new Size(250, 40);
            planButton.TabIndex = 16;
            planButton.Text = "Treatment plan";
            planButton.UseVisualStyleBackColor = true;
            planButton.Click += planButton_Click;
            // 
            // Emp_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(mainPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Emp_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Dashboard";
            Load += Emp_Main_Load;
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label credit;
        private Label EmpID;
        private Label EmpName;
        private Label IDLabel;
        private PictureBox HomepageIcon;
        private Button recordButton;
        private Button AccountButton;
        private Panel mainPanel;
        private Button medButton;
        private Button AppointmentButton;
        private Button signOutButton;
        private Button prescriptionButton;
        private Button planButton;
    }
}