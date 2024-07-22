namespace PRL.View
{
    partial class Iphone
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
            groupBox1 = new GroupBox();
            btnBack = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnImage = new FontAwesome.Sharp.IconButton();
            image1 = new PictureBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 834);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SlateBlue;
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnImage);
            groupBox1.Controls.Add(image1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(998, 713);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Iphone";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnBack
            // 
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 17;
            btnBack.ImageAlign = ContentAlignment.MiddleRight;
            btnBack.Location = new Point(917, 675);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 415);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(948, 215);
            dataGridView1.TabIndex = 19;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SkyBlue;
            btnEdit.ForeColor = SystemColors.ActiveCaptionText;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnEdit.IconColor = Color.Black;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 17;
            btnEdit.Location = new Point(287, 217);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 30);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SkyBlue;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 18;
            btnAdd.Location = new Point(164, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 30);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SkyBlue;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.Black;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 17;
            btnDelete.Location = new Point(164, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 30);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnImage
            // 
            btnImage.BackColor = Color.SkyBlue;
            btnImage.ForeColor = SystemColors.ActiveCaptionText;
            btnImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnImage.IconColor = Color.Black;
            btnImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImage.IconSize = 17;
            btnImage.Location = new Point(626, 347);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(101, 30);
            btnImage.TabIndex = 15;
            btnImage.Text = "Browse...";
            btnImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // image1
            // 
            image1.BackColor = Color.Lavender;
            image1.Location = new Point(565, 178);
            image1.Name = "image1";
            image1.Size = new Size(221, 153);
            image1.TabIndex = 4;
            image1.TabStop = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(565, 137);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(221, 23);
            textBox7.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(565, 96);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(565, 55);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 23);
            textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(167, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 23);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 178);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 0;
            label7.Text = "Updated by";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(467, 58);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 0;
            label6.Text = "Created by";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 138);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 0;
            label5.Text = "Updated at";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 138);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Created at";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 98);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 0;
            label3.Text = "Camera Selfie";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 58);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "Display";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 98);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Rear Camera";
            // 
            // Iphone
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 805);
            Controls.Add(panel1);
            Name = "Iphone";
            Text = "Iphone";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox image1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnImage;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDelete;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}