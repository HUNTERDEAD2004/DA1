using AppData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace PRL.View
{
    public partial class ReportFrm : Form
    {
        IphoneDbContext context;
        public ReportFrm()
        {
            InitializeComponent();
            context = new IphoneDbContext();    
            panel1.Dock = DockStyle.Fill;
            label1.Anchor = AnchorStyles.Top;
            dgvData.Anchor = AnchorStyles.Top;
            LoadReportData();
            LoadReport();
        }
        private void LoadReportData()
        {
            DateTime today = DateTime.Now.Date;

            var salesData = context.OrderDetails
                                   .Where(od => od.Order.CreatedAt.Date == today)
                                   .GroupBy(od => new
                                   {
                                       od.ProductName,
                                       od.ProductDetail.importPrice,
                                       od.ProductDetail.Quantity
                                   })
                                   .Select(g => new
                                   {
                                       ProductName = g.Key.ProductName,
                                       QuantitySold = g.Sum(od => od.Quantity),
                                       TotalSalesAmount = g.Sum(od => od.Quantity * (od.UnitPrice - od.DiscountValue)),
                                       TotalCostAmount = g.Sum(od => od.Quantity * g.Key.importPrice    ),
                                       StockQuantity = g.Key.Quantity
                                   })
                                   .ToList();

            if (salesData.Count > 0)
            {
                var reportTable = new DataTable();
                reportTable.Columns.Add("Name", typeof(string));
                reportTable.Columns.Add("Quantity Sold", typeof(int));
                reportTable.Columns.Add("Total Money", typeof(decimal));
                reportTable.Columns.Add("Total Profit", typeof(decimal));
                reportTable.Columns.Add("Quantity Left", typeof(int));

                foreach (var item in salesData)
                {
                    var totalProfit = item.TotalSalesAmount - item.TotalCostAmount;
                    reportTable.Rows.Add(item.ProductName, item.QuantitySold, item.TotalSalesAmount, totalProfit, item.StockQuantity);
                }
                dgvData.DataSource = reportTable;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào được bán trong ngày hôm nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Export(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var dataSheet = workbook.Worksheets.Add("Data Report");
                    for (int i = 1; i <= dgvData.Columns.Count; i++)
                    {
                        dataSheet.Cell(1, i).Value = dgvData.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvData.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvData.Columns.Count; j++)
                        {
                            dataSheet.Cell(i + 2, j + 1).Value = dgvData.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                        }
                    }

                    var hdSheet = workbook.Worksheets.Add("HD Report");
                    for (int i = 1; i <= dgvHD.Columns.Count; i++)
                    {
                        hdSheet.Cell(1, i).Value = dgvHD.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvHD.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvHD.Columns.Count; j++)
                        {
                            hdSheet.Cell(i + 2, j + 1).Value = dgvHD.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                        }
                    }

                    workbook.SaveAs(filePath);  
                }

                MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.Title = "Save Report as Excel File";
                sfd.FileName = "Report.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    Export(filePath);
                }
            }
        }
        private void LoadReport()
        {
            DateTime today = DateTime.Now.Date;

            var orders = context.Orders
                                .Where(o => o.CreatedAt.Date == today)
                                .Select(o => new
                                {
                                    OrderID = o.OrderID,
                                    OrderDate = o.CreatedAt,
                                    TotalAmount = o.TotalAmount,
                                    Status = o.Status == 0 ? "Chưa thanh toán" : "Đã thanh toán",
                                    CustomerName = o.Customer.CustomerName // Giả sử bạn có một thuộc tính tên khách hàng
                                })
                                .ToList();

            if (orders.Count > 0)
            {
                // Tạo DataTable để dùng làm nguồn dữ liệu cho DataGridView
                var reportTable = new DataTable();
                reportTable.Columns.Add("Order ID", typeof(Guid));
                reportTable.Columns.Add("Order Date", typeof(DateTime));
                reportTable.Columns.Add("Total Amount", typeof(decimal));
                reportTable.Columns.Add("Status", typeof(string));
                reportTable.Columns.Add("Customer Name", typeof(string)); // Thêm cột tên khách hàng nếu cần

                // Thêm dữ liệu vào DataTable
                foreach (var order in orders)
                {
                    reportTable.Rows.Add(order.OrderID, order.OrderDate, order.TotalAmount, order.Status, order.CustomerName);
                }

                // Cập nhật DataGridView với DataTable
                dgvHD.DataSource = reportTable;
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào trong ngày hôm nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
