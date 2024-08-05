using AppData.Models;
using ClosedXML.Excel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class FrmThongKe : Form
    {
        private IphoneDbContext _context;
        public FrmThongKe()
        {
            InitializeComponent();
            _context = new IphoneDbContext();
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            dtgv_show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgv_show.Left = (this.ClientSize.Width - dtgv_show.Width) / 2;  // Căn giữa theo chiều ngang
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            cmbTime.Items.AddRange(new string[] { "Hôm nay", "7 ngày trước", "30 ngày trước", "Tùy chỉnh", "Tất cả" });
            cmbTime.SelectedIndex = 0; // Đặt mặc định là "Hôm nay"
            dateTimeStart.Visible = false;
            dateTimeEnd.Visible = false;
            //Tiếng việt
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "dd/MM/yyyy";
            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = "dd/MM/yyyy";
            dtgv_show.Dock = DockStyle.Fill;
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCustomRange = cmbTime.SelectedItem.ToString() == "Tùy chỉnh";
            dateTimeStart.Visible = isCustomRange;
            dateTimeEnd.Visible = isCustomRange;
        }

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Define the start and end dates based on the selected time range
            DateTime startDate, endDate;

            switch (cmbTime.SelectedItem.ToString())
            {
                case "Hôm nay":
                    startDate = DateTime.Today;
                    endDate = dateTimeEnd.Value.Date.AddDays(1).AddTicks(-1);
                    break;
                case "7 ngày trước":
                    startDate = DateTime.Now.AddDays(-7);
                    endDate = DateTime.Now;
                    break;
                case "30 ngày trước":
                    startDate = DateTime.Now.AddDays(-30);
                    endDate = DateTime.Now;
                    break;
                case "Tùy chỉnh":
                    startDate = dateTimeStart.Value.Date;
                    endDate = dateTimeEnd.Value.Date.AddDays(1).AddTicks(-1); // End of the day
                    break;
                case "Tất cả":
                    startDate = DateTime.MinValue;
                    endDate = DateTime.MaxValue;
                    break;
                default:
                    // Default case should ideally not occur
                    return;
            }

            // Perform LINQ query to fetch data
            var data = from od in _context.Orders
                       join kh in _context.Customers on od.CustomerID equals kh.CustomerID
                       join ac in _context.Accounts on od.AccountID equals ac.AccountID
                       join vc in _context.Vouchers on od.IDVoucher equals vc.IDVoucher
                       where od.CreatedAt >= startDate && od.CreatedAt <= endDate
                       select new
                       {
                           od.OrderID, // Thêm OrderID để sử dụng cho việc xem chi tiết
                           kh.CustomerName,
                           kh.PhoneNumber,
                           od.Price,
                           od.TotalAmount,
                           vc.Discount,
                           Status = od.Status == 1 ? "Đã thanh toán" : "Chưa thanh toán",
                           CreatedAt = od.CreatedAt.ToString("dd/MM/yyyy"),
                           ac.Name
                       };

            // Bind data to DataGridView
            dtgv_show.DataSource = data.ToList();

            // Đặt tên cột hiển thị trong DataGridView để dễ đọc
            dtgv_show.Columns["OrderID"].HeaderText = "Mã Hóa Đơn";
            dtgv_show.Columns["Discount"].HeaderText = "Voucher";
            

            int tongHD = 0;
            int hoadondathanhtoan = 0;
            decimal doanhthu = 0;
            foreach (DataGridViewRow row in dtgv_show.Rows)
            {
                if (row.Cells["Price"].Value != null && row.Cells["Status"].Value != null)
                {
                    if (row.Cells["Price"].Value != null)
                    {
                        if (row.Cells["Status"].Value != null && row.Cells["Status"].Value.ToString() == "Đã thanh toán")
                        {
                            doanhthu += Convert.ToDecimal(row.Cells["Price"].Value);
                            hoadondathanhtoan++;
                        }
                        tongHD++;
                    }
                }
            }
            lb_tonghd.Text = tongHD.ToString();
            lb_doanhthu.Text = doanhthu.ToString();
            lb_hdtt.Text = hoadondathanhtoan.ToString();
        }


        private void btn_xuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new DataTable and fill it with the DataGridView data
                DataTable dataTable = new DataTable();
                foreach (DataGridViewColumn column in dtgv_show.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }

                foreach (DataGridViewRow row in dtgv_show.Rows)
                {
                    if (row.IsNewRow) continue;
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                // Create a new Excel workbook and worksheet
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Load data into the worksheet
                    worksheet.Cell(1, 1).InsertTable(dataTable);

                    // Save the workbook to a file
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        FileName = "DataExport.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng trong DataGridView chưa
            if (dtgv_show.SelectedRows.Count > 0)
            {
                // Lấy thông tin của hàng được chọn
                DataGridViewRow selectedRow = dtgv_show.SelectedRows[0];
                Guid orderID = (Guid)selectedRow.Cells["orderID"].Value; // Chuyển đổi từ object sang Guid

                // Mở form chi tiết hóa đơn và truyền thông tin hóa đơn
                FrmThongkechitiet frmChiTiet = new FrmThongkechitiet(orderID);
                frmChiTiet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
