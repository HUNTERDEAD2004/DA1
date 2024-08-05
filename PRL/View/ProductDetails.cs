using AppData.Models;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            var saleList = context.Sales.Where(s => s.EndDate == null || s.EndDate >= DateTime.Now).ToList();
            cbSale.DataSource = saleList;
            cbSale.DisplayMember = "DiscountValue";
            cbSale.ValueMember = "SaleID";

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

            var weight = context.Weights.ToList();
            weight.Insert(0, new Weight { WeightID = Guid.Empty, WeightValue = -1 });
            cbWeight.DataSource = weight;
            cbWeight.DisplayMember = "WeightValue";
            cbWeight.ValueMember = "WeightID";

            var year = context.YearsOfManufacture.ToList();
            year.Insert(0, new YearOfManufacture { YearID = Guid.Empty, Year = -1 });
            cbYOM.DataSource = year;
            cbYOM.DisplayMember = "Year";
            cbYOM.ValueMember = "YearID";

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
                product.Quantity = context.ProductDetails.Count(pd => pd.ProductID == productId);
                context.SaveChanges();
            }
        }
        public void LoadDetails()
        {
            var productDetails = context.ProductDetails
                    .Where(pd => pd.ProductID == _productID)
                    .Select(pd => new
                    {
                        pd.IMEI,
                        pd.Name,
                        Color = context.Colours.FirstOrDefault(c => c.ColorID == pd.ColorID).ColorName,
                        RAM = context.RAMs.FirstOrDefault(r => r.RAMID == pd.RAMID).RAMSize,
                        Price = pd.Price,
                        CPU = context.CPUs.FirstOrDefault(c => c.CPUID == pd.CPUID).CPUName,
                        GPU = context.GPUs.FirstOrDefault(g => g.GPUID == pd.GPUID).GPUName,
                        ROM = context.ROMs.FirstOrDefault(r => r.ROMID == pd.ROMID).ROMSize,
                        Display = context.Displays.FirstOrDefault(d => d.DisplayID == pd.DisplayID).DisplayName,
                        Weight = context.Weights.FirstOrDefault(s => s.WeightID == pd.WeightID).WeightValue,
                        Version = context.Versions.FirstOrDefault(s => s.VersionID == pd.VersionID).VersionName,
                        Rear = context.RearCameras.FirstOrDefault(s => s.RearCameraID == pd.RearCameraID).RearCameraDetails,
                        Camera_Selfie = context.CameraSelfies.FirstOrDefault(s => s.CameraSelfieID == pd.CameraSelfieID).CameraSelfieDetails,
                        Operating_System = context.OperatingSystems.FirstOrDefault(s => s.OSID == pd.OSID).OSName,
                        Battery = context.BatteryCapacities.FirstOrDefault(s => s.BatteryID == pd.BatteryID).Capacity,
                        Origin = context.Origins.FirstOrDefault(s => s.OriginID == pd.OriginID).OriginName,
                        Material = context.Materials.FirstOrDefault(s => s.MaterialID == pd.MaterialID).MaterialName,
                        Year_Of_Manufacture = context.YearsOfManufacture.FirstOrDefault(s => s.YearID == pd.YearID).Year,
                        Sale = context.Sales.FirstOrDefault(s => s.SaleID == pd.SaleID).DiscountValue + "%"
                    })
                    .ToList();

            dgvDetails.DataSource = productDetails;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((Guid)cbRam.SelectedValue == Guid.Empty ||
                (Guid)cbCpu.SelectedValue == Guid.Empty ||
                (Guid)cbGPU.SelectedValue == Guid.Empty ||
                (Guid)cbRom.SelectedValue == Guid.Empty ||
                (Guid)cbColor.SelectedValue == Guid.Empty ||
                (Guid)cbDisplay.SelectedValue == Guid.Empty ||
                (Guid)cbSale.SelectedValue == Guid.Empty ||
                (Guid)cbRear.SelectedValue == Guid.Empty ||
                (Guid)cbVersion.SelectedValue == Guid.Empty ||
                (Guid)cbOrigin.SelectedValue == Guid.Empty ||
                (Guid)cbWeight.SelectedValue == Guid.Empty ||
                (Guid)cbSelfie.SelectedValue == Guid.Empty ||
                (Guid)cbSystem.SelectedValue == Guid.Empty ||
                (Guid)cbYOM.SelectedValue == Guid.Empty ||
                (Guid)cbBattery.SelectedValue == Guid.Empty ||
                (Guid)cbMaterial.SelectedValue == Guid.Empty
                )
            {
                MessageBox.Show("Vui lòng chọn tất cả các thông tin chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string imei = txtImei.Text;
            string imeiPattern = @"^\d{15,}$";
            if (!Regex.IsMatch(imei, imeiPattern))
            {
                MessageBox.Show("IMEI phải là chuỗi số và có ít nhất 15 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var detail = new ProductDetail
            {
                IMEI = txtImei.Text,
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
                CameraSelfieID = (Guid)cbSelfie.SelectedValue,
                RearCameraID = (Guid)cbRear.SelectedValue,
                VersionID = (Guid)cbVersion.SelectedValue,
                OSID = (Guid)cbSystem.SelectedValue,
                WeightID = (Guid)cbWeight.SelectedValue,
                BatteryID = (Guid)cbBattery.SelectedValue,
                OriginID = (Guid)cbOrigin.SelectedValue,
                MaterialID = (Guid)cbMaterial.SelectedValue,
                YearID = (Guid)cbYOM.SelectedValue,
                Status = 1,
            };

            context.ProductDetails.Add(detail);
            context.SaveChanges();
            UpdateProductQuantity(_productID);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra và cập nhật chi tiết sản phẩm dựa trên IMEI
            if (!string.IsNullOrEmpty(txtImei.Text))
            {
                var imei = txtImei.Text;

                // Tìm chi tiết sản phẩm dựa trên IMEI
                var detail = context.ProductDetails.FirstOrDefault(pd => pd.IMEI == imei);

                if (detail != null)
                {
                    // Cập nhật các thuộc tính của chi tiết sản phẩm
                    detail.importPrice = decimal.Parse(txtPrice.Text);
                    detail.Name = txtName.Text;
                    detail.ColorID = (Guid)cbColor.SelectedValue;
                    detail.RAMID = (Guid)cbRam.SelectedValue;
                    detail.Price = decimal.Parse(txtPrice.Text);
                    detail.CPUID = (Guid)cbCpu.SelectedValue;
                    detail.GPUID = (Guid)cbGPU.SelectedValue;
                    detail.ROMID = (Guid)cbRom.SelectedValue;
                    detail.DisplayID = (Guid)cbDisplay.SelectedValue;
                    var saleId = cbSale.SelectedValue != null ? (Guid)cbSale.SelectedValue : Guid.Empty;
                    var saleExists = context.Sales.Any(s => s.SaleID == saleId);

                    detail.SaleID = saleExists ? saleId : new Guid("fda777df-d952-48c9-a916-ef6b90547878");
                    detail.CameraSelfieID = (Guid)cbSelfie.SelectedValue;
                    detail.RearCameraID = (Guid)cbRear.SelectedValue;
                    detail.VersionID = (Guid)cbVersion.SelectedValue;
                    detail.OSID = (Guid)cbSystem.SelectedValue;
                    detail.WeightID = (Guid)cbWeight.SelectedValue;
                    detail.BatteryID = (Guid)cbBattery.SelectedValue;
                    detail.OriginID = (Guid)cbOrigin.SelectedValue;
                    detail.MaterialID = (Guid)cbMaterial.SelectedValue;
                    detail.YearID = (Guid)cbYOM.SelectedValue;

                    // Cập nhật chi tiết sản phẩm trong cơ sở dữ liệu
                    context.ProductDetails.Update(detail);
                    context.SaveChanges();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Cập nhật chi tiết sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu
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
                var imeiCell = dgvDetails.Rows[e.RowIndex].Cells["IMEI"].Value as string;

                if (!string.IsNullOrEmpty(imeiCell))
                {
                    // Tìm chi tiết sản phẩm dựa trên IMEI
                    var productDetail = context.ProductDetails.FirstOrDefault(pd => pd.IMEI == imeiCell);

                    if (productDetail != null)
                    {
                        if (productDetail.Sale != null && productDetail.Sale.EndDate < DateTime.Now)
                        {
                            Guid fixedSaleID = new Guid("fda777df-d952-48c9-a916-ef6b90547878");
                            productDetail.SaleID = fixedSaleID;
                            context.ProductDetails.Update(productDetail);
                            context.SaveChanges();
                        }
                        txtImei.Text = productDetail.IMEI;
                        txtImport.Text = productDetail.importPrice.ToString("0.00");
                        cbColor.SelectedValue = productDetail.ColorID;
                        cbRam.SelectedValue = productDetail.RAMID;
                        txtPrice.Text = productDetail.Price.ToString("0.00");
                        cbCpu.SelectedValue = productDetail.CPUID;
                        cbGPU.SelectedValue = productDetail.GPUID;
                        cbRom.SelectedValue = productDetail.ROMID;
                        cbRear.SelectedValue = productDetail.RearCameraID;
                        cbSelfie.SelectedValue = productDetail.CameraSelfieID;
                        cbVersion.SelectedValue = productDetail.VersionID;
                        cbYOM.SelectedValue = productDetail.YearID;
                        cbWeight.SelectedValue = productDetail.WeightID;
                        cbOrigin.SelectedValue = productDetail.OriginID;
                        cbBattery.SelectedValue = productDetail.BatteryID;
                        cbDisplay.SelectedValue = productDetail.DisplayID;
                        cbSale.SelectedValue = productDetail.SaleID ?? Guid.Empty;
                        cbSystem.SelectedValue = productDetail.OSID;
                        cbMaterial.SelectedValue = productDetail.MaterialID;
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
            // Kiểm tra và xóa chi tiết sản phẩm dựa trên IMEI
            if (!string.IsNullOrEmpty(txtImei.Text))
            {
                var imei = txtImei.Text;

                // Tìm chi tiết sản phẩm dựa trên IMEI
                var detail = context.ProductDetails.FirstOrDefault(pd => pd.IMEI == imei);

                if (detail != null)
                {
                    var productId = detail.ProductID;

                    // Xóa chi tiết sản phẩm
                    context.ProductDetails.Remove(detail);
                    context.SaveChanges();

                    // Cập nhật số lượng sản phẩm (nếu cần)
                    UpdateProductQuantity(productId);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Xóa chi tiết sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu và làm sạch form
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
            cbBattery.SelectedIndex = -1;
            cbSystem.SelectedValue = "";
            cbSelfie.SelectedValue = "";
            cbRear.SelectedValue = "";
            cbVersion.SelectedValue = "";
            cbSystem.SelectedValue = "";
            cbSystem.SelectedValue = "";
            cbMaterial.SelectedValue = "";
            cbWeight.SelectedValue = -1;
            cbYOM.SelectedValue = "";
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
            NamSanXuat namSanXuat = new NamSanXuat();
            namSanXuat.Show();
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
            WEIGHT wEIGHT = new WEIGHT();
            wEIGHT.Show();
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
    }
}
