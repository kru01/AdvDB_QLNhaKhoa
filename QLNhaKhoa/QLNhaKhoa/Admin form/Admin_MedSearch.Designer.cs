namespace QLNhaKhoa.Admin_form
{
    partial class Admin_MedSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_MedSearch));
            label3 = new Label();
            medIDBox = new TextBox();
            label9 = new Label();
            instockBox = new TextBox();
            cboUnit = new ComboBox();
            label2 = new Label();
            cancelButton = new Button();
            searchMedButton = new Button();
            label1 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            priceBox = new TextBox();
            prescriptionBox = new TextBox();
            medNameBox = new TextBox();
            expDateBox = new DateTimePicker();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(301, 108);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 89;
            label3.Text = "Med ID";
            // 
            // medIDBox
            // 
            medIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medIDBox.Location = new Point(301, 134);
            medIDBox.MaxLength = 25;
            medIDBox.Name = "medIDBox";
            medIDBox.PlaceholderText = "Med ID";
            medIDBox.Size = new Size(100, 27);
            medIDBox.TabIndex = 88;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(388, 183);
            label9.Name = "label9";
            label9.Size = new Size(49, 23);
            label9.TabIndex = 87;
            label9.Text = "Price";
            // 
            // instockBox
            // 
            instockBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instockBox.Location = new Point(263, 209);
            instockBox.MaxLength = 11;
            instockBox.Name = "instockBox";
            instockBox.PlaceholderText = "Instock";
            instockBox.Size = new Size(100, 27);
            instockBox.TabIndex = 86;
            instockBox.KeyPress += instockBox_KeyPress;
            // 
            // cboUnit
            // 
            cboUnit.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboUnit.FormattingEnabled = true;
            cboUnit.Items.AddRange(new object[] { "Viên", "Hộp", "Gói" });
            cboUnit.Location = new Point(413, 134);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(75, 27);
            cboUnit.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(413, 108);
            label2.Name = "label2";
            label2.Size = new Size(40, 23);
            label2.TabIndex = 84;
            label2.Text = "Unit";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(308, 339);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(180, 50);
            cancelButton.TabIndex = 83;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // searchMedButton
            // 
            searchMedButton.BackColor = Color.SteelBlue;
            searchMedButton.FlatAppearance.BorderSize = 0;
            searchMedButton.FlatStyle = FlatStyle.Flat;
            searchMedButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchMedButton.ForeColor = Color.White;
            searchMedButton.Location = new Point(88, 339);
            searchMedButton.Name = "searchMedButton";
            searchMedButton.Size = new Size(180, 50);
            searchMedButton.TabIndex = 82;
            searchMedButton.Text = "Search";
            searchMedButton.UseVisualStyleBackColor = false;
            searchMedButton.Click += searchMedButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(157, 52);
            label1.Name = "label1";
            label1.Size = new Size(275, 39);
            label1.TabIndex = 81;
            label1.Text = "Search Medication";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(263, 183);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 80;
            label8.Text = "Instock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(88, 258);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 78;
            label6.Text = "Prescription";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(88, 108);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 77;
            label5.Text = "Med Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(88, 183);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 76;
            label4.Text = "Expiration Date";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(388, 209);
            priceBox.MaxLength = 11;
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.Size = new Size(100, 27);
            priceBox.TabIndex = 75;
            priceBox.KeyPress += priceBox_KeyPress;
            // 
            // prescriptionBox
            // 
            prescriptionBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prescriptionBox.Location = new Point(88, 284);
            prescriptionBox.MaxLength = 100;
            prescriptionBox.Name = "prescriptionBox";
            prescriptionBox.PlaceholderText = "Prescription";
            prescriptionBox.Size = new Size(400, 27);
            prescriptionBox.TabIndex = 74;
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(88, 134);
            medNameBox.MaxLength = 25;
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Med Name";
            medNameBox.Size = new Size(200, 27);
            medNameBox.TabIndex = 72;
            // 
            // expDateBox
            // 
            expDateBox.CustomFormat = "yyyy-MM-dd";
            expDateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expDateBox.Format = DateTimePickerFormat.Custom;
            expDateBox.Location = new Point(88, 209);
            expDateBox.MaxDate = new DateTime(9000, 12, 2, 0, 0, 0, 0);
            expDateBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            expDateBox.Name = "expDateBox";
            expDateBox.Size = new Size(150, 27);
            expDateBox.TabIndex = 71;
            expDateBox.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // Admin_MedSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 453);
            Controls.Add(label3);
            Controls.Add(medIDBox);
            Controls.Add(label9);
            Controls.Add(instockBox);
            Controls.Add(cboUnit);
            Controls.Add(label2);
            Controls.Add(cancelButton);
            Controls.Add(searchMedButton);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(priceBox);
            Controls.Add(prescriptionBox);
            Controls.Add(medNameBox);
            Controls.Add(expDateBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_MedSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Medication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox medIDBox;
        private Label label9;
        private TextBox instockBox;
        private ComboBox cboUnit;
        private Label label2;
        private Button cancelButton;
        private Button searchMedButton;
        private Label label1;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox priceBox;
        private TextBox prescriptionBox;
        private TextBox medNameBox;
        private DateTimePicker expDateBox;
    }
}