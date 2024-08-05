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
        public Products()
        {
            InitializeComponent();
            context = new IphoneDbContext();
            LoadData();
            panel1.Dock = DockStyle.Fill;
            //LoadDetails();
        }
        private void LoadData(Guid? productId = null)
        {
            var products = context.Products.ToList();
            dgvData.DataSource = products;
            dgvData.Columns["ProductID"].Visible = false;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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
                var selectedRow = dgvData.Rows[e.RowIndex];
                txtID.Text = selectedRow.Cells["ProductID"].Value.ToString();
                txtName.Text = selectedRow.Cells["ProductName"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();
                txtCreatAt.Text = selectedRow.Cells["CreatedAt"].Value.ToString();
                txtUpdateAt.Text = selectedRow.Cells["UpdatedAt"].Value.ToString();
                txtCreatBy.Text = selectedRow.Cells["CreatedBy"].Value.ToString();
                txtUpdateBy.Text = selectedRow.Cells["UpdatedBy"].Value.ToString();
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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                var productIdCellValue = dgvData.SelectedRows[0].Cells["ProductID"].Value;

                if (productIdCellValue != null)
                {
                    if (Guid.TryParse(productIdCellValue.ToString(), out var productId))
                    {
                        var detailsForm = new ProductDetails(productId);
                        detailsForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("ProductID không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ProductID không có giá trị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var productName = txtName.Text.Trim();

            var existingProduct = context.Products.FirstOrDefault(p => p.ProductName == productName);

            if (existingProduct != null)
            {
                MessageBox.Show("Sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var product = new Product
            {
                ProductID = Guid.NewGuid(),
                ProductName = txtName.Text,
                Description = txtDescription.Text,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedBy = "Apple",
                UpdatedBy = "Apple"
            };
            context.Products.Add(product);
            context.SaveChanges();
            LoadData();
            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
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
                    MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }
    }
}
