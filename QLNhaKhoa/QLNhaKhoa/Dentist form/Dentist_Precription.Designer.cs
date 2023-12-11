namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Prescription
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
            panel = new Panel();
            refreshButton = new Button();
            updatePreButton = new Button();
            deletePreButton = new Button();
            addPreButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            cboMedication = new ComboBox();
            cboCertificate = new ComboBox();
            cboRecord = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            quantityBox = new TextBox();
            prescriptionData = new DataGridView();
            panel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionData).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(refreshButton);
            panel.Controls.Add(updatePreButton);
            panel.Controls.Add(deletePreButton);
            panel.Controls.Add(addPreButton);
            panel.Controls.Add(label1);
            panel.Controls.Add(panel4);
            panel.Controls.Add(prescriptionData);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(900, 700);
            panel.TabIndex = 7;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(368, 300);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 6;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // updatePreButton
            // 
            updatePreButton.BackColor = Color.SteelBlue;
            updatePreButton.FlatAppearance.BorderSize = 0;
            updatePreButton.FlatStyle = FlatStyle.Flat;
            updatePreButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatePreButton.ForeColor = Color.White;
            updatePreButton.Location = new Point(156, 300);
            updatePreButton.Name = "updatePreButton";
            updatePreButton.Size = new Size(100, 40);
            updatePreButton.TabIndex = 5;
            updatePreButton.Text = "Update";
            updatePreButton.UseVisualStyleBackColor = false;
            updatePreButton.Click += updatePreButton_Click;
            // 
            // deletePreButton
            // 
            deletePreButton.BackColor = Color.SteelBlue;
            deletePreButton.FlatAppearance.BorderSize = 0;
            deletePreButton.FlatStyle = FlatStyle.Flat;
            deletePreButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletePreButton.ForeColor = Color.White;
            deletePreButton.Location = new Point(262, 300);
            deletePreButton.Name = "deletePreButton";
            deletePreButton.Size = new Size(100, 40);
            deletePreButton.TabIndex = 4;
            deletePreButton.Text = "Delete";
            deletePreButton.UseVisualStyleBackColor = false;
            deletePreButton.Click += deletePreButton_Click;
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
            addPreButton.TabIndex = 3;
            addPreButton.Text = "Add";
            addPreButton.UseVisualStyleBackColor = false;
            addPreButton.Click += addPreButton_Click;
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
            panel4.Controls.Add(cboMedication);
            panel4.Controls.Add(cboCertificate);
            panel4.Controls.Add(cboRecord);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(quantityBox);
            panel4.Location = new Point(50, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // cboMedication
            // 
            cboMedication.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMedication.FormattingEnabled = true;
            cboMedication.Location = new Point(100, 180);
            cboMedication.Name = "cboMedication";
            cboMedication.Size = new Size(250, 27);
            cboMedication.TabIndex = 10;
            // 
            // cboCertificate
            // 
            cboCertificate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCertificate.FormattingEnabled = true;
            cboCertificate.Location = new Point(450, 80);
            cboCertificate.Name = "cboCertificate";
            cboCertificate.Size = new Size(250, 27);
            cboCertificate.TabIndex = 9;
            // 
            // cboRecord
            // 
            cboRecord.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRecord.FormattingEnabled = true;
            cboRecord.Location = new Point(100, 80);
            cboRecord.Name = "cboRecord";
            cboRecord.Size = new Size(250, 27);
            cboRecord.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(450, 154);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 7;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 154);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 6;
            label4.Text = "Medication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 54);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 5;
            label3.Text = "Certificate ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 54);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 4;
            label2.Text = "Customer record";
            // 
            // quantityBox
            // 
            quantityBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityBox.Location = new Point(450, 180);
            quantityBox.Name = "quantityBox";
            quantityBox.PlaceholderText = "Quantity";
            quantityBox.Size = new Size(250, 27);
            quantityBox.TabIndex = 3;
            // 
            // prescriptionData
            // 
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
            // Dentist_Prescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Prescription";
            Text = "Dentist_Precription";
            Load += Dentist_Prescription_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel;
        private Button deletePreButton;
        private Button addPreButton;
        private Label label1;
        private Panel panel4;
        private DataGridView prescriptionData;
        private Button updatePreButton;
        private TextBox quantityBox;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private ComboBox cboRecord;
        private ComboBox cboCertificate;
        private ComboBox cboMedication;
        private Button refreshButton;
    }
}