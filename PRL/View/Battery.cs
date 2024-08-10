using AppData.Models;
using DAL.Models;
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
    public partial class Battery : Form
    {
        IphoneDbContext _db;

        public Battery()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void DgvBatteryShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvBatteryShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                BatteryiIdTxt.Text = row.Cells["BatteryID"].Value.ToString();
                CapicityTxt.Text = row.Cells["Capacity"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void Battery_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvBatteryShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvBatteryShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var BatteryData = _db.BatteryCapacities.ToList().Select(c => new
                {
                    c.BatteryID,
                    c.Capacity,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy
                }).ToList();

                if (BatteryData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvBatteryShow.DataSource = BatteryData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvBatteryShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvBatteryShow.CellClick += DgvBatteryShow_CellContentClick;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateVersion = MessageBox.Show("Bạn có muốn tạo thêm Battery không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateVersion == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(CapicityTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }
                var existed = _db.BatteryCapacities.FirstOrDefault(r => r.Capacity == int.Parse(CapicityTxt.Text));
                if (existed != null)
                {
                    MessageBox.Show("Dung lượng pin này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var newBattery = new BatteryCapacity
                {
                    BatteryID = Guid.NewGuid(), // Tạo ID mới
                    Capacity = int.Parse(CapicityTxt.Text),
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.BatteryCapacities.Add(newBattery);
                _db.SaveChanges();
                MessageBox.Show("Tạo Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Tạo Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var UpdateVersion = MessageBox.Show("Bạn có muốn cập nhật Battery không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateVersion == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(CapicityTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(BatteryiIdTxt.Text) || !Guid.TryParse(BatteryiIdTxt.Text, out Guid BatteryID))
                {
                    MessageBox.Show("Vui lòng nhập ID Battery hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingBattery = _db.BatteryCapacities.FirstOrDefault(c => c.BatteryID == BatteryID);

                if (existingBattery != null)
                {
                    existingBattery.Capacity =  int.Parse(CapicityTxt.Text);
                    existingBattery.CreatedAt = DateTime.Now;
                    existingBattery.CreatedBy = CBTxt.Text;
                    existingBattery.UpdatedAt = DateTime.Now;
                    existingBattery.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();

                    MessageBox.Show("Cập nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Battery!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy bỏ cập nhật sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteWeight = MessageBox.Show("Bạn có muốn xóa Battery không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteWeight == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(BatteryiIdTxt.Text) || !Guid.TryParse(BatteryiIdTxt.Text, out Guid BatteryID))
                {
                    MessageBox.Show("Vui lòng nhập ID Battery hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingBattery = _db.BatteryCapacities.FirstOrDefault(c => c.BatteryID == BatteryID);

                if (existingBattery != null)
                {
                    _db.BatteryCapacities.Remove(existingBattery);
                    _db.SaveChanges();

                    MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Battery!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy bỏ xóa sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = SearchingTxt.Text.ToLower();

            var filteredData = _db.BatteryCapacities.ToList().Where(c =>
                c.Capacity.ToString().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.BatteryID,
                c.Capacity,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy
            }).ToList();

            DgvBatteryShow.DataSource = filteredData;
        }
    }
}
