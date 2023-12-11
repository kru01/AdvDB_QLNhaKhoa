namespace QLNhaKhoa
{
    partial class Account
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
            label6 = new Label();
            IDBox = new TextBox();
            label5 = new Label();
            passwordBox = new TextBox();
            updateButton = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            bdayBox = new DateTimePicker();
            nameBox = new TextBox();
            phoneBox = new TextBox();
            addressBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(IDBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(bdayBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(phoneBox);
            panel1.Controls.Add(addressBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(200, 215);
            label6.Name = "label6";
            label6.Size = new Size(26, 23);
            label6.TabIndex = 20;
            label6.Text = "ID";
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDBox.Location = new Point(200, 241);
            IDBox.MaxLength = 11;
            IDBox.Name = "IDBox";
            IDBox.PlaceholderText = "ID";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(125, 27);
            IDBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(550, 335);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 18;
            label5.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(550, 361);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Password";
            passwordBox.Size = new Size(150, 27);
            passwordBox.TabIndex = 17;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(350, 550);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(200, 50);
            updateButton.TabIndex = 16;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.setting;
            pictureBox1.InitialImage = Properties.Resources.setting;
            pictureBox1.Location = new Point(375, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(375, 335);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 14;
            label4.Text = "Date of birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(350, 215);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(200, 335);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 12;
            label1.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(200, 460);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 11;
            label3.Text = "Address";
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy-MM-dd";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(375, 361);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(150, 27);
            bdayBox.TabIndex = 3;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(350, 241);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(350, 27);
            nameBox.TabIndex = 2;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(200, 361);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone number";
            phoneBox.Size = new Size(150, 27);
            phoneBox.TabIndex = 1;
            phoneBox.KeyPress += phoneBox_KeyPress;
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(200, 486);
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(500, 27);
            addressBox.TabIndex = 0;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button updateButton;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private DateTimePicker bdayBox;
        private TextBox nameBox;
        private TextBox phoneBox;
        private TextBox addressBox;
        private Label label5;
        private TextBox passwordBox;
        private Label label6;
        private TextBox IDBox;
    }
}