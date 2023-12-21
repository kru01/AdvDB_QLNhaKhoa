namespace QLNhaKhoa.General_Form
{
    partial class AddPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrescription));
            label2 = new Label();
            cboPlan = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cboName = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            cboMed = new ComboBox();
            quantityBox = new TextBox();
            cancelButton = new Button();
            addPreButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(542, 152);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 73;
            label2.Text = "Quantity";
            // 
            // cboPlan
            // 
            cboPlan.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(542, 113);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(150, 27);
            cboPlan.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(542, 87);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 66;
            label5.Text = "Plan ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(91, 87);
            label6.Name = "label6";
            label6.Size = new Size(132, 23);
            label6.TabIndex = 62;
            label6.Text = "Customer name";
            // 
            // cboName
            // 
            cboName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboName.FormattingEnabled = true;
            cboName.Location = new Point(91, 113);
            cboName.Name = "cboName";
            cboName.Size = new Size(410, 27);
            cboName.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(269, 31);
            label1.Name = "label1";
            label1.Size = new Size(245, 35);
            label1.TabIndex = 60;
            label1.Text = "Add a prescription";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(91, 152);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 65;
            label4.Text = "Medication";
            // 
            // cboMed
            // 
            cboMed.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMed.FormattingEnabled = true;
            cboMed.Location = new Point(92, 178);
            cboMed.Name = "cboMed";
            cboMed.Size = new Size(409, 27);
            cboMed.TabIndex = 67;
            // 
            // quantityBox
            // 
            quantityBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityBox.Location = new Point(542, 178);
            quantityBox.Name = "quantityBox";
            quantityBox.PlaceholderText = "Quantity";
            quantityBox.Size = new Size(150, 27);
            quantityBox.TabIndex = 74;
            quantityBox.KeyPress += quantityBox_KeyPress;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(419, 248);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 50);
            cancelButton.TabIndex = 76;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // addPreButton
            // 
            addPreButton.BackColor = Color.SteelBlue;
            addPreButton.FlatAppearance.BorderSize = 0;
            addPreButton.FlatStyle = FlatStyle.Flat;
            addPreButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPreButton.ForeColor = Color.White;
            addPreButton.Location = new Point(163, 248);
            addPreButton.Name = "addPreButton";
            addPreButton.Size = new Size(250, 50);
            addPreButton.TabIndex = 75;
            addPreButton.Text = "Add a prescription";
            addPreButton.UseVisualStyleBackColor = false;
            addPreButton.Click += addPreButton_Click;
            // 
            // AddPrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 353);
            Controls.Add(cancelButton);
            Controls.Add(addPreButton);
            Controls.Add(quantityBox);
            Controls.Add(label2);
            Controls.Add(cboPlan);
            Controls.Add(cboMed);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(cboName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddPrescription";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add prescription";
            Load += AddPrescription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cboPlan;
        private Label label5;
        private Label label6;
        private ComboBox cboName;
        private Label label1;
        private Label label4;
        private ComboBox cboMed;
        private TextBox quantityBox;
        private Button cancelButton;
        private Button addPreButton;
    }
}