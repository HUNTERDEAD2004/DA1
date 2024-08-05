
using Microsoft.Data.SqlClient;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using AppData.Models;
<<<<<<< HEAD
using System.Text.RegularExpressions;
=======
>>>>>>> An-DBNew

namespace PRL.View
{
    public partial class KhachHang : Form
    {
        private readonly IphoneDbContext _dbContext;

        public KhachHang()
        {
            InitializeComponent();
            _dbContext = new IphoneDbContext();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            // Xóa các cột hiện có (nếu có)
            dgvkhachhang.Columns.Clear();

            // Thêm các cột vào DataGridView
            dgvkhachhang.Columns.Add("CustomerID", "Customer ID");
            dgvkhachhang.Columns.Add("CustomerName", "Name");
            dgvkhachhang.Columns.Add("Age", "Age");
            dgvkhachhang.Columns.Add("Email", "Email");
            dgvkhachhang.Columns.Add("Gender", "Gender");
            dgvkhachhang.Columns.Add("PhoneNumber", "Number");
            dgvkhachhang.Columns.Add("Address", "Địa chỉ");
            dgvkhachhang.Columns.Add("Point", "Point");
            dgvkhachhang.Columns.Add("CreatedAt", "Created At");
            dgvkhachhang.Columns.Add("UpdatedAt", "Updated At");
            dgvkhachhang.Columns.Add("CreatedBy", "Created By");
            dgvkhachhang.Columns.Add("UpdatedBy", "Updated By");

            // Lấy dữ liệu từ cơ sở dữ liệu
            var customers = _dbContext.Customers.ToList();

            // Xóa dữ liệu hiện có trong DataGridView
            dgvkhachhang.Rows.Clear();

            // Thêm dữ liệu vào DataGridView
            foreach (var customer in customers)
            {
                dgvkhachhang.Rows.Add(customer.CustomerID, customer.CustomerName, customer.Age, customer.Email,
                                      customer.Gender, customer.PhoneNumber, customer.Address, customer.Point, customer.CreatedAt,
                                      customer.UpdatedAt, customer.CreatedBy, customer.UpdatedBy);
            }
        }
        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvkhachhang.Rows[e.RowIndex];

                string customerId = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                int age = int.Parse(row.Cells[2].Value.ToString());
                string email = row.Cells[3].Value.ToString();
                string gender = row.Cells[4].Value.ToString();
                if (gender == "Male" || gender == "Nam")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (gender == "Female" || gender == "Nữ")
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                string number = row.Cells[5].Value.ToString();
                string diachi = row.Cells[6].Value.ToString();
                int point = int.Parse(row.Cells[7].Value.ToString());
                DateTime createAt = DateTime.Parse(row.Cells[8].Value.ToString());
                DateTime updateAt = DateTime.Parse(row.Cells[9].Value.ToString());
                string createBy = row.Cells[10].Value.ToString();
                string updateBy = row.Cells[11].Value.ToString();

                txt_idkh.Text = customerId;
                txtten.Text = name;
                txtns.Text = age.ToString();
                txtemail.Text = email;
                txtsdt.Text = number;
                txtdiachi.Text = diachi;
                txtdiem.Text = point.ToString();
                txtnguoitao.Text = createBy;
                txtnguoisua.Text = updateBy;
            }
        }

        // thêm
        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtten.Text;
            string gender = radioButton1.Checked ? "Nam" : (radioButton2.Checked ? "Nữ" : "Unspecified");

            int tuoi;
            if (int.TryParse(txtns.Text, out tuoi))
            {
                // Chuyển đổi thành công
            }
            else
            {
                MessageBox.Show("Định dạng ngày sinh không hợp lệ. Vui lòng nhập một số hợp lệ.");
                return;
            }
<<<<<<< HEAD
            string emaill = txtemail.Text;
=======
            string email = txtemail.Text;
>>>>>>> An-DBNew
            string diachi = txtdiachi.Text;
            int diem;
            if (int.TryParse(txtdiem.Text, out diem))
            {
                // Chuyển đổi thành công
            }
            else
            {
                MessageBox.Show("Định dạng diem không hợp lệ. Vui lòng nhập một số hợp lệ.");
                return;
            }
            string sdt = txtsdt.Text;
            DateTime ngaytao;
            if (!DateTime.TryParse(dtpngaytao.Text, out ngaytao))
            {
                return;
            }
            DateTime ngaysua;
            if (!DateTime.TryParse(dtpngaysua.Text, out ngaysua))
            {
                return;
            }
            string nguoitao = txtnguoitao.Text;
            string nguoisua = txtnguoisua.Text;
            Customer kh = new Customer()
            {
                CustomerID = Guid.NewGuid(),
                CustomerName = name,
                Age = tuoi,
<<<<<<< HEAD
                Email = emaill,
=======
                Email = email,
>>>>>>> An-DBNew
                Address = diachi,
                Gender = gender,
                PhoneNumber = sdt,
                Point = diem,
                CreatedAt = ngaytao,
                UpdatedAt = ngaysua,
                CreatedBy = nguoitao,
                UpdatedBy = nguoisua
            };
            _dbContext.Customers.Add(kh);
            _dbContext.SaveChanges();
            LoadData();
            MessageBox.Show("+1 sức mạnh");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtten.Text) ||
                    string.IsNullOrWhiteSpace(txtns.Text) ||
                    string.IsNullOrWhiteSpace(txtemail.Text) ||
                    string.IsNullOrWhiteSpace(txtsdt.Text) ||
                    (!radioButton1.Checked && !radioButton2.Checked) ||
                    string.IsNullOrWhiteSpace(txtdiem.Text) ||
                    string.IsNullOrWhiteSpace(txtnguoisua.Text) ||
                    string.IsNullOrWhiteSpace(txtnguoitao.Text))
                {
                    MessageBox.Show("Lấp đầy khoảng trống đi nào", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
<<<<<<< HEAD
                string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                if (!Regex.IsMatch(txtemail.Text, emailRegex))
                {
                    MessageBox.Show("Sai email rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
=======

>>>>>>> An-DBNew
                Guid id = Guid.Parse(txt_idkh.Text);
                Customer cust = _dbContext.Customers.FirstOrDefault(a => a.CustomerID == id);
                cust.CustomerName = txtten.Text;
                cust.Age = int.Parse(txtns.Text);
                cust.Email = txtemail.Text;
                cust.Address = txtdiachi.Text;
                cust.Gender = radioButton1.Checked ? "Nam" : (radioButton2.Checked ? "Nữ" : "Unspecified");
                cust.PhoneNumber = txtsdt.Text;
                cust.Point = int.Parse(txtdiem.Text);
                cust.CreatedAt = DateTime.Now;
                cust.UpdatedAt = DateTime.Now;
                cust.CreatedBy = txtnguoitao.Text;
                cust.UpdatedBy = txtnguoisua.Text;

                _dbContext.SaveChanges();
                LoadData();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sửa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = Guid.Parse(txt_idkh.Text);
                Customer cus = _dbContext.Customers.FirstOrDefault(u => u.CustomerID == id);

                if (cus != null)
                {
                    _dbContext.Customers.Remove(cus);
                    _dbContext.SaveChanges();
                    LoadData();
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

        private void button4_Click(object sender, EventArgs e)
        {
            txt_idkh.Text = "";
            txtten.Text = "";
            txtns.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtdiem.Text = "0";
            dtpngaysua.Value = DateTime.Now;
            dtpngaytao.Value = DateTime.Now;
            txtnguoitao.Text = "";
            txtnguoisua.Text = "";
        }
    }
}
