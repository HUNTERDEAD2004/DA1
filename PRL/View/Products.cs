using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            AppleWatch form = new AppleWatch();
            this.Close();
            form.Show();
        }

        private void btnIphone_Click(object sender, EventArgs e)
        {
            Iphone form = new Iphone();
            this.Hide();
            form.Show();
        }

        private void btnIpad_Click(object sender, EventArgs e)
        {
            Ipad form = new Ipad();
            this.Hide();
            form.Show();
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            Macbook form = new Macbook();
            this.Hide();
            form.Show();
        }

        private void btnImac_Click(object sender, EventArgs e)
        {
            Imac form = new Imac();
            this.Hide();
            form.Show();
        }

        private void btnAirpod_Click(object sender, EventArgs e)
        {
            Airpods form = new Airpods();
            this.Hide();
            form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
