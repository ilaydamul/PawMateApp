namespace PawMateApp
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.ProfileButton = new System.Windows.Forms.Button();
            this.btn_showBlogCategories = new System.Windows.Forms.Button();
            this.btn_showMyBlogs = new System.Windows.Forms.Button();
            this.btn_showFriends = new System.Windows.Forms.Button();
            this.btn_showNotifications = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.topMenuPanel = new System.Windows.Forms.Panel();
            this.btn_minimizeApp = new System.Windows.Forms.PictureBox();
            this.btn_closeApp = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.topMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeApp)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileButton.Location = new System.Drawing.Point(8, 354);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(175, 36);
            this.ProfileButton.TabIndex = 15;
            this.ProfileButton.Text = "      Profilimi Görüntüle";
            this.ProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // btn_showBlogCategories
            // 
            this.btn_showBlogCategories.BackColor = System.Drawing.Color.White;
            this.btn_showBlogCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_showBlogCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_showBlogCategories.FlatAppearance.BorderSize = 0;
            this.btn_showBlogCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showBlogCategories.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showBlogCategories.Image = ((System.Drawing.Image)(resources.GetObject("btn_showBlogCategories.Image")));
            this.btn_showBlogCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showBlogCategories.Location = new System.Drawing.Point(8, 63);
            this.btn_showBlogCategories.Name = "btn_showBlogCategories";
            this.btn_showBlogCategories.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_showBlogCategories.Size = new System.Drawing.Size(175, 42);
            this.btn_showBlogCategories.TabIndex = 11;
            this.btn_showBlogCategories.Text = "İlanlar";
            this.btn_showBlogCategories.UseVisualStyleBackColor = false;
            this.btn_showBlogCategories.Click += new System.EventHandler(this.btn_showBlogCategories_Click);
            // 
            // btn_showMyBlogs
            // 
            this.btn_showMyBlogs.BackColor = System.Drawing.Color.White;
            this.btn_showMyBlogs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_showMyBlogs.FlatAppearance.BorderSize = 0;
            this.btn_showMyBlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showMyBlogs.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_showMyBlogs.Image = ((System.Drawing.Image)(resources.GetObject("btn_showMyBlogs.Image")));
            this.btn_showMyBlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showMyBlogs.Location = new System.Drawing.Point(8, 111);
            this.btn_showMyBlogs.Name = "btn_showMyBlogs";
            this.btn_showMyBlogs.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_showMyBlogs.Size = new System.Drawing.Size(175, 42);
            this.btn_showMyBlogs.TabIndex = 12;
            this.btn_showMyBlogs.Text = "İlanlarım";
            this.btn_showMyBlogs.UseVisualStyleBackColor = false;
            // 
            // btn_showFriends
            // 
            this.btn_showFriends.BackColor = System.Drawing.Color.White;
            this.btn_showFriends.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_showFriends.FlatAppearance.BorderSize = 0;
            this.btn_showFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showFriends.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_showFriends.Image = ((System.Drawing.Image)(resources.GetObject("btn_showFriends.Image")));
            this.btn_showFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showFriends.Location = new System.Drawing.Point(8, 159);
            this.btn_showFriends.Name = "btn_showFriends";
            this.btn_showFriends.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_showFriends.Size = new System.Drawing.Size(175, 42);
            this.btn_showFriends.TabIndex = 13;
            this.btn_showFriends.Text = "Favorilerim";
            this.btn_showFriends.UseVisualStyleBackColor = false;
            // 
            // btn_showNotifications
            // 
            this.btn_showNotifications.BackColor = System.Drawing.Color.White;
            this.btn_showNotifications.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_showNotifications.FlatAppearance.BorderSize = 0;
            this.btn_showNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showNotifications.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_showNotifications.Image = ((System.Drawing.Image)(resources.GetObject("btn_showNotifications.Image")));
            this.btn_showNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showNotifications.Location = new System.Drawing.Point(8, 207);
            this.btn_showNotifications.Name = "btn_showNotifications";
            this.btn_showNotifications.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_showNotifications.Size = new System.Drawing.Size(175, 42);
            this.btn_showNotifications.TabIndex = 14;
            this.btn_showNotifications.Text = "Taleplerim";
            this.btn_showNotifications.UseVisualStyleBackColor = false;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.btn_logout);
            this.menuPanel.Controls.Add(this.logoBox);
            this.menuPanel.Controls.Add(this.btn_showNotifications);
            this.menuPanel.Controls.Add(this.btn_showFriends);
            this.menuPanel.Controls.Add(this.btn_showMyBlogs);
            this.menuPanel.Controls.Add(this.ProfileButton);
            this.menuPanel.Controls.Add(this.btn_showBlogCategories);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(192, 450);
            this.menuPanel.TabIndex = 16;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(8, 396);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(175, 42);
            this.btn_logout.TabIndex = 17;
            this.btn_logout.Text = "Çıkış Yap";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(8, 9);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(175, 48);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 16;
            this.logoBox.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contentPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contentPanel.Location = new System.Drawing.Point(192, 26);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(608, 424);
            this.contentPanel.TabIndex = 17;
            // 
            // topMenuPanel
            // 
            this.topMenuPanel.BackColor = System.Drawing.Color.White;
            this.topMenuPanel.Controls.Add(this.btn_minimizeApp);
            this.topMenuPanel.Controls.Add(this.btn_closeApp);
            this.topMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topMenuPanel.Location = new System.Drawing.Point(192, 0);
            this.topMenuPanel.Name = "topMenuPanel";
            this.topMenuPanel.Size = new System.Drawing.Size(608, 26);
            this.topMenuPanel.TabIndex = 18;
            this.topMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenuPanel_MouseDown);
            // 
            // btn_minimizeApp
            // 
            this.btn_minimizeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_minimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizeApp.Image")));
            this.btn_minimizeApp.Location = new System.Drawing.Point(561, 1);
            this.btn_minimizeApp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizeApp.Name = "btn_minimizeApp";
            this.btn_minimizeApp.Size = new System.Drawing.Size(20, 24);
            this.btn_minimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizeApp.TabIndex = 9;
            this.btn_minimizeApp.TabStop = false;
            this.btn_minimizeApp.Click += new System.EventHandler(this.btn_minimizeApp_Click);
            this.btn_minimizeApp.MouseEnter += new System.EventHandler(this.btn_minimizeApp_MouseEnter);
            this.btn_minimizeApp.MouseLeave += new System.EventHandler(this.btn_minimizeApp_MouseLeave);
            // 
            // btn_closeApp
            // 
            this.btn_closeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_closeApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeApp.Image")));
            this.btn_closeApp.Location = new System.Drawing.Point(585, 1);
            this.btn_closeApp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_closeApp.Name = "btn_closeApp";
            this.btn_closeApp.Size = new System.Drawing.Size(21, 24);
            this.btn_closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_closeApp.TabIndex = 8;
            this.btn_closeApp.TabStop = false;
            this.btn_closeApp.Click += new System.EventHandler(this.btn_closeApp_Click);
            this.btn_closeApp.MouseEnter += new System.EventHandler(this.btn_closeApp_MouseEnter);
            this.btn_closeApp.MouseLeave += new System.EventHandler(this.btn_closeApp_MouseLeave);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topMenuPanel);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hone";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.topMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button btn_showBlogCategories;
        private System.Windows.Forms.Button btn_showMyBlogs;
        private System.Windows.Forms.Button btn_showFriends;
        private System.Windows.Forms.Button btn_showNotifications;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel topMenuPanel;
        private System.Windows.Forms.PictureBox btn_minimizeApp;
        private System.Windows.Forms.PictureBox btn_closeApp;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel contentPanel;
    }
}