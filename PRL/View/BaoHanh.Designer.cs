namespace PRL.View
{
    partial class BaoHanh
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnClear = new GroupBox();
            btnUpdate = new Button();
            btnClean = new Button();
            dgvbaohanh = new DataGridView();
            add = new Button();
            ngaykt = new DateTimePicker();
            ngaybd = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            btnBack = new FontAwesome.Sharp.IconButton();
            ime = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvsanpham = new DataGridView();
            btnClear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbaohanh).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Controls.Add(groupBox2);
            btnClear.Controls.Add(groupBox1);
            btnClear.Controls.Add(btnUpdate);
            btnClear.Controls.Add(btnClean);
            btnClear.Controls.Add(add);
            btnClear.Controls.Add(ngaykt);
            btnClear.Controls.Add(ngaybd);
            btnClear.Controls.Add(label4);
            btnClear.Controls.Add(label5);
            btnClear.Controls.Add(btnBack);
            btnClear.Controls.Add(ime);
            btnClear.Controls.Add(label2);
            btnClear.Controls.Add(label1);
            btnClear.Controls.Add(txtID);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(10, 9);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(3, 4, 3, 4);
            btnClear.Size = new Size(1428, 741);
            btnClear.TabIndex = 2;
            btnClear.TabStop = false;
            btnClear.Text = "Bảo Hành";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SkyBlue;
            btnUpdate.FlatAppearance.BorderColor = Color.Lavender;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(381, 209);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 33);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.SkyBlue;
            btnClean.FlatAppearance.BorderColor = Color.Lavender;
            btnClean.FlatAppearance.BorderSize = 2;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.ForeColor = SystemColors.ActiveCaptionText;
            btnClean.Location = new Point(500, 209);
            btnClean.Margin = new Padding(3, 4, 3, 4);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(86, 33);
            btnClean.TabIndex = 76;
            btnClean.Text = "Clear";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // dgvbaohanh
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvbaohanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvbaohanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvbaohanh.DefaultCellStyle = dataGridViewCellStyle5;
            dgvbaohanh.Location = new Point(23, 27);
            dgvbaohanh.Margin = new Padding(3, 4, 3, 4);
            dgvbaohanh.Name = "dgvbaohanh";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvbaohanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvbaohanh.RowHeadersWidth = 51;
            dgvbaohanh.RowTemplate.Height = 25;
            dgvbaohanh.Size = new Size(438, 243);
            dgvbaohanh.TabIndex = 69;
            dgvbaohanh.CellContentClick += dgvbaohanh_CellContentClick;
            // 
            // add
            // 
            add.BackColor = Color.SkyBlue;
            add.FlatAppearance.BorderColor = Color.Lavender;
            add.FlatAppearance.BorderSize = 2;
            add.FlatStyle = FlatStyle.Flat;
            add.ForeColor = SystemColors.ActiveCaptionText;
            add.Location = new Point(248, 209);
            add.Margin = new Padding(3, 4, 3, 4);
            add.Name = "add";
            add.Size = new Size(86, 33);
            add.TabIndex = 62;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click_1;
            // 
            // ngaykt
            // 
            ngaykt.Format = DateTimePickerFormat.Short;
            ngaykt.Location = new Point(514, 111);
            ngaykt.Margin = new Padding(3, 4, 3, 4);
            ngaykt.Name = "ngaykt";
            ngaykt.Size = new Size(220, 27);
            ngaykt.TabIndex = 74;
            // 
            // ngaybd
            // 
            ngaybd.Format = DateTimePickerFormat.Short;
            ngaybd.Location = new Point(514, 52);
            ngaybd.Margin = new Padding(3, 4, 3, 4);
            ngaybd.Name = "ngaybd";
            ngaybd.Size = new Size(220, 27);
            ngaybd.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(386, 116);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 67;
            label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(386, 57);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 66;
            label5.Text = "Ngày bắt đầu";
            // 
            // btnBack
            // 
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 17;
            btnBack.ImageAlign = ContentAlignment.MiddleRight;
            btnBack.Location = new Point(990, 851);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ime
            // 
            ime.Location = new Point(147, 111);
            ime.Margin = new Padding(3, 4, 3, 4);
            ime.Name = "ime";
            ime.Size = new Size(220, 27);
            ime.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(19, 116);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 3;
            label2.Text = "IMEI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(19, 57);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "ID bảo hành";
            // 
            // txtID
            // 
            txtID.Location = new Point(147, 52);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(220, 27);
            txtID.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1477, 813);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvbaohanh);
            groupBox1.Location = new Point(47, 299);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 293);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảo Hành";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvsanpham);
            groupBox2.Location = new Point(565, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 293);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm";
            // 
            // dgvsanpham
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvsanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvsanpham.DefaultCellStyle = dataGridViewCellStyle2;
            dgvsanpham.Location = new Point(23, 27);
            dgvsanpham.Margin = new Padding(3, 4, 3, 4);
            dgvsanpham.Name = "dgvsanpham";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvsanpham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvsanpham.RowHeadersWidth = 51;
            dgvsanpham.RowTemplate.Height = 25;
            dgvsanpham.Size = new Size(438, 243);
            dgvsanpham.TabIndex = 69;
            // 
            // BaoHanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 685);
            Controls.Add(panel1);
            Name = "BaoHanh";
            Text = "BaoHanh";
            Load += BaoHanh_Load;
            btnClear.ResumeLayout(false);
            btnClear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbaohanh).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox btnClear;
        private Button btnUpdate;
        private Button btnClean;
        private DataGridView dgvbaohanh;
        private Button add;
        private DateTimePicker ngaykt;
        private DateTimePicker ngaybd;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnBack;
        private TextBox ime;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private Panel panel1;
        private GroupBox groupBox2;
        private DataGridView dgvsanpham;
        private GroupBox groupBox1;
    }
}