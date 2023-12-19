namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Prescription
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
            panel3 = new Panel();
            refreshButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            medNameBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            quantityBox = new TextBox();
            medicationIDBox = new TextBox();
            certificateIDBox = new TextBox();
            recordIDBox = new TextBox();
            prescriptionData = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(prescriptionData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 8;
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
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 14;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(314, 25);
            label1.Name = "label1";
            label1.Size = new Size(271, 35);
            label1.TabIndex = 0;
            label1.Text = "Customer Prescription";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(medNameBox);
            panel4.Controls.Add(quantityBox);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(medicationIDBox);
            panel4.Controls.Add(certificateIDBox);
            panel4.Controls.Add(recordIDBox);
            panel4.Location = new Point(50, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(500, 44);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 11;
            label7.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kế hoạch", "Đã hoàn thành", "Đã hủy" });
            comboBox1.Location = new Point(500, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 27);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(224, 154);
            label6.Name = "label6";
            label6.Size = new Size(150, 23);
            label6.TabIndex = 9;
            label6.Text = "Medication Name";
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(224, 180);
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Quantity";
            medNameBox.ReadOnly = true;
            medNameBox.Size = new Size(350, 27);
            medNameBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(600, 154);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 7;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 154);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 6;
            label4.Text = "Med ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(224, 44);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 44);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 4;
            label2.Text = "Record ID";
            // 
            // quantityBox
            // 
            quantityBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityBox.Location = new Point(600, 180);
            quantityBox.Name = "quantityBox";
            quantityBox.PlaceholderText = "Quantity";
            quantityBox.Size = new Size(100, 27);
            quantityBox.TabIndex = 3;
            // 
            // medicationIDBox
            // 
            medicationIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medicationIDBox.Location = new Point(100, 180);
            medicationIDBox.Name = "medicationIDBox";
            medicationIDBox.PlaceholderText = "Med ID";
            medicationIDBox.ReadOnly = true;
            medicationIDBox.Size = new Size(100, 27);
            medicationIDBox.TabIndex = 2;
            // 
            // certificateIDBox
            // 
            certificateIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            certificateIDBox.Location = new Point(224, 70);
            certificateIDBox.Name = "certificateIDBox";
            certificateIDBox.PlaceholderText = "Name";
            certificateIDBox.Size = new Size(250, 27);
            certificateIDBox.TabIndex = 1;
            // 
            // recordIDBox
            // 
            recordIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordIDBox.Location = new Point(100, 70);
            recordIDBox.Name = "recordIDBox";
            recordIDBox.PlaceholderText = "Record ID";
            recordIDBox.ReadOnly = true;
            recordIDBox.Size = new Size(100, 27);
            recordIDBox.TabIndex = 0;
            // 
            // prescriptionData
            // 
            prescriptionData.AllowUserToAddRows = false;
            prescriptionData.AllowUserToDeleteRows = false;
            prescriptionData.AllowUserToResizeColumns = false;
            prescriptionData.AllowUserToResizeRows = false;
            prescriptionData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prescriptionData.BorderStyle = BorderStyle.None;
            prescriptionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prescriptionData.Dock = DockStyle.Bottom;
            prescriptionData.Location = new Point(0, 350);
            prescriptionData.Name = "prescriptionData";
            prescriptionData.RowHeadersWidth = 51;
            prescriptionData.Size = new Size(900, 350);
            prescriptionData.TabIndex = 2;
            prescriptionData.CellClick += prescriptionData_CellClick;
            // 
            // Emp_Prescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp_Prescription";
            Text = "Emp_Prescription";
            Load += Emp_Prescription_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox quantityBox;
        private TextBox medicationIDBox;
        private TextBox certificateIDBox;
        private TextBox recordIDBox;
        private DataGridView prescriptionData;
        private TextBox medNameBox;
        private Label label6;
        private Button refreshButton;
        private ComboBox comboBox1;
        private Label label7;
    }
}