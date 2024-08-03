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
    public partial class NamSanXuat : Form
    {
        IphoneDbContext _db;

        public NamSanXuat()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void NamSanXuat_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvYearShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvYearShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var DOBPData = _db.YearsOfManufacture.ToList().Select(c => new
                {
                    c.YearID,
                    c.Year,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy,
                }).ToList();

                if (DOBPData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvYearShow.DataSource = DOBPData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvYearShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //// Gán sự kiện CellClick cho DataGridView
                    DgvYearShow.CellClick += DgvYearShow_CellContentClick;
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

        private void DgvYearShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvYearShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                YearIdTxt.Text = row.Cells["YearID"].Value.ToString();
                YearTxt.Text = row.Cells["Year"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateDOBP = MessageBox.Show("Bạn có muốn tạo thêm Year không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateDOBP == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(YearTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newDOBP = new YearOfManufacture
                {
                    YearID = Guid.NewGuid(), // Tạo ID mới
                    Year = int.Parse(YearTxt.Text),
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.YearsOfManufacture.Add(newDOBP);
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
            var UpdateDOBP = MessageBox.Show("Bạn có muốn sửa Year không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateDOBP == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(YearTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(YearIdTxt.Text) || !Guid.TryParse(YearIdTxt.Text, out Guid YearId))
                {
                    MessageBox.Show("Vui lòng nhập ID Year hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingYear = _db.YearsOfManufacture.FirstOrDefault(r => r.YearID == YearId);

                if (ExitingYear != null)
                {
                    ExitingYear.Year = int.Parse(YearTxt.Text);
                    ExitingYear.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingYear.CreatedBy = CBTxt.Text;
                    ExitingYear.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingYear.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();
                    MessageBox.Show("Sửa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Year!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteDOBP = MessageBox.Show("Bạn có muốn Xóa Year !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteDOBP == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(YearIdTxt.Text) || !Guid.TryParse(YearIdTxt.Text, out Guid YearId))
                {
                    MessageBox.Show("Vui lòng nhập ID Year hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingYear = _db.YearsOfManufacture.FirstOrDefault(r => r.YearID == YearId);

                if (ExitingYear != null)
                {
                    _db.YearsOfManufacture.Remove(ExitingYear);
                    _db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Year!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.YearsOfManufacture.ToList().Where(c =>
                c.Year.ToString().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.YearID,
                c.Year,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy,
            }).ToList();

            DgvYearShow.DataSource = filteredData;
        }
    }
}
