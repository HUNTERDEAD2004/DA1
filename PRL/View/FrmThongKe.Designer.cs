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
            btn_xuat = new Button();
            btn_thongKe = new Button();
            dtgv_show = new DataGridView();
            panel5 = new Panel();
            lb_khachhang = new Label();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_show).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_xuat);
            groupBox1.Controls.Add(btn_thongKe);
            groupBox1.Controls.Add(dtgv_show);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 284);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1141, 377);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // btn_xuat
            // 
            btn_xuat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xuat.Location = new Point(925, 27);
            btn_xuat.Name = "btn_xuat";
            btn_xuat.Size = new Size(198, 49);
            btn_xuat.TabIndex = 7;
            btn_xuat.Text = "Xuất Excel";
            btn_xuat.UseVisualStyleBackColor = true;
            // 
            // btn_thongKe
            // 
            btn_thongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thongKe.Location = new Point(745, 27);
            btn_thongKe.Name = "btn_thongKe";
            btn_thongKe.Size = new Size(142, 51);
            btn_thongKe.TabIndex = 6;
            btn_thongKe.Text = "Thống Kê";
            btn_thongKe.UseVisualStyleBackColor = true;
            btn_thongKe.Click += btn_thongKe_Click;
            // 
            // dtgv_show
            // 
            dtgv_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_show.Dock = DockStyle.Bottom;
            dtgv_show.Location = new Point(3, 84);
            dtgv_show.Name = "dtgv_show";
            dtgv_show.RowHeadersWidth = 51;
            dtgv_show.RowTemplate.Height = 29;
            dtgv_show.Size = new Size(1135, 289);
            dtgv_show.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCyan;
            panel5.Controls.Add(lb_khachhang);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(718, 6);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(186, 113);
            panel5.TabIndex = 22;
            // 
            // lb_khachhang
            // 
            lb_khachhang.AutoSize = true;
            lb_khachhang.Location = new Point(41, 76);
            lb_khachhang.Name = "lb_khachhang";
            lb_khachhang.Size = new Size(17, 20);
            lb_khachhang.TabIndex = 4;
            lb_khachhang.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 23);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 3;
            label5.Text = "Tổng khách hàng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(lb_tonghd);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(424, 6);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 113);
            panel3.TabIndex = 24;
            // 
            // lb_tonghd
            // 
            lb_tonghd.AutoSize = true;
            lb_tonghd.Location = new Point(39, 76);
            lb_tonghd.Name = "lb_tonghd";
            lb_tonghd.Size = new Size(17, 20);
            lb_tonghd.TabIndex = 2;
            lb_tonghd.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 23);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 1;
            label3.Text = "Số hóa đơn";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lb_doanhthu);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(129, 6);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 113);
            panel2.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(138, 76);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 2;
            label10.Text = "VNĐ";
            // 
            // lb_doanhthu
            // 
            lb_doanhthu.AutoSize = true;
            lb_doanhthu.Location = new Point(41, 76);
            lb_doanhthu.Name = "lb_doanhthu";
            lb_doanhthu.Size = new Size(17, 20);
            lb_doanhthu.TabIndex = 1;
            lb_doanhthu.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 23);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 0;
            label2.Text = "Doanh thu";
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(733, 152);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(137, 27);
            dateTimeEnd.TabIndex = 26;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Location = new Point(439, 155);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(149, 27);
            dateTimeStart.TabIndex = 27;
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(158, 154);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(125, 28);
            cmbTime.TabIndex = 28;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 661);
            Controls.Add(cmbTime);
            Controls.Add(dateTimeStart);
            Controls.Add(dateTimeEnd);
            Controls.Add(groupBox1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
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
        private DataGridView dtgv_show;
        private Panel panel5;
        private Label lb_khachhang;
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
    }
}