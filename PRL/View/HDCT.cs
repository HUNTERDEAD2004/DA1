using DAL.Models;
using Microsoft.Data.SqlClient;
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
    public partial class HDCT : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=AppleStore4;Trusted_Connection=True;TrustServerCertificate=True");
        SqlDataAdapter sda;
        DataSet ds;
        // Đặt màu chữ cho toàn bộ form
        AppDbContext Context;

        public HDCT()
        {
            Context = new AppDbContext();
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

            Guid orderId = (Guid)data.Rows[0]["OderID"];
            LoadOrderDetails(orderId);
        }

        private void LoadOrderDetails(Guid orderId)
        {
            try
            {
                conn.Open();
                string query = @"
                SELECT od.OrderDetailsID, od.ProductId, od.OderID, od.Quantity, od.IMEI, od.NameSPCT, od.Price, od.PercentDiscount, od.CreateAt, od.UpdateAt, od.CreateBy, od.UpdateBy
                FROM oderDetails od
                WHERE od.OderID = @OrderID";

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
            // Sự kiện load form
        }

        private void ss_Click(object sender, EventArgs e)
        {
            // Sự kiện click khác
        }

        private void dgvHDC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHDC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvHDC.CurrentRow.Selected = true;
                txtSL.Text = dgvHDC.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                txtTT.Text = dgvHDC.Rows[e.RowIndex].Cells["TotalPrice"].Value.ToString();
                txtSL.Text = "1";

                // Chuyển đổi txtSZ.Text và txtGia.Text thành số
                decimal discount = Convert.ToDecimal(txtTT.Text);
                int quantity = Convert.ToInt32(txtSL.Text);
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
            using (var context = new AppDbContext())
            {
                var order = context.Oders
                    .Where(o => o.OderID == orderId)
                    .Select(u => new
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
                    })
                    .ToList();

                dgvHDC.DataSource = order;

                // Xóa 9 cột đầu tiên
                RemoveFirstNineColumns();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy OrderID từ hàng được chọn trong dgvHD
                if (dgvHDC.SelectedRows.Count > 0)
                {
                    Guid orderId = (Guid)dgvHDC.SelectedRows[0].Cells["OderID"].Value;
                    string sdt = txtSDT.Text.Trim();
                    Guid? customerId = null;

                    using (var context = new AppDbContext())
                    {
                        // Xử lý số điện thoại khách hàng
                        if (!string.IsNullOrWhiteSpace(sdt))
                        {
                            var customer = context.customers.FirstOrDefault(c => c.Number == sdt);
                            if (customer == null)
                            {
                                // Tạo mới khách hàng nếu không tồn tại
                                customer = new Customer
                                {
                                    CustomerID = Guid.NewGuid(),
                                    Name = "Khách hàng ảo",
                                    Age = 0,
                                    Email = "fakeemail@example.com",
                                    Number = sdt,
                                    Gender = "N/A",
                                    Point = 0,
                                    Status = 1,
                                    CreateAt = DateTime.Now,
                                    UpdateAt = DateTime.Now,
                                    CreateBy = "system",
                                    UpdateBy = "system"
                                };
                                context.customers.Add(customer);
                                context.SaveChanges();
                            }
                            customerId = customer.CustomerID;
                        }

                        // Cập nhật hóa đơn
                        var order = context.Oders.FirstOrDefault(o => o.OderID == orderId);
                        if (order != null)
                        {
                            order.Status = 1;
                            order.CustomerID = customerId;
                            order.UpdateAt = DateTime.Now;
                            order.UpdateBy = "system";
                            context.SaveChanges();
                        }

                        // Load lại dữ liệu hóa đơn cụ thể
                        LoadDataHD(orderId);
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thanh toán thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
