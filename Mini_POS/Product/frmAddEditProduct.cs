using Bll;
using DTO;
using Guna.UI2.WinForms;
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

namespace Mini_POS.Product
{
    public partial class frmAddEditProduct : Form
    {
        enum enMode { Add, Update }
        private enMode _Mode = enMode.Add;
        private int _productID = -1;
        private Product_DTO _product = new Product_DTO();
        private List<Category_DTO> categories = null;
        public event Action OnProductAddedOrUpdated;

        public frmAddEditProduct()
        {
            InitializeComponent();
        }

        public frmAddEditProduct(int productID)
        {
            InitializeComponent();
            _productID = productID;
            _Mode = enMode.Update;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            //load categories
            categories = await clsCategory.GetAllCategories();
            foreach (var item in categories)
            {
                cbCategory.Items.Add(item.Title);
            }
            cbCategory.SelectedIndex = 0;

            //if update
            if (_Mode == enMode.Update)
            {
                _LoadProductDataEditMode();
            }
        }

        private async void _LoadProductDataEditMode()
        {
            btnAddSave.Text = "Save";
            this.Text = lblTitle.Text = "Update Product";
            tbBarcode.Enabled = false;
            _product = await clsProducts.GetProductByID(_productID);
            if (_product == null)
            {
                PUtilities.ShowNot(
                    "Product Not Found",
                    $"No product found with ID: {_productID}. It may have been deleted.",
                    3.5f,
                    red: true
                );
                return;
            }
            tbBarcode.Text = _product.Barcode;
            tbProductName.Text = _product.Name;
            tbCostPrice.Text = _product.CostPrice.ToString();
            tbSellPrice.Text = _product.SellPrice.ToString();
            tbImageUrl.Text = _product.ImageUrl;
            numInStock.Value = _product.InStock;
            numMinStock.Value = _product.MinStockLevel;
            cbCategory.SelectedItem = categories.Find(item => item.CategoryID == _product.CategoryID)?.Title;

            try
            {
                picProduct.LoadAsync(tbImageUrl.Text.Trim());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Image load error : {ex.Message}");
            }
        }

        private void tbOnlyDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbImageUrl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                picProduct.LoadAsync(tbImageUrl.Text.Trim());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Image load error : {ex.Message}");
                picProduct.Image = Properties.Resources.image;
            }
        }

        private async void btnAddSave_Click(object sender, EventArgs e)
        {
            //validate inputs
            if (cbCategory.SelectedIndex == -1 ||
              string.IsNullOrWhiteSpace(tbBarcode.Text) ||
              string.IsNullOrWhiteSpace(tbProductName.Text) ||
              string.IsNullOrWhiteSpace(tbSellPrice.Text) ||
              string.IsNullOrWhiteSpace(tbCostPrice.Text) ||
              !decimal.TryParse(tbSellPrice.Text, out decimal sellPrice) ||
              !decimal.TryParse(tbCostPrice.Text, out decimal costPrice))
            {
                PUtilities.ShowNot(
                    "Validation Error",
                    "Please fill in all required fields with valid values (Image URL is optional).",
                    3.5f,
                    red: true
                );
                return;
            }

            if (await clsProducts.IsProductExistByBarocode(tbBarcode.Text.Trim()) && _Mode == enMode.Add)
            {
                PUtilities.ShowNot(
                    "Validation Error",
                    "Product with this barcode is already exists! Try use another barcode.",
                    3.5f,
                    red: true
                );
                return;
            }

            _product.CategoryID = categories[cbCategory.SelectedIndex].CategoryID;
            _product.Barcode = tbBarcode.Text.Trim();
            _product.Name = tbProductName.Text.Trim();
            _product.SellPrice = Convert.ToDecimal(tbSellPrice.Text);
            _product.CostPrice = Convert.ToDecimal(tbCostPrice.Text);
            _product.ImageUrl = tbImageUrl.Text.Trim();
            _product.InStock = Convert.ToInt32(numInStock.Value);
            _product.MinStockLevel = Convert.ToInt32(numMinStock.Value);

            if (_Mode == enMode.Update)
                _Update();
            else
                _Add();
        }

        private async void _Add()
        {
            int newProductID = await clsProducts.AddNewProduct(_product);

            if (newProductID != -1)
            {
                OnProductAddedOrUpdated?.Invoke();
                PUtilities.ShowNot(
                    "Product Added",
                    $"The product has been added successfully with ID: {newProductID}.",
                    3f
                );
                this.Close();
            }
            else
            {
                PUtilities.ShowNot(
                    "Add Failed",
                    "Unable to add the product. Please check the barcode or input values and try again.",
                    4f,
                    red: true
                );
            }
        }

        private async void _Update()
        {
            if (await clsProducts.UpdateProduct(_product))
            {
                PUtilities.ShowNot(
                    "Product Updated",
                    "The product details have been updated successfully.",
                    3f
                );
                OnProductAddedOrUpdated?.Invoke();
            }
            else
            {
                PUtilities.ShowNot(
                    "Update Failed",
                    "Unable to update the product. The barcode may already be in use or the input is invalid.",
                    4f,
                    red: true
                );
            }
        }

    }
}
