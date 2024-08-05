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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnClear = new GroupBox();
            groupBox2 = new GroupBox();
            dgvsanpham = new DataGridView();
            groupBox1 = new GroupBox();
            dgvbaohanh = new DataGridView();
            btnUpdate = new Button();
            btnClean = new Button();
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
            button1 = new Button();
            btnClear.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvbaohanh).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Controls.Add(button1);
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
            btnClear.Location = new Point(9, 7);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(1250, 556);
            btnClear.TabIndex = 2;
            btnClear.TabStop = false;
            btnClear.Text = "Bảo Hành";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvsanpham);
            groupBox2.Location = new Point(494, 224);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(424, 220);
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
            dgvsanpham.Location = new Point(20, 20);
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
            dgvsanpham.Size = new Size(383, 182);
            dgvsanpham.TabIndex = 69;
            dgvsanpham.CellContentClick += dgvsanpham_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvbaohanh);
            groupBox1.Location = new Point(41, 224);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(424, 220);
            groupBox1.TabIndex = 80;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảo Hành";
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
            dgvbaohanh.Location = new Point(20, 20);
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
            dgvbaohanh.Size = new Size(383, 182);
            dgvbaohanh.TabIndex = 69;
            dgvbaohanh.CellContentClick += dgvbaohanh_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SkyBlue;
            btnUpdate.FlatAppearance.BorderColor = Color.Lavender;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(333, 157);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 25);
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
            btnClean.Location = new Point(438, 157);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 25);
            btnClean.TabIndex = 76;
            btnClean.Text = "Xóa";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // add
            // 
            add.BackColor = Color.SkyBlue;
            add.FlatAppearance.BorderColor = Color.Lavender;
            add.FlatAppearance.BorderSize = 2;
            add.FlatStyle = FlatStyle.Flat;
            add.ForeColor = SystemColors.ActiveCaptionText;
            add.Location = new Point(217, 157);
            add.Name = "add";
            add.Size = new Size(75, 25);
            add.TabIndex = 62;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click_1;
            // 
            // ngaykt
            // 
            ngaykt.Format = DateTimePickerFormat.Short;
            ngaykt.Location = new Point(450, 83);
            ngaykt.Name = "ngaykt";
            ngaykt.Size = new Size(193, 23);
            ngaykt.TabIndex = 74;
            // 
            // ngaybd
            // 
            ngaybd.Format = DateTimePickerFormat.Short;
            ngaybd.Location = new Point(450, 39);
            ngaybd.Name = "ngaybd";
            ngaybd.Size = new Size(193, 23);
            ngaybd.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(338, 87);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 67;
            label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(338, 43);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
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
            btnBack.Location = new Point(866, 638);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ime
            // 
            ime.Location = new Point(129, 83);
            ime.Name = "ime";
            ime.Size = new Size(193, 23);
            ime.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(17, 87);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "IMEI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(17, 43);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "ID bảo hành";
            // 
            // txtID
            // 
            txtID.Location = new Point(129, 39);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(193, 23);
            txtID.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1292, 610);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.FlatAppearance.BorderColor = Color.Lavender;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(539, 157);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 82;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BaoHanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 514);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BaoHanh";
            Text = "BaoHanh";
            Load += BaoHanh_Load;
            btnClear.ResumeLayout(false);
            btnClear.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvbaohanh).EndInit();
            panel1.ResumeLayout(false);
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
        private Button button1;
    }
}