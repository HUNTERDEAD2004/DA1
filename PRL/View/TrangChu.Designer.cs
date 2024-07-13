namespace PRL.View
{
    partial class TrangChu
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
            button5 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(944, 23);
            button5.Name = "button5";
            button5.Size = new Size(113, 35);
            button5.TabIndex = 4;
            button5.Text = "Đăng xuất";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(260, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 508);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 508);
            panel1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(3, 234);
            button4.Name = "button4";
            button4.Size = new Size(224, 70);
            button4.TabIndex = 3;
            button4.Text = "Danh mục sản phẩm";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 158);
            button3.Name = "button3";
            button3.Size = new Size(224, 70);
            button3.TabIndex = 2;
            button3.Text = "Quản lý đơn hàng";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 6);
            button1.Name = "button1";
            button1.Size = new Size(224, 70);
            button1.TabIndex = 0;
            button1.Text = "Quản lý sản phẩm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 82);
            button2.Name = "button2";
            button2.Size = new Size(224, 70);
            button2.TabIndex = 1;
            button2.Text = "Quản lý nhân viên";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1, 345);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 160);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 646);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TrangChu";
            Text = "TrangChu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Panel panel2;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}