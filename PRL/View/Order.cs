using DAL.Models;
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
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PRL.View
{
    public partial class Order : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=AppleStore4;Trusted_Connection=True;TrustServerCertificate=True");
        SqlDataAdapter sda;
        DataSet ds;
        // Đặt màu chữ cho toàn bộ form
        AppDbContext Context;
        private HDCT hdctForm;
        public Order(HDCT hdct)
        {
            this.hdctForm = hdct;
            hdctForm = new HDCT();
            hdctForm.Show();
            Context = new AppDbContext();
            InitializeComponent();
        }

        void HienThi()
        {
            try
            {

                //Load Users
                SqlCommand cmd = new SqlCommand("SELECT * FROM oderDetails", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                dgvHDCT.DataSource = dt;
                dgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHDCT.DefaultCellStyle.ForeColor = Color.Black;
                dgvHDCT.DefaultCellStyle.BackColor = Color.White;
                dgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvHDCT.AutoResizeColumns();

                // Load userRoles
                SqlCommand cmd2 = new SqlCommand("\r\nSELECT \r\n    iph.IphoneIMEI,\r\n    iph.ProductId,\r\n iph.NameSP,\r\n    iph.Display,\r\n    iph.RearCamera,\r\n    iph.CameraSelfie,\r\n    iph.CPU,\r\n    iph.GPU,\r\n    iph.RAM,\r\n\tiph.Price,\r\n    pa.CategoryID,\r\n    pa.SaleID,\r\n    pa.Name AS ProductName,\r\n    pa.Description,\r\n    pa.OperatingSystem,\r\n    pa.BatteryCapacity,\r\n    pa.Weight,\r\n    pa.YearOfManufacture,\r\n    pa.Material,\r\n    pa.Origin,\r\n    pa.Color,\r\n    pa.Quantity,\r\n    pa.status,\r\n    pa.Version,\r\n    pa.imagePath,\r\n    cat.Name AS CategoryName,\r\n    sa.SaleCode,\r\n    sa.SaleName,\r\n sa.PercentDiscount,\r\n    sa.SaleStart,\r\n    sa.SaleEnd\r\nFROM \r\n    Iphones iph\r\nINNER JOIN \r\n    productApples pa ON iph.ProductId = pa.ProductId\r\nINNER JOIN \r\n    Categories cat ON pa.CategoryID = cat.CategoryID\r\nINNER JOIN \r\n    Sales sa ON pa.SaleID = sa.SaleID;\r\n", conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);
                dr2.Close();
                dgvSP.DataSource = dt2;
                dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSP.DefaultCellStyle.ForeColor = Color.Black;
                dgvSP.DefaultCellStyle.BackColor = Color.White;
                dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvSP.AutoResizeColumns();

                SqlCommand cmd3 = new SqlCommand("SELECT * FROM Oders", conn);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                DataTable dt3 = new DataTable();
                dt3.Load(dr3);
                dr3.Close();
                dgvHD.DataSource = dt3;
                dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHD.DefaultCellStyle.ForeColor = Color.Black;
                dgvHD.DefaultCellStyle.BackColor = Color.White;
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
            string sql = "SELECT * FROM oderDetails";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        void LayDLHD()
        {
            string sql3 = "SELECT * FROM Oders";
            sda = new SqlDataAdapter(sql3, conn);
            ds = new DataSet();
        }
        void LayDLSP()
        {
            string sql2 = "\r\nSELECT \r\n    iph.IphoneIMEI,\r\n    iph.ProductId,\r\n iph.NameSP,\r\n    iph.Display,\r\n    iph.RearCamera,\r\n    iph.CameraSelfie,\r\n    iph.CPU,\r\n    iph.GPU,\r\n    iph.RAM,\r\n\tiph.Price,\r\n    pa.CategoryID,\r\n    pa.SaleID,\r\n    pa.Name AS ProductName,\r\n    pa.Description,\r\n    pa.OperatingSystem,\r\n    pa.BatteryCapacity,\r\n    pa.Weight,\r\n    pa.YearOfManufacture,\r\n    pa.Material,\r\n    pa.Origin,\r\n    pa.Color,\r\n    pa.Quantity,\r\n    pa.status,\r\n    pa.Version,\r\n    pa.imagePath,\r\n    cat.Name AS CategoryName,\r\n    sa.SaleCode,\r\n    sa.SaleName,\r\n sa.PercentDiscount,\r\n    sa.SaleStart,\r\n    sa.SaleEnd\r\nFROM \r\n    Iphones iph\r\nINNER JOIN \r\n    productApples pa ON iph.ProductId = pa.ProductId\r\nINNER JOIN \r\n    Categories cat ON pa.CategoryID = cat.CategoryID\r\nINNER JOIN \r\n    Sales sa ON pa.SaleID = sa.SaleID;\r\n";

            sda = new SqlDataAdapter(sql2, conn);
            ds = new DataSet();
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSP.CurrentRow.Selected = true;
                txtimei.Text = dgvSP.Rows[e.RowIndex].Cells["IphoneIMEI"].Value.ToString();
                txtMSP.Text = dgvSP.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                txtSP.Text = dgvSP.Rows[e.RowIndex].Cells["NameSP"].Value.ToString();
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
            using (var context = new AppDbContext())
            {
                var data = from iph in context.Iphones
                           join pa in context.productApples on iph.ProductId equals pa.ProductId
                           join cat in context.Categories on pa.CategoryID equals cat.CategoryID
                           join sa in context.sales on pa.SaleID equals sa.SaleID
                           select new
                           {
                               iph.IphoneIMEI,
                               iph.ProductId,
                               iph.NameSP,
                               iph.Display,
                               iph.RearCamera,
                               iph.CameraSelfie,
                               iph.CPU,
                               iph.GPU,
                               iph.RAM,
                               iph.Price,
                               pa.CategoryID,
                               pa.SaleID,
                               ProductName = pa.Name,
                               pa.Description,
                               pa.OperatingSystem,
                               pa.BatteryCapacity,
                               pa.Weight,
                               pa.YearOfManufacture,
                               pa.Material,
                               pa.Origin,
                               pa.Color,
                               pa.Quantity,
                               pa.status,
                               pa.Version,
                               pa.imagePath,
                               CategoryName = cat.Name,
                               sa.SaleCode,
                               sa.SaleName,
                               sa.PercentDiscount,
                               sa.SaleStart,
                               sa.SaleEnd
                           };

                dgvSP.DataSource = data.ToList();
            }
        }

        private void LoadDataHD()
        {
            using (var context = new AppDbContext())
            {
                var oder = context.Oders.ToList();
                dgvHD.DataSource = oder.Select(u => new
                {
                    u.OderID,
                    u.UserID,
                    u.CustomerID,
                    u.Quantity,
                    u.TotalPrice,
                    u.Status,
                    u.CreateAt,
                    u.UpdateAt,
                    u.UpdateBy,
                    u.CreateBy,

                }).ToList();
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

                // Kiểm tra GUID hợp lệ cho ProductId
                if (!Guid.TryParse(txtMSP.Text, out productId))
                {
                    MessageBox.Show("Mã sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra GUID hợp lệ cho OderID
                if (!Guid.TryParse(txtHDHT.Text, out orderId))
                {
                    MessageBox.Show("Mã hóa đơn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var hdtc = new OderDetail
                {
                    OrderDetailsID = Guid.NewGuid(),
                    ProductId = Guid.Parse(txtMSP.Text),
                    OderID = Guid.Parse(txtHDHT.Text),
                    Quantity = Convert.ToInt32("1"),
                    IMEI = txtimei.Text,
                    NameSPCT = txtSP.Text,
                    Price = ParseFloat(txtTG.Text),
                    PercentDiscount = ParseFloat(txtSZ.Text),
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    CreateBy = "admin",
                    UpdateBy = "admin"
                };

                Context.oderDetails.Add(hdtc);
                Context.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thành công!, toẹt zời hehehe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            orderIds = Context.Oders.Select(o => o.OderID).ToList();
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
                        o.UserID, o.CustomerID, o.Quantity AS OrderQuantity, o.TotalPrice, o.Status, o.CreateAt AS OrderCreateAt, o.UpdateAt AS OrderUpdateAt, o.CreateBy AS OrderCreateBy, o.UpdateBy AS OrderUpdateBy
                FROM oderDetails od
                JOIN Oders o ON od.OderID = o.OderID
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
                var newOrder = new Oder
                {
                    OderID = Guid.NewGuid(),
                    UserID = null,
                    CustomerID = null,
                    Quantity = 0,
                    TotalPrice = 0,
                    Status = Convert.ToInt32("0"),
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    CreateBy = "admin",
                    UpdateBy = "admin"
                };

                Context.Oders.Add(newOrder);
                Context.SaveChanges();
                LoadDataHD();
                MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tạo hóa đơn thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var newOrderCT = new OderDetail
        //        {
        //            OrderDetailsID = Guid.NewGuid(),
        //            ProductId = Guid.Parse(txtMSP.Text),
        //            OderID = Guid.Parse(txtHDHT.Text),
        //            Quantity = 1,
        //            IpadIMEI = txtimei.Text,
        //            NameSPCT = txtSP.Text,
        //            Price = Convert.ToInt32(txtTG.Text),
        //            PercentDiscount = Convert.ToInt32(txtSZ.Text),
        //            CreateAt = DateTime.Now,
        //            UpdateAt = DateTime.Now,
        //            CreateBy = "admin",
        //            UpdateBy = "admin"
        //        };

        //        Context.oderDetails.Add(newOrderCT);
        //        Context.SaveChanges();
        //        LoadDataHD();
        //        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Thêm sản phẩm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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
                    cmd.CommandText = "DELETE FROM OderDetails WHERE OderID = @OderID; DELETE FROM Oders WHERE OderID = @OderID;";
                    cmd.Parameters.AddWithValue("@OderID", orderID);
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

                // Truy vấn để tính tổng Quantity và TotalPrice cho mỗi Oder
                string sqlUpdate = @"
            UPDATE Oders
            SET 
                Quantity = COALESCE((
                    SELECT COUNT(*)
                    FROM oderDetails
                    WHERE oderDetails.OderID = Oders.OderID
                ), 0),
                TotalPrice = COALESCE((
                    SELECT SUM(Quantity * Price)
                    FROM oderDetails
                    WHERE oderDetails.OderID = Oders.OderID
                ), 0)
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

                txtHDHT.Text = dgvHD.Rows[e.RowIndex].Cells["OderID"].Value.ToString();

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
                string sql5 = @"SELECT od.OrderDetailsID, od.ProductId, od.OderID, od.Quantity, od.IMEI, od.NameSPCT, od.Price, od.PercentDiscount, od.CreateAt, od.UpdateAt, od.CreateBy, od.UpdateBy,
                        o.UserID, o.CustomerID, o.Quantity AS OrderQuantity, o.TotalPrice, o.Status, o.CreateAt AS OrderCreateAt, o.UpdateAt AS OrderUpdateAt, o.CreateBy AS OrderCreateBy, o.UpdateBy AS OrderUpdateBy
                        FROM oderDetails od
                        JOIN Oders o ON od.OderID = o.OderID
                        WHERE od.OderID = @OrderID";

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
                Guid oderCT = Guid.Parse(txtHDCT.Text);
                OderDetail oderitem = Context.oderDetails.FirstOrDefault(u => u.OrderDetailsID == oderCT);

                if (oderitem != null)
                {
                    Context.oderDetails.Remove(oderitem);
                    Context.SaveChanges();
                    LoadData();
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
                OderDetail oderItem = Context.oderDetails.FirstOrDefault(u => u.OrderDetailsID == oderCT);

                if (oderItem != null)
                {

                    oderItem.OrderDetailsID = Guid.NewGuid();
                    oderItem.ProductId = Guid.Parse(txtMSP.Text);
                    oderItem.OderID = Guid.Parse(txtHDCT.Text);
                    oderItem.Quantity = Convert.ToInt32("1");
                    oderItem.IMEI = txtimei.Text;
                    oderItem.NameSPCT = txtSP.Text;
                    oderItem.Price = Convert.ToInt32(txtGia.Text);
                    oderItem.PercentDiscount = Convert.ToInt32(txtTG.Text);
                    oderItem.CreateAt = DateTime.Now;
                    oderItem.UpdateAt = DateTime.Now;
                    oderItem.CreateBy = "admin";
                    oderItem.UpdateBy = "admin";

                }
                Context.oderDetails.Update(oderItem);
                Context.SaveChanges();
                LoadData();
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
                txtHDCT.Text = dgvHDCT.Rows[e.RowIndex].Cells["OrderDetailsID"].Value.ToString();
                txtMSP.Text = dgvHDCT.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                txtSP.Text = dgvHDCT.Rows[e.RowIndex].Cells["NameSPCT"].Value.ToString();
                txtSZ.Text = dgvHDCT.Rows[e.RowIndex].Cells["PercentDiscount"].Value.ToString();
                txtGia.Text = dgvHDCT.Rows[e.RowIndex].Cells["Price"].Value.ToString();
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
                selectedData.Columns.Add(column.Name, column.ValueType);
            }

            foreach (DataGridViewRow row in dgvHD.SelectedRows)
            {
                DataRow dataRow = selectedData.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.OwningColumn.Name] = cell.Value;
                }
                selectedData.Rows.Add(dataRow);
            }

            hdctForm.ReceiveData(selectedData);
        }

    }
    
}
