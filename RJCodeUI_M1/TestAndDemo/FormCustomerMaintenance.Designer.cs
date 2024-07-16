namespace RJCodeUI_M1.TestAndDemo
{
    partial class FormCustomerMaintenance
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
            this.btnSave = new RJCodeUI_M1.RJControls.RJButton();
            this.lblTitle = new RJCodeUI_M1.RJControls.RJLabel();
            this.rjLabel4 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtAddress = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel3 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtEmail = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel2 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtPhone = new RJCodeUI_M1.RJControls.RJTextBox();
            this.rjLabel1 = new RJCodeUI_M1.RJControls.RJLabel();
            this.txtNames = new RJCodeUI_M1.RJControls.RJTextBox();
            this.pnlClientArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClientArea
            // 
            this.pnlClientArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlClientArea.Controls.Add(this.btnSave);
            this.pnlClientArea.Controls.Add(this.lblTitle);
            this.pnlClientArea.Controls.Add(this.rjLabel4);
            this.pnlClientArea.Controls.Add(this.txtAddress);
            this.pnlClientArea.Controls.Add(this.rjLabel3);
            this.pnlClientArea.Controls.Add(this.txtEmail);
            this.pnlClientArea.Controls.Add(this.rjLabel2);
            this.pnlClientArea.Controls.Add(this.txtPhone);
            this.pnlClientArea.Controls.Add(this.rjLabel1);
            this.pnlClientArea.Controls.Add(this.txtNames);
            this.pnlClientArea.Location = new System.Drawing.Point(1, 41);
            this.pnlClientArea.Size = new System.Drawing.Size(517, 291);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 1;
            this.btnSave.Design = RJCodeUI_M1.RJControls.ButtonDesign.Normal;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(186)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 24;
            this.btnSave.Location = new System.Drawing.Point(155, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.Style = RJCodeUI_M1.RJControls.ControlStyle.Solid;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.lblTitle.LinkLabel = false;
            this.lblTitle.Location = new System.Drawing.Point(122, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 23);
            this.lblTitle.Style = RJCodeUI_M1.RJControls.LabelStyle.Title;
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rjLabel4
            // 
            this.rjLabel4.AutoSize = true;
            this.rjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel4.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel4.LinkLabel = false;
            this.rjLabel4.Location = new System.Drawing.Point(271, 129);
            this.rjLabel4.Name = "rjLabel4";
            this.rjLabel4.Size = new System.Drawing.Size(112, 16);
            this.rjLabel4.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel4.TabIndex = 17;
            this.rjLabel4.Text = "Street address:";
            // 
            // txtAddress
            // 
            this.txtAddress._Customizable = false;
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.BorderSize = 1;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtAddress.Location = new System.Drawing.Point(274, 148);
            this.txtAddress.MultiLine = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceHolderText = null;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.Size = new System.Drawing.Size(200, 31);
            this.txtAddress.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtAddress.TabIndex = 5;
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // rjLabel3
            // 
            this.rjLabel3.AutoSize = true;
            this.rjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel3.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel3.LinkLabel = false;
            this.rjLabel3.Location = new System.Drawing.Point(271, 60);
            this.rjLabel3.Name = "rjLabel3";
            this.rjLabel3.Size = new System.Drawing.Size(47, 16);
            this.rjLabel3.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel3.TabIndex = 13;
            this.rjLabel3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail._Customizable = false;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtEmail.Location = new System.Drawing.Point(274, 79);
            this.txtEmail.MultiLine = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceHolderText = null;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.Size = new System.Drawing.Size(200, 31);
            this.txtEmail.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtEmail.TabIndex = 3;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // rjLabel2
            // 
            this.rjLabel2.AutoSize = true;
            this.rjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel2.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel2.LinkLabel = false;
            this.rjLabel2.Location = new System.Drawing.Point(40, 129);
            this.rjLabel2.Name = "rjLabel2";
            this.rjLabel2.Size = new System.Drawing.Size(107, 16);
            this.rjLabel2.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel2.TabIndex = 15;
            this.rjLabel2.Text = "Phone number:";
            // 
            // txtPhone
            // 
            this.txtPhone._Customizable = false;
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtPhone.Location = new System.Drawing.Point(43, 148);
            this.txtPhone.MultiLine = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceHolderText = null;
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.Size = new System.Drawing.Size(200, 31);
            this.txtPhone.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtPhone.TabIndex = 4;
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // rjLabel1
            // 
            this.rjLabel1.AutoSize = true;
            this.rjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rjLabel1.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.rjLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.rjLabel1.LinkLabel = false;
            this.rjLabel1.Location = new System.Drawing.Point(40, 60);
            this.rjLabel1.Name = "rjLabel1";
            this.rjLabel1.Size = new System.Drawing.Size(57, 16);
            this.rjLabel1.Style = RJCodeUI_M1.RJControls.LabelStyle.Normal;
            this.rjLabel1.TabIndex = 11;
            this.rjLabel1.Text = "Names:";
            // 
            // txtNames
            // 
            this.txtNames._Customizable = false;
            this.txtNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.txtNames.BorderRadius = 10;
            this.txtNames.BorderSize = 1;
            this.txtNames.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.txtNames.Location = new System.Drawing.Point(43, 79);
            this.txtNames.MultiLine = false;
            this.txtNames.Name = "txtNames";
            this.txtNames.Padding = new System.Windows.Forms.Padding(7);
            this.txtNames.PasswordChar = false;
            this.txtNames.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtNames.PlaceHolderText = null;
            this.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNames.Size = new System.Drawing.Size(200, 31);
            this.txtNames.Style = RJCodeUI_M1.RJControls.TextBoxStyle.MatteBorder;
            this.txtNames.TabIndex = 2;
            this.txtNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // FormCustomerMaintenance
            // 
            this._DesktopPanelSize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(97)))), ((int)(((byte)(212)))));
            this.BorderSize = 1;
            this.Caption = "Customer Maintenance";
            this.ClientSize = new System.Drawing.Size(519, 333);
            this.DisplayMaximizeButton = false;
            this.DisplayMinimizeButton = false;
            this.FormIcon = FontAwesome.Sharp.IconChar.UserCheck;
            this.Name = "FormCustomerMaintenance";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Resizable = false;
            this.Text = "Customer Maintenance";
            this.pnlClientArea.ResumeLayout(false);
            this.pnlClientArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RJControls.RJButton btnSave;
        private RJControls.RJLabel lblTitle;
        private RJControls.RJLabel rjLabel4;
        private RJControls.RJTextBox txtAddress;
        private RJControls.RJLabel rjLabel3;
        private RJControls.RJTextBox txtEmail;
        private RJControls.RJLabel rjLabel2;
        private RJControls.RJTextBox txtPhone;
        private RJControls.RJLabel rjLabel1;
        private RJControls.RJTextBox txtNames;
    }
}