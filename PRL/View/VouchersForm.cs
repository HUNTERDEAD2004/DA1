using AppData.Models;
using DAL.Models;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class VouchersForm : Form
    {
        IphoneDbContext context;

        public VouchersForm()
        {
            context = new IphoneDbContext();
            InitializeComponent();
        }

        private void LoadData()
        {
            // Xóa các voucher hết hạn 
            RemoveExpiredVouchers();
            var vouchers = context.Vouchers.ToList();
            dgvVC.DataSource = vouchers;
        }

        private void RemoveExpiredVouchers()
        {
            // Tìm các voucher đã hết hạn
            var expiredVouchers = context.Vouchers.Where(v => v.Expired_Date < DateTime.Now).ToList();

            foreach (var voucher in expiredVouchers)
            {
                voucher.Discount = 0;
                voucher.Minium_Total = int.MaxValue; 
            }

            if (expiredVouchers.Count > 0)
            {
                context.SaveChanges();
            }
        }


        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các điều kiện
                if (!ValidateInputs()) return;

                var newVoucher = new Voucher
                {
                    IDVoucher = Guid.NewGuid(),
                    Discount = decimal.Parse(txtDis.Text),
                    Expired_Date = dtpED.Value,
                    Minium_Total = decimal.Parse(txtMin.Text),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "Admin",
                    UpdatedBy = "Admin"
                };

                context.Vouchers.Add(newVoucher);
                context.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm voucher thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVC.SelectedRows.Count > 0)
                {
                    // Kiểm tra các điều kiện
                    if (!ValidateInputs()) return;

                    var selectedVoucherId = (Guid)dgvVC.SelectedRows[0].Cells["IDVoucher"].Value;
                    var voucher = context.Vouchers.FirstOrDefault(v => v.IDVoucher == selectedVoucherId);

                    if (voucher != null)
                    {
                        voucher.Discount = decimal.Parse(txtDis.Text);
                        voucher.Expired_Date = dtpED.Value;
                        voucher.Minium_Total = decimal.Parse(txtMin.Text);
                        voucher.UpdatedAt = DateTime.Now;
                        voucher.UpdatedBy = "Admin";

                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Sửa voucher thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một voucher để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Kiểm tra Discount > 0 và < 100
            decimal discount;
            if (!decimal.TryParse(txtDis.Text, out discount) || discount <= 0 || discount >= 100)
            {
                MessageBox.Show("Discount phải lớn hơn 0 và nhỏ hơn 100.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra Expired_Date không nhỏ hơn ngày hiện tại
            if (dtpED.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Expired Date không thể nhỏ hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra Minium_Total không thể là âm và phải lớn hơn 1000
            decimal miniumTotal;
            if (!decimal.TryParse(txtMin.Text, out miniumTotal) || miniumTotal < 0 || miniumTotal < 1000)
            {
                MessageBox.Show("Minium Total phải lớn hơn 1000 và không thể là số âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVC.SelectedRows.Count > 0)
                {
                    var selectedVoucherId = (Guid)dgvVC.SelectedRows[0].Cells["IDVoucher"].Value;
                    var voucher = context.Vouchers.FirstOrDefault(v => v.IDVoucher == selectedVoucherId);

                    if (voucher != null)
                    {                     
                        voucher.Discount = 0;
                        voucher.Minium_Total = int.MaxValue;

                        context.SaveChanges();
                        LoadData();
                        MessageBox.Show("Voucher đã được vô hiệu hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một voucher để vô hiệu hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtDis.Clear();
            txtMin.Clear();
            txtID.Clear();
            dtpED.Value = DateTime.Now;
        }

        private void VouchersForm_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void dgvVC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvVC.CurrentRow.Selected = true;
                txtID.Text = dgvVC.Rows[e.RowIndex].Cells["IDVoucher"].Value.ToString();
                txtDis.Text = dgvVC.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
                dtpED.Text = dgvVC.Rows[e.RowIndex].Cells["Expired_Date"].Value.ToString();
                txtMin.Text = dgvVC.Rows[e.RowIndex].Cells["Minium_Total"].Value.ToString();

               
            }
            LoadData();
        }
    }

}
