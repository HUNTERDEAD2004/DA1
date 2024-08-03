namespace PRL.View
{
    partial class QuenMK
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
            panel1 = new Panel();
            button3 = new Button();
            bttBack = new Button();
            txtNhapLai = new TextBox();
            txtPassMoi = new TextBox();
            btnXacNhan = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtIDSua = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(bttBack);
            panel1.Controls.Add(txtNhapLai);
            panel1.Controls.Add(txtPassMoi);
            panel1.Controls.Add(btnXacNhan);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtIDSua);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-27, -8);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 352);
            panel1.TabIndex = 58;
            // 
            // button3
            // 
            button3.Location = new Point(509, 77);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(77, 22);
            button3.TabIndex = 58;
            button3.Text = "Gửi mã";
            button3.UseVisualStyleBackColor = true;
            // 
            // bttBack
            // 
            bttBack.Location = new Point(329, 253);
            bttBack.Margin = new Padding(3, 2, 3, 2);
            bttBack.Name = "bttBack";
            bttBack.Size = new Size(82, 22);
            bttBack.TabIndex = 57;
            bttBack.Text = "Back";
            bttBack.UseVisualStyleBackColor = true;
            bttBack.Click += bttBack_Click;
            // 
            // txtNhapLai
            // 
            txtNhapLai.Location = new Point(221, 193);
            txtNhapLai.Margin = new Padding(3, 2, 3, 2);
            txtNhapLai.Name = "txtNhapLai";
            txtNhapLai.Size = new Size(283, 23);
            txtNhapLai.TabIndex = 55;
            // 
            // txtPassMoi
            // 
            txtPassMoi.Location = new Point(221, 133);
            txtPassMoi.Margin = new Padding(3, 2, 3, 2);
            txtPassMoi.Name = "txtPassMoi";
            txtPassMoi.Size = new Size(283, 23);
            txtPassMoi.TabIndex = 55;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Red;
            btnXacNhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(292, 218);
            btnXacNhan.Margin = new Padding(3, 2, 3, 2);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(150, 31);
            btnXacNhan.TabIndex = 56;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(264, 10);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 51;
            label1.Text = "Quên Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 53);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 52;
            label2.Text = "Nhập mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 169);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 53;
            label4.Text = "Nhập lại mật khẩu mới";
            // 
            // txtIDSua
            // 
            txtIDSua.Location = new Point(221, 77);
            txtIDSua.Margin = new Padding(3, 2, 3, 2);
            txtIDSua.Name = "txtIDSua";
            txtIDSua.Size = new Size(283, 23);
            txtIDSua.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 109);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 53;
            label3.Text = "Nhập mật khẩu mới";
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 392);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuenMK";
            Text = "QuenMK";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button bttBack;
        private TextBox txtNhapLai;
        private TextBox txtPassMoi;
        private Button btnXacNhan;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtIDSua;
        private Label label3;
    }
}