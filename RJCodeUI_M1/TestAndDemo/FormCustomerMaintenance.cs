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

namespace RJCodeUI_M1.TestAndDemo
{
    public partial class FormCustomerMaintenance : RJForms.RJChildForm
    {
        public FormCustomerMaintenance()
        {
            InitializeComponent();
            lblTitle.Text = "Add new customer";
            btnSave.Text = "Add";
            btnSave.BackColor = Settings.RJColors.Confirm;
        }

        public FormCustomerMaintenance(Customer customer)
        {
            InitializeComponent();
            lblTitle.Select();//Not focus on text boxes when starting the form.
            lblTitle.Text = "Edit customer";
            btnSave.Text = "Save";
            btnSave.BackColor = Settings.UIAppearance.StyleColor;

            txtNames.Text = customer.Names;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.PhoneNumber;
            txtAddress.Text = customer.StreetAddres;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
