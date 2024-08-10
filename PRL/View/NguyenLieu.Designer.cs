namespace PRL.View
{
    partial class NguyenLieu
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
            DgvMaterialhow = new DataGridView();
            groupBox1 = new GroupBox();
            BtnSearch = new Button();
            SearchingTxt = new TextBox();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnAdd = new Button();
            MarterialNameTxt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            MaterialIdTxt = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMaterialhow).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DgvMaterialhow);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(11, 248);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1161, 322);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // DgvMaterialhow
            // 
            DgvMaterialhow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMaterialhow.Location = new Point(6, 22);
            DgvMaterialhow.Name = "DgvMaterialhow";
            DgvMaterialhow.RowTemplate.Height = 25;
            DgvMaterialhow.Size = new Size(1149, 294);
            DgvMaterialhow.TabIndex = 0;
            DgvMaterialhow.CellContentClick += DgvMaterialhow_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(SearchingTxt);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnUpdate);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(MarterialNameTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(MaterialIdTxt);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(11, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 232);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "OS";
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
            // MarterialNameTxt
            // 
            MarterialNameTxt.Location = new Point(388, 57);
            MarterialNameTxt.Name = "MarterialNameTxt";
            MarterialNameTxt.Size = new Size(177, 23);
            MarterialNameTxt.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(307, 60);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 21;
            label3.Text = "MaterialName";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(20, 57);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 14;
            label1.Text = "MaterialId";
            // 
            // MaterialIdTxt
            // 
            MaterialIdTxt.Location = new Point(101, 57);
            MaterialIdTxt.Name = "MaterialIdTxt";
            MaterialIdTxt.Size = new Size(177, 23);
            MaterialIdTxt.TabIndex = 7;
            // 
            // NguyenLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1182, 581);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NguyenLieu";
            Text = "NguyenLieu";
            Load += NguyenLieu_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMaterialhow).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView DgvMaterialhow;
        private GroupBox groupBox1;
        private Button BtnSearch;
        private TextBox SearchingTxt;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnAdd;
        private TextBox MarterialNameTxt;
        private Label label3;
        private Label label1;
        private TextBox MaterialIdTxt;
    }
}