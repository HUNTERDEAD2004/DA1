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
    public partial class RAM : Form
    {
        IphoneDbContext _db;

        public RAM()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void RAM_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvRAMShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvRAMShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var RamData = _db.RAMs.ToList().Select(c => new
                {
                    c.RAMID,
                    c.RAMType,
                    c.RAMSize,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy,
                }).ToList();

                if (RamData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvRAMShow.DataSource = RamData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvRAMShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvRAMShow.CellClick += DgvRAMShow_CellContentClick;
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

        private void DgvRAMShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvRAMShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                RamIdTxt.Text = row.Cells["RAMID"].Value.ToString();
                RamTypeTxt.Text = row.Cells["RAMType"].Value.ToString();
                RamSizeTxt.Text = row.Cells["RAMSize"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var updateRam = MessageBox.Show("Bạn có muốn Sửa RAM không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (updateRam == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(RamTypeTxt.Text) || string.IsNullOrWhiteSpace(RamSizeTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(RamIdTxt.Text) || !Guid.TryParse(RamIdTxt.Text, out Guid RamID))
                {
                    MessageBox.Show("Vui lòng nhập ID RAM hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingRam = _db.RAMs.FirstOrDefault(c => c.RAMID == RamID);

                if (existingRam != null)
                {
                    existingRam.RAMType = RamTypeTxt.Text;
                    existingRam.RAMSize = RamSizeTxt.Text;
                    existingRam.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    existingRam.CreatedBy = CBTxt.Text;
                    existingRam.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    existingRam.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();

                    MessageBox.Show("Sửa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy RAM!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var deleteRam = MessageBox.Show("Bạn có muốn Xóa RAM không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteRam == DialogResult.Yes)
            {

                if (string.IsNullOrWhiteSpace(RamIdTxt.Text) || !Guid.TryParse(RamIdTxt.Text, out Guid RamID))
                {
                    MessageBox.Show("Vui lòng nhập ID RAM hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingRam = _db.RAMs.FirstOrDefault(c => c.RAMID == RamID);

                if (existingRam != null)
                {
                    _db.RAMs.Remove(existingRam);
                    _db.SaveChanges();

                    MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy RAM!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Xpá Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = SearchingTxt.Text.ToLower();

            var filteredData = _db.RAMs.ToList().Where(c =>
                c.RAMSize.ToLower().Contains(searchTerm) ||
                c.RAMType.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.RAMID,
                c.RAMSize,
                c.RAMType,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy,
            }).ToList();

            DgvRAMShow.DataSource = filteredData;
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            var CreateRam = MessageBox.Show("Bạn có muốn tạo thêm RAM không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateRam == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(RamTypeTxt.Text) || string.IsNullOrWhiteSpace(RamSizeTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newRam = new Ram
                {
                    RAMID = Guid.NewGuid(), // Tạo ID mới
                    RAMSize = RamSizeTxt.Text,
                    RAMType = RamTypeTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.RAMs.Add(newRam);
                _db.SaveChanges();
                MessageBox.Show("Tạo Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Tạo Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
