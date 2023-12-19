namespace QLNhaKhoa.General_Form
{
    partial class EmpList
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
            panel1 = new Panel();
            refreshButton = new Button();
            updateInfoButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            addressBox = new TextBox();
            label3 = new Label();
            cboGender = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            phoneBox = new TextBox();
            emailBox = new TextBox();
            cboEmpType = new ComboBox();
            nameBox = new TextBox();
            bdayBox = new DateTimePicker();
            label2 = new Label();
            IDBox = new TextBox();
            passwordBox = new TextBox();
            addEmpButton = new Button();
            usernameBox = new TextBox();
            employeeData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(updateInfoButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(addEmpButton);
            panel1.Controls.Add(usernameBox);
            panel1.Controls.Add(employeeData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 7;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(262, 298);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 14;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // updateInfoButton
            // 
            updateInfoButton.BackColor = Color.SteelBlue;
            updateInfoButton.FlatAppearance.BorderSize = 0;
            updateInfoButton.FlatStyle = FlatStyle.Flat;
            updateInfoButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateInfoButton.ForeColor = Color.White;
            updateInfoButton.Location = new Point(156, 298);
            updateInfoButton.Name = "updateInfoButton";
            updateInfoButton.Size = new Size(100, 40);
            updateInfoButton.TabIndex = 13;
            updateInfoButton.Text = "Update";
            updateInfoButton.UseVisualStyleBackColor = false;
            updateInfoButton.Click += updateInfoButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(361, 15);
            label1.Name = "label1";
            label1.Size = new Size(177, 35);
            label1.TabIndex = 7;
            label1.Text = "Employee List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(addressBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboGender);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(phoneBox);
            panel2.Controls.Add(emailBox);
            panel2.Controls.Add(cboEmpType);
            panel2.Controls.Add(nameBox);
            panel2.Controls.Add(bdayBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(IDBox);
            panel2.Location = new Point(50, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(100, 154);
            label11.Name = "label11";
            label11.Size = new Size(75, 23);
            label11.TabIndex = 23;
            label11.Text = "Address";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(100, 180);
            addressBox.MaxLength = 100;
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(600, 27);
            addressBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(477, 24);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 17;
            label3.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(477, 50);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(100, 27);
            cboGender.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(251, 89);
            label8.Name = "label8";
            label8.Size = new Size(123, 23);
            label8.TabIndex = 15;
            label8.Text = "Phone number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(477, 89);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(600, 24);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 13;
            label6.Text = "Emp type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(251, 24);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 12;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 89);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 11;
            label4.Text = "Date of birth";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(251, 115);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone number";
            phoneBox.Size = new Size(200, 27);
            phoneBox.TabIndex = 10;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Location = new Point(477, 115);
            emailBox.MaxLength = 100;
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Email";
            emailBox.Size = new Size(223, 27);
            emailBox.TabIndex = 9;
            // 
            // cboEmpType
            // 
            cboEmpType.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEmpType.FormattingEnabled = true;
            cboEmpType.Items.AddRange(new object[] { "Employee", "Dentist" });
            cboEmpType.Location = new Point(600, 50);
            cboEmpType.Name = "cboEmpType";
            cboEmpType.Size = new Size(100, 27);
            cboEmpType.TabIndex = 8;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(251, 50);
            nameBox.MaxLength = 25;
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(200, 27);
            nameBox.TabIndex = 7;
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy-MM-dd";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(100, 115);
            bdayBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(125, 27);
            bdayBox.TabIndex = 6;
            bdayBox.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 24);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 3;
            label2.Text = "Account ID";
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDBox.Location = new Point(100, 50);
            IDBox.Name = "IDBox";
            IDBox.PlaceholderText = "Account ID";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(125, 27);
            IDBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(374, 361);
            passwordBox.MaxLength = 25;
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Password";
            passwordBox.ReadOnly = true;
            passwordBox.Size = new Size(0, 27);
            passwordBox.TabIndex = 19;
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.Visible = false;
            // 
            // addEmpButton
            // 
            addEmpButton.BackColor = Color.SteelBlue;
            addEmpButton.FlatAppearance.BorderSize = 0;
            addEmpButton.FlatStyle = FlatStyle.Flat;
            addEmpButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmpButton.ForeColor = Color.White;
            addEmpButton.Location = new Point(50, 298);
            addEmpButton.Name = "addEmpButton";
            addEmpButton.Size = new Size(100, 40);
            addEmpButton.TabIndex = 9;
            addEmpButton.Text = "Add";
            addEmpButton.UseVisualStyleBackColor = false;
            addEmpButton.Click += addEmpButton_Click;
            // 
            // usernameBox
            // 
            usernameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Location = new Point(368, 361);
            usernameBox.MaxLength = 25;
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Username";
            usernameBox.ReadOnly = true;
            usernameBox.Size = new Size(0, 27);
            usernameBox.TabIndex = 18;
            usernameBox.Visible = false;
            // 
            // employeeData
            // 
            employeeData.AllowUserToAddRows = false;
            employeeData.AllowUserToDeleteRows = false;
            employeeData.AllowUserToResizeColumns = false;
            employeeData.AllowUserToResizeRows = false;
            employeeData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeData.BorderStyle = BorderStyle.None;
            employeeData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeData.Dock = DockStyle.Bottom;
            employeeData.Location = new Point(0, 350);
            employeeData.Name = "employeeData";
            employeeData.RowHeadersWidth = 51;
            employeeData.Size = new Size(900, 350);
            employeeData.TabIndex = 0;
            employeeData.CellClick += employeeData_CellClick;
            // 
            // EmpList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpList";
            Text = "EmpList";
            Load += EmpList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button refreshButton;
        private Button updateInfoButton;
        private Label label1;
        private Panel panel2;
        private Label label11;
        private TextBox addressBox;
        private Label label3;
        private ComboBox cboGender;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox phoneBox;
        private TextBox emailBox;
        private ComboBox cboEmpType;
        private TextBox nameBox;
        private DateTimePicker bdayBox;
        private Label label2;
        private TextBox IDBox;
        private TextBox passwordBox;
        private Button addEmpButton;
        private TextBox usernameBox;
        private DataGridView employeeData;
    }
}