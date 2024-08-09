using AppData.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class DangKy : Form
    {
        IphoneDbContext context;
        public DangKy()
        {
            InitializeComponent();
            context = new IphoneDbContext();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // sdt 
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Loại bỏ các khoảng trắng, dấu "-" hoặc dấu "." trong số điện thoại
            phoneNumber = phoneNumber.Replace(" ", "").Replace("-", "").Replace(".", "");

            // Kiểm tra độ dài của số điện thoại
            if (phoneNumber.Length < 10 || phoneNumber.Length > 12)
                return false;

            // Kiểm tra nếu số điện thoại bắt đầu bằng "0"
            if (phoneNumber.StartsWith("0"))
            {
                // Số điện thoại Việt Nam thường bắt đầu bằng "0" và có 10 chữ số
                return phoneNumber.Length == 10;
            }
            else
            {
                // Số điện thoại quốc tế thường bắt đầu bằng "+" và có 11 hoặc 12 chữ số
                return phoneNumber.Length == 11 || phoneNumber.Length == 12;
            }
        }
        //

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_User.Text;
                string ten = txtTen.Text;
                string email = txtEmail.Text;
                string sdt = txtsdt.Text;
                string GioiTinh = comboBox1.Text;
                string Password = txt_Password.Text;
                string dc = txtDiaChi.Text;
                if (string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(ten) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(sdt) ||
                    string.IsNullOrEmpty(GioiTinh) ||
                    string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }
                var existingUser = context.Accounts.FirstOrDefault(u => u.Username == username || u.Email == email || u.PhoneNumber == sdt);
                if (existingUser != null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng sử dụng thông tin khác.");
                    return;
                }
                //
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Email không hợp lệ.");
                    return;
                }

                // Kiểm tra số điện thoại
                if (!IsValidPhoneNumber(sdt))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.");
                    return;
                }

                // Kiểm tra tuổi
                int age = DateTime.Now.Year - dtpNS.Value.Year;
                if (age < 16)
                {
                    MessageBox.Show("Bạn phải từ 16 tuổi trở lên mới có thể đăng ký.");
                    return;
                }
                Account user = new Account()
                {
                    Username = username,
                    Name = ten,
                    Adress = dc,
                    BOD = dtpNS.Value,
                    Email = email,
                    PhoneNumber = sdt,
                    Gender = GioiTinh,
                    Wage = 0,
                    Password = Password,
                    Roles = "user",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    CreateBy = "system ",
                    UpdateBy = "system ",
                };
                context.Accounts.Add(user);
                context.SaveChanges();
                MessageBox.Show("đăng ký thành công");
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    MessageBox.Show($"Đăng ký thất bại: {ex.Message}");
                }
                else if (ex is InvalidOperationException)
                {
                    MessageBox.Show($"Đăng ký thất bại: {ex.Message}");
                }
                else
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }


        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            QuenMK form = new QuenMK();
            this.Hide();
            form.Show();
        }
    }
}
