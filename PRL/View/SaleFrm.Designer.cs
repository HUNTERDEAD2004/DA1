namespace PRL.View
{
    partial class SaleFrm
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
            txtUpdate = new DateTimePicker();
            txtEnd = new DateTimePicker();
            txtCreate = new DateTimePicker();
            txtStart = new DateTimePicker();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnUse = new Button();
            cbSale = new ComboBox();
            cbRam = new ComboBox();
            cbRom = new ComboBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtDescription = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUpdateBy = new TextBox();
            txtCreateBy = new TextBox();
            txtName = new TextBox();
            txtValue = new TextBox();
            dgvSales = new DataGridView();
            dgvSPCT = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSPCT).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(txtUpdate);
            panel1.Controls.Add(txtEnd);
            panel1.Controls.Add(txtCreate);
            panel1.Controls.Add(txtStart);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnUse);
            panel1.Controls.Add(cbSale);
            panel1.Controls.Add(cbRam);
            panel1.Controls.Add(cbRom);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUpdateBy);
            panel1.Controls.Add(txtCreateBy);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtValue);
            panel1.Controls.Add(dgvSales);
            panel1.Controls.Add(dgvSPCT);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 520);
            panel1.TabIndex = 0;
            // 
            // txtUpdate
            // 
            txtUpdate.Format = DateTimePickerFormat.Short;
            txtUpdate.Location = new Point(348, 83);
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(155, 23);
            txtUpdate.TabIndex = 11;
            // 
            // txtEnd
            // 
            txtEnd.Format = DateTimePickerFormat.Short;
            txtEnd.Location = new Point(85, 124);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(155, 23);
            txtEnd.TabIndex = 11;
            // 
            // txtCreate
            // 
            txtCreate.Format = DateTimePickerFormat.Short;
            txtCreate.Location = new Point(348, 42);
            txtCreate.Name = "txtCreate";
            txtCreate.Size = new Size(155, 23);
            txtCreate.TabIndex = 10;
            // 
            // txtStart
            // 
            txtStart.Format = DateTimePickerFormat.Short;
            txtStart.Location = new Point(85, 83);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(155, 23);
            txtStart.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(429, 238);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(341, 238);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(253, 238);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUse
            // 
            btnUse.Location = new Point(715, 290);
            btnUse.Name = "btnUse";
            btnUse.Size = new Size(75, 23);
            btnUse.TabIndex = 8;
            btnUse.Text = "Áp dụng";
            btnUse.UseVisualStyleBackColor = true;
            btnUse.Click += btnUse_Click;
            // 
            // cbSale
            // 
            cbSale.FormattingEnabled = true;
            cbSale.Location = new Point(588, 290);
            cbSale.Name = "cbSale";
            cbSale.Size = new Size(121, 23);
            cbSale.TabIndex = 7;
            // 
            // cbRam
            // 
            cbRam.FormattingEnabled = true;
            cbRam.Location = new Point(175, 290);
            cbRam.Name = "cbRam";
            cbRam.Size = new Size(121, 23);
            cbRam.TabIndex = 6;
            // 
            // cbRom
            // 
            cbRom.FormattingEnabled = true;
            cbRom.Location = new Point(302, 290);
            cbRom.Name = "cbRom";
            cbRom.Size = new Size(121, 23);
            cbRom.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 15;
            btnSearch.Location = new Point(429, 290);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 24);
            btnSearch.TabIndex = 5;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(85, 166);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(155, 96);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(275, 174);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 3;
            label8.Text = "Update By";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(275, 130);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 3;
            label7.Text = "Create By";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(14, 172);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(275, 86);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 3;
            label6.Text = "Update At";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(14, 128);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 3;
            label3.Text = "End";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(275, 42);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 3;
            label5.Text = "Create At";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Start";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Value";
            // 
            // txtUpdateBy
            // 
            txtUpdateBy.Location = new Point(348, 169);
            txtUpdateBy.Name = "txtUpdateBy";
            txtUpdateBy.ReadOnly = true;
            txtUpdateBy.Size = new Size(155, 23);
            txtUpdateBy.TabIndex = 2;
            // 
            // txtCreateBy
            // 
            txtCreateBy.Location = new Point(348, 127);
            txtCreateBy.Name = "txtCreateBy";
            txtCreateBy.ReadOnly = true;
            txtCreateBy.Size = new Size(155, 23);
            txtCreateBy.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 290);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 23);
            txtName.TabIndex = 2;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(85, 37);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(155, 23);
            txtValue.TabIndex = 2;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(509, 37);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.RowTemplate.Height = 25;
            dgvSales.Size = new Size(281, 224);
            dgvSales.TabIndex = 1;
            dgvSales.CellContentClick += dgvSales_CellContentClick;
            // 
            // dgvSPCT
            // 
            dgvSPCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSPCT.Location = new Point(14, 319);
            dgvSPCT.Name = "dgvSPCT";
            dgvSPCT.RowHeadersWidth = 51;
            dgvSPCT.RowTemplate.Height = 25;
            dgvSPCT.Size = new Size(776, 143);
            dgvSPCT.TabIndex = 0;
            dgvSPCT.CellContentClick += dgvSPCT_CellContentClick;
            // 
            // SaleFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(panel1);
            Name = "SaleFrm";
            Text = "Sales";
            Load += SaleFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSPCT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUpdateBy;
        private TextBox txtCreateBy;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox txtValue;
        private DataGridView dgvSales;
        private DataGridView dgvSPCT;
        private FontAwesome.Sharp.IconButton btnSearch;
        private RichTextBox txtDescription;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private TextBox txtName;
        private ComboBox cbRam;
        private ComboBox cbRom;
        private Button btnUse;
        private ComboBox cbSale;
        private Button btnAdd;
        private Button btnClear;
        private Button btnUpdate;
        private DateTimePicker txtUpdate;
        private DateTimePicker txtEnd;
        private DateTimePicker txtCreate;
        private DateTimePicker txtStart;
    }
}