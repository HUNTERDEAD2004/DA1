using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJCodeUI_M1.Models;
using RJCodeUI_M1.TestAndDemo;
using System.Diagnostics;
using System.IO;

namespace RJCodeUI_M1
{
    public partial class MainForm : RJForms.RJMainForm
    {
        #region -> Fields

        private User userConnected;

        #endregion

        #region -> Constructor

        public MainForm()
        {
            InitializeComponent();
            InitializeItems();

            lblUserName.Text = "No login";
        }

        public MainForm(User user)
        {
            InitializeComponent();
            InitializeItems();
            //
            userConnected = user;
            lblUserName.Text = user.FirstName + " " + user.LastName;
            pbProfilePicture.Image = user.ProfilePicture;

        }
        private void InitializeItems()
        {
            biFormOptions.DropdownMenu = this.dmFormOptions;//Set dropdown menu of form options
            if (Settings.UIAppearance.Style == Settings.UIStyle.Supernova)
                pbSideMenuLogo.Image = Properties.Resources.RJTitleBarLogoColor;

        }
        #endregion

        #region -> Events Methods Definition

        //How to use the OpenChildForm<childForm>(...) method

        /// You can use the Func<TResult> delegate with anonymous methods or lambda expression,
        /// for example, we can call this method as follows:
        /// With anonymous method:
        ///     <see cref="OpenChildForm( delegate () { return new MyForm('MyParameter'); });"/>    
        /// With lambda expression
        ///     <see cref="OpenChildForm( () => new MyForm('id', 'username'));"/>


        #region - Open Child Form
        //(User Options Dropdown Menu)
        /// Using [<see cref="OpenChildForm<childForm>(Func<childForm> _delegate) where childForm : RJChildForm"/>] Method

        private void miMyProfile_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormUserProfile(userConnected));
            //()=> : Generic delegate call
        }
        private void miSettings_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new RJForms.RJSettingsForm());
        }

        #endregion

        #region - Open Child Form from a Menu Button
        //(Side Menu)
        /// Using [<see cref="OpenChildForm<childForm>(Func<childForm> _delegate, object senderMenuButton) where childForm : RJChildForm"/>] Method

        private void btnUserControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormUserControls(), sender);
            //()=> : Generic delegate call
            //sender: btnUserControls (MenuButton)
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormDashboard(), sender);
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormProducts(), sender);
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormCustomer(), sender);
        }
        #endregion

        #region - Open Child Form from a Dropdown Menu Item associated with a Menu Button
        //(Side Menu)
        /// Using [<see cref="OpenChildForm<childForm>(Func<childForm> _delegate, object senderMenuItem, RJMenuButton ownerMenuButton) where childForm : RJChildForm"/>] Method

        private void miCommonControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormCommonControls(), sender, btnCustomControls);
            //()=> : Generic delegate call
            //sender: commonToolStripMenuItem (dmCustomControls Menu Item)
            //btnCustomControls: MenuButton 
        }
        private void miComponentsControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormComponentControls(), sender, btnCustomControls);
        }
        private void miMenuControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormMenuControls(), sender, btnCustomControls);
        }
        private void miContainerControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormContainerControls(), sender, btnCustomControls);
        }
        private void miDataControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormDataControls(), sender, btnCustomControls);
        }
        private void miSpecialControls_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormSpecialControls(), sender, btnCustomControls);
        }
        private void miSalesList_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormSalesOrder(), sender, btnSales);
        }
        private void baseFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormRJBaseFormDoc(), sender, btnCustomForms);
        }
        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormRJMainFormDoc(), sender, btnCustomForms);
        }
        private void childFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FormRJChildFormDoc(), sender, btnCustomForms);

        }
        #endregion

        #region - User Options
        //(User Options Dropdown Menu)

        private void miExit_Click(object sender, EventArgs e)
        {
            this.CloseWindow();
        }
        private void miLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void miHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"Files\Documentation.pdf");
        }
        private void miTermsCond_Click(object sender, EventArgs e)
        {
            Process.Start(@"Files\License.pdf");
        }

        #endregion
        
        #endregion

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.youtube.com/rjcodeadvanceen");
        }
        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/RJCodeAdvance");
        }

        private void pnlSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
