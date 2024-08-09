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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnClear = new GroupBox();
            btnLoad = new Button();
            btnUpdate = new Button();
            txtQuantity = new TextBox();
            btnClean = new Button();
            dgvData = new DataGridView();
            btnDetails = new Button();
            btnAddProduct = new Button();
            txtUpdateAt = new DateTimePicker();
            txtCreatAt = new DateTimePicker();
            txtUpdateBy = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtCreatBy = new TextBox();
            label5 = new Label();
            txtDescription = new RichTextBox();
            label7 = new Label();
            btnBack = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnDelete = new Button();
            btnClear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Controls.Add(btnDelete);
            btnClear.Controls.Add(btnLoad);
            btnClear.Controls.Add(btnUpdate);
            btnClear.Controls.Add(txtQuantity);
            btnClear.Controls.Add(btnClean);
            btnClear.Controls.Add(dgvData);
            btnClear.Controls.Add(btnDetails);
            btnClear.Controls.Add(btnAddProduct);
            btnClear.Controls.Add(txtUpdateAt);
            btnClear.Controls.Add(txtCreatAt);
            btnClear.Controls.Add(txtUpdateBy);
            btnClear.Controls.Add(label8);
            btnClear.Controls.Add(label6);
            btnClear.Controls.Add(label4);
            btnClear.Controls.Add(txtCreatBy);
            btnClear.Controls.Add(label5);
            btnClear.Controls.Add(txtDescription);
            btnClear.Controls.Add(label7);
            btnClear.Controls.Add(btnBack);
            btnClear.Controls.Add(label3);
            btnClear.Controls.Add(txtName);
            btnClear.Controls.Add(label2);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(9, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(1261, 556);
            btnClear.TabIndex = 2;
            btnClear.TabStop = false;
            btnClear.Text = "Product";
            btnClear.Enter += groupBox1_Enter;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.SkyBlue;
            btnLoad.FlatAppearance.BorderColor = Color.Lavender;
            btnLoad.FlatAppearance.BorderSize = 2;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.ForeColor = SystemColors.ActiveCaptionText;
            btnLoad.Location = new Point(1096, 37);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(52, 25);
            btnLoad.TabIndex = 80;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SkyBlue;
            btnUpdate.FlatAppearance.BorderColor = Color.Lavender;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(577, 222);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 25);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(126, 82);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(193, 23);
            txtQuantity.TabIndex = 78;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.SkyBlue;
            btnClean.FlatAppearance.BorderColor = Color.Lavender;
            btnClean.FlatAppearance.BorderSize = 2;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.ForeColor = SystemColors.ActiveCaptionText;
            btnClean.Location = new Point(245, 230);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 25);
            btnClean.TabIndex = 76;
            btnClean.Text = "Clear";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            dgvData.Location = new Point(658, 37);
            dgvData.Name = "dgvData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(432, 210);
            dgvData.TabIndex = 69;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.SkyBlue;
            btnDetails.ForeColor = SystemColors.ActiveCaptionText;
            btnDetails.Location = new Point(987, 253);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(103, 34);
            btnDetails.TabIndex = 64;
            btnDetails.Text = "View Product";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.SkyBlue;
            btnAddProduct.FlatAppearance.BorderColor = Color.Lavender;
            btnAddProduct.FlatAppearance.BorderSize = 2;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.ForeColor = SystemColors.ActiveCaptionText;
            btnAddProduct.Location = new Point(487, 222);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(75, 25);
            btnAddProduct.TabIndex = 62;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtUpdateAt
            // 
            txtUpdateAt.Format = DateTimePickerFormat.Short;
            txtUpdateAt.Location = new Point(450, 83);
            txtUpdateAt.Name = "txtUpdateAt";
            txtUpdateAt.Size = new Size(193, 23);
            txtUpdateAt.TabIndex = 74;
            // 
            // txtCreatAt
            // 
            txtCreatAt.Format = DateTimePickerFormat.Short;
            txtCreatAt.Location = new Point(450, 39);
            txtCreatAt.Name = "txtCreatAt";
            txtCreatAt.Size = new Size(193, 23);
            txtCreatAt.TabIndex = 73;
            // 
            // txtUpdateBy
            // 
            txtUpdateBy.Location = new Point(450, 171);
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
            txtCreatBy.Location = new Point(450, 127);
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
            // txtDescription
            // 
            txtDescription.Location = new Point(126, 128);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 96);
            txtDescription.TabIndex = 63;
            txtDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(15, 128);
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
            label3.Location = new Point(15, 85);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantity:";
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(15, 42);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Product Name:";
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
            // btnDelete
            // 
            btnDelete.BackColor = Color.SkyBlue;
            btnDelete.FlatAppearance.BorderColor = Color.Lavender;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(577, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 25);
            btnDelete.TabIndex = 81;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1181, 496);
            Controls.Add(panel1);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            btnClear.ResumeLayout(false);
            btnClear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox btnClear;
        private DataGridView dgvData;
        private Button btnDetails;
        private Button btnAddProduct;
        private DateTimePicker txtUpdateAt;
        private DateTimePicker txtCreatAt;
        private TextBox txtUpdateBy;
        private Label label8;
        private Label label6;
        private Label label4;
        private TextBox txtCreatBy;
        private Label label5;
        private RichTextBox txtDescription;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnBack;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private Panel panel1;
        private Button btnClean;
        private TextBox txtQuantity;
        private Button btnUpdate;
        private Button btnLoad;
        private Button btnDelete;
    }
}