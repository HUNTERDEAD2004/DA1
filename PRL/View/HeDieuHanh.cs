using AppData.Models;
using DocumentFormat.OpenXml.InkML;
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
    public partial class HeDieuHanh : Form
    {
        IphoneDbContext context;
        public HeDieuHanh()
        {
            context = new IphoneDbContext();
            InitializeComponent();
        }
        public static string? GetAccountIdFromRegistry()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
                string tk = null;
                if (key != null)
                {
                    tk = key.GetValue("Username").ToString();
                    key.Close();
                    return tk;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khóa Registry", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy xuất Registry hoặc cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        string currentUserName = GetAccountIdFromRegistry();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(OSNameTxt.Text))
                {
                    MessageBox.Show("Không được pháp để trống tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var exist = context.OperatingSystems.FirstOrDefault(op => op.OSName == OSNameTxt.Text);
                if (exist != null)
                {
                    MessageBox.Show("Đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var operatingSystem = new DAL.Models.OperatingSystems
                {
                    OSID = Guid.NewGuid(),
                    OSName = OSNameTxt.Text,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedBy = currentUserName,
                    UpdatedBy = currentUserName
                };

                context.OperatingSystems.Add(operatingSystem);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm hệ điều hành: {ex.Message}");
                throw;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvOShow.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một hệ điều hành để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(OSNameTxt.Text))
                {
                    MessageBox.Show("Tên hệ điều hành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var osId = (Guid)DgvOShow.SelectedRows[0].Cells["OSID"].Value;
                var existingOS = context.OperatingSystems.FirstOrDefault(os => os.OSID == osId);

                if (existingOS == null)
                {
                    MessageBox.Show("Hệ điều hành không tìm thấy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                existingOS.OSName = OSNameTxt.Text;
                existingOS.UpdatedAt = DateTime.UtcNow;
                existingOS.UpdatedBy = currentUserName;

                context.OperatingSystems.Update(existingOS);
                context.SaveChanges();

                MessageBox.Show("Cập nhật hệ điều hành thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Load();
                ClearForm();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Lỗi khi cập nhật hệ điều hành: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Load()
        {
            try
            {
                var operatingSystems = context.OperatingSystems
                    .Select(os => new
                    {
                        OSID = os.OSID,
                        OSName = os.OSName
                    })
                    .ToList();

                DgvOShow.DataSource = operatingSystems;
                DgvOShow.Columns["OSID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu hệ điều hành: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            OSNameTxt.Text = "";
            OSIdTxt.Text = "";
        }
        public void DeleteOperatingSystem(Guid osId)
        {
            try
            {
                var operatingSystem = context.OperatingSystems.FirstOrDefault(os => os.OSID == osId);

                if (operatingSystem == null)
                {
                    throw new KeyNotFoundException("Hệ điều hành không tìm thấy.");
                }

                context.OperatingSystems.Remove(operatingSystem);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa hệ điều hành: {ex.Message}");
                throw;
            }
        }


    }
}
