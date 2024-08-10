namespace PRL.View
{
    partial class GPU
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
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            CBTxt = new TextBox();
            UBTxt = new TextBox();
            UATimePicker = new DateTimePicker();
            CATimePicker = new DateTimePicker();
            BtnSearch = new Button();
            SearchingTxt = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnAdd = new Button();
            GpuMemoryTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GpuNameTxt = new TextBox();
            GpuIdTxt = new TextBox();
            groupBox2 = new GroupBox();
            DgvGPUShow = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvGPUShow).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(CBTxt);
            groupBox1.Controls.Add(UBTxt);
            groupBox1.Controls.Add(UATimePicker);
            groupBox1.Controls.Add(CATimePicker);
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(SearchingTxt);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnUpdate);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(GpuMemoryTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(GpuNameTxt);
            groupBox1.Controls.Add(GpuIdTxt);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 232);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ROM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SlateBlue;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(559, 57);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 38;
            label7.Text = "Create At";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SlateBlue;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(559, 128);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 37;
            label6.Text = "Update At";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.SlateBlue;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(368, 190);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 36;
            label9.Text = "Create By";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SlateBlue;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(622, 190);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 35;
            label8.Text = "Update By";
            // 
            // CBTxt
            // 
            CBTxt.Location = new Point(431, 187);
            CBTxt.Name = "CBTxt";
            CBTxt.Size = new Size(150, 23);
            CBTxt.TabIndex = 34;
            // 
            // UBTxt
            // 
            UBTxt.Location = new Point(693, 187);
            UBTxt.Name = "UBTxt";
            UBTxt.Size = new Size(150, 23);
            UBTxt.TabIndex = 33;
            // 
            // UATimePicker
            // 
            UATimePicker.Location = new Point(643, 122);
            UATimePicker.Name = "UATimePicker";
            UATimePicker.Size = new Size(200, 23);
            UATimePicker.TabIndex = 32;
            // 
            // CATimePicker
            // 
            CATimePicker.Location = new Point(643, 51);
            CATimePicker.Name = "CATimePicker";
            CATimePicker.Size = new Size(200, 23);
            CATimePicker.TabIndex = 31;
            // 
            // BtnSearch
            // 
            BtnSearch.ForeColor = SystemColors.ActiveCaptionText;
            BtnSearch.Location = new Point(884, 164);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(116, 41);
            BtnSearch.TabIndex = 29;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click_1;
            // 
            // SearchingTxt
            // 
            SearchingTxt.Location = new Point(884, 54);
            SearchingTxt.Multiline = true;
            SearchingTxt.Name = "SearchingTxt";
            SearchingTxt.Size = new Size(238, 27);
            SearchingTxt.TabIndex = 28;
            // 
            // BtnDelete
            // 
            BtnDelete.ForeColor = SystemColors.ActiveCaptionText;
            BtnDelete.Location = new Point(1006, 107);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 41);
            BtnDelete.TabIndex = 27;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click_1;
            // 
            // BtnUpdate
            // 
            BtnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BtnUpdate.Location = new Point(1006, 164);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(116, 41);
            BtnUpdate.TabIndex = 26;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click_1;
            // 
            // BtnAdd
            // 
            BtnAdd.ForeColor = SystemColors.ActiveCaptionText;
            BtnAdd.Location = new Point(884, 107);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(116, 41);
            BtnAdd.TabIndex = 25;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click_1;
            // 
            // GpuMemoryTxt
            // 
            GpuMemoryTxt.Location = new Point(101, 117);
            GpuMemoryTxt.Name = "GpuMemoryTxt";
            GpuMemoryTxt.Size = new Size(177, 23);
            GpuMemoryTxt.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 21;
            label3.Text = "GPUMemory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(20, 190);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 15;
            label2.Text = "GPUName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(20, 57);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 14;
            label1.Text = "GPUId";
            // 
            // GpuNameTxt
            // 
            GpuNameTxt.Location = new Point(101, 187);
            GpuNameTxt.Name = "GpuNameTxt";
            GpuNameTxt.Size = new Size(177, 23);
            GpuNameTxt.TabIndex = 11;
            // 
            // GpuIdTxt
            // 
            GpuIdTxt.Location = new Point(101, 57);
            GpuIdTxt.Name = "GpuIdTxt";
            GpuIdTxt.Size = new Size(177, 23);
            GpuIdTxt.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvGPUShow);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(12, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1161, 322);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // DgvGPUShow
            // 
            DgvGPUShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvGPUShow.Location = new Point(6, 22);
            DgvGPUShow.Name = "DgvGPUShow";
            DgvGPUShow.RowTemplate.Height = 25;
            DgvGPUShow.Size = new Size(1149, 294);
            DgvGPUShow.TabIndex = 0;
            DgvGPUShow.CellContentClick += DgvGPUShow_CellContentClick;
            // 
            // GPU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1182, 581);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GPU";
            Text = "GPU";
            Load += GPU_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvGPUShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox GpuNameTxt;
        private TextBox GpuIdTxt;
        private GroupBox groupBox2;
        private DataGridView DgvGPUShow;
        private TextBox GpuMemoryTxt;
        private Label label3;
        private DateTimePicker UATimePicker;
        private DateTimePicker CATimePicker;
        private Button BtnSearch;
        private TextBox SearchingTxt;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnAdd;
        private Label label9;
        private Label label8;
        private TextBox CBTxt;
        private TextBox UBTxt;
        private Label label7;
        private Label label6;
    }
}