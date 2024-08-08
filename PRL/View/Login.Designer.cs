namespace PRL.View
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            button1 = new Button();
            ForgotPassword = new Button();
            button2 = new Button();
            CBHT = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 394);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.apple;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 394);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(431, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(508, 118);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username...";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(508, 162);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password...";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 20;
            iconPictureBox1.Location = new Point(472, 118);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(23, 20);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.Control;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 20;
            iconPictureBox2.Location = new Point(472, 162);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(23, 20);
            iconPictureBox2.TabIndex = 5;
            iconPictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(508, 204);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(180, 32);
            button1.TabIndex = 6;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ForgotPassword
            // 
            ForgotPassword.BackColor = Color.Transparent;
            ForgotPassword.FlatAppearance.BorderSize = 0;
            ForgotPassword.FlatStyle = FlatStyle.Flat;
            ForgotPassword.ForeColor = Color.Red;
            ForgotPassword.Location = new Point(580, 271);
            ForgotPassword.Margin = new Padding(3, 2, 3, 2);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(121, 22);
            ForgotPassword.TabIndex = 7;
            ForgotPassword.Text = "Forgot Password?";
            ForgotPassword.UseVisualStyleBackColor = false;
            ForgotPassword.Click += ForgotPassword_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(255, 128, 0);
            button2.Location = new Point(508, 240);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(180, 27);
            button2.TabIndex = 8;
            button2.Text = "Đăng ký";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CBHT
            // 
            CBHT.AutoSize = true;
            CBHT.Location = new Point(697, 168);
            CBHT.Name = "CBHT";
            CBHT.Size = new Size(15, 14);
            CBHT.TabIndex = 9;
            CBHT.UseVisualStyleBackColor = true;
            CBHT.CheckedChanged += CBHT_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 400);
            Controls.Add(CBHT);
            Controls.Add(button2);
            Controls.Add(ForgotPassword);
            Controls.Add(button1);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Button button1;
        private Button ForgotPassword;
        private Button button2;
        private CheckBox CBHT;
    }
}