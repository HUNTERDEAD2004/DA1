using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.View
{
    public partial class Roleform : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-PMB8531\\SQLEXPRESS;Database=AppleStore4;Trusted_Connection=True;TrustServerCertificate=True");        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AN16NPP\\MSSQLSERVER01;Initial Catalog=Duan1_N6_Demo3;Integrated Security=True;TrustServerCertificate=true");
        SqlDataAdapter sda;
        DataSet ds;
        // Đặt màu chữ cho toàn bộ form
        AppDbContext Context;
        public Roleform()
        {
            Context = new AppDbContext();
            InitializeComponent();
        }

        void HienThi()
        {
            try
            {

                // Load Users
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                dgvUser.DataSource = dt;
                dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUser.DefaultCellStyle.ForeColor = Color.Black;
                dgvUser.DefaultCellStyle.BackColor = Color.White;
                dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvUser.AutoResizeColumns();

                // Load userRoles
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM userRoles", conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(dr2);
                dr2.Close();
                dgvUserRL.DataSource = dt2;
                dgvUserRL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUserRL.DefaultCellStyle.ForeColor = Color.Black;
                dgvUserRL.DefaultCellStyle.BackColor = Color.White;
                dgvUserRL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvUserRL.AutoResizeColumns();

                // Load Roles
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM Roles", conn);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                DataTable dt3 = new DataTable();
                dt3.Load(dr3);
                dr3.Close();
                dgvRole.DataSource = dt3;
                dgvRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRole.DefaultCellStyle.ForeColor = Color.Black;
                dgvRole.DefaultCellStyle.BackColor = Color.White;
                dgvRole.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvRole.AutoResizeColumns();
            }
            finally
            {
                conn.Close();
            }

        }

        void LayDLUser()
        {
            string sql = "SELECT * FROM Users";
            sda = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
        }
        void LayDLUserRl()
        {
            string sql2 = "SELECT * FROM userRoles";

            var userRoles = from ur in Context.userRoles
                            join u in Context.Users on ur.UserID equals u.UserID
                            join r in Context.Roles on ur.RoleID equals r.RoleId
                            select new
                            {
                                ur.UserRoleID,
                                UserID = ur.UserID,
                                UserName = u.Name,
                                RoleID = ur.RoleID,
                                RoleName = r.Name
                            };

            dgvUserRL.DataSource = userRoles.ToList();

            sda = new SqlDataAdapter(sql2, conn);
            ds = new DataSet();
        }
        void LayDLRole()
        {
            string sql3 = "SELECT * FROM Roles";
            sda = new SqlDataAdapter(sql3, conn);
            ds = new DataSet();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Role_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThi();
            LayDLUserRl();
            LayDLUser();
            LayDLRole();
        }

        private void dgvUserRL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserRL.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvUserRL.CurrentRow.Selected = true;
                txtIDHT.Text = dgvUserRL.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoleHT.Text = dgvUserRL.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNameUS.Text = dgvUserRL.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNameRL.Text = dgvUserRL.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            LayDLUserRl();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvUser.CurrentRow.Selected = true;
                txtIDHT.Text = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameUS.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            LayDLUser();
        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRole.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvRole.CurrentRow.Selected = true;
                txtRoleHT.Text = dgvRole.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameRL.Text = dgvRole.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRLID.Text = dgvRole.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvRole.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDes.Text = dgvRole.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            LayDLRole();
        }

        private void bttCap_Click(object sender, EventArgs e)
        {
            try
            {
                Guid userId = Guid.Parse(txtIDHT.Text);
                Guid roleId = Guid.Parse(txtRoleHT.Text);

                var existingUserRole = Context.userRoles
                    .FirstOrDefault(ur => ur.UserID == userId && ur.RoleID == roleId);

                string message = existingUserRole != null ? "Bạn có chắc muốn xóa quyền này?" : "Bạn có chắc muốn cấp quyền này?";
                DialogResult result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (existingUserRole != null)
                        {
                            // Nếu quyền đã tồn tại, xóa quyền đó
                            Context.userRoles.Remove(existingUserRole);
                            Context.SaveChanges();
                            MessageBox.Show($"+1 bụi đời, chúc mừng {txtNameUS.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            var userrole = new UserRole
                            {
                                UserRoleID = Guid.NewGuid(),
                                UserID = userId,
                                RoleID = roleId,
                            };
                            Context.userRoles.Add(userrole);
                            Context.SaveChanges();
                            MessageBox.Show($"Thăng chức rồi, nhớ bao đấy {txtNameUS.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        LayDLUserRl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cập nhật quyền thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hủy bỏ thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID hoặc Role không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bttTK_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string timKiem = txtTK.Text.Trim();
                string cbgt = CBGT.Text.Trim();
                string cbht = CBHD.Text.Trim();
                if (CBHD.Text == "Hoạt Động")
                {
                    cbht = "1";
                }
                else if (CBHD.Text == "Cút")
                {
                    cbht = "0";
                }


                string query = "SELECT * FROM Users WHERE 1=1";

                if (!string.IsNullOrEmpty(timKiem))
                {
                    query += " AND Name LIKE @name";
                }

                if (!string.IsNullOrEmpty(cbgt))
                {
                    query += " AND Gender = @gender";
                }

                if (!string.IsNullOrEmpty(cbht))
                {
                    query += " AND Status = @status";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(timKiem))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + timKiem + "%");
                    }
                    if (!string.IsNullOrEmpty(cbgt))
                    {
                        cmd.Parameters.AddWithValue("@gender", cbgt);
                    }
                    if (!string.IsNullOrEmpty(cbht))
                    {
                        cmd.Parameters.AddWithValue("@status", cbht);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dgvUser.DataSource = dataTable;
                    }
                }
                txtTK.Text = "";
                CBGT.Text = "";
                CBHD.Text = "";
                txtNameRL.Text = "";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            try
            {
                var role = new Role
                {
                    RoleId = Guid.NewGuid(),
                    Name = txtName.Text,
                    Description = txtDes.Text,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    CreateBy = "admin",
                    UpdateBy = "admin"
                };

                Context.Roles.Add(role);
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

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                Guid roleid = Guid.Parse(txtRLID.Text);
                Role role = Context.Roles.FirstOrDefault(u => u.RoleId == roleid);

                if (role != null)
                {            

                    role.RoleId = Guid.Parse(txtRLID.Text);
                    role.Name = txtName.Text;
                    role.Description = txtDes.Text;
                    
                }
                Context.Roles.Update(role);
                Context.SaveChanges();
                LoadData();
                bttCL_Click(sender, e);
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Guid roleID = Guid.Parse(txtRLID.Text);
                Role role = Context.Roles.FirstOrDefault(u => u.RoleId == roleID);

                if (role != null)
                {
                    Context.Roles.Remove(role);
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
            txtRLID.Text = "";
            txtName.Text = "";
            txtDes.Text = "";
            txtNameRL.Text = "";
        }

        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                var role = context.Roles.ToList();
                dgvRole.DataSource = role.Select(u => new
                {
                    u.RoleId,
                    u.Name,
                    u.Description,
                    u.CreateAt,
                    u.UpdateAt,
                    u.CreateBy,
                    u.UpdateBy
                }).ToList();
            }
        }

        private void bttRL_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
