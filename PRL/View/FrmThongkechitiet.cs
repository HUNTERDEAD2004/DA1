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
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Colors;
using iText.Layout.Borders;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font;
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
                                    join pd in _context.ProductDetails on od.ProductDetailID equals pd.ProductDetailID
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
                    using (var writer = new PdfWriter(saveFileDialog.FileName))
                    {
                        using (var pdf = new PdfDocument(writer))
                        {
                            var document = new Document(pdf);

                            // Sử dụng font Arial từ tệp TTF
                            var pathToFont = "C:/Windows/Fonts/arial.ttf";
                            PdfFont font = PdfFontFactory.CreateFont(pathToFont, PdfEncodings.IDENTITY_H);
                            document.SetFont(font);

                            // Thêm tiêu đề chính
                            var title = new Paragraph("Chi tiết hóa đơn")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetFontSize(24)
                                .SetBold();
                            document.Add(title);

                            // Thêm tiêu đề phụ
                            var subTitle = new Paragraph("IPhoneStore")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetFontSize(18)
                                .SetFontColor(ColorConstants.BLUE)
                                .SetBold();
                            document.Add(subTitle);

                            // Thêm thông tin hóa đơn từ DataGridView
                            var orderID = "Mã Hóa Đơn: " + label10.Text;
                            var employeeName = "Nhân viên: " + label8.Text;
                            var orderInfo = new Paragraph($"{orderID}\n{employeeName}")
                                .SetTextAlignment(TextAlignment.RIGHT)
                                .SetFontSize(12);
                            document.Add(orderInfo);

                            // Thêm thông tin khách hàng từ DataGridView
                            var customerInfo = new Paragraph($"Thông Tin Khách Hàng\nHọ và Tên: {lb_name.Text}\nĐịa Chỉ: {lb_dc.Text}\nPhone: {lb_sdt.Text}\nNgày mua: {lb_date.Text}")
                                .SetTextAlignment(TextAlignment.LEFT)
                                .SetFontSize(12)
                                .SetMarginTop(20);
                            document.Add(customerInfo);

                            // Thêm khoảng trống
                            document.Add(new Paragraph("\n"));

                            // Tạo bảng từ DataGridView
                            var table = new Table(dataGridView1.Columns.Count)
                                .UseAllAvailableWidth();

                            // Thêm tiêu đề bảng
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetBold());
                            }

                            // Thêm dữ liệu vào bảng từ DataGridView
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                                    }
                                }
                            }

                            document.Add(table);

                            // Thêm thông tin tổng tiền từ DataGridView
                            var totalQuantity = "Tổng số lượng: " + label12.Text;
                            var totalAmount = "Tổng Tiền: " + label14.Text;
                            var totalInfo = new Paragraph($"{totalQuantity}\n{totalAmount}")
                                .SetTextAlignment(TextAlignment.RIGHT)
                                .SetFontSize(12)
                                .SetMarginTop(20);
                            document.Add(totalInfo);

                            // Thêm khoảng trống
                            document.Add(new Paragraph("\n"));

                            // Thêm nút "In Hóa Đơn"
                            var printButton = new Paragraph("In Hóa Đơn")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetFontSize(16)
                                .SetBold()
                                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                                .SetFontColor(ColorConstants.BLACK)
                                .SetBorder(new SolidBorder(1));
                            document.Add(printButton);
                        }
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
