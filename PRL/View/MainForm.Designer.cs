﻿namespace PRL.View
{
    partial class MainForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Menu = new Panel();
            btnSetting = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            btnOrder = new FontAwesome.Sharp.IconButton();
            btnAccount = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnLogout = new Button();
            label2 = new Label();
            title = new Label();
            currentIcon = new FontAwesome.Sharp.IconPictureBox();
            panelChange = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Menu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentIcon).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 113);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pb4qlde0s1k5m5lob61756r9mc_b4021e2504cdf91403ebd897c40b8925;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(49, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 35);
            label1.TabIndex = 1;
            label1.Text = "Apple Store";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(49, 42, 81);
            Menu.Controls.Add(btnSetting);
            Menu.Controls.Add(btnDashboard);
            Menu.Controls.Add(btnCustomer);
            Menu.Controls.Add(btnOrder);
            Menu.Controls.Add(btnAccount);
            Menu.Controls.Add(btnProduct);
            Menu.Controls.Add(flowLayoutPanel1);
            Menu.Dock = DockStyle.Left;
            Menu.ForeColor = SystemColors.ControlDarkDark;
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(220, 779);
            Menu.TabIndex = 0;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.ForeColor = Color.FromArgb(122, 119, 170);
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnSetting.IconColor = Color.FromArgb(122, 119, 170);
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.IconSize = 28;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 413);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(220, 60);
            btnSetting.TabIndex = 7;
            btnSetting.Text = "   Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.FromArgb(122, 119, 170);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnDashboard.IconColor = Color.FromArgb(122, 119, 170);
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 28;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 353);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Dock = DockStyle.Top;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.ForeColor = Color.FromArgb(122, 119, 170);
            btnCustomer.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            btnCustomer.IconColor = Color.FromArgb(122, 119, 170);
            btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomer.IconSize = 28;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 293);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(220, 60);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "   Customers";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.FromArgb(122, 119, 170);
            btnOrder.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnOrder.IconColor = Color.FromArgb(122, 119, 170);
            btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOrder.IconSize = 28;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(0, 233);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(220, 60);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "   Orders";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnAccount
            // 
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.FromArgb(122, 119, 170);
            btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnAccount.IconColor = Color.FromArgb(122, 119, 170);
            btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAccount.IconSize = 28;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 173);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(220, 60);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "   Accounts";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.FromArgb(122, 119, 170);
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnProduct.IconColor = Color.FromArgb(122, 119, 170);
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.IconSize = 28;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 113);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(220, 60);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "   Products";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 42, 81);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(title);
            panel2.Controls.Add(currentIcon);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(220, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1104, 88);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(998, 31);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(853, 35);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 3;
            label2.Text = "Xin chào, Username";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.Gainsboro;
            title.Location = new Point(37, 38);
            title.Name = "title";
            title.Size = new Size(59, 17);
            title.TabIndex = 2;
            title.Text = "Products";
            // 
            // currentIcon
            // 
            currentIcon.BackColor = Color.FromArgb(49, 42, 81);
            currentIcon.ForeColor = Color.MediumPurple;
            currentIcon.IconChar = FontAwesome.Sharp.IconChar.Tags;
            currentIcon.IconColor = Color.MediumPurple;
            currentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            currentIcon.IconSize = 17;
            currentIcon.Location = new Point(20, 40);
            currentIcon.Name = "currentIcon";
            currentIcon.Size = new Size(22, 17);
            currentIcon.TabIndex = 1;
            currentIcon.TabStop = false;
            // 
            // panelChange
            // 
            panelChange.BackColor = Color.SlateBlue;
            panelChange.Dock = DockStyle.Fill;
            panelChange.Location = new Point(220, 88);
            panelChange.Name = "panelChange";
            panelChange.Size = new Size(1104, 691);
            panelChange.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 779);
            Controls.Add(panelChange);
            Controls.Add(panel2);
            Controls.Add(Menu);
            Name = "MainForm";
            Text = "MainForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Menu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel Menu;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnAccount;
        private Label label1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox currentIcon;
        private Label title;
        private Panel panelChange;
        private Button btnLogout;
        private Label label2;
    }
}