using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
            _productID = productId;
            LoadProduct();
            LoadDetails();
        }
        private void LoadComboBoxData()
        {
            var ramList = context.RAMs.ToList();
            ramList.Insert(0, new Ram { RAMID = Guid.Empty, RAMSize = "-- Chọn ram --" });
            cbRam.DataSource = ramList;
            cbRam.DisplayMember = "RAMSize";
            cbRam.ValueMember = "RAMID";

            var cpuList = context.CPUs.ToList();
            cpuList.Insert(0, new Cpu { CPUID = Guid.Empty, CPUName = "-- Chọn CPU --" });
            cbCpu.DataSource = cpuList;
            cbCpu.DisplayMember = "CPUName";
            cbCpu.ValueMember = "CPUID";

            var gpuList = context.GPUs.ToList();
            gpuList.Insert(0, new Gpu { GPUID = Guid.Empty, GPUName = "-- Chọn GPU --" });
            cbGPU.DataSource = gpuList;
            cbGPU.DisplayMember = "GPUName";
            cbGPU.ValueMember = "GPUID";

            var romList = context.ROMs.ToList();
            romList.Insert(0, new Rom { ROMID = Guid.Empty, ROMSize = "-- Chọn ROM --" });
            cbRom.DataSource = romList;
            cbRom.DisplayMember = "ROMSize";
            cbRom.ValueMember = "ROMID";

            var colorList = context.Colours.ToList();
            colorList.Insert(0, new AppData.Models.Color { ColorID = Guid.Empty, ColorName = "-- Chọn màu --" });
            cbColor.DataSource = colorList;
            cbColor.DisplayMember = "ColorName";
            cbColor.ValueMember = "ColorID";

            var displayList = context.Displays.ToList();
            displayList.Insert(0, new Display { DisplayID = Guid.Empty, DisplayName = "-- Chọn tấm nền --" });
            cbDisplay.DataSource = displayList;
            cbDisplay.DisplayMember = "DisplayName";
            cbDisplay.ValueMember = "DISPLAYID";

            // Thêm "Chọn" vào cbSale
            var saleList = context.Sales.ToList();
            saleList.Insert(0, new Sales { SaleID = Guid.Empty, DiscountValue = -1 });
            cbSale.DataSource = saleList;
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

        private void UpdateProductQuantity(Guid productId)
        {
            var product = context.Products.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                product.Quantity = context.ProductDetails.Count(pd => pd.ProductID == productId);
                context.SaveChanges();
            }
        }
        public void LoadDetails()
        {
            var productDetails = context.ProductDetails
                        .Where(pd => pd.ProductID == _productID)
                        .ToList();

            dgvDetails.DataSource = productDetails;

            // Đảm bảo các cột hiển thị như mong muốn
            dgvDetails.Columns["IMEI"].HeaderText = "IMEI";
            dgvDetails.Columns["Name"].HeaderText = "Tên";
            dgvDetails.Columns["ColorID"].HeaderText = "Màu sắc";
            dgvDetails.Columns["RAMID"].HeaderText = "RAM";
            dgvDetails.Columns["Price"].HeaderText = "Giá";
            dgvDetails.Columns["CPUID"].HeaderText = "CPU";
            dgvDetails.Columns["GPUID"].HeaderText = "GPU";
            dgvDetails.Columns["ROMID"].HeaderText = "ROM";
            dgvDetails.Columns["DisplayID"].HeaderText = "Màn hình";
            dgvDetails.Columns["SaleID"].HeaderText = "Khuyến mãi";

            // Tuỳ chỉnh cột nếu cần
            dgvDetails.Columns["Product"].Visible = false;
            dgvDetails.Columns["RAM"].Visible = false;
            dgvDetails.Columns["ROM"].Visible = false;
            dgvDetails.Columns["CPU"].Visible = false;
            dgvDetails.Columns["GPU"].Visible = false;
            dgvDetails.Columns["Color"].Visible = false;
            dgvDetails.Columns["Display"].Visible = false;
            dgvDetails.Columns["Sale"].Visible = false;
            dgvDetails.Columns["OrderDetails"].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((Guid)cbRam.SelectedValue == Guid.Empty ||
                (Guid)cbCpu.SelectedValue == Guid.Empty ||
                (Guid)cbGPU.SelectedValue == Guid.Empty ||
                (Guid)cbRom.SelectedValue == Guid.Empty ||
                (Guid)cbColor.SelectedValue == Guid.Empty ||
                (Guid)cbDisplay.SelectedValue == Guid.Empty ||
                (Guid)cbSale.SelectedValue == Guid.Empty)
            {
                MessageBox.Show("Vui lòng chọn tất cả các thông tin chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var detail = new ProductDetail
            {
                IMEI = Guid.NewGuid(),
                ProductID = _productID,
                Name = txtName.Text,
                ColorID = (Guid)cbColor.SelectedValue,
                RAMID = (Guid)cbRam.SelectedValue,
                Price = decimal.Parse(txtPrice.Text),
                CPUID = (Guid)cbCpu.SelectedValue,
                GPUID = (Guid)cbGPU.SelectedValue,
                ROMID = (Guid)cbRom.SelectedValue,
                DisplayID = (Guid)cbDisplay.SelectedValue,
                SaleID = (Guid)cbSale.SelectedValue,
            };
            context.ProductDetails.Add(detail);
            context.SaveChanges();
            UpdateProductQuantity(_productID);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(txtImei.Text, out Guid imei))
            {
                var detail = context.ProductDetails.FirstOrDefault(pd => pd.IMEI == imei);
                if (detail != null)
                {
                    // Cập nhật các thuộc tính của chi tiết sản phẩm
                    detail.Name = txtName.Text;
                    detail.ColorID = (Guid)cbColor.SelectedValue;
                    detail.RAMID = (Guid)cbRam.SelectedValue;
                    detail.Price = decimal.Parse(txtPrice.Text);
                    detail.CPUID = (Guid)cbCpu.SelectedValue;
                    detail.GPUID = (Guid)cbGPU.SelectedValue;
                    detail.ROMID = (Guid)cbRom.SelectedValue;
                    detail.DisplayID = (Guid)cbDisplay.SelectedValue;
                    detail.SaleID = (Guid)cbSale.SelectedValue;

                    context.ProductDetails.Update(detail);
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật chi tiết sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDetails();
                }
                else
                {
                    MessageBox.Show("Chi tiết sản phẩm không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("IMEI không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấp vào một hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị IMEI từ ô được nhấp
                var imeiCell = dgvDetails.Rows[e.RowIndex].Cells["IMEI"].Value;

                if (imeiCell != null && Guid.TryParse(imeiCell.ToString(), out var imei))
                {
                    // Tìm chi tiết sản phẩm dựa trên IMEI
                    var productDetail = context.ProductDetails.FirstOrDefault(pd => pd.IMEI == imei);

                    if (productDetail != null)
                    {
                        // Hiển thị thông tin chi tiết của sản phẩm trong các điều khiển của form
                        txtImei.Text = productDetail.IMEI.ToString();
                        cbColor.SelectedValue = productDetail.ColorID;
                        cbRam.SelectedValue = productDetail.RAMID;
                        txtPrice.Text = productDetail.Price.ToString("0.00");
                        cbCpu.SelectedValue = productDetail.CPUID;
                        cbGPU.SelectedValue = productDetail.GPUID;
                        cbRom.SelectedValue = productDetail.ROMID;
                        cbDisplay.SelectedValue = productDetail.DisplayID;
                        cbSale.SelectedValue = productDetail.SaleID;
                        txtName.Text = productDetail.Name;

                        // Có thể cập nhật các trường khác tùy thuộc vào yêu cầu
                    }
                    else
                    {
                        MessageBox.Show("Chi tiết sản phẩm không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("IMEI không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (Guid.TryParse(txtImei.Text, out var imei))
            {
                var detail = context.ProductDetails.FirstOrDefault(pd => pd.IMEI == imei);
                if (detail != null)
                {
                    var productId = detail.ProductID;

                    context.ProductDetails.Remove(detail);
                    context.SaveChanges();
                    UpdateProductQuantity(productId);
                    MessageBox.Show("Xóa chi tiết sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDetails();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Chi tiết sản phẩm không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("IMEI không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtImei.Text = "";
            txtName.Text = "";
            cbColor.SelectedIndex = -1;
            cbRam.SelectedIndex = -1;
            txtPrice.Text = "";
            cbCpu.SelectedIndex = -1;
            cbGPU.SelectedIndex = -1;
            cbRom.SelectedIndex = -1;
            cbDisplay.SelectedIndex = -1;
            cbSale.SelectedIndex = -1;
        }

    }
}
