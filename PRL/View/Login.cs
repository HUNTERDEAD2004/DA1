using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
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
    public partial class Login : Form
    {
        IphoneDbContext dbContext;
        public Login()
        {
            InitializeComponent();
            dbContext = new IphoneDbContext();
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            QuenMK form = new QuenMK();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string pass = textBox2.Text;
            try
            {
                Account us = GetUser(username, pass);
                if (us != null && CheckUser(us))
                {
                    MainForm form = new MainForm();

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MyApp");
                    key.SetValue("Username", username);
                    key.Close();

                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        bool CheckUser(Account user)
        {
            return user != null; // Chỉ kiểm tra xem user có null hay không
        }

        private Account GetUser(string username, string pass)
        {
            return dbContext.Accounts.FirstOrDefault(u => u.Username == username && u.Password == pass);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKy form = new DangKy();
            this.Hide();
            form.Show();
        }
    }
}
