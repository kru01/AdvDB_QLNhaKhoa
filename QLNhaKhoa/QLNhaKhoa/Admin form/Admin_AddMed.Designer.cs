namespace QLNhaKhoa.Admin_form
{
    partial class Admin_AddMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AddMed));
            AddMedButton = new Button();
            cancelButton = new Button();
            label8 = new Label();
            prescribeBox = new TextBox();
            label7 = new Label();
            expDateBox = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            priceBox = new TextBox();
            cboUnit = new ComboBox();
            medNameBox = new TextBox();
            label4 = new Label();
            instockBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddMedButton
            // 
            AddMedButton.BackColor = Color.SteelBlue;
            AddMedButton.FlatAppearance.BorderSize = 0;
            AddMedButton.FlatStyle = FlatStyle.Flat;
            AddMedButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddMedButton.ForeColor = Color.White;
            AddMedButton.Location = new Point(70, 430);
            AddMedButton.Name = "AddMedButton";
            AddMedButton.Size = new Size(200, 50);
            AddMedButton.TabIndex = 0;
            AddMedButton.Text = "Add Medication";
            AddMedButton.UseVisualStyleBackColor = false;
            AddMedButton.Click += AddMedButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(310, 430);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 50);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(70, 334);
            label8.Name = "label8";
            label8.Size = new Size(102, 23);
            label8.TabIndex = 29;
            label8.Text = "Prescription";
            // 
            // prescribeBox
            // 
            prescribeBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prescribeBox.Location = new Point(70, 360);
            prescribeBox.Name = "prescribeBox";
            prescribeBox.PlaceholderText = "Prescription";
            prescribeBox.Size = new Size(440, 27);
            prescribeBox.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(70, 254);
            label7.Name = "label7";
            label7.Size = new Size(134, 23);
            label7.TabIndex = 27;
            label7.Text = "Expiration Date";
            // 
            // expDateBox
            // 
            expDateBox.CustomFormat = "yyyy-MM-dd";
            expDateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expDateBox.Format = DateTimePickerFormat.Custom;
            expDateBox.Location = new Point(70, 280);
            expDateBox.Name = "expDateBox";
            expDateBox.Size = new Size(200, 27);
            expDateBox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(310, 174);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 25;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(70, 94);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 24;
            label5.Text = "Med Name";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(310, 200);
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.Size = new Size(200, 27);
            priceBox.TabIndex = 23;
            // 
            // cboUnit
            // 
            cboUnit.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboUnit.FormattingEnabled = true;
            cboUnit.Items.AddRange(new object[] { "Viên", "Hộp", "Gói" });
            cboUnit.Location = new Point(310, 280);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(200, 27);
            cboUnit.TabIndex = 22;
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(70, 120);
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Med Name";
            medNameBox.Size = new Size(440, 27);
            medNameBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(70, 174);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 20;
            label4.Text = "In stock";
            // 
            // instockBox
            // 
            instockBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instockBox.Location = new Point(70, 200);
            instockBox.Name = "instockBox";
            instockBox.PlaceholderText = "In stock";
            instockBox.Size = new Size(200, 27);
            instockBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(310, 254);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 18;
            label3.Text = "Unit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(183, 35);
            label1.Name = "label1";
            label1.Size = new Size(214, 35);
            label1.TabIndex = 30;
            label1.Text = "Add medication";
            // 
            // Admin_Medication_AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 553);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(prescribeBox);
            Controls.Add(label7);
            Controls.Add(expDateBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(priceBox);
            Controls.Add(cboUnit);
            Controls.Add(medNameBox);
            Controls.Add(label4);
            Controls.Add(instockBox);
            Controls.Add(label3);
            Controls.Add(cancelButton);
            Controls.Add(AddMedButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Medication_AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Medication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddMedButton;
        private Button cancelButton;
        private Label label8;
        private TextBox prescribeBox;
        private Label label7;
        private DateTimePicker expDateBox;
        private Label label6;
        private Label label5;
        private TextBox priceBox;
        private ComboBox cboUnit;
        private TextBox medNameBox;
        private Label label4;
        private TextBox instockBox;
        private Label label3;
        private Label label1;
    }
}