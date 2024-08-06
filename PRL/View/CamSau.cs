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
    public partial class CamSau : Form
    {
        IphoneDbContext _db;

        public CamSau()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void CamSau_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvCamSelfhow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvCamSelfhow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var CamSelfData = _db.CameraSelfies.ToList().Select(c => new
                {
                    c.CameraSelfieID,
                    c.CameraSelfieDetails,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy,
                }).ToList();

                if (CamSelfData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvCamSelfhow.DataSource = CamSelfData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvCamSelfhow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //// Gán sự kiện CellClick cho DataGridView
                    DgvCamSelfhow.CellClick += DgvCamSelfhow_CellContentClick;
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

        private void DgvCamSelfhow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvCamSelfhow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                CameraSelfieIdTxt.Text = row.Cells["CameraSelfieID"].Value.ToString();
                CameraSelfieDetailsTxt.Text = row.Cells["CameraSelfieDetails"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateCamSelf = MessageBox.Show("Bạn có muốn tạo thêm CamSelf không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateCamSelf == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(CameraSelfieDetailsTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newCamSelf = new CameraSelfie
                {
                    CameraSelfieID = Guid.NewGuid(), // Tạo ID mới
                    CameraSelfieDetails = CameraSelfieDetailsTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.CameraSelfies.Add(newCamSelf);
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
            var UpdateCamSelf = MessageBox.Show("Bạn có muốn sửa CamSelf không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateCamSelf == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(CameraSelfieDetailsTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(CameraSelfieIdTxt.Text) || !Guid.TryParse(CameraSelfieIdTxt.Text, out Guid CamSelfId))
                {
                    MessageBox.Show("Vui lòng nhập ID CamSelf hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingCamSelf = _db.CameraSelfies.FirstOrDefault(r => r.CameraSelfieID == CamSelfId);

                if (ExitingCamSelf != null)
                {
                    ExitingCamSelf.CameraSelfieDetails = CameraSelfieDetailsTxt.Text;
                    ExitingCamSelf.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingCamSelf.CreatedBy = CBTxt.Text;
                    ExitingCamSelf.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingCamSelf.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();
                    MessageBox.Show("Sửa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy CamSelf!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteCamSelf = MessageBox.Show("Bạn có muốn Xóa CamSelf !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteCamSelf == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(CameraSelfieIdTxt.Text) || !Guid.TryParse(CameraSelfieIdTxt.Text, out Guid CamSelfId))
                {
                    MessageBox.Show("Vui lòng nhập ID CamSelf hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingCamSelf = _db.CameraSelfies.FirstOrDefault(r => r.CameraSelfieID == CamSelfId);

                if (ExitingCamSelf != null)
                {
                    _db.CameraSelfies.Remove(ExitingCamSelf);
                    _db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy CamSelf!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.CameraSelfies.ToList().Where(c =>
                c.CameraSelfieDetails.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.CameraSelfieID,
                c.CameraSelfieDetails,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy,
            }).ToList();

            DgvCamSelfhow.DataSource = filteredData;
        }
    }
}
