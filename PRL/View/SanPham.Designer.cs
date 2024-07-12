namespace PRL.View
{
    partial class SanPham
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
            button1 = new Button();
            txtTimKiemSP = new TextBox();
            btnTimKiemSP = new Button();
            dgvSP = new DataGridView();
            groupBox1 = new GroupBox();
            txtMaNSX = new ComboBox();
            txtChatLieu = new ComboBox();
            txtSize = new ComboBox();
            btnXoa = new Button();
            txtVC = new TextBox();
            txtTien = new TextBox();
            txtSoLuong = new TextBox();
            label8 = new Label();
            txtSPCT = new TextBox();
            txtGia = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            btnThem = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtTenSanPham = new TextBox();
            txtMaSP = new TextBox();
            button4 = new Button();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtTimKiemSP);
            groupBox2.Controls.Add(btnTimKiemSP);
            groupBox2.Controls.Add(dgvSP);
            groupBox2.Location = new Point(79, 504);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(761, 293);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // button1
            // 
            button1.Location = new Point(671, 34);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "CTSP";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.Location = new Point(18, 39);
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.Size = new Size(523, 27);
            txtTimKiemSP.TabIndex = 1;
            // 
            // btnTimKiemSP
            // 
            btnTimKiemSP.BackColor = SystemColors.ButtonHighlight;
            btnTimKiemSP.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiemSP.Location = new Point(549, 38);
            btnTimKiemSP.Name = "btnTimKiemSP";
            btnTimKiemSP.Size = new Size(115, 27);
            btnTimKiemSP.TabIndex = 0;
            btnTimKiemSP.Text = "TÌm kiếm";
            btnTimKiemSP.UseVisualStyleBackColor = false;
            // 
            // dgvSP
            // 
            dgvSP.AllowUserToAddRows = false;
            dgvSP.AllowUserToDeleteRows = false;
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(18, 80);
            dgvSP.Name = "dgvSP";
            dgvSP.ReadOnly = true;
            dgvSP.RowHeadersWidth = 51;
            dgvSP.RowTemplate.Height = 29;
            dgvSP.Size = new Size(723, 187);
            dgvSP.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtMaNSX);
            groupBox1.Controls.Add(txtChatLieu);
            groupBox1.Controls.Add(txtSize);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtVC);
            groupBox1.Controls.Add(txtTien);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSPCT);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(79, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 473);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // txtMaNSX
            // 
            txtMaNSX.FormattingEnabled = true;
            txtMaNSX.Items.AddRange(new object[] { "Bandai", "GoodSmile", "MegaHouse" });
            txtMaNSX.Location = new Point(133, 100);
            txtMaNSX.Name = "txtMaNSX";
            txtMaNSX.Size = new Size(487, 28);
            txtMaNSX.TabIndex = 3;
            // 
            // txtChatLieu
            // 
            txtChatLieu.FormattingEnabled = true;
            txtChatLieu.Items.AddRange(new object[] { "Nhua Resin", "Go", "Giay" });
            txtChatLieu.Location = new Point(133, 197);
            txtChatLieu.Name = "txtChatLieu";
            txtChatLieu.Size = new Size(487, 28);
            txtChatLieu.TabIndex = 3;
            // 
            // txtSize
            // 
            txtSize.FormattingEnabled = true;
            txtSize.Items.AddRange(new object[] { "24cm", "27cm", "30cm" });
            txtSize.Location = new Point(133, 162);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(487, 28);
            txtSize.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(643, 179);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(104, 43);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtVC
            // 
            txtVC.Location = new Point(133, 297);
            txtVC.Name = "txtVC";
            txtVC.Size = new Size(487, 27);
            txtVC.TabIndex = 1;
            // 
            // txtTien
            // 
            txtTien.Location = new Point(133, 264);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(487, 27);
            txtTien.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(133, 231);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(487, 27);
            txtSoLuong.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 300);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 2;
            label8.Text = "CPU";
            // 
            // txtSPCT
            // 
            txtSPCT.Location = new Point(133, 133);
            txtSPCT.Name = "txtSPCT";
            txtSPCT.Size = new Size(487, 27);
            txtSPCT.TabIndex = 1;
            // 
            // txtGia
            // 
            txtGia.AutoSize = true;
            txtGia.Location = new Point(19, 267);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(64, 20);
            txtGia.TabIndex = 2;
            txtGia.Text = "Phụ kiện";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 133);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 2;
            label6.Text = "Giá";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 231);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 2;
            label7.Text = "Màu sắc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 196);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "CategoryID";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(643, 88);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 43);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 165);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 2;
            label4.Text = "Mô tả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 67);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 2;
            label5.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "ProductID";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(133, 69);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(487, 27);
            txtTenSanPham.TabIndex = 1;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(133, 38);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(487, 27);
            txtMaSP.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(402, 171);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 330);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 27);
            textBox1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 333);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 5;
            label9.Text = "Hệ điêu hành";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 363);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(487, 27);
            textBox2.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 366);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 7;
            label10.Text = "Nguồn gốc";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 396);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(487, 27);
            textBox3.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 399);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 9;
            label11.Text = "Dung lượng pin";
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 809);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SanPham";
            Text = "SanPham";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button button1;
        private TextBox txtTimKiemSP;
        private Button btnTimKiemSP;
        private DataGridView dgvSP;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label11;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox1;
        private Label label9;
        private ComboBox txtMaNSX;
        private ComboBox txtChatLieu;
        private ComboBox txtSize;
        private Button btnXoa;
        private TextBox txtVC;
        private TextBox txtTien;
        private TextBox txtSoLuong;
        private Label label8;
        private TextBox txtSPCT;
        private Label txtGia;
        private Label label6;
        private Label label7;
        private Label label2;
        private Button btnThem;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtTenSanPham;
        private TextBox txtMaSP;
        private Button button4;
    }
}