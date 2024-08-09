using AppData.Models;
using DAL.Models;
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
    public partial class IMEIForm : Form
    {
        public List<string> ImeiList { get; private set; } = new List<string>();
        private int requiredCount;
        public IMEIForm(int requiredCount)
        {
            InitializeComponent();
        }

        private void dgvImei_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu cột được nhấp vào là cột "Delete"
            if (e.ColumnIndex == dgvImei.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Xóa dòng tương ứng
                dgvImei.Rows.RemoveAt(e.RowIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void txtOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có dòng nào trong DataGridView hoặc tất cả các dòng đều trống
            bool hasImei = false;

            foreach (DataGridViewRow row in dgvImei.Rows)
            {
                if (row.Cells["Imei"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Imei"].Value.ToString()))
                {
                    string imei = row.Cells["Imei"].Value.ToString();
                    if (imei.Length == 15)
                    {
                        ImeiList.Add(imei);
                        hasImei = true; // Đánh dấu rằng có ít nhất một IMEI được nhập
                    }
                    else
                    {
                        MessageBox.Show("IMEI phải có đúng 15 số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (!hasImei)
            {
                MessageBox.Show("Bạn cần nhập ít nhất một IMEI trước khi nhấn OK.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ImeiList.Count >= requiredCount)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show($"Bạn cần nhập đủ {requiredCount} IMEI.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IMEIForm_Load(object sender, EventArgs e)
        {

        }
    }
}
