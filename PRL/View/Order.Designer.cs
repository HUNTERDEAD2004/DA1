namespace PRL.View
{
    partial class Order
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
            groupBox2 = new GroupBox();
            dgvHDCT = new DataGridView();
            groupBox1 = new GroupBox();
            dgvHD = new DataGridView();
            label10 = new Label();
            txtMSP = new TextBox();
            button5 = new Button();
            label9 = new Label();
            txtHDCT = new TextBox();
            RBCTT = new RadioButton();
            RBDTT = new RadioButton();
            button4 = new Button();
            label7 = new Label();
            txtTK = new TextBox();
            button3 = new Button();
            button2 = new Button();
            DTPVC = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            txtGia = new TextBox();
            label4 = new Label();
            txtSL = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtSZ = new TextBox();
            label1 = new Label();
            txtSP = new TextBox();
            panel1 = new Panel();
            btnSearch = new FontAwesome.Sharp.IconButton();
<<<<<<< HEAD:PRL/View/Order.Designer.cs
=======
            txtTG = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
>>>>>>> An-DBNew:PRL/View/Orderform.Designer.cs
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.SlateBlue;
            groupBox2.Controls.Add(dgvHDCT);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(425, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 321);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // dgvHDCT
            // 
            dgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDCT.Location = new Point(17, 22);
            dgvHDCT.Name = "dgvHDCT";
            dgvHDCT.RowHeadersWidth = 51;
            dgvHDCT.RowTemplate.Height = 25;
            dgvHDCT.Size = new Size(470, 287);
            dgvHDCT.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(dgvHD);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(6, 367);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 225);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // dgvHD
            // 
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Location = new Point(6, 22);
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(906, 197);
            dgvHD.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.SlateBlue;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(6, 13);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 63;
            label10.Text = "Mã Sản Phẩm";
            // 
            // txtMSP
            // 
            txtMSP.Location = new Point(110, 10);
            txtMSP.Name = "txtMSP";
            txtMSP.Size = new Size(298, 23);
            txtMSP.TabIndex = 62;
            // 
            // button5
            // 
            button5.Location = new Point(342, 339);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 61;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.SlateBlue;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(6, 49);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 60;
            label9.Text = "Mã Hóa đơn CT";
            // 
            // txtHDCT
            // 
            txtHDCT.Location = new Point(110, 46);
            txtHDCT.Name = "txtHDCT";
            txtHDCT.Size = new Size(298, 23);
            txtHDCT.TabIndex = 59;
            // 
            // RBCTT
            // 
            RBCTT.AutoSize = true;
            RBCTT.BackColor = Color.SlateBlue;
            RBCTT.ForeColor = SystemColors.ButtonHighlight;
            RBCTT.Location = new Point(255, 300);
            RBCTT.Name = "RBCTT";
            RBCTT.Size = new Size(108, 19);
            RBCTT.TabIndex = 58;
            RBCTT.TabStop = true;
            RBCTT.Text = "Chờ thanh toán";
            RBCTT.UseVisualStyleBackColor = false;
            // 
            // RBDTT
            // 
            RBDTT.AutoSize = true;
            RBDTT.BackColor = Color.SlateBlue;
            RBDTT.ForeColor = SystemColors.ButtonHighlight;
            RBDTT.Location = new Point(110, 300);
            RBDTT.Name = "RBDTT";
            RBDTT.Size = new Size(100, 19);
            RBDTT.TabIndex = 57;
            RBDTT.TabStop = true;
            RBDTT.Text = "Đã thanh toán";
            RBDTT.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(144, 338);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 56;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SlateBlue;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(473, 346);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 55;
            label7.Text = "Tìm kiếm";
            // 
            // txtTK
            // 
            txtTK.Location = new Point(533, 339);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(298, 23);
            txtTK.TabIndex = 54;
            // 
            // button3
            // 
            button3.Location = new Point(241, 338);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 53;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(45, 338);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 52;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = true;
            // 
            // DTPVC
            // 
            DTPVC.CustomFormat = "";
            DTPVC.Format = DateTimePickerFormat.Short;
            DTPVC.Location = new Point(110, 172);
            DTPVC.Margin = new Padding(3, 2, 3, 2);
            DTPVC.Name = "DTPVC";
            DTPVC.Size = new Size(220, 23);
            DTPVC.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SlateBlue;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(6, 304);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 50;
            label6.Text = "Trạng thái";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SlateBlue;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(6, 261);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 49;
            label5.Text = "Giá";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(110, 253);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(298, 23);
            txtGia.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SlateBlue;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(6, 220);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 47;
            label4.Text = "Số lượng Mua";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(110, 212);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(298, 23);
            txtSL.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SlateBlue;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(6, 178);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 45;
            label3.Text = "HSDVoucher";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SlateBlue;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(6, 135);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 44;
            label2.Text = "MenhGiaVoucher";
            // 
            // txtSZ
            // 
            txtSZ.Location = new Point(110, 132);
            txtSZ.Name = "txtSZ";
            txtSZ.Size = new Size(298, 23);
            txtSZ.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateBlue;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 93);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 42;
            label1.Text = "Tên sản phẩm";
            // 
            // txtSP
            // 
            txtSP.Location = new Point(110, 90);
            txtSP.Name = "txtSP";
            txtSP.Size = new Size(298, 23);
            txtSP.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label7);
