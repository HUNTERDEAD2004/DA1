using AppData.Models;
using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.Win32;
using DocumentFormat.OpenXml.InkML;
using System.Windows.Controls;

namespace PRL.View
{
    public partial class Orderform : Form
    {
        SqlConnection conn = new SqlConnection("Server=PHUC\\SQLEXPRESS;Database=IphoneNhom1;Trusted_Connection=True;TrustServerCertificate=True");
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
            btnSearch.Click += new EventHandler(btnSearch_Click);
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

                //SqlCommand cmd3 = new SqlCommand("SELECT * FROM Orders", conn);
                //SqlDataReader dr3 = cmd3.ExecuteReader();
                //DataTable dt3 = new DataTable();
                //dt3.Load(dr3);
                //dr3.Close();
                //dgvHD.DataSource = dt3;
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
            string sql2 = "SELECT \r\n  pd.Name AS ProductName, \r\n    d.DisplayName, \r\n    c.CPUName AS CPU, \r\n    g.GPUName AS GPU, \r\n    r.RAMSize AS RAM, \r\n    pd.Price, \r\n    p.ProductName, \r\n    p.Description, \r\n    co.ColorName AS Color, \r\n    pd.Quantity,\r\n\tp.Total,\r\n\tpd.Status,\r\n    s.SaleDescription AS SaleCode, \r\n    s.SaleDescription AS SaleName, \r\n    s.DiscountValue AS PercentDiscount, \r\n    s.StartDate AS SaleStart, \r\n    s.EndDate AS SaleEnd\r\n   pd.ProductDetailID, \r\n    pd.ProductID, \r\n FROM \r\n    ProductDetails pd\r\nINNER JOIN \r\n    Products p ON pd.ProductID = p.ProductID\r\nINNER JOIN \r\n    Colours co ON pd.ColorID = co.ColorID\r\nINNER JOIN \r\n    Displays d ON pd.DisplayID = d.DisplayID\r\nINNER JOIN \r\n    CPUs c ON pd.CPUID = c.CPUID\r\nINNER JOIN \r\n    GPUs g ON pd.GPUID = g.GPUID\r\nINNER JOIN \r\n    RAMs r ON pd.RAMID = r.RAMID\r\nINNER JOIN \r\n    Sales s ON pd.SaleID = s.SaleID\r\nWHERE \r\n    pd.Status = 1;";

            sda = new SqlDataAdapter(sql2, conn);
            ds = new DataSet();
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSP.CurrentRow.Selected = true;
                txtSPCT.Text = dgvSP.Rows[e.RowIndex].Cells["ProductDetailID"].Value.ToString();
                txtMSP.Text = dgvSP.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtSP.Text = dgvSP.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtSZ.Text = dgvSP.Rows[e.RowIndex].Cells["PercentDiscount"].Value.ToString();
                DTPVC.Text = dgvSP.Rows[e.RowIndex].Cells["SaleEnd"].Value.ToString();
                txtGia.Text = dgvSP.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtSL.Text = "1";

                var imei = dgvSP.Rows[e.RowIndex].Cells["ProductDetailID"].Value.ToString();
                Guid productDetailID = Guid.Parse(imei);

                // Lấy danh sách IMEI có ProductDetailID tương ứng và có Status = 1
                var imeis = Context.iMEIs.Where(im => im.ProductDetailID == productDetailID && im.Status == 1).ToList();
                imeis.Insert(0, new IMEI { ImeiID = "-- Chọn thông tin IMEI --" });

