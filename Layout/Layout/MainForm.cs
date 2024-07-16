using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Layout.Forms;

namespace Layout
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private Form currentForm;
        public struct hover
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        public MainForm()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            Menu.Controls.Add(leftborderBtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ResetText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();
                iconCurrent.IconChar = currentBtn.IconChar;
                iconCurrent.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(49, 42, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = form.FormBorderStyle;
            form.Dock = DockStyle.Fill;
            panelChange.Controls.Add(form);
            panelChange.Tag = form;
            form.BringToFront();
            form.Show();
            Title.Text = form.Text;
        }
        public void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
            iconCurrent.IconChar = IconChar.Tags;
            iconCurrent.IconColor = Color.MediumPurple;
            Title.Text = "Products"; 
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color1);
            OpenForm(new Products());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color2);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color3);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color4);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color5);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color1);
        }
    }
}
