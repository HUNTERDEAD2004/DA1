using AppData.Models;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace PRL.View
{
    public partial class FrmThongkechitiet : Form
    {
        private Guid _orderID;
        private IphoneDbContext _context;
        private DataTable dataTable;

        public FrmThongkechitiet(Guid orderID)
        {
            InitializeComponent();
            _orderID = orderID;
            _context = new IphoneDbContext();
            LoadOrderDetails();
            LoadData();
        }

        private void LoadOrderDetails()
        {
            try
            {
                //  lấy chi tiết hóa đơn với các bảng kết nối
                var orderDetails = (from od in _context.OrderDetails
                                    join pd in _context.ProductDetails on od.IMEI equals pd.IMEI
                                    join sl in _context.Sales on pd.SaleID equals sl.SaleID
                                    where od.OrderID == _orderID
                                    select new
                                    {
                                        ProductName = pd.Name,
                                        Quantity = od.Quantity,
                                        UnitPrice = od.UnitPrice,
                                        DiscountValue = sl.DiscountValue
                                    }).ToList();

                
                if (orderDetails.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho hóa đơn này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Tạo và điền DataTable
                dataTable = new DataTable();
                dataTable.Columns.Add("STT", typeof(int));
                dataTable.Columns.Add("ProductName");
                dataTable.Columns.Add("Quantity", typeof(int));
                dataTable.Columns.Add("DiscountValue", typeof(decimal));
                dataTable.Columns.Add("UnitPrice", typeof(decimal));

                // Điền dữ liệu vào DataTable
                int index = 1; // Bắt đầu số thứ tự từ 1
                foreach (var detail in orderDetails)
                {
                    dataTable.Rows.Add(index++, detail.ProductName, detail.Quantity, detail.DiscountValue, detail.UnitPrice);
                }

                // Gán dữ liệu vào DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            // Thông tin hóa đơn
            var order = _context.Orders.FirstOrDefault(o => o.OrderID == _orderID);
            label12.Text = order.TotalAmount.ToString();
            label14.Text = order.Price.ToString();
            var employee = _context.Accounts.FirstOrDefault(e => e.AccountID == order.AccountID);
            label8.Text = employee.Name;
            label10.Text = order.OrderID.ToString();
            lb_date.Text = order.CreatedAt.ToString("dd/MM/yyyy");

            // Thông tin khách hàng
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerID == order.CustomerID);
            lb_name.Text = customer.CustomerName;
            lb_dc.Text = customer.Address.ToString();
            lb_sdt.Text = customer.PhoneNumber.ToString();
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo tên tệp PDF
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    FileName = "Invoice_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new MemoryStream())
                    {
                        using (var writer = new PdfWriter(stream))
                        {
                            using (var pdf = new PdfDocument(writer))
                            {
                                var document = new Document(pdf);

                                // Thêm tiêu đề
                                document.Add(new Paragraph("Hóa Đơn").SetFontSize(20).SetBold());

                                // Thêm ngày in hóa đơn
                                document.Add(new Paragraph("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy")));

                                // Tạo bảng từ DataTable
                                var table = new Table(dataTable.Columns.Count);
                                foreach (DataColumn column in dataTable.Columns)
                                {
                                    table.AddHeaderCell(column.ColumnName);
                                }

                                foreach (DataRow row in dataTable.Rows)
                                {
                                    foreach (var cell in row.ItemArray)
                                    {
                                        table.AddCell(cell.ToString());
                                    }
                                }

                                document.Add(table);
                            }
                        }

                        // Lưu tệp PDF
                        File.WriteAllBytes(saveFileDialog.FileName, stream.ToArray());
                    }

                    MessageBox.Show("Hóa đơn đã được lưu dưới dạng PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi lưu hóa đơn: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