                // Cập nhật DataSource cho ComboBox
                cbImei.DataSource = imeis;
                cbImei.ValueMember = "ImeiID";
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
        private void LoadComboBoxData()
        {
            // Lấy danh sách IMEI có Status = 1
            var imei = Context.iMEIs.Where(i => i.Status == 1).ToList();

            // Thêm một mục đầu tiên vào danh sách để người dùng chọn
            imei.Insert(0, new IMEI { ImeiID = "-- Chọn thông tin IMEI --" });

            // Thiết lập DataSource cho ComboBox
            cbImei.DataSource = imei;
            cbImei.ValueMember = "ImeiID";

            // Lấy danh sách IMEI có Status = 1
            var sp = Context.Products.ToList();

            // Thêm một mục đầu tiên vào danh sách để người dùng chọn
            sp.Insert(0, new Product { ProductID = Guid.Empty, ProductName = "" });

            // Thiết lập DataSource cho ComboBox
            cbSPTk.DataSource = sp;
            cbSPTk.ValueMember = "ProductName";
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
                               pd.Price,
                               pd.Quantity,
                               ProductNames = p.ProductName,
                               p.Description,
                               Color = co.ColorName,
                               p.Total,
                               SaleCode = s.SaleDescription,
                               SaleName = s.SaleDescription,
                               PercentDiscount = s.DiscountValue,
                               SaleStart = s.StartDate,
                               SaleEnd = s.EndDate,
                               pd.ProductDetailID,
                               pd.ProductID,
                           };

