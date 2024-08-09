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

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_User.Text;
                string ten = txtTen.Text;
                string dc = txtDiaChi.Text;
                string email = txtEmail.Text;
                string sdt = txtsdt.Text;
                string GioiTinh = comboBox1.Text;
                string Password = txt_Password.Text;
                if (string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(ten) ||
                    string.IsNullOrEmpty(dc) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(sdt) ||
                    string.IsNullOrEmpty(GioiTinh) ||
                    string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
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
                    CreateBy = "admin",
                    UpdateBy = "admin",
                };

                var acc = new DAL.Models.Activity
                {
                    Note = $"{username} Đã đăng ký tài khoản Tên {ten}, vào lúc {DateTime.Now}",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = username,
                    UpdatedBy = username
                };

                context.Accounts.Add(user);
                context.Activities.Add(acc);
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
