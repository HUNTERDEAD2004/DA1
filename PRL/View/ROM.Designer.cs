namespace PRL.View
{
    partial class ROM
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
            DgvROMShow = new DataGridView();
            ROMIDTxt = new TextBox();
            ROMSizeTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
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
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvROMShow).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvROMShow);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(1, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1161, 322);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // DgvROMShow
            // 
            DgvROMShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvROMShow.Location = new Point(6, 22);
            DgvROMShow.Name = "DgvROMShow";
            DgvROMShow.RowTemplate.Height = 25;
            DgvROMShow.Size = new Size(1149, 294);
            DgvROMShow.TabIndex = 0;
            DgvROMShow.CellContentClick += DgvROMShow_CellContentClick;
            // 
            // ROMIDTxt
            // 
            ROMIDTxt.Location = new Point(107, 54);
            ROMIDTxt.Name = "ROMIDTxt";
            ROMIDTxt.Size = new Size(274, 23);
            ROMIDTxt.TabIndex = 7;
            // 
            // ROMSizeTxt
            // 
            ROMSizeTxt.Location = new Point(107, 107);
            ROMSizeTxt.Name = "ROMSizeTxt";
            ROMSizeTxt.Size = new Size(274, 23);
            ROMSizeTxt.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(21, 57);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 14;
            label1.Text = "ROMId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(11, 107);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 15;
            label2.Text = "ROMSize";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(ROMSizeTxt);
            groupBox1.Controls.Add(CBTxt);
            groupBox1.Controls.Add(ROMIDTxt);
            groupBox1.Controls.Add(UBTxt);
            groupBox1.Controls.Add(CATimePicker);
            groupBox1.Controls.Add(UATimePicker);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(BtnUpdate);
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(SearchingTxt);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(1, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ROM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SlateBlue;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(478, 60);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 50;
            label7.Text = "Create At";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SlateBlue;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(478, 131);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 49;
            label6.Text = "Update At";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SlateBlue;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(541, 193);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 48;
            label8.Text = "Update By";
            // 
            // CBTxt
            // 
            CBTxt.Location = new Point(350, 190);
            CBTxt.Name = "CBTxt";
            CBTxt.Size = new Size(150, 23);
            CBTxt.TabIndex = 47;
            // 
            // UBTxt
            // 
            UBTxt.Location = new Point(612, 190);
            UBTxt.Name = "UBTxt";
            UBTxt.Size = new Size(150, 23);
            UBTxt.TabIndex = 46;
            // 
            // UATimePicker
            // 
            UATimePicker.Location = new Point(562, 125);
            UATimePicker.Name = "UATimePicker";
            UATimePicker.Size = new Size(200, 23);
            UATimePicker.TabIndex = 45;
            // 
            // CATimePicker
            // 
            CATimePicker.Location = new Point(562, 54);
            CATimePicker.Name = "CATimePicker";
            CATimePicker.Size = new Size(200, 23);
            CATimePicker.TabIndex = 44;
            // 
            // BtnSearch
            // 
            BtnSearch.ForeColor = SystemColors.ActiveCaptionText;
            BtnSearch.Location = new Point(803, 167);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(116, 41);
            BtnSearch.TabIndex = 43;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // SearchingTxt
            // 
            SearchingTxt.Location = new Point(803, 57);
            SearchingTxt.Multiline = true;
            SearchingTxt.Name = "SearchingTxt";
            SearchingTxt.Size = new Size(238, 27);
            SearchingTxt.TabIndex = 42;
            // 
            // BtnDelete
            // 
            BtnDelete.ForeColor = SystemColors.ActiveCaptionText;
            BtnDelete.Location = new Point(925, 110);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 41);
            BtnDelete.TabIndex = 41;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BtnUpdate.Location = new Point(925, 167);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(116, 41);
            BtnUpdate.TabIndex = 40;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            BtnAdd.ForeColor = SystemColors.ActiveCaptionText;
            BtnAdd.Location = new Point(803, 110);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(116, 41);
            BtnAdd.TabIndex = 39;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            // 
            // ROM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1168, 566);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ROM";
            Text = "ROM";
            Load += ROM_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvROMShow).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView DgvROMShow;
        private TextBox ROMIDTxt;
        private TextBox ROMSizeTxt;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox CBTxt;
        private TextBox UBTxt;
        private DateTimePicker CATimePicker;
        private DateTimePicker UATimePicker;
        private Button BtnAdd;
        private Button BtnUpdate;
        private Button BtnSearch;
        private Button BtnDelete;
        private TextBox SearchingTxt;
    }
}