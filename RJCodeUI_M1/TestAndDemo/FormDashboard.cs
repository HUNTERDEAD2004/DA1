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
    public partial class FormDashboard : RJForms.RJChildForm
    {
        SalesAnalysis analysis = new SalesAnalysis();
        public FormDashboard()
        {
            InitializeComponent();

            var categories = new List<SalesAnalysis.SalesByCategory>();
            categories.AddRange(analysis.SalesByCategoryList);             
            categories.Add(new SalesAnalysis.SalesByCategory { Item="All"});

            cbCategory.DataSource = categories; 
            cbCategory.DisplayMember = "Item";            
            cbCategory.SelectedIndex = categories.Count-1;
            cbPeriod.SelectedIndex = 4;
           
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            //Labels
            lblNumberSales.Text = analysis.TotalNumberSales.ToString();
            lblRevenue.Text = analysis.Revenue.ToString("C0");
            lblProfit.Text = analysis.Profit.ToString("C0");
            lblCost.Text = analysis.Cost.ToString("C0");
            lblNumberCustomers.Text = analysis.NumberCustomers.ToString();
            //Charts
            chartRevenue.Series[0].Points.DataBind(analysis.SalesRevenueList, "DateOrTime", "Revenue", "");            
            chartSalesByCategory.Series[0].Points.DataBind(analysis.SalesByCategoryList, "Item", "UnitSold", "");
            chartNumberSales.Series[0].Points.DataBind(analysis.NumberSalesList, "DateOrTime", "UnitSold", "");
            chartNumberSales.Series[1].Points.DataBind(analysis.NumberSalesList, "DateOrTime", "UnitSold", "");
            chartTop5Products.Series[0].Points.DataBind(analysis.Top5ProductsList, "Item", "UnitSold", "");
        }

    }
}
