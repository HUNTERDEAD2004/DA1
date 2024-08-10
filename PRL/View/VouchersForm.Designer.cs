namespace PRL.View
{
    partial class VouchersForm
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
            txtID = new TextBox();
            labtc = new Label();
            label2 = new Label();
            txtDis = new TextBox();
            min = new Label();
            txtMin = new TextBox();
            dtpED = new DateTimePicker();
            lab = new Label();
            dgvVC = new DataGridView();
            bttXoa = new Button();
            bttClear = new Button();
            bttThem = new Button();
            bttSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVC).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(70, 25);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(265, 23);
            txtID.TabIndex = 0;
            // 
            // labtc
            // 
            labtc.AutoSize = true;
            labtc.ForeColor = SystemColors.ControlLightLight;
            labtc.Location = new Point(14, 28);
            labtc.Name = "labtc";
            labtc.Size = new Size(18, 15);
            labtc.TabIndex = 1;
            labtc.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(14, 67);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Discount";
            // 
            // txtDis
            // 
            txtDis.Location = new Point(70, 64);
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(265, 23);
            txtDis.TabIndex = 2;
            // 
            // min
            // 
            min.AutoSize = true;
            min.ForeColor = SystemColors.ControlLightLight;
            min.Location = new Point(625, 28);
            min.Name = "min";
            min.Size = new Size(79, 15);
            min.TabIndex = 5;
            min.Text = "Minium_Total";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(710, 25);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(265, 23);
            txtMin.TabIndex = 4;
            // 
            // dtpED
            // 
            dtpED.Location = new Point(710, 59);
            dtpED.Name = "dtpED";
            dtpED.Size = new Size(200, 23);
            dtpED.TabIndex = 6;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.ForeColor = SystemColors.ControlLightLight;
            lab.Location = new Point(625, 64);
            lab.Name = "lab";
            lab.Size = new Size(75, 15);
            lab.TabIndex = 7;
            lab.Text = "Expired_Date";
            // 
            // dgvVC
            // 
            dgvVC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVC.Location = new Point(14, 137);
            dgvVC.Name = "dgvVC";
            dgvVC.RowTemplate.Height = 25;
            dgvVC.Size = new Size(981, 259);
            dgvVC.TabIndex = 8;
            dgvVC.CellContentClick += dgvVC_CellContentClick;
            // 
            // bttXoa
            // 
            bttXoa.ForeColor = SystemColors.ActiveCaptionText;
            bttXoa.Location = new Point(908, 109);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(75, 23);
            bttXoa.TabIndex = 65;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += bttXoa_Click;
            // 
            // bttClear
            // 
            bttClear.ForeColor = SystemColors.ActiveCaptionText;
            bttClear.Location = new Point(710, 108);
            bttClear.Name = "bttClear";
            bttClear.Size = new Size(75, 23);
            bttClear.TabIndex = 64;
            bttClear.Text = "Clear";
            bttClear.UseVisualStyleBackColor = true;
            bttClear.Click += bttClear_Click;
            // 
            // bttThem
            // 
            bttThem.ForeColor = SystemColors.ActiveCaptionText;
            bttThem.Location = new Point(611, 108);
            bttThem.Name = "bttThem";
            bttThem.Size = new Size(75, 23);
            bttThem.TabIndex = 62;
            bttThem.Text = "Thêm";
            bttThem.UseVisualStyleBackColor = true;
            bttThem.Click += bttThem_Click;
            // 
            // bttSua
            // 
            bttSua.ForeColor = SystemColors.ActiveCaptionText;
            bttSua.Location = new Point(807, 108);
            bttSua.Name = "bttSua";
            bttSua.Size = new Size(75, 23);
            bttSua.TabIndex = 63;
            bttSua.Text = "Sửa";
            bttSua.UseVisualStyleBackColor = true;
            bttSua.Click += bttSua_Click;
            // 
            // VouchersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1479, 676);
            Controls.Add(bttXoa);
            Controls.Add(bttClear);
            Controls.Add(bttThem);
            Controls.Add(bttSua);
            Controls.Add(dgvVC);
            Controls.Add(lab);
            Controls.Add(dtpED);
            Controls.Add(min);
            Controls.Add(txtMin);
            Controls.Add(label2);
            Controls.Add(txtDis);
            Controls.Add(labtc);
            Controls.Add(txtID);
            Name = "VouchersForm";
            Text = "VouchersForm";
            Load += VouchersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label labtc;
        private Label label2;
        private TextBox txtDis;
        private Label min;
        private TextBox txtMin;
        private DateTimePicker dtpED;
        private Label lab;
        private DataGridView dgvVC;
        private Button bttXoa;
        private Button bttClear;
        private Button bttThem;
        private Button bttSua;
    }
}