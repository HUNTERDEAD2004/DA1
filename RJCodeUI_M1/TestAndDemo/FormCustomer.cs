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
    public partial class FormCustomer : RJForms.RJChildForm
    {
        public FormCustomer()
        {
            InitializeComponent();
            rjDataGridView1.DataSource = new Customer().GetCustomerList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmCustomer = new FormCustomerMaintenance();
            frmCustomer.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = rjDataGridView1.CurrentRow.Cells[2].Value.ToString();
            var customer = new Customer().GetCustomerList().FirstOrDefault(t=>t.Email==id);
            var frmCustomer = new FormCustomerMaintenance(customer);
            frmCustomer.ShowDialog();
        }
    }
}
