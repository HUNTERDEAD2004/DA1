namespace PRL.View
{
    partial class RAM
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
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            RamSizeTxt = new TextBox();
            RamTypeTxt = new TextBox();
            RamIdTxt = new TextBox();
            groupBox2 = new GroupBox();
            DgvRAMShow = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvRAMShow).BeginInit();
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(RamSizeTxt);
            groupBox1.Controls.Add(RamTypeTxt);
            groupBox1.Controls.Add(RamIdTxt);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "RAM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SlateBlue;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(549, 60);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 51;
            label7.Text = "Create At";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SlateBlue;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(549, 131);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 50;
            label6.Text = "Update At";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.SlateBlue;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(358, 193);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 49;
            label9.Text = "Create By";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SlateBlue;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(612, 193);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 48;
            label8.Text = "Update By";
            // 
            // CBTxt
            // 
            CBTxt.Location = new Point(421, 190);
            CBTxt.Name = "CBTxt";
            CBTxt.Size = new Size(150, 23);
            CBTxt.TabIndex = 47;
            // 
            // UBTxt
            // 
            UBTxt.Location = new Point(683, 190);
            UBTxt.Name = "UBTxt";
            UBTxt.Size = new Size(150, 23);
            UBTxt.TabIndex = 46;
            // 
            // UATimePicker
            // 
            UATimePicker.Location = new Point(633, 125);
            UATimePicker.Name = "UATimePicker";
            UATimePicker.Size = new Size(200, 23);
            UATimePicker.TabIndex = 45;
            // 
            // CATimePicker
            // 
            CATimePicker.Location = new Point(633, 54);
            CATimePicker.Name = "CATimePicker";
            CATimePicker.Size = new Size(200, 23);
            CATimePicker.TabIndex = 44;
            // 
            // BtnSearch
            // 
            BtnSearch.ForeColor = SystemColors.ActiveCaptionText;
            BtnSearch.Location = new Point(874, 167);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(116, 41);
            BtnSearch.TabIndex = 43;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click_1;
            // 
            // SearchingTxt
            // 
            SearchingTxt.Location = new Point(874, 57);
            SearchingTxt.Multiline = true;
            SearchingTxt.Name = "SearchingTxt";
            SearchingTxt.Size = new Size(238, 27);
            SearchingTxt.TabIndex = 42;
            // 
            // BtnDelete
            // 
            BtnDelete.ForeColor = SystemColors.ActiveCaptionText;
            BtnDelete.Location = new Point(996, 110);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 41);
            BtnDelete.TabIndex = 41;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click_1;
            // 
            // BtnUpdate
            // 
            BtnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BtnUpdate.Location = new Point(996, 167);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(116, 41);
            BtnUpdate.TabIndex = 40;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click_1;
            // 
            // BtnAdd
            // 
            BtnAdd.ForeColor = SystemColors.ActiveCaptionText;
            BtnAdd.Location = new Point(874, 110);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(116, 41);
            BtnAdd.TabIndex = 39;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 17;
            label4.Text = "RamType";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(16, 194);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 15;
            label2.Text = "RamSize";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 54);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 14;
            label1.Text = "RamId";
            // 
            // RamSizeTxt
            // 
            RamSizeTxt.Location = new Point(73, 191);
            RamSizeTxt.Name = "RamSizeTxt";
            RamSizeTxt.Size = new Size(274, 23);
            RamSizeTxt.TabIndex = 11;
            // 
            // RamTypeTxt
            // 
            RamTypeTxt.Location = new Point(73, 122);
            RamTypeTxt.Name = "RamTypeTxt";
            RamTypeTxt.Size = new Size(274, 23);
            RamTypeTxt.TabIndex = 8;
            // 
            // RamIdTxt
            // 
            RamIdTxt.Location = new Point(73, 54);
            RamIdTxt.Name = "RamIdTxt";
            RamIdTxt.Size = new Size(274, 23);
            RamIdTxt.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvRAMShow);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(12, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1161, 322);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // DgvRAMShow
            // 
            DgvRAMShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRAMShow.Location = new Point(6, 22);
            DgvRAMShow.Name = "DgvRAMShow";
            DgvRAMShow.RowTemplate.Height = 25;
            DgvRAMShow.Size = new Size(1149, 294);
            DgvRAMShow.TabIndex = 0;
            DgvRAMShow.CellContentClick += DgvRAMShow_CellContentClick;
            // 
            // RAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1168, 583);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RAM";
            Text = "RAM";
            Load += RAM_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvRAMShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox RamSizeTxt;
        private TextBox RamTypeTxt;
        private TextBox RamIdTxt;
        private GroupBox groupBox2;
        private DataGridView DgvRAMShow;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private TextBox CBTxt;
        private TextBox UBTxt;
        private DateTimePicker UATimePicker;
        private DateTimePicker CATimePicker;
        private Button BtnSearch;
        private TextBox SearchingTxt;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnAdd;
    }
}