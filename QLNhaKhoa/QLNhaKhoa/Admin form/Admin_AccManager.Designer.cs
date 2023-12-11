namespace QLNhaKhoa.Admin_form
{
    partial class Admin_AccManager
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
            updateAccButton = new Button();
            deleteAccButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            phoneBox = new TextBox();
            addressBox = new TextBox();
            cboEmpType = new ComboBox();
            nameBox = new TextBox();
            bdayBox = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            passwordBox = new TextBox();
            IDBox = new TextBox();
            createAccButton = new Button();
            accountData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(updateAccButton);
            panel1.Controls.Add(deleteAccButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(createAccButton);
            panel1.Controls.Add(accountData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 6;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(368, 298);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 14;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // updateAccButton
            // 
            updateAccButton.BackColor = Color.SteelBlue;
            updateAccButton.FlatAppearance.BorderSize = 0;
            updateAccButton.FlatStyle = FlatStyle.Flat;
            updateAccButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateAccButton.ForeColor = Color.White;
            updateAccButton.Location = new Point(156, 298);
            updateAccButton.Name = "updateAccButton";
            updateAccButton.Size = new Size(100, 40);
            updateAccButton.TabIndex = 13;
            updateAccButton.Text = "Update";
            updateAccButton.UseVisualStyleBackColor = false;
            updateAccButton.Click += updateAccButton_Click;
            // 
            // deleteAccButton
            // 
            deleteAccButton.BackColor = Color.SteelBlue;
            deleteAccButton.FlatAppearance.BorderSize = 0;
            deleteAccButton.FlatStyle = FlatStyle.Flat;
            deleteAccButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteAccButton.ForeColor = Color.White;
            deleteAccButton.Location = new Point(262, 298);
            deleteAccButton.Name = "deleteAccButton";
            deleteAccButton.Size = new Size(100, 40);
            deleteAccButton.TabIndex = 12;
            deleteAccButton.Text = "Delete";
            deleteAccButton.UseVisualStyleBackColor = false;
            deleteAccButton.Click += deleteAccButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(337, 15);
            label1.Name = "label1";
            label1.Size = new Size(226, 35);
            label1.TabIndex = 7;
            label1.Text = "Account Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(phoneBox);
            panel2.Controls.Add(addressBox);
            panel2.Controls.Add(cboEmpType);
            panel2.Controls.Add(nameBox);
            panel2.Controls.Add(bdayBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(passwordBox);
            panel2.Controls.Add(IDBox);
            panel2.Location = new Point(50, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(500, 159);
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
            label7.Location = new Point(100, 159);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(549, 95);
            label6.Name = "label6";
            label6.Size = new Size(129, 23);
            label6.TabIndex = 13;
            label6.Text = "Employee type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(286, 95);
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
            label4.Location = new Point(100, 95);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 11;
            label4.Text = "Birthday";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(500, 185);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone number";
            phoneBox.Size = new Size(200, 27);
            phoneBox.TabIndex = 10;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(100, 185);
            addressBox.MaxLength = 100;
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(350, 27);
            addressBox.TabIndex = 9;
            // 
            // cboEmpType
            // 
            cboEmpType.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEmpType.FormattingEnabled = true;
            cboEmpType.Items.AddRange(new object[] { "Employee", "Dentist", "Admin" });
            cboEmpType.Location = new Point(549, 120);
            cboEmpType.Name = "cboEmpType";
            cboEmpType.Size = new Size(151, 27);
            cboEmpType.TabIndex = 8;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(286, 120);
            nameBox.MaxLength = 25;
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(225, 27);
            nameBox.TabIndex = 7;
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy-MM-dd";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(100, 121);
            bdayBox.MaxDate = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            bdayBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(150, 27);
            bdayBox.TabIndex = 6;
            bdayBox.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 32);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 32);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 3;
            label2.Text = "Account ID";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(450, 58);
            passwordBox.MaxLength = 20;
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Password";
            passwordBox.Size = new Size(250, 27);
            passwordBox.TabIndex = 1;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDBox.Location = new Point(100, 58);
            IDBox.Name = "IDBox";
            IDBox.PlaceholderText = "Account ID";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(250, 27);
            IDBox.TabIndex = 0;
            // 
            // createAccButton
            // 
            createAccButton.BackColor = Color.SteelBlue;
            createAccButton.FlatAppearance.BorderSize = 0;
            createAccButton.FlatStyle = FlatStyle.Flat;
            createAccButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccButton.ForeColor = Color.White;
            createAccButton.Location = new Point(50, 298);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(100, 40);
            createAccButton.TabIndex = 9;
            createAccButton.Text = "Create";
            createAccButton.UseVisualStyleBackColor = false;
            createAccButton.Click += createAccButton_Click;
            // 
            // accountData
            // 
            accountData.AllowUserToDeleteRows = false;
            accountData.AllowUserToResizeColumns = false;
            accountData.AllowUserToResizeRows = false;
            accountData.BorderStyle = BorderStyle.None;
            accountData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountData.Dock = DockStyle.Bottom;
            accountData.Location = new Point(0, 350);
            accountData.Name = "accountData";
            accountData.RowHeadersWidth = 51;
            accountData.Size = new Size(900, 350);
            accountData.TabIndex = 0;
            accountData.CellClick += accountData_CellClick;
            // 
            // Admin_AccManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_AccManager";
            Text = "Admin_AccManager";
            Load += Admin_AccManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button createAccButton;
        private DataGridView accountData;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox passwordBox;
        private TextBox IDBox;
        private Label label1;
        private Button deleteAccButton;
        private Button updateAccButton;
        private DateTimePicker bdayBox;
        private TextBox nameBox;
        private ComboBox cboEmpType;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox phoneBox;
        private TextBox addressBox;
        private Button refreshButton;
    }
}