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
            this.adminPanel = new System.Windows.Forms.Panel();
            this.has_notif = new System.Windows.Forms.PictureBox();
            this.btn_showUserManagement = new System.Windows.Forms.Button();
            this.btn_showBusinessManagement = new System.Windows.Forms.Button();
            this.btn_showNotifications = new System.Windows.Forms.Button();
            this.btn_showTreatmentManagement = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.businessPanel = new System.Windows.Forms.Panel();
            this.stock_warn = new System.Windows.Forms.PictureBox();
            this.btn_treatmentManagement = new System.Windows.Forms.Button();
            this.btn_vetManagement = new System.Windows.Forms.Button();
            this.btn_petManagement = new System.Windows.Forms.Button();
            this.btn_stockManagement = new System.Windows.Forms.Button();
            this.btn_appointManagement = new System.Windows.Forms.Button();
            this.btn_medicineManagement = new System.Windows.Forms.Button();
            this.btn_patientManagement = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.btn_profile = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.topMenuPanel = new System.Windows.Forms.Panel();
            this.btn_minimizeApp = new System.Windows.Forms.PictureBox();
            this.btn_closeApp = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.has_notif)).BeginInit();
            this.businessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock_warn)).BeginInit();
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
            this.menuPanel.Controls.Add(this.btn_profile);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(192, 620);
            this.menuPanel.TabIndex = 16;
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.White;
            this.adminPanel.Controls.Add(this.has_notif);
            this.adminPanel.Controls.Add(this.btn_showUserManagement);
            this.adminPanel.Controls.Add(this.btn_showBusinessManagement);
            this.adminPanel.Controls.Add(this.btn_showNotifications);
            this.adminPanel.Controls.Add(this.btn_showTreatmentManagement);
            this.adminPanel.Location = new System.Drawing.Point(0, 63);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(192, 206);
            this.adminPanel.TabIndex = 21;
            this.adminPanel.Visible = false;
            // 
            // has_notif
            // 
            this.has_notif.Image = global::PawMateApp.Properties.Resources.warning;
            this.has_notif.Location = new System.Drawing.Point(160, 151);
            this.has_notif.Name = "has_notif";
            this.has_notif.Size = new System.Drawing.Size(23, 36);
            this.has_notif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.has_notif.TabIndex = 169;
            this.has_notif.TabStop = false;
            this.has_notif.Visible = false;
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
            this.businessPanel.Controls.Add(this.stock_warn);
            this.businessPanel.Controls.Add(this.btn_treatmentManagement);
            this.businessPanel.Controls.Add(this.btn_vetManagement);
            this.businessPanel.Controls.Add(this.btn_petManagement);
            this.businessPanel.Controls.Add(this.btn_stockManagement);
            this.businessPanel.Controls.Add(this.btn_appointManagement);
            this.businessPanel.Controls.Add(this.btn_medicineManagement);
            this.businessPanel.Controls.Add(this.btn_patientManagement);
            this.businessPanel.Location = new System.Drawing.Point(0, 63);
            this.businessPanel.Name = "businessPanel";
            this.businessPanel.Size = new System.Drawing.Size(192, 349);
            this.businessPanel.TabIndex = 22;
            this.businessPanel.Visible = false;
            this.businessPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.businessPanel_Paint);
            // 
            // stock_warn
            // 
            this.stock_warn.Image = global::PawMateApp.Properties.Resources.warning;
            this.stock_warn.Location = new System.Drawing.Point(160, 153);
            this.stock_warn.Name = "stock_warn";
            this.stock_warn.Size = new System.Drawing.Size(23, 36);
            this.stock_warn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stock_warn.TabIndex = 168;
            this.stock_warn.TabStop = false;
            this.stock_warn.Visible = false;
            // 
            // btn_treatmentManagement
            // 
            this.btn_treatmentManagement.BackColor = System.Drawing.Color.White;
            this.btn_treatmentManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_treatmentManagement.FlatAppearance.BorderSize = 0;
            this.btn_treatmentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_treatmentManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_treatmentManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_treatmentManagement.Image")));
            this.btn_treatmentManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_treatmentManagement.Location = new System.Drawing.Point(0, 243);
            this.btn_treatmentManagement.Name = "btn_treatmentManagement";
            this.btn_treatmentManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_treatmentManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_treatmentManagement.TabIndex = 24;
            this.btn_treatmentManagement.Text = "Tedavi ve Reçete Planlama";
            this.btn_treatmentManagement.UseVisualStyleBackColor = false;
            this.btn_treatmentManagement.Click += new System.EventHandler(this.btn_treatmentManagement_Click);
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
            this.btn_vetManagement.Click += new System.EventHandler(this.btn_vetManagement_Click);
            // 
            // btn_petManagement
            // 
            this.btn_petManagement.BackColor = System.Drawing.Color.White;
            this.btn_petManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_petManagement.FlatAppearance.BorderSize = 0;
            this.btn_petManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_petManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_petManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_petManagement.Image")));
            this.btn_petManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_petManagement.Location = new System.Drawing.Point(0, 195);
            this.btn_petManagement.Name = "btn_petManagement";
            this.btn_petManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_petManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_petManagement.TabIndex = 22;
            this.btn_petManagement.Text = "     Pet ve Müşteri      Yönetimi\r\n";
            this.btn_petManagement.UseVisualStyleBackColor = false;
            this.btn_petManagement.Click += new System.EventHandler(this.btn_petManagement_Click);
            // 
            // btn_stockManagement
            // 
            this.btn_stockManagement.BackColor = System.Drawing.Color.White;
            this.btn_stockManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_stockManagement.FlatAppearance.BorderSize = 0;
            this.btn_stockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stockManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_stockManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_stockManagement.Image")));
            this.btn_stockManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stockManagement.Location = new System.Drawing.Point(0, 147);
            this.btn_stockManagement.Name = "btn_stockManagement";
            this.btn_stockManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_stockManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_stockManagement.TabIndex = 21;
            this.btn_stockManagement.Text = "Stok Yönetimi";
            this.btn_stockManagement.UseVisualStyleBackColor = false;
            this.btn_stockManagement.Click += new System.EventHandler(this.btn_stockManagement_Click);
            // 
            // btn_appointManagement
            // 
            this.btn_appointManagement.BackColor = System.Drawing.Color.White;
            this.btn_appointManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_appointManagement.FlatAppearance.BorderSize = 0;
            this.btn_appointManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appointManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_appointManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_appointManagement.Image")));
            this.btn_appointManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_appointManagement.Location = new System.Drawing.Point(0, 3);
            this.btn_appointManagement.Name = "btn_appointManagement";
            this.btn_appointManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_appointManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_appointManagement.TabIndex = 18;
            this.btn_appointManagement.Text = "             Randevu               Planlama";
            this.btn_appointManagement.UseVisualStyleBackColor = false;
            this.btn_appointManagement.Click += new System.EventHandler(this.btn_appointManagement_Click);
            // 
            // btn_medicineManagement
            // 
            this.btn_medicineManagement.BackColor = System.Drawing.Color.White;
            this.btn_medicineManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_medicineManagement.FlatAppearance.BorderSize = 0;
            this.btn_medicineManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_medicineManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_medicineManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_medicineManagement.Image")));
            this.btn_medicineManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_medicineManagement.Location = new System.Drawing.Point(0, 99);
            this.btn_medicineManagement.Name = "btn_medicineManagement";
            this.btn_medicineManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_medicineManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_medicineManagement.TabIndex = 20;
            this.btn_medicineManagement.Text = "İlaç Yönetimi";
            this.btn_medicineManagement.UseVisualStyleBackColor = false;
            this.btn_medicineManagement.Click += new System.EventHandler(this.btn_medicineManagement_Click);
            // 
            // btn_patientManagement
            // 
            this.btn_patientManagement.BackColor = System.Drawing.Color.White;
            this.btn_patientManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_patientManagement.FlatAppearance.BorderSize = 0;
            this.btn_patientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patientManagement.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.btn_patientManagement.Image = ((System.Drawing.Image)(resources.GetObject("btn_patientManagement.Image")));
            this.btn_patientManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_patientManagement.Location = new System.Drawing.Point(0, 51);
            this.btn_patientManagement.Name = "btn_patientManagement";
            this.btn_patientManagement.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_patientManagement.Size = new System.Drawing.Size(192, 48);
            this.btn_patientManagement.TabIndex = 19;
            this.btn_patientManagement.Text = "Hasta Yönetimi";
            this.btn_patientManagement.UseVisualStyleBackColor = false;
            this.btn_patientManagement.Click += new System.EventHandler(this.btn_patientManagement_Click);
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
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(8, 517);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(175, 44);
            this.btn_profile.TabIndex = 15;
            this.btn_profile.Text = "          Profilimi Görüntüle";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Visible = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
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
            this.adminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.has_notif)).EndInit();
            this.businessPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stock_warn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.topMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_profile;
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
        private System.Windows.Forms.Button btn_appointManagement;
        private System.Windows.Forms.Button btn_medicineManagement;
        private System.Windows.Forms.Button btn_patientManagement;
        private System.Windows.Forms.Button btn_treatmentManagement;
        private System.Windows.Forms.Button btn_vetManagement;
        private System.Windows.Forms.Button btn_petManagement;
        private System.Windows.Forms.Button btn_stockManagement;
        private System.Windows.Forms.Button btn_showUserManagement;
        private System.Windows.Forms.PictureBox stock_warn;
        private System.Windows.Forms.PictureBox has_notif;
    }
}