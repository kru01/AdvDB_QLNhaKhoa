namespace QLNhaKhoa.Employee_form
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
            AppointmentButton = new Button();
            BillButton = new Button();
            MedicationButton = new Button();
            PrescriptionButton = new Button();
            CusSerButton = new Button();
            credit = new Label();
            EmpID = new Label();
            EmpName = new Label();
            IDLabel = new Label();
            HomepageIcon = new PictureBox();
            MedCertButton = new Button();
            MedRecdButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            ExitButton = new Button();
            minimizeButton = new Button();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(AppointmentButton);
            LeftPanel.Controls.Add(BillButton);
            LeftPanel.Controls.Add(MedicationButton);
            LeftPanel.Controls.Add(PrescriptionButton);
            LeftPanel.Controls.Add(CusSerButton);
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(EmpID);
            LeftPanel.Controls.Add(EmpName);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(HomepageIcon);
            LeftPanel.Controls.Add(MedCertButton);
            LeftPanel.Controls.Add(MedRecdButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(300, 740);
            LeftPanel.TabIndex = 4;
            // 
            // AppointmentButton
            // 
            AppointmentButton.FlatAppearance.BorderSize = 0;
            AppointmentButton.FlatStyle = FlatStyle.Flat;
            AppointmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.White;
            AppointmentButton.Location = new Point(25, 600);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(250, 40);
            AppointmentButton.TabIndex = 13;
            AppointmentButton.Text = "Appointment";
            AppointmentButton.UseVisualStyleBackColor = true;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // BillButton
            // 
            BillButton.FlatAppearance.BorderSize = 0;
            BillButton.FlatStyle = FlatStyle.Flat;
            BillButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BillButton.ForeColor = Color.White;
            BillButton.Location = new Point(25, 550);
            BillButton.Name = "BillButton";
            BillButton.Size = new Size(250, 40);
            BillButton.TabIndex = 12;
            BillButton.Text = "Medical Bill";
            BillButton.UseVisualStyleBackColor = true;
            BillButton.Click += BillButton_Click;
            // 
            // MedicationButton
            // 
            MedicationButton.FlatAppearance.BorderSize = 0;
            MedicationButton.FlatStyle = FlatStyle.Flat;
            MedicationButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedicationButton.ForeColor = Color.White;
            MedicationButton.Location = new Point(25, 500);
            MedicationButton.Name = "MedicationButton";
            MedicationButton.Size = new Size(250, 40);
            MedicationButton.TabIndex = 11;
            MedicationButton.Text = "Medication";
            MedicationButton.UseVisualStyleBackColor = true;
            MedicationButton.Click += MedicationButton_Click;
            // 
            // PrescriptionButton
            // 
            PrescriptionButton.FlatAppearance.BorderSize = 0;
            PrescriptionButton.FlatStyle = FlatStyle.Flat;
            PrescriptionButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrescriptionButton.ForeColor = Color.White;
            PrescriptionButton.Location = new Point(25, 450);
            PrescriptionButton.Name = "PrescriptionButton";
            PrescriptionButton.Size = new Size(250, 40);
            PrescriptionButton.TabIndex = 10;
            PrescriptionButton.Text = "Prescription";
            PrescriptionButton.UseVisualStyleBackColor = true;
            PrescriptionButton.Click += PrescriptionButton_Click;
            // 
            // CusSerButton
            // 
            CusSerButton.FlatAppearance.BorderSize = 0;
            CusSerButton.FlatStyle = FlatStyle.Flat;
            CusSerButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CusSerButton.ForeColor = Color.White;
            CusSerButton.Location = new Point(25, 400);
            CusSerButton.Name = "CusSerButton";
            CusSerButton.Size = new Size(250, 40);
            CusSerButton.TabIndex = 9;
            CusSerButton.Text = "Customer services";
            CusSerButton.UseVisualStyleBackColor = true;
            CusSerButton.Click += CusSerButton_Click;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            credit.ForeColor = Color.White;
            credit.Location = new Point(101, 717);
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
            // MedCertButton
            // 
            MedCertButton.FlatAppearance.BorderSize = 0;
            MedCertButton.FlatStyle = FlatStyle.Flat;
            MedCertButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedCertButton.ForeColor = Color.White;
            MedCertButton.Location = new Point(15, 350);
            MedCertButton.Name = "MedCertButton";
            MedCertButton.Size = new Size(270, 40);
            MedCertButton.TabIndex = 3;
            MedCertButton.Text = "Medical certificate list";
            MedCertButton.UseVisualStyleBackColor = true;
            MedCertButton.Click += MedCertButton_Click;
            // 
            // MedRecdButton
            // 
            MedRecdButton.FlatAppearance.BorderSize = 0;
            MedRecdButton.FlatStyle = FlatStyle.Flat;
            MedRecdButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedRecdButton.ForeColor = Color.White;
            MedRecdButton.Location = new Point(25, 300);
            MedRecdButton.Name = "MedRecdButton";
            MedRecdButton.Size = new Size(250, 40);
            MedRecdButton.TabIndex = 2;
            MedRecdButton.Text = "Medical record list";
            MedRecdButton.UseVisualStyleBackColor = true;
            MedRecdButton.Click += MedRecdButton_Click;
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
            mainPanel.Location = new Point(300, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 700);
            mainPanel.TabIndex = 5;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(1160, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("VNI-Lithos", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimizeButton.Location = new Point(1120, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(40, 40);
            minimizeButton.TabIndex = 15;
            minimizeButton.Text = "-";
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // Emp_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 740);
            ControlBox = false;
            Controls.Add(minimizeButton);
            Controls.Add(ExitButton);
            Controls.Add(mainPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button CusSerButton;
        private Label credit;
        private Label EmpID;
        private Label EmpName;
        private Label IDLabel;
        private PictureBox HomepageIcon;
        private Button MedCertButton;
        private Button MedRecdButton;
        private Button AccountButton;
        private Panel mainPanel;
        private Button ExitButton;
        private Button PrescriptionButton;
        private Button MedicationButton;
        private Button BillButton;
        private Button AppointmentButton;
        private Button minimizeButton;
    }
}