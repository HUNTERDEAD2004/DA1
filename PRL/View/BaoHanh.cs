using AppData.Models;
<<<<<<< HEAD
=======
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
>>>>>>> An-DBNew
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
=======
>>>>>>> An-DBNew

namespace PRL.View
{
    public partial class BaoHanh : Form
    {
<<<<<<< HEAD
=======
        SqlConnection conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=IphoneDB4;Trusted_Connection=True;TrustServerCertificate=True");
        SqlDataAdapter sda;
        DataSet ds;
>>>>>>> An-DBNew
        IphoneDbContext _dbContext;
        public BaoHanh()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            HienThi();
>>>>>>> An-DBNew
            _dbContext = new IphoneDbContext();
        }

        private void BaoHanh_Load(object sender, EventArgs e)
        {
            LoadData();
<<<<<<< HEAD
            LoadDataSP();
=======
        }

        void HienThi()
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT \r\n    pd.IMEI, \r\n    pd.ProductID, \r\n    pd.Name AS ProductName, \r\n    d.DisplayName, \r\n    c.CPUName AS CPU, \r\n    g.GPUName AS GPU, \r\n    r.RAMSize AS RAM, \r\n    pd.Price, \r\n    p.ProductName, pd.Status ,\r\n    p.Description, \r\n    co.ColorName AS Color, \r\n    p.Quantity, \r\n    s.SaleDescription AS SaleCode, \r\n    s.SaleDescription AS SaleName, \r\n    s.DiscountValue AS PercentDiscount, \r\n    s.StartDate AS SaleStart, \r\n    s.EndDate AS SaleEnd\r\nFROM \r\n    ProductDetails pd\r\nINNER JOIN \r\n    Products p ON pd.ProductID = p.ProductID\r\nINNER JOIN \r\n    Colours co ON pd.ColorID = co.ColorID\r\nINNER JOIN \r\n    Displays d ON pd.DisplayID = d.DisplayID\r\nINNER JOIN \r\n    CPUs c ON pd.CPUID = c.CPUID\r\nINNER JOIN \r\n    GPUs g ON pd.GPUID = g.GPUID\r\nINNER JOIN \r\n    RAMs r ON pd.RAMID = r.RAMID\r\nINNER JOIN \r\n    Sales s ON pd.SaleID = s.SaleID\r\nWHERE \r\n    pd.Status = 0;", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Close();
            dgvsanpham.DataSource = dt2;
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvsanpham.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvsanpham.AutoResizeColumns();
            conn.Close();
>>>>>>> An-DBNew
        }
        public void LoadData()
        {
            // Xóa các cột hiện có (nếu có)
            dgvbaohanh.Columns.Clear();

            // Thêm các cột vào DataGridView
<<<<<<< HEAD
            dgvbaohanh.Columns.Add("[WarrantyID]", "id bảo hành");
            dgvbaohanh.Columns.Add("[IMEI]", "imei");
            dgvbaohanh.Columns.Add("[WarrantyStartDate]", "bắt đầu");
            dgvbaohanh.Columns.Add("[WarrantyEndDate]", "Kết thúc");
            dgvbaohanh.Columns.Add("[CreatedBy ]", "Người thêm");
            dgvbaohanh.Columns.Add("[UpdatedBy ]", "Người sửa");
=======
            dgvbaohanh.Columns.Add("[WarrantyID]", "Customer ID");
            dgvbaohanh.Columns.Add("[IMEI]", "Imei");
            dgvbaohanh.Columns.Add("[WarrantyStartDate]", "bắt đầu");
            dgvbaohanh.Columns.Add("[WarrantyEndDate]", "Kết thúc");
>>>>>>> An-DBNew

            // Lấy dữ liệu từ cơ sở dữ liệu
            var baohanh = _dbContext.Warranties.ToList();

            // Xóa dữ liệu hiện có trong DataGridView
            dgvbaohanh.Rows.Clear();

            // Thêm dữ liệu vào DataGridView
            foreach (var bh in baohanh)
            {
<<<<<<< HEAD
                dgvbaohanh.Rows.Add(bh.WarrantyID, bh.IMEI, bh.WarrantyStartDate, bh.WarrantyEndDate, bh.CreatedBy, bh.UpdatedBy);
            }
        }

=======
                dgvbaohanh.Rows.Add(bh.WarrantyID, bh.ProductDetailID, bh.WarrantyStartDate, bh.WarrantyEndDate);
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
                dgvbaohanh.Rows.Add(bh.WarrantyID, bh.ProductDetailID, bh.WarrantyStartDate, bh.WarrantyEndDate);
            }
        }
