namespace PRL.View
{
    partial class IMEIForm
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
            dgvImei = new DataGridView();
            txtOK = new Button();
            Imei = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvImei).BeginInit();
            SuspendLayout();
            // 
            // dgvImei
            // 
            dgvImei.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImei.Columns.AddRange(new DataGridViewColumn[] { Imei, Delete });
            dgvImei.Location = new Point(12, 12);
            dgvImei.Name = "dgvImei";
            dgvImei.RowTemplate.Height = 25;
            dgvImei.Size = new Size(243, 96);
            dgvImei.TabIndex = 0;
            dgvImei.CellContentClick += dgvImei_CellContentClick;
            // 
            // txtOK
            // 
            txtOK.Location = new Point(89, 114);
            txtOK.Name = "txtOK";
            txtOK.Size = new Size(75, 23);
            txtOK.TabIndex = 1;
            txtOK.Text = "OK";
            txtOK.UseVisualStyleBackColor = true;
            txtOK.Click += txtOK_Click;
            // 
            // Imei
            // 
            Imei.Frozen = true;
            Imei.HeaderText = "Imei";
            Imei.Name = "Imei";
            // 
            // Delete
            // 
            Delete.Frozen = true;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // IMEIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 144);
            Controls.Add(txtOK);
            Controls.Add(dgvImei);
            Name = "IMEIForm";
            Text = "IMEIForm";
            Load += IMEIForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImei).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvImei;
        private Button txtOK;
        private DataGridViewButtonColumn Add;
        private DataGridViewTextBoxColumn Imei;
        private DataGridViewButtonColumn Delete;
    }
}