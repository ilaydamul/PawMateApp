namespace PawMateApp.Screens
{
    partial class VetManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetManagement));
            this.txt_title = new System.Windows.Forms.Label();
            this.btn_deleteVet = new System.Windows.Forms.Button();
            this.btn_addVet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.isBusinessAdmin = new System.Windows.Forms.CheckBox();
            this.vetImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.btn_addUpdateVet = new System.Windows.Forms.Button();
            this.vetList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vetImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetList)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(258, 32);
            this.txt_title.TabIndex = 102;
            this.txt_title.Text = "Veteriner Yönetimi";
            // 
            // btn_deleteVet
            // 
            this.btn_deleteVet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_deleteVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteVet.ForeColor = System.Drawing.Color.White;
            this.btn_deleteVet.Location = new System.Drawing.Point(638, 545);
            this.btn_deleteVet.Name = "btn_deleteVet";
            this.btn_deleteVet.Size = new System.Drawing.Size(158, 30);
            this.btn_deleteVet.TabIndex = 138;
            this.btn_deleteVet.Text = "Sil";
            this.btn_deleteVet.UseVisualStyleBackColor = false;
            this.btn_deleteVet.Click += new System.EventHandler(this.btn_deleteVet_Click);
            // 
            // btn_addVet
            // 
            this.btn_addVet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addVet.ForeColor = System.Drawing.Color.White;
            this.btn_addVet.Location = new System.Drawing.Point(638, 39);
            this.btn_addVet.Name = "btn_addVet";
            this.btn_addVet.Size = new System.Drawing.Size(158, 33);
            this.btn_addVet.TabIndex = 135;
            this.btn_addVet.Text = "Veteriner Ekle";
            this.btn_addVet.UseVisualStyleBackColor = false;
            this.btn_addVet.Click += new System.EventHandler(this.btn_addVet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(269, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 137;
            this.label5.Text = "Veterinerleriniz";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.isBusinessAdmin);
            this.panel1.Controls.Add(this.vetImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_fullname);
            this.panel1.Controls.Add(this.btn_addUpdateVet);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 500);
            this.panel1.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 127;
            this.label2.Text = "E-Mail Adresi";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(14, 347);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(226, 20);
            this.txt_email.TabIndex = 4;
            // 
            // isBusinessAdmin
            // 
            this.isBusinessAdmin.AutoSize = true;
            this.isBusinessAdmin.Location = new System.Drawing.Point(15, 377);
            this.isBusinessAdmin.Name = "isBusinessAdmin";
            this.isBusinessAdmin.Size = new System.Drawing.Size(93, 17);
            this.isBusinessAdmin.TabIndex = 5;
            this.isBusinessAdmin.Text = "İşletme Admini";
            this.isBusinessAdmin.UseVisualStyleBackColor = true;
            // 
            // vetImage
            // 
            this.vetImage.BackColor = System.Drawing.Color.White;
            this.vetImage.Image = ((System.Drawing.Image)(resources.GetObject("vetImage.Image")));
            this.vetImage.Location = new System.Drawing.Point(13, 8);
            this.vetImage.Name = "vetImage";
            this.vetImage.Size = new System.Drawing.Size(227, 147);
            this.vetImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vetImage.TabIndex = 122;
            this.vetImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 121;
            this.label1.Text = "Telefon Numarası";
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.White;
            this.txt_phone.Location = new System.Drawing.Point(13, 304);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(226, 20);
            this.txt_phone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 120;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(13, 223);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(226, 20);
            this.txt_username.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 119;
            this.label7.Text = "Şifre";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(13, 263);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(226, 20);
            this.txt_password.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 118;
            this.label8.Text = "Ad Soyad";
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.Color.White;
            this.txt_fullname.Location = new System.Drawing.Point(14, 182);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(226, 20);
            this.txt_fullname.TabIndex = 0;
            // 
            // btn_addUpdateVet
            // 
            this.btn_addUpdateVet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addUpdateVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUpdateVet.ForeColor = System.Drawing.Color.White;
            this.btn_addUpdateVet.Location = new System.Drawing.Point(13, 451);
            this.btn_addUpdateVet.Name = "btn_addUpdateVet";
            this.btn_addUpdateVet.Size = new System.Drawing.Size(226, 37);
            this.btn_addUpdateVet.TabIndex = 6;
            this.btn_addUpdateVet.Text = "Ekle";
            this.btn_addUpdateVet.UseVisualStyleBackColor = false;
            this.btn_addUpdateVet.Click += new System.EventHandler(this.btn_addUpdateVet_Click);
            // 
            // vetList
            // 
            this.vetList.AllowUserToAddRows = false;
            this.vetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vetList.Location = new System.Drawing.Point(274, 75);
            this.vetList.Name = "vetList";
            this.vetList.RowHeadersWidth = 51;
            this.vetList.Size = new System.Drawing.Size(522, 466);
            this.vetList.TabIndex = 134;
            this.vetList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vetList_CellClick);
            // 
            // VetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.btn_deleteVet);
            this.Controls.Add(this.btn_addVet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vetList);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VetManagement";
            this.Text = "VetManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vetImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Button btn_deleteVet;
        private System.Windows.Forms.Button btn_addVet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox isBusinessAdmin;
        private System.Windows.Forms.PictureBox vetImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Button btn_addUpdateVet;
        private System.Windows.Forms.DataGridView vetList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
    }
}