using DAL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class QuanLyNhanVien : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=AppleStore4;Trusted_Connection=True;TrustServerCertificate=True");        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        // Đặt màu chữ cho toàn bộ form
        AppDbContext Context;


        public QuanLyNhanVien()
        {
            Context = new AppDbContext();
            InitializeComponent();
        }
        void HienThi()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvnhanvien.DataSource = dt;
            // Thiết lập tự động điều chỉnh độ rộng cột
            dgvnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thiết lập màu nền và màu chữ
            dgvnhanvien.DefaultCellStyle.ForeColor = Color.Black;
            dgvnhanvien.DefaultCellStyle.BackColor = Color.White;

            dgvnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvnhanvien.AutoResizeColumns();


        }
        void LayDL()
        {
            string sql = "SELECT * FROM Users";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }

        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var users = context.Users.ToList();
                dgvnhanvien.DataSource = users.Select(u => new
                {
                    u.UserID,
                    u.Name,
                    u.Adress,
                    u.Email,
                    u.PhoneNumber,
                    u.UserName,
                    Password = new string('*', u.Password.Length), // Hiển thị mật khẩu dưới dạng ***
                    u.Status,
                    u.BirthOfDate,
                    u.Gender,
                    u.CreateAt,
                    u.UpdateAt,
                    u.CreateBy
                }).ToList();
            }
        }


        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            LayDL();
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvnhanvien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvnhanvien.CurrentRow.Selected = true;
                txt_IdNhanVien.Text = dgvnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtten.Text = dgvnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDC.Text = dgvnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtemail.Text = dgvnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsdt.Text = dgvnhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTK.Text = dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMK.Text = dgvnhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtL.Text = dgvnhanvien.Rows[e.RowIndex].Cells[10].Value.ToString();
                //txtTK.Text = dgvnhanvien.Rows[e.RowIndex].Cells[8].Value.ToString();
                dateNV.Text = dgvnhanvien.Rows[e.RowIndex].Cells[8].Value.ToString();


                if (dgvnhanvien.Rows[e.RowIndex].Cells[9].Value.ToString() == "Male" || dgvnhanvien.Rows[e.RowIndex].Cells[9].Value.ToString() == "Nam")
                {
                    rbtnam.Checked = true;
                    rbtnu.Checked = false;
                }
                else if (dgvnhanvien.Rows[e.RowIndex].Cells[9].Value.ToString() == "Female" || dgvnhanvien.Rows[e.RowIndex].Cells[9].Value.ToString() == "Nữ")
                {
                    rbtnam.Checked = false;
                    rbtnu.Checked = true;
                }

                if (dgvnhanvien.Rows[e.RowIndex].Cells[7].Value.ToString() == "1")
                {
                    rdb_HoatDong.Checked = true;
                    rdb_NgungHD.Checked = false;
                }
                else if (dgvnhanvien.Rows[e.RowIndex].Cells[7].Value.ToString() == "2")
                {
                    rdb_HoatDong.Checked = false;
                    rdb_NgungHD.Checked = true;
                }

            }
            LayDL();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvnhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvnhanvien.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
            {
                // Thay đổi giá trị hiển thị thành ***
                e.Value = new string('*', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^\d{10}$");
        }

        private bool IsValidBirthDate(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (birthDate > DateTime.Now.AddYears(-age)) age--;
            return age >= 16;
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtten.Text) ||
                    string.IsNullOrWhiteSpace(txtDC.Text) ||
                    string.IsNullOrWhiteSpace(txtemail.Text) ||
                    string.IsNullOrWhiteSpace(txtsdt.Text) ||
                    string.IsNullOrWhiteSpace(txtTK.Text) ||
                    string.IsNullOrWhiteSpace(txtMK.Text) ||
                    string.IsNullOrWhiteSpace(txtL.Text) ||
                    (!rbtnam.Checked && !rbtnu.Checked && !rdb_NgungHD.Checked && !rdb_HoatDong.Checked))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin và đảm bảo thông tin hợp lệ. Đập chết mợ bây giờ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidEmail(txtemail.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng email. Để spam TN rác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidPhoneNumber(txtsdt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng sdt. Để gọi ok", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidBirthDate(dateNV.Value))
                {
                    MessageBox.Show("Vui lòng nhập đúng ngày sinh. Tý tuổi ranh làm gì. Đập vỡ alo bây giờ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra trùng lặp email và số điện thoại
                bool emailExists = Context.Users.Any(u => u.Email == txtemail.Text);
                bool phoneNumberExists = Context.Users.Any(u => u.PhoneNumber == txtsdt.Text);
                bool taikhoanExists = Context.Users.Any(u => u.UserName == txtTK.Text);
                bool tennvExists = Context.Users.Any(u => u.Name == txtten.Text);

                if (tennvExists)
                {
                    MessageBox.Show("tên đã tồn tại. Vui lòng sử dụng tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (emailExists)
                {
                    MessageBox.Show("Email đã tồn tại. Vui lòng sử dụng email khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (phoneNumberExists)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng sử dụng số điện thoại khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (taikhoanExists)
                {
                    MessageBox.Show("tài khoảng đã tồn tại. Vui lòng sử dụng số tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var user = new User
                {
                    UserID = Guid.NewGuid(),
                    Name = txtten.Text,
                    Adress = txtDC.Text,
                    Email = txtemail.Text,
                    PhoneNumber = txtsdt.Text,
                    UserName = txtTK.Text,
                    Password = txtMK.Text,
                    Status = rdb_HoatDong.Checked ? 1 : 0,
                    BirthOfDate = dateNV.Value,
                    Gender = rbtnam.Checked ? "Male" : (rbtnu.Checked ? "Female" : "Unspecified"),
                    Wage = Convert.ToInt32(txtL.Text),
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    CreateBy = "admin", // Thay đổi thành người dùng hiện tại
                    UpdateBy = "admin"  // Thay đổi thành người dùng hiện tại
                };

                Context.Users.Add(user);
                Context.SaveChanges();
                LoadData();
                bttCL_Click(sender, e);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtten.Text) ||
                    string.IsNullOrWhiteSpace(txtDC.Text) ||
                    string.IsNullOrWhiteSpace(txtemail.Text) ||
                    string.IsNullOrWhiteSpace(txtsdt.Text) ||
                    string.IsNullOrWhiteSpace(txtTK.Text) ||
                    string.IsNullOrWhiteSpace(txtMK.Text) ||
                    (!rbtnam.Checked && !rbtnu.Checked && !rdb_NgungHD.Checked && !rdb_HoatDong.Checked))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin và đảm bảo thông tin hợp lệ. Đập hết mợ bây giờ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidEmail(txtemail.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng email. Để spam TN rác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidPhoneNumber(txtsdt.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng sdt. Để gọi ok", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidBirthDate(dateNV.Value))
                {
                    MessageBox.Show("Vui lòng nhập đúng ngày sinh. Tý tuổi ranh làm gì. Đập vỡ alo bây giờ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Guid userId = Guid.Parse(txt_IdNhanVien.Text);
                User user = Context.Users.FirstOrDefault(u => u.UserID == userId);

                if (user != null)
                {
                    // Kiểm tra trùng lặp email và số điện thoại nhưng bỏ qua bản ghi đang sửa
                    bool emailExists = Context.Users.Any(u => u.Email == txtemail.Text && u.UserID != userId);
                    bool phoneNumberExists = Context.Users.Any(u => u.PhoneNumber == txtsdt.Text && u.UserID != userId);
                    bool taikhoanExists = Context.Users.Any(u => u.UserName == txtTK.Text && u.UserID != userId);
                    bool tennvExists = Context.Users.Any(u => u.Name == txtten.Text && u.UserID != userId);

                    if (tennvExists)
                    {
                        MessageBox.Show("Tên đã tồn tại. Vui lòng sử dụng tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (emailExists)
                    {
                        MessageBox.Show("Email đã tồn tại. Vui lòng sử dụng email khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (phoneNumberExists)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng sử dụng số điện thoại khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (taikhoanExists)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại. Vui lòng sử dụng tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    user.Name = txtten.Text;
                    user.Adress = txtDC.Text;
                    user.Email = txtemail.Text;
                    user.PhoneNumber = txtsdt.Text;
                    user.UserName = txtTK.Text;
                    user.Password = txtMK.Text;
                    user.Status = rdb_HoatDong.Checked ? 1 : 0;
                    user.BirthOfDate = dateNV.Value;
                    user.Gender = rbtnam.Checked ? "Male" : (rbtnu.Checked ? "Female" : "Unspecified");
                    user.Wage = Convert.ToInt32(txtL.Text);
                    user.UpdateAt = DateTime.Now;
                    user.UpdateBy = "admin"; // Thay đổi thành người dùng hiện tại

                    Context.SaveChanges();
                    LoadData();
                    bttCL_Click(sender, e);
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sửa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                Guid userId = Guid.Parse(txt_IdNhanVien.Text);
                User user = Context.Users.FirstOrDefault(u => u.UserID == userId);

                if (user != null)
                {
                    Context.Users.Remove(user);
                    Context.SaveChanges();
                    LoadData();
                    bttCL_Click(sender, e);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thấy ID!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bttCL_Click(object sender, EventArgs e)
        {
            txt_IdNhanVien.Text = "";
            txtten.Text = "";
            txtDC.Text = "";
            txtemail.Text = "";
            txtsdt.Text = "";
            txtTK.Text = "";
            txtMK.Text = "";
            txtL.Text = "";
            dateNV.Value = DateTime.Now;
            rbtnam.Checked = false;
            rbtnu.Checked = false;
            rdb_HoatDong.Checked = false;
            rdb_NgungHD.Checked = false;
        }

        private void bttRL_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }
    }
}
