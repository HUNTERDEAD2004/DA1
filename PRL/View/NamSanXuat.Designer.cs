﻿namespace PRL.View
{
    partial class NamSanXuat
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
            DgvYearShow = new DataGridView();
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
            YearTxt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            YearIdTxt = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvYearShow).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvYearShow);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(11, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1161, 322);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // DgvYearShow
            // 
            DgvYearShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvYearShow.Location = new Point(6, 22);
            DgvYearShow.Name = "DgvYearShow";
            DgvYearShow.RowTemplate.Height = 25;
            DgvYearShow.Size = new Size(1149, 294);
            DgvYearShow.TabIndex = 0;
            DgvYearShow.CellContentClick += DgvYearShow_CellContentClick;
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
            groupBox1.Controls.Add(YearTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(YearIdTxt);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(11, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 232);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "OS";
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
            BtnSearch.Click += BtnSearch_Click;
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
            BtnDelete.Click += BtnDelete_Click;
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
            BtnUpdate.Click += BtnUpdate_Click;
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
            BtnAdd.Click += BtnAdd_Click;
            // 
            // YearTxt
            // 
            YearTxt.Location = new Point(101, 117);
            YearTxt.Name = "YearTxt";
            YearTxt.Size = new Size(177, 23);
            YearTxt.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 21;
            label3.Text = "Year";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(20, 57);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "YearId";
            // 
            // YearIdTxt
            // 
            YearIdTxt.Location = new Point(101, 57);
            YearIdTxt.Name = "YearIdTxt";
            YearIdTxt.Size = new Size(177, 23);
            YearIdTxt.TabIndex = 7;
            // 
            // NamSanXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1182, 581);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NamSanXuat";
            Text = "NamSanXuat";
            Load += NamSanXuat_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvYearShow).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView DgvYearShow;
        private GroupBox groupBox1;
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
        private TextBox YearTxt;
        private Label label3;
        private Label label1;
        private TextBox YearIdTxt;
    }
}