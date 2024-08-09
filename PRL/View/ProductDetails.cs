using AppData.Models;
using DAL.Models;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using Irony.Parsing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
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
            RemoveExpiredSales();
        }
        public static string? GetAccountIdFromRegistry()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
                string tk = null;
                if (key != null)
                {
                    tk = key.GetValue("Username").ToString();
                    key.Close();
                    return tk;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khóa Registry", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy xuất Registry hoặc cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        string nameAc = GetAccountIdFromRegistry();
        private void LoadComboBoxData()
        {
            var ramList = context.RAMs.ToList();
            ramList.Insert(0, new Ram { RAMID = Guid.Empty, RAMSize = "-- Chọn ram --" });
            cbRam.DataSource = ramList;
            cbRamSearch.DataSource = ramList;
            cbRam.DisplayMember = "RAMSize";
            cbRam.ValueMember = "RAMID";
            cbRamSearch.DisplayMember = "RAMSize";
            cbRamSearch.ValueMember = "RAMID";

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
            cbRomSearch.DataSource = romList;
            cbRom.DisplayMember = "ROMSize";
            cbRom.ValueMember = "ROMID";
            cbRomSearch.DisplayMember = "ROMSize";
            cbRomSearch.ValueMember = "ROMID";

            var colorList = context.Colours.ToList();
            colorList.Insert(0, new AppData.Models.Color { ColorID = Guid.Empty, ColorName = "-- Chọn màu --" });
            cbColor.DataSource = colorList;
            cbColorSearch.DataSource = colorList;
            cbColor.DisplayMember = "ColorName";
            cbColor.ValueMember = "ColorID";
            cbColorSearch.DisplayMember = "ColorName";
            cbColorSearch.ValueMember = "ColorID";

            var displayList = context.Displays.ToList();
            displayList.Insert(0, new Display { DisplayID = Guid.Empty, DisplayName = "-- Chọn tấm nền --" });
            cbDisplay.DataSource = displayList;
            cbDisplay.DisplayMember = "DisplayName";
            cbDisplay.ValueMember = "DISPLAYID";

            var saleList = context.Sales
                 .Where(s => s.EndDate == null || s.EndDate >= DateTime.Now)
                 .ToList();
            saleList.Insert(0, new Sales { SaleID = Guid.Empty, DiscountValue = 0 });
            cbSale.DataSource = saleList;
            cbSale.DisplayMember = "DiscountValue";
            cbSale.ValueMember = "SaleID";
            cbSale.SelectedValue = Guid.Empty;

            var battery = context.BatteryCapacities.ToList();
            battery.Insert(0, new BatteryCapacity { BatteryID = Guid.Empty, Capacity = -1 });
            cbBattery.DataSource = battery;
            cbBattery.DisplayMember = "Capacity";
            cbBattery.ValueMember = "BatteryID";

            var os = context.OperatingSystems.ToList();
            os.Insert(0, new OperatingSystems { OSID = Guid.Empty, OSName = "-- Chọn system --" });
            cbSystem.DataSource = os;
            cbSystem.DisplayMember = "OSName";
            cbSystem.ValueMember = "OSID";

            var m = context.Materials.ToList();
            m.Insert(0, new Material { MaterialID = Guid.Empty, MaterialName = "-- Chọn chất liệu --" });
            cbMaterial.DataSource = m;
            cbMaterial.DisplayMember = "MaterialName";
            cbMaterial.ValueMember = "MaterialID";

            var o = context.Origins.ToList();
            o.Insert(0, new Origin { OriginID = Guid.Empty, OriginName = "-- Chọn xuất xứ --" });
            cbOrigin.DataSource = o;
            cbOrigin.DisplayMember = "OriginName";
            cbOrigin.ValueMember = "OriginID";

            var ver = context.Versions.ToList();
            ver.Insert(0, new DAL.Models.Versions { VersionID = Guid.Empty, VersionName = "-- Chọn phiên bản --" });
            cbVersion.DataSource = ver;
            cbVersion.DisplayMember = "VersionName";
            cbVersion.ValueMember = "VersionID";

            var rear = context.RearCameras.ToList();
            rear.Insert(0, new RearCamera { RearCameraID = Guid.Empty, RearCameraDetails = "-- Chọn thông tin camera sau --" });
            cbRear.DataSource = rear;
            cbRear.DisplayMember = "RearCameraDetails";
            cbRear.ValueMember = "RearCameraID";

            var selfie = context.CameraSelfies.ToList();
            selfie.Insert(0, new CameraSelfie { CameraSelfieID = Guid.Empty, CameraSelfieDetails = "-- Chọn thông tin camera selfie --" });
            cbSelfie.DataSource = selfie;
            cbSelfie.DisplayMember = "CameraSelfieDetails";
            cbSelfie.ValueMember = "CameraSelfieID";
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
                product.Total = context.ProductDetails.Count(pd => pd.ProductID == productId);
                context.SaveChanges();
            }
        }
        public void LoadDetails()
        {
            var productDetails = context.ProductDetails
                    .Where(pd => pd.ProductID == _productID)
                    .Select(pd => new
                    {
                        ProductDetailID = pd.ProductDetailID,
                        Name = pd.Name,
                        Color = context.Colours.FirstOrDefault(c => c.ColorID == pd.ColorID).ColorName,
                        RAM = context.RAMs.FirstOrDefault(r => r.RAMID == pd.RAMID).RAMSize,
                        Price = pd.Price,
                        CPU = context.CPUs.FirstOrDefault(c => c.CPUID == pd.CPUID).CPUName,
                        GPU = context.GPUs.FirstOrDefault(g => g.GPUID == pd.GPUID).GPUName,
                        ROM = context.ROMs.FirstOrDefault(r => r.ROMID == pd.ROMID).ROMSize,
                        Display = context.Displays.FirstOrDefault(d => d.DisplayID == pd.DisplayID).DisplayName,
                        Weight = pd.Weight,
                        Version = context.Versions.FirstOrDefault(s => s.VersionID == pd.VersionID).VersionName,
                        Rear = context.RearCameras.FirstOrDefault(s => s.RearCameraID == pd.RearCameraID).RearCameraDetails,
                        Camera_Selfie = context.CameraSelfies.FirstOrDefault(s => s.CameraSelfieID == pd.CameraSelfieID).CameraSelfieDetails,
                        Operating_System = context.OperatingSystems.FirstOrDefault(s => s.OSID == pd.OSID).OSName,
                        Battery = context.BatteryCapacities.FirstOrDefault(s => s.BatteryID == pd.BatteryID).Capacity,
                        Origin = context.Origins.FirstOrDefault(s => s.OriginID == pd.OriginID).OriginName,
                        Material = context.Materials.FirstOrDefault(s => s.MaterialID == pd.MaterialID).MaterialName,
                        Year = pd.Year,
                        Sale = context.Sales.FirstOrDefault(s => s.SaleID == pd.SaleID).DiscountValue + "%"
                    })
                    .ToList();
            dgvDetails.DataSource = productDetails;
            if (dgvDetails.Columns["ProductDetailID"] != null)
            {
                dgvDetails.Columns["ProductDetailID"].Visible = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((Guid)cbRam.SelectedValue == Guid.Empty ||
                (Guid)cbCpu.SelectedValue == Guid.Empty ||
                (Guid)cbGPU.SelectedValue == Guid.Empty ||
                (Guid)cbRom.SelectedValue == Guid.Empty ||
                (Guid)cbColor.SelectedValue == Guid.Empty ||
                (Guid)cbDisplay.SelectedValue == Guid.Empty ||
                (Guid)cbRear.SelectedValue == Guid.Empty ||
                (Guid)cbSystem.SelectedValue == Guid.Empty ||
                (Guid)cbBattery.SelectedValue == Guid.Empty ||
                (Guid)cbMaterial.SelectedValue == Guid.Empty
                )
            {
                MessageBox.Show("Vui lòng chọn tất cả các thông tin chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtName.Text == "" || txtWeight.Text == "" || txtYear.Text == "" || txtImport.Text == "")
            {
                MessageBox.Show("Không được để trống các trường dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string price = @"^\d+(\.\d+)?$";
            if (!Regex.IsMatch(txtImport.Text, price) || !Regex.IsMatch(txtPrice.Text, price))
            {
                MessageBox.Show("Giá nhập/bán không được nhập chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (decimal.Parse(txtPrice.Text) < decimal.Parse(txtImport.Text))
            {
                MessageBox.Show("Giá nhập không được lớn hơn giá bán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (int.Parse(txtQuantity.Text) < 0)
            {
                MessageBox.Show("số lượng không hợp lệ. Kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Kiểm tra sản phẩm chi tiết trùng lặp
            var existingDetail = context.ProductDetails
                .FirstOrDefault(pd => pd.ProductID == _productID &&
                                      pd.RAMID == (Guid)cbRam.SelectedValue &&
                                      pd.ROMID == (Guid)cbRom.SelectedValue &&
                                      pd.CPUID == (Guid)cbCpu.SelectedValue &&
                                      pd.GPUID == (Guid)cbGPU.SelectedValue &&
                                      pd.ColorID == (Guid)cbColor.SelectedValue);

            if (existingDetail != null)
            {
                MessageBox.Show("Đã tồn tại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Lấy giá trị từ các combobox
            string color = cbColor.Text;
            string ram = cbRam.Text;
            string cpu = cbCpu.Text;
            string gpu = cbGPU.Text;
            string rom = cbRom.Text;
            string display = cbDisplay.Text;

            // Tạo tên sản phẩm mới bằng cách kết hợp các giá trị combobox
            string newName = $"{txtName.Text} {color} {ram} {cpu} {gpu} {rom} {display}";

            // Chuyển đổi giá trị nhập liệu
            decimal prices = decimal.Parse(txtPrice.Text);
            decimal importPrice = decimal.Parse(txtImport.Text);
            int quantity = int.Parse(txtQuantity.Text);
            int weight = int.Parse(txtWeight.Text);
            int year = int.Parse(txtYear.Text);

            // Kiểm tra điều kiện giá nhập không được lớn hơn giá bán
            if (importPrice > prices)
            {
                MessageBox.Show("Giá nhập không được lớn hơn giá bán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng ProductDetail
            var detail = new ProductDetail
            {
                ProductDetailID = Guid.NewGuid(),
                ProductID = _productID,
                Name = txtName.Text,
                Price = prices,
                importPrice = importPrice,
                Quantity = quantity,
                Status = 1,
                ColorID = (Guid)cbColor.SelectedValue,
                RAMID = (Guid)cbRam.SelectedValue,
                CPUID = (Guid)cbCpu.SelectedValue,
                GPUID = (Guid)cbGPU.SelectedValue,
                ROMID = (Guid)cbRom.SelectedValue,
                DisplayID = (Guid)cbDisplay.SelectedValue,
                SaleID = cbSale.SelectedValue != null && (Guid)cbSale.SelectedValue != Guid.Empty
                ? (Guid?)cbSale.SelectedValue
                : null,
                OSID = (Guid)cbSystem.SelectedValue,
                BatteryID = (Guid)cbBattery.SelectedValue,
                Weight = weight,
                Year = year,
                MaterialID = (Guid)cbMaterial.SelectedValue,
                OriginID = (Guid)cbOrigin.SelectedValue,
                VersionID = (Guid)cbVersion.SelectedValue,
                RearCameraID = (Guid)cbRear.SelectedValue,
                CameraSelfieID = (Guid)cbSelfie.SelectedValue
            };

            context.ProductDetails.Add(detail);
            context.SaveChanges();
            UpdateProductQuantity(_productID);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var acc = new Activity
            {
                Note = $"{nameAc} Đã thêm sản phẩm {ProductName} với {cbRam.SelectedValue}, {cbRom.SelectedValue}, {cbColor.SelectedValue}, vào lúc {DateTime.Now}",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = nameAc,
                UpdatedBy = nameAc
            };
            context.Activities.Add(acc);
            context.SaveChanges();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                var productDetailID = (Guid)dgvDetails.SelectedRows[0].Cells["ProductDetailID"].Value;

                var detail = context.ProductDetails.Find(productDetailID);

                if (detail != null)
                {
                    if (string.IsNullOrEmpty(txtName.Text) ||
                        int.Parse(txtWeight.Text) == 0)

                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ và chính xác các trường dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra lựa chọn của các ComboBox
                    if (cbColor.SelectedValue == null ||
                        cbRam.SelectedValue == null ||
                        cbCpu.SelectedValue == null ||
                        cbGPU.SelectedValue == null ||
                        cbRom.SelectedValue == null ||
                        cbDisplay.SelectedValue == null ||
                        cbSale.SelectedValue == null ||
                        cbSystem.SelectedValue == null ||
                        cbBattery.SelectedValue == null ||
                        cbOrigin.SelectedValue == null ||
                        cbMaterial.SelectedValue == null ||
                        cbVersion.SelectedValue == null ||
                        cbRear.SelectedValue == null ||
                        cbSelfie.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn tất cả các tùy chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật các thuộc tính của chi tiết sản phẩm
                    detail.Name = txtName.Text;
                    detail.Price = decimal.Parse(txtPrice.Text);
                    detail.importPrice = decimal.Parse(txtImport.Text);
                    detail.Quantity = int.Parse(txtQuantity.Text);
                    detail.ColorID = (Guid)cbColor.SelectedValue;
                    detail.RAMID = (Guid)cbRam.SelectedValue;
                    detail.CPUID = (Guid)cbCpu.SelectedValue;
                    detail.GPUID = (Guid)cbGPU.SelectedValue;
                    detail.ROMID = (Guid)cbRom.SelectedValue;
                    detail.DisplayID = (Guid)cbDisplay.SelectedValue;
                    detail.CameraSelfieID = (Guid)cbSelfie.SelectedValue;
                    detail.RearCameraID = (Guid)cbRear.SelectedValue;
                    detail.VersionID = (Guid)cbVersion.SelectedValue;
                    detail.OSID = (Guid)cbSystem.SelectedValue;
                    detail.BatteryID = (Guid)cbBattery.SelectedValue;
                    detail.OriginID = (Guid)cbOrigin.SelectedValue;
                    detail.MaterialID = (Guid)cbMaterial.SelectedValue;
                    detail.Weight = int.Parse(txtWeight.Text);
                    detail.Year = int.Parse(txtYear.Text);

                    var saleId = cbSale.SelectedValue != null ? (Guid?)cbSale.SelectedValue : null;
                    detail.SaleID = saleId.HasValue && context.Sales.Any(s => s.SaleID == saleId.Value) ? saleId : null;

                    context.ProductDetails.Update(detail);
                    context.SaveChanges();

                    MessageBox.Show("Cập nhật chi tiết sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var acc = new Activity
                    {
                        Note = $"{nameAc} Đã sửa sản phẩm {ProductName}, vào lúc {DateTime.Now}",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        CreatedBy = nameAc,
                        UpdatedBy = nameAc
                    };
                    context.Activities.Add(acc);
                    context.SaveChanges();
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
                MessageBox.Show("Vui lòng chọn một chi tiết sản phẩm để cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấp vào một hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvDetails.Rows[e.RowIndex];

                // Lấy giá trị ProductDetailID từ ô được nhấp
                var cellValue = selectedRow.Cells["ProductDetailID"].Value;

                if (cellValue != null && Guid.TryParse(cellValue.ToString(), out Guid productDetailID))
                {
                    // Tìm chi tiết sản phẩm dựa trên ProductDetailID
                    var productDetail = context.ProductDetails.FirstOrDefault(pd => pd.ProductDetailID == productDetailID);

                    if (productDetail != null)
                    {
                        // Kiểm tra nếu ngày kết thúc của Sale đã qua
                        if (productDetail.Sale != null && productDetail.Sale.EndDate < DateTime.Now)
                        {
                            productDetail.SaleID = null;
                            context.ProductDetails.Update(productDetail);
                            context.SaveChanges();
                        }

                        // Cập nhật các giá trị vào các điều khiển
                        txtImport.Text = productDetail.importPrice.ToString("0.00");
                        txtPrice.Text = productDetail.Price.ToString("0.00");
                        txtYear.Text = productDetail.Year.ToString();
                        txtWeight.Text = productDetail.Weight.ToString();
                        cbColor.SelectedValue = productDetail.ColorID;
                        cbRam.SelectedValue = productDetail.RAMID;
                        cbCpu.SelectedValue = productDetail.CPUID;
                        cbGPU.SelectedValue = productDetail.GPUID;
                        cbRom.SelectedValue = productDetail.ROMID;
                        cbRear.SelectedValue = productDetail.RearCameraID;
                        cbSelfie.SelectedValue = productDetail.CameraSelfieID;
                        cbVersion.SelectedValue = productDetail.VersionID;
                        cbOrigin.SelectedValue = productDetail.OriginID;
                        cbBattery.SelectedValue = productDetail.BatteryID;
                        cbDisplay.SelectedValue = productDetail.DisplayID;
                        cbSale.SelectedValue = productDetail.SaleID ?? Guid.Empty;
                        cbSystem.SelectedValue = productDetail.OSID;
                        cbMaterial.SelectedValue = productDetail.MaterialID;
                        txtQuantity.Text = productDetail.Quantity.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Chi tiết sản phẩm không tìm thấy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ProductDetailID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                // Lấy ProductDetailID từ dòng được chọn trong DataGridView
                var productDetailID = (Guid)dgvDetails.SelectedRows[0].Cells["ProductDetailID"].Value;

                // Tìm chi tiết sản phẩm dựa trên ProductDetailID
                var detail = context.ProductDetails.FirstOrDefault(pd => pd.ProductDetailID == productDetailID);

                if (detail != null)
                {
                    var productId = detail.ProductID;
                    context.ProductDetails.Remove(detail);
                    context.SaveChanges();

                    UpdateProductQuantity(productId);

                    MessageBox.Show("Xóa chi tiết sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var acc = new Activity
                    {
                        Note = $"{nameAc} Đã xóa sản phẩm {ProductName}, vào lúc {DateTime.Now}",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        CreatedBy = nameAc,
                        UpdatedBy = nameAc
                    };
                    context.Activities.Add(acc);
                    context.SaveChanges();
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
                MessageBox.Show("Vui lòng chọn một chi tiết sản phẩm để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {
            txtQuantity.Text = "";
            txtName.Text = "";
            cbColor.SelectedIndex = -1;
            cbRam.SelectedIndex = -1;
            txtPrice.Text = "";
            cbCpu.SelectedIndex = -1;
            cbGPU.SelectedIndex = -1;
            cbRom.SelectedIndex = -1;
            cbDisplay.SelectedIndex = -1;
            cbSale.SelectedIndex = -1;
            cbBattery.SelectedIndex = -1;
            cbSystem.SelectedValue = "";
            cbSelfie.SelectedValue = "";
            cbRear.SelectedValue = "";
            cbVersion.SelectedValue = "";
            cbSystem.SelectedValue = "";
            cbSystem.SelectedValue = "";
            cbMaterial.SelectedValue = "";
            txtWeight.Text = "";
            txtYear.SelectedValue = "";
            cbOrigin.SelectedValue = "";
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }
        public void RemoveExpiredSales()
        {
            var expiredSales = context.Sales.Where(s => s.EndDate < DateTime.Now).ToList();

            foreach (var sale in expiredSales)
            {
                var productDetailsWithSale = context.ProductDetails
                    .Where(pd => pd.SaleID == sale.SaleID)
                    .ToList();

                foreach (var productDetail in productDetailsWithSale)
                {
                    productDetail.SaleID = null;
                }

                context.ProductDetails.UpdateRange(productDetailsWithSale);
            }

            // Bước 3: Xóa các mã khuyến mãi khỏi bảng Sales
            context.Sales.RemoveRange(expiredSales);
            context.SaveChanges();
        }

        private void bcSale_Click(object sender, EventArgs e)
        {
            SaleFrm sale = new SaleFrm();
            sale.Show();
        }

        private void bcRam_Click(object sender, EventArgs e)
        {
            RAM rAM = new RAM();
            rAM.Show();
        }

        private void bcCpu_Click(object sender, EventArgs e)
        {
            CPU cu = new CPU();
            cu.Show();
        }

        private void bcGpu_Click(object sender, EventArgs e)
        {
            GPU gpu = new GPU();
            gpu.Show();
        }

        private void bcRom_Click(object sender, EventArgs e)
        {
            ROM rROM = new ROM();
            rROM.Show();
        }

        private void bcDisplay_Click(object sender, EventArgs e)
        {
            ManHinh display = new ManHinh();
            display.Show();
        }

        private void bcRC_Click(object sender, EventArgs e)
        {
            CamSau cs = new CamSau();
            cs.Show();
        }

        private void bcCS_Click(object sender, EventArgs e)
        {
            CamTruoc camTruoc = new CamTruoc();
            camTruoc.Show();
        }

        private void bcYOM_Click(object sender, EventArgs e)
        {

        }

        private void bcMater_Click(object sender, EventArgs e)
        {
            NguyenLieu nguyenLieu = new NguyenLieu();
            nguyenLieu.Show();
        }

        private void bcOrigin_Click(object sender, EventArgs e)
        {
            ORIGIN oRIGIN = new ORIGIN();
            oRIGIN.Show();
        }

        private void bcWght_Click(object sender, EventArgs e)
        {

        }

        private void bcSys_Click(object sender, EventArgs e)
        {
            HeDieuHanh heDieuHanh = new HeDieuHanh();
            heDieuHanh.Show();
        }

        private void bcBT_Click(object sender, EventArgs e)
        {
            Battery battery = new Battery();
            battery.Show();
        }

        private void bcVer_Click(object sender, EventArgs e)
        {
            VERSION ver = new VERSION();
            ver.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadProduct();
            LoadDetails();
        }

        private void btnImei_Click(object sender, EventArgs e)
        {
            //IMEI meiI = new IMEI();
        }

        private List<ProductDetail> searchResults = new List<ProductDetail>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtName.Text.Trim();
            Guid? ramID = cbRam.SelectedValue as Guid?;
            Guid? romID = cbRom.SelectedValue as Guid?;
            Guid? colorID = cbColor.SelectedValue as Guid?;

            if (string.IsNullOrEmpty(searchName) &&
                (!ramID.HasValue || ramID.Value == Guid.Empty) &&
                (!romID.HasValue || romID.Value == Guid.Empty) &&
                (!colorID.HasValue || colorID.Value == Guid.Empty))
            {
                MessageBox.Show("Vui lòng nhập ít nhất một điều kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var data = context.ProductDetails.AsQueryable();

            if (!string.IsNullOrEmpty(searchName))
            {
                data = data.Where(pd => pd.Name.Contains(searchName));
            }

            if (ramID.HasValue && ramID.Value != Guid.Empty)
            {
                data = data.Where(pd => pd.RAMID == ramID.Value);
            }

            if (romID.HasValue && romID.Value != Guid.Empty)
            {
                data = data.Where(pd => pd.ROMID == romID.Value);
            }

            if (colorID.HasValue && colorID.Value != Guid.Empty)
            {
                data = data.Where(pd => pd.ColorID == colorID.Value);
            }
            searchResults = data.ToList();

            if (searchResults.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào thỏa mãn điều kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var productDetails = searchResults
            .Select(pd => new
            {
                ProductDetailID = pd.ProductDetailID,
                Name = pd.Name,
                Color = context.Colours.FirstOrDefault(c => c.ColorID == pd.ColorID)?.ColorName,
                RAM = context.RAMs.FirstOrDefault(r => r.RAMID == pd.RAMID)?.RAMSize,
                ROM = context.ROMs.FirstOrDefault(r => r.ROMID == pd.ROMID)?.ROMSize,
                CPU = context.CPUs.FirstOrDefault(c => c.CPUID == pd.CPUID)?.CPUName,
                GPU = context.GPUs.FirstOrDefault(g => g.GPUID == pd.GPUID)?.GPUName,
                Display = context.Displays.FirstOrDefault(d => d.DisplayID == pd.DisplayID)?.DisplayName,
                Weight = pd.Weight,
                Version = context.Versions.FirstOrDefault(v => v.VersionID == pd.VersionID)?.VersionName,
                RearCamera = context.RearCameras.FirstOrDefault(rc => rc.RearCameraID == pd.RearCameraID)?.RearCameraDetails,
                CameraSelfie = context.CameraSelfies.FirstOrDefault(cs => cs.CameraSelfieID == pd.CameraSelfieID)?.CameraSelfieDetails,
                OperatingSystem = context.OperatingSystems.FirstOrDefault(os => os.OSID == pd.OSID)?.OSName,
                Battery = context.BatteryCapacities.FirstOrDefault(b => b.BatteryID == pd.BatteryID)?.Capacity,
                Origin = context.Origins.FirstOrDefault(o => o.OriginID == pd.OriginID)?.OriginName,
                Material = context.Materials.FirstOrDefault(m => m.MaterialID == pd.MaterialID)?.MaterialName,
                Year = pd.Year,
                Price = pd.Price,
                Sale = pd.SaleID.HasValue
                       ? context.Sales.FirstOrDefault(s => s.SaleID == pd.SaleID)?.DiscountValue + "%"
                       : "No Sale"
            })
            .ToList();

            dgvDetails.DataSource = productDetails;
        }

    }
}
