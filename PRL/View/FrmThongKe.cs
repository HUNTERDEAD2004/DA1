using AppData.Models;
using System;
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
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            cmbTime.Items.AddRange(new string[] { "Hôm nay", "7 ngày trước", "30 ngày trước", "Tùy chỉnh" });
            cmbTime.SelectedIndex = 0; // Đặt mặc định là "Hôm nay"
            dateTimeStart.Visible = false;
            dateTimeEnd.Visible = false;
            //Tiếng việt
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "dd/MM/yyyy";
            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = "dd/MM/yyyy";
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCustomRange = cmbTime.SelectedItem.ToString() == "Tùy chỉnh";
            dateTimeStart.Visible = isCustomRange;
            dateTimeEnd.Visible = isCustomRange;
        }

        private void btn_thongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate, endDate;

            switch (cmbTime.SelectedItem.ToString())
            {
                case "Hôm nay":
                    startDate = DateTime.Today;
                    endDate = DateTime.Today;
                    break;
                case "7 ngày trước":
                    startDate = DateTime.Now.AddDays(-7);
                    endDate = DateTime.Now;
                    break;
                case "30 ngày trước":
                    startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
                    endDate = startDate.AddMonths(1).AddDays(-1);
                    break;
                case "Khoảng thời gian tùy chỉnh":
                    startDate = dateTimeStart.Value;
                    endDate = dateTimeEnd.Value;
                    break;
                default:
                    return;
                 }
            }            
        }
}
