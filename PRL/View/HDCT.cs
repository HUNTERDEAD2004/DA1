using AppData.Models;
using DocumentFormat.OpenXml.Wordprocessing;
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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRL.View
{
    public partial class HDCT : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=IphoneDB5;Trusted_Connection=True;TrustServerCertificate=True");
        SqlDataAdapter sda;
        DataSet ds;
        IphoneDbContext Context;

        public HDCT()
        {
            Context = new IphoneDbContext();
            InitializeComponent();
            // Tắt thêm hàng
            dgvHDC.AllowUserToAddRows = false;
            dgvHDTT.AllowUserToAddRows = false;
            txtKT.Leave += new EventHandler(txtKT_Leave);
            txtKT.Leave += new EventHandler(richTextBox1_TextChanged);


        }

        private void bttBack_Click(object sender, EventArgs e)
        {
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

                // Lấy CustomerName từ DataTable
                string customerName = data.Rows[0]["CustomerName"].ToString();            
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
                string tk = key.GetValue("Username").ToString();
                string query = "SELECT AccountID FROM Accounts WHERE Username = @Username";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", tk);
                txtMNV.Text = tk;


                key.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khóa Registry", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void ss_Click(object sender, EventArgs e)
        {
        }

        private void dgvHDC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHDC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvHDC.CurrentRow.Selected = true;
                    txtMHD.Text = dgvHDC.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                    txtSL.Text = dgvHDC.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                    TxtTT.Text = dgvHDC.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                    txtKT.Text = txtTTVC.Text;
                    txtKH.Text = dgvHDC.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                    VC();

                    string customerName = dgvHDC.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();

                    // Truy vấn Point từ bảng Customers dựa trên CustomerName
                    using (var context = new IphoneDbContext())
                    {
                        var customer = context.Customers.FirstOrDefault(c => c.CustomerName == customerName);
                        if (customer != null)
                        {
                            int customerPoints = customer.Point;
                            txtDiem.Text = customerPoints.ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy khách hàng: {customerName}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    decimal discount = Convert.ToDecimal(txtVCG.Text);
                    decimal price = decimal.Parse(TxtTT.Text);

                    decimal totalPrice = price * (1 - (discount / 100));

                    txtTTVC.Text = totalPrice.ToString("F2");
                    originalTotalPrice = decimal.Parse(txtTTVC.Text);
                    // Gọi sự kiện CheckedChanged để tính lại tổng tiền nếu checkbox được chọn
                    CBSD_CheckedChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHDTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

                dgvHDC.Columns["AccountID"].DisplayIndex = 0;
                dgvHDC.Columns["CustomerID"].DisplayIndex = 1;
                dgvHDC.Columns["TotalAmount"].DisplayIndex = 2;
                dgvHDC.Columns["Price"].DisplayIndex = 3;
                dgvHDC.Columns["Status"].DisplayIndex = 4;
                // Xóa 9 cột đầu tiên
                //RemoveFirstNineColumns();
            }
        }

        private void VC()
        {
            // Kiểm tra và xác định IDVoucher
            decimal totalAmount = decimal.Parse(TxtTT.Text);
            var vouchers = Context.Vouchers.OrderByDescending(v => v.Minium_Total).ToList();
            Guid selectedVoucherId = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"); // Mặc định voucher ảo
            decimal discountValue = 0; // Mặc định Discount 

            foreach (var voucher in vouchers)
            {
                if (totalAmount >= voucher.Minium_Total)
                {
                    var Ma = voucher.IDVoucher;
                    txtMVC.Text = Ma.ToString();

                    var Mini = voucher.Minium_Total;
                    txtVC.Text = Mini.ToString();
                    discountValue = voucher.Discount;
                    break;
                }
            }

            // Gán IDVoucher vào txtVC
            //txtVC.Text = selectedVoucherId.ToString();


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
                    var reportIdCell = selectedRow.Cells["ReportID"].Value;

                    // Kiểm tra giá trị OrderID có hợp lệ không
                    if (orderIdCell != null && Guid.TryParse(orderIdCell.ToString(), out Guid orderId) &&
                        reportIdCell != null && Guid.TryParse(reportIdCell.ToString(), out Guid reportId))
                    {
                        // Hiển thị thông báo xác nhận trước khi thanh toán
                        var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thanh toán hóa đơn này không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmResult == DialogResult.Yes)
                        {
                            Guid? customerId = null;
                            decimal price = decimal.Parse(txtTTVC.Text);
                            int quantity = int.Parse(txtSL.Text);
                            int pointsToDeduct = 0;

                            using (var context = new IphoneDbContext())
                            {
                                // Lấy CustomerID từ txtKH
                                string customerInfo = txtKH.Text.Trim();
                                var customer = context.Customers.FirstOrDefault(c => c.CustomerName == customerInfo || c.PhoneNumber == customerInfo);
                                if (customer != null)
                                {
                                    customerId = customer.CustomerID;

                                    // Nếu người dùng chọn sử dụng điểm, trừ đi toàn bộ số điểm
                                    if (CBSD.Checked)
                                    {
                                        pointsToDeduct = customer.Point; // Giả sử 'Points' là thuộc tính chứa số điểm của khách hàng
                                        customer.Point = 0; // Trừ hết điểm của khách hàng
                                        context.SaveChanges(); // Lưu thay đổi
                                    }
                                }

                                // Lấy AccountID từ Username
                                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
                                string accountIdString = null;
                                string usernameAC = null;
                                if (key != null)
                                {
                                    string username = key.GetValue("Username").ToString();
                                    var account = context.Accounts.FirstOrDefault(a => a.Username == username);
                                    if (account != null)
                                    {
                                        accountIdString = account.AccountID.ToString();
                                        usernameAC = account.Username.ToString();
                                    }
                                    key.Close();
                                }

                                // lệnh SQL để cập nhật hóa đơn
                                string sql = @"
                        UPDATE Orders
                        SET 
                            Status = 1,
                            AccountID = @AccountID,
                            IDVoucher = @IDVoucher,
                            Price = @Price,
                            Note = @Note,
                            TotalAmount = @TotalAmount,
                            UpdatedAt = @UpdatedAt,
                            UpdatedBy = @UpdatedBy,
                            CustomerID = @CustomerID
                        WHERE OrderID = @OrderID";

                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@OrderID", orderId);

                                    // Kiểm tra và chuyển đổi AccountID
                                    if (Guid.TryParse(accountIdString, out Guid accountId))
                                    {
                                        cmd.Parameters.AddWithValue("@AccountID", accountId);
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@AccountID", DBNull.Value);
                                    }

                                    if (Guid.TryParse(txtMVC.Text, out Guid voucherId))
                                    {
                                        cmd.Parameters.AddWithValue("@IDVoucher", voucherId);
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@IDVoucher", DBNull.Value);
                                    }

                                    cmd.Parameters.AddWithValue("@Price", price);
                                    cmd.Parameters.AddWithValue("@TotalAmount", quantity);
                                    cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                                    cmd.Parameters.AddWithValue("@UpdatedBy", "system");
                                    cmd.Parameters.AddWithValue("@Note", richTextBox1.Text);

                                    // Kiểm tra và chuyển đổi CustomerID
                                    if (customerId.HasValue)
                                    {
                                        cmd.Parameters.AddWithValue("@CustomerID", customerId.Value);
                                    }
                                    else
                                    {
                                        cmd.Parameters.AddWithValue("@CustomerID", DBNull.Value);
                                    }

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
                                        // Cập nhật báo cáo
                                        var report = context.Reports.FirstOrDefault(r => r.ReportID == reportId);
                                        if (report != null)
                                        {
                                            report.TotalSold += quantity;
                                            report.TotalAmount += price;
                                            report.SuccessfulOrders += 1;
                                            report.UpdatedAt = DateTime.Now;
                                            report.UpdatedBy = "system";
                                            context.SaveChanges();
                                        }

                                        var acc = new DAL.Models.Activity
                                        {
                                            Note = $"{usernameAC} Đã thanh toán Hóa đơn {orderId} với {pointsToDeduct} điểm, vào lúc {DateTime.Now}",
                                            CreatedAt = DateTime.Now,
                                            UpdatedAt = DateTime.Now,
                                            CreatedBy = usernameAC,
                                            UpdatedBy = usernameAC
                                        };

                                        context.Activities.Add(acc);
                                        context.SaveChanges();

                                        // Load lại dữ liệu hóa đơn cụ thể
                                        //LoadDataHD(orderId);

                                        dgvHDC.DataSource = null;
                                        dgvHDTT.DataSource = null;
                                        txtMHD.Text = "";
                                        txtMVC.Text = "";
                                        txtMNV.Text = "";
                                        txtSL.Text = "";
                                        TxtTT.Text = "";
                                        txtVC.Text = "";
                                        txtVCG.Text = "";
                                        txtTTVC.Text = "";
                                        txtKT.Text = "";
                                        txtTL.Text = "";
                                        richTextBox1.Text = "";
                                        this.Close();
                                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không tìm thấy hóa đơn với OrderID: " + orderId, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("OrderID hoặc ReportID không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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







        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
        }

        private void TinhTienTraLai()
        {
            decimal tongtien = decimal.TryParse(txtTTVC.Text, out tongtien) ? tongtien : 0;
            decimal tienKhachDua = decimal.TryParse(txtKT.Text, out tienKhachDua) ? tienKhachDua : 0;

            if (decimal.Parse(txtKT.Text) < decimal.Parse(txtTTVC.Text))
            {
                MessageBox.Show("Khách trả chưa Đủ. Không Cho Nợ OK.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal tienTraLai = tienKhachDua - tongtien;
                txtTL.Text = tienTraLai.ToString();
            }
        }

        private void txtKT_Leave(object sender, EventArgs e)
        {
            TinhTienTraLai();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateRichTextBox();
        }

        private void UpdateRichTextBox()
        {
            int customerPoints = int.Parse(txtDiem.Text);
            int giam = customerPoints * 1000;
            if (CBSD.Checked)
            {
                richTextBox1.Text = $"Tổng tiền = {txtTTVC.Text}," +
                    $"\nKhách trả = {txtKT.Text},\nTiền trả lại = {txtTL.Text}," +
                    $"\nKhách có sử dụng điểm: {txtDiem.Text} Điểm," +
                    $"\nGiảm: {giam}";
            }
            else
            {
                richTextBox1.Text = $"Tổng tiền = {txtTTVC.Text},\nKhách trả = {txtKT.Text},\nTiền trả lại = {txtTL.Text}";

            }
        }

        private decimal originalTotalPrice; 

        private void CBSD_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBSD.Checked)
                {
                    if (originalTotalPrice == 0)
                    {
                        originalTotalPrice = decimal.Parse(txtTTVC.Text);
                    }

                    int customerPoints = int.Parse(txtDiem.Text); 

                    decimal pointsDiscount = customerPoints * 1000;

                    decimal discountedPrice = originalTotalPrice - pointsDiscount;
                    txtTTVC.Text = discountedPrice.ToString("F2");
                    txtKT.Text = txtTTVC.Text;
                }
                else
                {
                    txtTTVC.Text = originalTotalPrice.ToString("F2");
                    txtKT.Text = txtTTVC.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
