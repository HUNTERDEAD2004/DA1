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
            textBox1 = new TextBox();
            label9 = new Label();
            rdb_NgungHD = new RadioButton();
            rdb_HoatDong = new RadioButton();
            label10 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(101, 278);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 19;
            btntimkiem.Text = "Tìm Kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(201, 279);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(163, 27);
            txttimkiem.TabIndex = 18;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(743, 275);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 17;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(643, 275);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 16;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(543, 275);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 15;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvnhanvien);
            groupBox2.Location = new Point(30, 306);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(815, 213);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.AllowUserToAddRows = false;
            dgvnhanvien.AllowUserToDeleteRows = false;
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.Location = new Point(19, 67);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.ReadOnly = true;
            dgvnhanvien.RowHeadersWidth = 51;
            dgvnhanvien.RowTemplate.Height = 29;
            dgvnhanvien.Size = new Size(785, 140);
            dgvnhanvien.TabIndex = 0;
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(819, 260);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý nhân viên";
            // 
            // txt_IdNhanVien
            // 
            txt_IdNhanVien.Location = new Point(120, 35);
            txt_IdNhanVien.Name = "txt_IdNhanVien";
            txt_IdNhanVien.Size = new Size(251, 27);
            txt_IdNhanVien.TabIndex = 13;
            txt_IdNhanVien.TextChanged += txtid_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 38);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 12;
            label4.Text = "ID";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(589, 127);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.PasswordChar = '*';
            txtTaiKhoan.Size = new Size(205, 27);
            txtTaiKhoan.TabIndex = 11;
            // 
            // txtuong
            // 
            txtuong.Location = new Point(589, 79);
            txtuong.Name = "txtuong";
            txtuong.Size = new Size(205, 27);
            txtuong.TabIndex = 11;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(589, 35);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(205, 27);
            txtsdt.TabIndex = 11;
            // 
            // rbtnam
            // 
            rbtnam.AutoSize = true;
            rbtnam.Location = new Point(680, 210);
            rbtnam.Name = "rbtnam";
            rbtnam.Size = new Size(62, 24);
            rbtnam.TabIndex = 10;
            rbtnam.TabStop = true;
            rbtnam.Text = "Nam";
            rbtnam.UseVisualStyleBackColor = true;
            // 
            // rbtnu
            // 
            rbtnu.AutoSize = true;
            rbtnu.Location = new Point(591, 210);
            rbtnu.Name = "rbtnu";
            rbtnu.Size = new Size(50, 24);
            rbtnu.TabIndex = 10;
            rbtnu.TabStop = true;
            rbtnu.Text = "Nữ";
            rbtnu.UseVisualStyleBackColor = true;
            // 
            // txtngaysinh
            // 
            txtngaysinh.CustomFormat = "";
            txtngaysinh.Format = DateTimePickerFormat.Short;
            txtngaysinh.Location = new Point(121, 119);
            txtngaysinh.Name = "txtngaysinh";
            txtngaysinh.Size = new Size(250, 27);
            txtngaysinh.TabIndex = 9;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(121, 169);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(250, 27);
            txtemail.TabIndex = 8;
            // 
            // txtten
            // 
            txtten.Location = new Point(121, 77);
            txtten.Name = "txtten";
            txtten.Size = new Size(250, 27);
            txtten.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(464, 84);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 7;
            label8.Text = "Lương";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(466, 210);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 6;
            label7.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 134);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Tài Khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 172);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 84);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 124);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 42);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(589, 165);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(464, 172);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 14;
            label9.Text = "Mật khẩu";
            // 
            // rdb_NgungHD
            // 
            rdb_NgungHD.AutoSize = true;
            rdb_NgungHD.Location = new Point(231, 210);
            rdb_NgungHD.Name = "rdb_NgungHD";
            rdb_NgungHD.Size = new Size(149, 24);
            rdb_NgungHD.TabIndex = 18;
            rdb_NgungHD.TabStop = true;
            rdb_NgungHD.Text = "Ngừng hoạt động";
            rdb_NgungHD.UseVisualStyleBackColor = true;
            // 
            // rdb_HoatDong
            // 
            rdb_HoatDong.AutoSize = true;
            rdb_HoatDong.Location = new Point(120, 208);
            rdb_HoatDong.Name = "rdb_HoatDong";
            rdb_HoatDong.Size = new Size(102, 24);
            rdb_HoatDong.TabIndex = 17;
            rdb_HoatDong.TabStop = true;
            rdb_HoatDong.Text = "Hoạt động";
            rdb_HoatDong.UseVisualStyleBackColor = true;
            rdb_HoatDong.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 210);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 16;
            label10.Text = "Trạng Thái";
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 546);
            Controls.Add(btntimkiem);
            Controls.Add(txttimkiem);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
    }
}