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

        public IMEIForm()
        {
            InitializeComponent();
            dgvImei.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvImei_RowPostPaint);
        }

        private void dgvImei_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
            // Kiểm tra nhập chưa
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

            
                this.DialogResult = DialogResult.OK;
                this.Close();
            
        }

        private void dgvImei_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Vẽ số thứ tự
            using (SolidBrush b = new SolidBrush(dgvImei.RowHeadersDefaultCellStyle.ForeColor))
            {
                string stt = (e.RowIndex + 1).ToString();
                e.Graphics.DrawString(stt, dgvImei.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 4);
            }
        }

        private void IMEIForm_Load(object sender, EventArgs e)
        {
            // Gắn sự kiện RowPostPaint cho DataGridView
            dgvImei.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvImei_RowPostPaint);
        }

    }
}
