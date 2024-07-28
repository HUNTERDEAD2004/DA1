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
            groupBox2 = new GroupBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnBack = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            groupBox1 = new GroupBox();
            txtQuantity = new NumericUpDown();
            txtID = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDescription = new RichTextBox();
            btnDetails = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 502);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(17, 288);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(305, 138);
            groupBox2.TabIndex = 62;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
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
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(350, 36);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.Size = new Size(615, 390);
            dgvData.TabIndex = 59;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDetails);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(dgvData);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(9, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1144, 675);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(128, 127);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(193, 23);
            txtQuantity.TabIndex = 58;
            // 
            // txtID
            // 
            txtID.Location = new Point(129, 39);
            txtID.Name = "txtID";
            txtID.Size = new Size(193, 23);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Product ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 172);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 19;
            label7.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 129);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Product Name:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(128, 172);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 96);
            txtDescription.TabIndex = 63;
            txtDescription.Text = "";
            // 
            // btnDetails
            // 
            btnDetails.ForeColor = SystemColors.ActiveCaptionText;
            btnDetails.Location = new Point(971, 36);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(97, 46);
            btnDetails.TabIndex = 64;
            btnDetails.Text = "View this product";
            btnDetails.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 496);
            Controls.Add(panel1);
            Name = "Products";
            Text = "Products";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dgvData;
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
    }
}