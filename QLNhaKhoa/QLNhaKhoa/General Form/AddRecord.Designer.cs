namespace QLNhaKhoa.Admin_form
{
    partial class AddRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecord));
            label1 = new Label();
            label8 = new Label();
            addressBox = new TextBox();
            label7 = new Label();
            bdayBox = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            nameBox = new TextBox();
            label4 = new Label();
            emailBox = new TextBox();
            label3 = new Label();
            cancelButton = new Button();
            AddRecordButton = new Button();
            cboGender = new ComboBox();
            phoneBox = new TextBox();
            infoBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(211, 37);
            label1.Name = "label1";
            label1.Size = new Size(152, 35);
            label1.TabIndex = 45;
            label1.Text = "Add record";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(71, 289);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 44;
            label8.Text = "Address";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(71, 315);
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(440, 27);
            addressBox.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(71, 219);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 42;
            label7.Text = "Email";
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy-MM-dd";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(71, 175);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(250, 27);
            bdayBox.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(360, 149);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 40;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(71, 79);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 39;
            label5.Text = "Patient name";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(71, 105);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Patient name";
            nameBox.Size = new Size(440, 27);
            nameBox.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(71, 149);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 35;
            label4.Text = "Date of Birth";
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Location = new Point(71, 245);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Email";
            emailBox.Size = new Size(200, 27);
            emailBox.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(311, 219);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 33;
            label3.Text = "Phone number";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(311, 450);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 50);
            cancelButton.TabIndex = 32;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddRecordButton
            // 
            AddRecordButton.BackColor = Color.SteelBlue;
            AddRecordButton.FlatAppearance.BorderSize = 0;
            AddRecordButton.FlatStyle = FlatStyle.Flat;
            AddRecordButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddRecordButton.ForeColor = Color.White;
            AddRecordButton.Location = new Point(71, 450);
            AddRecordButton.Name = "AddRecordButton";
            AddRecordButton.Size = new Size(200, 50);
            AddRecordButton.TabIndex = 31;
            AddRecordButton.Text = "Add Record";
            AddRecordButton.UseVisualStyleBackColor = false;
            AddRecordButton.Click += AddRecordButton_Click;
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(360, 175);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 27);
            cboGender.TabIndex = 46;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(311, 245);
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone number";
            phoneBox.Size = new Size(200, 27);
            phoneBox.TabIndex = 47;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // infoBox
            // 
            infoBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infoBox.Location = new Point(71, 385);
            infoBox.Name = "infoBox";
            infoBox.PlaceholderText = "General Info";
            infoBox.Size = new Size(440, 27);
            infoBox.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(71, 359);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 49;
            label2.Text = "General Info";
            // 
            // AddRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 553);
            Controls.Add(label2);
            Controls.Add(infoBox);
            Controls.Add(phoneBox);
            Controls.Add(cboGender);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(addressBox);
            Controls.Add(label7);
            Controls.Add(bdayBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(nameBox);
            Controls.Add(label4);
            Controls.Add(emailBox);
            Controls.Add(label3);
            Controls.Add(cancelButton);
            Controls.Add(AddRecordButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add medical record";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private TextBox addressBox;
        private Label label7;
        private DateTimePicker bdayBox;
        private Label label6;
        private Label label5;
        private TextBox nameBox;
        private Label label4;
        private TextBox emailBox;
        private Label label3;
        private Button cancelButton;
        private Button AddRecordButton;
        private ComboBox cboGender;
        private TextBox phoneBox;
        private TextBox infoBox;
        private Label label2;
    }
}