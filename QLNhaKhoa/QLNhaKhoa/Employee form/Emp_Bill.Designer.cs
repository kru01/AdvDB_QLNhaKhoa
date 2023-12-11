namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Bill
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
            cboRecord = new ComboBox();
            cboCertificate = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            totalBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateBox = new DateTimePicker();
            billIDBox = new TextBox();
            addBillButton = new Button();
            billData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billData).BeginInit();
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
            panel1.Controls.Add(addBillButton);
            panel1.Controls.Add(billData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 7;
            // 
            // searchIDBox
            // 
            searchIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchIDBox.Location = new Point(569, 311);
            searchIDBox.MaxLength = 10;
            searchIDBox.Name = "searchIDBox";
            searchIDBox.PlaceholderText = "Enter bill ID to search";
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
            refreshButton.Location = new Point(156, 298);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
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
            label1.Location = new Point(371, 20);
            label1.Name = "label1";
            label1.Size = new Size(157, 35);
            label1.TabIndex = 12;
            label1.Text = "Medical Bill";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cboRecord);
            panel2.Controls.Add(cboCertificate);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(totalBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateBox);
            panel2.Controls.Add(billIDBox);
            panel2.Location = new Point(50, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 11;
            // 
            // cboRecord
            // 
            cboRecord.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRecord.FormattingEnabled = true;
            cboRecord.Location = new Point(450, 182);
            cboRecord.Name = "cboRecord";
            cboRecord.Size = new Size(250, 27);
            cboRecord.TabIndex = 11;
            // 
            // cboCertificate
            // 
            cboCertificate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCertificate.FormattingEnabled = true;
            cboCertificate.Location = new Point(325, 80);
            cboCertificate.Name = "cboCertificate";
            cboCertificate.Size = new Size(150, 27);
            cboCertificate.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(325, 54);
            label6.Name = "label6";
            label6.Size = new Size(172, 23);
            label6.TabIndex = 9;
            label6.Text = "Customer Certificate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(550, 54);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 7;
            label5.Text = "Total";
            // 
            // totalBox
            // 
            totalBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalBox.Location = new Point(550, 80);
            totalBox.Name = "totalBox";
            totalBox.PlaceholderText = "Total";
            totalBox.ReadOnly = true;
            totalBox.Size = new Size(150, 27);
            totalBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 154);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 5;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 154);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 4;
            label3.Text = "Customer Record";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 54);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 3;
            label2.Text = "Bill ID";
            // 
            // dateBox
            // 
            dateBox.CustomFormat = "yyyy-MM-dd";
            dateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBox.Format = DateTimePickerFormat.Custom;
            dateBox.Location = new Point(100, 180);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(250, 27);
            dateBox.TabIndex = 2;
            // 
            // billIDBox
            // 
            billIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billIDBox.Location = new Point(100, 80);
            billIDBox.Name = "billIDBox";
            billIDBox.PlaceholderText = "Bill ID";
            billIDBox.ReadOnly = true;
            billIDBox.Size = new Size(150, 27);
            billIDBox.TabIndex = 0;
            // 
            // addBillButton
            // 
            addBillButton.BackColor = Color.SteelBlue;
            addBillButton.FlatAppearance.BorderSize = 0;
            addBillButton.FlatStyle = FlatStyle.Flat;
            addBillButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBillButton.ForeColor = Color.White;
            addBillButton.Location = new Point(50, 298);
            addBillButton.Name = "addBillButton";
            addBillButton.Size = new Size(100, 40);
            addBillButton.TabIndex = 9;
            addBillButton.Text = "Add";
            addBillButton.UseVisualStyleBackColor = false;
            addBillButton.Click += addBillButton_Click;
            // 
            // billData
            // 
            billData.AllowUserToAddRows = false;
            billData.AllowUserToDeleteRows = false;
            billData.AllowUserToResizeColumns = false;
            billData.AllowUserToResizeRows = false;
            billData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            billData.BorderStyle = BorderStyle.None;
            billData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            billData.Dock = DockStyle.Bottom;
            billData.Location = new Point(0, 350);
            billData.Name = "billData";
            billData.RowHeadersWidth = 51;
            billData.Size = new Size(900, 350);
            billData.TabIndex = 0;
            billData.CellClick += billData_CellClick;
            // 
            // Emp_Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp_Bill";
            Text = "Emp_Bill";
            Load += Emp_Bill_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)billData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateBox;
        private TextBox billIDBox;
        private Button addBillButton;
        private DataGridView billData;
        private Label label5;
        private TextBox totalBox;
        private Label label6;
        private Button refreshButton;
        private TextBox searchIDBox;
        private Button searchButton;
        private ComboBox cboCertificate;
        private ComboBox cboRecord;
    }
}