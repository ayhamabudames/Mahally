using Bll;
using DTO;
using Mini_POS.Product.controls;
using Mini_POS.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Bll.Utilities;

namespace Mini_POS.Navigation
{
    public partial class ucHomeNav : UserControl
    {
        //pagination
        int _currentPage = 1;
        int _pageRowsNumber = 20;
        int _totalProducts = 0;
        //cart
        decimal _totalAmount = 0;
        List<Product_DTO> _cartItems = new List<Product_DTO>();
        List<ucCartItemCard> _cartItemsCards = new List<ucCartItemCard>();
        //barcode
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public ucHomeNav()
        {
            InitializeComponent();
        }

        private async void ucHomeNav_Load(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.FormClosed += ParentForm_FormClosed;
            }
            LoadProducts();
            _InitBarcode();
        }

        private void ParentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void _InitBarcode()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in filterInfoCollection)
            {
                cbCameras.Items.Add(item.Name);
            }
            cbCameras.SelectedIndex = 1;
        }

        private async void LoadProducts()
        {
            // Load products for the current page
            flpProducts.Controls.Clear();
            _totalProducts = await clsProducts.GetProductsCount();
            var products = (string.IsNullOrEmpty(tbSearchInput.Text)) ?
                await clsProducts.GetAllProductsPagination(_currentPage, _pageRowsNumber) :
                await clsProducts.SearchProductsPagination(_currentPage, _pageRowsNumber, tbSearchInput.Text.Trim());

            foreach (Product_DTO p in products)
            {
                ucProductItemCard product = new ucProductItemCard(p);
                product.AddToCartClicked += Product_AddToCartClicked;
                flpProducts.Controls.Add(product);
            }

            if (_currentPage > 1)
            {
                btnPrevious.Enabled = true;
            }
            else
            {
                btnPrevious.Enabled = false;
            }

            lblTotalProducts.Text = $"{_currentPage * _pageRowsNumber} / {_totalProducts}";
        }

        private bool _IsItemExistInCart(int productID)
        {
            foreach (var item in _cartItems)
            {
                if (item.ProductID == productID)
                {
                    return true;
                }
            }
            return false;
        }

        private void _CalculateTotalAmount()
        {
            _totalAmount = 0;
            foreach (ucCartItemCard item in _cartItemsCards)
            {
                _totalAmount += (item.Quantity * item.UnitPrice);
            }
            lblTotalAmount.Text = _totalAmount.ToString("C2");
        }

        private void Product_AddToCartClicked(object sender, Product_DTO cardItem)
        {
            if (_IsItemExistInCart(cardItem.ProductID))
            {
                return;
            }
            //if not exist in the cart
            _cartItems.Add(cardItem);
            ucCartItemCard cartItemCard = new ucCartItemCard(cardItem);
            cartItemCard.ItemRemoved += CartItem_ItemRemoved;
            cartItemCard.QuantityChanged += CartItemCard_QuantityChanged;
            flpCart.Controls.Add(cartItemCard);
            _cartItemsCards.Add(cartItemCard);
            _CalculateTotalAmount();
        }

        private void CartItemCard_QuantityChanged(object sender, int e)
        {
            _CalculateTotalAmount();
        }

        private void CartItem_ItemRemoved(object sender, int productID)
        {
            _cartItems.RemoveAll(item => item.ProductID == productID);
            _cartItemsCards.RemoveAll(item => item.ProductID == productID);
            flpCart.Controls.Clear();
            foreach (var item in _cartItems)
            {
                ucCartItemCard cartItem = new ucCartItemCard(item);
                cartItem.ItemRemoved += CartItem_ItemRemoved;
                flpCart.Controls.Add(cartItem);
            }
            _CalculateTotalAmount();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            // Enable or disable the Next button based on whether there are more products to load
            if (_currentPage >= (_totalProducts / _pageRowsNumber) && (_totalProducts % _pageRowsNumber) == 0)
            {
                btnNext.Enabled = false;
            }
            else
            {
                _currentPage++;
                btnNext.Enabled = true;
            }
            this.ucHomeNav_Load(null, null);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1 && _currentPage != 1)
            {
                _currentPage--;
                this.ucHomeNav_Load(null, null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            this.LoadProducts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            flpCart.Controls.Clear();
            _cartItems.Clear();
            _totalAmount = 0;
            lblTotalAmount.Text = _totalAmount.ToString("C2");
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            if (_cartItemsCards == null || _cartItemsCards.Count == 0)
            {
                PUtilities.ShowNot(
    "Warning",
    "The cart is currently empty! Please add products to complete the sale.",
    3f,
    red: true
);
                return;
            }

            btnPayment.Enabled = false;
            List<Item_DTO> items = new List<Item_DTO>();

            foreach (var i in _cartItemsCards)
            {
                items.Add(new Item_DTO()
                {
                    ProductID = i.ProductID,
                    UnitPrice = i.UnitPrice,
                    Quantity = i.Quantity
                });
            }

            try
            {
                if (await clsSell.InvoiceSell(items))
                {
                    //TODO: Message 
                    PUtilities.PlaySFX("cash_money.wav");
                    _PrintInvoice();
                    this.btnClear_Click(null, null);
                    ucHomeNav_Load(null, null);
                    PUtilities.ShowNot("Success", "Transaction completed and invoice generated successfully!", 5f);
                }
                else
                {
                    PUtilities.ShowNot(
    "Transaction Failed",
    "Unable to complete the sale! Please check stock availability and try again.",
    3.5f,
    red: true
);
                }
            }
            catch (Exception ex)
            {
                PUtilities.ShowNot(
     "System Error",
     $"An unexpected error occurred while processing the invoice: {ex.Message}",
     4f,
     red: true
 );
            }
            finally
            {
                btnPayment.Enabled = true;
            }
        }

        private void lblBarcodeCode_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCameras.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private async void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);

            if (result != null)
            {
                lblblbl.Invoke(new MethodInvoker(async delegate ()
                {
                    //barcode scanned
                    if (lblblbl.Text != result.ToString())
                    {
                        Product_DTO product = await clsProducts.GetProductByBarcode(result.ToString());
                        if (product != null)
                        {
                            Product_AddToCartClicked(this, product);
                            PUtilities.PlaySFX("scanner_beep.wav");
                        }
                    }
                }));
            }
            picBarcode.Image = bitmap;
        }

        private void cbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCameras.SelectedIndex].MonikerString);
        }

        private void tsCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (tsCamera.Checked)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCameras.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                lblblbl.Text = "Cam On";

            }
            else
            {

                if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    lblblbl.Text = "Cam Off";
                    picBarcode.Image = Properties.Resources.tex4;
                }
            }
        }

        private void _PrintInvoice()
        {
            Document doc = new Document();
            string invoicePath = $@"{PUtilities.invoicePath}Invoice_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc
                , new FileStream(invoicePath
                , FileMode.Create));
            doc.Open();

            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font arabicFont = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font arabicHeaderFont = new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLD);

            string logoPath = PUtilities.logoPath;
            if (File.Exists(logoPath))
            {
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(logoPath);
                img.ScaleToFit(200f, 200f);
                img.Alignment = Element.ALIGN_CENTER;
                doc.Add(img);
            }

            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL; 
            table.SetWidths(new float[] { 2f, 2f, 5f });

            PdfPCell hName = new PdfPCell(new Phrase("المنتج", arabicHeaderFont)) { RunDirection = PdfWriter.RUN_DIRECTION_RTL, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 };
            PdfPCell hQty = new PdfPCell(new Phrase("الكمية", arabicHeaderFont)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 };
            PdfPCell hPrice = new PdfPCell(new Phrase("السعر", arabicHeaderFont)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 };
            table.AddCell(hName);
            table.AddCell(hQty);
            table.AddCell(hPrice);

            foreach (var item in _cartItemsCards)
            {
                PdfPCell cName = new PdfPCell(new Phrase(item.GG, arabicFont)) { RunDirection = PdfWriter.RUN_DIRECTION_RTL, Padding = 4 };
                PdfPCell cQty = new PdfPCell(new Phrase(item.Quantity.ToString(), arabicFont)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 };
                PdfPCell cPrice = new PdfPCell(new Phrase(item.UnitPrice.ToString("0.00") + " $", arabicFont)) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 4 };

                table.AddCell(cName);
                table.AddCell(cQty);
                table.AddCell(cPrice);
            }

            doc.Add(table);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

         
            Paragraph pTime = new Paragraph($"Time         : {DateTime.Now:yyyy-MM-dd_HH-mm-ss}");
            Paragraph pCashier = new Paragraph($"Cashier      : {clsGlobal.CurrentUser.Name}");
            Paragraph pTotalAmount = new Paragraph($"Total Amount : {lblTotalAmount.Text}");

            doc.Add(pTime);
            doc.Add(pCashier);
            doc.Add(pTotalAmount);
            if (tsOpenInvoice.Checked)
            {
                System.Diagnostics.Process.Start(invoicePath);
            }
            doc.Close();
        }
    }
}
