namespace PRL.View
{
    partial class FrmThongKe
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
            groupBox1 = new GroupBox();
            dtgv_show = new DataGridView();
            btn_xuat = new Button();
            btn_thongKe = new Button();
            panel5 = new Panel();
            lb_hdtt = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lb_tonghd = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            lb_doanhthu = new Label();
            label2 = new Label();
            dateTimeEnd = new DateTimePicker();
            dateTimeStart = new DateTimePicker();
            cmbTime = new ComboBox();
            btn_chitiet = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_show).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgv_show);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1062, 246);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // dtgv_show
            // 
            dtgv_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgv_show.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgv_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_show.Location = new Point(40, 22);
            dtgv_show.Margin = new Padding(3, 2, 3, 2);
            dtgv_show.Name = "dtgv_show";
            dtgv_show.RowHeadersWidth = 51;
            dtgv_show.RowTemplate.Height = 29;
            dtgv_show.Size = new Size(965, 201);
            dtgv_show.TabIndex = 0;
            // 
            // btn_xuat
            // 
            btn_xuat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xuat.Location = new Point(858, 210);
            btn_xuat.Margin = new Padding(3, 2, 3, 2);
            btn_xuat.Name = "btn_xuat";
            btn_xuat.Size = new Size(173, 37);
            btn_xuat.TabIndex = 7;
            btn_xuat.Text = "Xuất Excel";
            btn_xuat.UseVisualStyleBackColor = true;
            btn_xuat.Click += btn_xuat_Click;
            // 
            // btn_thongKe
            // 
            btn_thongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thongKe.Location = new Point(688, 208);
            btn_thongKe.Margin = new Padding(3, 2, 3, 2);
            btn_thongKe.Name = "btn_thongKe";
            btn_thongKe.Size = new Size(124, 38);
            btn_thongKe.TabIndex = 6;
            btn_thongKe.Text = "Thống Kê";
            btn_thongKe.UseVisualStyleBackColor = true;
            btn_thongKe.Click += btn_thongKe_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCyan;
            panel5.Controls.Add(lb_hdtt);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(628, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 85);
            panel5.TabIndex = 22;
            // 
            // lb_hdtt
            // 
            lb_hdtt.AutoSize = true;
            lb_hdtt.Location = new Point(91, 57);
            lb_hdtt.Name = "lb_hdtt";
            lb_hdtt.Size = new Size(13, 15);
            lb_hdtt.TabIndex = 4;
            lb_hdtt.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 17);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 3;
            label5.Text = "Hóa Đơn Đã Thanh Toán";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(lb_tonghd);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(371, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 85);
            panel3.TabIndex = 24;
            // 
            // lb_tonghd
            // 
            lb_tonghd.AutoSize = true;
            lb_tonghd.Location = new Point(81, 57);
            lb_tonghd.Name = "lb_tonghd";
            lb_tonghd.Size = new Size(13, 15);
            lb_tonghd.TabIndex = 2;
            lb_tonghd.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 17);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 1;
            label3.Text = "Số hóa đơn";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lb_doanhthu);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(113, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 85);
            panel2.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(121, 57);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 2;
            label10.Text = "VNĐ";
            // 
            // lb_doanhthu
            // 
            lb_doanhthu.AutoSize = true;
            lb_doanhthu.Location = new Point(36, 57);
            lb_doanhthu.Name = "lb_doanhthu";
            lb_doanhthu.Size = new Size(13, 15);
            lb_doanhthu.TabIndex = 1;
            lb_doanhthu.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 17);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Doanh thu";
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(641, 114);
            dateTimeEnd.Margin = new Padding(3, 2, 3, 2);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(120, 23);
            dateTimeEnd.TabIndex = 26;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Location = new Point(384, 116);
            dateTimeStart.Margin = new Padding(3, 2, 3, 2);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(131, 23);
            dateTimeStart.TabIndex = 27;
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(138, 116);
            cmbTime.Margin = new Padding(3, 2, 3, 2);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(110, 23);
            cmbTime.TabIndex = 28;
            // 
            // btn_chitiet
            // 
            btn_chitiet.ImageAlign = ContentAlignment.MiddleLeft;
            btn_chitiet.Location = new Point(509, 208);
            btn_chitiet.Margin = new Padding(3, 2, 3, 2);
            btn_chitiet.Name = "btn_chitiet";
            btn_chitiet.Size = new Size(124, 38);
            btn_chitiet.TabIndex = 29;
            btn_chitiet.Text = "Chi tiết hóa đơn";
            btn_chitiet.UseVisualStyleBackColor = true;
            btn_chitiet.Click += btn_chitiet_Click;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1062, 490);
            Controls.Add(btn_chitiet);
            Controls.Add(btn_xuat);
            Controls.Add(cmbTime);
            Controls.Add(btn_thongKe);
            Controls.Add(dateTimeStart);
            Controls.Add(dateTimeEnd);
            Controls.Add(groupBox1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            Load += FrmThongKe_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_show).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_xuat;
        private Button btn_thongKe;
        private Panel panel5;
        private Label lb_hdtt;
        private Label label5;
        private Panel panel3;
        private Label lb_tonghd;
        private Label label3;
        private Panel panel2;
        private Label label10;
        private Label lb_doanhthu;
        private Label label2;
        private DateTimePicker dateTimeEnd;
        private DateTimePicker dateTimeStart;
        private ComboBox cmbTime;
        private DataGridView dtgv_show;
        private Button btn_chitiet;
    }
}