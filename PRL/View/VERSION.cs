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
    public partial class VERSION : Form
    {
        IphoneDbContext _db;

        public VERSION()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void VERSION_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvVersionShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvVersionShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var VersionData = _db.Versions.ToList().Select(c => new
                {
                    c.VersionID,
                    c.VersionName,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy
                }).ToList();

                if (VersionData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvVersionShow.DataSource = VersionData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvVersionShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvVersionShow.CellClick += DgvVersionShow_CellContentClick;
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

        private void DgvVersionShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvVersionShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                VerIdTxt.Text = row.Cells["VersionID"].Value.ToString();
                VerNameTxt.Text = row.Cells["VersionName"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateVersion = MessageBox.Show("Bạn có muốn tạo thêm Version không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateVersion == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(VerNameTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }
                var existed = _db.Versions.FirstOrDefault(r => r.VersionName == VerNameTxt.Text);
                if (existed != null)
                {
                    MessageBox.Show("Kích thước RAM này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var newWeight = new DAL.Models.Versions
                {
                    VersionID = Guid.NewGuid(), // Tạo ID mới
                    VersionName = VerNameTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.Versions.Add(newWeight);
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
            var UpdateVersion = MessageBox.Show("Bạn có muốn cập nhật Version không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateVersion == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(VerNameTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(VerIdTxt.Text) || !Guid.TryParse(VerIdTxt.Text, out Guid VerID))
                {
                    MessageBox.Show("Vui lòng nhập ID Origin hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingVersion = _db.Versions.FirstOrDefault(c => c.VersionID == VerID);

                if (existingVersion != null)
                {
                    existingVersion.VersionName = VerNameTxt.Text;
                    existingVersion.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    existingVersion.CreatedBy = CBTxt.Text;
                    existingVersion.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    existingVersion.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();

                    MessageBox.Show("Cập nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Version!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy bỏ cập nhật sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteWeight = MessageBox.Show("Bạn có muốn xóa Version không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteWeight == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(VerIdTxt.Text) || !Guid.TryParse(VerIdTxt.Text, out Guid VerID))
                {
                    MessageBox.Show("Vui lòng nhập ID Origin hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingVersion = _db.Versions.FirstOrDefault(c => c.VersionID == VerID);

                if (existingVersion != null)
                {
                    _db.Versions.Remove(existingVersion);
                    _db.SaveChanges();

                    MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Version!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.Versions.ToList().Where(c =>
                c.VersionName.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.VersionID,
                c.VersionName,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy
            }).ToList();

            DgvVersionShow.DataSource = filteredData;
        }
    }
}
