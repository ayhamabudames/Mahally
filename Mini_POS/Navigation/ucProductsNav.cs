using Bll;
using DTO;
using Mini_POS.Product;
using Mini_POS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_POS.Navigation
{
    public partial class ucProductsNav : UserControl
    {
        private List<Product_DTO> _products = new List<Product_DTO>();

        public ucProductsNav()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void ucProductsNav_Load(object sender, EventArgs e)
        {
            cbProductsFilter.SelectedIndex = 0;
            await _LoadAllProducts();

        }

        private async Task _LoadAllProducts()
        {
            _products = await clsProducts.GetAllProducts();
            dgvProducts.DataSource = _products;

            lblTotalProducts.Text = _products.Count.ToString();
            int _inStock = await clsProducts.GetTotalProductsInStock();
            int _lowStock = await clsProducts.GetTotalProductsLowStock();

            lblInStock.Text = _inStock.ToString();
            lblLowStock.Text = _lowStock.ToString();
            lblDGVCount.Text = "#" + _products.Count.ToString();
        }

        private async void cbProductsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //None
            //In Stock
            //Out of Stock
            //Low Stock
            switch (cbProductsFilter.SelectedIndex)
            {
                case 0:
                    _products = await clsProducts.GetAllProducts();
                    break;
                case 1:
                    _products = await clsProducts.GetInStockProducts();
                    break;

                case 2:
                    _products = await clsProducts.GetOutOfStockProducts();
                    break;

                case 3:
                    _products = await clsProducts.GetLowStockProducts();
                    break;

            }
            lblDGVCount.Text = "#" + _products.Count.ToString();
            dgvProducts.DataSource = _products;
        }

        private int _GetSelectedProductID()
        {
            return (int)dgvProducts.SelectedRows[0].Cells[0].Value;
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteAnswer = MessageBox.Show(
        "Are you sure you want to permanently delete this product?",
        "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (deleteAnswer == DialogResult.Yes)
            {
                if (await clsProducts.DeleteProductByID(_GetSelectedProductID()))
                {
                    PUtilities.ShowNot(
                        "Product Deleted",
                        "The product has been removed successfully.",
                        3f
                    );
                    await _LoadAllProducts();
                }
                else
                {
                    PUtilities.ShowNot(
                        "Delete Failed",
                        "Unable to delete the product. It may be linked to existing sales records.",
                        4f,
                        red: true
                    );
                }
            }
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddEditProduct frm = new frmAddEditProduct();
            frm.OnProductAddedOrUpdated += Frm_OnProductAddedOrEdited;
            frm.ShowDialog();

        }

        private async void Frm_OnProductAddedOrEdited()
        {
            cbProductsFilter.SelectedIndex = 0;
            await _LoadAllProducts();
        }

        private void edittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count != 0)
            {
                frmAddEditProduct frm = new frmAddEditProduct(_GetSelectedProductID());
                frm.OnProductAddedOrUpdated += Frm_OnProductAddedOrEdited;
                frm.ShowDialog();
            }
        }
    }
}
