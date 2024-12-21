namespace PawMateApp.Screens
{
    partial class PetAndCustomerManagement
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
            this.txt_title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_customers = new System.Windows.Forms.TabPage();
            this.btn_addCustomerBtn = new System.Windows.Forms.Button();
            this.customerList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_customerAlternatePhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_customerAlternate = new System.Windows.Forms.TextBox();
            this.txt_customerAddress = new System.Windows.Forms.TextBox();
            this.txt_customerPhone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_customerEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.btn_deleteCustomer = new System.Windows.Forms.Button();
            this.tab_pets = new System.Windows.Forms.TabPage();
            this.btn_addPetBtn = new System.Windows.Forms.Button();
            this.petList = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.radio_disi = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_species = new System.Windows.Forms.ComboBox();
            this.cb_customers = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_breed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_petName = new System.Windows.Forms.TextBox();
            this.btn_addPet = new System.Windows.Forms.Button();
            this.btn_deletePet = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_pets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(8, 11);
            this.txt_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(399, 40);
            this.txt_title.TabIndex = 6;
            this.txt_title.Text = "Pet ve Müşteri Yönetimi";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_customers);
            this.tabControl1.Controls.Add(this.tab_pets);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(16, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 673);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Tag = "";
            // 
            // tab_customers
            // 
            this.tab_customers.Controls.Add(this.btn_addCustomerBtn);
            this.tab_customers.Controls.Add(this.customerList);
            this.tab_customers.Controls.Add(this.panel1);
            this.tab_customers.Controls.Add(this.btn_deleteCustomer);
            this.tab_customers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tab_customers.Location = new System.Drawing.Point(4, 32);
            this.tab_customers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_customers.Name = "tab_customers";
            this.tab_customers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_customers.Size = new System.Drawing.Size(1037, 637);
            this.tab_customers.TabIndex = 0;
            this.tab_customers.Text = "Müşteriler";
            this.tab_customers.UseVisualStyleBackColor = true;
            // 
            // btn_addCustomerBtn
            // 
            this.btn_addCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.btn_addCustomerBtn.Location = new System.Drawing.Point(816, 4);
            this.btn_addCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addCustomerBtn.Name = "btn_addCustomerBtn";
            this.btn_addCustomerBtn.Size = new System.Drawing.Size(211, 41);
            this.btn_addCustomerBtn.TabIndex = 151;
            this.btn_addCustomerBtn.Text = "Müşteri Ekle";
            this.btn_addCustomerBtn.UseVisualStyleBackColor = false;
            this.btn_addCustomerBtn.Click += new System.EventHandler(this.btn_addCustomerBtn_Click);
            // 
            // customerList
            // 
            this.customerList.AllowUserToAddRows = false;
            this.customerList.BackgroundColor = System.Drawing.Color.White;
            this.customerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerList.GridColor = System.Drawing.Color.White;
            this.customerList.Location = new System.Drawing.Point(357, 52);
            this.customerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerList.Name = "customerList";
            this.customerList.RowHeadersWidth = 51;
            this.customerList.Size = new System.Drawing.Size(669, 530);
            this.customerList.TabIndex = 148;
            this.customerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerList_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_customerAlternatePhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_customerAlternate);
            this.panel1.Controls.Add(this.txt_customerAddress);
            this.panel1.Controls.Add(this.txt_customerPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_customerEmail);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_customerName);
            this.panel1.Controls.Add(this.btn_addCustomer);
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 617);
            this.panel1.TabIndex = 146;
            // 
            // txt_customerAlternatePhone
            // 
            this.txt_customerAlternatePhone.Location = new System.Drawing.Point(19, 460);
            this.txt_customerAlternatePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerAlternatePhone.Mask = "9990000000";
            this.txt_customerAlternatePhone.Name = "txt_customerAlternatePhone";
            this.txt_customerAlternatePhone.Size = new System.Drawing.Size(300, 26);
            this.txt_customerAlternatePhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 151;
            this.label4.Text = "Alternatif Telefon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PawMateApp.Properties.Resources.medicineManag;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 383);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 150;
            this.label5.Text = "Alternatif Kişi";
            // 
            // txt_customerAlternate
            // 
            this.txt_customerAlternate.BackColor = System.Drawing.Color.White;
            this.txt_customerAlternate.Location = new System.Drawing.Point(19, 406);
            this.txt_customerAlternate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerAlternate.Name = "txt_customerAlternate";
            this.txt_customerAlternate.Size = new System.Drawing.Size(300, 26);
            this.txt_customerAlternate.TabIndex = 4;
            // 
            // txt_customerAddress
            // 
            this.txt_customerAddress.BackColor = System.Drawing.Color.White;
            this.txt_customerAddress.Location = new System.Drawing.Point(19, 352);
            this.txt_customerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerAddress.Name = "txt_customerAddress";
            this.txt_customerAddress.Size = new System.Drawing.Size(300, 26);
            this.txt_customerAddress.TabIndex = 3;
            // 
            // txt_customerPhone
            // 
            this.txt_customerPhone.Location = new System.Drawing.Point(19, 244);
            this.txt_customerPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerPhone.Mask = "9990000000";
            this.txt_customerPhone.Name = "txt_customerPhone";
            this.txt_customerPhone.Size = new System.Drawing.Size(300, 26);
            this.txt_customerPhone.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 124;
            this.label2.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 122;
            this.label1.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 120;
            this.label3.Text = "Telefon Numarası";
            // 
            // txt_customerEmail
            // 
            this.txt_customerEmail.BackColor = System.Drawing.Color.White;
            this.txt_customerEmail.Location = new System.Drawing.Point(19, 298);
            this.txt_customerEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerEmail.Name = "txt_customerEmail";
            this.txt_customerEmail.Size = new System.Drawing.Size(300, 26);
            this.txt_customerEmail.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 118;
            this.label8.Text = "Ad Soyad";
            // 
            // txt_customerName
            // 
            this.txt_customerName.BackColor = System.Drawing.Color.White;
            this.txt_customerName.Location = new System.Drawing.Point(17, 190);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(300, 26);
            this.txt_customerName.TabIndex = 0;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_addCustomer.Location = new System.Drawing.Point(19, 556);
            this.btn_addCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(301, 46);
            this.btn_addCustomer.TabIndex = 6;
            this.btn_addCustomer.Text = "Ekle";
            this.btn_addCustomer.UseVisualStyleBackColor = false;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_deleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btn_deleteCustomer.Location = new System.Drawing.Point(816, 590);
            this.btn_deleteCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(211, 37);
            this.btn_deleteCustomer.TabIndex = 150;
            this.btn_deleteCustomer.Text = "Sil";
            this.btn_deleteCustomer.UseVisualStyleBackColor = false;
            this.btn_deleteCustomer.Click += new System.EventHandler(this.btn_deleteCustomer_Click);
            // 
            // tab_pets
            // 
            this.tab_pets.Controls.Add(this.btn_addPetBtn);
            this.tab_pets.Controls.Add(this.petList);
            this.tab_pets.Controls.Add(this.panel2);
            this.tab_pets.Controls.Add(this.btn_deletePet);
            this.tab_pets.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tab_pets.Location = new System.Drawing.Point(4, 32);
            this.tab_pets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_pets.Name = "tab_pets";
            this.tab_pets.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_pets.Size = new System.Drawing.Size(1037, 637);
            this.tab_pets.TabIndex = 1;
            this.tab_pets.Text = "Petler";
            this.tab_pets.UseVisualStyleBackColor = true;
            this.tab_pets.Click += new System.EventHandler(this.tab_pets_Click);
            // 
            // btn_addPetBtn
            // 
            this.btn_addPetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addPetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPetBtn.ForeColor = System.Drawing.Color.White;
            this.btn_addPetBtn.Location = new System.Drawing.Point(816, 4);
            this.btn_addPetBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addPetBtn.Name = "btn_addPetBtn";
            this.btn_addPetBtn.Size = new System.Drawing.Size(211, 41);
            this.btn_addPetBtn.TabIndex = 155;
            this.btn_addPetBtn.Text = "Pet Ekle";
            this.btn_addPetBtn.UseVisualStyleBackColor = false;
            this.btn_addPetBtn.Click += new System.EventHandler(this.btn_addPetBtn_Click);
            // 
            // petList
            // 
            this.petList.AllowUserToAddRows = false;
            this.petList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petList.Location = new System.Drawing.Point(357, 52);
            this.petList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.petList.Name = "petList";
            this.petList.RowHeadersWidth = 51;
            this.petList.Size = new System.Drawing.Size(669, 530);
            this.petList.TabIndex = 153;
            this.petList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.petList_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.radio_erkek);
            this.panel2.Controls.Add(this.radio_disi);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cb_species);
            this.panel2.Controls.Add(this.cb_customers);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txt_breed);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_petName);
            this.panel2.Controls.Add(this.btn_addPet);
            this.panel2.Location = new System.Drawing.Point(8, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 617);
            this.panel2.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 159;
            this.label6.Text = "Cinsiyet";
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_erkek.Location = new System.Drawing.Point(89, 412);
            this.radio_erkek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(66, 21);
            this.radio_erkek.TabIndex = 158;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // radio_disi
            // 
            this.radio_disi.AutoSize = true;
            this.radio_disi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_disi.Location = new System.Drawing.Point(19, 412);
            this.radio_disi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_disi.Name = "radio_disi";
            this.radio_disi.Size = new System.Drawing.Size(54, 21);
            this.radio_disi.TabIndex = 157;
            this.radio_disi.TabStop = true;
            this.radio_disi.Text = "Dişi";
            this.radio_disi.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 274);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 19);
            this.label12.TabIndex = 156;
            this.label12.Text = "Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(15, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 19);
            this.label10.TabIndex = 155;
            this.label10.Text = "Sahibi";
            // 
            // cb_species
            // 
            this.cb_species.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_species.FormattingEnabled = true;
            this.cb_species.Location = new System.Drawing.Point(17, 298);
            this.cb_species.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_species.Name = "cb_species";
            this.cb_species.Size = new System.Drawing.Size(301, 26);
            this.cb_species.TabIndex = 154;
            // 
            // cb_customers
            // 
            this.cb_customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_customers.FormattingEnabled = true;
            this.cb_customers.Location = new System.Drawing.Point(19, 187);
            this.cb_customers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_customers.Name = "cb_customers";
            this.cb_customers.Size = new System.Drawing.Size(301, 26);
            this.cb_customers.TabIndex = 153;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::PawMateApp.Properties.Resources.pets;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(333, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 147;
            this.pictureBox2.TabStop = false;
            // 
            // txt_breed
            // 
            this.txt_breed.BackColor = System.Drawing.Color.White;
            this.txt_breed.Location = new System.Drawing.Point(17, 354);
            this.txt_breed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_breed.Name = "txt_breed";
            this.txt_breed.Size = new System.Drawing.Size(300, 26);
            this.txt_breed.TabIndex = 148;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 331);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 124;
            this.label9.Text = "Cinsi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(13, 220);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 120;
            this.label11.Text = "Pet Adı";
            // 
            // txt_petName
            // 
            this.txt_petName.BackColor = System.Drawing.Color.White;
            this.txt_petName.Location = new System.Drawing.Point(17, 244);
            this.txt_petName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_petName.Name = "txt_petName";
            this.txt_petName.Size = new System.Drawing.Size(300, 26);
            this.txt_petName.TabIndex = 1;
            // 
            // btn_addPet
            // 
            this.btn_addPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPet.ForeColor = System.Drawing.Color.White;
            this.btn_addPet.Location = new System.Drawing.Point(19, 556);
            this.btn_addPet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addPet.Name = "btn_addPet";
            this.btn_addPet.Size = new System.Drawing.Size(301, 46);
            this.btn_addPet.TabIndex = 4;
            this.btn_addPet.Text = "Ekle";
            this.btn_addPet.UseVisualStyleBackColor = false;
            this.btn_addPet.Click += new System.EventHandler(this.btn_addPet_Click);
            // 
            // btn_deletePet
            // 
            this.btn_deletePet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_deletePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletePet.ForeColor = System.Drawing.Color.White;
            this.btn_deletePet.Location = new System.Drawing.Point(816, 590);
            this.btn_deletePet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deletePet.Name = "btn_deletePet";
            this.btn_deletePet.Size = new System.Drawing.Size(211, 37);
            this.btn_deletePet.TabIndex = 154;
            this.btn_deletePet.Text = "Sil";
            this.btn_deletePet.UseVisualStyleBackColor = false;
            this.btn_deletePet.Click += new System.EventHandler(this.btn_deletePet_Click);
            // 
            // PetAndCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1077, 726);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PetAndCustomerManagement";
            this.Text = "PetAndCustomerManagement";
            this.Load += new System.EventHandler(this.PetAndCustomerManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_pets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.petList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_customers;
        private System.Windows.Forms.TabPage tab_pets;
        private System.Windows.Forms.Button btn_addCustomerBtn;
        private System.Windows.Forms.DataGridView customerList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txt_customerPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_customerEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.Button btn_deleteCustomer;
        private System.Windows.Forms.TextBox txt_customerAddress;
        private System.Windows.Forms.MaskedTextBox txt_customerAlternatePhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_customerAlternate;
        private System.Windows.Forms.Button btn_addPetBtn;
        private System.Windows.Forms.DataGridView petList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_breed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_petName;
        private System.Windows.Forms.Button btn_addPet;
        private System.Windows.Forms.Button btn_deletePet;
        private System.Windows.Forms.ComboBox cb_customers;
        private System.Windows.Forms.ComboBox cb_species;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.RadioButton radio_disi;
    }
}