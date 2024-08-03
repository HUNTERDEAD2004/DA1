using AppData.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PRL.View
{
    public partial class Orderform : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=IphoneDB4;Trusted_Connection=True;TrustServerCertificate=True");
        SqlDataAdapter sda;
        DataSet ds;
        // Đặt màu chữ cho toàn bộ form
        IphoneDbContext Context;
        private HDCT hdctForm;
        public Orderform(HDCT hdct)
        {
            this.hdctForm = hdct;
            hdctForm = new HDCT();
            hdctForm.Show();
            Context = new IphoneDbContext();
            InitializeComponent();
        }

        void HienThi()
        {
            try
            {

                //Load Users
                //SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetails", conn);
                //SqlDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //dr.Close();
                //dgvHDCT.DataSource = dt;
                dgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHDCT.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                dgvHDCT.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                dgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvHDCT.AutoResizeColumns();

                // Load userRoles
                SqlCommand cmd2 = new SqlCommand("SELECT \r\n    pd.IMEI, \r\n    pd.ProductID, \r\n    pd.Name AS ProductName, \r\n    d.DisplayName, \r\n    c.CPUName AS CPU, \r\n    g.GPUName AS GPU, \r\n    r.RAMSize AS RAM, \r\n    pd.Price, \r\n    p.ProductName, \r\n    p.Description, \r\n    co.ColorName AS Color, \r\n    p.Quantity, \r\n    s.SaleDescription AS SaleCode, \r\n    s.SaleDescription AS SaleName, \r\n    s.DiscountValue AS PercentDiscount, \r\n    s.StartDate AS SaleStart, \r\n    s.EndDate AS SaleEnd\r\nFROM \r\n    ProductDetails pd\r\nINNER JOIN \r\n    Products p ON pd.ProductID = p.ProductID\r\nINNER JOIN \r\n    Colours co ON pd.ColorID = co.ColorID\r\nINNER JOIN \r\n    Displays d ON pd.DisplayID = d.DisplayID\r\nINNER JOIN \r\n    CPUs c ON pd.CPUID = c.CPUID\r\nINNER JOIN \r\n    GPUs g ON pd.GPUID = g.GPUID\r\nINNER JOIN \r\n    RAMs r ON pd.RAMID = r.RAMID\r\nINNER JOIN \r\n    Sales s ON pd.SaleID = s.SaleID\r\nWHERE \r\n    pd.Status = 1;", conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);
                dr2.Close();
                dgvSP.DataSource = dt2;
                dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSP.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                dgvSP.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvSP.AutoResizeColumns();

                SqlCommand cmd3 = new SqlCommand("SELECT * FROM Orders", conn);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                DataTable dt3 = new DataTable();
                dt3.Load(dr3);
                dr3.Close();
                dgvHD.DataSource = dt3;
                dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHD.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                dgvHD.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvHD.AutoResizeColumns();
            }
            finally
            {
                conn.Close();
            }

        }

        void LayDLHDCT()
        {
            string sql = "SELECT * FROM OrderDetails";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        void LayDLHD()
        {
            try
            {
                string sql3 = @"
                                SELECT 
                                    o.OrderID, 
                                    o.AccountID, 
                                    o.CustomerID, 
                                    o.IDVoucher, 
                                    COUNT(od.OrderDetailID) AS Quantity, 
                                    SUM(od.Quantity * od.UnitPrice) AS Price, 
                                    CASE 
                                        WHEN o.Status = '1' THEN 'Đã thanh toán' 
                                        ELSE 'Chưa thanh toán' 
                                    END AS Status, 
                                    o.CreatedAt, 
                                    o.UpdatedAt, 
                                    o.UpdatedBy, 
                                    o.CreatedBy 
                                FROM 
                                    Orders o
                                LEFT JOIN 
                                    OrderDetails od ON o.OrderID = od.OrderID
                                WHERE 
                                    o.Status = '0'
                                GROUP BY 
                                    o.OrderID, 
                                    o.AccountID, 
                                    o.CustomerID, 
                                    o.IDVoucher, 
                                    o.Status, 
                                    o.CreatedAt, 
                                    o.UpdatedAt, 
                                    o.UpdatedBy, 
                                    o.CreatedBy;
                                ";

                sda = new SqlDataAdapter(sql3, conn);
                ds = new DataSet();
                sda.Fill(ds);
                dgvHD.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        void LayDLSP()
        {
            string sql2 = "\r\nSELECT \r\n    pd.IMEI, \r\n    pd.Name AS ProductName, \r\n    pd.importPrice,\r\n    pd.Price,\r\n    d.DisplayName, \r\n    c.CPUName AS CPU, \r\n    g.GPUName AS GPU, \r\n    r.RAMSize AS RAM, \r\n    ro.ROMSize AS ROM, \r\n    co.ColorName AS Color, \r\n    o.OriginName AS Origin,\r\n    y.Year AS YearOfManufacture,\r\n    m.MaterialName AS Material,\r\n    v.VersionName AS Version,\r\n    rc.RearCameraDetails AS RearCamera,\r\n    cs.CameraSelfieDetails AS CameraSelfie,\r\n    os.OSName AS OperatingSystem,\r\n    b.Capacity AS BatteryCapacity,\r\n    w.WeightValue AS Weight,\r\n    s.SaleDescription AS SaleCode, \r\n    s.SaleDescription AS SaleName, \r\n    s.DiscountValue AS PercentDiscount, \r\n    s.StartDate AS SaleStart, \r\n    s.EndDate AS SaleEnd\r\nFROM \r\n    ProductDetails pd\r\nINNER JOIN \r\n    Products p ON pd.ProductID = p.ProductID\r\nINNER JOIN \r\n    Colours co ON pd.ColorID = co.ColorID\r\nINNER JOIN \r\n    Displays d ON pd.DisplayID = d.DisplayID\r\nINNER JOIN \r\n    CPUs c ON pd.CPUID = c.CPUID\r\nINNER JOIN \r\n    GPUs g ON pd.GPUID = g.GPUID\r\nINNER JOIN \r\n    RAMs r ON pd.RAMID = r.RAMID\r\nINNER JOIN \r\n    ROMs ro ON pd.ROMID = ro.ROMID\r\nINNER JOIN \r\n    Sales s ON pd.SaleID = s.SaleID\r\nINNER JOIN \r\n    Origins o ON pd.OriginID = o.OriginID\r\nINNER JOIN \r\n    YearsOfManufacture y ON pd.YearID = y.YearID\r\nINNER JOIN \r\n    Materials m ON pd.MaterialID = m.MaterialID\r\nINNER JOIN \r\n    Versions v ON pd.VersionID = v.VersionID\r\nINNER JOIN \r\n    RearCameras rc ON pd.RearCameraID = rc.RearCameraID\r\nINNER JOIN \r\n    CameraSelfies cs ON pd.CameraSelfieID = cs.CameraSelfieID\r\nINNER JOIN \r\n    OperatingSystems os ON pd.OSID = os.OSID\r\nINNER JOIN \r\n    BatteryCapacities b ON pd.BatteryID = b.BatteryID\r\nINNER JOIN \r\n    Weights w ON pd.WeightID = w.WeightID\r\n";

            sda = new SqlDataAdapter(sql2, conn);
            ds = new DataSet();
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSP.CurrentRow.Selected = true;
                txtimei.Text = dgvSP.Rows[e.RowIndex].Cells["IMEI"].Value.ToString();
                txtMSP.Text = dgvSP.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtSP.Text = dgvSP.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtSZ.Text = dgvSP.Rows[e.RowIndex].Cells["PercentDiscount"].Value.ToString();
                DTPVC.Text = dgvSP.Rows[e.RowIndex].Cells["SaleEnd"].Value.ToString();
                txtGia.Text = dgvSP.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtSL.Text = "1";

                // Chuyển đổi txtSZ.Text và txtGia.Text thành số
                decimal discount = Convert.ToDecimal(txtSZ.Text);
                decimal price = Convert.ToDecimal(txtGia.Text);
                int quantity = Convert.ToInt32(txtSL.Text);

                // Tính tổng tiền
                decimal totalPrice = quantity * price * (1 - (discount / 100));

                // Gán kết quả vào txtTG
                txtTG.Text = totalPrice.ToString("F2");

            }
            LayDLSP();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            LayDLHD();
            LayDLSP();
        }


        private void LoadData()
        {
            using (var context = new IphoneDbContext())
            {
                var data = from iph in context.ProductDetails
                           join p in context.Products on iph.ProductID equals p.ProductID
                           join co in context.Colours on iph.ColorID equals co.ColorID
                           join d in context.Displays on iph.DisplayID equals d.DisplayID
                           join c in context.CPUs on iph.CPUID equals c.CPUID
                           join g in context.GPUs on iph.GPUID equals g.GPUID
                           join r in context.RAMs on iph.RAMID equals r.RAMID
                           join s in context.Sales on iph.SaleID equals s.SaleID
                           where iph.Status == 1 // Điều kiện == 1
                           select new
                           {
                               iph.Imeis,
                               iph.ProductID,
                               ProductDetailName = iph.Name,
                               d.DisplayName,
                               CPU = c.CPUName,
                               GPU = g.GPUName,
                               RAM = r.RAMSize,
                               iph.Price,
                               ProductName = p.ProductName,
                               p.Description,
                               Color = co.ColorName,
                               p.Quantity,
                               SaleCode = s.SaleDescription,
                               SaleDescription = s.SaleDescription,
                               PercentDiscount = s.DiscountValue,
                               SaleStart = s.StartDate,
                               SaleEnd = s.EndDate
                           };

                dgvSP.DataSource = data.ToList();
            }
        }




        private void LoadDataHD()
        {
            using (var context = new IphoneDbContext())
            {
                var oder = context.Orders
                    .Where(o => o.Status == 0)
                    .ToList();
                dgvHD.DataSource = oder.Select(u => new
                {
                    u.OrderID,
                    u.AccountID,
                    u.CustomerID,
                    u.IDVoucher,
                    u.TotalAmount,
                    u.Price,
                    Status = u.Status == 0 ? "Chưa thanh toán" : "Đã thanh toán",
                    u.CreatedAt,
                    u.UpdatedAt,
                    u.UpdatedBy,
                    u.CreatedBy,
                }).ToList();
            }
        }

        private void LoadDataHDCT()
        {
            using (var context = new IphoneDbContext())
            {
                var oderCT = context.OrderDetails
                                    .Where(o => o.OrderID == Guid.Parse(txtHDHT.Text))
                                    .ToList();
                dgvHDCT.DataSource = oderCT.Select(u => new
                {
                    u.OrderDetailID,
                    u.OrderID,
                    u.ProductDetailID,
                    u.ProductName,
                    u.Quantity,
                    u.UnitPrice,
                    u.DiscountValue,
                    u.CreatedAt,
                    u.UpdatedAt,
                    u.UpdatedBy,
                    u.CreatedBy,
                }).ToList();
                dgvHDCT.DataSource = oderCT.ToList();

            }
        }


        private float ParseFloat(string input)
        {
            float value;
            if (!float.TryParse(input, out value))
            {
                MessageBox.Show($"Giá trị '{input}' không phải là số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new FormatException($"Giá trị '{input}' không phải là số hợp lệ.");
            }
            return value;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Guid productId, orderId;

                // Check ProductId
                if (!Guid.TryParse(txtMSP.Text, out productId))
                {
                    MessageBox.Show("Mã sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check OrderID
                if (!Guid.TryParse(txtHDHT.Text, out orderId))
                {
                    MessageBox.Show("Mã hóa đơn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var context = new IphoneDbContext())
                {
                    // Tìm sản phẩm bằng IMEI
                    var productDetail = context.ProductDetails.FirstOrDefault(pd => pd.ProductID == productId || pd.ProductDetailID == Guid.Parse(txtimei.Text));
                    if (productDetail == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    productDetail.Status = 0;

                    var hdtc = new OrderDetail
                    {
                        OrderDetailID = Guid.NewGuid(),
                        OrderID = orderId,
                        ProductDetailID = Guid.Parse(txtimei.Text),
                        ProductName = txtSP.Text,
                        Quantity = 1,
                        UnitPrice = decimal.Parse(txtTG.Text),
                        DiscountValue = decimal.Parse(txtSZ.Text),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        CreatedBy = "admin",
                        UpdatedBy = "admin"
                    };

                    context.OrderDetails.Add(hdtc);
                    context.SaveChanges();

                    LoadData();
                    LoadDataHDCT();
                    LayDLHD();

                    MessageBox.Show("Thêm thành công!, toẹt zời hehehe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int currentOrderIndex = 0;
        private List<Guid> orderIds = new List<Guid>();

        private void LoadOrders()
        {
            // Load tất cả các OderID từ cơ sở dữ liệu
            orderIds = Context.Orders.Select(o => o.OrderID).ToList();
            if (orderIds.Count > 0)
            {
                currentOrderIndex = 0;
            }
        }

        private void LoadOrderDetailInfo(Guid orderId)
        {
            using (var conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=AppleStore4;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                string query = @"
                SELECT od.OrderDetailsID, od.ProductId, od.OderID, od.Quantity, od.IpadIMEI, od.NameSPCT, od.Price, od.PercentDiscount, od.CreateAt, od.UpdateAt, od.CreateBy, od.UpdateBy,
                        o.UserID, o.CustomerID, o.Quantity AS OrderQuantity, o., o.Status, o.CreateAt AS OrderCreateAt, o.UpdateAt AS OrderUpdateAt, o.CreateBy AS OrderCreateBy, o.UpdateBy AS OrderUpdateBy
                FROM OrderDetails od
                JOIN Orders o ON od.OderID = o.OderID
                WHERE od.OderID = @OrderID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Clear previous data
                dgvHDCT.Rows.Clear();

                while (reader.Read())
                {
                    int rowIndex = dgvHDCT.Rows.Add();
                    DataGridViewRow row = dgvHDCT.Rows[rowIndex];
                    row.Cells["OrderDetailsID"].Value = reader["OrderDetailsID"];
                    row.Cells["ProductId"].Value = reader["ProductId"];
                    row.Cells["OderID"].Value = reader["OderID"];
                    row.Cells["Quantity"].Value = reader["Quantity"];
                    row.Cells["IpadIMEI"].Value = reader["IpadIMEI"];
                    row.Cells["NameSPCT"].Value = reader["NameSPCT"];
                    row.Cells["Price"].Value = reader["Price"];
                    row.Cells["PercentDiscount"].Value = reader["PercentDiscount"];
                    row.Cells["OrderCreateAt"].Value = reader["OrderCreateAt"];

                    // Tính toán giá sau chiết khấu
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    decimal percentDiscount = Convert.ToDecimal(reader["PercentDiscount"]);
                    decimal finalPrice = price * (1 - percentDiscount / 100);
                    row.Cells["FinalPrice"].Value = finalPrice.ToString("F2");
                }
                conn.Close();
            }
        }







        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var newOrder = new Order
                {
                    OrderID = Guid.NewGuid(),
                    CustomerID = Guid.Parse("41c71f03-a71d-4434-b97d-6570c344901c"),
                    AccountID = Guid.Parse("94f5180e-ab9c-4843-a743-800cfa3ba75b"),
                    IDVoucher = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                    TotalAmount = 0,
                    Price = 0,
                    Status = 0,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "admin",
                    UpdatedBy = "admin"
                };

                Context.Orders.Add(newOrder);
                Context.SaveChanges();
                LoadDataHD();
                MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo hóa đơn thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bttHDT_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu txtHDHT.Text không rỗng
                if (string.IsNullOrWhiteSpace(txtHDHT.Text))
                {
                    MessageBox.Show("ID không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Guid orderID;
                // Kiểm tra nếu txtHDHT.Text có thể chuyển đổi thành Guid
                if (!Guid.TryParse(txtHDHT.Text.Trim(), out orderID))
                {
                    MessageBox.Show("ID không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mở kết nối cơ sở dữ liệu nếu nó chưa mở
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (var transaction = Context.Database.BeginTransaction())
                {
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM OrderDetails WHERE OrderID = @OrderID; DELETE FROM Orders WHERE OrderID = @OrderID;";
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                }

                LoadDataHD();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }




        void UpdateOrderDetails()
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu nếu nó chưa mở
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Truy vấn để tính tổng Quantity và TotalPrice cho mỗi Order
                string sqlUpdate = @"
            UPDATE Orders
            SET 
                TotalAmount = COALESCE((
                    SELECT SUM(od.Quantity)
                    FROM OrderDetails od
                    WHERE od.OrderID = Orders.OrderID
                ), 0),
                Price = COALESCE((
                    SELECT SUM(od.Quantity * pd.Price)
                    FROM OrderDetails od
                    JOIN ProductDetails pd ON od.IMEI = pd.IMEI
                    WHERE od.OrderID = Orders.OrderID
                ), 0);
            ";

                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối cơ sở dữ liệu
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }








        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvHD.CurrentRow.Selected = true;

                txtHDHT.Text = dgvHD.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();

            }
        }

        private void bttCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu nếu nó chưa mở
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                UpdateOrderDetails();
                // Câu truy vấn SELECT
                string sql5 = @"SELECT OrderDetailID, 
                       OrderID, 
                       IMEI, 
                       ProductName, 
                       Quantity, 
                       UnitPrice, 
                       DiscountValue, 
                       CreatedAt, 
                       UpdatedAt, 
                       CreatedBy, 
                       UpdatedBy
                FROM OrderDetails
                WHERE OrderID = @OrderID";





                // Khởi tạo SqlCommand
                SqlCommand cmd = new SqlCommand(sql5, conn);
                cmd.Parameters.AddWithValue("@OrderID", txtHDHT.Text);

                // Thực hiện lệnh SELECT
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                sda.Fill(ds);

                // Kiểm tra xem DataSet có dữ liệu hay không
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Điền dữ liệu vào DataGridView
                    dgvHDCT.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho OrderID: " + txtHDHT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối cơ sở dữ liệu
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Guid orderCT;
                // Kiểm tra GUID hợp lệ cho OrderDetailID
                if (!Guid.TryParse(txtHDCT.Text, out orderCT))
                {
                    MessageBox.Show("Mã hóa đơn chi tiết không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tìm OrderDetail bằng OrderDetailID
                OrderDetail orderItem = Context.OrderDetails.FirstOrDefault(u => u.OrderDetailID == orderCT);

                if (orderItem != null)
                {
                    // Tìm sản phẩm bằng IMEI hoặc ProductID từ OrderDetail
                    var productDetail = Context.ProductDetails.FirstOrDefault(pd => pd.ProductDetailID == orderItem.ProductDetailID);

                    if (productDetail != null)
                    {
                        productDetail.Status = 1;
                    }

                    Context.OrderDetails.Remove(orderItem);
                    Context.SaveChanges();

                    LoadData();
                    LoadDataHDCT();
                    LayDLHD();
                    bttCL_Click(sender, e);

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


        private void bttCL_Click(object sender, EventArgs e)
        {
            txtMSP.Text = "";
            txtHDCT.Text = "";
            txtimei.Text = "";
            txtSP.Text = "";
            txtSZ.Text = "";
            DTPVC.Text = "";
            txtSL.Text = "";
            txtGia.Text = "";
            txtTG.Text = "";
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                Guid oderCT = Guid.Parse(txtHDCT.Text);
                OrderDetail oderItem = Context.OrderDetails.FirstOrDefault(u => u.OrderDetailID == oderCT);

                if (oderItem != null)
                {

                    oderItem.OrderDetailID = Guid.NewGuid();
                    oderItem.ProductDetailID = Guid.Parse(txtMSP.Text);
                    oderItem.OrderID = Guid.Parse(txtHDCT.Text);
                    oderItem.Quantity = Convert.ToInt32("1");
                    oderItem.ProductName = txtSP.Text;
                    oderItem.UnitPrice = Convert.ToInt32(txtGia.Text);
                    oderItem.DiscountValue = Convert.ToInt32(txtTG.Text);
                    oderItem.CreatedAt = DateTime.Now;
                    oderItem.UpdatedAt = DateTime.Now;
                    oderItem.CreatedBy = "admin";
                    oderItem.UpdatedBy = "admin";

                }
                Context.OrderDetails.Update(oderItem);
                Context.SaveChanges();
                LoadData();
                LoadDataHDCT();
                LayDLHD();
                bttCL_Click(sender, e);
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHDCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDCT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvHDCT.CurrentRow.Selected = true;
                txtimei.Text = dgvHDCT.Rows[e.RowIndex].Cells["IMEI"].Value.ToString();
                txtHDCT.Text = dgvHDCT.Rows[e.RowIndex].Cells["OrderDetailID"].Value.ToString();
                txtSP.Text = dgvHDCT.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtSZ.Text = dgvHDCT.Rows[e.RowIndex].Cells["DiscountValue"].Value.ToString();
                txtGia.Text = dgvHDCT.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtSL.Text = "1";

                // Chuyển đổi txtSZ.Text và txtGia.Text thành số
                decimal discount = Convert.ToDecimal(txtSZ.Text);
                decimal price = Convert.ToDecimal(txtGia.Text);
                int quantity = Convert.ToInt32(txtSL.Text);

                // Tính tổng tiền
                decimal totalPrice = quantity * price * (1 - (discount / 100));

                // Gán kết quả vào txtTG
                txtTG.Text = totalPrice.ToString("F2");

            }
            LayDLSP();
        }

        public delegate void TransferDataHandler(DataTable data);
        public event TransferDataHandler OnDataTransfer;


        private void bttHDCT_Click(object sender, EventArgs e)
        {
            DataTable selectedData = new DataTable();
            foreach (DataGridViewColumn column in dgvHD.Columns)
            {
                Type columnType = column.ValueType;

                // Nếu cột là nullable, sử dụng kiểu dữ liệu không nullable tương ứng
                if (columnType.IsGenericType && columnType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    columnType = Nullable.GetUnderlyingType(columnType);
                }

                selectedData.Columns.Add(column.Name, columnType);
            }

            foreach (DataGridViewRow row in dgvHD.SelectedRows)
            {
                DataRow dataRow = selectedData.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.OwningColumn.Name] = cell.Value ?? DBNull.Value; // Nếu giá trị là null, chuyển thành DBNull.Value
                }
                selectedData.Rows.Add(dataRow);
            }

            hdctForm.ReceiveData(selectedData);
        }


        private void bttRL_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearDataGridView()
        {
            // Cách 1: Đặt DataSource về null
            dgvHDCT.DataSource = null;

            // Cách 2: Xóa tất cả các hàng trong DataGridView
            dgvHDCT.Rows.Clear();
        }
        private void bttRL_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                LayDLHD();
                ClearDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
