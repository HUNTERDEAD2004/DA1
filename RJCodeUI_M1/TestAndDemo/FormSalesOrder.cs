using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RJCodeUI_M1.Models;

namespace RJCodeUI_M1.TestAndDemo
{
    public partial class FormSalesOrder : RJForms.RJChildForm
    {
        #region -> Fields

        int rows = 8;
        int starIndex = 0;
        bool isDragging = false;
        List<SalesOrder> salesList = new List<SalesOrder>();
        SalesOrder salesOrder = new SalesOrder();
        #endregion

        #region Constructor

        public FormSalesOrder()
        {
            InitializeComponent();
            cbPeriod.SelectedIndex = 5;
            rjComboBox2.Text = "All";
        }
        #endregion

        #region Methods Definition

        private void LoadPageDatagridView()
        {
            salesList.Clear();
            rjDataGridView1.DataSource = null;
            salesList.AddRange(salesOrder.GetSalesList().GetRange(starIndex, rows));
            rjDataGridView1.DataSource = salesList;

        }

        #endregion

        #region -> Event Methods

        private void FormSalesOrder_Load(object sender, EventArgs e)
        {
            LoadPageDatagridView();
            lblNumberItems.Text = "Total item: " + salesOrder.GetSalesList().Count.ToString();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            starIndex = (salesOrder.GetSalesList().FindIndex(a => a.OrderId == salesList.LastOrDefault().OrderId)) + 1;
            if (starIndex <= salesOrder.GetSalesList().Count - 1)
                LoadPageDatagridView();
        }
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            starIndex = (salesOrder.GetSalesList().FindIndex(a => a.OrderId == salesList.FirstOrDefault().OrderId)) - rows;
            if (starIndex >= 0)
                LoadPageDatagridView();
        }
        private void FormSalesOrder_Move(object sender, EventArgs e)
        {
            isDragging = true;
        }
        private void FormSalesOrder_ResizeEnd(object sender, EventArgs e)
        {
            if (isDragging == false)
            {
                rows = rjDataGridView1.Height / rjDataGridView1.Rows[0].Height - 1;
                LoadPageDatagridView();
            }
            isDragging = false;
        }

        private void FormSalesOrder_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                rows = rjDataGridView1.Height / rjDataGridView1.Rows[0].Height - 1;
                LoadPageDatagridView();
            }
        }
        #endregion

    }
}
