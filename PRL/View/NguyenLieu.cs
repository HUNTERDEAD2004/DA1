﻿using AppData.Models;
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
    public partial class NguyenLieu : Form
    {
        IphoneDbContext _db;

        public NguyenLieu()
        {
            _db = new IphoneDbContext();
            InitializeComponent();
        }

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            LoadData();

            // Điều chỉnh kích thước các cột tự động theo nội dung
            DgvMaterialhow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadData()
        {
            try
            {
                // Đảm bảo rằng AutoGenerateColumns được đặt thành true
                DgvMaterialhow.AutoGenerateColumns = true;

                // Lấy dữ liệu từ cơ sở dữ liệu và chọn các cột cần thiết
                var MaterialData = _db.Materials.ToList().Select(c => new
                {
                    c.MaterialID,
                    c.MaterialName,
                    c.CreatedAt,
                    c.CreatedBy,
                    c.UpdatedAt,
                    c.UpdatedBy,
                }).ToList();

                if (MaterialData.Any())
                {
                    // Gán dữ liệu cho DataGridView
                    DgvMaterialhow.DataSource = MaterialData;

                    // Điều chỉnh kích thước các cột tự động theo nội dung
                    DgvMaterialhow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //// Gán sự kiện CellClick cho DataGridView
                    DgvMaterialhow.CellClick += DgvMaterialhow_CellContentClick;
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

        private void DgvMaterialhow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DgvMaterialhow.Rows[e.RowIndex];

                // Gán dữ liệu từ các ô vào các TextBox tương ứng
                MaterialIdTxt.Text = row.Cells["MaterialID"].Value.ToString();
                MarterialNameTxt.Text = row.Cells["MaterialName"].Value.ToString();
                CATimePicker.Text = row.Cells["CreatedAt"].Value.ToString();
                CBTxt.Text = row.Cells["CreatedBy"].Value.ToString();
                UATimePicker.Text = row.Cells["UpdatedAt"].Value.ToString();
                UBTxt.Text = row.Cells["UpdatedBy"].Value.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var CreateCamSelf = MessageBox.Show("Bạn có muốn tạo thêm Material không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreateCamSelf == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(MarterialNameTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                var newMaterial = new Material
                {
                    MaterialID = Guid.NewGuid(), // Tạo ID mới
                    MaterialName = MarterialNameTxt.Text,
                    CreatedAt = DateTime.Now,
                    CreatedBy = CBTxt.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = UBTxt.Text
                };

                // Thêm vào cơ sở dữ liệu
                _db.Materials.Add(newMaterial);
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
            var UpdateCamSelf = MessageBox.Show("Bạn có muốn sửa Material không !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateCamSelf == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(MarterialNameTxt.Text) || string.IsNullOrWhiteSpace(CBTxt.Text) || string.IsNullOrWhiteSpace(UBTxt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu có trường rỗng
                }

                if (string.IsNullOrWhiteSpace(MaterialIdTxt.Text) || !Guid.TryParse(MaterialIdTxt.Text, out Guid ExitingMaterialID))
                {
                    MessageBox.Show("Vui lòng nhập ID Material hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingMaterial = _db.Materials.FirstOrDefault(r => r.MaterialID == ExitingMaterialID);

                if (ExitingMaterial != null)
                {
                    ExitingMaterial.MaterialName = MarterialNameTxt.Text;
                    ExitingMaterial.CreatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingMaterial.CreatedBy = CBTxt.Text;
                    ExitingMaterial.UpdatedAt = DateTime.Parse(CATimePicker.Text);
                    ExitingMaterial.UpdatedBy = UBTxt.Text;

                    _db.SaveChanges();
                    MessageBox.Show("Sửa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Material!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại *_*?", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var DeleteCamSelf = MessageBox.Show("Bạn có muốn Xóa Material !?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteCamSelf == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(MaterialIdTxt.Text) || !Guid.TryParse(MaterialIdTxt.Text, out Guid ExitingMaterialID))
                {
                    MessageBox.Show("Vui lòng nhập ID Material hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc phương thức nếu ID không hợp lệ
                }

                var ExitingMaterial = _db.Materials.FirstOrDefault(r => r.MaterialID == ExitingMaterialID);

                if (ExitingMaterial != null)
                {
                    _db.Materials.Remove(ExitingMaterial);
                    _db.SaveChanges();
                    MessageBox.Show("Xóa Thành Công 0>0!", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Material!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var filteredData = _db.Materials.ToList().Where(c =>
                c.MaterialName.ToLower().Contains(searchTerm) ||
                c.CreatedAt.ToString().Contains(searchTerm) ||
                c.CreatedBy.ToLower().Contains(searchTerm) ||
                c.UpdatedAt.ToString().Contains(searchTerm) ||
                c.UpdatedBy.ToLower().Contains(searchTerm)
            ).Select(c => new
            {
                c.MaterialID,
                c.MaterialName,
                c.CreatedAt,
                c.CreatedBy,
                c.UpdatedAt,
                c.UpdatedBy,
            }).ToList();

            DgvMaterialhow.DataSource = filteredData;
        }
    }
}
