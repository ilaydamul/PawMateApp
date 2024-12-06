namespace PawMateApp.Screens
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.userImage = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_updateProfileInfos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_updateImage = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.Label();
            this.lbl_businessName = new System.Windows.Forms.Label();
            this.profile_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_img)).BeginInit();
            this.SuspendLayout();
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.White;
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(98, 85);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(120, 120);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userImage.TabIndex = 0;
            this.userImage.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(470, 122);
            this.lbl_name.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(165, 64);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "İlayda Mülazimoğlu";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_updateProfileInfos
            // 
            this.btn_updateProfileInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_updateProfileInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateProfileInfos.ForeColor = System.Drawing.Color.White;
            this.btn_updateProfileInfos.Location = new System.Drawing.Point(13, 230);
            this.btn_updateProfileInfos.Name = "btn_updateProfileInfos";
            this.btn_updateProfileInfos.Size = new System.Drawing.Size(226, 37);
            this.btn_updateProfileInfos.TabIndex = 6;
            this.btn_updateProfileInfos.Text = "Güncelle";
            this.btn_updateProfileInfos.UseVisualStyleBackColor = false;
            this.btn_updateProfileInfos.Click += new System.EventHandler(this.btn_updateProfileInfos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_updateProfileInfos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_fullname);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label10);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(35, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 288);
            this.panel1.TabIndex = 18;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(13, 194);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(226, 20);
            this.txt_email.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 14);
            this.label7.TabIndex = 134;
            this.label7.Text = "E-Mail Adresi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 14);
            this.label8.TabIndex = 133;
            this.label8.Text = "Telefon Numarası";
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.Color.White;
            this.txt_fullname.Location = new System.Drawing.Point(14, 32);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(226, 20);
            this.txt_fullname.TabIndex = 125;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.White;
            this.txt_phone.Location = new System.Drawing.Point(13, 154);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(226, 20);
            this.txt_phone.TabIndex = 128;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 14);
            this.label11.TabIndex = 130;
            this.label11.Text = "Ad Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 14);
            this.label9.TabIndex = 132;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(13, 113);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(226, 20);
            this.txt_password.TabIndex = 127;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(13, 73);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(226, 20);
            this.txt_username.TabIndex = 126;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 14);
            this.label10.TabIndex = 131;
            this.label10.Text = "Şifre";
            // 
            // btn_updateImage
            // 
            this.btn_updateImage.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateImage.ForeColor = System.Drawing.Color.Black;
            this.btn_updateImage.Location = new System.Drawing.Point(98, 215);
            this.btn_updateImage.Name = "btn_updateImage";
            this.btn_updateImage.Size = new System.Drawing.Size(120, 30);
            this.btn_updateImage.TabIndex = 100;
            this.btn_updateImage.Text = "Fotoğrafımı Güncelle";
            this.btn_updateImage.UseVisualStyleBackColor = false;
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(119, 32);
            this.txt_title.TabIndex = 101;
            this.txt_title.Text = "Profilim";
            // 
            // lbl_businessName
            // 
            this.lbl_businessName.AutoSize = true;
            this.lbl_businessName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_businessName.Location = new System.Drawing.Point(504, 84);
            this.lbl_businessName.Name = "lbl_businessName";
            this.lbl_businessName.Size = new System.Drawing.Size(95, 24);
            this.lbl_businessName.TabIndex = 105;
            this.lbl_businessName.Text = "PawMate";
            this.lbl_businessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profile_img
            // 
            this.profile_img.BackgroundImage = global::PawMateApp.Properties.Resources.profile_img21;
            this.profile_img.Location = new System.Drawing.Point(323, 215);
            this.profile_img.Name = "profile_img";
            this.profile_img.Size = new System.Drawing.Size(460, 346);
            this.profile_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_img.TabIndex = 106;
            this.profile_img.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.profile_img);
            this.Controls.Add(this.lbl_businessName);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_updateImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.userImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_updateProfileInfos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_updateImage;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_businessName;
        private System.Windows.Forms.PictureBox profile_img;
    }
}