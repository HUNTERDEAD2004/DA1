using AppData.Models;
using DAL.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class SaleFrm : Form
    {
        IphoneDbContext context;
        public SaleFrm()
        {
            context = new IphoneDbContext();
            InitializeComponent();
            LoadDetails();
            LoadComboBox();
            LoadSales();
            panel1.Dock = DockStyle.Fill;
        }

        private void dgvSPCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadDetails()
        {
            var productDetails = context.ProductDetails.Select(pd => new
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

            dgvSPCT.DataSource = productDetails;
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
        private List<ProductDetail> searchResults = new List<ProductDetail>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtName.Text.Trim();
            Guid? ramID = cbRam.SelectedValue as Guid?;
            Guid? romID = cbRom.SelectedValue as Guid?;

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var data = context.ProductDetails.AsQueryable();

            data = data.Where(pd => pd.Name.Contains(searchName));

            if (ramID.HasValue && ramID.Value != Guid.Empty)
            {
                data = data.Where(pd => pd.RAMID == ramID.Value);
            }

            if (romID.HasValue && romID.Value != Guid.Empty)
            {
                data = data.Where(pd => pd.ROMID == romID.Value);
            }

            string ram = cbRam.Text;
            string rom = cbRom.Text;
            searchResults = data.ToList();

            var productDetails = searchResults
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

            dgvSPCT.DataSource = productDetails;
        }

        public void LoadComboBox()
        {
            var romList = context.ROMs.ToList();
            romList.Insert(0, new Rom { ROMID = Guid.Empty, ROMSize = "-- ROM --" });
            cbRom.DataSource = romList;
            cbRom.DisplayMember = "ROMSize";
            cbRom.ValueMember = "ROMID";

            var ramList = context.RAMs.ToList();
            ramList.Insert(0, new Ram { RAMID = Guid.Empty, RAMSize = "-- RAM --" });
            cbRam.DataSource = ramList;
            cbRam.DisplayMember = "RAMSize";
            cbRam.ValueMember = "RAMID";

            var saleList = context.Sales.Where(s => s.EndDate == null || s.EndDate >= DateTime.Now).ToList();
            cbSale.DataSource = saleList;
            cbSale.DisplayMember = "DiscountValue";
            cbSale.ValueMember = "SaleID";
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            Guid selectedSaleID = (Guid)cbSale.SelectedValue;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn áp dụng mã sale này cho các sản phẩm đã chọn?", "Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (dgvSPCT.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSPCT.SelectedRows)
                {
                    var productDetailID = (Guid)row.Cells["ProductDetailID"].Value;
                    var product = context.ProductDetails.FirstOrDefault(pd => pd.ProductDetailID == productDetailID);
                    if (product != null)
                    {
                        product.SaleID = selectedSaleID;
                    }
                }
            }
            else
            {
                var productList = searchResults ?? dgvSPCT.DataSource as List<ProductDetail>;

                if (productList == null || productList.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm nào để áp dụng mã sale.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var productDetail in productList)
                {
                    var product = context.ProductDetails.FirstOrDefault(pd => pd.ProductDetailID == productDetail.ProductDetailID);
                    if (product != null)
                    {
                        product.SaleID = selectedSaleID;
                    }
                }
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            context.SaveChanges();
            var acc = new Activity
            {
                Note = $"{nameAc} Đã thêm mã sale có giá trị {txtValue}%, vào lúc {DateTime.Now}",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = nameAc,
                UpdatedBy = nameAc
            };
            context.Activities.Add(acc);
            context.SaveChanges();
            MessageBox.Show("Đã áp dụng mã sale cho các sản phẩm được chọn hoặc tìm thấy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadSales()
        {
            var data = context.Sales.Where(s => s.EndDate >= DateTime.Now).ToList();
            dgvSales.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var sale = new Sales
            {
                SaleID = Guid.NewGuid(),
                SaleDescription = txtDescription.Text,
                DiscountValue = decimal.Parse(txtValue.Text),
                StartDate = DateTime.Parse(txtStart.Text),
                EndDate = string.IsNullOrEmpty(txtEnd.Text) ? (DateTime?)null : DateTime.Parse(txtEnd.Text),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = nameAc,
                UpdatedBy = nameAc
            };

            context.Sales.Add(sale);
            context.SaveChanges();
            MessageBox.Show("Thêm mã sale thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var acc = new Activity
            {
                Note = $"{nameAc} Đã thêm một mã sale với giá trị {txtValue}, vào lúc {DateTime.Now}",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = nameAc,
                UpdatedBy = nameAc
            };
            context.Activities.Add(acc);
            context.SaveChanges();
            LoadSales();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                var saleID = (Guid)dgvSales.SelectedRows[0].Cells["SaleID"].Value;
                var sale = context.Sales.FirstOrDefault(s => s.SaleID == saleID);

                if (sale != null)
                {
                    sale.SaleDescription = txtDescription.Text;
                    sale.DiscountValue = decimal.Parse(txtValue.Text);
                    sale.StartDate = DateTime.Parse(txtStart.Text);
                    sale.EndDate = string.IsNullOrEmpty(txtEnd.Text) ? (DateTime?)null : DateTime.Parse(txtEnd.Text);
                    sale.UpdatedAt = DateTime.Now;
                    sale.UpdatedBy = "Admin";

                    context.Sales.Update(sale);
                    context.SaveChanges();
                    var acc = new Activity
                    {
                        Note = $"{nameAc} Đã sửa mã sale giá trị {txtValue}%, vào lúc {DateTime.Now}",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        CreatedBy = nameAc,
                        UpdatedBy = nameAc
                    };
                    context.Activities.Add(acc);
                    context.SaveChanges();
                    LoadSales();
                    MessageBox.Show("Cập nhật mã sale thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã sale để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị SaleID từ ô được nhấp
                var saleID = (Guid)dgvSales.Rows[e.RowIndex].Cells["SaleID"].Value;

                // Tìm mã sale dựa trên SaleID
                var sale = context.Sales.FirstOrDefault(s => s.SaleID == saleID);

                if (sale != null)
                {
                    // Hiển thị thông tin mã sale trong các điều khiển của form
                    txtDescription.Text = sale.SaleDescription;
                    txtValue.Text = sale.DiscountValue.ToString("0.00");
                    txtStart.Text = sale.StartDate.ToString("yyyy-MM-dd");
                    txtEnd.Text = sale.EndDate.HasValue ? sale.EndDate.Value.ToString("yyyy-MM-dd") : string.Empty;

                    // Tự động cập nhật CreatedAt và UpdatedAt
                    txtCreate.Text = sale.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss");
                    txtUpdate.Text = sale.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss");
                    txtUpdateBy.Text = nameAc;
                    txtCreateBy.Text = nameAc;
                }
                else
                {
                    MessageBox.Show("Mã sale không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaleFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
