namespace QLNhaKhoa.Filter_folder
{
    partial class Filter_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter_Patient));
            label1 = new Label();
            cboPatient = new ComboBox();
            label2 = new Label();
            filterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(72, 31);
            label1.Name = "label1";
            label1.Size = new Size(238, 39);
            label1.TabIndex = 0;
            label1.Text = "Filter by patient";
            // 
            // cboPatient
            // 
            cboPatient.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPatient.FormattingEnabled = true;
            cboPatient.Location = new Point(67, 119);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(250, 27);
            cboPatient.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(67, 93);
            label2.Name = "label2";
            label2.Size = new Size(195, 23);
            label2.TabIndex = 2;
            label2.Text = "Choose a patient name";
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.SteelBlue;
            filterButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterButton.ForeColor = Color.White;
            filterButton.Location = new Point(118, 174);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(150, 40);
            filterButton.TabIndex = 3;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // Filter_Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 253);
            Controls.Add(filterButton);
            Controls.Add(label2);
            Controls.Add(cboPatient);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Filter_Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter by patient name";
            Load += Filter_Patient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboPatient;
        private Label label2;
        private Button filterButton;
    }
}