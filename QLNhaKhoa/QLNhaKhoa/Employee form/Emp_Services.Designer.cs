namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Services
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
            searchIDBox = new TextBox();
            searchButton = new Button();
            refreshButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            serviceNameBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            priceBox = new TextBox();
            servicesIDBox = new TextBox();
            serviceData = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(searchIDBox);
            panel3.Controls.Add(searchButton);
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(serviceData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 9;
            // 
            // searchIDBox
            // 
            searchIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchIDBox.Location = new Point(569, 311);
            searchIDBox.MaxLength = 10;
            searchIDBox.Name = "searchIDBox";
            searchIDBox.PlaceholderText = "Enter service ID to search";
            searchIDBox.Size = new Size(200, 27);
            searchIDBox.TabIndex = 16;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SteelBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Tw Cen MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(775, 311);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 27);
            searchButton.TabIndex = 17;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(50, 300);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(200, 40);
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
            label1.Location = new Point(351, 25);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 0;
            label1.Text = "Dental Services";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(serviceNameBox);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(priceBox);
            panel4.Controls.Add(servicesIDBox);
            panel4.Location = new Point(50, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // serviceNameBox
            // 
            serviceNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceNameBox.Location = new Point(100, 180);
            serviceNameBox.MaxLength = 5;
            serviceNameBox.Name = "serviceNameBox";
            serviceNameBox.PlaceholderText = "Service Name";
            serviceNameBox.ReadOnly = true;
            serviceNameBox.Size = new Size(600, 27);
            serviceNameBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 154);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 5;
            label4.Text = "Service Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 54);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 54);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Service ID";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(450, 80);
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.ReadOnly = true;
            priceBox.Size = new Size(250, 27);
            priceBox.TabIndex = 1;
            // 
            // servicesIDBox
            // 
            servicesIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            servicesIDBox.Location = new Point(100, 80);
            servicesIDBox.MaxLength = 5;
            servicesIDBox.Name = "servicesIDBox";
            servicesIDBox.PlaceholderText = "Service ID";
            servicesIDBox.ReadOnly = true;
            servicesIDBox.Size = new Size(250, 27);
            servicesIDBox.TabIndex = 0;
            // 
            // serviceData
            // 
            serviceData.AllowUserToAddRows = false;
            serviceData.AllowUserToDeleteRows = false;
            serviceData.AllowUserToResizeColumns = false;
            serviceData.AllowUserToResizeRows = false;
            serviceData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            serviceData.BorderStyle = BorderStyle.None;
            serviceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceData.Dock = DockStyle.Bottom;
            serviceData.Location = new Point(0, 350);
            serviceData.Name = "serviceData";
            serviceData.RowHeadersWidth = 51;
            serviceData.Size = new Size(900, 350);
            serviceData.TabIndex = 2;
            serviceData.CellClick += serviceData_CellClick;
            // 
            // Emp_Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp_Services";
            Text = "Emp_Services";
            Load += Emp_Services_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox priceBox;
        private TextBox servicesIDBox;
        private DataGridView serviceData;
        private TextBox serviceNameBox;
        private Button refreshButton;
        private TextBox searchIDBox;
        private Button searchButton;
    }
}