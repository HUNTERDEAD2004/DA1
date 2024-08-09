namespace PRL.View
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
            Menu = new Panel();
            btnSales = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            btnCustomer = new FontAwesome.Sharp.IconButton();
            btnOrder = new FontAwesome.Sharp.IconButton();
            btnAccount = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            label2 = new Label();
            title = new Label();
            currentIcon = new FontAwesome.Sharp.IconPictureBox();
            panelChange = new Panel();
            Menu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentIcon).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(49, 42, 81);
            Menu.Controls.Add(btnSales);
            Menu.Controls.Add(btnDashboard);
            Menu.Controls.Add(btnCustomer);
            Menu.Controls.Add(btnOrder);
            Menu.Controls.Add(btnAccount);
            Menu.Controls.Add(btnProduct);
            Menu.Controls.Add(flowLayoutPanel1);
            Menu.Dock = DockStyle.Left;
            Menu.ForeColor = SystemColors.ControlDarkDark;
            Menu.Location = new Point(0, 0);
            Menu.Margin = new Padding(3, 2, 3, 2);
            Menu.Name = "Menu";
            Menu.Size = new Size(192, 815);
            Menu.TabIndex = 0;
            // 
            // btnSales
            // 
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSales.ForeColor = Color.FromArgb(122, 119, 170);
            btnSales.IconChar = FontAwesome.Sharp.IconChar.Tools;
            btnSales.IconColor = Color.FromArgb(122, 119, 170);
            btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSales.IconSize = 28;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 310);
            btnSales.Margin = new Padding(3, 2, 3, 2);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(192, 45);
            btnSales.TabIndex = 7;
            btnSales.Text = "   Sales";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSetting_Click;
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
            btnDashboard.Location = new Point(0, 265);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(192, 45);
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
            btnCustomer.Location = new Point(0, 220);
            btnCustomer.Margin = new Padding(3, 2, 3, 2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(192, 45);
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
            btnOrder.Location = new Point(0, 175);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(192, 45);
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
            btnAccount.Location = new Point(0, 130);
            btnAccount.Margin = new Padding(3, 2, 3, 2);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(192, 45);
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
            btnProduct.Location = new Point(0, 85);
            btnProduct.Margin = new Padding(3, 2, 3, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(192, 45);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "   Products";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(192, 85);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(46, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 1;
            label1.Text = "Apple Store";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 42, 81);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(title);
            panel2.Controls.Add(currentIcon);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(192, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1336, 66);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1206, 23);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(82, 22);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1079, 26);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 3;
            label2.Text = "Xin chào, Username";
            label2.Click += label2_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.Gainsboro;
            title.Location = new Point(32, 28);
            title.Name = "title";
            title.Size = new Size(52, 13);
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
            currentIcon.IconSize = 13;
            currentIcon.Location = new Point(18, 30);
            currentIcon.Margin = new Padding(3, 2, 3, 2);
            currentIcon.Name = "currentIcon";
            currentIcon.Size = new Size(19, 13);
            currentIcon.TabIndex = 1;
            currentIcon.TabStop = false;
            // 
            // panelChange
            // 
            panelChange.BackColor = Color.SlateBlue;
            panelChange.Dock = DockStyle.Fill;
            panelChange.Location = new Point(192, 66);
            panelChange.Margin = new Padding(3, 2, 3, 2);
            panelChange.Name = "panelChange";
            panelChange.Size = new Size(1336, 749);
            panelChange.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 815);
            Controls.Add(panelChange);
            Controls.Add(panel2);
            Controls.Add(Menu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            Menu.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Menu;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnAccount;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox currentIcon;
        private Label title;
        private Panel panelChange;
        private Button btnLogout;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}