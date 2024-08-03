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
    public partial class BaoHanh : Form
    {
        IphoneDbContext _dbContext;
        public BaoHanh()
        {
            InitializeComponent();
            _dbContext = new IphoneDbContext();
        }

        private void BaoHanh_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            // Xóa các cột hiện có (nếu có)
            dgvbaohanh.Columns.Clear();

            // Thêm các cột vào DataGridView
            dgvbaohanh.Columns.Add("[WarrantyID]", "Customer ID");
            dgvbaohanh.Columns.Add("[IMEI]", "Name");
            dgvbaohanh.Columns.Add("[WarrantyStartDate]", "bắt đầu");
            dgvbaohanh.Columns.Add("[WarrantyEndDate]", "Kết thúc");

            // Lấy dữ liệu từ cơ sở dữ liệu
            var baohanh = _dbContext.Warranties.ToList();

            // Xóa dữ liệu hiện có trong DataGridView
            dgvbaohanh.Rows.Clear();

            // Thêm dữ liệu vào DataGridView
            foreach (var bh in baohanh)
            {
                dgvbaohanh.Rows.Add(bh.WarrantyID, bh.IMEI, bh.WarrantyStartDate, bh.WarrantyEndDate);
            }
        }
        public void LoadDataSP()
        {
            var Sa = _dbContext.ProductDetails
                    .Where(o => o.Status == 0)
                    .ToList();
            // Xóa các cột hiện có (nếu có)
            dgvsanpham.Columns.Clear();

            // Thêm các cột vào DataGridView
            dgvsanpham.Columns.Add("[WarrantyID]", "Customer ID");
            dgvsanpham.Columns.Add("[IMEI]", "Name");
            dgvsanpham.Columns.Add("[WarrantyStartDate]", "bắt đầu");
            dgvsanpham.Columns.Add("[WarrantyEndDate]", "Kết thúc");

            // Lấy dữ liệu từ cơ sở dữ liệu
            var baohanh = _dbContext.Warranties.ToList();

            // Xóa dữ liệu hiện có trong DataGridView
            dgvbaohanh.Rows.Clear();

            // Thêm dữ liệu vào DataGridView
            foreach (var bh in baohanh)
            {
                dgvbaohanh.Rows.Add(bh.WarrantyID, bh.IMEI, bh.WarrantyStartDate, bh.WarrantyEndDate);
            }
        }
        private void dgvbaohanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvbaohanh.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
                string imei = row.Cells[1].Value.ToString();
                DateTime createAt = DateTime.Parse(row.Cells[2].Value.ToString());
                DateTime updateAt = DateTime.Parse(row.Cells[3].Value.ToString());

                txtID.Text = id;
                ime.Text = imei;
            }
        }
        private void add_Click_1(object sender, EventArgs e)
        {
            string imei = ime.Text;
            DateTime ngaytao;
            if (!DateTime.TryParse(ngaybd.Text, out ngaytao))
            {
                return;
            }
            DateTime ngaysua;
            if (!DateTime.TryParse(ngaykt.Text, out ngaysua))
            {
                return;
            }
            Warranty bh = new Warranty()
            {
                WarrantyID = Guid.NewGuid(),
                IMEI = imei,
                WarrantyStartDate = ngaytao,
                WarrantyEndDate = ngaysua,
            };
            _dbContext.Warranties.Add(bh);
            _dbContext.SaveChanges();
            LoadData();
            MessageBox.Show("+1 sức mạnh");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ime.Text))
                {
                    MessageBox.Show("Lấp đầy khoảng trống đi nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Guid id = Guid.Parse(txtID.Text);
                Warranty bh = _dbContext.Warranties.FirstOrDefault(a => a.WarrantyID == id);
                bh.IMEI = ime.Text;
                bh.WarrantyStartDate = DateTime.Now;
                bh.WarrantyEndDate = DateTime.Now;

                _dbContext.SaveChanges();
                LoadData();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sửa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = Guid.Parse(txtID.Text);
                Warranty bh = _dbContext.Warranties.FirstOrDefault(a => a.WarrantyID == id);

                if (bh != null)
                {
                    _dbContext.Warranties.Remove(bh);
                    _dbContext.SaveChanges();
                    LoadData();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thấy ID!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
