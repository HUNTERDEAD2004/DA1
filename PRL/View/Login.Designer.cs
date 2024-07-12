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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pass = new TextBox();
            username = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-17, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 642);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pass
            // 
            pass.BackColor = Color.CornflowerBlue;
            pass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pass.ForeColor = SystemColors.HighlightText;
            pass.Location = new Point(170, 355);
            pass.Name = "pass";
            pass.PlaceholderText = "Password";
            pass.RightToLeft = RightToLeft.No;
            pass.Size = new Size(279, 39);
            pass.TabIndex = 3;
            pass.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.AccessibleDescription = "";
            username.BackColor = Color.CornflowerBlue;
            username.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = SystemColors.HighlightText;
            username.Location = new Point(170, 235);
            username.Name = "username";
            username.PlaceholderText = "User";
            username.Size = new Size(279, 39);
            username.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(61, 334);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(61, 214);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 60);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 74);
            label1.Name = "label1";
            label1.Size = new Size(145, 64);
            label1.TabIndex = 9;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe Script", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(170, 520);
            button2.Name = "button2";
            button2.Size = new Size(143, 46);
            button2.TabIndex = 12;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.CornflowerBlue;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(61, 460);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 25);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password";
            // 
            // linkLabel2
            // 
            linkLabel2.BackColor = Color.CornflowerBlue;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(382, 460);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(67, 25);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Register";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.CornflowerBlue;
            checkBox1.CausesValidation = false;
            checkBox1.ForeColor = Color.LightCyan;
            checkBox1.Location = new Point(170, 416);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(171, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Remember password";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(490, 617);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(username);
            Controls.Add(pass);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox pass;
        private TextBox username;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Button button2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private CheckBox checkBox1;
    }
}