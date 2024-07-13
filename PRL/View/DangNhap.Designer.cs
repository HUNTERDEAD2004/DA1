namespace PRL.View
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            label1 = new Label();
            label2 = new Label();
            txt_User = new TextBox();
            txt_Password = new TextBox();
            label3 = new Label();
            btn_DangNhap = new Button();
            btn_QuenMatKhau = new Button();
            btn_DangKy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 139);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(107, 207);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // txt_User
            // 
            txt_User.Location = new Point(277, 139);
            txt_User.Margin = new Padding(3, 4, 3, 4);
            txt_User.Multiline = true;
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(356, 32);
            txt_User.TabIndex = 2;
            txt_User.TextChanged += txt_User_TextChanged;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(277, 207);
            txt_Password.Margin = new Padding(3, 4, 3, 4);
            txt_Password.Multiline = true;
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(356, 32);
            txt_Password.TabIndex = 3;
            txt_Password.TextChanged += txt_Password_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(425, 51);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 4;
            label3.Text = "LOGIN";
            label3.Click += label3_Click;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(368, 285);
            btn_DangNhap.Margin = new Padding(3, 4, 3, 4);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(182, 31);
            btn_DangNhap.TabIndex = 5;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // btn_QuenMatKhau
            // 
            btn_QuenMatKhau.Location = new Point(459, 342);
            btn_QuenMatKhau.Margin = new Padding(3, 4, 3, 4);
            btn_QuenMatKhau.Name = "btn_QuenMatKhau";
            btn_QuenMatKhau.Size = new Size(174, 31);
            btn_QuenMatKhau.TabIndex = 6;
            btn_QuenMatKhau.Text = "Quên Mật Khẩu";
            btn_QuenMatKhau.UseVisualStyleBackColor = true;
            btn_QuenMatKhau.Click += btn_QuenMatKhau_Click;
            // 
            // btn_DangKy
            // 
            btn_DangKy.Location = new Point(277, 342);
            btn_DangKy.Margin = new Padding(3, 4, 3, 4);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(176, 31);
            btn_DangKy.TabIndex = 7;
            btn_DangKy.Text = "Đăng Ký ";
            btn_DangKy.UseVisualStyleBackColor = true;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 477);
            Controls.Add(btn_DangKy);
            Controls.Add(btn_QuenMatKhau);
            Controls.Add(btn_DangNhap);
            Controls.Add(label3);
            Controls.Add(txt_Password);
            Controls.Add(txt_User);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_User;
        private TextBox txt_Password;
        private Label label3;
        private Button btn_DangNhap;
        private Button btn_QuenMatKhau;
        private Button btn_DangKy;
    }
}