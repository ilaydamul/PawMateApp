namespace PawMateApp.Screens
{
    partial class AddAdvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdvert));
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_breed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_genderMan = new System.Windows.Forms.RadioButton();
            this.radio_genderGirl = new System.Windows.Forms.RadioButton();
            this.btn_addAdvert = new System.Windows.Forms.Button();
            this.btn_closeApp = new System.Windows.Forms.PictureBox();
            this.combobox_species = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title.Location = new System.Drawing.Point(6, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(126, 32);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "İlan Ekle";
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.White;
            this.txt_title.Location = new System.Drawing.Point(15, 28);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(555, 20);
            this.txt_title.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 101;
            this.label2.Text = "İlan Başlığı";
            // 
            // txt_content
            // 
            this.txt_content.BackColor = System.Drawing.Color.White;
            this.txt_content.Location = new System.Drawing.Point(15, 114);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(555, 95);
            this.txt_content.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "Açıklama";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.combobox_species);
            this.panel1.Controls.Add(this.btn_addAdvert);
            this.panel1.Controls.Add(this.radio_genderGirl);
            this.panel1.Controls.Add(this.radio_genderMan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_age);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_breed);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_content);
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 368);
            this.panel1.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 14);
            this.label3.TabIndex = 105;
            this.label3.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 107;
            this.label4.Text = "Cins";
            // 
            // txt_breed
            // 
            this.txt_breed.BackColor = System.Drawing.Color.White;
            this.txt_breed.Location = new System.Drawing.Point(206, 70);
            this.txt_breed.Name = "txt_breed";
            this.txt_breed.Size = new System.Drawing.Size(171, 20);
            this.txt_breed.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 14);
            this.label5.TabIndex = 109;
            this.label5.Text = "Yaş";
            // 
            // txt_age
            // 
            this.txt_age.BackColor = System.Drawing.Color.White;
            this.txt_age.Location = new System.Drawing.Point(399, 70);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(171, 20);
            this.txt_age.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 110;
            this.label6.Text = "Cinsiyet";
            // 
            // radio_genderMan
            // 
            this.radio_genderMan.AutoSize = true;
            this.radio_genderMan.Location = new System.Drawing.Point(15, 234);
            this.radio_genderMan.Name = "radio_genderMan";
            this.radio_genderMan.Size = new System.Drawing.Size(53, 17);
            this.radio_genderMan.TabIndex = 111;
            this.radio_genderMan.TabStop = true;
            this.radio_genderMan.Text = "Erkek";
            this.radio_genderMan.UseVisualStyleBackColor = true;
            // 
            // radio_genderGirl
            // 
            this.radio_genderGirl.AutoSize = true;
            this.radio_genderGirl.Location = new System.Drawing.Point(74, 234);
            this.radio_genderGirl.Name = "radio_genderGirl";
            this.radio_genderGirl.Size = new System.Drawing.Size(42, 17);
            this.radio_genderGirl.TabIndex = 112;
            this.radio_genderGirl.TabStop = true;
            this.radio_genderGirl.Text = "Dişi";
            this.radio_genderGirl.UseVisualStyleBackColor = true;
            // 
            // btn_addAdvert
            // 
            this.btn_addAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addAdvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addAdvert.ForeColor = System.Drawing.Color.White;
            this.btn_addAdvert.Location = new System.Drawing.Point(423, 311);
            this.btn_addAdvert.Name = "btn_addAdvert";
            this.btn_addAdvert.Size = new System.Drawing.Size(147, 37);
            this.btn_addAdvert.TabIndex = 113;
            this.btn_addAdvert.Text = "Ekle";
            this.btn_addAdvert.UseVisualStyleBackColor = false;
            // 
            // btn_closeApp
            // 
            this.btn_closeApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_closeApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_closeApp.Image")));
            this.btn_closeApp.Location = new System.Drawing.Point(575, 11);
            this.btn_closeApp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_closeApp.Name = "btn_closeApp";
            this.btn_closeApp.Size = new System.Drawing.Size(21, 24);
            this.btn_closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_closeApp.TabIndex = 105;
            this.btn_closeApp.TabStop = false;
            this.btn_closeApp.Click += new System.EventHandler(this.btn_closeApp_Click);
            // 
            // combobox_species
            // 
            this.combobox_species.FormattingEnabled = true;
            this.combobox_species.Location = new System.Drawing.Point(15, 70);
            this.combobox_species.Name = "combobox_species";
            this.combobox_species.Size = new System.Drawing.Size(167, 21);
            this.combobox_species.TabIndex = 114;
            // 
            // AddAdvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 424);
            this.Controls.Add(this.btn_closeApp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAdvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAdvert";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closeApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_genderGirl;
        private System.Windows.Forms.RadioButton radio_genderMan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_breed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addAdvert;
        private System.Windows.Forms.PictureBox btn_closeApp;
        private System.Windows.Forms.ComboBox combobox_species;
    }
}