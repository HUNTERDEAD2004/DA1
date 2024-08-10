namespace PRL.View
{
    partial class ReportFrm
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
            panel1 = new Panel();
            btnExport = new FontAwesome.Sharp.IconButton();
            dgvHD = new DataGridView();
            dgvData = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(dgvHD);
            panel1.Controls.Add(dgvData);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1547, 839);
            panel1.TabIndex = 0;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Cyan;
            btnExport.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExport.IconColor = Color.Black;
            btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExport.Location = new Point(688, 414);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(121, 39);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export Report";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // dgvHD
            // 
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Location = new Point(759, 111);
            dgvHD.Name = "dgvHD";
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(603, 267);
            dgvHD.TabIndex = 1;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(86, 111);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(655, 267);
            dgvData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(668, 42);
            label1.Name = "label1";
            label1.Size = new Size(141, 50);
            label1.TabIndex = 0;
            label1.Text = "Report";
            // 
            // ReportFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 704);
            Controls.Add(panel1);
            Name = "ReportFrm";
            Text = "Report";
            Load += ReportFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvData;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnExport;
        private DataGridView dgvHD;
    }
}