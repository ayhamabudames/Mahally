namespace Mini_POS.Product
{
    partial class frmAddEditProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCostPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbImageUrl = new Guna.UI2.WinForms.Guna2TextBox();
            this.numInStock = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numMinStock = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSave = new MyCustomControls.AyhamButton();
            this.btnCancel = new MyCustomControls.AyhamButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 16;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderRadius = 4;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Location = new System.Drawing.Point(351, 96);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(369, 36);
            this.cbCategory.TabIndex = 40;
            // 
            // tbProductName
            // 
            this.tbProductName.BackColor = System.Drawing.Color.Transparent;
            this.tbProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbProductName.BorderRadius = 4;
            this.tbProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbProductName.DefaultText = "";
            this.tbProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbProductName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tbProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbProductName.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tbProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbProductName.Location = new System.Drawing.Point(21, 90);
            this.tbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.PlaceholderText = "Product Name";
            this.tbProductName.SelectedText = "";
            this.tbProductName.Size = new System.Drawing.Size(212, 42);
            this.tbProductName.TabIndex = 41;
            // 
            // tbBarcode
            // 
            this.tbBarcode.BackColor = System.Drawing.Color.Transparent;
            this.tbBarcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbBarcode.BorderRadius = 4;
            this.tbBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBarcode.DefaultText = "";
            this.tbBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBarcode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tbBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBarcode.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tbBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBarcode.Location = new System.Drawing.Point(21, 277);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.PlaceholderText = "Barcode";
            this.tbBarcode.SelectedText = "";
            this.tbBarcode.Size = new System.Drawing.Size(212, 42);
            this.tbBarcode.TabIndex = 42;
            this.tbBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyNumbers_KeyPress);
            // 
            // tbSellPrice
            // 
            this.tbSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.tbSellPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbSellPrice.BorderRadius = 4;
            this.tbSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSellPrice.DefaultText = "";
            this.tbSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tbSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellPrice.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tbSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellPrice.Location = new System.Drawing.Point(21, 218);
            this.tbSellPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbSellPrice.Name = "tbSellPrice";
            this.tbSellPrice.PlaceholderText = "Sell Price";
            this.tbSellPrice.SelectedText = "";
            this.tbSellPrice.Size = new System.Drawing.Size(212, 42);
            this.tbSellPrice.TabIndex = 43;
            this.tbSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyDecimal_KeyPress);
            // 
            // tbCostPrice
            // 
            this.tbCostPrice.BackColor = System.Drawing.Color.Transparent;
            this.tbCostPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbCostPrice.BorderRadius = 4;
            this.tbCostPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCostPrice.DefaultText = "";
            this.tbCostPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCostPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCostPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCostPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCostPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tbCostPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCostPrice.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tbCostPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCostPrice.Location = new System.Drawing.Point(21, 153);
            this.tbCostPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostPrice.Name = "tbCostPrice";
            this.tbCostPrice.PlaceholderText = "Cost Price";
            this.tbCostPrice.SelectedText = "";
            this.tbCostPrice.Size = new System.Drawing.Size(212, 42);
            this.tbCostPrice.TabIndex = 44;
            this.tbCostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOnlyDecimal_KeyPress);
            // 
            // tbImageUrl
            // 
            this.tbImageUrl.BackColor = System.Drawing.Color.Transparent;
            this.tbImageUrl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tbImageUrl.BorderRadius = 4;
            this.tbImageUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbImageUrl.DefaultText = "";
            this.tbImageUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbImageUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbImageUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbImageUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbImageUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.tbImageUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbImageUrl.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tbImageUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbImageUrl.Location = new System.Drawing.Point(261, 275);
            this.tbImageUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbImageUrl.Name = "tbImageUrl";
            this.tbImageUrl.PlaceholderText = "Image Url";
            this.tbImageUrl.SelectedText = "";
            this.tbImageUrl.Size = new System.Drawing.Size(242, 42);
            this.tbImageUrl.TabIndex = 45;
            this.tbImageUrl.TextChanged += new System.EventHandler(this.tbImageUrl_TextChanged);
            // 
            // numInStock
            // 
            this.numInStock.BackColor = System.Drawing.Color.Transparent;
            this.numInStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numInStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.numInStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numInStock.ForeColor = System.Drawing.Color.White;
            this.numInStock.Location = new System.Drawing.Point(351, 157);
            this.numInStock.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numInStock.Name = "numInStock";
            this.numInStock.Size = new System.Drawing.Size(100, 36);
            this.numInStock.TabIndex = 46;
            this.numInStock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            // 
            // numMinStock
            // 
            this.numMinStock.BackColor = System.Drawing.Color.Transparent;
            this.numMinStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numMinStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.numMinStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numMinStock.ForeColor = System.Drawing.Color.White;
            this.numMinStock.Location = new System.Drawing.Point(351, 224);
            this.numMinStock.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numMinStock.Name = "numMinStock";
            this.numMinStock.Size = new System.Drawing.Size(100, 36);
            this.numMinStock.TabIndex = 47;
            this.numMinStock.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 48;
            this.label1.Text = "In Stock : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 34);
            this.label2.TabIndex = 49;
            this.label2.Text = "Min Stock : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(257, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 34);
            this.label3.TabIndex = 50;
            this.label3.Text = "Category : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddSave
            // 
            this.btnAddSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSave.BorderRadius = 5;
            this.btnAddSave.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.Accept;
            this.btnAddSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAddSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddSave.ForeColor = System.Drawing.Color.White;
            this.btnAddSave.Location = new System.Drawing.Point(540, 353);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(180, 45);
            this.btnAddSave.TabIndex = 51;
            this.btnAddSave.Text = "Add";
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.CancelOutline;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(351, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(78, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 34);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Add New Product";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Mini_POS.Properties.Resources.products;
            this.pictureBox3.Location = new System.Drawing.Point(20, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // picProduct
            // 
            this.picProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Image = global::Mini_POS.Properties.Resources.image;
            this.picProduct.Location = new System.Drawing.Point(540, 138);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(180, 180);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 13;
            this.picProduct.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Mini_POS.Properties.Resources.cross;
            this.btnClose.Location = new System.Drawing.Point(710, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(747, 410);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMinStock);
            this.Controls.Add(this.numInStock);
            this.Controls.Add(this.tbImageUrl);
            this.Controls.Add(this.tbCostPrice);
            this.Controls.Add(this.tbSellPrice);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditProduct";
            this.Load += new System.EventHandler(this.frmAddEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox picProduct;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2TextBox tbProductName;
        private Guna.UI2.WinForms.Guna2NumericUpDown numMinStock;
        private Guna.UI2.WinForms.Guna2NumericUpDown numInStock;
        private Guna.UI2.WinForms.Guna2TextBox tbImageUrl;
        private Guna.UI2.WinForms.Guna2TextBox tbCostPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbSellPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MyCustomControls.AyhamButton btnCancel;
        private MyCustomControls.AyhamButton btnAddSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}