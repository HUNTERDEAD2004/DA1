using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeUI_M1.TestAndDemo
{
    public partial class FormSpecialControls : RJForms.RJChildForm
    {
        public FormSpecialControls()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rjProgressBar1.Value < rjProgressBar1.Maximum)
            {
                rjProgressBar1.Value++;
                rjProgressBar2.Value++;
            }
            else timer1.Stop();
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            rjProgressBar1.Value = 0;
            rjProgressBar2.Value = 0;
            timer1.Start();
        }

        private void FormSpecialControls_Load(object sender, EventArgs e)
        {
            //rjProgressBar2.ForeBackColor = this.BackColor;   
        }
    }
}
