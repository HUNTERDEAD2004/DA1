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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            //InitializePasswordTextBox(); 
        }

        //private void InitializePasswordTextBox()
        //{
        //    txt_Password.PasswordChar = '*'; // Đặt ký tự ẩn (ví dụ: '*')
        //    txt_Password.UseSystemPasswordChar = true; // Sử dụng ký tự ẩn hệ thống (nếu có)
        //    // Thêm sự kiện để theo dõi giá trị nhập vào
        //    txt_Password.TextChanged += txt_Password_TextChanged;
        //    // Thêm TextBox vào Form hoặc Panel, vv.
        //    Controls.Add(txt_Password);
        //}

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            //Xử lý sự kiện khi giá trị trong TextBox thay đổi
            //Console.WriteLine("Password entered: " + txt_Password.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new DangNhap());
        //}
    }
}
