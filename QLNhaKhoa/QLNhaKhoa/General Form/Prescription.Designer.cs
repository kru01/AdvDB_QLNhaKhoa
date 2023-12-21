namespace QLNhaKhoa.General_Form
{
    partial class Prescription
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
            panel3 = new Panel();
            updateBox = new Button();
            addPreButton = new Button();
            refreshButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            cboMed = new ComboBox();
            quantityBox = new TextBox();
            label7 = new Label();
            noteBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            nameBox = new TextBox();
            recordIDBox = new TextBox();
            prescriptionData = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(updateBox);
            panel3.Controls.Add(addPreButton);
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(prescriptionData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 9;
            // 
            // updateBox
            // 
            updateBox.BackColor = Color.SteelBlue;
            updateBox.FlatAppearance.BorderSize = 0;
            updateBox.FlatStyle = FlatStyle.Flat;
            updateBox.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBox.ForeColor = Color.White;
            updateBox.Location = new Point(156, 300);
            updateBox.Name = "updateBox";
            updateBox.Size = new Size(100, 40);
            updateBox.TabIndex = 16;
            updateBox.Text = "Update";
            updateBox.UseVisualStyleBackColor = false;
            updateBox.Click += updateBox_Click;
            // 
            // addPreButton
            // 
            addPreButton.BackColor = Color.SteelBlue;
            addPreButton.FlatAppearance.BorderSize = 0;
            addPreButton.FlatStyle = FlatStyle.Flat;
            addPreButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPreButton.ForeColor = Color.White;
            addPreButton.Location = new Point(50, 300);
            addPreButton.Name = "addPreButton";
            addPreButton.Size = new Size(100, 40);
            addPreButton.TabIndex = 15;
            addPreButton.Text = "Add";
            addPreButton.UseVisualStyleBackColor = false;
            addPreButton.Click += addPreButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(262, 300);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 14;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(314, 25);
            label1.Name = "label1";
            label1.Size = new Size(271, 35);
            label1.TabIndex = 0;
            label1.Text = "Customer Prescription";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cboMed);
            panel4.Controls.Add(quantityBox);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(noteBox);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(nameBox);
            panel4.Controls.Add(recordIDBox);
            panel4.Location = new Point(50, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // cboMed
            // 
            cboMed.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMed.FormattingEnabled = true;
            cboMed.Location = new Point(100, 185);
            cboMed.Name = "cboMed";
            cboMed.Size = new Size(475, 27);
            cboMed.TabIndex = 14;
            // 
            // quantityBox
            // 
            quantityBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityBox.Location = new Point(599, 185);
            quantityBox.Name = "quantityBox";
            quantityBox.PlaceholderText = "Quantity";
            quantityBox.Size = new Size(100, 27);
            quantityBox.TabIndex = 13;
            quantityBox.KeyPress += quantityBox_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(100, 94);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 11;
            label7.Text = "Note";
            // 
            // noteBox
            // 
            noteBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteBox.Location = new Point(100, 120);
            noteBox.Name = "noteBox";
            noteBox.PlaceholderText = "Note";
            noteBox.ReadOnly = true;
            noteBox.Size = new Size(599, 27);
            noteBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(100, 159);
            label6.Name = "label6";
            label6.Size = new Size(150, 23);
            label6.TabIndex = 9;
            label6.Text = "Medication Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(599, 159);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 7;
            label5.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(224, 29);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 29);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 4;
            label2.Text = "Record ID";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(224, 55);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(475, 27);
            nameBox.TabIndex = 1;
            // 
            // recordIDBox
            // 
            recordIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordIDBox.Location = new Point(100, 55);
            recordIDBox.Name = "recordIDBox";
            recordIDBox.PlaceholderText = "Record ID";
            recordIDBox.ReadOnly = true;
            recordIDBox.Size = new Size(100, 27);
            recordIDBox.TabIndex = 0;
            // 
            // prescriptionData
            // 
            prescriptionData.AllowUserToAddRows = false;
            prescriptionData.AllowUserToDeleteRows = false;
            prescriptionData.AllowUserToResizeColumns = false;
            prescriptionData.AllowUserToResizeRows = false;
            prescriptionData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prescriptionData.BorderStyle = BorderStyle.None;
            prescriptionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prescriptionData.Dock = DockStyle.Bottom;
            prescriptionData.Location = new Point(0, 350);
            prescriptionData.Name = "prescriptionData";
            prescriptionData.RowHeadersWidth = 51;
            prescriptionData.Size = new Size(900, 350);
            prescriptionData.TabIndex = 2;
            prescriptionData.CellClick += prescriptionData_CellClick;
            // 
            // Prescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Prescription";
            Text = "Prescription";
            Load += Prescription_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button refreshButton;
        private Label label1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox nameBox;
        private TextBox recordIDBox;
        private DataGridView prescriptionData;
        private Button addPreButton;
        private TextBox noteBox;
        private Label label7;
        private Button updateBox;
        private TextBox quantityBox;
        private ComboBox cboMed;
    }
}