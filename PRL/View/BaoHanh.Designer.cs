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
<<<<<<< HEAD
            txtnguoithem = new TextBox();
            label3 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tensp = new TextBox();
            label7 = new Label();
            label8 = new Label();
            idsp = new TextBox();
            label6 = new Label();
=======
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            txtnguoisua = new TextBox();
            label9 = new Label();
=======
            button1 = new Button();
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            btnClear.Controls.Add(txtnguoisua);
            btnClear.Controls.Add(label9);
            btnClear.Controls.Add(txtnguoithem);
            btnClear.Controls.Add(label3);
            btnClear.Controls.Add(radioButton2);
            btnClear.Controls.Add(radioButton1);
            btnClear.Controls.Add(tensp);
            btnClear.Controls.Add(label7);
            btnClear.Controls.Add(label8);
            btnClear.Controls.Add(idsp);
            btnClear.Controls.Add(label6);
=======
            btnClear.Controls.Add(button1);
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            btnClear.Location = new Point(10, 9);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(3, 4, 3, 4);
            btnClear.Size = new Size(1428, 741);
            btnClear.TabIndex = 2;
            btnClear.TabStop = false;
            // 
            // txtnguoithem
            // 
            txtnguoithem.Location = new Point(514, 157);
            txtnguoithem.Margin = new Padding(3, 4, 3, 4);
            txtnguoithem.Name = "txtnguoithem";
            txtnguoithem.Size = new Size(220, 27);
            txtnguoithem.TabIndex = 93;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(386, 162);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 92;
            label3.Text = "Người thêm";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(656, 116);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 91;
            radioButton2.TabStop = true;
            radioButton2.Text = "hết bảo hành";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(516, 116);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(120, 24);
            radioButton1.TabIndex = 90;
            radioButton1.TabStop = true;
            radioButton1.Text = "còn bảo hành";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // tensp
            // 
            tensp.Location = new Point(147, 218);
            tensp.Margin = new Padding(3, 4, 3, 4);
            tensp.Name = "tensp";
            tensp.Size = new Size(220, 27);
            tensp.TabIndex = 89;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(19, 223);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 88;
            label7.Text = "Tên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(19, 164);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 87;
            label8.Text = "ID sản phẩm";
            // 
            // idsp
            // 
            idsp.Location = new Point(147, 159);
            idsp.Margin = new Padding(3, 4, 3, 4);
            idsp.Name = "idsp";
            idsp.ReadOnly = true;
            idsp.Size = new Size(220, 27);
            idsp.TabIndex = 86;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(388, 114);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 83;
            label6.Text = "Trạng thái";
=======
            btnClear.Location = new Point(9, 7);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(1250, 556);
            btnClear.TabIndex = 2;
            btnClear.TabStop = false;
            btnClear.Text = "Bảo Hành";
>>>>>>> An-DBNew
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvsanpham);
<<<<<<< HEAD
            groupBox2.Location = new Point(565, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 293);
=======
            groupBox2.Location = new Point(494, 224);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(424, 220);
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            dgvsanpham.Location = new Point(23, 27);
            dgvsanpham.Margin = new Padding(3, 4, 3, 4);
=======
            dgvsanpham.Location = new Point(20, 20);
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            dgvsanpham.Size = new Size(438, 243);
=======
            dgvsanpham.Size = new Size(383, 182);
>>>>>>> An-DBNew
            dgvsanpham.TabIndex = 69;
            dgvsanpham.CellContentClick += dgvsanpham_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvbaohanh);
<<<<<<< HEAD
            groupBox1.Location = new Point(47, 299);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 293);
=======
            groupBox1.Location = new Point(41, 224);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(424, 220);
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            dgvbaohanh.Location = new Point(23, 27);
            dgvbaohanh.Margin = new Padding(3, 4, 3, 4);
=======
            dgvbaohanh.Location = new Point(20, 20);
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            dgvbaohanh.Size = new Size(438, 243);
=======
            dgvbaohanh.Size = new Size(383, 182);
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            btnUpdate.Location = new Point(381, 259);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 33);
=======
            btnUpdate.Location = new Point(333, 157);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 25);
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            btnClean.Location = new Point(500, 259);
            btnClean.Margin = new Padding(3, 4, 3, 4);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(86, 33);
            btnClean.TabIndex = 76;
            btnClean.Text = "Clear";
