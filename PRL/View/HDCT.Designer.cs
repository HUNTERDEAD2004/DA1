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
            dgvKH = new DataGridView();
            ss = new Label();
            txtMKH = new TextBox();
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
            txtTT = new TextBox();
            label4 = new Label();
            txtSL = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            groupBox4 = new GroupBox();
            lab32 = new Label();
            txtMHD = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDTT).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDC).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(745, 303);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 86;
            label3.Text = "Tìm kiếm";
            // 
            // txtTKH
            // 
            txtTKH.Location = new Point(845, 300);
            txtTKH.Name = "txtTKH";
            txtTKH.Size = new Size(340, 23);
            txtTKH.TabIndex = 85;
            // 
            // button6
            // 
            button6.Location = new Point(1191, 300);
            button6.Name = "button6";
            button6.Size = new Size(39, 23);
            button6.TabIndex = 84;
            button6.Text = "Tìm";
            button6.UseVisualStyleBackColor = true;
            // 
            // dgvKH
            // 
            dgvKH.AllowUserToAddRows = false;
            dgvKH.AllowUserToDeleteRows = false;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new Point(14, 20);
            dgvKH.Name = "dgvKH";
            dgvKH.ReadOnly = true;
            dgvKH.RowHeadersWidth = 51;
            dgvKH.RowTemplate.Height = 25;
            dgvKH.Size = new Size(487, 244);
            dgvKH.TabIndex = 62;
            // 
            // ss
            // 
            ss.AutoSize = true;
            ss.Location = new Point(750, 181);
            ss.Name = "ss";
            ss.Size = new Size(90, 15);
            ss.TabIndex = 83;
            ss.Text = "Mã Khách hàng";
            ss.Click += ss_Click;
            // 
            // txtMKH
            // 
            txtMKH.Location = new Point(853, 178);
            txtMKH.Name = "txtMKH";
            txtMKH.Size = new Size(340, 23);
            txtMKH.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(750, 63);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 78;
            label1.Text = "Mã Nhân Viên";
            // 
            // txtMNV
            // 
            txtMNV.Location = new Point(854, 60);
            txtMNV.Name = "txtMNV";
            txtMNV.Size = new Size(340, 23);
            txtMNV.TabIndex = 76;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(dgvHDTT);
            groupBox2.Location = new Point(12, 328);
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
            bttBack.Location = new Point(1163, 619);
            bttBack.Name = "bttBack";
            bttBack.Size = new Size(75, 23);
            bttBack.TabIndex = 72;
            bttBack.Text = "Back";
            bttBack.UseVisualStyleBackColor = true;
            bttBack.Click += bttBack_Click;
            // 
            // button3
            // 
            button3.Location = new Point(845, 619);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 71;
            button3.Text = "In";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(753, 619);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 70;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(956, 246);
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
            label5.Location = new Point(750, 143);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 67;
            label5.Text = "Tổng tiền";
            // 
            // txtTT
            // 
            txtTT.Location = new Point(854, 140);
            txtTT.Name = "txtTT";
            txtTT.Size = new Size(340, 23);
            txtTT.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(750, 102);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 65;
            label4.Text = "Số lượng Mua";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(854, 99);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(340, 23);
            txtSL.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(750, 220);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 88;
            label6.Text = "SDT";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(854, 217);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(340, 23);
            txtSDT.TabIndex = 87;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvKH);
            groupBox4.Location = new Point(737, 328);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(514, 285);
            groupBox4.TabIndex = 89;
            groupBox4.TabStop = false;
            groupBox4.Text = "Khách hàng";
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
            txtMHD.Size = new Size(340, 23);
            txtMHD.TabIndex = 90;
            // 
            // HDCT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 659);
            Controls.Add(lab32);
            Controls.Add(txtMHD);
            Controls.Add(groupBox4);
            Controls.Add(label6);
            Controls.Add(txtSDT);
            Controls.Add(label3);
            Controls.Add(txtTKH);
            Controls.Add(button6);
            Controls.Add(ss);
            Controls.Add(txtMKH);
            Controls.Add(label1);
            Controls.Add(txtMNV);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(bttBack);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(txtTT);
            Controls.Add(label4);
            Controls.Add(txtSL);
            Name = "HDCT";
            Text = "HDCT";
            Load += HDCT_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDTT).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDC).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtTKH;
        private Button button6;
        private DataGridView dgvKH;
        private Label ss;
        private TextBox txtMKH;
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
        private TextBox txtTT;
        private Label label4;
        private TextBox txtSL;
        private Label label6;
        private TextBox txtSDT;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lab32;
        private TextBox txtMHD;
    }
}