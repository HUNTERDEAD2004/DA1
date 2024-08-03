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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }
    }
}
