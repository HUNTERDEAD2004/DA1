namespace PRL.View
{
    partial class DangKy
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
            btn_DangKy = new Button();
            btn_QuenMatKhau = new Button();
            btn_DangNhap = new Button();
            label3 = new Label();
            txt_Password = new TextBox();
            txt_User = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtsdt = new TextBox();
            txtTen = new TextBox();
            txtName = new Label();
            comboBox1 = new ComboBox();
            namsinh = new TextBox();
            SuspendLayout();
            // 
            // btn_DangKy
            // 
            btn_DangKy.Location = new Point(363, 352);
            btn_DangKy.Margin = new Padding(3, 4, 3, 4);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(176, 31);
            btn_DangKy.TabIndex = 15;
            btn_DangKy.Text = "Đăng Ký ";
            btn_DangKy.UseVisualStyleBackColor = true;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // btn_QuenMatKhau
            // 
            btn_QuenMatKhau.Location = new Point(448, 408);
            btn_QuenMatKhau.Margin = new Padding(3, 4, 3, 4);
            btn_QuenMatKhau.Name = "btn_QuenMatKhau";
            btn_QuenMatKhau.Size = new Size(128, 31);
            btn_QuenMatKhau.TabIndex = 14;
            btn_QuenMatKhau.Text = "Quên Mật Khẩu";
            btn_QuenMatKhau.UseVisualStyleBackColor = true;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(314, 408);
            btn_DangNhap.Margin = new Padding(3, 4, 3, 4);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(128, 31);
            btn_DangNhap.TabIndex = 13;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(403, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 32);
            label3.TabIndex = 12;
            label3.Text = "Sign Up";
            label3.Click += label3_Click;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(286, 277);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Multiline = true;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(338, 22);
            txt_Password.TabIndex = 11;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(286, 55);
            txt_User.Margin = new Padding(3, 4, 3, 4);
            txt_User.Multiline = true;
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(338, 22);
            txt_User.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(158, 270);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 54);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 8;
            label1.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(158, 115);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 16;
            label4.Text = "Năm Sinh";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(158, 146);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 17;
            label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(158, 177);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 18;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(158, 208);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 19;
            label7.Text = "Số Điện Thoại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(158, 239);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 20;
            label8.Text = "Giới Tính";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(286, 149);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(338, 22);
            txtDiaChi.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(286, 181);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 22);
            txtEmail.TabIndex = 23;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(286, 213);
            txtsdt.Margin = new Padding(3, 4, 3, 4);
            txtsdt.Multiline = true;
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(338, 22);
            txtsdt.TabIndex = 24;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(286, 87);
            txtTen.Margin = new Padding(3, 4, 3, 4);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(338, 22);
            txtTen.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(158, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(57, 23);
            txtName.TabIndex = 26;
            txtName.Text = "Name";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(286, 238);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 29;
            // 
            // namsinh
            // 
            namsinh.Location = new Point(286, 117);
            namsinh.Margin = new Padding(3, 4, 3, 4);
            namsinh.Multiline = true;
            namsinh.Name = "namsinh";
            namsinh.Size = new Size(338, 22);
            namsinh.TabIndex = 30;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 515);
            Controls.Add(namsinh);
            Controls.Add(comboBox1);
            Controls.Add(txtTen);
            Controls.Add(txtName);
            Controls.Add(txtsdt);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_DangKy);
            Controls.Add(btn_QuenMatKhau);
            Controls.Add(btn_DangNhap);
            Controls.Add(label3);
            Controls.Add(txt_Password);
            Controls.Add(txt_User);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangKy";
            Text = "DangKy";
            Load += DangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DangKy;
        private Button btn_QuenMatKhau;
        private Button btn_DangNhap;
        private Label label3;
        private TextBox txt_Password;
        private TextBox txt_User;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtsdt;
        private TextBox txtTen;
        private Label txtName;
        private ComboBox comboBox1;
        private TextBox namsinh;
    }
}