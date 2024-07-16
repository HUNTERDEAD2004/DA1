using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeUI_M1.TestAndDemo
{
    public partial class FormComponentControls : RJForms.RJChildForm
    {
        public FormComponentControls()
        {
            InitializeComponent();
        }

        private void btnAnyControl_Click(object sender, EventArgs e)
        {
            dmExample.Show(btnAnyControl,DropdownMenuPosition.TopRight);
        }

        private void lblInfo1_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.component?view=net-5.0#definition");
        }

        private void lblInfo2_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.contextmenustrip.-ctor?view=net-5.0");
        }

        private void lblInfo3_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.timer.-ctor?view=net-5.0#System_Windows_Forms_Timer__ctor_System_ComponentModel_IContainer_");
        }

        private void lblInfo4_Click(object sender, EventArgs e)
        {
            Process.Start("https://stackoverflow.com/a/4603934/12778930");
        }
    }
}
