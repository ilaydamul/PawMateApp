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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.btn_updateProfileInfos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_updateImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.White;
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(101, 97);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(120, 120);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userImage.TabIndex = 0;
            this.userImage.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(70, 266);
            this.lbl_name.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(182, 64);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "İlayda Mülazimoğlu";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 99;
            this.label2.Text = "Adınız";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(13, 30);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 20);
            this.txt_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Soyadınız";
            // 
            // txt_surname
            // 
            this.txt_surname.BackColor = System.Drawing.Color.White;
            this.txt_surname.Location = new System.Drawing.Point(13, 76);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(196, 20);
            this.txt_surname.TabIndex = 2;
            // 
            // btn_updateProfileInfos
            // 
            this.btn_updateProfileInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_updateProfileInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateProfileInfos.ForeColor = System.Drawing.Color.White;
            this.btn_updateProfileInfos.Location = new System.Drawing.Point(13, 259);
            this.btn_updateProfileInfos.Name = "btn_updateProfileInfos";
            this.btn_updateProfileInfos.Size = new System.Drawing.Size(196, 37);
            this.btn_updateProfileInfos.TabIndex = 6;
            this.btn_updateProfileInfos.Text = "Güncelle";
            this.btn_updateProfileInfos.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_surname);
            this.panel1.Controls.Add(this.btn_updateProfileInfos);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(314, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 315);
            this.panel1.TabIndex = 18;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(13, 214);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(196, 20);
            this.txt_password.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "Şifreniz";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(13, 168);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(196, 20);
            this.txt_username.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(13, 122);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(196, 20);
            this.txt_email.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kullanıcı Adınız";
            // 
            // btn_updateImage
            // 
            this.btn_updateImage.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateImage.ForeColor = System.Drawing.Color.Black;
            this.btn_updateImage.Location = new System.Drawing.Point(101, 226);
            this.btn_updateImage.Name = "btn_updateImage";
            this.btn_updateImage.Size = new System.Drawing.Size(120, 30);
            this.btn_updateImage.TabIndex = 100;
            this.btn_updateImage.Text = "Fotoğrafımı Güncelle";
            this.btn_updateImage.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 424);
            this.Controls.Add(this.btn_updateImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.userImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Button btn_updateProfileInfos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_updateImage;
    }
}