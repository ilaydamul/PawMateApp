namespace PawMateApp.Components
{
    partial class StockItem
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
            this.txt_description = new System.Windows.Forms.Label();
            this.txt_medicineName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_stock = new System.Windows.Forms.PictureBox();
            this.btn_deleteStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Arial", 9.25F);
            this.txt_description.Location = new System.Drawing.Point(4, 64);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(113, 20);
            this.txt_description.TabIndex = 145;
            this.txt_description.Text = "Kalan Miktar:";
            // 
            // txt_medicineName
            // 
            this.txt_medicineName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_medicineName.Location = new System.Drawing.Point(61, 11);
            this.txt_medicineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_medicineName.Name = "txt_medicineName";
            this.txt_medicineName.Size = new System.Drawing.Size(197, 30);
            this.txt_medicineName.TabIndex = 144;
            this.txt_medicineName.Text = "İlaç Adı";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 147;
            this.label1.Text = "89";
            // 
            // img_stock
            // 
            this.img_stock.Image = global::PawMateApp.Properties.Resources.green_light;
            this.img_stock.Location = new System.Drawing.Point(4, 4);
            this.img_stock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_stock.Name = "img_stock";
            this.img_stock.Size = new System.Drawing.Size(53, 49);
            this.img_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_stock.TabIndex = 146;
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
            this.btn_deleteStock.Location = new System.Drawing.Point(223, 111);
            this.btn_deleteStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deleteStock.Name = "btn_deleteStock";
            this.btn_deleteStock.Size = new System.Drawing.Size(47, 42);
            this.btn_deleteStock.TabIndex = 142;
            this.btn_deleteStock.UseVisualStyleBackColor = false;
            this.btn_deleteStock.Click += new System.EventHandler(this.btn_deleteStock_Click);
            // 
            // StockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_stock);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_medicineName);
            this.Controls.Add(this.btn_deleteStock);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StockItem";
            this.Size = new System.Drawing.Size(283, 162);
            this.Load += new System.EventHandler(this.StockItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_stock;
        private System.Windows.Forms.Label txt_description;
        private System.Windows.Forms.Label txt_medicineName;
        private System.Windows.Forms.Button btn_deleteStock;
        private System.Windows.Forms.Label label1;
    }
}
