namespace PRL.View
{
    partial class Orderform
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
            groupBox2 = new GroupBox();
            dgvHDCT = new DataGridView();
            groupBox1 = new GroupBox();
            dgvSP = new DataGridView();
            label10 = new Label();
            txtMSP = new TextBox();
            bttXoa = new Button();
            label9 = new Label();
            txtHDCT = new TextBox();
            RBCTT = new RadioButton();
            RBDTT = new RadioButton();
            bttCL = new Button();
            txtTKSP = new TextBox();
            bttSua = new Button();
            button2 = new Button();
            DTPVC = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            txtGia = new TextBox();
            label4 = new Label();
            txtSL = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtSZ = new TextBox();
            label1 = new Label();
            txtSP = new TextBox();
            panel1 = new Panel();
            cbImei = new ComboBox();
            bttRL = new Button();
            txtHDHT = new TextBox();
            groupBox3 = new GroupBox();
            dgvHD = new DataGridView();
            bttHDCT = new Button();
            bttCheck = new Button();
            bttHDT = new Button();
            bttCHD = new Button();
            label11 = new Label();
            txtSPCT = new TextBox();
            label8 = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cbSPTk = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateBlue;
            groupBox2.Controls.Add(dgvHDCT);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(425, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(813, 321);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // dgvHDCT
            // 
            dgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDCT.Location = new Point(17, 22);
            dgvHDCT.Name = "dgvHDCT";
            dgvHDCT.RowHeadersWidth = 51;
            dgvHDCT.RowTemplate.Height = 25;
            dgvHDCT.Size = new Size(777, 287);
            dgvHDCT.TabIndex = 1;
            dgvHDCT.CellContentClick += dgvHDCT_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(dgvSP);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(8, 435);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 225);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // dgvSP
            // 
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(7, 22);
            dgvSP.Name = "dgvSP";
            dgvSP.RowHeadersWidth = 51;
            dgvSP.RowTemplate.Height = 25;
            dgvSP.Size = new Size(656, 197);
            dgvSP.TabIndex = 2;
            dgvSP.CellContentClick += dgvHD_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.SlateBlue;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(6, 13);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 63;
            label10.Text = "Mã Sản Phẩm";
            // 
            // txtMSP
            // 
            txtMSP.Location = new Point(110, 10);
            txtMSP.Name = "txtMSP";
            txtMSP.ReadOnly = true;
            txtMSP.Size = new Size(298, 23);
            txtMSP.TabIndex = 62;
            // 
            // bttXoa
            // 
            bttXoa.ForeColor = SystemColors.ActiveCaptionText;
            bttXoa.Location = new Point(324, 405);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(75, 23);
            bttXoa.TabIndex = 61;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += button5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.SlateBlue;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(6, 49);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 60;
            label9.Text = "Mã Hóa đơn CT";
            // 
            // txtHDCT
            // 
            txtHDCT.Location = new Point(110, 46);
            txtHDCT.Name = "txtHDCT";
            txtHDCT.ReadOnly = true;
            txtHDCT.Size = new Size(298, 23);
            txtHDCT.TabIndex = 59;
            // 
            // RBCTT
            // 
            RBCTT.AutoSize = true;
            RBCTT.BackColor = Color.SlateBlue;
            RBCTT.ForeColor = SystemColors.ButtonHighlight;
            RBCTT.Location = new Point(257, 369);
            RBCTT.Name = "RBCTT";
            RBCTT.Size = new Size(108, 19);
            RBCTT.TabIndex = 58;
            RBCTT.TabStop = true;
            RBCTT.Text = "Chờ thanh toán";
            RBCTT.UseVisualStyleBackColor = false;
            // 
            // RBDTT
            // 
            RBDTT.AutoSize = true;
            RBDTT.BackColor = Color.SlateBlue;
            RBDTT.Enabled = false;
            RBDTT.ForeColor = SystemColors.ButtonHighlight;
            RBDTT.Location = new Point(112, 369);
            RBDTT.Name = "RBDTT";
            RBDTT.Size = new Size(100, 19);
            RBDTT.TabIndex = 57;
            RBDTT.TabStop = true;
            RBDTT.Text = "Đã thanh toán";
            RBDTT.UseVisualStyleBackColor = false;
            // 
            // bttCL
            // 
            bttCL.ForeColor = SystemColors.ActiveCaptionText;
            bttCL.Location = new Point(126, 404);
            bttCL.Name = "bttCL";
            bttCL.Size = new Size(75, 23);
            bttCL.TabIndex = 56;
            bttCL.Text = "Clear";
            bttCL.UseVisualStyleBackColor = true;
            bttCL.Click += bttCL_Click;
            // 
            // txtTKSP
            // 
            txtTKSP.Location = new Point(554, 406);
            txtTKSP.Name = "txtTKSP";
            txtTKSP.Size = new Size(204, 23);
            txtTKSP.TabIndex = 54;
            // 
            // bttSua
            // 
            bttSua.ForeColor = SystemColors.ActiveCaptionText;
            bttSua.Location = new Point(223, 404);
            bttSua.Name = "bttSua";
            bttSua.Size = new Size(75, 23);
            bttSua.TabIndex = 53;
            bttSua.Text = "Sửa";
            bttSua.UseVisualStyleBackColor = true;
            bttSua.Click += bttSua_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(27, 404);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 52;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DTPVC
            // 
            DTPVC.CustomFormat = "";
            DTPVC.Format = DateTimePickerFormat.Short;
            DTPVC.Location = new Point(112, 210);
            DTPVC.Margin = new Padding(3, 2, 3, 2);
            DTPVC.Name = "DTPVC";
            DTPVC.Size = new Size(147, 23);
            DTPVC.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SlateBlue;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(8, 373);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 50;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SlateBlue;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(8, 299);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 49;
            label5.Text = "Giá";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(112, 291);
            txtGia.Name = "txtGia";
            txtGia.ReadOnly = true;
            txtGia.Size = new Size(298, 23);
            txtGia.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SlateBlue;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(8, 258);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 47;
            label4.Text = "Số lượng Mua";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(112, 250);
            txtSL.Name = "txtSL";
            txtSL.ReadOnly = true;
            txtSL.Size = new Size(298, 23);
            txtSL.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SlateBlue;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(8, 216);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 45;
            label3.Text = "Hạn giảm giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SlateBlue;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(8, 173);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 44;
            label2.Text = "Giảm giá";
            // 
            // txtSZ
            // 
            txtSZ.Location = new Point(112, 170);
            txtSZ.Name = "txtSZ";
            txtSZ.ReadOnly = true;
            txtSZ.Size = new Size(298, 23);
            txtSZ.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateBlue;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(8, 131);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 42;
            label1.Text = "Tên sản phẩm";
            // 
            // txtSP
            // 
            txtSP.Location = new Point(112, 128);
            txtSP.Name = "txtSP";
            txtSP.ReadOnly = true;
            txtSP.Size = new Size(298, 23);
            txtSP.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(cbSPTk);
            panel1.Controls.Add(cbImei);
            panel1.Controls.Add(bttRL);
            panel1.Controls.Add(txtHDHT);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(bttHDCT);
            panel1.Controls.Add(bttCheck);
            panel1.Controls.Add(bttHDT);
            panel1.Controls.Add(bttCHD);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtSPCT);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(DTPVC);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(bttXoa);
            panel1.Controls.Add(txtSL);
            panel1.Controls.Add(txtTKSP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RBCTT);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bttCL);
            panel1.Controls.Add(txtSZ);
            panel1.Controls.Add(RBDTT);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtSP);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(bttSua);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-2, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1663, 920);
            panel1.TabIndex = 70;
            // 
            // cbImei
            // 
            cbImei.FormattingEnabled = true;
            cbImei.Location = new Point(112, 326);
            cbImei.Name = "cbImei";
            cbImei.Size = new Size(298, 23);
            cbImei.TabIndex = 83;
            // 
            // bttRL
            // 
            bttRL.ForeColor = SystemColors.ActiveCaptionText;
            bttRL.Location = new Point(1086, 343);
            bttRL.Name = "bttRL";
            bttRL.Size = new Size(75, 23);
            bttRL.TabIndex = 82;
            bttRL.Text = "RL";
            bttRL.UseVisualStyleBackColor = true;
            bttRL.Click += bttRL_Click_1;
            // 
            // txtHDHT
            // 
            txtHDHT.Location = new Point(265, 210);
            txtHDHT.Name = "txtHDHT";
            txtHDHT.ReadOnly = true;
            txtHDHT.Size = new Size(145, 23);
            txtHDHT.TabIndex = 71;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHD);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(701, 435);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(541, 225);
            groupBox3.TabIndex = 79;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa Đơn";
            // 
            // dgvHD
            // 
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Location = new Point(6, 22);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(529, 197);
            dgvHD.TabIndex = 2;
            dgvHD.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bttHDCT
            // 
            bttHDCT.ForeColor = SystemColors.ActiveCaptionText;
            bttHDCT.Location = new Point(1167, 343);
            bttHDCT.Name = "bttHDCT";
            bttHDCT.Size = new Size(75, 23);
            bttHDCT.TabIndex = 78;
            bttHDCT.Text = "HDCT";
            bttHDCT.UseVisualStyleBackColor = true;
            bttHDCT.Click += bttHDCT_Click;
            // 
            // bttCheck
            // 
            bttCheck.ForeColor = SystemColors.ActiveCaptionText;
            bttCheck.Location = new Point(444, 343);
            bttCheck.Name = "bttCheck";
            bttCheck.Size = new Size(75, 23);
            bttCheck.TabIndex = 77;
            bttCheck.Text = "Check";
            bttCheck.UseVisualStyleBackColor = true;
            bttCheck.Click += bttCheck_Click;
            // 
            // bttHDT
            // 
            bttHDT.ForeColor = SystemColors.ActiveCaptionText;
            bttHDT.Location = new Point(1202, 404);
            bttHDT.Name = "bttHDT";
            bttHDT.Size = new Size(34, 23);
            bttHDT.TabIndex = 76;
            bttHDT.Text = "-";
            bttHDT.UseVisualStyleBackColor = true;
            bttHDT.Click += bttHDT_Click;
            // 
            // bttCHD
            // 
            bttCHD.ForeColor = SystemColors.ActiveCaptionText;
            bttCHD.Location = new Point(1165, 404);
            bttCHD.Name = "bttCHD";
            bttCHD.Size = new Size(31, 23);
            bttCHD.TabIndex = 74;
            bttCHD.Text = "+";
            bttCHD.UseVisualStyleBackColor = true;
            bttCHD.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.SlateBlue;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(8, 92);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 73;
            label11.Text = "Mã Imei";
            // 
            // txtSPCT
            // 
            txtSPCT.Location = new Point(112, 89);
            txtSPCT.Name = "txtSPCT";
            txtSPCT.ReadOnly = true;
            txtSPCT.Size = new Size(298, 23);
            txtSPCT.TabIndex = 71;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SlateBlue;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(8, 329);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 72;
            label8.Text = "Imei";
            // 
            // btnSearch
            // 
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 17;
            btnSearch.Location = new Point(764, 406);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(37, 23);
            btnSearch.TabIndex = 56;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // cbSPTk
            // 
            cbSPTk.FormattingEnabled = true;
            cbSPTk.Location = new Point(427, 406);
            cbSPTk.Name = "cbSPTk";
            cbSPTk.Size = new Size(121, 23);
            cbSPTk.TabIndex = 84;
            // 
            // Orderform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 658);
            Controls.Add(groupBox2);
            Controls.Add(label10);
            Controls.Add(txtMSP);
            Controls.Add(label9);
            Controls.Add(txtHDCT);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Orderform";
            Text = "Order";
            Load += Order_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dgvHDCT;
        private GroupBox groupBox1;
        private DataGridView dgvSP;
        private Label label10;
        private TextBox txtMSP;
        private Button bttXoa;
        private Label label9;
        private TextBox txtHDCT;
        private RadioButton RBCTT;
        private RadioButton RBDTT;
        private Button bttCL;
        private Label label7;
        private TextBox txtTKSP;
        private Button bttSua;
        private Button button2;
        private DateTimePicker DTPVC;
        private Label label6;
        private Label label5;
        private TextBox txtGia;
        private Label label4;
        private TextBox txtSL;
        private Label label3;
        private Label label2;
        private TextBox txtSZ;
        private Label label1;
        private TextBox txtSP;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Label label8;
        private TextBox txtSPCT;
        private Label label11;
        private Button bttHDT;
        private Button bttCHD;
        private TextBox txtHDHT;
        private DataGridView dgvHD;
        private Button bttCheck;
        private Button bttHDCT;
        private GroupBox groupBox3;
        private Button bttRL;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cbImei;
        private ComboBox cbSPTk;
    }
}