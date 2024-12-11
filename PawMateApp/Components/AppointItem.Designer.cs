namespace PawMateApp.Components
{
    partial class AppointItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_visitDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.Label();
            this.txt_customerPhone = new System.Windows.Forms.Label();
            this.txt_petName = new System.Windows.Forms.Label();
            this.txt_vetName = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.Label();
            this.pet_image = new System.Windows.Forms.PictureBox();
            this.img_stock = new System.Windows.Forms.PictureBox();
            this.btn_deleteStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_visitDate
            // 
            this.txt_visitDate.AutoSize = true;
            this.txt_visitDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.txt_visitDate.Location = new System.Drawing.Point(46, 14);
            this.txt_visitDate.Name = "txt_visitDate";
            this.txt_visitDate.Size = new System.Drawing.Size(108, 22);
            this.txt_visitDate.TabIndex = 149;
            this.txt_visitDate.Text = "02.08.2024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label3.Location = new System.Drawing.Point(106, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 154;
            this.label3.Text = "Müşteri Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label4.Location = new System.Drawing.Point(107, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 155;
            this.label4.Text = "Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label5.Location = new System.Drawing.Point(108, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 156;
            this.label5.Text = "Pet Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label6.Location = new System.Drawing.Point(108, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 157;
            this.label6.Text = "Veteriner:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label7.Location = new System.Drawing.Point(108, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 158;
            this.label7.Text = "Ziyaret Sebebi:";
            // 
            // txt_customerName
            // 
            this.txt_customerName.AutoSize = true;
            this.txt_customerName.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.txt_customerName.Location = new System.Drawing.Point(184, 50);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(78, 16);
            this.txt_customerName.TabIndex = 160;
            this.txt_customerName.Text = "Müşteri Adı";
            // 
            // txt_customerPhone
            // 
            this.txt_customerPhone.AutoSize = true;
            this.txt_customerPhone.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.txt_customerPhone.Location = new System.Drawing.Point(184, 67);
            this.txt_customerPhone.Name = "txt_customerPhone";
            this.txt_customerPhone.Size = new System.Drawing.Size(75, 16);
            this.txt_customerPhone.TabIndex = 161;
            this.txt_customerPhone.Text = "Telefon No";
            // 
            // txt_petName
            // 
            this.txt_petName.AutoSize = true;
            this.txt_petName.Font = new System.Drawing.Font("Arial", 9.25F);
            this.txt_petName.Location = new System.Drawing.Point(167, 83);
            this.txt_petName.Name = "txt_petName";
            this.txt_petName.Size = new System.Drawing.Size(49, 16);
            this.txt_petName.TabIndex = 162;
            this.txt_petName.Text = "Pet Adı";
            // 
            // txt_vetName
            // 
            this.txt_vetName.AutoSize = true;
            this.txt_vetName.Font = new System.Drawing.Font("Arial", 9.25F);
            this.txt_vetName.Location = new System.Drawing.Point(176, 99);
            this.txt_vetName.Name = "txt_vetName";
            this.txt_vetName.Size = new System.Drawing.Size(80, 16);
            this.txt_vetName.TabIndex = 163;
            this.txt_vetName.Text = "Veteriner Adı";
            // 
            // txt_reason
            // 
            this.txt_reason.AutoSize = true;
            this.txt_reason.Font = new System.Drawing.Font("Arial", 9.25F);
            this.txt_reason.Location = new System.Drawing.Point(208, 115);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(44, 16);
            this.txt_reason.TabIndex = 164;
            this.txt_reason.Text = "Sebep";
            // 
            // pet_image
            // 
            this.pet_image.Image = global::PawMateApp.Properties.Resources.cat_pic;
            this.pet_image.Location = new System.Drawing.Point(14, 50);
            this.pet_image.Name = "pet_image";
            this.pet_image.Size = new System.Drawing.Size(86, 81);
            this.pet_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pet_image.TabIndex = 159;
            this.pet_image.TabStop = false;
            // 
            // img_stock
            // 
            this.img_stock.Image = global::PawMateApp.Properties.Resources.date_calendar;
            this.img_stock.Location = new System.Drawing.Point(14, 10);
            this.img_stock.Name = "img_stock";
            this.img_stock.Size = new System.Drawing.Size(29, 29);
            this.img_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_stock.TabIndex = 151;
            this.img_stock.TabStop = false;
            // 
            // btn_deleteStock
            // 
            this.btn_deleteStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_deleteStock.BackgroundImage = global::PawMateApp.Properties.Resources.bin;
            this.btn_deleteStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_deleteStock.FlatAppearance.BorderSize = 0;
            this.btn_deleteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteStock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_deleteStock.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteStock.Location = new System.Drawing.Point(461, 3);
            this.btn_deleteStock.Name = "btn_deleteStock";
            this.btn_deleteStock.Size = new System.Drawing.Size(35, 34);
            this.btn_deleteStock.TabIndex = 148;
            this.btn_deleteStock.UseVisualStyleBackColor = false;
            // 
            // AppointItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.txt_vetName);
            this.Controls.Add(this.txt_petName);
            this.Controls.Add(this.txt_customerPhone);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.pet_image);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img_stock);
            this.Controls.Add(this.txt_visitDate);
            this.Controls.Add(this.btn_deleteStock);
            this.Name = "AppointItem";
            this.Size = new System.Drawing.Size(499, 147);
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox img_stock;
        private System.Windows.Forms.Label txt_visitDate;
        private System.Windows.Forms.Button btn_deleteStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pet_image;
        private System.Windows.Forms.Label txt_customerName;
        private System.Windows.Forms.Label txt_customerPhone;
        private System.Windows.Forms.Label txt_petName;
        private System.Windows.Forms.Label txt_vetName;
        private System.Windows.Forms.Label txt_reason;
    }
}
