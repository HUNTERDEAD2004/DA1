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
    public partial class FormMenuControls : RJForms.RJChildForm
    {
        public FormMenuControls()
        {
            InitializeComponent();
        }

        private void btnAnyControl_Click(object sender, EventArgs e)
        {
            dmExample.Show(btnAnyControl,DropdownMenuPosition.TopRight);
        }

        private void rjLabel13_Click(object sender, EventArgs e)
        {

        }
    }
}
