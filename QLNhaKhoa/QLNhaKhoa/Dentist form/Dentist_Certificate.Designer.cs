namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Certificate
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
            addCertButton = new Button();
            certificateData = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            cboRecord = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            examDateBox = new DateTimePicker();
            certificateIDBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)certificateData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(addCertButton);
            panel1.Controls.Add(certificateData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 5;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(156, 300);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 10;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // addCertButton
            // 
            addCertButton.BackColor = Color.SteelBlue;
            addCertButton.FlatAppearance.BorderSize = 0;
            addCertButton.FlatStyle = FlatStyle.Flat;
            addCertButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCertButton.ForeColor = Color.White;
            addCertButton.Location = new Point(50, 300);
            addCertButton.Name = "addCertButton";
            addCertButton.Size = new Size(100, 40);
            addCertButton.TabIndex = 9;
            addCertButton.Text = "Add";
            addCertButton.UseVisualStyleBackColor = false;
            addCertButton.Click += addCertButton_Click;
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
            certificateData.Name = "certificateData";
            certificateData.RowHeadersWidth = 51;
            certificateData.Size = new Size(900, 350);
            certificateData.TabIndex = 0;
            certificateData.CellClick += certificateData_CellClick;
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
            label1.TabIndex = 6;
            label1.Text = "Medical Certificate";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cboRecord);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(examDateBox);
            panel2.Controls.Add(certificateIDBox);
            panel2.Location = new Point(50, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 7;
            // 
            // cboRecord
            // 
            cboRecord.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRecord.FormattingEnabled = true;
            cboRecord.Location = new Point(450, 182);
            cboRecord.Name = "cboRecord";
            cboRecord.Size = new Size(250, 27);
            cboRecord.TabIndex = 6;
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
            label3.Location = new Point(450, 154);
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
            label2.Location = new Point(275, 54);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 3;
            label2.Text = "Certificate ID";
            // 
            // examDateBox
            // 
            examDateBox.CustomFormat = "yyyy-MM-dd";
            examDateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            examDateBox.Format = DateTimePickerFormat.Custom;
            examDateBox.Location = new Point(100, 180);
            examDateBox.Name = "examDateBox";
            examDateBox.Size = new Size(250, 27);
            examDateBox.TabIndex = 2;
            // 
            // certificateIDBox
            // 
            certificateIDBox.Enabled = false;
            certificateIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            certificateIDBox.Location = new Point(275, 80);
            certificateIDBox.Name = "certificateIDBox";
            certificateIDBox.PlaceholderText = "Certificate ID";
            certificateIDBox.ReadOnly = true;
            certificateIDBox.Size = new Size(250, 27);
            certificateIDBox.TabIndex = 0;
            // 
            // Dentist_Certificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Certificate";
            Text = "Dentist_Bill";
            Load += Dentist_Certificate_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)certificateData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView certificateData;
        private Button addCertButton;
        private Label label1;
        private Panel panel2;
        private TextBox certificateIDBox;
        private DateTimePicker examDateBox;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button refreshButton;
        private ComboBox cboRecord;
    }
}