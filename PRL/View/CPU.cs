using AppData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class CPU : Form
    {
        IphoneDbContext _db;
        public CPU()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void CPU_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvCPUShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hoặc bạn có thể đặt kích thước từng cột cụ thể
            // DgvCPUShow.Columns["CPUName"].Width = 150;
            // DgvCPUShow.Columns["CPUCores"].Width = 100;
            // DgvCPUShow.Columns["CPUThreads"].Width = 100;
            // DgvCPUShow.Columns["CPUClockSpeed"].Width = 100;

        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvCPUShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var CPUData = _db.CPUs.ToList().Select(c => new
                {
                    c.CPUID,
                    c.CPUName,
                    c.CPUCores,
                    c.CPUThreads,
                    c.CPUClockSpeed,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy
                }).ToList();

                if (CPUData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvCPUShow.DataSource = CPUData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvCPUShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvCPUShow.CellClick += DgvCPUShow_CellContentClick;
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

        private void DgvCPUShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvCPUShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                CPUID.Text = row.Cells["CPUID"].Value.ToString();
                CPUName.Text = row.Cells["CPUName"].Value.ToString();
                CPUCores.Text = row.Cells["CPUCores"].Value.ToString();
                CPUThreads.Text = row.Cells["CPUThreads"].Value.ToString();
                CPUClockSpeed.Text = row.Cells["CPUClockSpeed"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateCPU = MessageBox.Show("Bạn có muốn tạo thêm CPU không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateCPU == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(CPUName.Text) || string.IsNullOrWhiteSpace(CPUCores.Text) || string.IsNullOrWhiteSpace(CPUThreads.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }
                var existed = _db.CPUs.FirstOrDefault(r => r.CPUName == CPUName.Text);
                if (existed != null)
                {
                    MessageBox.Show("CPU này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var newCPU = new Cpu
                {
                    CPUID = Guid.NewGuid(), // Tạo ID mới
                    CPUName = CPUName.Text,
                    CPUCores = int.Parse(CPUCores.Text),
                    CPUThreads = int.Parse(CPUThreads.Text),
                    CPUClockSpeed = CPUClockSpeed.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.CPUs.Add(newCPU);
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
            var UpdateCPU = MessageBox.Show("Bạn có muốn cập nhật CPU không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateCPU == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(CPUName.Text) || string.IsNullOrWhiteSpace(CPUCores.Text) || string.IsNullOrWhiteSpace(CPUThreads.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(CPUID.Text) || !Guid.TryParse(CPUID.Text, out Guid CpuId))
                {
                    MessageBox.Show("Vui lòng nhập ID CPU hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingCPU = _db.CPUs.FirstOrDefault(c => c.CPUID == CpuId);

                if (existingCPU != null)
                {
                    existingCPU.CPUName = CPUName.Text;
                    existingCPU.CPUCores = int.Parse(CPUCores.Text);
                    existingCPU.CPUThreads = int.Parse(CPUThreads.Text);
                    existingCPU.CPUClockSpeed = CPUClockSpeed.Text;
                    existingCPU.CreatedAt = DateTime.Now;
                    existingCPU.CreatedBy = CBTxt.Text;
                    existingCPU.UpdatedAt = DateTime.Now;
                    existingCPU.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();

                    MessageBox.Show("Cập nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy CPU!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy bỏ cập nhật sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteCPU = MessageBox.Show("Bạn có muốn xóa CPU không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteCPU == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(CPUID.Text) || !Guid.TryParse(CPUID.Text, out Guid CpuId))
                {
                    MessageBox.Show("Vui lòng nhập ID CPU hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingCPU = _db.CPUs.FirstOrDefault(c => c.CPUID == CpuId);

                if (existingCPU != null)
                {
                    _db.CPUs.Remove(existingCPU);
                    _db.SaveChanges();

                    MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy CPU!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.CPUs.ToList().Where(c =>
                c.CPUName.ToLower().Contains(searchTerm) ||
                c.CPUCores.ToString().Contains(searchTerm) ||
                c.CPUThreads.ToString().Contains(searchTerm) ||
                c.CPUClockSpeed.ToString().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.CPUID,
                c.CPUName,
                c.CPUCores,
                c.CPUThreads,
                c.CPUClockSpeed,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy
            }).ToList();

            DgvCPUShow.DataSource = filteredData;
        }
    }
}
