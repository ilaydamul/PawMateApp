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
            this.tabControl1.SuspendLayout();
            this.tab_customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.customerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.txt_customerAlternatePhone.TabIndex = 152;
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
            this.txt_customerAlternate.TabIndex = 149;
            // 
            // txt_customerAddress
            // 
            this.txt_customerAddress.BackColor = System.Drawing.Color.White;
            this.txt_customerAddress.Location = new System.Drawing.Point(19, 352);
            this.txt_customerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerAddress.Name = "txt_customerAddress";
            this.txt_customerAddress.Size = new System.Drawing.Size(300, 26);
            this.txt_customerAddress.TabIndex = 148;
            // 
            // txt_customerPhone
            // 
            this.txt_customerPhone.Location = new System.Drawing.Point(19, 244);
            this.txt_customerPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_customerPhone.Mask = "9990000000";
            this.txt_customerPhone.Name = "txt_customerPhone";
            this.txt_customerPhone.Size = new System.Drawing.Size(300, 26);
            this.txt_customerPhone.TabIndex = 126;
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
            this.txt_customerEmail.TabIndex = 1;
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
            this.btn_addCustomer.TabIndex = 4;
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
            this.tab_pets.Location = new System.Drawing.Point(4, 32);
            this.tab_pets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_pets.Name = "tab_pets";
            this.tab_pets.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_pets.Size = new System.Drawing.Size(1037, 637);
            this.tab_pets.TabIndex = 1;
            this.tab_pets.Text = "Petler";
            this.tab_pets.UseVisualStyleBackColor = true;
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
    }
}