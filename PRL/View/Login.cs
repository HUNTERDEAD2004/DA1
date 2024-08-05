using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
<<<<<<< HEAD
=======
using Microsoft.Win32;
>>>>>>> An-DBNew
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
<<<<<<< HEAD

=======
>>>>>>> An-DBNew
            string username = textBox1.Text;
            string pass = textBox2.Text;
            try
            {
                Account us = GetUser(username, pass);
                if (us != null && CheckUser(us))
                {
<<<<<<< HEAD
                    MainForm form = new MainForm(username);

                    form.Tag = us; // Lưu trữ thông tin người dùng trong Tag
=======
                    MainForm form = new MainForm();

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MyApp");
                    key.SetValue("Username", username);
                    key.SetValue("Role", us.Roles);
                    key.Close();
>>>>>>> An-DBNew

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
<<<<<<< HEAD
            return user != null; // Chỉ kiểm tra xem user có null hay không
        }

        private Account GetUser(string username, string pass)
        {
            return dbContext.Accounts.FirstOrDefault(u => u.Username == username && u.Password == pass);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                checkBox1.BringToFront();
                textBox2.PasswordChar = '\0';
            }
            else
            {
                checkBox1.BringToFront();
                textBox2.PasswordChar = '*';
            }
=======
            return user != null; 
        }


        private Account GetUser(string username, string pass)
        {
            var user = dbContext.Accounts.FirstOrDefault(u => u.Username == username && u.Password == pass);
            if (user != null)
            {
                user.Roles = GetRole(username); 
            }
            return user;
        }


        private string GetRole(string username)
        {
            var role = dbContext.Accounts.Where(r => r.Username == username).Select(r => r.Roles).FirstOrDefault();
            return role;
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKy form = new DangKy();
            this.Hide();
            form.Show();
>>>>>>> An-DBNew
        }
    }
}
