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
    public partial class WEIGHT : Form
    {
        IphoneDbContext _db;

        public WEIGHT()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void WEIGHT_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvWeightShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvWeightShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var WeightData = _db.Weights.ToList().Select(c => new
                {
                    c.WeightID,
                    c.WeightValue,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy
                }).ToList();

                if (WeightData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvWeightShow.DataSource = WeightData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvWeightShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvWeightShow.CellClick += DgvWeightShow_CellContentClick;
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

        private void DgvWeightShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvWeightShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                WeightIdTxt.Text = row.Cells["WeightID"].Value.ToString();
                WeightValueTxt.Text = row.Cells["WeightValue"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateWeight = MessageBox.Show("Bạn có muốn tạo thêm Weight không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateWeight == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(WeightValueTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newWeight = new Weight
                {
                    WeightID = Guid.NewGuid(), // Tạo ID mới
                    WeightValue = float.Parse(WeightValueTxt.Text),
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.Weights.Add(newWeight);
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
            var UpdateWeight = MessageBox.Show("Bạn có muốn cập nhật Weight không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateWeight == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(WeightValueTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(WeightIdTxt.Text) || !Guid.TryParse(WeightIdTxt.Text, out Guid WeightID))
                {
                    MessageBox.Show("Vui lòng nhập ID Weight hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingWeight = _db.Weights.FirstOrDefault(c => c.WeightID == WeightID);

                if (existingWeight != null)
                {
                    existingWeight.WeightValue = float.Parse(WeightValueTxt.Text);
                    existingWeight.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    existingWeight.CreatedBy = CBTxt.Text;
                    existingWeight.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    existingWeight.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();

                    MessageBox.Show("Cập nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Weight!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy bỏ cập nhật sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteWeight = MessageBox.Show("Bạn có muốn xóa Weight không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteWeight == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(WeightIdTxt.Text) || !Guid.TryParse(WeightIdTxt.Text, out Guid WeightID))
                {
                    MessageBox.Show("Vui lòng nhập ID CPU hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingWeight = _db.Weights.FirstOrDefault(c => c.WeightID == WeightID);

                if (existingWeight != null)
                {
                    _db.Weights.Remove(existingWeight);
                    _db.SaveChanges();

                    MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Weight!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.Weights.ToList().Where(c =>
                c.WeightValue.ToString().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.WeightID,
                c.WeightValue,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy
            }).ToList();

            DgvWeightShow.DataSource = filteredData;
        }
    }
}
