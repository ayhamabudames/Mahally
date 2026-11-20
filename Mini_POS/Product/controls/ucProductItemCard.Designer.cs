namespace Mini_POS.Product.controls
{
    partial class ucProductItemCard
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
            this.lblStock = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAdd = new MyCustomControls.AyhamButton();
            this.picProductImage = new System.Windows.Forms.PictureBox();
            this.container.SuspendLayout();
            this.pnStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BorderRadius = 4;
            this.container.Controls.Add(this.pnStock);
            this.container.Controls.Add(this.lblProductPrice);
            this.container.Controls.Add(this.lblProductName);
            this.container.Controls.Add(this.btnAdd);
            this.container.Controls.Add(this.picProductImage);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(200, 200);
            this.container.TabIndex = 0;
            this.container.Text = "guna2ContainerControl1";
            // 
            // pnStock
            // 
            this.pnStock.BorderRadius = 4;
            this.pnStock.Controls.Add(this.pictureBox1);
            this.pnStock.Controls.Add(this.lblStock);
            this.pnStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnStock.Location = new System.Drawing.Point(5, 12);
            this.pnStock.Name = "pnStock";
            this.pnStock.Size = new System.Drawing.Size(38, 70);
            this.pnStock.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mini_POS.Properties.Resources.stock;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(-3, 41);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(48, 23);
            this.lblStock.TabIndex = 32;
            this.lblStock.Text = "100+";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.LightGray;
            this.lblProductPrice.Location = new System.Drawing.Point(14, 159);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(125, 23);
            this.lblProductPrice.TabIndex = 30;
            this.lblProductPrice.Text = "$150";
            this.lblProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(3, 124);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(194, 23);
            this.lblProductName.TabIndex = 29;
            this.lblProductName.Text = "[Product Name]";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.Accept;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Mini_POS.Properties.Resources.add;
            this.btnAdd.ImageSize = new System.Drawing.Size(15, 15);
            this.btnAdd.Location = new System.Drawing.Point(145, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picProductImage
            // 
            this.picProductImage.BackColor = System.Drawing.Color.Transparent;
            this.picProductImage.Image = global::Mini_POS.Properties.Resources.logo_no_bg;
            this.picProductImage.Location = new System.Drawing.Point(49, 12);
            this.picProductImage.Name = "picProductImage";
            this.picProductImage.Size = new System.Drawing.Size(100, 100);
            this.picProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProductImage.TabIndex = 26;
            this.picProductImage.TabStop = false;
            // 
            // ucProductItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.container);
            this.Name = "ucProductItemCard";
            this.Size = new System.Drawing.Size(200, 200);
            this.container.ResumeLayout(false);
            this.pnStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl container;
        private MyCustomControls.AyhamButton btnAdd;
        private System.Windows.Forms.PictureBox picProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblStock;
        private Guna.UI2.WinForms.Guna2Panel pnStock;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
