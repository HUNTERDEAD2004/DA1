using AppData.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class HDCT : Form
    {
        SqlConnection conn = new SqlConnection("Server=PHUC\\SQLEXPRESS;Database=IphoneNhom1;Trusted_Connection=True;TrustServerCertificate=True");
        SqlDataAdapter sda;
        DataSet ds;
        // Đặt màu chữ cho toàn bộ form
        IphoneDbContext Context;

        public HDCT()
        {
            Context = new IphoneDbContext();
            InitializeComponent();
            // Tắt thuộc tính AllowUserToAddRows
            dgvHDC.AllowUserToAddRows = false;
            dgvHDTT.AllowUserToAddRows = false;
        }

        private void bttBack_Click(object sender, EventArgs e)
        {
            // Sự kiện bấm nút Back
        }

        public void ReceiveData(DataTable data)
        {
            // Xóa các cột cũ (nếu có) và thêm các cột từ DataTable
            dgvHDC.Columns.Clear();
            foreach (DataColumn column in data.Columns)
            {
                dgvHDC.Columns.Add(column.ColumnName, column.ColumnName);
            }

            // Thêm các hàng từ DataTable vào DataGridView
            foreach (DataRow row in data.Rows)
            {
                dgvHDC.Rows.Add(row.ItemArray);
            }

            try
            {
                Guid orderId = (Guid)data.Rows[0]["OrderID"];
                LoadOrderDetails(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn lại hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LoadOrderDetails(Guid orderId)
        {
            try
            {
                conn.Open();
                string query = @"
                SELECT od.OrderDetailID, od.OrderID, od.IMEI, od.ProductName, od.Quantity, od.UnitPrice, od.DiscountValue, od.CreatedAt, od.UpdatedAt, od.CreatedBy, od.UpdatedBy
                FROM OrderDetails od
                WHERE od.OrderID = @OrderID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Xóa các cột cũ (nếu có) và thêm các cột từ DataTable
                dgvHDTT.Columns.Clear();
                foreach (DataColumn column in dt.Columns)
                {
                    dgvHDTT.Columns.Add(column.ColumnName, column.ColumnName);
                }

                // Thêm các hàng từ DataTable vào DataGridView
                foreach (DataRow row in dt.Rows)
                {
                    dgvHDTT.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void HDCT_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
            if (key != null)
            {
                var tk = key.GetValue("Username").ToString();
                string query = "SELECT AccountID FROM Accounts WHERE Username = @Username";

               
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", tk);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string accountId = reader["AccountID"].ToString();
                        txtMNV.Text = accountId; // Gán AccountID vào TextBox
                    }
                    else
                    {
                        txtMNV.Text = "Không tìm thấy tài khoản";
                    }
                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                

                key.Close();
            }
        }


        private void ss_Click(object sender, EventArgs e)
        {
            // Sự kiện click khác
        }

        private void dgvHDC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHDC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvHDC.CurrentRow.Selected = true;
                    txtMHD.Text = dgvHDC.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                    txtSL.Text = dgvHDC.Rows[e.RowIndex].Cells["TotalAmount"].Value.ToString();
                    TxtTT.Text = dgvHDC.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                    VC();

                    decimal discount = Convert.ToDecimal(txtVCG.Text);
                    decimal price = decimal.Parse(TxtTT.Text);

                    decimal totalPrice = price * (1 - (discount / 100));

                    txtTTVC.Text = totalPrice.ToString("F2");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvHDTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sự kiện click trong dgvHDTT
        }

        private void RemoveFirstNineColumns()
        {
            if (dgvHDC.Columns.Count >= 9)
            {
                for (int i = 0; i <= 9; i++)
                {
                    dgvHDC.Columns.RemoveAt(0);
                }
            }
        }

        private void LoadDataHD(Guid orderId)
        {
            using (var context = new IphoneDbContext())
            {
                var order = context.Orders
                   .Where(o => o.OrderID == orderId)
                   .Select(u => new
                   {
                       u.OrderID,
                       u.AccountID,
                       u.CustomerID,
                       u.TotalAmount,
                       u.Price,
                       u.Status,
                       u.CreatedAt,
                       u.UpdatedAt,
                       u.UpdatedBy,
                       u.CreatedBy,
                   })
                   .ToList();

                dgvHDC.DataSource = order;


                // Xóa 9 cột đầu tiên
                RemoveFirstNineColumns();
            }
        }

        private void VC()
        {
            // Kiểm tra và xác định IDVoucher
            decimal totalAmount = decimal.Parse(TxtTT.Text);
            var vouchers = Context.Vouchers.OrderByDescending(v => v.Minium_Total).ToList();
            Guid selectedVoucherId = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"); // Mặc định
            decimal discountValue = 0m; // Mặc định giá trị Discount

            foreach (var voucher in vouchers)
            {
                if (totalAmount >= voucher.Minium_Total)
                {
                    selectedVoucherId = voucher.IDVoucher;
                    discountValue = voucher.Discount; // Lấy giá trị Discount
                    break;
                }
            }

            // Gán IDVoucher vào txtVC
            txtVC.Text = selectedVoucherId.ToString();

            // Gán Discount vào txtVCG
            txtVCG.Text = discountValue.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có hàng nào được chọn trong dgvHDC
                if (dgvHDC.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvHDC.SelectedRows[0];
                    var orderIdCell = selectedRow.Cells["OrderID"].Value;

                    // Kiểm tra giá trị OrderID có hợp lệ không
                    if (orderIdCell != null && Guid.TryParse(orderIdCell.ToString(), out Guid orderId))
                    {
                        string sdt = txtSDT.Text.Trim();
                        Guid? customerId = null;
                        //int totalPoints = int.Parse(txtSL.Text); // Số lượng của hóa đơn được sử dụng làm điểm cộng

                        using (var context = new IphoneDbContext())
                        {
                            // Xử lý số điện thoại khách hàng
                            if (!string.IsNullOrWhiteSpace(sdt))
                            {
                                var customer = context.Customers.FirstOrDefault(c => c.PhoneNumber == sdt);
                                if (customer == null)
                                {
                                    // Tạo mới khách hàng nếu không tồn tại
                                    customer = new Customer
                                    {
                                        CustomerID = Guid.NewGuid(),
                                        CustomerName = "Khách hàng ảo",
                                        Age = 0,
                                        Email = "fakeemail@example.com",
                                        PhoneNumber = sdt,
                                        Gender = "N/A",
                                        Point = 0, // Điểm khởi tạo bằng số lượng của hóa đơn
                                        Address = "abc",
                                        CreatedAt = DateTime.Now,
                                        UpdatedAt = DateTime.Now,
                                        CreatedBy = "system",
                                        UpdatedBy = "system"
                                    };
                                    context.Customers.Add(customer);
                                    context.SaveChanges();
                                }
                                else
                                {
                                    // Cộng điểm cho khách hàng hiện có
                                    customer.Point += 0;
                                    context.SaveChanges();
                                }
                                customerId = customer.CustomerID;
                            }

                            // Tạo câu lệnh SQL để cập nhật hóa đơn
                            string sql = @"
                    UPDATE Orders
                    SET 
                        Status = 1,
                        CustomerID = @CustomerID,
                        AccountID = @AccountID,
                        IDVoucher = @IDVoucher,
                        Price = @Price,
                        TotalAmount = @TotalAmount,
                        UpdatedAt = @UpdatedAt,
                        UpdatedBy = @UpdatedBy
                    WHERE OrderID = @OrderID";

                            using (SqlConnection conn = new SqlConnection("Server=PHUC\\SQLEXPRESS;Database=IphoneNhom1;Trusted_Connection=True;TrustServerCertificate=True"))
                            {
                                SqlCommand cmd = new SqlCommand(sql, conn);
                                cmd.Parameters.AddWithValue("@OrderID", orderId);
                                cmd.Parameters.AddWithValue("@CustomerID", (object)customerId ?? DBNull.Value);
                                cmd.Parameters.AddWithValue("@AccountID", txtMNV.Text);
                                cmd.Parameters.AddWithValue("@IDVoucher", txtVC.Text);
                                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtTTVC.Text));
                                cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(txtSL.Text));
                                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                                cmd.Parameters.AddWithValue("@UpdatedBy", "system");

                                if (conn.State == ConnectionState.Closed)
                                {
                                    conn.Open();
                                }

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (conn.State == ConnectionState.Open)
                                {
                                    conn.Close();
                                }

                                if (rowsAffected > 0)
                                {
                                    // Load lại dữ liệu hóa đơn cụ thể
                                    LoadDataHD(orderId);
                                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy hóa đơn với OrderID: " + orderId, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("OrderID không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thanh toán thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
