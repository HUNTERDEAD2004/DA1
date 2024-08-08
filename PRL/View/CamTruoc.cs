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
    public partial class CamTruoc : Form
    {
        IphoneDbContext _db;

        public CamTruoc()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void CamTruoc_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvRearCamShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvRearCamShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var RearCameraData = _db.RearCameras.ToList().Select(c => new
                {
                    c.RearCameraID,
                    c.RearCameraDetails,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy
                }).ToList();

                if (RearCameraData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvRearCamShow.DataSource = RearCameraData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvRearCamShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvRearCamShow.CellClick += DgvRearCamShow_CellContentClick;
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

        private void DgvRearCamShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvRearCamShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                RearCamIdTxt.Text = row.Cells["BatteryID"].Value.ToString();
                RearCameraDetailsTxt.Text = row.Cells["Capacity"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateVersion = MessageBox.Show("Bạn có muốn tạo thêm RearCamera không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateVersion == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(RearCameraDetailsTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newRearCamera = new RearCamera
                {
                    RearCameraID = Guid.NewGuid(), // Tạo ID mới
                    RearCameraDetails = RearCameraDetailsTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.RearCameras.Add(newRearCamera);
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
            var UpdateVersion = MessageBox.Show("Bạn có muốn cập nhật RearCamera không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateVersion == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(RearCameraDetailsTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(RearCamIdTxt.Text) || !Guid.TryParse(RearCamIdTxt.Text, out Guid RearCamID))
                {
                    MessageBox.Show("Vui lòng nhập ID RearCamera hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingCamRear = _db.RearCameras.FirstOrDefault(c => c.RearCameraID == RearCamID);

                if (existingCamRear != null)
                {
                    existingCamRear.RearCameraDetails = RearCameraDetailsTxt.Text;
                    existingCamRear.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    existingCamRear.CreatedBy = CBTxt.Text;
                    existingCamRear.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    existingCamRear.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();

                    MessageBox.Show("Cập nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy RearCamera!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy bỏ cập nhật sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteWeight = MessageBox.Show("Bạn có muốn xóa RearCamera không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteWeight == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(RearCamIdTxt.Text) || !Guid.TryParse(RearCamIdTxt.Text, out Guid RearCamID))
                {
                    MessageBox.Show("Vui lòng nhập ID RearCamera hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingCamRear = _db.RearCameras.FirstOrDefault(c => c.RearCameraID == RearCamID);

                if (existingCamRear != null)
                {
                    _db.RearCameras.Remove(existingCamRear);
                    _db.SaveChanges();

                    MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy RearCamera!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.RearCameras.ToList().Where(c =>
                c.RearCameraDetails.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.RearCameraID,
                c.RearCameraDetails,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy
            }).ToList();

            DgvRearCamShow.DataSource = filteredData;
        }
    }
}
