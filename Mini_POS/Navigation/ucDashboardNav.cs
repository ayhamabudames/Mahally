using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_POS.Navigation
{
    public partial class ucDashboardNav : UserControl
    {
        public ucDashboardNav()
        {
            InitializeComponent();
        }

        private async void btnIncomeProfite_Click(object sender, EventArgs e)
        {
            //get income and profite
            decimal income;
            decimal profite;

            (income, profite) = await clsProducts.GetTotalIncomeAndProfiteInRange
                (dtpIncomeProfiteFrom.Value, dtpIncomeProfiteTo.Value);
            lblIncome.Text = income.ToString("C2");
            lblProfite.Text = profite.ToString("C2");
        }

        private void dtpIncomeProfiteTo_DropDown(object sender, EventArgs e)
        {
            dtpIncomeProfiteTo.MinDate = dtpIncomeProfiteFrom.Value;
        }

        private void dtpTotalSalesTo_DropDown(object sender, EventArgs e)
        {
            dtpTotalSalesTo.MinDate = dtpTotalSalesFrom.Value;
        }

        private async void btnTotalSales_Click(object sender, EventArgs e)
        {
            int totalSales = await clsProducts.GetTotalSalesInRangeAsync
                (dtpTotalSalesFrom.Value, dtpTotalSalesTo.Value);
            lblTotalSales.Text = totalSales.ToString();
        }

        private async void ucDashboardNav_Load(object sender, EventArgs e)
        {
            //get low stock products
            dgvLowStockProducts.DataSource = await clsProducts.GetLowStockProducts();

            //get top products
            dgvTopProducts.DataSource = await clsProducts.GetTopSoldProductsAsync();
        }
    }
}
