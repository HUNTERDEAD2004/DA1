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
    public partial class ProductDetails : Form
    {
        IphoneDbContext context;
        private readonly Guid _productID;
        public ProductDetails(Guid productId)
        {
            context = new IphoneDbContext();
            InitializeComponent();
            LoadComboBoxData();
            LoadProduct();
            txtProductID.Text = productId.ToString();
            _productID = productId;
        }
        private void ProductDetails_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void LoadComboBoxData()
        {
            cbRam.DataSource = context.RAMs.ToList();
            cbRam.DisplayMember = "RAMSize";
            cbRam.ValueMember = "RAMID";

            cbCpu.DataSource = context.CPUs.ToList();
            cbCpu.DisplayMember = "CPUName";
            cbCpu.ValueMember = "CPUID";

            cbGPU.DataSource = context.GPUs.ToList();
            cbGPU.DisplayMember = "GPUName";
            cbGPU.ValueMember = "GPUID";

            cbRom.DataSource = context.ROMs.ToList();
            cbRom.DisplayMember = "ROMSize";
            cbRom.ValueMember = "ROMID";

            cbDisplay.DataSource = context.Displays.ToList();
            cbDisplay.DisplayMember = "DisplayName";
            cbDisplay.ValueMember = "DISPLAYID";

            cbSale.DataSource = context.Sales.ToList();
            cbSale.DisplayMember = "DiscountValue";
            cbSale.ValueMember = "SaleID";
        }
        private void LoadProduct()
        {
            var product = context.Products.FirstOrDefault(p => p.ProductID == _productID);

            if (product != null)
            {
                txtProductID.Text = product.ProductID.ToString();
                txtName.Text = product.ProductName;
            }
            else
            {
                MessageBox.Show("Sản phẩm không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
