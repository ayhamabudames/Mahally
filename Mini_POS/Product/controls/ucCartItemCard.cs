using DTO;
using Mini_POS.Utilities;
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
    public partial class ucCartItemCard : UserControl
    {
        //add quantity event
        public event EventHandler<int> QuantityChanged;
        //remove item event
        public event EventHandler<int> ItemRemoved;
        private Product_DTO _product = null;
        private int _quantity = 1;
        public int Quantity
        {
            get { return _quantity; }
        }
        public decimal UnitPrice
        {
            get { return _product.SellPrice; }
        }

        public string GG
        {
            get { return _product != null ? _product.Name : string.Empty; }
        }

        public int ProductID { get { return _product.ProductID; } }

        public ucCartItemCard(Product_DTO product)
        {
            InitializeComponent();
            _product = product;
        }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            if (_product.InStock > _quantity)
            {
                _quantity++;
                lblQuantity.Text = _quantity.ToString();
                QuantityChanged?.Invoke(this, _quantity);
            }
            else
            {
                PUtilities.ShowNot("Out Stock",
                    $"{_product.Name} is out of stock,Invoice the manager to restock it!", 1.5f, true);
            }
            //TODO: Show message that the product is out of stock

        }

        private void btnMinusQuantity_Click(object sender, EventArgs e)
        {
            if (_quantity > 1)
            {
                _quantity--;
                lblQuantity.Text = _quantity.ToString();
                QuantityChanged?.Invoke(this, _quantity);
            }
        }

        private void ucCartItemCard_Load(object sender, EventArgs e)
        {
            lblProductName.Text = _product.Name;
            lblProductPrice.Text = _product.SellPrice.ToString("C2");

            try
            {
                picProductImage.LoadAsync(_product.ImageUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            ItemRemoved?.Invoke(this, _product.ProductID);
        }
    }
}
