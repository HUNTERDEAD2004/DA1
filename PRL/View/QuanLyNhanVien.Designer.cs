namespace PRL.View
{
    partial class QuanLyNhanVien
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
            btntimkiem = new Button();
            txttimkiem = new TextBox();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            groupBox2 = new GroupBox();
            dgvnhanvien = new DataGridView();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            label7 = new Label();
            rbtnu = new RadioButton();
            radioButton1 = new RadioButton();
            rbtnam = new RadioButton();
            dateNV = new DateTimePicker();
            txtDC = new TextBox();
            lable22 = new Label();
            textRL = new TextBox();
            label12 = new Label();
            rdb_NgungHD = new RadioButton();
            rdb_HoatDong = new RadioButton();
            label10 = new Label();
            label9 = new Label();
            txt_IdNhanVien = new TextBox();
            label4 = new Label();
            txtMK = new TextBox();
            txtTK = new TextBox();
            txtL = new TextBox();
            txtsdt = new TextBox();
            txtemail = new TextBox();
            txtten = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            bttRL = new Button();
            bttCL = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btntimkiem
            // 
            btntimkiem.ForeColor = SystemColors.ActiveCaptionText;
            btntimkiem.Location = new Point(6, 24);
            btntimkiem.Margin = new Padding(3, 2, 3, 2);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(82, 22);
            btntimkiem.TabIndex = 19;
            btntimkiem.Text = "Tìm Kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(94, 23);
            txttimkiem.Margin = new Padding(3, 2, 3, 2);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(836, 23);
            txttimkiem.TabIndex = 18;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(824, 333);
            btnxoa.Margin = new Padding(3, 2, 3, 2);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(82, 22);
            btnxoa.TabIndex = 17;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(723, 333);
            btnsua.Margin = new Padding(3, 2, 3, 2);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(82, 22);
            btnsua.TabIndex = 16;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(626, 333);
            btnthem.Margin = new Padding(3, 2, 3, 2);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(82, 22);
            btnthem.TabIndex = 15;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateBlue;
            groupBox2.Controls.Add(btntimkiem);
            groupBox2.Controls.Add(txttimkiem);
            groupBox2.Controls.Add(dgvnhanvien);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(84, 355);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(940, 249);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.AllowUserToAddRows = false;
            dgvnhanvien.AllowUserToDeleteRows = false;
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.GridColor = SystemColors.ActiveCaptionText;
            dgvnhanvien.Location = new Point(6, 50);
            dgvnhanvien.Margin = new Padding(3, 2, 3, 2);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.ReadOnly = true;
            dgvnhanvien.RowHeadersWidth = 51;
            dgvnhanvien.RowTemplate.Height = 29;
            dgvnhanvien.Size = new Size(924, 195);
            dgvnhanvien.TabIndex = 0;
            dgvnhanvien.CellContentClick += dgvnhanvien_CellContentClick;
            dgvnhanvien.CellFormatting += dgvnhanvien_CellFormatting;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(dateNV);
            groupBox1.Controls.Add(txtDC);
            groupBox1.Controls.Add(lable22);
            groupBox1.Controls.Add(textRL);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(rdb_NgungHD);
            groupBox1.Controls.Add(rdb_HoatDong);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_IdNhanVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(txtTK);
            groupBox1.Controls.Add(txtL);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(79, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(945, 280);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý nhân viên";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(rbtnu);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(rbtnam);
            panel2.Location = new Point(458, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 57);
            panel2.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 22);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 6;
            label7.Text = "Giới tính";
            // 
            // rbtnu
            // 
            rbtnu.AutoSize = true;
            rbtnu.Location = new Point(116, 20);
            rbtnu.Margin = new Padding(3, 2, 3, 2);
            rbtnu.Name = "rbtnu";
            rbtnu.Size = new Size(41, 19);
            rbtnu.TabIndex = 10;
            rbtnu.TabStop = true;
            rbtnu.Text = "Nữ";
            rbtnu.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(355, 20);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(108, 19);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Không xác định";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtnam
            // 
            rbtnam.AutoSize = true;
            rbtnam.Location = new Point(231, 20);
            rbtnam.Margin = new Padding(3, 2, 3, 2);
            rbtnam.Name = "rbtnam";
            rbtnam.Size = new Size(51, 19);
            rbtnam.TabIndex = 10;
            rbtnam.TabStop = true;
            rbtnam.Text = "Nam";
            rbtnam.UseVisualStyleBackColor = true;
            // 
            // dateNV
            // 
            dateNV.Location = new Point(106, 131);
            dateNV.Name = "dateNV";
            dateNV.Size = new Size(311, 23);
            dateNV.TabIndex = 24;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(106, 95);
            txtDC.Margin = new Padding(3, 2, 3, 2);
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(312, 23);
            txtDC.TabIndex = 23;
            // 
            // lable22
            // 
            lable22.AutoSize = true;
            lable22.Location = new Point(16, 97);
            lable22.Name = "lable22";
            lable22.Size = new Size(43, 15);
            lable22.TabIndex = 22;
            lable22.Text = "Địa chỉ";
            lable22.Click += label11_Click;
            // 
            // textRL
            // 
            textRL.Location = new Point(572, 58);
            textRL.Margin = new Padding(3, 2, 3, 2);
            textRL.Name = "textRL";
            textRL.Size = new Size(347, 23);
            textRL.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(463, 60);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 20;
            label12.Text = "Quyền";
            // 
            // rdb_NgungHD
            // 
            rdb_NgungHD.AutoSize = true;
            rdb_NgungHD.Location = new Point(297, 212);
            rdb_NgungHD.Margin = new Padding(3, 2, 3, 2);
            rdb_NgungHD.Name = "rdb_NgungHD";
            rdb_NgungHD.Size = new Size(120, 19);
            rdb_NgungHD.TabIndex = 18;
            rdb_NgungHD.TabStop = true;
            rdb_NgungHD.Text = "Ngừng hoạt động";
            rdb_NgungHD.UseVisualStyleBackColor = true;
            // 
            // rdb_HoatDong
            // 
            rdb_HoatDong.AutoSize = true;
            rdb_HoatDong.Location = new Point(105, 212);
            rdb_HoatDong.Margin = new Padding(3, 2, 3, 2);
            rdb_HoatDong.Name = "rdb_HoatDong";
            rdb_HoatDong.Size = new Size(82, 19);
            rdb_HoatDong.TabIndex = 17;
            rdb_HoatDong.TabStop = true;
            rdb_HoatDong.Text = "Hoạt động";
            rdb_HoatDong.UseVisualStyleBackColor = true;
            rdb_HoatDong.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 214);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 16;
            label10.Text = "Trạng Thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(463, 166);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 14;
            label9.Text = "Mật khẩu";
            // 
            // txt_IdNhanVien
            // 
            txt_IdNhanVien.Location = new Point(106, 25);
            txt_IdNhanVien.Margin = new Padding(3, 2, 3, 2);
            txt_IdNhanVien.Name = "txt_IdNhanVien";
            txt_IdNhanVien.ReadOnly = true;
            txt_IdNhanVien.Size = new Size(312, 23);
            txt_IdNhanVien.TabIndex = 13;
            txt_IdNhanVien.TextChanged += txtid_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 28);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 12;
            label4.Text = "ID";
            // 
            // txtMK
            // 
            txtMK.Location = new Point(572, 162);
            txtMK.Margin = new Padding(3, 2, 3, 2);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(347, 23);
            txtMK.TabIndex = 11;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(572, 127);
            txtTK.Margin = new Padding(3, 2, 3, 2);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(347, 23);
            txtTK.TabIndex = 11;
            // 
            // txtL
            // 
            txtL.Location = new Point(572, 92);
            txtL.Margin = new Padding(3, 2, 3, 2);
            txtL.Name = "txtL";
            txtL.Size = new Size(347, 23);
            txtL.TabIndex = 11;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(572, 25);
            txtsdt.Margin = new Padding(3, 2, 3, 2);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(347, 23);
            txtsdt.TabIndex = 11;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(106, 164);
            txtemail.Margin = new Padding(3, 2, 3, 2);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(311, 23);
            txtemail.TabIndex = 8;
            // 
            // txtten
            // 
            txtten.Location = new Point(106, 59);
            txtten.Margin = new Padding(3, 2, 3, 2);
            txtten.Name = "txtten";
            txtten.Size = new Size(311, 23);
            txtten.TabIndex = 8;
            txtten.TextChanged += txtten_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(463, 95);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 7;
            label8.Text = "Lương";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 131);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Tài Khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 168);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 63);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 131);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 31);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(bttRL);
            panel1.Controls.Add(bttCL);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(btnxoa);
            panel1.Controls.Add(btnthem);
            panel1.Controls.Add(btnsua);
            panel1.Location = new Point(-67, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1157, 654);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // bttRL
            // 
            bttRL.Location = new Point(1030, 379);
            bttRL.Margin = new Padding(3, 2, 3, 2);
            bttRL.Name = "bttRL";
            bttRL.Size = new Size(47, 22);
            bttRL.TabIndex = 19;
            bttRL.Text = "RL";
            bttRL.UseVisualStyleBackColor = true;
            bttRL.Click += bttRL_Click;
            // 
            // bttCL
            // 
            bttCL.Location = new Point(918, 333);
            bttCL.Margin = new Padding(3, 2, 3, 2);
            bttCL.Name = "bttCL";
            bttCL.Size = new Size(82, 22);
            bttCL.TabIndex = 18;
            bttCL.Text = "clear";
            bttCL.UseVisualStyleBackColor = true;
            bttCL.Click += bttCL_Click;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 609);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanLyNhanVien";
            Text = "QuanLyNhanVien";
            Load += QuanLyNhanVien_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btntimkiem;
        private TextBox txttimkiem;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private GroupBox groupBox2;
        private DataGridView dgvnhanvien;
        private GroupBox groupBox1;
        private TextBox txt_IdNhanVien;
        private Label label4;
        private TextBox txtsdt;
        private RadioButton rbtnam;
        private RadioButton rbtnu;
        private TextBox txtemail;
        private TextBox txtten;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label9;
        private RadioButton rdb_NgungHD;
        private RadioButton rdb_HoatDong;
        private Label label10;
        private Panel panel1;
        private RadioButton radioButton1;
        private TextBox txtMK;
        private TextBox txtTK;
        private TextBox txtL;
        private TextBox txtDC;
        private Label lable22;
        private TextBox textRL;
        private Label label12;
        private DateTimePicker dateNV;
        private Panel panel2;
        private Button bttCL;
        private Button bttRL;
    }
}