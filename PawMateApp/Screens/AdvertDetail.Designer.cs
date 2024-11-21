namespace PawMateApp.Screens
{
    partial class AdvertDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertDetail));
            this.txt_title = new System.Windows.Forms.Label();
            this.advertImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_content = new System.Windows.Forms.Label();
            this.txt_species = new System.Windows.Forms.Label();
            this.txt_breed = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.Label();
            this.btn_addFavorites = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.advertImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addFavorites)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(161, 32);
            this.txt_title.TabIndex = 3;
            this.txt_title.Text = "İlan Başlığı";
            // 
            // advertImage
            // 
            this.advertImage.BackColor = System.Drawing.Color.White;
            this.advertImage.Image = ((System.Drawing.Image)(resources.GetObject("advertImage.Image")));
            this.advertImage.Location = new System.Drawing.Point(12, 54);
            this.advertImage.Name = "advertImage";
            this.advertImage.Size = new System.Drawing.Size(224, 196);
            this.advertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.advertImage.TabIndex = 4;
            this.advertImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 14);
            this.label3.TabIndex = 106;
            this.label3.Text = "Tür: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 107;
            this.label1.Text = "Cins: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 14);
            this.label2.TabIndex = 108;
            this.label2.Text = "Yaş: ";
            // 
            // txt_content
            // 
            this.txt_content.AutoSize = true;
            this.txt_content.Location = new System.Drawing.Point(281, 54);
            this.txt_content.MaximumSize = new System.Drawing.Size(330, 0);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(44, 13);
            this.txt_content.TabIndex = 109;
            this.txt_content.Text = "Content";
            // 
            // txt_species
            // 
            this.txt_species.AutoSize = true;
            this.txt_species.Location = new System.Drawing.Point(56, 294);
            this.txt_species.Name = "txt_species";
            this.txt_species.Size = new System.Drawing.Size(52, 13);
            this.txt_species.TabIndex = 110;
            this.txt_species.Text = "Tür Bilgisi";
            // 
            // txt_breed
            // 
            this.txt_breed.AutoSize = true;
            this.txt_breed.Location = new System.Drawing.Point(56, 318);
            this.txt_breed.Name = "txt_breed";
            this.txt_breed.Size = new System.Drawing.Size(56, 13);
            this.txt_breed.TabIndex = 111;
            this.txt_breed.Text = "Cins Bilgisi";
            // 
            // txt_age
            // 
            this.txt_age.AutoSize = true;
            this.txt_age.Location = new System.Drawing.Point(56, 341);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(54, 13);
            this.txt_age.TabIndex = 112;
            this.txt_age.Text = "Yaş Bilgisi";
            // 
            // btn_addFavorites
            // 
            this.btn_addFavorites.Image = global::PawMateApp.Properties.Resources.heart_icon;
            this.btn_addFavorites.Location = new System.Drawing.Point(213, 256);
            this.btn_addFavorites.Name = "btn_addFavorites";
            this.btn_addFavorites.Size = new System.Drawing.Size(23, 23);
            this.btn_addFavorites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_addFavorites.TabIndex = 113;
            this.btn_addFavorites.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 14);
            this.label4.TabIndex = 114;
            this.label4.Text = "Favorilere Ekle";
            // 
            // AdvertDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_addFavorites);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_breed);
            this.Controls.Add(this.txt_species);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.advertImage);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdvertDetail";
            this.Text = "AdvertDetail";
            ((System.ComponentModel.ISupportInitialize)(this.advertImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addFavorites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.PictureBox advertImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_content;
        private System.Windows.Forms.Label txt_species;
        private System.Windows.Forms.Label txt_breed;
        private System.Windows.Forms.Label txt_age;
        private System.Windows.Forms.PictureBox btn_addFavorites;
        private System.Windows.Forms.Label label4;
    }
}