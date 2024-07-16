namespace RJCodeUI_M1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbSideMenuLogo = new System.Windows.Forms.PictureBox();
            this.biFormOptions = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.biNotifications = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.pbProfilePicture = new RJCodeUI_M1.RJControls.RJCircularPictureBox();
            this.lblUserName = new RJCodeUI_M1.RJControls.RJLabel();
            this.biUserOptions = new RJCodeUI_M1.RJControls.RJMenuIcon();
            this.dmUserOptions = new RJCodeUI_M1.RJControls.RJDropdownMenu(this.components);
            this.miMyProfile = new FontAwesome.Sharp.IconMenuItem();
            this.miSettings = new FontAwesome.Sharp.IconMenuItem();
            this.miTermsCond = new FontAwesome.Sharp.IconMenuItem();
            this.miHelp = new FontAwesome.Sharp.IconMenuItem();
            this.miLogout = new FontAwesome.Sharp.IconMenuItem();
            this.miExit = new FontAwesome.Sharp.IconMenuItem();
            this.btnDashboard = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.btnSales = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.dmSalesOrder = new RJCodeUI_M1.RJControls.RJDropdownMenu(this.components);
            this.salesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingDeliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hightPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProducts = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.btnCustomers = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.btnUserControls = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.dmCustomControls = new RJCodeUI_M1.RJControls.RJDropdownMenu(this.components);
            this.commonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rjLabel1 = new RJCodeUI_M1.RJControls.RJLabel();
            this.rjLabel2 = new RJCodeUI_M1.RJControls.RJLabel();
            this.dmCustomForms = new RJCodeUI_M1.RJControls.RJDropdownMenu(this.components);
            this.baseFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomForms = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.btnYoutube = new RJCodeUI_M1.RJControls.RJButton();
            this.btnGithub = new RJCodeUI_M1.RJControls.RJButton();
            this.btnCustomControls = new RJCodeUI_M1.RJControls.RJMenuButton();
            this.pnlSideMenu.SuspendLayout();
            this.pnlSideMenuHeader.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideMenuLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biFormOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biUserOptions)).BeginInit();
            this.dmUserOptions.SuspendLayout();
            this.dmSalesOrder.SuspendLayout();
            this.dmCustomControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.dmCustomForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.btnCustomers);
            this.pnlSideMenu.Controls.Add(this.btnProducts);
            this.pnlSideMenu.Controls.Add(this.btnSales);
            this.pnlSideMenu.Controls.Add(this.btnDashboard);
            this.pnlSideMenu.Controls.Add(this.btnCustomForms);
            this.pnlSideMenu.Controls.Add(this.btnUserControls);
            this.pnlSideMenu.Controls.Add(this.btnCustomControls);
            this.pnlSideMenu.Size = new System.Drawing.Size(220, 548);
            this.pnlSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSideMenu_Paint);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnCustomControls, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnUserControls, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnCustomForms, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnDashboard, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnSales, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnProducts, 0);
            this.pnlSideMenu.Controls.SetChildIndex(this.btnCustomers, 0);
            // 
            // pnlSideMenuHeader
            // 
            this.pnlSideMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.pnlSideMenuHeader.Controls.Add(this.pbSideMenuLogo);
            this.pnlSideMenuHeader.Controls.SetChildIndex(this.pbSideMenuLogo, 0);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.biUserOptions);
            this.pnlTitleBar.Controls.Add(this.lblUserName);
            this.pnlTitleBar.Controls.Add(this.pbProfilePicture);
            this.pnlTitleBar.Controls.Add(this.biNotifications);
            this.pnlTitleBar.Controls.Add(this.biFormOptions);
            this.pnlTitleBar.Location = new System.Drawing.Point(221, 1);
            this.pnlTitleBar.Size = new System.Drawing.Size(958, 60);
            this.pnlTitleBar.Controls.SetChildIndex(this.biFormOptions, 0);
            this.pnlTitleBar.Controls.SetChildIndex(this.biNotifications, 0);
            this.pnlTitleBar.Controls.SetChildIndex(this.pbProfilePicture, 0);
            this.pnlTitleBar.Controls.SetChildIndex(this.lblUserName, 0);
            this.pnlTitleBar.Controls.SetChildIndex(this.biUserOptions, 0);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.btnGithub);
            this.pnlDesktop.Controls.Add(this.btnYoutube);
            this.pnlDesktop.Controls.Add(this.rjLabel2);
            this.pnlDesktop.Controls.Add(this.rjLabel1);
            this.pnlDesktop.Controls.Add(this.pictureBox2);
            this.pnlDesktop.Location = new System.Drawing.Point(221, 86);
            this.pnlDesktop.Size = new System.Drawing.Size(958, 523);
            // 
            // pnlDesktopHeader
            // 
            this.pnlDesktopHeader.Location = new System.Drawing.Point(221, 61);
            this.pnlDesktopHeader.Size = new System.Drawing.Size(958, 25);
            // 
            // pbSideMenuLogo
            // 
            this.pbSideMenuLogo.Image = global::RJCodeUI_M1.Properties.Resources.RJTitleBarLogo;
            this.pbSideMenuLogo.Location = new System.Drawing.Point(9, 5);
            this.pbSideMenuLogo.Name = "pbSideMenuLogo";
            this.pbSideMenuLogo.Size = new System.Drawing.Size(110, 50);
            this.pbSideMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSideMenuLogo.TabIndex = 1;
            this.pbSideMenuLogo.TabStop = false;
            // 
            // biFormOptions
            // 
            this.biFormOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.biFormOptions.BackColor = System.Drawing.Color.Transparent;
            this.biFormOptions.BackIcon = false;
            this.biFormOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biFormOptions.Customizable = false;
            this.biFormOptions.DropdownMenu = null;
            this.biFormOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.biFormOptions.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.biFormOptions.IconColor = System.Drawing.Color.WhiteSmoke;
            this.biFormOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.biFormOptions.IconSize = 25;
            this.biFormOptions.Location = new System.Drawing.Point(723, 20);
            this.biFormOptions.Name = "biFormOptions";
            this.biFormOptions.Size = new System.Drawing.Size(25, 25);
            this.biFormOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.biFormOptions.TabIndex = 5;
            this.biFormOptions.TabStop = false;
            // 
            // biNotifications
            // 
            this.biNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.biNotifications.BackColor = System.Drawing.Color.Transparent;
            this.biNotifications.BackIcon = false;
            this.biNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biNotifications.Customizable = false;
            this.biNotifications.DropdownMenu = null;
            this.biNotifications.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.biNotifications.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.biNotifications.IconColor = System.Drawing.Color.WhiteSmoke;
            this.biNotifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.biNotifications.IconSize = 25;
            this.biNotifications.Location = new System.Drawing.Point(756, 20);
            this.biNotifications.Name = "biNotifications";
            this.biNotifications.Size = new System.Drawing.Size(25, 25);
            this.biNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.biNotifications.TabIndex = 6;
            this.biNotifications.TabStop = false;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfilePicture.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbProfilePicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbProfilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbProfilePicture.BorderSize = 0;
            this.pbProfilePicture.Customizable = true;
            this.pbProfilePicture.GradientAngle = 50F;
            this.pbProfilePicture.GradientColor = false;
            this.pbProfilePicture.Image = global::RJCodeUI_M1.Properties.Resources.userProfile;
            this.pbProfilePicture.Location = new System.Drawing.Point(787, 13);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(35, 35);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 7;
            this.pbProfilePicture.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserName.LinkLabel = false;
            this.lblUserName.Location = new System.Drawing.Point(828, 23);
            this.lblUserName.MaximumSize = new System.Drawing.Size(95, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 20);
            this.lblUserName.Style = RJCodeUI_M1.RJControls.LabelStyle.BarText;
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // biUserOptions
            // 
            this.biUserOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.biUserOptions.BackColor = System.Drawing.Color.Transparent;
            this.biUserOptions.BackIcon = false;
            this.biUserOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.biUserOptions.Customizable = false;
            this.biUserOptions.DropdownMenu = this.dmUserOptions;
            this.biUserOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.biUserOptions.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            this.biUserOptions.IconColor = System.Drawing.Color.WhiteSmoke;
            this.biUserOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.biUserOptions.IconSize = 25;
            this.biUserOptions.Location = new System.Drawing.Point(925, 23);
            this.biUserOptions.Name = "biUserOptions";
            this.biUserOptions.Size = new System.Drawing.Size(25, 25);
            this.biUserOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.biUserOptions.TabIndex = 9;
            this.biUserOptions.TabStop = false;
            // 
            // dmUserOptions
            // 
            this.dmUserOptions.ActiveMenuItem = false;
            this.dmUserOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmUserOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dmUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMyProfile,
            this.miSettings,
            this.miTermsCond,
            this.miHelp,
            this.miLogout,
            this.miExit});
            this.dmUserOptions.Name = "dmUserOptions";
            this.dmUserOptions.OwnerIsMenuButton = false;
            this.dmUserOptions.Size = new System.Drawing.Size(207, 160);
            // 
            // miMyProfile
            // 
            this.miMyProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.miMyProfile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.miMyProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miMyProfile.IconSize = 21;
            this.miMyProfile.Name = "miMyProfile";
            this.miMyProfile.Size = new System.Drawing.Size(206, 26);
            this.miMyProfile.Text = "My Profile";
            this.miMyProfile.Click += new System.EventHandler(this.miMyProfile_Click);
            // 
            // miSettings
            // 
            this.miSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.miSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.miSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miSettings.IconSize = 21;
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(206, 26);
            this.miSettings.Text = "Settings";
            this.miSettings.Click += new System.EventHandler(this.miSettings_Click);
            // 
            // miTermsCond
            // 
            this.miTermsCond.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.miTermsCond.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(132)))), ((int)(((byte)(235)))));
            this.miTermsCond.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miTermsCond.IconSize = 21;
            this.miTermsCond.Name = "miTermsCond";
            this.miTermsCond.Size = new System.Drawing.Size(206, 26);
            this.miTermsCond.Text = "Terms and Cond";
            this.miTermsCond.Click += new System.EventHandler(this.miTermsCond_Click);
            // 
            // miHelp
            // 
            this.miHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.miHelp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.miHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miHelp.IconSize = 21;
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(206, 26);
            this.miHelp.Text = "Help";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // miLogout
            // 
            this.miLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.miLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(228)))));
            this.miLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miLogout.IconSize = 21;
            this.miLogout.Name = "miLogout";
            this.miLogout.Size = new System.Drawing.Size(206, 26);
            this.miLogout.Text = "Logout";
            this.miLogout.Click += new System.EventHandler(this.miLogout_Click);
            // 
            // miExit
            // 
            this.miExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.miExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(37)))), ((int)(((byte)(118)))));
            this.miExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miExit.IconSize = 21;
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(206, 26);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.DropdownMenu = null;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 28;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 230);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 55);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSales.BackgroundImage")));
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.DropdownMenu = this.dmSalesOrder;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnSales.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSales.IconSize = 28;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 285);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(220, 55);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "   Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // dmSalesOrder
            // 
            this.dmSalesOrder.ActiveMenuItem = false;
            this.dmSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmSalesOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dmSalesOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesListToolStripMenuItem,
            this.salesListToolStripMenuItem1,
            this.pendingDeliveriesToolStripMenuItem,
            this.dropSaleToolStripMenuItem,
            this.renewSalesToolStripMenuItem});
            this.dmSalesOrder.Name = "dmSalesOrder";
            this.dmSalesOrder.OwnerIsMenuButton = false;
            this.dmSalesOrder.Size = new System.Drawing.Size(219, 124);
            // 
            // salesListToolStripMenuItem
            // 
            this.salesListToolStripMenuItem.Name = "salesListToolStripMenuItem";
            this.salesListToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.salesListToolStripMenuItem.Text = "New Sale";
            // 
            // salesListToolStripMenuItem1
            // 
            this.salesListToolStripMenuItem1.Name = "salesListToolStripMenuItem1";
            this.salesListToolStripMenuItem1.Size = new System.Drawing.Size(218, 24);
            this.salesListToolStripMenuItem1.Text = "Sales List";
            this.salesListToolStripMenuItem1.Click += new System.EventHandler(this.miSalesList_Click);
            // 
            // pendingDeliveriesToolStripMenuItem
            // 
            this.pendingDeliveriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hightPriorityToolStripMenuItem,
            this.mediumPriorityToolStripMenuItem,
            this.lowPriorityToolStripMenuItem});
            this.pendingDeliveriesToolStripMenuItem.Name = "pendingDeliveriesToolStripMenuItem";
            this.pendingDeliveriesToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.pendingDeliveriesToolStripMenuItem.Text = "Pending Deliveries";
            // 
            // hightPriorityToolStripMenuItem
            // 
            this.hightPriorityToolStripMenuItem.Name = "hightPriorityToolStripMenuItem";
            this.hightPriorityToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.hightPriorityToolStripMenuItem.Text = "Hight Priority";
            // 
            // mediumPriorityToolStripMenuItem
            // 
            this.mediumPriorityToolStripMenuItem.Name = "mediumPriorityToolStripMenuItem";
            this.mediumPriorityToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.mediumPriorityToolStripMenuItem.Text = "Medium Priority";
            // 
            // lowPriorityToolStripMenuItem
            // 
            this.lowPriorityToolStripMenuItem.Name = "lowPriorityToolStripMenuItem";
            this.lowPriorityToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.lowPriorityToolStripMenuItem.Text = "Low Priority";
            // 
            // dropSaleToolStripMenuItem
            // 
            this.dropSaleToolStripMenuItem.Name = "dropSaleToolStripMenuItem";
            this.dropSaleToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.dropSaleToolStripMenuItem.Text = "Drop Sales";
            // 
            // renewSalesToolStripMenuItem
            // 
            this.renewSalesToolStripMenuItem.Name = "renewSalesToolStripMenuItem";
            this.renewSalesToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.renewSalesToolStripMenuItem.Text = "Renew Sales";
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.DropdownMenu = null;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnProducts.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducts.IconSize = 28;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 340);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(220, 55);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "   Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.DropdownMenu = null;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnCustomers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomers.IconSize = 28;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 395);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(220, 55);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "   Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnUserControls
            // 
            this.btnUserControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnUserControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserControls.DropdownMenu = null;
            this.btnUserControls.FlatAppearance.BorderSize = 0;
            this.btnUserControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserControls.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnUserControls.IconChar = FontAwesome.Sharp.IconChar.Uikit;
            this.btnUserControls.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnUserControls.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserControls.IconSize = 28;
            this.btnUserControls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserControls.Location = new System.Drawing.Point(0, 120);
            this.btnUserControls.Name = "btnUserControls";
            this.btnUserControls.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUserControls.Size = new System.Drawing.Size(220, 55);
            this.btnUserControls.TabIndex = 5;
            this.btnUserControls.Text = "   User Controls";
            this.btnUserControls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserControls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserControls.UseVisualStyleBackColor = false;
            this.btnUserControls.Click += new System.EventHandler(this.btnUserControls_Click);
            // 
            // dmCustomControls
            // 
            this.dmCustomControls.ActiveMenuItem = false;
            this.dmCustomControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmCustomControls.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dmCustomControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonToolStripMenuItem,
            this.menusToolStripMenuItem,
            this.containersToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.componentsToolStripMenuItem,
            this.specialsToolStripMenuItem});
            this.dmCustomControls.Name = "dmCustomControls";
            this.dmCustomControls.OwnerIsMenuButton = false;
            this.dmCustomControls.Size = new System.Drawing.Size(173, 148);
            // 
            // commonToolStripMenuItem
            // 
            this.commonToolStripMenuItem.Name = "commonToolStripMenuItem";
            this.commonToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.commonToolStripMenuItem.Text = "Common";
            this.commonToolStripMenuItem.Click += new System.EventHandler(this.miCommonControls_Click);
            // 
            // menusToolStripMenuItem
            // 
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.menusToolStripMenuItem.Text = "Menus";
            this.menusToolStripMenuItem.Click += new System.EventHandler(this.miMenuControls_Click);
            // 
            // containersToolStripMenuItem
            // 
            this.containersToolStripMenuItem.Name = "containersToolStripMenuItem";
            this.containersToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.containersToolStripMenuItem.Text = "Containers";
            this.containersToolStripMenuItem.Click += new System.EventHandler(this.miContainerControls_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.dataToolStripMenuItem.Text = "Data";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.miDataControls_Click);
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            this.componentsToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.componentsToolStripMenuItem.Text = "Components";
            this.componentsToolStripMenuItem.Click += new System.EventHandler(this.miComponentsControls_Click);
            // 
            // specialsToolStripMenuItem
            // 
            this.specialsToolStripMenuItem.Name = "specialsToolStripMenuItem";
            this.specialsToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.specialsToolStripMenuItem.Text = "Specials";
            this.specialsToolStripMenuItem.Click += new System.EventHandler(this.miSpecialControls_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(391, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // rjLabel1
            // 
            this.rjLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjLabel1.AutoSize = true;
            this.rjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel1.Font = new System.Drawing.Font("Verdana", 18F);
            this.rjLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel1.LinkLabel = false;
            this.rjLabel1.Location = new System.Drawing.Point(339, 272);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(306, 36);
            this.rjLabel1.Style = RJCodeUI_M1.RJControls.LabelStyle.Custom;
            this.rjLabel1.TabIndex = 1;
            this.rjLabel1.Text = "RJ CODE ADVANCE";
            // 
            // rjLabel2
            // 
            this.rjLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjLabel2.AutoSize = true;
            this.rjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel2.LinkLabel = false;
            this.rjLabel2.Location = new System.Drawing.Point(280, 301);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(466, 22);
            this.rjLabel2.Style = RJCodeUI_M1.RJControls.LabelStyle.Custom;
            this.rjLabel2.TabIndex = 2;
            this.rjLabel2.Text = "Programming and software development tutorials";
            // 
            // dmCustomForms
            // 
            this.dmCustomForms.ActiveMenuItem = false;
            this.dmCustomForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmCustomForms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dmCustomForms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseFormToolStripMenuItem,
            this.mainFormToolStripMenuItem,
            this.childFormToolStripMenuItem});
            this.dmCustomForms.Name = "dmCustomForms";
            this.dmCustomForms.OwnerIsMenuButton = false;
            this.dmCustomForms.Size = new System.Drawing.Size(162, 76);
            // 
            // baseFormToolStripMenuItem
            // 
            this.baseFormToolStripMenuItem.Name = "baseFormToolStripMenuItem";
            this.baseFormToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.baseFormToolStripMenuItem.Text = "Base Form";
            this.baseFormToolStripMenuItem.Click += new System.EventHandler(this.baseFormToolStripMenuItem_Click);
            // 
            // mainFormToolStripMenuItem
            // 
            this.mainFormToolStripMenuItem.Name = "mainFormToolStripMenuItem";
            this.mainFormToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.mainFormToolStripMenuItem.Text = "Main Form";
            this.mainFormToolStripMenuItem.Click += new System.EventHandler(this.mainFormToolStripMenuItem_Click);
            // 
            // childFormToolStripMenuItem
            // 
            this.childFormToolStripMenuItem.Name = "childFormToolStripMenuItem";
            this.childFormToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.childFormToolStripMenuItem.Text = "Child Form";
            this.childFormToolStripMenuItem.Click += new System.EventHandler(this.childFormToolStripMenuItem_Click);
            // 
            // btnCustomForms
            // 
            this.btnCustomForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnCustomForms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomForms.BackgroundImage")));
            this.btnCustomForms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomForms.DropdownMenu = this.dmCustomForms;
            this.btnCustomForms.FlatAppearance.BorderSize = 0;
            this.btnCustomForms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.btnCustomForms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomForms.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomForms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnCustomForms.IconChar = FontAwesome.Sharp.IconChar.ThLarge;
            this.btnCustomForms.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnCustomForms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomForms.IconSize = 28;
            this.btnCustomForms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomForms.Location = new System.Drawing.Point(0, 175);
            this.btnCustomForms.Name = "btnCustomForms";
            this.btnCustomForms.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCustomForms.Size = new System.Drawing.Size(220, 55);
            this.btnCustomForms.TabIndex = 7;
            this.btnCustomForms.Text = "   Custom Forms";
            this.btnCustomForms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomForms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomForms.UseVisualStyleBackColor = false;
            // 
            // btnYoutube
            // 
            this.btnYoutube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnYoutube.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnYoutube.BorderRadius = 20;
            this.btnYoutube.BorderSize = 0;
            this.btnYoutube.Design = RJCodeUI_M1.RJControls.ButtonDesign.Normal;
            this.btnYoutube.FlatAppearance.BorderSize = 0;
            this.btnYoutube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnYoutube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(186)))));
            this.btnYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYoutube.ForeColor = System.Drawing.Color.White;
            this.btnYoutube.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnYoutube.IconColor = System.Drawing.Color.White;
            this.btnYoutube.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYoutube.IconSize = 24;
            this.btnYoutube.Location = new System.Drawing.Point(284, 339);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(180, 40);
            this.btnYoutube.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.btnYoutube.TabIndex = 3;
            this.btnYoutube.Text = "YouTube";
            this.btnYoutube.UseVisualStyleBackColor = false;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnGithub.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnGithub.BorderRadius = 20;
            this.btnGithub.BorderSize = 2;
            this.btnGithub.Design = RJCodeUI_M1.RJControls.ButtonDesign.Normal;
            this.btnGithub.FlatAppearance.BorderSize = 0;
            this.btnGithub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.btnGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(219)))));
            this.btnGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnGithub.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGithub.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnGithub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGithub.IconSize = 24;
            this.btnGithub.Location = new System.Drawing.Point(472, 339);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(180, 40);
            this.btnGithub.Style = RJCodeUI_M1.RJControls.ControlStyle.Glass;
            this.btnGithub.TabIndex = 4;
            this.btnGithub.Text = "GitHub";
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnCustomControls
            // 
            this.btnCustomControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.btnCustomControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomControls.BackgroundImage")));
            this.btnCustomControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomControls.DropdownMenu = this.dmCustomControls;
            this.btnCustomControls.FlatAppearance.BorderSize = 0;
            this.btnCustomControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomControls.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnCustomControls.IconChar = FontAwesome.Sharp.IconChar.Cuttlefish;
            this.btnCustomControls.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(119)))), ((int)(((byte)(170)))));
            this.btnCustomControls.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomControls.IconSize = 28;
            this.btnCustomControls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomControls.Location = new System.Drawing.Point(0, 65);
            this.btnCustomControls.Name = "btnCustomControls";
            this.btnCustomControls.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCustomControls.Size = new System.Drawing.Size(220, 55);
            this.btnCustomControls.TabIndex = 6;
            this.btnCustomControls.Text = "   Controls";
            this.btnCustomControls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomControls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomControls.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.ClientSize = new System.Drawing.Size(1180, 610);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Controls.SetChildIndex(this.pnlTitleBar, 0);
            this.Controls.SetChildIndex(this.pnlDesktopHeader, 0);
            this.Controls.SetChildIndex(this.pnlDesktop, 0);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenuHeader.ResumeLayout(false);
            this.pnlSideMenuHeader.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSideMenuLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biFormOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biUserOptions)).EndInit();
            this.dmUserOptions.ResumeLayout(false);
            this.dmSalesOrder.ResumeLayout(false);
            this.dmCustomControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.dmCustomForms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSideMenuLogo;
        private RJControls.RJMenuIcon biUserOptions;
        private RJControls.RJLabel lblUserName;
        private RJControls.RJCircularPictureBox pbProfilePicture;
        private RJControls.RJMenuIcon biNotifications;
        private RJControls.RJMenuIcon biFormOptions;
        private RJControls.RJDropdownMenu dmUserOptions;
        private FontAwesome.Sharp.IconMenuItem miMyProfile;
        private FontAwesome.Sharp.IconMenuItem miSettings;
        private FontAwesome.Sharp.IconMenuItem miTermsCond;
        private FontAwesome.Sharp.IconMenuItem miHelp;
        private FontAwesome.Sharp.IconMenuItem miLogout;
        private FontAwesome.Sharp.IconMenuItem miExit;
        private RJControls.RJMenuButton btnUserControls;
        private RJControls.RJMenuButton btnCustomers;
        private RJControls.RJMenuButton btnProducts;
        private RJControls.RJMenuButton btnSales;
        private RJControls.RJMenuButton btnDashboard;
        private RJControls.RJDropdownMenu dmSalesOrder;
        private System.Windows.Forms.ToolStripMenuItem salesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pendingDeliveriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewSalesToolStripMenuItem;
        private RJControls.RJDropdownMenu dmCustomControls;
        private System.Windows.Forms.ToolStripMenuItem commonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hightPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowPriorityToolStripMenuItem;
        private RJControls.RJLabel rjLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJMenuButton btnCustomForms;
        private RJControls.RJDropdownMenu dmCustomForms;
        private System.Windows.Forms.ToolStripMenuItem baseFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childFormToolStripMenuItem;
        private RJControls.RJButton btnGithub;
        private RJControls.RJButton btnYoutube;
        private RJControls.RJMenuButton btnCustomControls;
    }
}