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
            btnClear = new GroupBox();
            button1 = new Button();
            txtUpdateAt = new DateTimePicker();
            txtCreatAt = new DateTimePicker();
            dgvData = new DataGridView();
            txtUpdateBy = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtCreatBy = new TextBox();
            label5 = new Label();
            btnDetails = new Button();
            txtDescription = new RichTextBox();
            txtQuantity = new NumericUpDown();
            label7 = new Label();
            btnBack = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            groupBox2 = new GroupBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            btnClear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 502);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Controls.Add(button1);
            btnClear.Controls.Add(txtUpdateAt);
            btnClear.Controls.Add(txtCreatAt);
            btnClear.Controls.Add(dgvData);
            btnClear.Controls.Add(txtUpdateBy);
            btnClear.Controls.Add(label8);
            btnClear.Controls.Add(label6);
            btnClear.Controls.Add(label4);
            btnClear.Controls.Add(txtCreatBy);
            btnClear.Controls.Add(label5);
            btnClear.Controls.Add(btnDetails);
            btnClear.Controls.Add(txtDescription);
            btnClear.Controls.Add(txtQuantity);
            btnClear.Controls.Add(label7);
            btnClear.Controls.Add(btnBack);
            btnClear.Controls.Add(label3);
            btnClear.Controls.Add(txtName);
            btnClear.Controls.Add(label2);
            btnClear.Controls.Add(label1);
            btnClear.Controls.Add(txtID);
            btnClear.Controls.Add(groupBox2);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(9, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(1144, 675);
            btnClear.TabIndex = 2;
            btnClear.TabStop = false;
            btnClear.Text = "Product";
            btnClear.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(17, 416);
            button1.Name = "button1";
            button1.Size = new Size(87, 28);
            button1.TabIndex = 72;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtUpdateAt
            // 
            txtUpdateAt.Format = DateTimePickerFormat.Short;
            txtUpdateAt.Location = new Point(450, 82);
            txtUpdateAt.MaxDate = new DateTime(2024, 7, 29, 0, 0, 0, 0);
            txtUpdateAt.Name = "txtUpdateAt";
            txtUpdateAt.Size = new Size(193, 23);
            txtUpdateAt.TabIndex = 71;
            txtUpdateAt.Value = new DateTime(2024, 7, 29, 0, 0, 0, 0);
            // 
            // txtCreatAt
            // 
            txtCreatAt.Format = DateTimePickerFormat.Short;
            txtCreatAt.ImeMode = ImeMode.Off;
            txtCreatAt.Location = new Point(450, 39);
            txtCreatAt.MaxDate = new DateTime(2024, 7, 29, 0, 22, 36, 0);
            txtCreatAt.Name = "txtCreatAt";
            txtCreatAt.Size = new Size(193, 23);
            txtCreatAt.TabIndex = 70;
            txtCreatAt.Value = new DateTime(2024, 7, 29, 0, 0, 0, 0);
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(338, 201);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(432, 210);
            dgvData.TabIndex = 69;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // txtUpdateBy
            // 
            txtUpdateBy.Location = new Point(450, 172);
            txtUpdateBy.Name = "txtUpdateBy";
            txtUpdateBy.Size = new Size(193, 23);
            txtUpdateBy.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(338, 175);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 67;
            label8.Text = "Updated By:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(338, 131);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 66;
            label6.Text = "Created By:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(338, 86);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 67;
            label4.Text = "Updated At:";
            // 
            // txtCreatBy
            // 
            txtCreatBy.Location = new Point(450, 128);
            txtCreatBy.Name = "txtCreatBy";
            txtCreatBy.Size = new Size(193, 23);
            txtCreatBy.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(338, 42);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 66;
            label5.Text = "Created At:";
            // 
            // btnDetails
            // 
            btnDetails.ForeColor = SystemColors.ActiveCaptionText;
            btnDetails.Location = new Point(776, 201);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(97, 46);
            btnDetails.TabIndex = 64;
            btnDetails.Text = "View this product";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(128, 172);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 96);
            txtDescription.TabIndex = 63;
            txtDescription.Text = "";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(128, 127);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(193, 23);
            txtQuantity.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(17, 172);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 19;
            label7.Text = "Description";
            // 
            // btnBack
            // 
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 17;
            btnBack.ImageAlign = ContentAlignment.MiddleRight;
            btnBack.Location = new Point(866, 638);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(17, 129);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Product ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(129, 39);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(193, 23);
            txtID.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(17, 273);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(305, 138);
            groupBox2.TabIndex = 62;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlDark;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 15;
            btnSearch.Location = new Point(232, 37);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(45, 20);
            btnSearch.TabIndex = 61;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ControlDark;
            txtSearch.Location = new Point(19, 34);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 23);
            txtSearch.TabIndex = 60;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SkyBlue;
            btnDelete.FlatAppearance.BorderColor = Color.Lavender;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(202, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 25);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SkyBlue;
            btnAdd.FlatAppearance.BorderColor = Color.Lavender;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(22, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 25);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SkyBlue;
            btnUpdate.FlatAppearance.BorderColor = Color.Lavender;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(112, 79);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 25);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1152, 496);
            Controls.Add(panel1);
            Name = "Products";
            Text = "Products";
            panel1.ResumeLayout(false);
            btnClear.ResumeLayout(false);
            btnClear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox btnClear;
        private NumericUpDown txtQuantity;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnBack;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDetails;
        private RichTextBox txtDescription;
        private DataGridView dgvData;
        private Button button1;
        private DateTimePicker txtUpdateAt;
        private DateTimePicker txtCreatAt;
        private TextBox txtUpdateBy;
        private Label label8;
        private Label label6;
        private Label label4;
        private TextBox txtCreatBy;
        private Label label5;
    }
}