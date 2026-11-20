using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_POS.Product.controls
{
    public partial class ucProductItemCard : UserControl
    {
        Product_DTO _product = null;
        //add event to handle add to cart button click
        public event EventHandler<Product_DTO> AddToCartClicked;
        public ucProductItemCard(Product_DTO product)
        {
            InitializeComponent();
            this._product = product;
            _BindData();
        }
        
        private void _BindData()
        {
            lblProductName.Text = _product.Name;
            lblProductPrice.Text = _product.SellPrice.ToString("C2");



            //stock
            if (_product.InStock <= _product.MinStockLevel)
            {
                pnStock.FillColor = Color.FromArgb(255, 56, 56);
            }
            lblStock.Text = (_product.InStock > 100) ? "100+" : _product.InStock.ToString();

            // Load the product image from the URL
            if (!string.IsNullOrWhiteSpace(_product.ImageUrl))
            {
                try
                {
                    picProductImage.LoadAsync(_product.ImageUrl);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image: {ex.Message}");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, _product);
        }
    }
}
