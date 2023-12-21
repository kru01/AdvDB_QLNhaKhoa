namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Treatment
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
            addPlanButton = new Button();
            planData = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            noteBox = new TextBox();
            cboTreatment = new ComboBox();
            label9 = new Label();
            cboAssistant = new ComboBox();
            cboDentist = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            desBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cboStatus = new ComboBox();
            label5 = new Label();
            nameBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dateBox = new DateTimePicker();
            IDBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)planData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(addPlanButton);
            panel1.Controls.Add(planData);
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
            refreshButton.Location = new Point(156, 375);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 10;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // addPlanButton
            // 
            addPlanButton.BackColor = Color.SteelBlue;
            addPlanButton.FlatAppearance.BorderSize = 0;
            addPlanButton.FlatStyle = FlatStyle.Flat;
            addPlanButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPlanButton.ForeColor = Color.White;
            addPlanButton.Location = new Point(50, 375);
            addPlanButton.Name = "addPlanButton";
            addPlanButton.Size = new Size(100, 40);
            addPlanButton.TabIndex = 9;
            addPlanButton.Text = "Add";
            addPlanButton.UseVisualStyleBackColor = false;
            addPlanButton.Click += addPlanButton_Click;
            // 
            // planData
            // 
            planData.AllowUserToAddRows = false;
            planData.AllowUserToDeleteRows = false;
            planData.AllowUserToResizeColumns = false;
            planData.AllowUserToResizeRows = false;
            planData.BorderStyle = BorderStyle.None;
            planData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planData.Dock = DockStyle.Bottom;
            planData.Location = new Point(0, 425);
            planData.Name = "planData";
            planData.RowHeadersWidth = 51;
            planData.Size = new Size(900, 275);
            planData.TabIndex = 0;
            planData.CellClick += planData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(352, 25);
            label1.Name = "label1";
            label1.Size = new Size(196, 35);
            label1.TabIndex = 6;
            label1.Text = "Treatment plan";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(noteBox);
            panel2.Controls.Add(cboTreatment);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cboAssistant);
            panel2.Controls.Add(cboDentist);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(desBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cboStatus);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(nameBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateBox);
            panel2.Controls.Add(IDBox);
            panel2.Location = new Point(50, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 325);
            panel2.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(425, 234);
            label10.Name = "label10";
            label10.Size = new Size(48, 23);
            label10.TabIndex = 23;
            label10.Text = "Note";
            // 
            // noteBox
            // 
            noteBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteBox.Location = new Point(425, 260);
            noteBox.Name = "noteBox";
            noteBox.PlaceholderText = "Description";
            noteBox.ReadOnly = true;
            noteBox.Size = new Size(275, 27);
            noteBox.TabIndex = 22;
            // 
            // cboTreatment
            // 
            cboTreatment.Enabled = false;
            cboTreatment.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTreatment.FormattingEnabled = true;
            cboTreatment.Location = new Point(100, 260);
            cboTreatment.Name = "cboTreatment";
            cboTreatment.Size = new Size(275, 27);
            cboTreatment.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(100, 234);
            label9.Name = "label9";
            label9.Size = new Size(89, 23);
            label9.TabIndex = 20;
            label9.Text = "Treatment";
            // 
            // cboAssistant
            // 
            cboAssistant.Enabled = false;
            cboAssistant.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAssistant.FormattingEnabled = true;
            cboAssistant.Location = new Point(500, 120);
            cboAssistant.Name = "cboAssistant";
            cboAssistant.Size = new Size(200, 27);
            cboAssistant.TabIndex = 18;
            // 
            // cboDentist
            // 
            cboDentist.Enabled = false;
            cboDentist.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentist.FormattingEnabled = true;
            cboDentist.Location = new Point(275, 120);
            cboDentist.Name = "cboDentist";
            cboDentist.Size = new Size(200, 27);
            cboDentist.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(500, 94);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 16;
            label8.Text = "Assistant";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(100, 164);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 14;
            label3.Text = "Description";
            // 
            // desBox
            // 
            desBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            desBox.Location = new Point(100, 190);
            desBox.Name = "desBox";
            desBox.PlaceholderText = "Description";
            desBox.ReadOnly = true;
            desBox.Size = new Size(600, 27);
            desBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(275, 94);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 12;
            label7.Text = "Dentist name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(550, 24);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 10;
            label6.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.Enabled = false;
            cboStatus.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Kế hoạch", "Đã hoàn thành", "Đã hủy" });
            cboStatus.Location = new Point(550, 50);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(150, 27);
            cboStatus.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(225, 24);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 8;
            label5.Text = "Name";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(225, 50);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(300, 27);
            nameBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 94);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 5;
            label4.Text = "Date of treatment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 24);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 3;
            label2.Text = "Plan ID";
            // 
            // dateBox
            // 
            dateBox.CustomFormat = "yyyy-MM-dd";
            dateBox.Enabled = false;
            dateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBox.Format = DateTimePickerFormat.Custom;
            dateBox.Location = new Point(100, 120);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(150, 27);
            dateBox.TabIndex = 2;
            // 
            // IDBox
            // 
            IDBox.Enabled = false;
            IDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDBox.Location = new Point(100, 50);
            IDBox.Name = "IDBox";
            IDBox.PlaceholderText = "Plan ID";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(100, 27);
            IDBox.TabIndex = 0;
            // 
            // Dentist_Treatment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Treatment";
            Text = "Dentist_Bill";
            Load += Dentist_Treatment_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)planData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView planData;
        private Button addPlanButton;
        private Label label1;
        private Panel panel2;
        private TextBox IDBox;
        private DateTimePicker dateBox;
        private Label label2;
        private Label label4;
        private Button refreshButton;
        private Label label5;
        private TextBox nameBox;
        private Label label6;
        private ComboBox cboStatus;
        private Label label7;
        private TextBox desBox;
        private Label label3;
        private Label label8;
        private ComboBox cboAssistant;
        private ComboBox cboDentist;
        private Label label9;
        private ComboBox cboTreatment;
        private Label label10;
        private TextBox noteBox;
    }
}