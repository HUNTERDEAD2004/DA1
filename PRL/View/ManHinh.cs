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
    public partial class ManHinh : Form
    {
        IphoneDbContext _db;

        public ManHinh()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void ManHinh_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvDIsPlayShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvDIsPlayShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var DisplayData = _db.Displays.ToList().Select(c => new
                {
                    c.DisplayID,
                    c.DisplayName,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy,

                }).ToList();

                if (DisplayData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvDIsPlayShow.DataSource = DisplayData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvDIsPlayShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvDIsPlayShow.CellClick += DgvDIsPlayShow_CellContentClick;
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

        private void DgvDIsPlayShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvDIsPlayShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                DisPlayId.Text = row.Cells["DisplayID"].Value.ToString();
                DisPlayName.Text = row.Cells["DisplayName"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateDisplay = MessageBox.Show("Bạn có muốn tạo thêm Display không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateDisplay == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(DisPlayName.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newDisplay = new Display
                {
                    DisplayID = Guid.NewGuid(), // Tạo ID mới
                    DisplayName = DisPlayName.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.Displays.Add(newDisplay);
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
            var deleteDisplay = MessageBox.Show("Bạn có muốn Xóa Display không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteDisplay == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(DisPlayId.Text) || !Guid.TryParse(DisPlayId.Text, out Guid DisplayId))
                {
                    MessageBox.Show("Vui lòng nhập ID Display hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingDisplay = _db.Displays.FirstOrDefault(c => c.DisplayID == DisplayId);

                if (existingDisplay != null)
                {
                    _db.Displays.Remove(existingDisplay);
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
                MessageBox.Show("Xóa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = SearchingTxt.Text.ToLower();

            var filteredData = _db.Displays.ToList().Where(c =>
                c.DisplayName.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.DisplayID,
                c.DisplayName,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy,

            }).ToList();

            DgvDIsPlayShow.DataSource = filteredData;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var updateDisplay = MessageBox.Show("Bạn có muốn Sửa Display không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (updateDisplay == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(DisPlayName.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(DisPlayId.Text) || !Guid.TryParse(DisPlayId.Text, out Guid DisplayId))
                {
                    MessageBox.Show("Vui lòng nhập ID Display hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingDisplay = _db.Displays.FirstOrDefault(c => c.DisplayID == DisplayId);

                if (existingDisplay != null)
                {
                    existingDisplay.DisplayName = DisPlayName.Text;
                    existingDisplay.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    existingDisplay.CreatedBy = CBTxt.Text;
                    existingDisplay.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    existingDisplay.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();

                    MessageBox.Show("Sửa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Display!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
