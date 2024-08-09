using AppData.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
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
    public partial class Activitiesform : Form
    {
        IphoneDbContext context;
        public Activitiesform()
        {
            context = new IphoneDbContext();
            InitializeComponent();
        }

        private void Activitiesform_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        void HienThi()
        {
            try
            {
                // Sử dụng LINQ để lấy tất cả các bản ghi từ Activities
                var activities = context.Activities.ToList();

                // Chuyển đổi danh sách thành DataTable
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Note", typeof(string));
                dt.Columns.Add("CreatedAt", typeof(DateTime));
                dt.Columns.Add("UpdatedAt", typeof(DateTime));
                dt.Columns.Add("CreatedBy", typeof(string));
                dt.Columns.Add("UpdatedBy", typeof(string));

                foreach (var activity in activities)
                {
                    dt.Rows.Add(activity.ID, activity.Note, activity.CreatedAt, activity.UpdatedAt, activity.CreatedBy, activity.UpdatedBy);
                }

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
