namespace Mini_POS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLogedUserInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLogedInUserRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogednnUserFullName = new System.Windows.Forms.Label();
            this.pnlNotification = new Guna.UI2.WinForms.Guna2Panel();
            this.ucCurrentNav = new Mini_POS.Navigation.ucHomeNav();
            this.lblTitleNoti = new System.Windows.Forms.Label();
            this.lblContentNoti = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new MyCustomControls.AyhamButton();
            this.btnUsers = new MyCustomControls.AyhamButton();
            this.btnSettings = new MyCustomControls.AyhamButton();
            this.btnDahsboard = new MyCustomControls.AyhamButton();
            this.btnProducts = new MyCustomControls.AyhamButton();
            this.btnHome = new MyCustomControls.AyhamButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu.SuspendLayout();
            this.pnlLogedUserInfo.SuspendLayout();
            this.pnlNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BorderRadius = 8;
            this.pnlSideMenu.Controls.Add(this.pnlNotification);
            this.pnlSideMenu.Controls.Add(this.pnlLogedUserInfo);
            this.pnlSideMenu.Controls.Add(this.btnUsers);
            this.pnlSideMenu.Controls.Add(this.btnSettings);
            this.pnlSideMenu.Controls.Add(this.btnDahsboard);
            this.pnlSideMenu.Controls.Add(this.btnProducts);
            this.pnlSideMenu.Controls.Add(this.btnHome);
            this.pnlSideMenu.Controls.Add(this.pictureBox2);
            this.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.pnlSideMenu.Location = new System.Drawing.Point(21, 29);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(261, 1024);
            this.pnlSideMenu.TabIndex = 13;
            // 
            // pnlLogedUserInfo
            // 
            this.pnlLogedUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogedUserInfo.BorderRadius = 4;
            this.pnlLogedUserInfo.Controls.Add(this.pictureBox1);
            this.pnlLogedUserInfo.Controls.Add(this.lblLogedInUserRole);
            this.pnlLogedUserInfo.Controls.Add(this.label1);
            this.pnlLogedUserInfo.Controls.Add(this.lblLogednnUserFullName);
            this.pnlLogedUserInfo.Controls.Add(this.btnLogout);
            this.pnlLogedUserInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlLogedUserInfo.Location = new System.Drawing.Point(12, 933);
            this.pnlLogedUserInfo.Name = "pnlLogedUserInfo";
            this.pnlLogedUserInfo.Size = new System.Drawing.Size(235, 67);
            this.pnlLogedUserInfo.TabIndex = 20;
            // 
            // lblLogedInUserRole
            // 
            this.lblLogedInUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogedInUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblLogedInUserRole.Location = new System.Drawing.Point(100, 37);
            this.lblLogedInUserRole.Name = "lblLogedInUserRole";
            this.lblLogedInUserRole.Size = new System.Drawing.Size(63, 24);
            this.lblLogedInUserRole.TabIndex = 2;
            this.lblLogedInUserRole.Text = "[Role]";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role : ";
            // 
            // lblLogednnUserFullName
            // 
            this.lblLogednnUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogednnUserFullName.ForeColor = System.Drawing.Color.White;
            this.lblLogednnUserFullName.Location = new System.Drawing.Point(55, 11);
            this.lblLogednnUserFullName.Name = "lblLogednnUserFullName";
            this.lblLogednnUserFullName.Size = new System.Drawing.Size(178, 23);
            this.lblLogednnUserFullName.TabIndex = 0;
            this.lblLogednnUserFullName.Text = "User Full Name";
            // 
            // pnlNotification
            // 
            this.pnlNotification.BackColor = System.Drawing.Color.Transparent;
            this.pnlNotification.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlNotification.BorderRadius = 4;
            this.pnlNotification.BorderThickness = 2;
            this.pnlNotification.Controls.Add(this.pictureBox3);
            this.pnlNotification.Controls.Add(this.lblContentNoti);
            this.pnlNotification.Controls.Add(this.lblTitleNoti);
            this.pnlNotification.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.pnlNotification.Location = new System.Drawing.Point(12, 605);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(235, 196);
            this.pnlNotification.TabIndex = 22;
            this.pnlNotification.Visible = false;
            // 
            // ucCurrentNav
            // 
            this.ucCurrentNav.BackColor = System.Drawing.Color.Transparent;
            this.ucCurrentNav.Location = new System.Drawing.Point(326, 29);
            this.ucCurrentNav.Name = "ucCurrentNav";
            this.ucCurrentNav.Size = new System.Drawing.Size(1551, 1024);
            this.ucCurrentNav.TabIndex = 14;
            this.ucCurrentNav.Load += new System.EventHandler(this.ucCurrentNav_Load);
            // 
            // lblTitleNoti
            // 
            this.lblTitleNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNoti.ForeColor = System.Drawing.Color.White;
            this.lblTitleNoti.Location = new System.Drawing.Point(5, 11);
            this.lblTitleNoti.Name = "lblTitleNoti";
            this.lblTitleNoti.Size = new System.Drawing.Size(204, 23);
            this.lblTitleNoti.TabIndex = 0;
            this.lblTitleNoti.Text = "[Title]";
            this.lblTitleNoti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContentNoti
            // 
            this.lblContentNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentNoti.ForeColor = System.Drawing.Color.White;
            this.lblContentNoti.Location = new System.Drawing.Point(5, 43);
            this.lblContentNoti.Name = "lblContentNoti";
            this.lblContentNoti.Size = new System.Drawing.Size(227, 127);
            this.lblContentNoti.TabIndex = 1;
            this.lblContentNoti.Text = "[content]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Mini_POS.Properties.Resources.notification;
            this.pictureBox3.Location = new System.Drawing.Point(211, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mini_POS.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.BorderThickness = 2;
            this.btnLogout.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.CancelOutline;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Mini_POS.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(15, 15);
            this.btnLogout.Location = new System.Drawing.Point(199, 33);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(30, 30);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnUsers.BorderRadius = 5;
            this.btnUsers.BorderThickness = 2;
            this.btnUsers.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.AcceptOutline;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::Mini_POS.Properties.Resources.users;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(70, 70);
            this.btnUsers.Location = new System.Drawing.Point(13, 387);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(235, 51);
            this.btnUsers.TabIndex = 19;
            this.btnUsers.Tag = "users";
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSettings.BorderRadius = 5;
            this.btnSettings.BorderThickness = 2;
            this.btnSettings.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.AcceptOutline;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::Mini_POS.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageSize = new System.Drawing.Size(70, 70);
            this.btnSettings.Location = new System.Drawing.Point(13, 321);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(235, 51);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Tag = "settings";
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDahsboard
            // 
            this.btnDahsboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDahsboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnDahsboard.BorderRadius = 5;
            this.btnDahsboard.BorderThickness = 2;
            this.btnDahsboard.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.AcceptOutline;
            this.btnDahsboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDahsboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDahsboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDahsboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDahsboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDahsboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDahsboard.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDahsboard.ForeColor = System.Drawing.Color.White;
            this.btnDahsboard.Image = global::Mini_POS.Properties.Resources.dashboard;
            this.btnDahsboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDahsboard.ImageSize = new System.Drawing.Size(70, 70);
            this.btnDahsboard.Location = new System.Drawing.Point(12, 453);
            this.btnDahsboard.Name = "btnDahsboard";
            this.btnDahsboard.Size = new System.Drawing.Size(235, 51);
            this.btnDahsboard.TabIndex = 17;
            this.btnDahsboard.Tag = "dashboard";
            this.btnDahsboard.Text = "Dashboard";
            this.btnDahsboard.Click += new System.EventHandler(this.btnDahsboard_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnProducts.BorderRadius = 5;
            this.btnProducts.BorderThickness = 2;
            this.btnProducts.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.AcceptOutline;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducts.FillColor = System.Drawing.Color.Transparent;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::Mini_POS.Properties.Resources.products;
            this.btnProducts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProducts.ImageSize = new System.Drawing.Size(70, 70);
            this.btnProducts.Location = new System.Drawing.Point(12, 254);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(235, 51);
            this.btnProducts.TabIndex = 15;
            this.btnProducts.Tag = "products";
            this.btnProducts.Text = "Products";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 5;
            this.btnHome.ButtonStyle = MyCustomControls.AyhamButton.enButtonStyle.Accept;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Mini_POS.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(70, 70);
            this.btnHome.Location = new System.Drawing.Point(12, 188);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(235, 51);
            this.btnHome.TabIndex = 14;
            this.btnHome.Tag = "home";
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Mini_POS.Properties.Resources.logo_no_bg;
            this.pictureBox2.Location = new System.Drawing.Point(29, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Mini_POS.Properties.Resources.cross;
            this.btnClose.Location = new System.Drawing.Point(1883, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.ucCurrentNav);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini POS System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlLogedUserInfo.ResumeLayout(false);
            this.pnlNotification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnlSideMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MyCustomControls.AyhamButton btnHome;
        private MyCustomControls.AyhamButton btnProducts;
        private MyCustomControls.AyhamButton btnLogout;
        private MyCustomControls.AyhamButton btnDahsboard;
        private MyCustomControls.AyhamButton btnUsers;
        private MyCustomControls.AyhamButton btnSettings;
        private Guna.UI2.WinForms.Guna2Panel pnlLogedUserInfo;
        private System.Windows.Forms.Label lblLogedInUserRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogednnUserFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Navigation.ucHomeNav ucCurrentNav;
        private Guna.UI2.WinForms.Guna2Panel pnlNotification;
        private System.Windows.Forms.Label lblContentNoti;
        private System.Windows.Forms.Label lblTitleNoti;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}