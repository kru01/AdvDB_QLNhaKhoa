namespace QLNhaKhoa.Filter_folder
{
    partial class Filter_Dentist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter_Dentist));
            filterButton = new Button();
            label2 = new Label();
            cboDentist = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.SteelBlue;
            filterButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterButton.ForeColor = Color.White;
            filterButton.Location = new Point(117, 178);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(150, 40);
            filterButton.TabIndex = 7;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(66, 97);
            label2.Name = "label2";
            label2.Size = new Size(191, 23);
            label2.TabIndex = 6;
            label2.Text = "Choose a dentist name";
            // 
            // cboDentist
            // 
            cboDentist.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentist.FormattingEnabled = true;
            cboDentist.Location = new Point(66, 123);
            cboDentist.Name = "cboDentist";
            cboDentist.Size = new Size(250, 27);
            cboDentist.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(71, 35);
            label1.Name = "label1";
            label1.Size = new Size(235, 39);
            label1.TabIndex = 4;
            label1.Text = "Filter by dentist";
            // 
            // Filter_Dentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 253);
            Controls.Add(filterButton);
            Controls.Add(label2);
            Controls.Add(cboDentist);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Filter_Dentist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter by dentist name";
            Load += Filter_Dentist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button filterButton;
        private Label label2;
        private ComboBox cboDentist;
        private Label label1;
    }
}