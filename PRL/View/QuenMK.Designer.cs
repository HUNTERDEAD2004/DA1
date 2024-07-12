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
            button2 = new Button();
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
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtNhapLai);
            panel1.Controls.Add(txtPassMoi);
            panel1.Controls.Add(btnXacNhan);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtIDSua);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-31, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 470);
            panel1.TabIndex = 58;
            // 
            // button3
            // 
            button3.Location = new Point(582, 103);
            button3.Name = "button3";
            button3.Size = new Size(88, 29);
            button3.TabIndex = 58;
            button3.Text = "Gửi mã";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(376, 337);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 57;
            button2.UseVisualStyleBackColor = true;
            // 
            // txtNhapLai
            // 
            txtNhapLai.Location = new Point(253, 257);
            txtNhapLai.Name = "txtNhapLai";
            txtNhapLai.Size = new Size(323, 27);
            txtNhapLai.TabIndex = 55;
            // 
            // txtPassMoi
            // 
            txtPassMoi.Location = new Point(253, 177);
            txtPassMoi.Name = "txtPassMoi";
            txtPassMoi.Size = new Size(323, 27);
            txtPassMoi.TabIndex = 55;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Red;
            btnXacNhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(334, 290);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(172, 41);
            btnXacNhan.TabIndex = 56;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(302, 14);
            label1.Name = "label1";
            label1.Size = new Size(269, 46);
            label1.TabIndex = 51;
            label1.Text = "Quên Mật Khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 71);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 52;
            label2.Text = "Nhập mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 225);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 53;
            label4.Text = "Nhập lại mật khẩu mới";
            // 
            // txtIDSua
            // 
            txtIDSua.Location = new Point(253, 103);
            txtIDSua.Name = "txtIDSua";
            txtIDSua.Size = new Size(323, 27);
            txtIDSua.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 145);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 53;
            label3.Text = "Nhập mật khẩu mới";
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 523);
            Controls.Add(panel1);
            Name = "QuenMK";
            Text = "QuenMK";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
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