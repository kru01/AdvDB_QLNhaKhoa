namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Record
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
            button_Update = new Button();
            refreshButton = new Button();
            deleteRecordButton = new Button();
            addRecordButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            textBox_PaidAmount = new TextBox();
            label13 = new Label();
            textBox_TotalCost = new TextBox();
            label12 = new Label();
            textBox_GeneralInformation = new TextBox();
            label11 = new Label();
            textBox_Address = new TextBox();
            label10 = new Label();
            textBox_PhoneNumber = new TextBox();
            label9 = new Label();
            textBox_Email = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox_Gender = new TextBox();
            label6 = new Label();
            dateTimePicker_DoB = new DateTimePicker();
            textBox_Name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            recordIDBox = new TextBox();
            recordData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button_Update);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(deleteRecordButton);
            panel1.Controls.Add(addRecordButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(recordData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 0;
            // 
            // button_Update
            // 
            button_Update.BackColor = Color.SteelBlue;
            button_Update.FlatAppearance.BorderSize = 0;
            button_Update.FlatStyle = FlatStyle.Flat;
            button_Update.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Update.ForeColor = Color.White;
            button_Update.Location = new Point(368, 300);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(100, 40);
            button_Update.TabIndex = 7;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = false;
            button_Update.Click += button_Update_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(262, 300);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 6;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            // 
            // deleteRecordButton
            // 
            deleteRecordButton.BackColor = Color.SteelBlue;
            deleteRecordButton.FlatAppearance.BorderSize = 0;
            deleteRecordButton.FlatStyle = FlatStyle.Flat;
            deleteRecordButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteRecordButton.ForeColor = Color.White;
            deleteRecordButton.Location = new Point(156, 300);
            deleteRecordButton.Name = "deleteRecordButton";
            deleteRecordButton.Size = new Size(100, 40);
            deleteRecordButton.TabIndex = 4;
            deleteRecordButton.Text = "Delete";
            deleteRecordButton.UseVisualStyleBackColor = false;
            deleteRecordButton.Click += deleteRecordButton_Click;
            // 
            // addRecordButton
            // 
            addRecordButton.BackColor = Color.SteelBlue;
            addRecordButton.FlatAppearance.BorderSize = 0;
            addRecordButton.FlatStyle = FlatStyle.Flat;
            addRecordButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRecordButton.ForeColor = Color.White;
            addRecordButton.Location = new Point(50, 300);
            addRecordButton.Name = "addRecordButton";
            addRecordButton.Size = new Size(100, 40);
            addRecordButton.TabIndex = 3;
            addRecordButton.Text = "Add";
            addRecordButton.UseVisualStyleBackColor = false;
            addRecordButton.Click += addRecordButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(289, 25);
            label1.Name = "label1";
            label1.Size = new Size(358, 36);
            label1.TabIndex = 0;
            label1.Text = "Customer Medical Record";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox_PaidAmount);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox_TotalCost);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox_GeneralInformation);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox_Address);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox_PhoneNumber);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox_Email);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox_Gender);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dateTimePicker_DoB);
            panel2.Controls.Add(textBox_Name);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(recordIDBox);
            panel2.Location = new Point(50, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 254);
            panel2.TabIndex = 0;
            // 
            // textBox_PaidAmount
            // 
            textBox_PaidAmount.Location = new Point(515, 166);
            textBox_PaidAmount.Name = "textBox_PaidAmount";
            textBox_PaidAmount.Size = new Size(250, 27);
            textBox_PaidAmount.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SteelBlue;
            label13.Location = new Point(515, 138);
            label13.Name = "label13";
            label13.Size = new Size(51, 25);
            label13.TabIndex = 23;
            label13.Text = "Paid";
            // 
            // textBox_TotalCost
            // 
            textBox_TotalCost.Location = new Point(515, 106);
            textBox_TotalCost.Name = "textBox_TotalCost";
            textBox_TotalCost.Size = new Size(250, 27);
            textBox_TotalCost.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SteelBlue;
            label12.Location = new Point(515, 78);
            label12.Name = "label12";
            label12.Size = new Size(97, 25);
            label12.TabIndex = 21;
            label12.Text = "Total cost";
            // 
            // textBox_GeneralInformation
            // 
            textBox_GeneralInformation.Location = new Point(515, 48);
            textBox_GeneralInformation.Name = "textBox_GeneralInformation";
            textBox_GeneralInformation.Size = new Size(250, 27);
            textBox_GeneralInformation.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(515, 20);
            label11.Name = "label11";
            label11.Size = new Size(176, 25);
            label11.TabIndex = 19;
            label11.Text = "General Infomation";
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(259, 164);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(250, 27);
            textBox_Address.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(259, 136);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 17;
            label10.Text = "Address";
            // 
            // textBox_PhoneNumber
            // 
            textBox_PhoneNumber.Location = new Point(259, 106);
            textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            textBox_PhoneNumber.Size = new Size(250, 27);
            textBox_PhoneNumber.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(259, 78);
            label9.Name = "label9";
            label9.Size = new Size(140, 25);
            label9.TabIndex = 15;
            label9.Text = "Phone number";
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(259, 48);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(250, 27);
            textBox_Email.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(259, 20);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 13;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(3, 194);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // textBox_Gender
            // 
            textBox_Gender.Location = new Point(3, 222);
            textBox_Gender.Name = "textBox_Gender";
            textBox_Gender.Size = new Size(250, 27);
            textBox_Gender.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(3, 136);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 10;
            label6.Text = "DoB";
            // 
            // dateTimePicker_DoB
            // 
            dateTimePicker_DoB.Location = new Point(3, 164);
            dateTimePicker_DoB.Name = "dateTimePicker_DoB";
            dateTimePicker_DoB.Size = new Size(250, 27);
            dateTimePicker_DoB.TabIndex = 9;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(3, 106);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(250, 27);
            textBox_Name.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(3, 78);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 7;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(3, 20);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 5;
            label4.Text = "Record ID";
            // 
            // recordIDBox
            // 
            recordIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordIDBox.Location = new Point(3, 48);
            recordIDBox.Name = "recordIDBox";
            recordIDBox.PlaceholderText = "Record ID";
            recordIDBox.ReadOnly = true;
            recordIDBox.Size = new Size(250, 27);
            recordIDBox.TabIndex = 0;
            // 
            // recordData
            // 
            recordData.AllowUserToAddRows = false;
            recordData.AllowUserToDeleteRows = false;
            recordData.AllowUserToResizeColumns = false;
            recordData.AllowUserToResizeRows = false;
            recordData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            recordData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            recordData.BorderStyle = BorderStyle.None;
            recordData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordData.Dock = DockStyle.Bottom;
            recordData.Location = new Point(0, 350);
            recordData.Name = "recordData";
            recordData.RowHeadersWidth = 51;
            recordData.Size = new Size(900, 350);
            recordData.TabIndex = 2;
            recordData.CellClick += recordData_CellClick;
            // 
            // Dentist_Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Record";
            Text = "Dentist_Record";
            Load += Dentist_Record_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView recordData;
        private Panel panel2;
        private Label label1;
        private Button deleteRecordButton;
        private TextBox recordIDBox;
        private Label label4;
        private Button refreshButton;
        private Button button_Update;
        private Button addRecordButton;
        private Label label5;
        private TextBox textBox_PhoneNumber;
        private Label label9;
        private TextBox textBox_Email;
        private Label label8;
        private Label label7;
        private TextBox textBox_Gender;
        private Label label6;
        private DateTimePicker dateTimePicker_DoB;
        private TextBox textBox_Name;
        private TextBox textBox_GeneralInformation;
        private Label label11;
        private TextBox textBox_Address;
        private Label label10;
        private TextBox textBox_PaidAmount;
        private Label label13;
        private TextBox textBox_TotalCost;
        private Label label12;
    }
}