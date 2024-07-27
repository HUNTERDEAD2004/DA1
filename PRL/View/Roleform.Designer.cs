namespace PRL.View
{
    partial class Roleform
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
            dgvUser = new DataGridView();
            groupBox1 = new GroupBox();
            bttRL = new Button();
            txtRoleHT = new TextBox();
            txtIDHT = new TextBox();
            CBHD = new ComboBox();
            CBGT = new ComboBox();
            bttTK = new Button();
            bttCL = new Button();
            bttXoa = new Button();
            bttSua = new Button();
            bttCap = new Button();
            bttThem = new Button();
            txtTK = new TextBox();
            label5 = new Label();
            txtDes = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            lab222 = new Label();
            txtRLID = new TextBox();
            txtNameRL = new TextBox();
            txtNameUS = new TextBox();
            dgvUserRL = new DataGridView();
            dgvRole = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserRL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRole).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(27, 267);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(971, 182);
            dgvUser.TabIndex = 0;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bttRL);
            groupBox1.Controls.Add(txtRoleHT);
            groupBox1.Controls.Add(txtIDHT);
            groupBox1.Controls.Add(CBHD);
            groupBox1.Controls.Add(CBGT);
            groupBox1.Controls.Add(bttTK);
            groupBox1.Controls.Add(bttCL);
            groupBox1.Controls.Add(bttXoa);
            groupBox1.Controls.Add(bttSua);
            groupBox1.Controls.Add(bttCap);
            groupBox1.Controls.Add(bttThem);
            groupBox1.Controls.Add(txtTK);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDes);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lab222);
            groupBox1.Controls.Add(txtRLID);
            groupBox1.Controls.Add(txtNameRL);
            groupBox1.Controls.Add(txtNameUS);
            groupBox1.Controls.Add(dgvUserRL);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(971, 249);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // bttRL
            // 
            bttRL.Location = new Point(930, 134);
            bttRL.Name = "bttRL";
            bttRL.Size = new Size(35, 23);
            bttRL.TabIndex = 27;
            bttRL.Text = "RL";
            bttRL.UseVisualStyleBackColor = true;
            bttRL.Click += bttRL_Click;
            // 
            // txtRoleHT
            // 
            txtRoleHT.Location = new Point(810, 191);
            txtRoleHT.Name = "txtRoleHT";
            txtRoleHT.ReadOnly = true;
            txtRoleHT.Size = new Size(155, 23);
            txtRoleHT.TabIndex = 26;
            // 
            // txtIDHT
            // 
            txtIDHT.Location = new Point(520, 191);
            txtIDHT.Name = "txtIDHT";
            txtIDHT.ReadOnly = true;
            txtIDHT.Size = new Size(187, 23);
            txtIDHT.TabIndex = 25;
            // 
            // CBHD
            // 
            CBHD.FormattingEnabled = true;
            CBHD.Items.AddRange(new object[] { "Hoạt Động", "Cút" });
            CBHD.Location = new Point(313, 218);
            CBHD.Name = "CBHD";
            CBHD.Size = new Size(127, 23);
            CBHD.TabIndex = 24;
            // 
            // CBGT
            // 
            CBGT.FormattingEnabled = true;
            CBGT.Items.AddRange(new object[] { "Male", "Female", "Unknown" });
            CBGT.Location = new Point(223, 218);
            CBGT.Name = "CBGT";
            CBGT.Size = new Size(84, 23);
            CBGT.TabIndex = 23;
            // 
            // bttTK
            // 
            bttTK.Location = new Point(0, 219);
            bttTK.Name = "bttTK";
            bttTK.Size = new Size(75, 23);
            bttTK.TabIndex = 22;
            bttTK.Text = "Tìm";
            bttTK.UseVisualStyleBackColor = true;
            bttTK.Click += bttTK_Click;
            // 
            // bttCL
            // 
            bttCL.Location = new Point(849, 134);
            bttCL.Name = "bttCL";
            bttCL.Size = new Size(75, 23);
            bttCL.TabIndex = 21;
            bttCL.Text = " Clear";
            bttCL.UseVisualStyleBackColor = true;
            bttCL.Click += bttCL_Click;
            // 
            // bttXoa
            // 
            bttXoa.Location = new Point(752, 134);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(75, 23);
            bttXoa.TabIndex = 20;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += bttXoa_Click;
            // 
            // bttSua
            // 
            bttSua.Location = new Point(655, 134);
            bttSua.Name = "bttSua";
            bttSua.Size = new Size(75, 23);
            bttSua.TabIndex = 19;
            bttSua.Text = "Sửa";
            bttSua.UseVisualStyleBackColor = true;
            bttSua.Click += bttSua_Click;
            // 
            // bttCap
            // 
            bttCap.Location = new Point(713, 220);
            bttCap.Name = "bttCap";
            bttCap.Size = new Size(91, 23);
            bttCap.TabIndex = 18;
            bttCap.Text = "Cấp hoặc cút";
            bttCap.UseVisualStyleBackColor = true;
            bttCap.Click += bttCap_Click;
            // 
            // bttThem
            // 
            bttThem.Location = new Point(557, 134);
            bttThem.Name = "bttThem";
            bttThem.Size = new Size(75, 23);
            bttThem.TabIndex = 17;
            bttThem.Text = "Thêm";
            bttThem.UseVisualStyleBackColor = true;
            bttThem.Click += bttThem_Click;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(81, 218);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(136, 23);
            txtTK.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 99);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 13;
            label5.Text = "Description";
            // 
            // txtDes
            // 
            txtDes.Location = new Point(557, 96);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(408, 23);
            txtDes.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 70);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(557, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(408, 23);
            txtName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 41);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "RoleId";
            // 
            // lab222
            // 
            lab222.AutoSize = true;
            lab222.Location = new Point(484, 224);
            lab222.Name = "lab222";
            lab222.Size = new Size(30, 15);
            lab222.TabIndex = 7;
            lab222.Text = "User";
            lab222.Click += label1_Click;
            // 
            // txtRLID
            // 
            txtRLID.Location = new Point(557, 38);
            txtRLID.Name = "txtRLID";
            txtRLID.Size = new Size(408, 23);
            txtRLID.TabIndex = 6;
            // 
            // txtNameRL
            // 
            txtNameRL.Location = new Point(810, 218);
            txtNameRL.Name = "txtNameRL";
            txtNameRL.Size = new Size(154, 23);
            txtNameRL.TabIndex = 5;
            // 
            // txtNameUS
            // 
            txtNameUS.Location = new Point(520, 220);
            txtNameUS.Name = "txtNameUS";
            txtNameUS.Size = new Size(187, 23);
            txtNameUS.TabIndex = 4;
            // 
            // dgvUserRL
            // 
            dgvUserRL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserRL.Location = new Point(6, 22);
            dgvUserRL.Name = "dgvUserRL";
            dgvUserRL.RowTemplate.Height = 25;
            dgvUserRL.Size = new Size(434, 174);
            dgvUserRL.TabIndex = 3;
            dgvUserRL.CellContentClick += dgvUserRL_CellContentClick;
            // 
            // dgvRole
            // 
            dgvRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRole.Location = new Point(27, 455);
            dgvRole.Name = "dgvRole";
            dgvRole.RowTemplate.Height = 25;
            dgvRole.Size = new Size(971, 122);
            dgvRole.TabIndex = 2;
            dgvRole.CellContentClick += dgvRole_CellContentClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // Roleform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 589);
            Controls.Add(dgvRole);
            Controls.Add(groupBox1);
            Controls.Add(dgvUser);
            Name = "Roleform";
            Text = "Role";
            Load += Role_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserRL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRole).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUser;
        private GroupBox groupBox1;
        private DataGridView dgvUserRL;
        private DataGridView dgvRole;
        private TextBox txtTK;
        private Label label5;
        private TextBox txtDes;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private Label lab222;
        private TextBox txtRLID;
        private TextBox txtNameRL;
        private TextBox txtNameUS;
        private Button bttCL;
        private Button bttXoa;
        private Button bttSua;
        private Button bttCap;
        private Button bttThem;
        private ComboBox CBHD;
        private ComboBox CBGT;
        private Button bttTK;
        private TextBox txtRoleHT;
        private TextBox txtIDHT;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button bttRL;
    }
}