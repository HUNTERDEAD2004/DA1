namespace PRL.View
{
    partial class ProductDetails
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
            txtImei = new TextBox();
            label1 = new Label();
            txtProductID = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            panel1 = new Panel();
            dgvDetails = new DataGridView();
            cbSale = new ComboBox();
            cbDisplay = new ComboBox();
            cbRom = new ComboBox();
            cbGPU = new ComboBox();
            cbCpu = new ComboBox();
            cbRam = new ComboBox();
            cbColor = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // txtImei
            // 
            txtImei.Location = new Point(109, 45);
            txtImei.Name = "txtImei";
            txtImei.ReadOnly = true;
            txtImei.Size = new Size(163, 23);
            txtImei.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "IMEI";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(109, 95);
            txtProductID.Name = "txtProductID";
            txtProductID.ReadOnly = true;
            txtProductID.Size = new Size(163, 23);
            txtProductID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 98);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Product ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(36, 248);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Color";
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 145);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 23);
            txtName.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(36, 148);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 9;
            label6.Text = "Name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(109, 195);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(163, 23);
            txtPrice.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-306, 129);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "IMEI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(36, 198);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 12;
            label7.Text = "Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(342, 53);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 14;
            label13.Text = "Ram";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(342, 103);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 16;
            label12.Text = "Cpu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(342, 253);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 18;
            label11.Text = "Display";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(36, 298);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 20;
            label10.Text = "Sale";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(342, 153);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 22;
            label9.Text = "Gpu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(342, 203);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 24;
            label8.Text = "Rom";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(790, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(874, 290);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(958, 290);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 27;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(dgvDetails);
            panel1.Controls.Add(cbSale);
            panel1.Controls.Add(cbDisplay);
            panel1.Controls.Add(cbRom);
            panel1.Controls.Add(cbGPU);
            panel1.Controls.Add(cbCpu);
            panel1.Controls.Add(cbRam);
            panel1.Controls.Add(cbColor);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtProductID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtImei);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 434);
            panel1.TabIndex = 0;
            // 
            // dgvDetails
            // 
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(591, 45);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowTemplate.Height = 25;
            dgvDetails.Size = new Size(440, 226);
            dgvDetails.TabIndex = 36;
            dgvDetails.CellContentClick += dgvDetails_CellContentClick;
            // 
            // cbSale
            // 
            cbSale.FormattingEnabled = true;
            cbSale.Location = new Point(109, 295);
            cbSale.Name = "cbSale";
            cbSale.Size = new Size(163, 23);
            cbSale.TabIndex = 35;
            // 
            // cbDisplay
            // 
            cbDisplay.FormattingEnabled = true;
            cbDisplay.Location = new Point(394, 248);
            cbDisplay.Name = "cbDisplay";
            cbDisplay.Size = new Size(163, 23);
            cbDisplay.TabIndex = 34;
            // 
            // cbRom
            // 
            cbRom.FormattingEnabled = true;
            cbRom.Location = new Point(394, 198);
            cbRom.Name = "cbRom";
            cbRom.Size = new Size(163, 23);
            cbRom.TabIndex = 33;
            // 
            // cbGPU
            // 
            cbGPU.FormattingEnabled = true;
            cbGPU.Location = new Point(394, 148);
            cbGPU.Name = "cbGPU";
            cbGPU.Size = new Size(163, 23);
            cbGPU.TabIndex = 32;
            // 
            // cbCpu
            // 
            cbCpu.FormattingEnabled = true;
            cbCpu.Location = new Point(394, 98);
            cbCpu.Name = "cbCpu";
            cbCpu.Size = new Size(163, 23);
            cbCpu.TabIndex = 31;
            // 
            // cbRam
            // 
            cbRam.FormattingEnabled = true;
            cbRam.Location = new Point(394, 48);
            cbRam.Name = "cbRam";
            cbRam.Size = new Size(163, 23);
            cbRam.TabIndex = 30;
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Location = new Point(109, 245);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(163, 23);
            cbColor.TabIndex = 28;
            // 
            // ProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 425);
            Controls.Add(panel1);
            Name = "ProductDetails";
            Text = "ProductDetails";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtImei;
        private Label label1;
        private TextBox txtProductID;
        private Label label2;
        private Label label4;
        private TextBox txtName;
        private Label label6;
        private TextBox txtPrice;
        private Label label5;
        private Label label7;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDel;
        private Panel panel1;
        private ComboBox cbSale;
        private ComboBox cbDisplay;
        private ComboBox cbRom;
        private ComboBox cbGPU;
        private ComboBox cbCpu;
        private ComboBox cbRam;
        private ComboBox cbColor;
        private DataGridView dgvDetails;
    }
}