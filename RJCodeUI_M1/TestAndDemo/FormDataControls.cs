using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJCodeUI_M1.TestAndDemo
{
    public partial class FormDataControls : RJForms.RJChildForm
    {
        Models.SalesAnalysis analysis = new Models.SalesAnalysis();

        public FormDataControls()
        {
            InitializeComponent();

            LoadDatagridviewData();
            LoadChartData();
        }
        private void LoadDatagridviewData()
        {
            rjDataGridView1.Rows.Add("Amethyst"," Johns","19");
            rjDataGridView1.Rows.Add("Leandra"," Copeland", "21");
            rjDataGridView1.Rows.Add("Susan"," Keith",  "45");
            rjDataGridView1.Rows.Add("Odysseus"," Matthews", "28");
            rjDataGridView1.Rows.Add("Bianca ","Goodman", "36");

            rjDataGridView2.Rows.Add("Amethyst", " Johns", "19");
            rjDataGridView2.Rows.Add("Leandra", " Copeland", "21");
            rjDataGridView2.Rows.Add("Susan", " Keith", "45");
            rjDataGridView2.Rows.Add("Odysseus", " Matthews", "28");
            rjDataGridView2.Rows.Add("Bianca ", "Goodman", "36");

            var list = new Models.Product().GetProductsList().Take(8).ToList();
            rjDataGridView3.DataSource = list;
        }
        private void LoadChartData()
        {

            var salesRevenue2 = new List<Models.SalesAnalysis.SalesRevenue>();
            var salesRevenue3 = new List<Models.SalesAnalysis.SalesRevenue>();
            bool sum = false;
            foreach (var item in analysis.SalesRevenueList)
            {
                if (sum == true)
                {
                    salesRevenue2.Add(new Models.SalesAnalysis.SalesRevenue
                    {
                        DateOrTime = item.DateOrTime,
                        Revenue = item.Revenue + 450000
                    });
                    sum = false;
                }
                else
                {
                    salesRevenue2.Add(new Models.SalesAnalysis.SalesRevenue
                    {
                        DateOrTime = item.DateOrTime,
                        Revenue = item.Revenue - 450000
                    });
                    sum = true;
                }
            }
            foreach (var item in analysis.SalesRevenueList)
            {

                salesRevenue3.Add(new Models.SalesAnalysis.SalesRevenue
                {
                    DateOrTime = item.DateOrTime,
                    Revenue = item.Revenue - 250000
                });


            }

            rjChart1.Series[0].Points.DataBind(analysis.SalesRevenueList, "DateOrTime", "Revenue", "");
            rjChart1.Series[1].Points.DataBind(salesRevenue2, "DateOrTime", "Revenue", "");
            rjChart1.Series[2].Points.DataBind(salesRevenue3, "DateOrTime", "Revenue", "");

            rjChart2.Series[0].Points.DataBind(analysis.SalesByCategoryList, "Item", "UnitSold", "");
        }
    }
}
