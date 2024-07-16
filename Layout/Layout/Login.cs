using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout
{
    public partial class Login : Form
    {
        private Form currentFormChild;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
        public void OpenForm(Form childForm)
        {
            MainForm form = new MainForm();
            this.Hide();
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MainForm form = new MainForm();
            //this.Hide();
            //form.Show();
        }
    }
}
