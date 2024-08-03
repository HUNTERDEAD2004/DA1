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
            txtImport = new TextBox();
            label15 = new Label();
            cbVersion = new ComboBox();
            cbBattery = new ComboBox();
            label20 = new Label();
            txt = new Label();
            cbSystem = new ComboBox();
            cbOrigin = new ComboBox();
            cbYOM = new ComboBox();
            cbWeight = new ComboBox();
            cbMaterial = new ComboBox();
            cbSelfie = new ComboBox();
            cbRear = new ComboBox();
            txt1 = new Label();
            txt2 = new Label();
            tt = new Label();
            t = new Label();
            txt3 = new Label();
            label14 = new Label();
            label3 = new Label();
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
            btnAdd.Location = new Point(918, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1002, 317);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(1086, 317);
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
            panel1.Controls.Add(txtImport);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(cbVersion);
            panel1.Controls.Add(cbBattery);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(txt);
            panel1.Controls.Add(cbSystem);
            panel1.Controls.Add(cbOrigin);
            panel1.Controls.Add(cbYOM);
            panel1.Controls.Add(cbWeight);
            panel1.Controls.Add(cbMaterial);
            panel1.Controls.Add(cbSelfie);
            panel1.Controls.Add(cbRear);
            panel1.Controls.Add(txt1);
            panel1.Controls.Add(txt2);
            panel1.Controls.Add(tt);
            panel1.Controls.Add(t);
            panel1.Controls.Add(txt3);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label3);
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
            panel1.Size = new Size(1527, 773);
            panel1.TabIndex = 0;
            // 
            // txtImport
            // 
            txtImport.Location = new Point(986, 144);
            txtImport.Name = "txtImport";
            txtImport.Size = new Size(163, 23);
            txtImport.TabIndex = 44;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(908, 149);
            label15.Name = "label15";
            label15.Size = new Size(72, 15);
            label15.TabIndex = 43;
            label15.Text = "Import Price";
            // 
            // cbVersion
            // 
            cbVersion.FormattingEnabled = true;
            cbVersion.Location = new Point(985, 98);
            cbVersion.Name = "cbVersion";
            cbVersion.Size = new Size(163, 23);
            cbVersion.TabIndex = 41;
            // 
            // cbBattery
            // 
            cbBattery.FormattingEnabled = true;
            cbBattery.Location = new Point(985, 48);
            cbBattery.Name = "cbBattery";
            cbBattery.Size = new Size(163, 23);
            cbBattery.TabIndex = 42;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.ButtonHighlight;
            label20.Location = new Point(909, 103);
            label20.Name = "label20";
            label20.Size = new Size(45, 15);
            label20.TabIndex = 39;
            label20.Text = "Version";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.ForeColor = SystemColors.ButtonHighlight;
            txt.Location = new Point(909, 53);
            txt.Name = "txt";
            txt.Size = new Size(44, 15);
            txt.TabIndex = 40;
            txt.Text = "Battery";
            // 
            // cbSystem
            // 
            cbSystem.FormattingEnabled = true;
            cbSystem.Location = new Point(715, 295);
            cbSystem.Name = "cbSystem";
            cbSystem.Size = new Size(163, 23);
            cbSystem.TabIndex = 38;
            // 
            // cbOrigin
            // 
            cbOrigin.FormattingEnabled = true;
            cbOrigin.Location = new Point(715, 195);
            cbOrigin.Name = "cbOrigin";
            cbOrigin.Size = new Size(163, 23);
            cbOrigin.TabIndex = 38;
            // 
            // cbYOM
            // 
            cbYOM.FormattingEnabled = true;
            cbYOM.Location = new Point(715, 98);
            cbYOM.Name = "cbYOM";
            cbYOM.Size = new Size(163, 23);
            cbYOM.TabIndex = 38;
            // 
            // cbWeight
            // 
            cbWeight.FormattingEnabled = true;
            cbWeight.Location = new Point(715, 245);
            cbWeight.Name = "cbWeight";
            cbWeight.Size = new Size(163, 23);
            cbWeight.TabIndex = 38;
            // 
            // cbMaterial
            // 
            cbMaterial.FormattingEnabled = true;
            cbMaterial.Location = new Point(715, 144);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(163, 23);
            cbMaterial.TabIndex = 38;
            // 
            // cbSelfie
            // 
            cbSelfie.FormattingEnabled = true;
            cbSelfie.Location = new Point(715, 48);
            cbSelfie.Name = "cbSelfie";
            cbSelfie.Size = new Size(163, 23);
            cbSelfie.TabIndex = 38;
            // 
            // cbRear
            // 
            cbRear.FormattingEnabled = true;
            cbRear.Location = new Point(422, 295);
            cbRear.Name = "cbRear";
            cbRear.Size = new Size(163, 23);
            cbRear.TabIndex = 38;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.ForeColor = SystemColors.ButtonHighlight;
            txt1.Location = new Point(623, 300);
            txt1.Name = "txt1";
            txt1.Size = new Size(45, 15);
            txt1.TabIndex = 37;
            txt1.Text = "System";
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.ForeColor = SystemColors.ButtonHighlight;
            txt2.Location = new Point(623, 250);
            txt2.Name = "txt2";
            txt2.Size = new Size(45, 15);
            txt2.TabIndex = 37;
            txt2.Text = "Weight";
            // 
            // tt
            // 
            tt.AutoSize = true;
            tt.ForeColor = SystemColors.ButtonHighlight;
            tt.Location = new Point(623, 200);
            tt.Name = "tt";
            tt.Size = new Size(40, 15);
            tt.TabIndex = 37;
            tt.Text = "Origin";
            // 
            // t
            // 
            t.AutoSize = true;
            t.ForeColor = SystemColors.ButtonHighlight;
            t.Location = new Point(623, 149);
            t.Name = "t";
            t.Size = new Size(50, 15);
            t.TabIndex = 37;
            t.Text = "Material";
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.ForeColor = SystemColors.ButtonHighlight;
            txt3.Location = new Point(623, 103);
            txt3.Name = "txt3";
            txt3.Size = new Size(34, 15);
            txt3.TabIndex = 37;
            txt3.Text = "YOM";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(623, 53);
            label14.Name = "label14";
            label14.Size = new Size(79, 15);
            label14.TabIndex = 37;
            label14.Text = "Camera Seflie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(342, 300);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 37;
            label3.Text = "Rear Camera";
            // 
            // dgvDetails
            // 
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(36, 356);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowHeadersWidth = 51;
            dgvDetails.RowTemplate.Height = 25;
            dgvDetails.Size = new Size(1125, 226);
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
            cbDisplay.Location = new Point(422, 250);
            cbDisplay.Name = "cbDisplay";
            cbDisplay.Size = new Size(163, 23);
            cbDisplay.TabIndex = 34;
            // 
            // cbRom
            // 
            cbRom.FormattingEnabled = true;
            cbRom.Location = new Point(422, 195);
            cbRom.Name = "cbRom";
            cbRom.Size = new Size(163, 23);
            cbRom.TabIndex = 33;
            // 
            // cbGPU
            // 
            cbGPU.FormattingEnabled = true;
            cbGPU.Location = new Point(422, 145);
            cbGPU.Name = "cbGPU";
            cbGPU.Size = new Size(163, 23);
            cbGPU.TabIndex = 32;
            // 
            // cbCpu
            // 
            cbCpu.FormattingEnabled = true;
            cbCpu.Location = new Point(422, 100);
            cbCpu.Name = "cbCpu";
            cbCpu.Size = new Size(163, 23);
            cbCpu.TabIndex = 31;
            // 
            // cbRam
            // 
            cbRam.FormattingEnabled = true;
            cbRam.Location = new Point(422, 50);
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
            ClientSize = new Size(1499, 667);
            Controls.Add(panel1);
            Name = "ProductDetails";
            Text = "ProductDetails";
            Load += ProductDetails_Load;
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
        private ComboBox cbRear;
        private Label label3;
        private ComboBox cbVersion;
        private ComboBox cbBattery;
        private Label label20;
        private Label txt;
        private ComboBox cbSystem;
        private ComboBox cbOrigin;
        private ComboBox cbYOM;
        private ComboBox cbWeight;
        private ComboBox cbMaterial;
        private ComboBox cbSelfie;
        private Label txt1;
        private Label txt2;
        private Label tt;
        private Label t;
        private Label txt3;
        private Label label14;
        private TextBox txtImport;
        private Label label15;
    }
}