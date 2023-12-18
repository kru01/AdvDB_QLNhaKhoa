namespace QLNhaKhoa.General_Form
{
    partial class Record
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
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            addressBox = new TextBox();
            label6 = new Label();
            emailBox = new TextBox();
            phoneBox = new TextBox();
            IDBox = new TextBox();
            label2 = new Label();
            ageBox = new TextBox();
            label11 = new Label();
            infoBox = new TextBox();
            label3 = new Label();
            cboGender = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            costBox = new TextBox();
            paidBox = new TextBox();
            nameBox = new TextBox();
            bdayBox = new DateTimePicker();
            addRecordButton = new Button();
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
            panel1.Controls.Add(updateInfoButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(addRecordButton);
            panel1.Controls.Add(recordData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 8;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(262, 348);
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
            updateInfoButton.Location = new Point(156, 348);
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
            label1.Location = new Point(357, 15);
            label1.Name = "label1";
            label1.Size = new Size(185, 35);
            label1.TabIndex = 7;
            label1.Text = "Patient record";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(addressBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(emailBox);
            panel2.Controls.Add(phoneBox);
            panel2.Controls.Add(IDBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ageBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(infoBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboGender);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(costBox);
            panel2.Controls.Add(paidBox);
            panel2.Controls.Add(nameBox);
            panel2.Controls.Add(bdayBox);
            panel2.Location = new Point(50, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 300);
            panel2.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(477, 219);
            label12.Name = "label12";
            label12.Size = new Size(51, 23);
            label12.TabIndex = 31;
            label12.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(100, 219);
            label10.Name = "label10";
            label10.Size = new Size(75, 23);
            label10.TabIndex = 30;
            label10.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(477, 154);
            label9.Name = "label9";
            label9.Size = new Size(123, 23);
            label9.TabIndex = 29;
            label9.Text = "Phone number";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(100, 245);
            addressBox.MaxLength = 25;
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(351, 27);
            addressBox.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(100, 24);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 27;
            label6.Text = "Record ID";
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Location = new Point(477, 245);
            emailBox.MaxLength = 25;
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Email";
            emailBox.Size = new Size(223, 27);
            emailBox.TabIndex = 28;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(477, 180);
            phoneBox.MaxLength = 25;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone number";
            phoneBox.Size = new Size(223, 27);
            phoneBox.TabIndex = 28;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDBox.Location = new Point(100, 50);
            IDBox.MaxLength = 25;
            IDBox.Name = "IDBox";
            IDBox.PlaceholderText = "Record ID";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(125, 27);
            IDBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(477, 23);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 25;
            label2.Text = "Age";
            // 
            // ageBox
            // 
            ageBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageBox.Location = new Point(477, 50);
            ageBox.Name = "ageBox";
            ageBox.PlaceholderText = "Age";
            ageBox.ReadOnly = true;
            ageBox.Size = new Size(100, 27);
            ageBox.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(100, 154);
            label11.Name = "label11";
            label11.Size = new Size(112, 23);
            label11.TabIndex = 23;
            label11.Text = "General Info";
            // 
            // infoBox
            // 
            infoBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoBox.Location = new Point(100, 180);
            infoBox.MaxLength = 100;
            infoBox.Name = "infoBox";
            infoBox.PlaceholderText = "General info";
            infoBox.Size = new Size(351, 27);
            infoBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(600, 24);
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
            cboGender.Location = new Point(600, 50);
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
            label8.Size = new Size(85, 23);
            label8.TabIndex = 15;
            label8.Text = "Total cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(477, 89);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 14;
            label7.Text = "Amount paid";
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
            // costBox
            // 
            costBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            costBox.Location = new Point(251, 115);
            costBox.MaxLength = 11;
            costBox.Name = "costBox";
            costBox.PlaceholderText = "Total cost";
            costBox.Size = new Size(200, 27);
            costBox.TabIndex = 10;
            // 
            // paidBox
            // 
            paidBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paidBox.Location = new Point(477, 115);
            paidBox.MaxLength = 100;
            paidBox.Name = "paidBox";
            paidBox.PlaceholderText = "Amount paid";
            paidBox.Size = new Size(223, 27);
            paidBox.TabIndex = 9;
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
            bdayBox.MaxDate = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            bdayBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(125, 27);
            bdayBox.TabIndex = 6;
            bdayBox.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // addRecordButton
            // 
            addRecordButton.BackColor = Color.SteelBlue;
            addRecordButton.FlatAppearance.BorderSize = 0;
            addRecordButton.FlatStyle = FlatStyle.Flat;
            addRecordButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRecordButton.ForeColor = Color.White;
            addRecordButton.Location = new Point(50, 348);
            addRecordButton.Name = "addRecordButton";
            addRecordButton.Size = new Size(100, 40);
            addRecordButton.TabIndex = 9;
            addRecordButton.Text = "Add";
            addRecordButton.UseVisualStyleBackColor = false;
            addRecordButton.Click += addRecordButton_Click;
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
            recordData.Location = new Point(0, 400);
            recordData.Name = "recordData";
            recordData.RowHeadersWidth = 51;
            recordData.Size = new Size(900, 300);
            recordData.TabIndex = 0;
            recordData.CellClick += recordData_CellClick;
            // 
            // Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Record";
            Text = "Record";
            Load += Record_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button refreshButton;
        private Button updateInfoButton;
        private Label label1;
        private Panel panel2;
        private Label label12;
        private Label label10;
        private Label label9;
        private TextBox addressBox;
        private Label label6;
        private TextBox emailBox;
        private TextBox phoneBox;
        private TextBox IDBox;
        private Label label2;
        private TextBox ageBox;
        private Label label11;
        private TextBox infoBox;
        private Label label3;
        private ComboBox cboGender;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox costBox;
        private TextBox paidBox;
        private TextBox nameBox;
        private DateTimePicker bdayBox;
        private Button addRecordButton;
        private DataGridView recordData;
    }
}