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
            rdb_NgungHD = new RadioButton();
            rdb_HoatDong = new RadioButton();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            txt_IdNhanVien = new TextBox();
            label4 = new Label();
            txtTaiKhoan = new TextBox();
            txtuong = new TextBox();
            txtsdt = new TextBox();
            rbtnam = new RadioButton();
            rbtnu = new RadioButton();
            txtngaysinh = new DateTimePicker();
            txtemail = new TextBox();
            txtten = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(88, 208);
            btntimkiem.Margin = new Padding(3, 2, 3, 2);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(82, 22);
            btntimkiem.TabIndex = 19;
            btntimkiem.Text = "Tìm Kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(176, 209);
            txttimkiem.Margin = new Padding(3, 2, 3, 2);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(143, 23);
            txttimkiem.TabIndex = 18;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(650, 206);
            btnxoa.Margin = new Padding(3, 2, 3, 2);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(82, 22);
            btnxoa.TabIndex = 17;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(563, 206);
            btnsua.Margin = new Padding(3, 2, 3, 2);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(82, 22);
            btnsua.TabIndex = 16;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(475, 206);
            btnthem.Margin = new Padding(3, 2, 3, 2);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(82, 22);
            btnthem.TabIndex = 15;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateBlue;
            groupBox2.Controls.Add(dgvnhanvien);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(26, 230);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(713, 160);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.AllowUserToAddRows = false;
            dgvnhanvien.AllowUserToDeleteRows = false;
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.Location = new Point(17, 50);
            dgvnhanvien.Margin = new Padding(3, 2, 3, 2);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.ReadOnly = true;
            dgvnhanvien.RowHeadersWidth = 51;
            dgvnhanvien.RowTemplate.Height = 29;
            dgvnhanvien.Size = new Size(687, 105);
            dgvnhanvien.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(rdb_NgungHD);
            groupBox1.Controls.Add(rdb_HoatDong);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_IdNhanVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTaiKhoan);
            groupBox1.Controls.Add(txtuong);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(rbtnam);
            groupBox1.Controls.Add(rbtnu);
            groupBox1.Controls.Add(txtngaysinh);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(18, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(717, 195);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý nhân viên";
            // 
            // rdb_NgungHD
            // 
            rdb_NgungHD.AutoSize = true;
            rdb_NgungHD.Location = new Point(202, 158);
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
            rdb_HoatDong.Location = new Point(105, 156);
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
            label10.Location = new Point(15, 158);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 16;
            label10.Text = "Trạng Thái";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(515, 124);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(406, 129);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 14;
            label9.Text = "Mật khẩu";
            // 
            // txt_IdNhanVien
            // 
            txt_IdNhanVien.Location = new Point(105, 26);
            txt_IdNhanVien.Margin = new Padding(3, 2, 3, 2);
            txt_IdNhanVien.Name = "txt_IdNhanVien";
            txt_IdNhanVien.Size = new Size(220, 23);
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
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(515, 95);
            txtTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.PasswordChar = '*';
            txtTaiKhoan.Size = new Size(180, 23);
            txtTaiKhoan.TabIndex = 11;
            // 
            // txtuong
            // 
            txtuong.Location = new Point(515, 59);
            txtuong.Margin = new Padding(3, 2, 3, 2);
            txtuong.Name = "txtuong";
            txtuong.Size = new Size(180, 23);
            txtuong.TabIndex = 11;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(515, 26);
            txtsdt.Margin = new Padding(3, 2, 3, 2);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(180, 23);
            txtsdt.TabIndex = 11;
            // 
            // rbtnam
            // 
            rbtnam.AutoSize = true;
            rbtnam.Location = new Point(595, 158);
            rbtnam.Margin = new Padding(3, 2, 3, 2);
            rbtnam.Name = "rbtnam";
            rbtnam.Size = new Size(51, 19);
            rbtnam.TabIndex = 10;
            rbtnam.TabStop = true;
            rbtnam.Text = "Nam";
            rbtnam.UseVisualStyleBackColor = true;
            // 
            // rbtnu
            // 
            rbtnu.AutoSize = true;
            rbtnu.Location = new Point(517, 158);
            rbtnu.Margin = new Padding(3, 2, 3, 2);
            rbtnu.Name = "rbtnu";
            rbtnu.Size = new Size(41, 19);
            rbtnu.TabIndex = 10;
            rbtnu.TabStop = true;
            rbtnu.Text = "Nữ";
            rbtnu.UseVisualStyleBackColor = true;
            // 
            // txtngaysinh
            // 
            txtngaysinh.CustomFormat = "";
            txtngaysinh.Format = DateTimePickerFormat.Short;
            txtngaysinh.Location = new Point(106, 89);
            txtngaysinh.Margin = new Padding(3, 2, 3, 2);
            txtngaysinh.Name = "txtngaysinh";
            txtngaysinh.Size = new Size(219, 23);
            txtngaysinh.TabIndex = 9;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(106, 127);
            txtemail.Margin = new Padding(3, 2, 3, 2);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(219, 23);
            txtemail.TabIndex = 8;
            // 
            // txtten
            // 
            txtten.Location = new Point(106, 58);
            txtten.Margin = new Padding(3, 2, 3, 2);
            txtten.Name = "txtten";
            txtten.Size = new Size(219, 23);
            txtten.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(406, 63);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 7;
            label8.Text = "Lương";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 158);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 6;
            label7.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(406, 100);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Tài Khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 129);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 63);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 93);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 32);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 479);
            panel1.TabIndex = 20;
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 410);
            Controls.Add(btntimkiem);
            Controls.Add(txttimkiem);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanLyNhanVien";
            Text = "QuanLyNhanVien";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtTaiKhoan;
        private TextBox txtuong;
        private TextBox txtsdt;
        private RadioButton rbtnam;
        private RadioButton rbtnu;
        private DateTimePicker txtngaysinh;
        private TextBox txtemail;
        private TextBox txtten;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label9;
        private RadioButton rdb_NgungHD;
        private RadioButton rdb_HoatDong;
        private Label label10;
        private Panel panel1;
    }
}