                dgvSP.DataSource = data.ToList();
            }
        }





        private void LoadDataHD()
        {
            using (var context = new IphoneDbContext())
            {
                var orders = context.Orders
                    .Where(o => o.Status == 0)
                    .Select(o => new
                    {
                        o.OrderID,
                        Username = o.Account.Username,  // Tên nhân viên
                        CustomerName = o.Customer.CustomerName,  // Tên khách hàng
                        ReportDate = o.Report.ReportDate,  // Ngày báo cáo
                        ReportID = o.Report.ReportID,  // Ngày báo cáo
                        o.IDVoucher,
                        Quantity = o.OrderDetails.Sum(od => od.Quantity),  // Tổng số lượng
                        Price = o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice),  // Tổng tiền
                        Status = o.Status == 0 ? "Chưa thanh toán" : "Đã thanh toán",
                        o.CreatedAt,
                        o.UpdatedAt,
                        o.UpdatedBy,
                        o.CreatedBy,
                    })
                    .ToList();

                dgvHD.DataSource = orders;

                dgvHD.Columns["OrderID"].DisplayIndex = 0;
                dgvHD.Columns["CustomerName"].DisplayIndex = 1;
                dgvHD.Columns["Username"].DisplayIndex = 2;
                dgvHD.Columns["Quantity"].DisplayIndex = 3;
                dgvHD.Columns["Price"].DisplayIndex = 4;
                dgvHD.Columns["Status"].DisplayIndex = 5;
                dgvHD.Columns["ReportDate"].DisplayIndex = 6;
                dgvHD.Columns["IDVoucher"].DisplayIndex = 7;
                dgvHD.Columns["ReportID"].DisplayIndex = 8;
                dgvHD.Columns["CreatedAt"].DisplayIndex = 9;
                dgvHD.Columns["UpdatedAt"].DisplayIndex = 10;
                dgvHD.Columns["CreatedBy"].DisplayIndex = 11;
                dgvHD.Columns["UpdatedBy"].DisplayIndex = 12;
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

                dgvHDCT.Columns["ImeiID"].DisplayIndex = 0;
                dgvHDCT.Columns["ProductName"].DisplayIndex = 1;
                dgvHDCT.Columns["Quantity"].DisplayIndex = 2;
                dgvHDCT.Columns["UnitPrice"].DisplayIndex = 3;
                dgvHDCT.Columns["DiscountValue"].DisplayIndex = 4;
                dgvHDCT.Columns["OrderDetailID"].DisplayIndex = 5;
                dgvHDCT.Columns["OrderID"].DisplayIndex = 6;
                dgvHDCT.Columns["ProductDetailID"].DisplayIndex = 7;
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
                Guid productId, orderId, productDetailId;

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

                // Check ProductDetailID (IMEI)
                if (!Guid.TryParse(txtSPCT.Text, out productDetailId))
                {
                    MessageBox.Show("IMEI không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check imei 15 số
                string newImei = cbImei.Text;
                if (!long.TryParse(newImei, out _) || newImei.Length != 15)
                {
                    MessageBox.Show("IMEI phải là số và có đủ 15 số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // Giảm số lượng sản phẩm
                    if (productDetail.Quantity > 0)
                    {
                        productDetail.Quantity -= 1;
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã hết hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
                    string tk = null;
                    if (key != null)
                    {
                        tk = key.GetValue("Username").ToString();
                        string query = "SELECT AccountID FROM Accounts WHERE Username = @Username";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Username", tk);


                        key.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khóa Registry", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    var Imei = context.iMEIs.FirstOrDefault(i => i.ImeiID == newImei);
                    if (Imei == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Imei.Status = 2;
                        Imei.UpdatedAt = DateTime.Now;
                        Imei.UpdatedBy = tk;
                        context.SaveChanges();
                    }



                    // Lấy giá và các thông tin từ ProductDetails
                    decimal unitPrice = productDetail.Price;
                    string productName = productDetail.Name;

                    // Lấy giá trị chiết khấu từ bảng Sales
                    var sale = context.Sales.FirstOrDefault(s => s.SaleID == productDetail.SaleID);
                    decimal discountValue = sale != null ? sale.DiscountValue : 0;

                    // Tính toán giá sau chiết khấu
                    decimal finalPrice = unitPrice;

                    if (discountValue > 0 && discountValue < 100)
                    {
                        // Giảm theo phần trăm
                        finalPrice = unitPrice * (1 - (discountValue / 100));
                    }
                    else if (discountValue > 1000 && discountValue <= unitPrice)
                    {
                        // Giảm theo giá cố định
                        finalPrice = unitPrice - discountValue;
                    }
                    else if ((discountValue >= 100 && discountValue <= 1000) || discountValue > unitPrice)
                    {
                        MessageBox.Show("Giá trị chiết khấu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Tạo OrderDetailID mới
                    Guid newOrderDetailId = Guid.NewGuid();

                    // Check if IMEI already exists
                    var existingImei = context.iMEIs.FirstOrDefault(i => i.ImeiID == newImei);
                    if (existingImei != null)
                    {
                        // Cập nhật OrderDetailID cho IMEI đã tồn tại
                        existingImei.OrderDetailID = newOrderDetailId;
                        existingImei.UpdatedAt = DateTime.Now;
                        existingImei.UpdatedBy = "admin";
                    }
                    else
                    {
                        // Add new IMEI to IMEIs table
                        var newImeiEntry = new IMEI
                        {
                            ImeiID = newImei,
                            ProductDetailID = productDetailId,
                            OrderDetailID = newOrderDetailId,
                            Status = 2,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            CreatedBy = "admin",
                            UpdatedBy = "admin"
                        };
                        context.iMEIs.Add(newImeiEntry);
                    }

                    var hdtc = new OrderDetail
                    {
                        OrderDetailID = newOrderDetailId,
                        OrderID = orderId,
                        ProductDetailID = Guid.Parse(txtimei.Text),
                        ProductName = txtSP.Text,
                        Quantity = 1,
                        UnitPrice = finalPrice,
                        DiscountValue = discountValue,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        CreatedBy = "admin",
                        UpdatedBy = "admin"
                    };

                    context.OrderDetails.Add(hdtc);
                    context.SaveChanges();

                    LoadData();
                    LoadDataHDCT();
                    LoadDataHD();

                    clear();
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




        private Guid CheckAndCreateReport()
        {
            try
            {
                // Lấy ngày hôm nay
                DateTime today = DateTime.Today;

                // Kiểm tra xem có báo cáo nào đã được tạo hôm nay chưa
                var existingReport = Context.Reports.FirstOrDefault(r => r.ReportDate == today);

                if (existingReport == null)
                {
                    // Nếu chưa có, tạo báo cáo mới
                    var newReport = new Report
                    {
                        ReportID = Guid.NewGuid(),
                        ReportDate = today,
                        TotalSold = 0,
                        TotalAmount = 0,
                        SuccessfulOrders = 0,
                        CancelledOrders = 0,
                        PendingOrders = 0,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        CreatedBy = "admin",
                        UpdatedBy = "admin"
                    };

                    Context.Reports.Add(newReport);
                    Context.SaveChanges();

                    return newReport.ReportID; // Trả về ReportID của báo cáo mới tạo
                }

                return existingReport.ReportID; // Trả về ReportID của báo cáo đã tồn tại
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra và tạo báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Guid.Empty; // Trả về một Guid rỗng nếu có lỗi
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra và tạo báo cáo nếu cần, đồng thời lấy ReportID
                Guid reportId = CheckAndCreateReport();

                var newOrder = new Order
                {
                    OrderID = Guid.NewGuid(),
                    CustomerID = Guid.Parse("41c71f03-a71d-4434-b97d-6570c344901c"),
                    AccountID = Guid.Parse("94f5180e-ab9c-4843-a743-800cfa3ba75b"),
                    IDVoucher = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                    ReportID = reportId,  // Gán ReportID vào đơn hàng
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
                    SELECT SUM(od.Quantity * od.UnitPrice)
                    FROM OrderDetails od
                    JOIN ProductDetails pd ON od.ProductDetailID = pd.ProductDetailID
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
                string sql5 = @"
                SELECT          
               od.ProductName, 
               od.Quantity, 
               od.UnitPrice, 
               od.DiscountValue, 
                i.ImeiID,
               i.OrderDetailID,
               od.OrderID, 
               od.ProductDetailID
        FROM OrderDetails od
        JOIN IMEIs i ON od.OrderDetailID = i.OrderDetailID
        WHERE od.OrderID = @OrderID";

                // Khởi tạo SqlCommand
                SqlCommand cmd = new SqlCommand(sql5, conn);
                cmd.Parameters.AddWithValue("@OrderID", txtHDHT.Text);
                // Ẩn cột OrderDetailID trong DataGridView

                // Thực hiện lệnh SELECT
                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                sda.Fill(ds);

                // Kiểm tra xem DataSet có dữ liệu hay không
                if (ds.Tables[0].Rows.Count > 0)
                {
                    using (var context = new IphoneDbContext())
                    {
                        // Tính toán giá sau chiết khấu cho từng hàng
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            Guid productDetailId = (Guid)row["ProductDetailID"];
                            var productDetail = context.ProductDetails.FirstOrDefault(pd => pd.ProductDetailID == productDetailId);
                            if (productDetail == null)
                            {
                                MessageBox.Show($"Không tìm thấy sản phẩm cho ProductDetailID: {productDetailId}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            decimal unitPrice = productDetail.Price;
                            // Lấy giá trị chiết khấu từ bảng Sales
                            var sale = context.Sales.FirstOrDefault(s => s.SaleID == productDetail.SaleID);
                            decimal discountValue = sale != null ? sale.DiscountValue : 0;
                            decimal finalPrice = unitPrice;

                            if (discountValue > 0 && discountValue < 100)
                            {
                                // Giảm theo phần trăm
                                finalPrice = unitPrice * (1 - (discountValue / 100));
                            }
                            else if (discountValue > 1000 && discountValue <= unitPrice)
                            {
                                // Giảm theo giá cố định
                                finalPrice = unitPrice - discountValue;
                            }
                            else if ((discountValue >= 100 && discountValue <= 1000) || discountValue > unitPrice)
                            {
                                MessageBox.Show("Giá trị chiết khấu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            row["UnitPrice"] = finalPrice;
                        }
                    }

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
                string newImei = cbImei.Text;

                if (orderItem != null)
                {
                    // Tìm sản phẩm bằng IMEI hoặc ProductID từ OrderDetail
                    var productDetail = Context.ProductDetails.FirstOrDefault(pd => pd.ProductDetailID == orderItem.ProductDetailID);

                    if (productDetail != null)
                    {
                        productDetail.Quantity += 1;
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

        void clear()
        {
            txtMSP.Text = "";
            txtHDCT.Text = "";
            txtSPCT.Text = "";
            txtSP.Text = "";
            txtSZ.Text = "";
            DTPVC.Text = "";
            txtSL.Text = "";
            txtGia.Text = "";
            cbImei.Text = "";
        }
        private void bttCL_Click(object sender, EventArgs e)
        {
            clear();
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
                    oderItem.IMEI = txtMSP.Text;
                    oderItem.OrderID = Guid.Parse(txtHDCT.Text);
                    oderItem.Quantity = Convert.ToInt32("1");
                    oderItem.ProductName = txtSP.Text;
                    oderItem.UnitPrice = Convert.ToInt32(txtGia.Text);
                    oderItem.DiscountValue = Convert.ToInt32(cbImei.Text);
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
                txtSPCT.Text = dgvHDCT.Rows[e.RowIndex].Cells["ProductDetailID"].Value.ToString();
                cbImei.Text = dgvHDCT.Rows[e.RowIndex].Cells["ImeiID"].Value.ToString();
                txtHDCT.Text = dgvHDCT.Rows[e.RowIndex].Cells["OrderDetailID"].Value.ToString();
                txtSP.Text = dgvHDCT.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtSZ.Text = dgvHDCT.Rows[e.RowIndex].Cells["DiscountValue"].Value.ToString();
                txtGia.Text = dgvHDCT.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtSL.Text = "1";

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

            dgvHDCT.DataSource = null;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTKSP.Text.Trim();
            string selectedProductName = cbSPTk.SelectedItem != null ? cbSPTk.SelectedItem.ToString() : string.Empty;

            using (var context = new IphoneDbContext())
            {
                if (string.IsNullOrWhiteSpace(searchTerm) && string.IsNullOrWhiteSpace(selectedProductName))
                {
                    // Gọi lại LoadData nếu không có từ khóa tìm kiếm
                    LoadData();
                }
                else
                {
                    // Truy vấn với từ khóa tìm kiếm
                    var data = from pd in context.ProductDetails
                               join p in context.Products on pd.ProductID equals p.ProductID
                               join co in context.Colours on pd.ColorID equals co.ColorID
                               join d in context.Displays on pd.DisplayID equals d.DisplayID
                               join c in context.CPUs on pd.CPUID equals c.CPUID
                               join g in context.GPUs on pd.GPUID equals g.GPUID
                               join r in context.RAMs on pd.RAMID equals r.RAMID
                               join s in context.Sales on pd.SaleID equals s.SaleID
                               where pd.Status == 1 && (pd.Name.Contains(searchTerm) || p.ProductName.Contains(selectedProductName))
                               select new
                               {
                                   ProductName = pd.Name,
                                   d.DisplayName,
                                   CPU = c.CPUName,
                                   GPU = g.GPUName,
                                   RAM = r.RAMSize,
                                   pd.Price,
                                   pd.Quantity,
                                   ProductNames = p.ProductName,
                                   p.Description,
                                   Color = co.ColorName,
                                   p.Total,
                                   pd.Status,
                                   SaleCode = s.SaleDescription,
                                   SaleName = s.SaleDescription,
                                   PercentDiscount = s.DiscountValue,
                                   SaleStart = s.StartDate,
                                   SaleEnd = s.EndDate,
                                   pd.ProductDetailID,
                                   pd.ProductID,
                               };

                    dgvSP.DataSource = data.ToList();
                }
            }
        }
    }

}
