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
    public partial class FormUserProfile : RJForms.RJChildForm
    {
        public FormUserProfile()
        {
            
            InitializeComponent();
        }
        public FormUserProfile(Models.User user)
        {
            
            InitializeComponent();

            txtUsername.Text = user.Username;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;
            dpBirthdate.Value = user.Birthdate;
            pbPhoto.Image = user.ProfilePicture;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }
    }
}
