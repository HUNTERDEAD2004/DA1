namespace PRL.View
{
    partial class CPU
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
            BtnSearch = new Button();
            SearchingTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            CPUName = new TextBox();
            CPUClockSpeed = new TextBox();
            CPUCores = new TextBox();
            CPUThreads = new TextBox();
            CPUID = new TextBox();
            BtnAdd = new Button();
            groupBox2 = new GroupBox();
            DgvCPUShow = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCPUShow).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(SearchingTxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnUpdate);
            groupBox1.Controls.Add(CPUName);
            groupBox1.Controls.Add(CPUClockSpeed);
            groupBox1.Controls.Add(CPUCores);
            groupBox1.Controls.Add(CPUThreads);
            groupBox1.Controls.Add(CPUID);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CPU";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SlateBlue;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(383, 128);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 18;
            label5.Text = "CPUClockSpeed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 125);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 17;
            label4.Text = "CPUThreads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(805, 57);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 16;
            label3.Text = "CPUCores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(413, 57);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 15;
            label2.Text = "CPUName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(40, 57);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 14;
            label1.Text = "CPUID";
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
            // CPUName
            // 
            CPUName.Location = new Point(481, 54);
            CPUName.Name = "CPUName";
            CPUName.Size = new Size(274, 23);
            CPUName.TabIndex = 11;
            // 
            // CPUClockSpeed
            // 
            CPUClockSpeed.Location = new Point(481, 125);
            CPUClockSpeed.Name = "CPUClockSpeed";
            CPUClockSpeed.Size = new Size(274, 23);
            CPUClockSpeed.TabIndex = 10;
            // 
            // CPUCores
            // 
            CPUCores.Location = new Point(871, 54);
            CPUCores.Name = "CPUCores";
            CPUCores.Size = new Size(274, 23);
            CPUCores.TabIndex = 9;
            // 
            // CPUThreads
            // 
            CPUThreads.Location = new Point(87, 125);
            CPUThreads.Name = "CPUThreads";
            CPUThreads.Size = new Size(274, 23);
            CPUThreads.TabIndex = 8;
            // 
            // CPUID
            // 
            CPUID.Location = new Point(87, 54);
            CPUID.Name = "CPUID";
            CPUID.Size = new Size(274, 23);
            CPUID.TabIndex = 7;
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
            groupBox2.Controls.Add(DgvCPUShow);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(2, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1161, 322);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // DgvCPUShow
            // 
            DgvCPUShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCPUShow.Location = new Point(6, 22);
            DgvCPUShow.Name = "DgvCPUShow";
            DgvCPUShow.RowTemplate.Height = 25;
            DgvCPUShow.Size = new Size(1149, 294);
            DgvCPUShow.TabIndex = 0;
            DgvCPUShow.CellContentClick += DgvCPUShow_CellContentClick;
            // 
            // CPU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1168, 566);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CPU";
            Text = "CPU";
            Load += CPU_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvCPUShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox CPUName;
        private TextBox CPUClockSpeed;
        private TextBox CPUCores;
        private TextBox CPUThreads;
        private TextBox CPUID;
        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView DgvCPUShow;
        private TextBox SearchingTxt;
        private Button BtnSearch;
    }
}