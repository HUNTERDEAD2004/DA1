using AppData.Models;
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
    public partial class GPU : Form
    {
        IphoneDbContext _db;

        public GPU()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void GPU_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvGPUShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvGPUShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var GPUData = _db.GPUs.ToList().Select(c => new
                {
                    c.GPUID,
                    c.GPUName,
                    c.GPUMemory,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy,
                }).ToList();

                if (GPUData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvGPUShow.DataSource = GPUData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvGPUShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //// Gán sự kiện CellClick cho DataGridView
                    DgvGPUShow.CellClick += DgvGPUShow_CellContentClick;
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

        private void DgvGPUShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvGPUShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                GpuIdTxt.Text = row.Cells["GPUID"].Value.ToString();
                GpuNameTxt.Text = row.Cells["GPUName"].Value.ToString();
                GpuMemoryTxt.Text = row.Cells["GPUMemory"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateGPU = MessageBox.Show("Bạn có muốn tạo thêm GPU không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateGPU == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(GpuNameTxt.Text) || string.IsNullOrWhiteSpace(GpuMemoryTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }
                var existed = _db.GPUs.FirstOrDefault(r => r.GPUName == GpuNameTxt.Text);
                if (existed != null)
                {
                    MessageBox.Show("GPU này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var newGPU = new Gpu
                {
                    GPUID = Guid.NewGuid(), // Tạo ID mới
                    GPUName = GpuNameTxt.Text,
                    GPUMemory = GpuMemoryTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.GPUs.Add(newGPU);
                _db.SaveChanges();
                MessageBox.Show("Tạo Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Tạo Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteGPU = MessageBox.Show("Bạn có muốn Xóa GPU không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteGPU == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(GpuIdTxt.Text) || !Guid.TryParse(GpuIdTxt.Text, out Guid GPUId))
                {
                    MessageBox.Show("Vui lòng nhập ID GPU hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingGPU = _db.GPUs.FirstOrDefault(r => r.GPUID == GPUId);

                if (ExitingGPU != null)
                {
                    _db.GPUs.Remove(ExitingGPU);
                    _db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy GPU!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var UpdateGPU = MessageBox.Show("Bạn có muốn sửa GPU không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateGPU == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(GpuNameTxt.Text) || string.IsNullOrWhiteSpace(GpuMemoryTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(GpuIdTxt.Text) || !Guid.TryParse(GpuIdTxt.Text, out Guid GPUId))
                {
                    MessageBox.Show("Vui lòng nhập ID GPU hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingGPU = _db.GPUs.FirstOrDefault(r => r.GPUID == GPUId);

                if (ExitingGPU != null)
                {
                    ExitingGPU.GPUName = GpuNameTxt.Text;
                    ExitingGPU.GPUMemory = GpuMemoryTxt.Text;
                    ExitingGPU.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingGPU.CreatedBy = CBTxt.Text;
                    ExitingGPU.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingGPU.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();
                    MessageBox.Show("Sửa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy GPU!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = SearchingTxt.Text.ToLower();

            var filteredData = _db.GPUs.ToList().Where(c =>
                c.GPUName.ToLower().Contains(searchTerm) ||
                c.GPUMemory.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.GPUID,
                c.GPUName,
                c.GPUMemory,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy,
            }).ToList();

            DgvGPUShow.DataSource = filteredData;
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
