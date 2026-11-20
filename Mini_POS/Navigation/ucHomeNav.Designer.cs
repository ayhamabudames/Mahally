namespace Mini_POS.Navigation
{
    partial class ucHomeNav
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.container = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.pnStock = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.btnPrevious = new MyCustomControls.AyhamButton();
            this.btnNext = new MyCustomControls.AyhamButton();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tsCamera = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblblbl = new System.Windows.Forms.Label();
            this.cbCameras = new Guna.UI2.WinForms.Guna2ComboBox();
            this.picBarcode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayment = new MyCustomControls.AyhamButton();
            this.btnClear = new System.Windows.Forms.Label();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlCartContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.flpCart = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new MyCustomControls.AyhamButton();
            this.tbSearchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.tsOpenInvoice = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.pnStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSideMenu.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.pnlCartContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.BorderRadius = 8;
            this.container.Controls.Add(this.pnStock);
            this.container.Controls.Add(this.btnPrevious);
            this.container.Controls.Add(this.btnNext);
            this.container.Controls.Add(this.flpProducts);
            this.container.Controls.Add(this.pnlSideMenu);
            this.container.Controls.Add(this.btnSearch);
            this.container.Controls.Add(this.tbSearchInput);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1551, 1024);
            this.container.TabIndex = 0;
            this.container.Text = "guna2ContainerControl1";
            // 
            // pnStock
            // 
            this.pnStock.BorderRadius = 4;
            this.pnStock.Controls.Add(this.pictureBox1);
            this.pnStock.Controls.Add(this.lblTotalProducts);
            this.pnStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnStock.Location = new System.Drawing.Point(39, 37);
            this.pnStock.Name = "pnStock";
            this.pnStock.Size = new System.Drawing.Size(171, 48);
            this.pnStock.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mini_POS.Properties.Resources.stock;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.White;
            this.lblTotalProducts.Location = new System.Drawing.Point(47, 5);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(123, 34);
            this.lblTotalProducts.TabIndex = 30;
            this.lblTotalProducts.Text = "[15/500]";
            this.lblTotalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnPrevious.BorderRadius = 5;
            this.btnPrevious.BorderThickness = 2;
            this.btnPrevious.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.AcceptOutline;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FillColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(966, 53);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(89, 32);
            this.btnPrevious.TabIndex = 26;
            this.btnPrevious.Text = "Prev";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnNext.BorderRadius = 5;
            this.btnNext.BorderThickness = 2;
            this.btnNext.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.AcceptOutline;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1076, 53);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 32);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.Location = new System.Drawing.Point(39, 91);
            this.flpProducts.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Size = new System.Drawing.Size(1126, 922);
            this.flpProducts.TabIndex = 25;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BorderRadius = 8;
            this.pnlSideMenu.Controls.Add(this.guna2Panel1);
            this.pnlSideMenu.Controls.Add(this.lblTotalAmount);
            this.pnlSideMenu.Controls.Add(this.label1);
            this.pnlSideMenu.Controls.Add(this.btnPayment);
            this.pnlSideMenu.Controls.Add(this.btnClear);
            this.pnlSideMenu.Controls.Add(this.picProductImage);
            this.pnlSideMenu.Controls.Add(this.lblCartTitle);
            this.pnlSideMenu.Controls.Add(this.pnlCartContainer);
            this.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlSideMenu.Location = new System.Drawing.Point(1204, 13);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(327, 1000);
            this.pnlSideMenu.TabIndex = 14;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 4;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.tsOpenInvoice);
            this.guna2Panel1.Controls.Add(this.tsCamera);
            this.guna2Panel1.Controls.Add(this.lblblbl);
            this.guna2Panel1.Controls.Add(this.cbCameras);
            this.guna2Panel1.Controls.Add(this.picBarcode);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.guna2Panel1.Location = new System.Drawing.Point(9, 832);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(310, 150);
            this.guna2Panel1.TabIndex = 35;
            // 
            // tsCamera
            // 
            this.tsCamera.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tsCamera.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.tsCamera.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsCamera.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsCamera.Location = new System.Drawing.Point(142, 117);
            this.tsCamera.Name = "tsCamera";
            this.tsCamera.Size = new System.Drawing.Size(44, 23);
            this.tsCamera.TabIndex = 43;
            this.tsCamera.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsCamera.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tsCamera.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsCamera.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsCamera.CheckedChanged += new System.EventHandler(this.tsCamera_CheckedChanged);
            // 
            // lblblbl
            // 
            this.lblblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblbl.ForeColor = System.Drawing.Color.White;
            this.lblblbl.Location = new System.Drawing.Point(202, 117);
            this.lblblbl.Name = "lblblbl";
            this.lblblbl.Size = new System.Drawing.Size(93, 20);
            this.lblblbl.TabIndex = 42;
            this.lblblbl.Text = "Cam Off";
            this.lblblbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblblbl.Click += new System.EventHandler(this.lblBarcodeCode_Click);
            // 
            // cbCameras
            // 
            this.cbCameras.BackColor = System.Drawing.Color.Transparent;
            this.cbCameras.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCameras.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCameras.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCameras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCameras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCameras.ItemHeight = 30;
            this.cbCameras.Location = new System.Drawing.Point(12, 101);
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.Size = new System.Drawing.Size(108, 36);
            this.cbCameras.TabIndex = 1;
            this.cbCameras.SelectedIndexChanged += new System.EventHandler(this.cbCameras_SelectedIndexChanged);
            // 
            // picBarcode
            // 
            this.picBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBarcode.BorderRadius = 4;
            this.picBarcode.FillColor = System.Drawing.Color.Transparent;
            this.picBarcode.Image = global::Mini_POS.Properties.Resources.tex4;
            this.picBarcode.ImageRotate = 0F;
            this.picBarcode.Location = new System.Drawing.Point(20, 12);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(275, 67);
            this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarcode.TabIndex = 0;
            this.picBarcode.TabStop = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(206, 699);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(98, 49);
            this.lblTotalAmount.TabIndex = 41;
            this.lblTotalAmount.Text = "$0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 49);
            this.label1.TabIndex = 39;
            this.label1.Text = "Total ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPayment
            // 
            this.btnPayment.BackgroundImage = global::Mini_POS.Properties.Resources.tex3;
            this.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayment.BorderColor = System.Drawing.Color.Transparent;
            this.btnPayment.BorderRadius = 10;
            this.btnPayment.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.Accept;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.FillColor = System.Drawing.Color.Transparent;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(21, 756);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(295, 54);
            this.btnPayment.TabIndex = 38;
            this.btnPayment.Text = "Payment";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClear.Location = new System.Drawing.Point(265, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 22);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picProductImage
            // 
            this.picProductImage.BackColor = System.Drawing.Color.Transparent;
            this.picProductImage.Image = global::Mini_POS.Properties.Resources.cart;
            this.picProductImage.Location = new System.Drawing.Point(10, 16);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(50, 50);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductImage.TabIndex = 36;
            this.picProductImage.TabStop = false;
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTitle.ForeColor = System.Drawing.Color.White;
            this.lblCartTitle.Location = new System.Drawing.Point(66, 17);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(201, 49);
            this.lblCartTitle.TabIndex = 35;
            this.lblCartTitle.Text = "Customer Order";
            this.lblCartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCartContainer
            // 
            this.pnlCartContainer.BorderRadius = 4;
            this.pnlCartContainer.Controls.Add(this.flpCart);
            this.pnlCartContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.pnlCartContainer.Location = new System.Drawing.Point(9, 78);
            this.pnlCartContainer.Name = "pnlCartContainer";
            this.pnlCartContainer.Size = new System.Drawing.Size(310, 613);
            this.pnlCartContainer.TabIndex = 34;
            // 
            // flpCart
            // 
            this.flpCart.AutoScroll = true;
            this.flpCart.BackColor = System.Drawing.Color.Transparent;
            this.flpCart.Location = new System.Drawing.Point(0, 3);
            this.flpCart.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flpCart.Name = "flpCart";
            this.flpCart.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flpCart.Size = new System.Drawing.Size(307, 607);
            this.flpCart.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 25;
            this.btnSearch.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.Accept;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Mini_POS.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(816, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 50);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchInput
            // 
            this.tbSearchInput.BackColor = System.Drawing.Color.Transparent;
            this.tbSearchInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbSearchInput.BorderRadius = 8;
            this.tbSearchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchInput.DefaultText = "";
            this.tbSearchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tbSearchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbSearchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchInput.Location = new System.Drawing.Point(346, 13);
            this.tbSearchInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearchInput.Name = "tbSearchInput";
            this.tbSearchInput.PlaceholderText = "Search Product";
            this.tbSearchInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSearchInput.SelectedText = "";
            this.tbSearchInput.Size = new System.Drawing.Size(463, 50);
            this.tbSearchInput.TabIndex = 23;
            // 
            // tsOpenInvoice
            // 
            this.tsOpenInvoice.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tsOpenInvoice.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.tsOpenInvoice.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsOpenInvoice.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsOpenInvoice.Location = new System.Drawing.Point(142, 87);
            this.tsOpenInvoice.Name = "tsOpenInvoice";
            this.tsOpenInvoice.Size = new System.Drawing.Size(44, 23);
            this.tsOpenInvoice.TabIndex = 44;
            this.tsOpenInvoice.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsOpenInvoice.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tsOpenInvoice.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsOpenInvoice.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(192, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Open Invoice";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucHomeNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.container);
            this.Name = "ucHomeNav";
            this.Size = new System.Drawing.Size(1551, 1024);
            this.Load += new System.EventHandler(this.ucHomeNav_Load);
            this.container.ResumeLayout(false);
            this.pnStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSideMenu.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.pnlCartContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl container;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchInput;
        private MyCustomControls.AyhamButton btnSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlSideMenu;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private MyCustomControls.AyhamButton btnPrevious;
        private MyCustomControls.AyhamButton btnNext;
        private System.Windows.Forms.Label lblTotalProducts;
        private Guna.UI2.WinForms.Guna2Panel pnStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpCart;
        private Guna.UI2.WinForms.Guna2Panel pnlCartContainer;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Label btnClear;
        private MyCustomControls.AyhamButton btnPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picBarcode;
        private Guna.UI2.WinForms.Guna2ComboBox cbCameras;
        private System.Windows.Forms.Label lblblbl;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsCamera;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsOpenInvoice;
        private System.Windows.Forms.Label label2;
    }
}
