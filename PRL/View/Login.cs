using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
        AppDbContext dbContext;
        public Login()
        {
            InitializeComponent();
            dbContext = new AppDbContext();
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            DAL.Models.User user = GetUser(username, pass); 
            if (user != null && Checkk(user))
            {
                MainForm form = new MainForm(username);
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
            }
        }
        bool Checkk(DAL.Models.User user)
        {
            return user != null; // Chỉ kiểm tra xem user có null hay không
        }

        private DAL.Models.User GetUser(string username, string pass)
        {
            return dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == pass);
        }
    }
}
