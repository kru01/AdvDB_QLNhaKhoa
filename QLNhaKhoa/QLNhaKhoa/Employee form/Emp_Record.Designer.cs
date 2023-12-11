namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Record
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
            searchIDBox = new TextBox();
            searchButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            customerIDBox = new TextBox();
            dentistIDBox = new TextBox();
            recordIDBox = new TextBox();
            recordData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(searchIDBox);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(recordData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 1;
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
            refreshButton.TabIndex = 7;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // searchIDBox
            // 
            searchIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchIDBox.Location = new Point(569, 310);
            searchIDBox.MaxLength = 10;
            searchIDBox.Name = "searchIDBox";
            searchIDBox.PlaceholderText = "Enter record ID to search";
            searchIDBox.Size = new Size(200, 27);
            searchIDBox.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SteelBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Tw Cen MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(775, 310);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 27);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(289, 25);
            label1.Name = "label1";
            label1.Size = new Size(322, 35);
            label1.TabIndex = 0;
            label1.Text = "Customer Medical Record";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(customerIDBox);
            panel2.Controls.Add(dentistIDBox);
            panel2.Controls.Add(recordIDBox);
            panel2.Location = new Point(50, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(275, 54);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 5;
            label4.Text = "Record ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 154);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 4;
            label3.Text = "Dentist ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 154);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 3;
            label2.Text = "Customer ID";
            // 
            // customerIDBox
            // 
            customerIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerIDBox.Location = new Point(100, 180);
            customerIDBox.Name = "customerIDBox";
            customerIDBox.PlaceholderText = "Customer ID";
            customerIDBox.ReadOnly = true;
            customerIDBox.Size = new Size(250, 27);
            customerIDBox.TabIndex = 2;
            // 
            // dentistIDBox
            // 
            dentistIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentistIDBox.Location = new Point(450, 180);
            dentistIDBox.Name = "dentistIDBox";
            dentistIDBox.PlaceholderText = "Dentist ID";
            dentistIDBox.ReadOnly = true;
            dentistIDBox.Size = new Size(250, 27);
            dentistIDBox.TabIndex = 1;
            // 
            // recordIDBox
            // 
            recordIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordIDBox.Location = new Point(275, 80);
            recordIDBox.Name = "recordIDBox";
            recordIDBox.PlaceholderText = "Record ID";
            recordIDBox.ReadOnly = true;
            recordIDBox.Size = new Size(250, 27);
            recordIDBox.TabIndex = 0;
            // 
            // recordData
            // 
            recordData.AllowUserToAddRows = false;
            recordData.AllowUserToDeleteRows = false;
            recordData.AllowUserToResizeColumns = false;
            recordData.AllowUserToResizeRows = false;
            recordData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            recordData.BorderStyle = BorderStyle.None;
            recordData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordData.Dock = DockStyle.Bottom;
            recordData.Location = new Point(0, 350);
            recordData.Name = "recordData";
            recordData.RowHeadersWidth = 51;
            recordData.Size = new Size(900, 350);
            recordData.TabIndex = 2;
            recordData.CellClick += recordData_CellClick;
            // 
            // Emp_Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp_Record";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emp_Record";
            Load += Emp_Record_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox customerIDBox;
        private TextBox dentistIDBox;
        private TextBox recordIDBox;
        private DataGridView recordData;
        private Button searchButton;
        private TextBox searchIDBox;
        private Button refreshButton;
    }
}