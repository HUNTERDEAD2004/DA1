﻿using AppData.Models;
using DAL.Models;
using Microsoft.Win32;
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
    public partial class ORIGIN : Form
    {
        IphoneDbContext _db;

        public ORIGIN()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void ORIGIN_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvOriginShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvOriginShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var OriginData = _db.Origins.ToList().Select(c => new
                {
                    c.OriginID,
                    c.OriginName,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy
                }).ToList();

                if (OriginData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvOriginShow.DataSource = OriginData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvOriginShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Gán sự kiện CellClick cho DataGridView
                    DgvOriginShow.CellClick += DgvOriginShow_CellContentClick;
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

        private void DgvOriginShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvOriginShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                OriIdTxt.Text = row.Cells["OriginID"].Value.ToString();
                OriNameTxt.Text = row.Cells["OriginName"].Value.ToString();
            }
        }
        public static string? GetAccountIdFromRegistry()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
                string tk = null;
                if (key != null)
                {
                    tk = key.GetValue("Username").ToString();
                    key.Close();
                    return tk;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khóa Registry", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy xuất Registry hoặc cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        string currentName = GetAccountIdFromRegistry();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateVersion = MessageBox.Show("Bạn có muốn tạo thêm Origin không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateVersion == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(OriNameTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }
                var existing = _db.Origins.FirstOrDefault(c => c.OriginName == OriNameTxt.Text);
                if (existing != null)
                {
                    MessageBox.Show("Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var newOrigin = new Origin
                {
                    OriginID = Guid.NewGuid(), // Tạo ID mới
                    OriginName = OriNameTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = currentName,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = currentName
                };

                // Thêm vào cơ sở dữ liệu
                _db.Origins.Add(newOrigin);
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
            var UpdateVersion = MessageBox.Show("Bạn có muốn cập nhật Origin không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateVersion == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(OriNameTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(OriIdTxt.Text) || !Guid.TryParse(OriIdTxt.Text, out Guid ORiID))
                {
                    MessageBox.Show("Vui lòng nhập ID Origin hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingOrigin = _db.Origins.FirstOrDefault(c => c.OriginID == ORiID);

                if (existingOrigin != null)
                {
                    existingOrigin.OriginName = OriNameTxt.Text;
                    existingOrigin.UpdatedBy = currentName;
                    existingOrigin.UpdatedAt = DateTime.Now;

                    _db.SaveChanges();

                    MessageBox.Show("Cập nhật Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Origin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hủy bỏ cập nhật sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteWeight = MessageBox.Show("Bạn có muốn xóa Origin không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteWeight == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(OriIdTxt.Text) || !Guid.TryParse(OriIdTxt.Text, out Guid ORiID))
                {
                    MessageBox.Show("Vui lòng nhập ID Origin hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var existingOrigin = _db.Origins.FirstOrDefault(c => c.OriginID == ORiID);

                if (existingOrigin != null)
                {
                    _db.Origins.Remove(existingOrigin);
                    _db.SaveChanges();

                    MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Origin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.Origins.ToList().Where(c =>
                c.OriginName.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToString().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToString().Contains(searchTerm)
            ).Select(c => new
            {
                c.OriginID,
                c.OriginName,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy
            }).ToList();

            DgvOriginShow.DataSource = filteredData;
        }
    }
}
