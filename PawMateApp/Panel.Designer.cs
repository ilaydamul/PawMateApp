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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.businessPanel = new System.Windows.Forms.Panel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.btn_showUserManagement = new System.Windows.Forms.Button();
            this.btn_showBusinessManagement = new System.Windows.Forms.Button();
            this.btn_showNotifications = new System.Windows.Forms.Button();
            this.btn_showTreatmentManagement = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_vetManagement = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.topMenuPanel = new System.Windows.Forms.Panel();
            this.btn_minimizeApp = new System.Windows.Forms.PictureBox();
            this.btn_closeApp = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.businessPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.topMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeApp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.adminPanel);
            this.menuPanel.Controls.Add(this.btn_logout);
            this.menuPanel.Controls.Add(this.businessPanel);
            this.menuPanel.Controls.Add(this.logoBox);
            this.menuPanel.Controls.Add(this.ProfileButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(192, 620);
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
            this.btn_logout.Location = new System.Drawing.Point(8, 569);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(175, 42);
            this.btn_logout.TabIndex = 17;
            this.btn_logout.Text = "Çıkış Yap";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // businessPanel
            // 
            this.businessPanel.Controls.Add(this.button10);
            this.businessPanel.Controls.Add(this.btn_vetManagement);
            this.businessPanel.Controls.Add(this.button8);
            this.businessPanel.Controls.Add(this.button7);
            this.businessPanel.Controls.Add(this.button4);
            this.businessPanel.Controls.Add(this.button5);
            this.businessPanel.Controls.Add(this.button6);
            this.businessPanel.Location = new System.Drawing.Point(0, 63);
            this.businessPanel.Name = "businessPanel";
            this.businessPanel.Size = new System.Drawing.Size(192, 349);
            this.businessPanel.TabIndex = 22;
            this.businessPanel.Visible = false;
            this.businessPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.businessPanel_Paint);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.White;
            this.adminPanel.Controls.Add(this.btn_showUserManagement);
            this.adminPanel.Controls.Add(this.btn_showBusinessManagement);
            this.adminPanel.Controls.Add(this.btn_showNotifications);
            this.adminPanel.Controls.Add(this.btn_showTreatmentManagement);
            this.adminPanel.Location = new System.Drawing.Point(0, 64);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(192, 206);
            this.adminPanel.TabIndex = 21;
            this.adminPanel.Visible = false;
            // 
            // btn_showUserManagement
            // 
            this.btn_showUserManagement.BackColor = System.Drawing.Color.White;
            this.btn_showUserManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_showUserManagement.FlatAppearance.BorderSize = 0;
            this.btn_showUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showUserManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_showUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_showUserManagement.Image")));
            this.btn_showUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showUserManagement.Location = new System.Drawing.Point(-1, 49);
            this.btn_showUserManagement.Name = "btn_showUserManagement";
            this.btn_showUserManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_showUserManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_showUserManagement.TabIndex = 21;
            this.btn_showUserManagement.Text = "Kullanıcılar";
            this.btn_showUserManagement.UseVisualStyleBackColor = false;
            this.btn_showUserManagement.Click += new System.EventHandler(this.btn_showUserManagement_Click);
            // 
            // btn_showBusinessManagement
            // 
            this.btn_showBusinessManagement.BackColor = System.Drawing.Color.White;
            this.btn_showBusinessManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_showBusinessManagement.FlatAppearance.BorderSize = 0;
            this.btn_showBusinessManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showBusinessManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_showBusinessManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_showBusinessManagement.Image")));
            this.btn_showBusinessManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showBusinessManagement.Location = new System.Drawing.Point(-1, 3);
            this.btn_showBusinessManagement.Name = "btn_showBusinessManagement";
            this.btn_showBusinessManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_showBusinessManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_showBusinessManagement.TabIndex = 18;
            this.btn_showBusinessManagement.Text = "İşletmeler";
            this.btn_showBusinessManagement.UseVisualStyleBackColor = false;
            this.btn_showBusinessManagement.Click += new System.EventHandler(this.btn_showBusinessManagement_Click);
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
            this.btn_showNotifications.Location = new System.Drawing.Point(-1, 145);
            this.btn_showNotifications.Name = "btn_showNotifications";
            this.btn_showNotifications.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_showNotifications.Size = new System.Drawing.Size(192, 48);
            this.btn_showNotifications.TabIndex = 20;
            this.btn_showNotifications.Text = "Bildirimler";
            this.btn_showNotifications.UseVisualStyleBackColor = false;
            this.btn_showNotifications.Click += new System.EventHandler(this.btn_showNotifications_Click);
            // 
            // btn_showTreatmentManagement
            // 
            this.btn_showTreatmentManagement.BackColor = System.Drawing.Color.White;
            this.btn_showTreatmentManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_showTreatmentManagement.FlatAppearance.BorderSize = 0;
            this.btn_showTreatmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showTreatmentManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_showTreatmentManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_showTreatmentManagement.Image")));
            this.btn_showTreatmentManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showTreatmentManagement.Location = new System.Drawing.Point(-1, 97);
            this.btn_showTreatmentManagement.Name = "btn_showTreatmentManagement";
            this.btn_showTreatmentManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_showTreatmentManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_showTreatmentManagement.TabIndex = 19;
            this.btn_showTreatmentManagement.Text = "Tedaviler";
            this.btn_showTreatmentManagement.UseVisualStyleBackColor = false;
            this.btn_showTreatmentManagement.Click += new System.EventHandler(this.btn_showTreatmentManagement_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 243);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button10.Size = new System.Drawing.Size(192, 48);
            this.button10.TabIndex = 24;
            this.button10.Text = "Tedavi ve Reçete Planlama";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btn_vetManagement
            // 
            this.btn_vetManagement.BackColor = System.Drawing.Color.White;
            this.btn_vetManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_vetManagement.FlatAppearance.BorderSize = 0;
            this.btn_vetManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vetManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_vetManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_vetManagement.Image")));
            this.btn_vetManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vetManagement.Location = new System.Drawing.Point(0, 291);
            this.btn_vetManagement.Name = "btn_vetManagement";
            this.btn_vetManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_vetManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_vetManagement.TabIndex = 23;
            this.btn_vetManagement.Text = "    Veteriner Yönetimi";
            this.btn_vetManagement.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 195);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button8.Size = new System.Drawing.Size(192, 48);
            this.button8.TabIndex = 22;
            this.button8.Text = "     Pet ve Müşteri      Yönetimi\r\n";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 147);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button7.Size = new System.Drawing.Size(192, 48);
            this.button7.TabIndex = 21;
            this.button7.Text = "Stok Yönetimi";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button4.Size = new System.Drawing.Size(192, 48);
            this.button4.TabIndex = 18;
            this.button4.Text = "             Randevu               Planlama";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 99);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button5.Size = new System.Drawing.Size(192, 48);
            this.button5.TabIndex = 20;
            this.button5.Text = "İlaç Yönetimi";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 51);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button6.Size = new System.Drawing.Size(192, 48);
            this.button6.TabIndex = 19;
            this.button6.Text = "Hasta Yönetimi";
            this.button6.UseVisualStyleBackColor = false;
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
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileButton.Location = new System.Drawing.Point(8, 517);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(175, 44);
            this.ProfileButton.TabIndex = 15;
            this.ProfileButton.Text = "          Profilimi Görüntüle";
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Visible = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contentPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contentPanel.Location = new System.Drawing.Point(192, 30);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(808, 590);
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
            this.topMenuPanel.Size = new System.Drawing.Size(808, 30);
            this.topMenuPanel.TabIndex = 18;
            this.topMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenuPanel_MouseDown);
            // 
            // btn_minimizeApp
            // 
            this.btn_minimizeApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizeApp.Image")));
            this.btn_minimizeApp.Location = new System.Drawing.Point(761, 2);
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
            this.btn_closeApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_closeApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeApp.Image")));
            this.btn_closeApp.Location = new System.Drawing.Point(785, 2);
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
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.topMenuPanel);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.menuPanel.ResumeLayout(false);
            this.businessPanel.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.topMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel topMenuPanel;
        private System.Windows.Forms.PictureBox btn_minimizeApp;
        private System.Windows.Forms.PictureBox btn_closeApp;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btn_showNotifications;
        private System.Windows.Forms.Button btn_showTreatmentManagement;
        private System.Windows.Forms.Button btn_showBusinessManagement;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Panel businessPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_vetManagement;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_showUserManagement;
    }
}