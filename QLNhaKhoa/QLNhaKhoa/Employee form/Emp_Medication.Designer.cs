namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Medication
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
            searchIDBox = new TextBox();
            searchButton = new Button();
            refreshButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            unitBox = new TextBox();
            label9 = new Label();
            empIDBox = new TextBox();
            label8 = new Label();
            prescriptionBox = new TextBox();
            label7 = new Label();
            expDateBox = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            priceBox = new TextBox();
            medNameBox = new TextBox();
            label4 = new Label();
            instockBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            medIDBox = new TextBox();
            medData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(searchIDBox);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(medData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 8;
            // 
            // searchIDBox
            // 
            searchIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchIDBox.Location = new Point(569, 311);
            searchIDBox.MaxLength = 10;
            searchIDBox.Name = "searchIDBox";
            searchIDBox.PlaceholderText = "Enter med ID to search";
            searchIDBox.Size = new Size(200, 27);
            searchIDBox.TabIndex = 18;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SteelBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Tw Cen MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(775, 311);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 27);
            searchButton.TabIndex = 19;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(50, 300);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(200, 40);
            refreshButton.TabIndex = 15;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(375, 20);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 7;
            label1.Text = "Medication";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(unitBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(empIDBox);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(prescriptionBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(expDateBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(priceBox);
            panel2.Controls.Add(medNameBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(instockBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(medIDBox);
            panel2.Location = new Point(50, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 11;
            // 
            // unitBox
            // 
            unitBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitBox.Location = new Point(300, 42);
            unitBox.Name = "unitBox";
            unitBox.PlaceholderText = "Unit";
            unitBox.ReadOnly = true;
            unitBox.Size = new Size(200, 27);
            unitBox.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(188, 16);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 17;
            label9.Text = "Emp ID";
            // 
            // empIDBox
            // 
            empIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empIDBox.Location = new Point(188, 42);
            empIDBox.Name = "empIDBox";
            empIDBox.PlaceholderText = "Emp ID";
            empIDBox.ReadOnly = true;
            empIDBox.Size = new Size(100, 27);
            empIDBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(300, 176);
            label8.Name = "label8";
            label8.Size = new Size(84, 23);
            label8.TabIndex = 15;
            label8.Text = "Prescirbe";
            // 
            // prescriptionBox
            // 
            prescriptionBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prescriptionBox.Location = new Point(300, 202);
            prescriptionBox.Name = "prescriptionBox";
            prescriptionBox.PlaceholderText = "Prescribe";
            prescriptionBox.ReadOnly = true;
            prescriptionBox.Size = new Size(425, 27);
            prescriptionBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(75, 176);
            label7.Name = "label7";
            label7.Size = new Size(134, 23);
            label7.TabIndex = 13;
            label7.Text = "Expiration Date";
            // 
            // expDateBox
            // 
            expDateBox.CustomFormat = "yyyy-MM-dd";
            expDateBox.Enabled = false;
            expDateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expDateBox.Format = DateTimePickerFormat.Custom;
            expDateBox.Location = new Point(75, 202);
            expDateBox.Name = "expDateBox";
            expDateBox.Size = new Size(200, 27);
            expDateBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(525, 95);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 11;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(75, 95);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 10;
            label5.Text = "Med Name";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(525, 121);
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.ReadOnly = true;
            priceBox.Size = new Size(200, 27);
            priceBox.TabIndex = 9;
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(75, 121);
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Med Name";
            medNameBox.ReadOnly = true;
            medNameBox.Size = new Size(425, 27);
            medNameBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(525, 16);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 6;
            label4.Text = "In stock";
            // 
            // instockBox
            // 
            instockBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instockBox.Location = new Point(525, 42);
            instockBox.Name = "instockBox";
            instockBox.PlaceholderText = "In stock";
            instockBox.ReadOnly = true;
            instockBox.Size = new Size(200, 27);
            instockBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(300, 16);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 4;
            label3.Text = "Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(75, 16);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 3;
            label2.Text = "Med ID";
            // 
            // medIDBox
            // 
            medIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medIDBox.Location = new Point(75, 42);
            medIDBox.Name = "medIDBox";
            medIDBox.PlaceholderText = "Med ID";
            medIDBox.ReadOnly = true;
            medIDBox.Size = new Size(100, 27);
            medIDBox.TabIndex = 0;
            // 
            // medData
            // 
            medData.AllowUserToAddRows = false;
            medData.AllowUserToDeleteRows = false;
            medData.AllowUserToResizeColumns = false;
            medData.AllowUserToResizeRows = false;
            medData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            medData.BorderStyle = BorderStyle.None;
            medData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medData.Dock = DockStyle.Bottom;
            medData.Location = new Point(0, 350);
            medData.Name = "medData";
            medData.RowHeadersWidth = 51;
            medData.Size = new Size(900, 350);
            medData.TabIndex = 0;
            medData.CellClick += medData_CellClick;
            // 
            // Emp_Medication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp_Medication";
            Text = "Emp_Medication";
            Load += Emp_Medication_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label9;
        private TextBox empIDBox;
        private Label label8;
        private TextBox prescriptionBox;
        private Label label7;
        private DateTimePicker expDateBox;
        private Label label6;
        private Label label5;
        private TextBox priceBox;
        private TextBox medNameBox;
        private Label label4;
        private TextBox instockBox;
        private Label label3;
        private Label label2;
        private TextBox medIDBox;
        private DataGridView medData;
        private TextBox unitBox;
        private Button refreshButton;
        private TextBox searchIDBox;
        private Button searchButton;
    }
}