using AppData.Models;
using Microsoft.Data.SqlClient;
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
    public partial class BaoHanh : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=IphoneDB8;Trusted_Connection=True;TrustServerCertificate=True");
        SqlDataAdapter sda;
        DataSet ds;
        IphoneDbContext _dbContext;
        public BaoHanh()
        {
            InitializeComponent();
            HienThi();
            _dbContext = new IphoneDbContext();
        }

        private void BaoHanh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void HienThi()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //SqlCommand cmd2 = new SqlCommand("SELECT ImeiID,Status,CreatedAt,CreatedBy from iMEIs where Status = 2;", conn);
            //SqlDataReader dr2 = cmd2.ExecuteReader();
            //DataTable dt2 = new DataTable();
            //dt2.Load(dr2);
            //dr2.Close();
            //dgvsanpham.DataSource = dt2;
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvsanpham.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvsanpham.AutoResizeColumns();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public void LoadData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            // Lấy dữ liệu từ bảng IMEIs với Status = 2
            SqlCommand cmd2 = new SqlCommand("SELECT ImeiID, Status, CreatedAt, CreatedBy FROM IMEIs WHERE Status = 2;", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Close();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            // Xóa các cột và dòng hiện có trong DataGridView
            dgvsanpham.Columns.Clear();
            dgvsanpham.Rows.Clear();

            // bảng IMEIs
            dgvsanpham.Columns.Add("ImeiID", "ImeiID");
            dgvsanpham.Columns.Add("Status", "Status");
            dgvsanpham.Columns.Add("CreatedAt", "CreatedAt");
            dgvsanpham.Columns.Add("CreatedBy", "CreatedBy");

            // bảng Warranties
            dgvsanpham.Columns.Add("WarrantyID", "WarrantyID");
            dgvsanpham.Columns.Add("WarrantyStartDate", "WarrantyStartDate");
            dgvsanpham.Columns.Add("WarrantyEndDate", "WarrantyEndDate");

            foreach (DataRow row in dt2.Rows)
            {
                dgvsanpham.Rows.Add(row["ImeiID"], row["Status"], row["CreatedAt"], row["CreatedBy"], null, null, null);
            }

            var baohanh = _dbContext.Warranties.ToList();

            // Kết hợp dữ liệu bảo hành vào DataGridView
            foreach (var bh in baohanh)
            {
                foreach (DataGridViewRow dgvRow in dgvsanpham.Rows)
                {
                    if (dgvRow.Cells["ImeiID"].Value != null && dgvRow.Cells["ImeiID"].Value.ToString() == bh.ImeiID)
                    {                       
                        dgvRow.Cells["WarrantyID"].Value = bh.WarrantyID;
                        dgvRow.Cells["WarrantyStartDate"].Value = bh.WarrantyStartDate;
                        dgvRow.Cells["WarrantyEndDate"].Value = bh.WarrantyEndDate;
                        break; 
                    }
                }
            }

            // Định dạng DataGridView
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvsanpham.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvsanpham.AutoResizeColumns();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            string imei = ime.Text;
            Guid productId;

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

            var productDetail = _dbContext.ProductDetails.FirstOrDefault(pd => pd.ProductDetailID == Guid.Parse(imei));
            if (productDetail == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productDetail.Status = 1;

            Warranty bh = new Warranty()
            {
                WarrantyID = Guid.NewGuid(),
                ImeiID = imei,
                CreatedAt = ngaytao,
                UpdatedAt = ngaysua,
                CreatedBy = "Admin",
                UpdatedBy = "Admin",
            };
            _dbContext.Warranties.Add(bh);
            _dbContext.SaveChanges();
            HienThi();
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
                bh.ImeiID = ime.Text;
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

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsanpham.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();

                ime.Text = id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            ime.Text = "";
            ngaybd.Value = DateTime.Now;
            ngaykt.Value = DateTime.Now;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
