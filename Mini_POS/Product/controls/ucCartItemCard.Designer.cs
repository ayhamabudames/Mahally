namespace Mini_POS.Product.controls
{
    partial class ucCartItemCard
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnRemoveItem = new MyCustomControls.AyhamButton();
            this.btnMinusQuantity = new MyCustomControls.AyhamButton();
            this.btnAddQuantity = new MyCustomControls.AyhamButton();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BorderRadius = 4;
            this.container.Controls.Add(this.btnRemoveItem);
            this.container.Controls.Add(this.lblQuantity);
            this.container.Controls.Add(this.btnMinusQuantity);
            this.container.Controls.Add(this.btnAddQuantity);
            this.container.Controls.Add(this.lblProductPrice);
            this.container.Controls.Add(this.lblProductName);
            this.container.Controls.Add(this.picProductImage);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(299, 100);
            this.container.TabIndex = 0;
            this.container.Text = "guna2ContainerControl1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(205, 63);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(44, 23);
            this.lblQuantity.TabIndex = 38;
            this.lblQuantity.Text = "1";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblProductPrice.Location = new System.Drawing.Point(99, 37);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(125, 20);
            this.lblProductPrice.TabIndex = 35;
            this.lblProductPrice.Text = "$150";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(99, 10);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(174, 23);
            this.lblProductName.TabIndex = 34;
            this.lblProductName.Text = "[Product Name]";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnRemoveItem.BorderRadius = 5;
            this.btnRemoveItem.BorderThickness = 2;
            this.btnRemoveItem.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.CancelOutline;
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveItem.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Image = global::Mini_POS.Properties.Resources.minus;
            this.btnRemoveItem.ImageSize = new System.Drawing.Size(5, 5);
            this.btnRemoveItem.Location = new System.Drawing.Point(99, 70);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveItem.TabIndex = 39;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnMinusQuantity
            // 
            this.btnMinusQuantity.BorderColor = System.Drawing.Color.Transparent;
            this.btnMinusQuantity.BorderRadius = 10;
            this.btnMinusQuantity.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.Accept;
            this.btnMinusQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinusQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinusQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinusQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinusQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinusQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnMinusQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinusQuantity.ForeColor = System.Drawing.Color.White;
            this.btnMinusQuantity.Image = global::Mini_POS.Properties.Resources.minus;
            this.btnMinusQuantity.ImageSize = new System.Drawing.Size(7, 7);
            this.btnMinusQuantity.Location = new System.Drawing.Point(169, 60);
            this.btnMinusQuantity.Name = "btnMinusQuantity";
            this.btnMinusQuantity.Size = new System.Drawing.Size(30, 30);
            this.btnMinusQuantity.TabIndex = 37;
            this.btnMinusQuantity.Click += new System.EventHandler(this.btnMinusQuantity_Click);
            // 
            // btnAddQuantity
            // 
            this.btnAddQuantity.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddQuantity.BorderRadius = 10;
            this.btnAddQuantity.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.Accept;
            this.btnAddQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAddQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddQuantity.ForeColor = System.Drawing.Color.White;
            this.btnAddQuantity.Image = global::Mini_POS.Properties.Resources.add;
            this.btnAddQuantity.ImageSize = new System.Drawing.Size(7, 7);
            this.btnAddQuantity.Location = new System.Drawing.Point(255, 60);
            this.btnAddQuantity.Name = "btnAddQuantity";
            this.btnAddQuantity.Size = new System.Drawing.Size(30, 30);
            this.btnAddQuantity.TabIndex = 36;
            this.btnAddQuantity.Click += new System.EventHandler(this.btnAddQuantity_Click);
            // 
            // picProductImage
            // 
            this.picProductImage.BackColor = System.Drawing.Color.Transparent;
            this.picProductImage.Image = global::Mini_POS.Properties.Resources.logo_no_bg;
            this.picProductImage.Location = new System.Drawing.Point(13, 10);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(80, 80);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductImage.TabIndex = 33;
            this.picProductImage.TabStop = false;
            // 
            // ucCartItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.container);
            this.Name = "ucCartItemCard";
            this.Size = new System.Drawing.Size(299, 100);
            this.Load += new System.EventHandler(this.ucCartItemCard_Load);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl container;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox picProductImage;
        private MyCustomControls.AyhamButton btnAddQuantity;
        private MyCustomControls.AyhamButton btnMinusQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private MyCustomControls.AyhamButton btnRemoveItem;
    }
}
