using FontAwesome.Sharp;
using Microsoft.Win32;
using System.Data;
using System.Xml.Linq;

namespace PRL.View
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private Form currentForm;
        private Orderform orderForm;
        private HDCT hdctForm;
        
        public struct hover
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();
                currentIcon.IconChar = currentBtn.IconChar;
                currentIcon.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(49, 42, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        public MainForm()
        {
            

            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            Menu.Controls.Add(leftborderBtn);
        }
        public void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;
            currentIcon.IconChar = IconChar.Tags;
            currentIcon.IconColor = Color.MediumPurple;
            title.Text = "Products";
        }
        public void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChange.Controls.Clear();
            panelChange.Controls.Add(form);
            panelChange.Tag = form;
            form.BringToFront();
            form.Show();
            title.Text = form.Text;
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
            if (key != null)
            {
                var role = key.GetValue("Role").ToString();
                key.Close();

                if (role == "admin")
                {
                    ActivateButton(sender, hover.color1);
                    OpenForm(new Products());
                }
                else if (role == "user")
                {
                    MessageBox.Show("Cút");
                }
            }
            
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
            if (key != null)
            {
                var role = key.GetValue("Role").ToString();
                key.Close();

                if (role == "admin")
                {
                    ActivateButton(sender, hover.color2);
                    OpenForm(new QuanLyNhanVien());
                } else if (role == "user")
                {
                    MessageBox.Show("Cút");
                }
            }
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            HDCT hdctform = new HDCT();
            Orderform orderform = new Orderform(hdctform);

            OpenForm(orderform);
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color4);
            OpenForm(new KhachHang());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color5);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, hover.color6);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MyApp");
            if (key != null)
            {
                var name = key.GetValue("Username").ToString();
                label2.Text = ($"Xin Chào: {name}");
                key.Close();
            }

        }
    }
}
