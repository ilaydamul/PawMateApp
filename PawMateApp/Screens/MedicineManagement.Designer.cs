namespace PawMateApp.Screens
{
    partial class MedicineManagement
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_deleteMedicine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_medicinePrice = new System.Windows.Forms.MaskedTextBox();
            this.txt_medicineUnit = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_medicineDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_medicineTitle = new System.Windows.Forms.TextBox();
            this.btn_addMedicine = new System.Windows.Forms.Button();
            this.medicineList = new System.Windows.Forms.DataGridView();
            this.btn_addMedicineBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineList)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(186, 32);
            this.txt_title.TabIndex = 6;
            this.txt_title.Text = "İlaç Yönetimi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PawMateApp.Properties.Resources.medicineManag;
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // btn_deleteMedicine
            // 
            this.btn_deleteMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_deleteMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteMedicine.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_deleteMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_deleteMedicine.Location = new System.Drawing.Point(638, 548);
            this.btn_deleteMedicine.Name = "btn_deleteMedicine";
            this.btn_deleteMedicine.Size = new System.Drawing.Size(158, 30);
            this.btn_deleteMedicine.TabIndex = 144;
            this.btn_deleteMedicine.Text = "Sil";
            this.btn_deleteMedicine.UseVisualStyleBackColor = false;
            this.btn_deleteMedicine.Click += new System.EventHandler(this.btn_deleteMedicine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(269, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 143;
            this.label5.Text = "İlaçlar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_medicinePrice);
            this.panel1.Controls.Add(this.txt_medicineUnit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_medicineDesc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_medicineTitle);
            this.panel1.Controls.Add(this.btn_addMedicine);
            this.panel1.Location = new System.Drawing.Point(12, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 354);
            this.panel1.TabIndex = 2;
            // 
            // txt_medicinePrice
            // 
            this.txt_medicinePrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_medicinePrice.Location = new System.Drawing.Point(13, 198);
            this.txt_medicinePrice.Mask = "00000";
            this.txt_medicinePrice.Name = "txt_medicinePrice";
            this.txt_medicinePrice.Size = new System.Drawing.Size(226, 22);
            this.txt_medicinePrice.TabIndex = 126;
            // 
            // txt_medicineUnit
            // 
            this.txt_medicineUnit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_medicineUnit.Location = new System.Drawing.Point(13, 156);
            this.txt_medicineUnit.Mask = "00000";
            this.txt_medicineUnit.Name = "txt_medicineUnit";
            this.txt_medicineUnit.Size = new System.Drawing.Size(226, 22);
            this.txt_medicineUnit.TabIndex = 125;
            this.txt_medicineUnit.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 124;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Birim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 120;
            this.label3.Text = "Açıklama";
            // 
            // txt_medicineDesc
            // 
            this.txt_medicineDesc.BackColor = System.Drawing.Color.White;
            this.txt_medicineDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_medicineDesc.Location = new System.Drawing.Point(13, 72);
            this.txt_medicineDesc.Multiline = true;
            this.txt_medicineDesc.Name = "txt_medicineDesc";
            this.txt_medicineDesc.Size = new System.Drawing.Size(226, 61);
            this.txt_medicineDesc.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 118;
            this.label8.Text = "İlaç Adı";
            // 
            // txt_medicineTitle
            // 
            this.txt_medicineTitle.BackColor = System.Drawing.Color.White;
            this.txt_medicineTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_medicineTitle.Location = new System.Drawing.Point(13, 31);
            this.txt_medicineTitle.Name = "txt_medicineTitle";
            this.txt_medicineTitle.Size = new System.Drawing.Size(226, 22);
            this.txt_medicineTitle.TabIndex = 0;
            // 
            // btn_addMedicine
            // 
            this.btn_addMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMedicine.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addMedicine.ForeColor = System.Drawing.Color.White;
            this.btn_addMedicine.Location = new System.Drawing.Point(13, 305);
            this.btn_addMedicine.Name = "btn_addMedicine";
            this.btn_addMedicine.Size = new System.Drawing.Size(226, 37);
            this.btn_addMedicine.TabIndex = 4;
            this.btn_addMedicine.Text = "Ekle";
            this.btn_addMedicine.UseVisualStyleBackColor = false;
            this.btn_addMedicine.Click += new System.EventHandler(this.btn_addMedicine_Click);
            // 
            // medicineList
            // 
            this.medicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineList.Location = new System.Drawing.Point(274, 75);
            this.medicineList.Name = "medicineList";
            this.medicineList.Size = new System.Drawing.Size(522, 466);
            this.medicineList.TabIndex = 140;
            this.medicineList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicineList_CellClick);
            // 
            // btn_addMedicineBtn
            // 
            this.btn_addMedicineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addMedicineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMedicineBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addMedicineBtn.ForeColor = System.Drawing.Color.White;
            this.btn_addMedicineBtn.Location = new System.Drawing.Point(638, 39);
            this.btn_addMedicineBtn.Name = "btn_addMedicineBtn";
            this.btn_addMedicineBtn.Size = new System.Drawing.Size(158, 33);
            this.btn_addMedicineBtn.TabIndex = 145;
            this.btn_addMedicineBtn.Text = "İlaç Ekle";
            this.btn_addMedicineBtn.UseVisualStyleBackColor = false;
            this.btn_addMedicineBtn.Click += new System.EventHandler(this.btn_addMedicineBtn_Click);
            // 
            // MedicineManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.btn_addMedicineBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_deleteMedicine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.medicineList);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineManagement";
            this.Text = "MedicineManagement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_deleteMedicine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_medicineDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_medicineTitle;
        private System.Windows.Forms.Button btn_addMedicine;
        private System.Windows.Forms.DataGridView medicineList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addMedicineBtn;
        private System.Windows.Forms.MaskedTextBox txt_medicinePrice;
        private System.Windows.Forms.MaskedTextBox txt_medicineUnit;
    }
}