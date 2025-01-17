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
    public partial class ROM : Form
    {
        IphoneDbContext _db;
        public ROM()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void ROM_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvROMShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvROMShow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var ROMData = _db.ROMs.ToList().Select(c => new
                {
                    c.ROMID,
                    c.ROMSize,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy,
                }).ToList();

                if (ROMData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvROMShow.DataSource = ROMData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvROMShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //// Gán sự kiện CellClick cho DataGridView
                    DgvROMShow.CellClick += DgvROMShow_CellContentClick;
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

        private void DgvROMShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvROMShow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                ROMIDTxt.Text = row.Cells["ROMID"].Value.ToString();
                ROMSizeTxt.Text = row.Cells["ROMSize"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateROM = MessageBox.Show("Bạn có muốn tạo thêm ROM không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateROM == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(ROMSizeTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newROM = new Rom
                {
                    ROMID = Guid.NewGuid(), // Tạo ID mới
                    ROMSize = ROMSizeTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.ROMs.Add(newROM);
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
            var UpdateROM = MessageBox.Show("Bạn có muốn sửa ROM không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateROM == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(ROMSizeTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(ROMIDTxt.Text) || !Guid.TryParse(ROMIDTxt.Text, out Guid RomId))
                {
                    MessageBox.Show("Vui lòng nhập ID ROM hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingRom = _db.ROMs.FirstOrDefault(r => r.ROMID == RomId);

                if (ExitingRom != null)
                {
                    ExitingRom.ROMSize = ROMSizeTxt.Text;
                    ExitingRom.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingRom.CreatedBy = CBTxt.Text;
                    ExitingRom.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingRom.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();
                    MessageBox.Show("Sửa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ROM!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteROM = MessageBox.Show("Bạn có muốn Xóa ROM không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteROM == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(ROMIDTxt.Text) || !Guid.TryParse(ROMIDTxt.Text, out Guid RomId))
                {
                    MessageBox.Show("Vui lòng nhập ID ROM hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingRom = _db.ROMs.FirstOrDefault(r => r.ROMID == RomId);

                if (ExitingRom != null)
                {
                    _db.ROMs.Remove(ExitingRom);
                    _db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ROM!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.ROMs.ToList().Where(c =>
                c.ROMSize.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.ROMID,
                c.ROMSize,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy,
            }).ToList();

            DgvROMShow.DataSource = filteredData;
        }
    }
}
