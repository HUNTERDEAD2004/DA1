namespace PRL.View
{
    partial class Products
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnMac = new FontAwesome.Sharp.IconButton();
            btnAirpod = new FontAwesome.Sharp.IconButton();
            btnImac = new FontAwesome.Sharp.IconButton();
            btnIpad = new FontAwesome.Sharp.IconButton();
            btnIphone = new FontAwesome.Sharp.IconButton();
            btnWatch = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 533);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(889, 268);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMac);
            groupBox1.Controls.Add(btnAirpod);
            groupBox1.Controls.Add(btnImac);
            groupBox1.Controls.Add(btnIpad);
            groupBox1.Controls.Add(btnIphone);
            groupBox1.Controls.Add(btnWatch);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(37, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(889, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
            // 
            // btnMac
            // 
            btnMac.ForeColor = SystemColors.ActiveCaptionText;
            btnMac.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            btnMac.IconColor = Color.Black;
            btnMac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMac.IconSize = 16;
            btnMac.Location = new Point(617, 39);
            btnMac.Name = "btnMac";
            btnMac.Size = new Size(96, 38);
            btnMac.TabIndex = 6;
            btnMac.Text = "Macbook";
            btnMac.TextAlign = ContentAlignment.MiddleRight;
            btnMac.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMac.UseVisualStyleBackColor = true;
            btnMac.Click += btnMac_Click;
            // 
            // btnAirpod
            // 
            btnAirpod.ForeColor = SystemColors.ActiveCaptionText;
            btnAirpod.IconChar = FontAwesome.Sharp.IconChar.Headphones;
            btnAirpod.IconColor = Color.Black;
            btnAirpod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAirpod.IconSize = 16;
            btnAirpod.Location = new Point(759, 40);
            btnAirpod.Name = "btnAirpod";
            btnAirpod.Size = new Size(96, 38);
            btnAirpod.TabIndex = 5;
            btnAirpod.Text = "Airpods";
            btnAirpod.TextAlign = ContentAlignment.MiddleRight;
            btnAirpod.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAirpod.UseVisualStyleBackColor = true;
            btnAirpod.Click += btnAirpod_Click;
            // 
            // btnImac
            // 
            btnImac.ForeColor = SystemColors.ActiveCaptionText;
            btnImac.IconChar = FontAwesome.Sharp.IconChar.DesktopAlt;
            btnImac.IconColor = Color.Black;
            btnImac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImac.IconSize = 16;
            btnImac.Location = new Point(476, 39);
            btnImac.Name = "btnImac";
            btnImac.Size = new Size(96, 38);
            btnImac.TabIndex = 4;
            btnImac.Text = "IMAC";
            btnImac.TextAlign = ContentAlignment.MiddleRight;
            btnImac.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImac.UseVisualStyleBackColor = true;
            btnImac.Click += btnImac_Click;
            // 
            // btnIpad
            // 
            btnIpad.ForeColor = SystemColors.ActiveCaptionText;
            btnIpad.IconChar = FontAwesome.Sharp.IconChar.TabletScreenButton;
            btnIpad.IconColor = Color.Black;
            btnIpad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIpad.IconSize = 16;
            btnIpad.Location = new Point(335, 39);
            btnIpad.Name = "btnIpad";
            btnIpad.Size = new Size(96, 38);
            btnIpad.TabIndex = 3;
            btnIpad.Text = "Ipad";
            btnIpad.TextAlign = ContentAlignment.MiddleRight;
            btnIpad.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIpad.UseVisualStyleBackColor = true;
            btnIpad.Click += btnIpad_Click;
            // 
            // btnIphone
            // 
            btnIphone.ForeColor = SystemColors.ActiveCaptionText;
            btnIphone.IconChar = FontAwesome.Sharp.IconChar.MobileScreenButton;
            btnIphone.IconColor = Color.Black;
            btnIphone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIphone.IconSize = 16;
            btnIphone.Location = new Point(194, 40);
            btnIphone.Name = "btnIphone";
            btnIphone.Size = new Size(96, 38);
            btnIphone.TabIndex = 2;
            btnIphone.Text = "Iphone";
            btnIphone.TextAlign = ContentAlignment.MiddleRight;
            btnIphone.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIphone.UseVisualStyleBackColor = true;
            btnIphone.Click += btnIphone_Click;
            // 
            // btnWatch
            // 
            btnWatch.ForeColor = SystemColors.ActiveCaptionText;
            btnWatch.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            btnWatch.IconColor = Color.Black;
            btnWatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWatch.IconSize = 16;
            btnWatch.Location = new Point(43, 40);
            btnWatch.Name = "btnWatch";
            btnWatch.Size = new Size(106, 38);
            btnWatch.TabIndex = 1;
            btnWatch.Text = "Apple Watch";
            btnWatch.TextAlign = ContentAlignment.MiddleRight;
            btnWatch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWatch.UseVisualStyleBackColor = true;
            btnWatch.Click += btnWatch_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 496);
            Controls.Add(panel1);
            Name = "Products";
            Text = "Products";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnAirpod;
        private FontAwesome.Sharp.IconButton btnImac;
        private FontAwesome.Sharp.IconButton btnIpad;
        private FontAwesome.Sharp.IconButton btnIphone;
        private FontAwesome.Sharp.IconButton btnWatch;
        private FontAwesome.Sharp.IconButton btnMac;
    }
}