=======
            btnClean.Location = new Point(438, 157);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 25);
            btnClean.TabIndex = 76;
            btnClean.Text = "Xóa";
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            add.Location = new Point(248, 259);
            add.Margin = new Padding(3, 4, 3, 4);
            add.Name = "add";
            add.Size = new Size(86, 33);
=======
            add.Location = new Point(217, 157);
            add.Name = "add";
            add.Size = new Size(75, 25);
>>>>>>> An-DBNew
            add.TabIndex = 62;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click_1;
            // 
            // ngaykt
            // 
            ngaykt.Format = DateTimePickerFormat.Short;
<<<<<<< HEAD
            ngaykt.Location = new Point(896, 57);
            ngaykt.Margin = new Padding(3, 4, 3, 4);
            ngaykt.Name = "ngaykt";
            ngaykt.Size = new Size(220, 27);
=======
            ngaykt.Location = new Point(450, 83);
            ngaykt.Name = "ngaykt";
            ngaykt.Size = new Size(193, 23);
>>>>>>> An-DBNew
            ngaykt.TabIndex = 74;
            // 
            // ngaybd
            // 
            ngaybd.Format = DateTimePickerFormat.Short;
<<<<<<< HEAD
            ngaybd.Location = new Point(514, 52);
            ngaybd.Margin = new Padding(3, 4, 3, 4);
            ngaybd.Name = "ngaybd";
            ngaybd.Size = new Size(220, 27);
=======
            ngaybd.Location = new Point(450, 39);
            ngaybd.Name = "ngaybd";
            ngaybd.Size = new Size(193, 23);
>>>>>>> An-DBNew
            ngaybd.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
<<<<<<< HEAD
            label4.Location = new Point(768, 62);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
=======
            label4.Location = new Point(338, 87);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
>>>>>>> An-DBNew
            label4.TabIndex = 67;
            label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
<<<<<<< HEAD
            label5.Location = new Point(386, 57);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
=======
            label5.Location = new Point(338, 43);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
>>>>>>> An-DBNew
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
<<<<<<< HEAD
            btnBack.Location = new Point(990, 851);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
=======
            btnBack.Location = new Point(866, 638);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
>>>>>>> An-DBNew
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ime
            // 
<<<<<<< HEAD
            ime.Location = new Point(147, 111);
            ime.Margin = new Padding(3, 4, 3, 4);
            ime.Name = "ime";
            ime.Size = new Size(220, 27);
=======
            ime.Location = new Point(129, 83);
            ime.Name = "ime";
            ime.Size = new Size(193, 23);
>>>>>>> An-DBNew
            ime.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
<<<<<<< HEAD
            label2.Location = new Point(19, 116);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
=======
            label2.Location = new Point(17, 87);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
>>>>>>> An-DBNew
            label2.TabIndex = 3;
            label2.Text = "IMEI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
<<<<<<< HEAD
            label1.Location = new Point(19, 57);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
=======
            label1.Location = new Point(17, 43);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
>>>>>>> An-DBNew
            label1.TabIndex = 1;
            label1.Text = "ID bảo hành";
            // 
            // txtID
            // 
<<<<<<< HEAD
            txtID.Location = new Point(147, 52);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(220, 27);
=======
            txtID.Location = new Point(129, 39);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(193, 23);
>>>>>>> An-DBNew
            txtID.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(btnClear);
<<<<<<< HEAD
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1477, 813);
            panel1.TabIndex = 1;
            // 
            // txtnguoisua
            // 
            txtnguoisua.Location = new Point(896, 157);
            txtnguoisua.Margin = new Padding(3, 4, 3, 4);
            txtnguoisua.Name = "txtnguoisua";
            txtnguoisua.Size = new Size(220, 27);
            txtnguoisua.TabIndex = 95;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(768, 162);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 94;
            label9.Text = "Người sửa";
            // 
            // BaoHanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 685);
            Controls.Add(panel1);
=======
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
>>>>>>> An-DBNew
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
<<<<<<< HEAD
=======
        private Label label2;
        private Label label1;
>>>>>>> An-DBNew
        private TextBox txtID;
        private Panel panel1;
        private GroupBox groupBox2;
        private DataGridView dgvsanpham;
        private GroupBox groupBox1;
<<<<<<< HEAD
        private TextBox tensp;
        private Label label7;
        private Label label8;
        private TextBox idsp;
        private Label label6;
        private Label label2;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txtnguoithem;
        private Label label3;
        private TextBox txtnguoisua;
        private Label label9;
=======
        private Button button1;
>>>>>>> An-DBNew
    }
}