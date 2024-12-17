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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtt_vets = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_activeAppo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_totalMedicine = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_customers = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_allPresp = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_vets = new System.Windows.Forms.Label();
            this.pc_vets = new System.Windows.Forms.PictureBox();
            this.lbl_pets = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_totalAppo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profile_img = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_img)).BeginInit();
            this.SuspendLayout();
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.Color.White;
            this.userImage.Image = global::PawMateApp.Properties.Resources.user;
            this.userImage.Location = new System.Drawing.Point(89, 68);
            this.userImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(185, 161);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 0;
            this.userImage.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(199, 249);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.MaximumSize = new System.Drawing.Size(533, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(298, 39);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "İlayda Mülazimoğlu";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_updateProfileInfos
            // 
            this.btn_updateProfileInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_updateProfileInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateProfileInfos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_updateProfileInfos.ForeColor = System.Drawing.Color.White;
            this.btn_updateProfileInfos.Location = new System.Drawing.Point(17, 335);
            this.btn_updateProfileInfos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_updateProfileInfos.Name = "btn_updateProfileInfos";
            this.btn_updateProfileInfos.Size = new System.Drawing.Size(301, 46);
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
            this.panel1.Location = new System.Drawing.Point(16, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 404);
            this.panel1.TabIndex = 18;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(17, 239);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(300, 22);
            this.txt_email.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 134;
            this.label7.Text = "E-Mail Adresi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 133;
            this.label8.Text = "Telefon Numarası";
            // 
            // txt_fullname
            // 
            this.txt_fullname.BackColor = System.Drawing.Color.White;
            this.txt_fullname.Location = new System.Drawing.Point(19, 39);
            this.txt_fullname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(300, 22);
            this.txt_fullname.TabIndex = 125;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.White;
            this.txt_phone.Location = new System.Drawing.Point(17, 190);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(300, 22);
            this.txt_phone.TabIndex = 128;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(16, 17);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 130;
            this.label11.Text = "Ad Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 132;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(17, 139);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(300, 22);
            this.txt_password.TabIndex = 127;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(17, 90);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(300, 22);
            this.txt_username.TabIndex = 126;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 131;
            this.label10.Text = "Şifre";
            // 
            // btn_updateImage
            // 
            this.btn_updateImage.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateImage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_updateImage.ForeColor = System.Drawing.Color.Black;
            this.btn_updateImage.Location = new System.Drawing.Point(89, 246);
            this.btn_updateImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_updateImage.Name = "btn_updateImage";
            this.btn_updateImage.Size = new System.Drawing.Size(185, 37);
            this.btn_updateImage.TabIndex = 100;
            this.btn_updateImage.Text = "Fotoğrafımı Güncelle";
            this.btn_updateImage.UseVisualStyleBackColor = false;
            this.btn_updateImage.Click += new System.EventHandler(this.btn_updateImage_Click);
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(8, 11);
            this.txt_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(144, 40);
            this.txt_title.TabIndex = 101;
            this.txt_title.Text = "Profilim";
            // 
            // lbl_businessName
            // 
            this.lbl_businessName.AutoSize = true;
            this.lbl_businessName.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_businessName.Location = new System.Drawing.Point(288, 219);
            this.lbl_businessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_businessName.Name = "lbl_businessName";
            this.lbl_businessName.Size = new System.Drawing.Size(120, 30);
            this.lbl_businessName.TabIndex = 105;
            this.lbl_businessName.Text = "PawMate";
            this.lbl_businessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(393, 444);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(133, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 107;
            this.label1.Text = "İlaç Sayısı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(479, 623);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MaximumSize = new System.Drawing.Size(133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 109;
            this.label2.Text = "Müşteriler";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtt_vets
            // 
            this.txtt_vets.AutoSize = true;
            this.txtt_vets.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtt_vets.Location = new System.Drawing.Point(309, 623);
            this.txtt_vets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtt_vets.MaximumSize = new System.Drawing.Size(133, 0);
            this.txtt_vets.Name = "txtt_vets";
            this.txtt_vets.Size = new System.Drawing.Size(107, 22);
            this.txtt_vets.TabIndex = 110;
            this.txtt_vets.Text = "Veterinerler";
            this.txtt_vets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(157, 623);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.MaximumSize = new System.Drawing.Size(133, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 111;
            this.label4.Text = "Petler";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(57, 433);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.MaximumSize = new System.Drawing.Size(133, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 44);
            this.label5.TabIndex = 112;
            this.label5.Text = "Toplam Randevu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(203, 444);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.MaximumSize = new System.Drawing.Size(133, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 113;
            this.label6.Text = "Aktif Randevu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(545, 433);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.MaximumSize = new System.Drawing.Size(133, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 44);
            this.label12.TabIndex = 114;
            this.label12.Text = "Yazılam Tüm Reçeleteler";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_activeAppo
            // 
            this.lbl_activeAppo.AutoSize = true;
            this.lbl_activeAppo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_activeAppo.Location = new System.Drawing.Point(231, 351);
            this.lbl_activeAppo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_activeAppo.MaximumSize = new System.Drawing.Size(133, 0);
            this.lbl_activeAppo.Name = "lbl_activeAppo";
            this.lbl_activeAppo.Size = new System.Drawing.Size(71, 38);
            this.lbl_activeAppo.TabIndex = 118;
            this.lbl_activeAppo.Text = "100";
            this.lbl_activeAppo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PawMateApp.Properties.Resources.rec;
            this.pictureBox2.Location = new System.Drawing.Point(207, 314);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 116;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_totalMedicine
            // 
            this.lbl_totalMedicine.AutoSize = true;
            this.lbl_totalMedicine.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_totalMedicine.Location = new System.Drawing.Point(404, 351);
            this.lbl_totalMedicine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalMedicine.MaximumSize = new System.Drawing.Size(133, 0);
            this.lbl_totalMedicine.Name = "lbl_totalMedicine";
            this.lbl_totalMedicine.Size = new System.Drawing.Size(71, 38);
            this.lbl_totalMedicine.TabIndex = 120;
            this.lbl_totalMedicine.Text = "100";
            this.lbl_totalMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PawMateApp.Properties.Resources.rec;
            this.pictureBox3.Location = new System.Drawing.Point(380, 314);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 119;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_customers
            // 
            this.lbl_customers.AutoSize = true;
            this.lbl_customers.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_customers.Location = new System.Drawing.Point(491, 540);
            this.lbl_customers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customers.MaximumSize = new System.Drawing.Size(133, 0);
            this.lbl_customers.Name = "lbl_customers";
            this.lbl_customers.Size = new System.Drawing.Size(71, 38);
            this.lbl_customers.TabIndex = 122;
            this.lbl_customers.Text = "100";
            this.lbl_customers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PawMateApp.Properties.Resources.rec;
            this.pictureBox4.Location = new System.Drawing.Point(467, 503);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 112);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 121;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_allPresp
            // 
            this.lbl_allPresp.AutoSize = true;
            this.lbl_allPresp.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_allPresp.Location = new System.Drawing.Point(572, 351);
            this.lbl_allPresp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_allPresp.MaximumSize = new System.Drawing.Size(133, 0);
            this.lbl_allPresp.Name = "lbl_allPresp";
            this.lbl_allPresp.Size = new System.Drawing.Size(71, 38);
            this.lbl_allPresp.TabIndex = 128;
            this.lbl_allPresp.Text = "100";
            this.lbl_allPresp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PawMateApp.Properties.Resources.rec;
            this.pictureBox6.Location = new System.Drawing.Point(548, 314);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(121, 112);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 127;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_vets
            // 
            this.lbl_vets.AutoSize = true;
            this.lbl_vets.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vets.Location = new System.Drawing.Point(320, 540);
            this.lbl_vets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vets.MaximumSize = new System.Drawing.Size(133, 0);
            this.lbl_vets.Name = "lbl_vets";
            this.lbl_vets.Size = new System.Drawing.Size(71, 38);
            this.lbl_vets.TabIndex = 126;
            this.lbl_vets.Text = "100";
            this.lbl_vets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pc_vets
            // 
            this.pc_vets.Image = global::PawMateApp.Properties.Resources.rec;
            this.pc_vets.Location = new System.Drawing.Point(296, 503);
            this.pc_vets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pc_vets.Name = "pc_vets";
            this.pc_vets.Size = new System.Drawing.Size(121, 112);
            this.pc_vets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_vets.TabIndex = 125;
            this.pc_vets.TabStop = false;
            // 
            // lbl_pets
            // 
            this.lbl_pets.AutoSize = true;
            this.lbl_pets.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pets.Location = new System.Drawing.Point(151, 540);
            this.lbl_pets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pets.MaximumSize = new System.Drawing.Size(133, 0);
            this.lbl_pets.Name = "lbl_pets";
            this.lbl_pets.Size = new System.Drawing.Size(71, 38);
            this.lbl_pets.TabIndex = 124;
            this.lbl_pets.Text = "100";
            this.lbl_pets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::PawMateApp.Properties.Resources.rec;
            this.pictureBox8.Location = new System.Drawing.Point(127, 503);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(121, 112);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 123;
            this.pictureBox8.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbl_totalAppo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.profile_img);
            this.panel2.Controls.Add(this.lbl_allPresp);
            this.panel2.Controls.Add(this.lbl_totalMedicine);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.lbl_vets);
            this.panel2.Controls.Add(this.lbl_businessName);
            this.panel2.Controls.Add(this.pc_vets);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_pets);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_customers);
            this.panel2.Controls.Add(this.txtt_vets);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_activeAppo);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 726);
            this.panel2.TabIndex = 129;
            // 
            // lbl_totalAppo
            // 
            this.lbl_totalAppo.AutoSize = true;
            this.lbl_totalAppo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_totalAppo.Location = new System.Drawing.Point(61, 351);
            this.lbl_totalAppo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalAppo.MaximumSize = new System.Drawing.Size(133, 0);
            this.lbl_totalAppo.Name = "lbl_totalAppo";
            this.lbl_totalAppo.Size = new System.Drawing.Size(71, 38);
            this.lbl_totalAppo.TabIndex = 131;
            this.lbl_totalAppo.Text = "100";
            this.lbl_totalAppo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PawMateApp.Properties.Resources.rec;
            this.pictureBox1.Location = new System.Drawing.Point(37, 314);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            // 
            // profile_img
            // 
            this.profile_img.Image = global::PawMateApp.Properties.Resources.profile_img21;
            this.profile_img.Location = new System.Drawing.Point(0, 4);
            this.profile_img.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profile_img.Name = "profile_img";
            this.profile_img.Size = new System.Drawing.Size(712, 209);
            this.profile_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_img.TabIndex = 129;
            this.profile_img.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1077, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_updateImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Profile";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtt_vets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_activeAppo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_totalMedicine;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_customers;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_allPresp;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbl_vets;
        private System.Windows.Forms.PictureBox pc_vets;
        private System.Windows.Forms.Label lbl_pets;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox profile_img;
        private System.Windows.Forms.Label lbl_totalAppo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}