<<<<<<< HEAD:PRL/View/Order.Designer.cs
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(-2, -3);
=======
            panel1.Controls.Add(txtGia);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(bttXoa);
            panel1.Controls.Add(txtSL);
            panel1.Controls.Add(txtTK);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RBCTT);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bttCL);
            panel1.Controls.Add(txtSZ);
            panel1.Controls.Add(RBDTT);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtSP);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(bttSua);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-2, -6);
>>>>>>> An-DBNew:PRL/View/Orderform.Designer.cs
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 917);
            panel1.TabIndex = 70;
            // 
            // btnSearch
            // 
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 17;
            btnSearch.Location = new Point(839, 342);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(37, 23);
            btnSearch.TabIndex = 56;
            btnSearch.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD:PRL/View/Order.Designer.cs
            // Order
=======
            // txtTG
            // 
            txtTG.Location = new Point(112, 329);
            txtTG.Name = "txtTG";
            txtTG.ReadOnly = true;
            txtTG.Size = new Size(298, 23);
            txtTG.TabIndex = 71;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // Orderform
>>>>>>> An-DBNew:PRL/View/Orderform.Designer.cs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 602);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(txtMSP);
            Controls.Add(button5);
            Controls.Add(label9);
            Controls.Add(txtHDCT);
            Controls.Add(RBCTT);
            Controls.Add(RBDTT);
            Controls.Add(button4);
            Controls.Add(txtTK);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(DTPVC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtGia);
            Controls.Add(label4);
            Controls.Add(txtSL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSZ);
            Controls.Add(label1);
            Controls.Add(txtSP);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Order";
            Text = "Order";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dgvHDCT;
        private GroupBox groupBox1;
        private DataGridView dgvHD;
        private Label label10;
        private TextBox txtMSP;
        private Button button5;
        private Label label9;
        private TextBox txtHDCT;
        private RadioButton RBCTT;
        private RadioButton RBDTT;
        private Button button4;
        private Label label7;
        private TextBox txtTK;
        private Button button3;
        private Button button2;
        private DateTimePicker DTPVC;
        private Label label6;
        private Label label5;
        private TextBox txtGia;
        private Label label4;
        private TextBox txtSL;
        private Label label3;
        private Label label2;
        private TextBox txtSZ;
        private Label label1;
        private TextBox txtSP;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnSearch;
<<<<<<< HEAD:PRL/View/Order.Designer.cs
=======
        private Label label8;
        private TextBox txtTG;
        private TextBox txtimei;
        private Label label11;
        private Button bttHDT;
        private Button bttCHD;
        private TextBox txtHDHT;
        private DataGridView dgvHD;
        private Button bttCheck;
        private Button bttHDCT;
        private GroupBox groupBox3;
        private Button bttRL;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
>>>>>>> An-DBNew:PRL/View/Orderform.Designer.cs
    }
}