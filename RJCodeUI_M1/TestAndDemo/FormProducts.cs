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
    public partial class FormProducts : RJForms.RJChildForm
    {
        public FormProducts()
        {
            InitializeComponent();
            rjDataGridView1.DataSource = new Product().GetProductsList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frmProduct = new FormProductMaintenance();
            frmProduct.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id =(int) rjDataGridView1.CurrentRow.Cells[0].Value;
            var product = new Product().GetProductsList().FirstOrDefault(t=>t.Id==id);

            var frmProduct = new FormProductMaintenance(product);
            frmProduct.ShowDialog();
        }
    }
}
