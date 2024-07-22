namespace PRL.View
{
    partial class AppleWatch
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
            image1 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnBack = new FontAwesome.Sharp.IconButton();
            btnImage = new FontAwesome.Sharp.IconButton();
            button2 = new Button();
            button1 = new Button();
            buttonAdd = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(-77, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 724);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(image1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnImage);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(89, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(947, 675);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Apple Watch";
            // 
            // image1
            // 
            image1.BackColor = Color.Lavender;
            image1.Location = new Point(541, 166);
            image1.Name = "image1";
            image1.Size = new Size(137, 145);
            image1.TabIndex = 17;
            image1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 382);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(911, 232);
            dataGridView1.TabIndex = 16;
            // 
            // btnBack
            // 
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnBack.IconColor = Color.Black;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 17;
            btnBack.ImageAlign = ContentAlignment.MiddleRight;
            btnBack.Location = new Point(866, 638);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnImage
            // 
            btnImage.BackColor = Color.SkyBlue;
            btnImage.ForeColor = SystemColors.ActiveCaptionText;
            btnImage.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnImage.IconColor = Color.Black;
            btnImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImage.IconSize = 17;
            btnImage.Location = new Point(563, 317);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(91, 28);
            btnImage.TabIndex = 14;
            btnImage.Text = "Browse...";
            btnImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.FlatAppearance.BorderColor = Color.Lavender;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(420, 244);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 13;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.FlatAppearance.BorderColor = Color.Lavender;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(330, 244);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 12;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.SkyBlue;
            buttonAdd.FlatAppearance.BorderColor = Color.Lavender;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdd.Location = new Point(240, 244);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 25);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 140);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "Updated By";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(541, 137);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(137, 23);
            textBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 96);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            label4.Text = "Created By";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(541, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 186);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Updated at";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(309, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 23);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 140);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Created At";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 96);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Display";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 0;
            // 
            // AppleWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 699);
            Controls.Add(panel1);
            Name = "AppleWatch";
            Text = "AppleWatch";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button buttonAdd;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnImage;
        private Button button2;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnBack;
        private DataGridView dataGridView1;
        private PictureBox image1;
    }
}