﻿using AppData.Models;
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
    public partial class MauSac : Form
    {
        IphoneDbContext _db;
        public MauSac()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void MauSac_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvColorShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateColor = MessageBox.Show("Bạn có muốn tạo thêm Color không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateColor == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(ColorNameTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newColor = new AppData.Models.Color
                {
                    ColorID = Guid.NewGuid(), // Tạo ID mới
                    ColorName = ColorNameTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.Colours.Add(newColor);
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
            var updateColor = MessageBox.Show("Bạn có muốn Sửa Color không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (updateColor == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(ColorNameTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(ColorId.Text) || !Guid.TryParse(ColorId.Text, out Guid colorID))
                {
                    MessageBox.Show("Vui lòng nhập ID màu hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingColor = _db.Colours.FirstOrDefault(c => c.ColorID == colorID);

                if (existingColor != null)
                {
                    existingColor.ColorName = ColorNameTxt.Text;
                    existingColor.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    existingColor.CreatedBy = CBTxt.Text;
                    existingColor.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    existingColor.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();

                    MessageBox.Show("Sửa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Color!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var deleteColor = MessageBox.Show("Bạn có muốn Xóa Color không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteColor == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(ColorId.Text) || !Guid.TryParse(ColorId.Text, out Guid colorID))
                {
                    MessageBox.Show("Vui lòng nhập ID màu hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingColor = _db.Colours.FirstOrDefault(c => c.ColorID == colorID);

                if (existingColor != null)
                {
                    _db.Colours.Remove(existingColor);
                    _db.SaveChanges();

                    MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Color!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.Colours.ToList().Where(c =>
                c.ColorName.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.ColorID,
                c.ColorName,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy,
            }).ToList();

            DgvColorShow.DataSource = filteredData;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvColorShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var ColorData = _db.Colours.ToList().Select(c => new
                {
                    c.ColorID,
                    c.ColorName,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy,
                }).ToList();

                if (ColorData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvColorShow.DataSource = ColorData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvColorShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvColorShow.CellClick += DgvColorShow_CellContentClick;
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

        private void DgvColorShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvColorShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                ColorId.Text = row.Cells["ColorID"].Value.ToString();
                ColorNameTxt.Text = row.Cells["ColorName"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }
    }
}
