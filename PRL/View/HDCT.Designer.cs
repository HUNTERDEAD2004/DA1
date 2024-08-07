namespace PRL.View
{
    partial class HDCT
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
            label3 = new Label();
            txtTKH = new TextBox();
            button6 = new Button();
            ss = new Label();
            txtKT = new TextBox();
            label1 = new Label();
            txtMNV = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dgvHDTT = new DataGridView();
            groupBox1 = new GroupBox();
            dgvHDC = new DataGridView();
            bttBack = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            label5 = new Label();
            txtVC = new TextBox();
            label4 = new Label();
            txtSL = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            lab32 = new Label();
            txtMHD = new TextBox();
            label2 = new Label();
            txtTTVC = new TextBox();
            label7 = new Label();
            TxtTT = new TextBox();
            label8 = new Label();
            txtVCG = new TextBox();
            label9 = new Label();
            txtTL = new TextBox();
            label10 = new Label();
            txtMVC = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDTT).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDC).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 352);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 86;
            label3.Text = "Tìm kiếm";
            // 
            // txtTKH
            // 
            txtTKH.Location = new Point(329, 349);
            txtTKH.Name = "txtTKH";
            txtTKH.Size = new Size(340, 23);
            txtTKH.TabIndex = 85;
            // 
            // button6
            // 
            button6.Location = new Point(675, 349);
            button6.Name = "button6";
            button6.Size = new Size(39, 23);
            button6.TabIndex = 84;
            button6.Text = "Tìm";
            button6.UseVisualStyleBackColor = true;
            // 
            // ss
            // 
            ss.AutoSize = true;
            ss.Location = new Point(750, 236);
            ss.Name = "ss";
            ss.Size = new Size(58, 15);
            ss.TabIndex = 83;
            ss.Text = "Khách Trả";
            ss.Click += ss_Click;
            // 
            // txtKT
            // 
            txtKT.Location = new Point(853, 233);
            txtKT.Name = "txtKT";
            txtKT.Size = new Size(340, 23);
            txtKT.TabIndex = 82;
            txtKT.Leave += txtKT_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(750, 92);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 78;
            label1.Text = "Nhân Viên";
            // 
            // txtMNV
            // 
            txtMNV.Location = new Point(854, 89);
            txtMNV.Name = "txtMNV";
            txtMNV.ReadOnly = true;
            txtMNV.Size = new Size(340, 23);
            txtMNV.TabIndex = 76;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvHDTT);
            groupBox2.Location = new Point(12, 368);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(708, 285);
            groupBox2.TabIndex = 74;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(741, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(498, 274);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dgvHDTT
            // 
            dgvHDTT.AllowUserToAddRows = false;
            dgvHDTT.AllowUserToDeleteRows = false;
            dgvHDTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDTT.Location = new Point(6, 22);
            dgvHDTT.Name = "dgvHDTT";
            dgvHDTT.ReadOnly = true;
            dgvHDTT.RowHeadersWidth = 51;
            dgvHDTT.RowTemplate.Height = 25;
            dgvHDTT.Size = new Size(686, 244);
            dgvHDTT.TabIndex = 1;
            dgvHDTT.CellContentClick += dgvHDTT_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHDC);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 310);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // dgvHDC
            // 
            dgvHDC.AllowUserToAddRows = false;
            dgvHDC.AllowUserToDeleteRows = false;
            dgvHDC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDC.Location = new Point(6, 16);
            dgvHDC.Name = "dgvHDC";
            dgvHDC.ReadOnly = true;
            dgvHDC.RowHeadersWidth = 51;
            dgvHDC.RowTemplate.Height = 25;
            dgvHDC.Size = new Size(686, 288);
            dgvHDC.TabIndex = 0;
            dgvHDC.CellContentClick += dgvHDC_CellContentClick;
            // 
            // bttBack
            // 
            bttBack.Location = new Point(1163, 659);
            bttBack.Name = "bttBack";
            bttBack.Size = new Size(75, 23);
            bttBack.TabIndex = 72;
            bttBack.Text = "Back";
            bttBack.UseVisualStyleBackColor = true;
            bttBack.Click += bttBack_Click;
            // 
            // button3
            // 
            button3.Location = new Point(845, 659);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 71;
            button3.Text = "In";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(753, 659);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 70;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(970, 586);
            button2.Name = "button2";
            button2.Size = new Size(104, 48);
            button2.TabIndex = 69;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 159);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 67;
            label5.Text = "Vouchers DK";
            // 
            // txtVC
            // 
            txtVC.Location = new Point(854, 156);
            txtVC.Name = "txtVC";
            txtVC.ReadOnly = true;
            txtVC.Size = new Size(139, 23);
            txtVC.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(750, 121);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 65;
            label4.Text = "Số lượng Mua";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(854, 118);
            txtSL.Name = "txtSL";
            txtSL.ReadOnly = true;
            txtSL.Size = new Size(139, 23);
            txtSL.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(753, 312);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 88;
            label6.Text = "SDT";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(853, 309);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(340, 23);
            txtSDT.TabIndex = 87;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // lab32
            // 
            lab32.AutoSize = true;
            lab32.Location = new Point(750, 31);
            lab32.Name = "lab32";
            lab32.Size = new Size(74, 15);
            lab32.TabIndex = 91;
            lab32.Text = "Mã Hóa Đơn";
            // 
            // txtMHD
            // 
            txtMHD.Location = new Point(854, 28);
            txtMHD.Name = "txtMHD";
            txtMHD.ReadOnly = true;
            txtMHD.Size = new Size(340, 23);
            txtMHD.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(749, 197);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 93;
            label2.Text = "Tổng tiền";
            // 
            // txtTTVC
            // 
            txtTTVC.Location = new Point(853, 194);
            txtTTVC.Name = "txtTTVC";
            txtTTVC.ReadOnly = true;
            txtTTVC.Size = new Size(340, 23);
            txtTTVC.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1015, 121);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 95;
            label7.Text = "Tổng";
            // 
            // TxtTT
            // 
            TxtTT.Location = new Point(1055, 118);
            TxtTT.Name = "TxtTT";
            TxtTT.ReadOnly = true;
            TxtTT.Size = new Size(139, 23);
            TxtTT.TabIndex = 94;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1014, 164);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 97;
            label8.Text = "Giảm";
            // 
            // txtVCG
            // 
            txtVCG.Location = new Point(1055, 156);
            txtVCG.Name = "txtVCG";
            txtVCG.ReadOnly = true;
            txtVCG.Size = new Size(139, 23);
            txtVCG.TabIndex = 96;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(750, 274);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 99;
            label9.Text = "Trả lại";
            // 
            // txtTL
            // 
            txtTL.Location = new Point(853, 271);
            txtTL.Name = "txtTL";
            txtTL.ReadOnly = true;
            txtTL.Size = new Size(340, 23);
            txtTL.TabIndex = 98;
            txtTL.TextChanged += txtSDT_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(750, 60);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 101;
            label10.Text = "Mã Vouchers";
            // 
            // txtMVC
            // 
            txtMVC.Location = new Point(854, 57);
            txtMVC.Name = "txtMVC";
            txtMVC.ReadOnly = true;
            txtMVC.Size = new Size(340, 23);
            txtMVC.TabIndex = 100;
            // 
            // HDCT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 694);
            Controls.Add(label10);
            Controls.Add(txtMVC);
            Controls.Add(label9);
            Controls.Add(txtTL);
            Controls.Add(label8);
            Controls.Add(txtVCG);
            Controls.Add(label7);
            Controls.Add(TxtTT);
            Controls.Add(label2);
            Controls.Add(txtTTVC);
            Controls.Add(lab32);
            Controls.Add(txtMHD);
            Controls.Add(label6);
            Controls.Add(txtSDT);
            Controls.Add(label3);
            Controls.Add(txtTKH);
            Controls.Add(button6);
            Controls.Add(ss);
            Controls.Add(txtKT);
            Controls.Add(label1);
            Controls.Add(txtMNV);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(bttBack);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(txtVC);
            Controls.Add(label4);
            Controls.Add(txtSL);
            Name = "HDCT";
            Text = "HDCT";
            Load += HDCT_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDTT).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtTKH;
        private Button button6;
        private Label ss;
        private TextBox txtKT;
        private Label label1;
        private TextBox txtMNV;
        private GroupBox groupBox2;
        private DataGridView dgvHDTT;
        private GroupBox groupBox1;
        private DataGridView dgvHDC;
        private Button bttBack;
        private Button button3;
        private Button button4;
        private Button button2;
        private Label label5;
        private TextBox txtVC;
        private Label label4;
        private TextBox txtSL;
        private Label label6;
        private TextBox txtSDT;
        private GroupBox groupBox3;
        private Label lab32;
        private TextBox txtMHD;
        private Label label2;
        private TextBox txtTTVC;
        private Label label7;
        private TextBox TxtTT;
        private Label label8;
        private TextBox txtVCG;
        private Label label9;
        private TextBox txtTL;
        private Label label10;
        private TextBox txtMVC;
    }
}