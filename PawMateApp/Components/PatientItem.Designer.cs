namespace PawMateApp.Components
{
    partial class PatientItem
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
            this.txt_vetName = new System.Windows.Forms.Label();
            this.txt_petName = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_visitDate = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.pet_image = new System.Windows.Forms.PictureBox();
            this.img_stock = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vetName
            // 
            this.txt_vetName.AutoSize = true;
            this.txt_vetName.Font = new System.Drawing.Font("Arial", 9.25F);
            this.txt_vetName.Location = new System.Drawing.Point(133, 62);
            this.txt_vetName.Name = "txt_vetName";
            this.txt_vetName.Size = new System.Drawing.Size(80, 16);
            this.txt_vetName.TabIndex = 177;
            this.txt_vetName.Text = "Veteriner Adı";
            // 
            // txt_petName
            // 
            this.txt_petName.AutoSize = true;
            this.txt_petName.Font = new System.Drawing.Font("Arial", 9.25F);
            this.txt_petName.Location = new System.Drawing.Point(123, 46);
            this.txt_petName.Name = "txt_petName";
            this.txt_petName.Size = new System.Drawing.Size(49, 16);
            this.txt_petName.TabIndex = 176;
            this.txt_petName.Text = "Pet Adı";
            // 
            // txt_customerName
            // 
            this.txt_customerName.AutoSize = true;
            this.txt_customerName.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Bold);
            this.txt_customerName.Location = new System.Drawing.Point(146, 30);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(78, 16);
            this.txt_customerName.TabIndex = 174;
            this.txt_customerName.Text = "Müşteri Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label6.Location = new System.Drawing.Point(65, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 171;
            this.label6.Text = "Veteriner:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label5.Location = new System.Drawing.Point(64, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 170;
            this.label5.Text = "Pet Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label3.Location = new System.Drawing.Point(64, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 168;
            this.label3.Text = "Müşteri Adı:";
            // 
            // txt_visitDate
            // 
            this.txt_visitDate.AutoSize = true;
            this.txt_visitDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_visitDate.Location = new System.Drawing.Point(39, 8);
            this.txt_visitDate.Name = "txt_visitDate";
            this.txt_visitDate.Size = new System.Drawing.Size(79, 16);
            this.txt_visitDate.TabIndex = 166;
            this.txt_visitDate.Text = "02.08.2024";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_edit.BackgroundImage = global::PawMateApp.Properties.Resources.edit;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(418, 26);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(35, 34);
            this.btn_edit.TabIndex = 178;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // pet_image
            // 
            this.pet_image.Image = global::PawMateApp.Properties.Resources.cat_pic;
            this.pet_image.Location = new System.Drawing.Point(7, 32);
            this.pet_image.Name = "pet_image";
            this.pet_image.Size = new System.Drawing.Size(48, 44);
            this.pet_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pet_image.TabIndex = 173;
            this.pet_image.TabStop = false;
            // 
            // img_stock
            // 
            this.img_stock.Image = global::PawMateApp.Properties.Resources.date_calendar;
            this.img_stock.Location = new System.Drawing.Point(7, 6);
            this.img_stock.Name = "img_stock";
            this.img_stock.Size = new System.Drawing.Size(26, 20);
            this.img_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_stock.TabIndex = 167;
            this.img_stock.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.BackgroundImage = global::PawMateApp.Properties.Resources.bin;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(459, 25);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(38, 37);
            this.btn_delete.TabIndex = 165;
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // PatientItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_vetName);
            this.Controls.Add(this.txt_petName);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.pet_image);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img_stock);
            this.Controls.Add(this.txt_visitDate);
            this.Controls.Add(this.btn_delete);
            this.Name = "PatientItem";
            this.Size = new System.Drawing.Size(500, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_vetName;
        private System.Windows.Forms.Label txt_petName;
        private System.Windows.Forms.Label txt_customerName;
        private System.Windows.Forms.PictureBox pet_image;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox img_stock;
        private System.Windows.Forms.Label txt_visitDate;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
    }
}
