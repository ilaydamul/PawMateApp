namespace PawMateApp.Screens.Admin
{
    partial class BusinessManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessManagement));
            this.txt_title = new System.Windows.Forms.Label();
            this.businessesList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_approved = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.businessLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_authName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_businessEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_businessName = new System.Windows.Forms.TextBox();
            this.btn_addUpdateBusiness = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_addBusiness = new System.Windows.Forms.Button();
            this.btn_deleteBusiness = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.businessesList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(144, 32);
            this.txt_title.TabIndex = 4;
            this.txt_title.Text = "İşletmeler";
            // 
            // businessesList
            // 
            this.businessesList.AllowUserToAddRows = false;
            this.businessesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessesList.Location = new System.Drawing.Point(274, 75);
            this.businessesList.Name = "businessesList";
            this.businessesList.RowHeadersWidth = 51;
            this.businessesList.Size = new System.Drawing.Size(522, 466);
            this.businessesList.TabIndex = 5;
            this.businessesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.businessesList_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.cb_approved);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.businessLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_authName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_businessEmail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_businessName);
            this.panel1.Controls.Add(this.btn_addUpdateBusiness);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 500);
            this.panel1.TabIndex = 105;
            // 
            // cb_approved
            // 
            this.cb_approved.AutoSize = true;
            this.cb_approved.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_approved.Location = new System.Drawing.Point(19, 377);
            this.cb_approved.Name = "cb_approved";
            this.cb_approved.Size = new System.Drawing.Size(56, 18);
            this.cb_approved.TabIndex = 125;
            this.cb_approved.Text = "Onaylı";
            this.cb_approved.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(11, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 124;
            this.label2.Text = "İşletme Adresi";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_address.Location = new System.Drawing.Point(14, 293);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(226, 60);
            this.txt_address.TabIndex = 4;
            // 
            // businessLogo
            // 
            this.businessLogo.BackColor = System.Drawing.Color.White;
            this.businessLogo.Image = ((System.Drawing.Image)(resources.GetObject("businessLogo.Image")));
            this.businessLogo.Location = new System.Drawing.Point(14, 11);
            this.businessLogo.Name = "businessLogo";
            this.businessLogo.Size = new System.Drawing.Size(226, 79);
            this.businessLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.businessLogo.TabIndex = 122;
            this.businessLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(11, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "İşletme Telefonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(11, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 120;
            this.label3.Text = "Yetkili Kişi Adı";
            // 
            // txt_authName
            // 
            this.txt_authName.BackColor = System.Drawing.Color.White;
            this.txt_authName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_authName.Location = new System.Drawing.Point(14, 161);
            this.txt_authName.Name = "txt_authName";
            this.txt_authName.Size = new System.Drawing.Size(226, 22);
            this.txt_authName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(11, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 119;
            this.label7.Text = "İşletme E-Mail";
            // 
            // txt_businessEmail
            // 
            this.txt_businessEmail.BackColor = System.Drawing.Color.White;
            this.txt_businessEmail.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_businessEmail.Location = new System.Drawing.Point(14, 205);
            this.txt_businessEmail.Name = "txt_businessEmail";
            this.txt_businessEmail.Size = new System.Drawing.Size(226, 22);
            this.txt_businessEmail.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(12, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 118;
            this.label8.Text = "İşletme Adınız";
            // 
            // txt_businessName
            // 
            this.txt_businessName.BackColor = System.Drawing.Color.White;
            this.txt_businessName.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_businessName.Location = new System.Drawing.Point(15, 117);
            this.txt_businessName.Name = "txt_businessName";
            this.txt_businessName.Size = new System.Drawing.Size(226, 22);
            this.txt_businessName.TabIndex = 0;
            // 
            // btn_addUpdateBusiness
            // 
            this.btn_addUpdateBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addUpdateBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUpdateBusiness.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addUpdateBusiness.ForeColor = System.Drawing.Color.White;
            this.btn_addUpdateBusiness.Location = new System.Drawing.Point(14, 450);
            this.btn_addUpdateBusiness.Name = "btn_addUpdateBusiness";
            this.btn_addUpdateBusiness.Size = new System.Drawing.Size(226, 37);
            this.btn_addUpdateBusiness.TabIndex = 6;
            this.btn_addUpdateBusiness.Text = "Ekle";
            this.btn_addUpdateBusiness.UseVisualStyleBackColor = false;
            this.btn_addUpdateBusiness.Click += new System.EventHandler(this.btn_addUpdateBusiness_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(14, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 110;
            this.label6.Text = "Hesap Onaylı mı?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(269, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 107;
            this.label5.Text = "İşletme Listesi";
            // 
            // btn_addBusiness
            // 
            this.btn_addBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBusiness.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addBusiness.ForeColor = System.Drawing.Color.White;
            this.btn_addBusiness.Location = new System.Drawing.Point(638, 39);
            this.btn_addBusiness.Name = "btn_addBusiness";
            this.btn_addBusiness.Size = new System.Drawing.Size(158, 33);
            this.btn_addBusiness.TabIndex = 7;
            this.btn_addBusiness.Text = "İşletme Ekle";
            this.btn_addBusiness.UseVisualStyleBackColor = false;
            this.btn_addBusiness.Click += new System.EventHandler(this.btn_addBusiness_Click);
            // 
            // btn_deleteBusiness
            // 
            this.btn_deleteBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_deleteBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteBusiness.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_deleteBusiness.ForeColor = System.Drawing.Color.White;
            this.btn_deleteBusiness.Location = new System.Drawing.Point(638, 545);
            this.btn_deleteBusiness.Name = "btn_deleteBusiness";
            this.btn_deleteBusiness.Size = new System.Drawing.Size(158, 30);
            this.btn_deleteBusiness.TabIndex = 133;
            this.btn_deleteBusiness.Text = "Sil";
            this.btn_deleteBusiness.UseVisualStyleBackColor = false;
            this.btn_deleteBusiness.Click += new System.EventHandler(this.btn_deleteBusiness_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(15, 249);
            this.txt_phone.Mask = "9990000000";
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(226, 20);
            this.txt_phone.TabIndex = 126;
            // 
            // BusinessManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.btn_deleteBusiness);
            this.Controls.Add(this.btn_addBusiness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.businessesList);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusinessManagement";
            this.Text = "İşletme Yönetimi";
            this.Load += new System.EventHandler(this.BusinessManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.businessesList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.DataGridView businessesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addUpdateBusiness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_authName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_businessEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_businessName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.PictureBox businessLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_addBusiness;
        private System.Windows.Forms.Button btn_deleteBusiness;
        private System.Windows.Forms.CheckBox cb_approved;
        private System.Windows.Forms.MaskedTextBox txt_phone;
    }
}