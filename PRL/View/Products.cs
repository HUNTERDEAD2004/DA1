using AppData.Models;
using Microsoft.EntityFrameworkCore;
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
        IphoneDbContext context;
        private Guid? _productId;
        public Products()
        {
            InitializeComponent();
            context = new IphoneDbContext();
            LoadData();
        }
        private void LoadData(Guid? productId = null)
        {
            var products = context.Products.ToList();
            dgvData.DataSource = products;
            _productId = productId;
            if (_productId.HasValue)
            {
                LoadData();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductID = Guid.NewGuid(),
                ProductName = txtName.Text,
                Description = txtDescription.Text,
                Quantity = int.Parse(txtQuantity.Text),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedBy = "Apple",
                UpdatedBy = "Apple"
            };

            context.Products.Add(product);
            context.SaveChanges();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0 && ValidateForm())
            {
                var productId = (Guid)dgvData.SelectedRows[0].Cells["ProductID"].Value;
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    product.ProductName = txtName.Text;
                    product.Description = txtDescription.Text;
                    product.Quantity = int.Parse(txtQuantity.Text);
                    product.UpdatedAt = DateTime.UtcNow;
                    product.UpdatedBy = "Apple";

                    context.Products.Update(product);
                    context.SaveChanges();
                    LoadData();
                    ClearForm();
                }
            }
        }
        private void ClearForm()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtUpdateAt.Text = "";
            txtCreatAt.Text = "";
            txtCreatBy.Text = "";
            txtUpdateBy.Text = "";
            txtQuantity.Text = "";
        }
        private bool ValidateForm()
        {
            return true;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                txtID.Text = row.Cells["ProductID"].Value.ToString();
                txtName.Text = row.Cells["ProductName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtCreatAt.Text = row.Cells["CreatedAt"].Value.ToString();
                txtUpdateAt.Text = row.Cells["UpdatedAt"].Value.ToString();
                txtCreatBy.Text = row.Cells["CreatedBy"].Value.ToString();
                txtUpdateBy.Text = row.Cells["UpdatedBy"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                var productId = (Guid)dgvData.SelectedRows[0].Cells["ProductID"].Value;
                var product = context.Products.Find(productId);
                if (product != null)
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                    LoadData();
                    ClearForm();
                }
            }
        }
    }
}
