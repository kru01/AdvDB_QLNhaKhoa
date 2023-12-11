namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Certificate
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
            label6 = new Label();
            label5 = new Label();
            medTotalBox = new TextBox();
            serviceTotalBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            examDateBox = new DateTimePicker();
            recordIDBox = new TextBox();
            certificateIDBox = new TextBox();
            certificateData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)certificateData).BeginInit();
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
            panel1.Controls.Add(certificateData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 6;
            // 
            // searchIDBox
            // 
            searchIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchIDBox.Location = new Point(569, 311);
            searchIDBox.MaxLength = 10;
            searchIDBox.Name = "searchIDBox";
            searchIDBox.PlaceholderText = "Enter certificate ID to search";
            searchIDBox.Size = new Size(200, 27);
            searchIDBox.TabIndex = 14;
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
            searchButton.TabIndex = 15;
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
            refreshButton.TabIndex = 13;
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
            label1.Location = new Point(326, 25);
            label1.Name = "label1";
            label1.Size = new Size(248, 35);
            label1.TabIndex = 12;
            label1.Text = "Medical Certificate";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(medTotalBox);
            panel2.Controls.Add(serviceTotalBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(examDateBox);
            panel2.Controls.Add(recordIDBox);
            panel2.Controls.Add(certificateIDBox);
            panel2.Location = new Point(50, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(550, 154);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 9;
            label6.Text = "Services total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(325, 154);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 8;
            label5.Text = "Med total";
            // 
            // medTotalBox
            // 
            medTotalBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medTotalBox.Location = new Point(325, 180);
            medTotalBox.Name = "medTotalBox";
            medTotalBox.PlaceholderText = "Med total";
            medTotalBox.ReadOnly = true;
            medTotalBox.Size = new Size(150, 27);
            medTotalBox.TabIndex = 7;
            // 
            // serviceTotalBox
            // 
            serviceTotalBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceTotalBox.Location = new Point(550, 180);
            serviceTotalBox.Name = "serviceTotalBox";
            serviceTotalBox.PlaceholderText = "Services total";
            serviceTotalBox.ReadOnly = true;
            serviceTotalBox.Size = new Size(150, 27);
            serviceTotalBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 154);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 5;
            label4.Text = "Date of examination";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 54);
            label3.Name = "label3";
            label3.Size = new Size(167, 23);
            label3.TabIndex = 4;
            label3.Text = "Customer Record ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 54);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 3;
            label2.Text = "Certificate ID";
            // 
            // examDateBox
            // 
            examDateBox.CustomFormat = "yyyy-MM-dd";
            examDateBox.Enabled = false;
            examDateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            examDateBox.Format = DateTimePickerFormat.Custom;
            examDateBox.Location = new Point(100, 180);
            examDateBox.Name = "examDateBox";
            examDateBox.Size = new Size(150, 27);
            examDateBox.TabIndex = 2;
            // 
            // recordIDBox
            // 
            recordIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordIDBox.Location = new Point(450, 80);
            recordIDBox.Name = "recordIDBox";
            recordIDBox.PlaceholderText = "Customer Record ID";
            recordIDBox.ReadOnly = true;
            recordIDBox.Size = new Size(250, 27);
            recordIDBox.TabIndex = 1;
            // 
            // certificateIDBox
            // 
            certificateIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            certificateIDBox.Location = new Point(100, 80);
            certificateIDBox.Name = "certificateIDBox";
            certificateIDBox.PlaceholderText = "Certificate ID";
            certificateIDBox.ReadOnly = true;
            certificateIDBox.Size = new Size(250, 27);
            certificateIDBox.TabIndex = 0;
            // 
            // certificateData
            // 
            certificateData.AllowUserToAddRows = false;
            certificateData.AllowUserToDeleteRows = false;
            certificateData.AllowUserToResizeColumns = false;
            certificateData.AllowUserToResizeRows = false;
            certificateData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            certificateData.BorderStyle = BorderStyle.None;
            certificateData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            certificateData.Dock = DockStyle.Bottom;
            certificateData.Location = new Point(0, 350);
            certificateData.MultiSelect = false;
            certificateData.Name = "certificateData";
            certificateData.RowHeadersWidth = 51;
            certificateData.Size = new Size(900, 350);
            certificateData.TabIndex = 0;
            certificateData.CellClick += certificateData_CellClick;
            // 
            // Emp_Certificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp_Certificate";
            Text = "Emp_Certificate";
            Load += Emp_Certificate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)certificateData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView certificateData;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker examDateBox;
        private TextBox recordIDBox;
        private TextBox certificateIDBox;
        private Label label1;
        private TextBox serviceTotalBox;
        private TextBox medTotalBox;
        private Label label6;
        private Label label5;
        private Button refreshButton;
        private TextBox searchIDBox;
        private Button searchButton;
    }
}