>>>>>>> An-DBNew
        private void dgvbaohanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvbaohanh.Rows[e.RowIndex];

<<<<<<< HEAD
                string id = row.Cells[0].Value.ToString();
                string imei = row.Cells[1].Value.ToString();
                DateTime createAt = DateTime.Parse(row.Cells[2].Value.ToString());
                DateTime updateAt = DateTime.Parse(row.Cells[3].Value.ToString());
                string them = row.Cells[4].Value.ToString();
                string sua = row.Cells[5].Value.ToString();
                txtID.Text = id;
                ime.Text = imei;
                txtnguoithem.Text = them;
                txtnguoisua.Text = sua;
=======
                string imei = row.Cells[1].Value.ToString();
                DateTime createAt = DateTime.Parse(row.Cells[2].Value.ToString());
                DateTime updateAt = DateTime.Parse(row.Cells[3].Value.ToString());

                ime.Text = imei;
>>>>>>> An-DBNew
            }
        }
        private void add_Click_1(object sender, EventArgs e)
        {
            string imei = ime.Text;
<<<<<<< HEAD
=======
            Guid productId;

>>>>>>> An-DBNew
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
<<<<<<< HEAD
            string them = txtnguoithem.Text;
            string sua = txtnguoisua.Text;
            Warranty bh = new Warranty()
            {
                WarrantyID = Guid.NewGuid(),
                IMEI = imei,
                WarrantyStartDate = ngaytao,
                WarrantyEndDate = ngaysua,
                CreatedBy = them,
                UpdatedBy = sua
            };
            _dbContext.Warranties.Add(bh);
            _dbContext.SaveChanges();
=======

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
                ProductDetailID = Guid.Parse(imei),
                CreatedAt = ngaytao,
                UpdatedAt = ngaysua,
                CreatedBy = "Admin",
                UpdatedBy = "Admin",
            };
            _dbContext.Warranties.Add(bh);
            _dbContext.SaveChanges();
            HienThi();
>>>>>>> An-DBNew
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
<<<<<<< HEAD
                //Guid sp = Guid.Parse(idsp.Text);
                Warranty bh = _dbContext.Warranties.FirstOrDefault(a => a.WarrantyID == id);
                bh.IMEI = ime.Text;
                bh.WarrantyStartDate = DateTime.Now;
                bh.WarrantyEndDate = DateTime.Now;
                bh.CreatedBy = txtnguoithem.Text;
                bh.UpdatedBy = txtnguoisua.Text;
                //ProductDetail pr = _dbContext.ProductDetails.FirstOrDefault(a => a.ProductID == sp);
                //pr.Name = tensp.Text;
                //pr.Status = radioButton1.Checked ? 0 : 1;
=======
                Warranty bh = _dbContext.Warranties.FirstOrDefault(a => a.WarrantyID == id);
                bh.ProductDetailID = Guid.Parse(ime.Text);
                bh.WarrantyStartDate = DateTime.Now;
                bh.WarrantyEndDate = DateTime.Now;

>>>>>>> An-DBNew
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
<<<<<<< HEAD
        public void LoadDataSP()
        {
            var Sa = _dbContext.ProductDetails
                    .Where(o => o.Status == 0)
                    .ToList();
            // Xóa các cột hiện có (nếu có)
            dgvsanpham.Columns.Clear();

            // Thêm các cột vào DataGridView
            dgvsanpham.Columns.Add("[ProductID]", "ID");
            dgvsanpham.Columns.Add("[IMEI]", "Imei");
            dgvsanpham.Columns.Add("[Name]", "name");
            dgvsanpham.Columns.Add("[Status]", "trạng thái");
            // Lấy dữ liệu từ cơ sở dữ liệu
            var sp = _dbContext.ProductDetails.ToList();

            // Xóa dữ liệu hiện có trong DataGridView
            dgvsanpham.Rows.Clear();

            // Thêm dữ liệu vào DataGridView
            foreach (var bh in sp)
            {
                dgvsanpham.Rows.Add(bh.ProductID, bh.IMEI, bh.Name, bh.Status == 0 ? "còn bảo hành" : "hết bảo hành");
            }
        }
=======

>>>>>>> An-DBNew
        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsanpham.Rows[e.RowIndex];

                string id = row.Cells[0].Value.ToString();
<<<<<<< HEAD
                string imei = row.Cells[1].Value.ToString();
                string name = row.Cells[2].Value.ToString();
                string trangt = row.Cells[3].Value.ToString();
                if (trangt == "còn bảo hành")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (trangt == "hết bảo hành")
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }

                idsp.Text = id;
                ime.Text = imei;
                tensp.Text = name;
            }
        }
=======

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
>>>>>>> An-DBNew
    }
}
