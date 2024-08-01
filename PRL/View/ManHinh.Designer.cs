﻿namespace PRL.View
{
    partial class ManHinh
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
            DisPlayName = new TextBox();
            BtnSearch = new Button();
            SearchingTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            DisPlayId = new TextBox();
            BtnAdd = new Button();
            groupBox2 = new GroupBox();
            DgvDIsPlayShow = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDIsPlayShow).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(DisPlayName);
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(SearchingTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnUpdate);
            groupBox1.Controls.Add(DisPlayId);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 232);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Display";
            // 
            // DisPlayName
            // 
            DisPlayName.Location = new Point(483, 54);
            DisPlayName.Name = "DisPlayName";
            DisPlayName.Size = new Size(274, 23);
            DisPlayName.TabIndex = 21;
            // 
            // BtnSearch
            // 
            BtnSearch.ForeColor = SystemColors.ActiveCaptionText;
            BtnSearch.Location = new Point(871, 168);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(116, 41);
            BtnSearch.TabIndex = 20;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // SearchingTxt
            // 
            SearchingTxt.Location = new Point(21, 178);
            SearchingTxt.Multiline = true;
            SearchingTxt.Name = "SearchingTxt";
            SearchingTxt.Size = new Size(758, 27);
            SearchingTxt.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(386, 57);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 15;
            label2.Text = "DisplayName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(21, 57);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 14;
            label1.Text = "DisplayId";
            // 
            // BtnDelete
            // 
            BtnDelete.ForeColor = SystemColors.ActiveCaptionText;
            BtnDelete.Location = new Point(1029, 107);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(116, 41);
            BtnDelete.TabIndex = 13;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            BtnUpdate.Location = new Point(1029, 164);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(116, 41);
            BtnUpdate.TabIndex = 12;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // DisPlayId
            // 
            DisPlayId.Location = new Point(87, 54);
            DisPlayId.Name = "DisPlayId";
            DisPlayId.Size = new Size(274, 23);
            DisPlayId.TabIndex = 7;
            // 
            // BtnAdd
            // 
            BtnAdd.ForeColor = SystemColors.ActiveCaptionText;
            BtnAdd.Location = new Point(871, 107);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(116, 41);
            BtnAdd.TabIndex = 6;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvDIsPlayShow);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(2, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1161, 322);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // DgvDIsPlayShow
            // 
            DgvDIsPlayShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDIsPlayShow.Location = new Point(6, 22);
            DgvDIsPlayShow.Name = "DgvDIsPlayShow";
            DgvDIsPlayShow.RowTemplate.Height = 25;
            DgvDIsPlayShow.Size = new Size(1149, 294);
            DgvDIsPlayShow.TabIndex = 0;
            DgvDIsPlayShow.CellContentClick += DgvDIsPlayShow_CellContentClick;
            // 
            // ManHinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1165, 578);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManHinh";
            Text = "ManHinh";
            Load += ManHinh_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvDIsPlayShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnSearch;
        private TextBox SearchingTxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnDelete;
        private Button BtnUpdate;
        private TextBox CPUName;
        private TextBox CPUClockSpeed;
        private TextBox CPUCores;
        private TextBox CPUThreads;
        private TextBox DisPlayId;
        private Button BtnAdd;
        private GroupBox groupBox2;
        private DataGridView DgvDIsPlayShow;
        private TextBox DisPlayName;
    }
}