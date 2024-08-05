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
    public partial class Iphone : Form
    {
        public Iphone()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            // Tạo và cấu hình OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chọn một hình ảnh";

            // Hiển thị hộp thoại OpenFileDialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp đã chọn
                string selectedFilePath = openFileDialog.FileName;

                // Hiển thị hình ảnh trong PictureBox
                image1.Image = Image.FromFile(selectedFilePath);

                // Điều chỉnh PictureBox để hiển thị toàn bộ ảnh
                image1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
