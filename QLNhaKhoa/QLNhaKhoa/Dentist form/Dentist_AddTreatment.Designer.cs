namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_AddTreatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dentist_AddTreatment));
            cancelButton = new Button();
            addTreatmentButton = new Button();
            noteBox = new TextBox();
            label7 = new Label();
            cboAssistant = new ComboBox();
            cboDentist = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dateBox = new DateTimePicker();
            label6 = new Label();
            cboName = new ComboBox();
            label1 = new Label();
            label8 = new Label();
            cboTreatment = new ComboBox();
            label2 = new Label();
            label9 = new Label();
            cboTooth = new ComboBox();
            cboTSurface = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            descriptionBox = new TextBox();
            label12 = new Label();
            cboPayment = new ComboBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(415, 548);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 50);
            cancelButton.TabIndex = 56;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // addTreatmentButton
            // 
            addTreatmentButton.BackColor = Color.SteelBlue;
            addTreatmentButton.FlatAppearance.BorderSize = 0;
            addTreatmentButton.FlatStyle = FlatStyle.Flat;
            addTreatmentButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTreatmentButton.ForeColor = Color.White;
            addTreatmentButton.Location = new Point(159, 548);
            addTreatmentButton.Name = "addTreatmentButton";
            addTreatmentButton.Size = new Size(250, 50);
            addTreatmentButton.TabIndex = 55;
            addTreatmentButton.Text = "Add treatment plan";
            addTreatmentButton.UseVisualStyleBackColor = false;
            addTreatmentButton.Click += addTreatmentButton_Click;
            // 
            // noteBox
            // 
            noteBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteBox.Location = new Point(92, 310);
            noteBox.Name = "noteBox";
            noteBox.PlaceholderText = "Note";
            noteBox.Size = new Size(600, 27);
            noteBox.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(91, 284);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 49;
            label7.Text = "Note";
            // 
            // cboAssistant
            // 
            cboAssistant.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAssistant.FormattingEnabled = true;
            cboAssistant.Location = new Point(416, 180);
            cboAssistant.Name = "cboAssistant";
            cboAssistant.Size = new Size(275, 27);
            cboAssistant.TabIndex = 48;
            // 
            // cboDentist
            // 
            cboDentist.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentist.FormattingEnabled = true;
            cboDentist.Location = new Point(92, 180);
            cboDentist.Name = "cboDentist";
            cboDentist.Size = new Size(275, 27);
            cboDentist.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(415, 154);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 46;
            label5.Text = "Assistant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(91, 154);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 45;
            label4.Text = "Dentist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(541, 89);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 43;
            label3.Text = "Date";
            // 
            // dateBox
            // 
            dateBox.CustomFormat = "yyyy-MM-dd";
            dateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBox.Format = DateTimePickerFormat.Custom;
            dateBox.Location = new Point(541, 115);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(150, 27);
            dateBox.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(91, 89);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 40;
            label6.Text = "Customer name";
            // 
            // cboName
            // 
            cboName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboName.FormattingEnabled = true;
            cboName.Location = new Point(91, 115);
            cboName.Name = "cboName";
            cboName.Size = new Size(275, 27);
            cboName.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(249, 16);
            label1.Name = "label1";
            label1.Size = new Size(281, 35);
            label1.TabIndex = 38;
            label1.Text = "Add a treatment plan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(304, 62);
            label8.Name = "label8";
            label8.Size = new Size(161, 27);
            label8.TabIndex = 57;
            label8.Text = "Select treatment";
            // 
            // cboTreatment
            // 
            cboTreatment.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTreatment.FormattingEnabled = true;
            cboTreatment.Location = new Point(92, 245);
            cboTreatment.Name = "cboTreatment";
            cboTreatment.Size = new Size(599, 27);
            cboTreatment.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(91, 219);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 59;
            label2.Text = "Treatment";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(329, 416);
            label9.Name = "label9";
            label9.Size = new Size(120, 27);
            label9.TabIndex = 60;
            label9.Text = "Select tooth";
            // 
            // cboTooth
            // 
            cboTooth.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTooth.FormattingEnabled = true;
            cboTooth.Location = new Point(91, 484);
            cboTooth.Name = "cboTooth";
            cboTooth.Size = new Size(275, 27);
            cboTooth.TabIndex = 61;
            // 
            // cboTSurface
            // 
            cboTSurface.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTSurface.FormattingEnabled = true;
            cboTSurface.Location = new Point(417, 484);
            cboTSurface.Name = "cboTSurface";
            cboTSurface.Size = new Size(275, 27);
            cboTSurface.TabIndex = 62;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(91, 458);
            label10.Name = "label10";
            label10.Size = new Size(53, 23);
            label10.TabIndex = 63;
            label10.Text = "Tooth";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(417, 458);
            label11.Name = "label11";
            label11.Size = new Size(118, 23);
            label11.TabIndex = 64;
            label11.Text = "Tooth surface";
            // 
            // descriptionBox
            // 
            descriptionBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionBox.Location = new Point(91, 374);
            descriptionBox.Name = "descriptionBox";
            descriptionBox.PlaceholderText = "Description";
            descriptionBox.Size = new Size(600, 27);
            descriptionBox.TabIndex = 65;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(92, 348);
            label12.Name = "label12";
            label12.Size = new Size(97, 23);
            label12.TabIndex = 66;
            label12.Text = "Description";
            // 
            // cboPayment
            // 
            cboPayment.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPayment.FormattingEnabled = true;
            cboPayment.Items.AddRange(new object[] { "Tiền mặt", "Online" });
            cboPayment.Location = new Point(415, 115);
            cboPayment.Name = "cboPayment";
            cboPayment.Size = new Size(100, 27);
            cboPayment.TabIndex = 67;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SteelBlue;
            label13.Location = new Point(415, 89);
            label13.Name = "label13";
            label13.Size = new Size(78, 23);
            label13.TabIndex = 68;
            label13.Text = "Payment";
            // 
            // Dentist_AddTreatment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 653);
            Controls.Add(label13);
            Controls.Add(cboPayment);
            Controls.Add(label12);
            Controls.Add(descriptionBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(cboTSurface);
            Controls.Add(cboTooth);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(cboTreatment);
            Controls.Add(label8);
            Controls.Add(cancelButton);
            Controls.Add(addTreatmentButton);
            Controls.Add(noteBox);
            Controls.Add(label7);
            Controls.Add(cboAssistant);
            Controls.Add(cboDentist);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateBox);
            Controls.Add(label6);
            Controls.Add(cboName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dentist_AddTreatment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add treatment";
            Load += Dentist_AddTreatment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button addTreatmentButton;
        private TextBox noteBox;
        private Label label7;
        private ComboBox cboAssistant;
        private ComboBox cboDentist;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dateBox;
        private Label label6;
        private ComboBox cboName;
        private Label label1;
        private Label label8;
        private ComboBox cboTreatment;
        private Label label2;
        private Label label9;
        private ComboBox cboTooth;
        private ComboBox cboTSurface;
        private Label label10;
        private Label label11;
        private TextBox descriptionBox;
        private Label label12;
        private ComboBox cboPayment;
        private Label label13;
    }
}