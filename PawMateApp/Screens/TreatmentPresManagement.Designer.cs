namespace PawMateApp.Screens
{
    partial class TreatmentPresManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreatmentPresManagement));
            this.txt_title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prescriptionList = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_noRec = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_usageInstructions = new System.Windows.Forms.TextBox();
            this.cb_visits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_medicines = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_addPrescription = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_dateChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.MaskedTextBox();
            this.prescriptionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(233, 32);
            this.txt_title.TabIndex = 6;
            this.txt_title.Text = "Reçete Planlama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(9, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 166;
            this.label3.Text = "Reçete Yaz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(270, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 23);
            this.label5.TabIndex = 165;
            this.label5.Text = "Yazılan Reçeteler";
            // 
            // prescriptionList
            // 
            this.prescriptionList.AutoScroll = true;
            this.prescriptionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.prescriptionList.Controls.Add(this.txt_noRec);
            this.prescriptionList.Location = new System.Drawing.Point(274, 109);
            this.prescriptionList.Name = "prescriptionList";
            this.prescriptionList.Size = new System.Drawing.Size(522, 466);
            this.prescriptionList.TabIndex = 163;
            // 
            // txt_noRec
            // 
            this.txt_noRec.AutoSize = true;
            this.txt_noRec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_noRec.Location = new System.Drawing.Point(3, 0);
            this.txt_noRec.Name = "txt_noRec";
            this.txt_noRec.Size = new System.Drawing.Size(302, 18);
            this.txt_noRec.TabIndex = 10;
            this.txt_noRec.Text = "Aranan kriterlere uygun reçete bulunamadı.";
            this.txt_noRec.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PawMateApp.Properties.Resources.appoint_img;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 162;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.txt_usageInstructions);
            this.panel1.Controls.Add(this.cb_visits);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_medicines);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_addPrescription);
            this.panel1.Location = new System.Drawing.Point(12, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 326);
            this.panel1.TabIndex = 161;
            // 
            // txt_usageInstructions
            // 
            this.txt_usageInstructions.BackColor = System.Drawing.Color.White;
            this.txt_usageInstructions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_usageInstructions.Location = new System.Drawing.Point(16, 162);
            this.txt_usageInstructions.Multiline = true;
            this.txt_usageInstructions.Name = "txt_usageInstructions";
            this.txt_usageInstructions.Size = new System.Drawing.Size(226, 67);
            this.txt_usageInstructions.TabIndex = 3;
            // 
            // cb_visits
            // 
            this.cb_visits.FormattingEnabled = true;
            this.cb_visits.Location = new System.Drawing.Point(15, 31);
            this.cb_visits.Name = "cb_visits";
            this.cb_visits.Size = new System.Drawing.Size(227, 21);
            this.cb_visits.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = "İlaç";
            // 
            // cb_medicines
            // 
            this.cb_medicines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_medicines.FormattingEnabled = true;
            this.cb_medicines.Location = new System.Drawing.Point(15, 73);
            this.cb_medicines.Name = "cb_medicines";
            this.cb_medicines.Size = new System.Drawing.Size(227, 21);
            this.cb_medicines.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 126;
            this.label4.Text = "Dozaj / Miktar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Hastalar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 118;
            this.label8.Text = "Kullanım Talimatı";
            // 
            // btn_addPrescription
            // 
            this.btn_addPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPrescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addPrescription.ForeColor = System.Drawing.Color.White;
            this.btn_addPrescription.Location = new System.Drawing.Point(16, 277);
            this.btn_addPrescription.Name = "btn_addPrescription";
            this.btn_addPrescription.Size = new System.Drawing.Size(226, 37);
            this.btn_addPrescription.TabIndex = 4;
            this.btn_addPrescription.Text = "Ekle";
            this.btn_addPrescription.UseVisualStyleBackColor = false;
            this.btn_addPrescription.Click += new System.EventHandler(this.btn_addPrescription_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.White;
            this.txt_search.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(378, 46);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(185, 22);
            this.txt_search.TabIndex = 129;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_research_TextChanged);
            // 
            // btn_dateChange
            // 
            this.btn_dateChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_dateChange.FlatAppearance.BorderSize = 0;
            this.btn_dateChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dateChange.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dateChange.ForeColor = System.Drawing.Color.Black;
            this.btn_dateChange.Image = ((System.Drawing.Image)(resources.GetObject("btn_dateChange.Image")));
            this.btn_dateChange.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dateChange.Location = new System.Drawing.Point(569, 46);
            this.btn_dateChange.Name = "btn_dateChange";
            this.btn_dateChange.Size = new System.Drawing.Size(105, 22);
            this.btn_dateChange.TabIndex = 167;
            this.btn_dateChange.Text = "Tarih Azalan";
            this.btn_dateChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dateChange.UseVisualStyleBackColor = false;
            this.btn_dateChange.Click += new System.EventHandler(this.btn_dateChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(272, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 168;
            this.label2.Text = "Arama Yapın:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_quantity.Location = new System.Drawing.Point(16, 118);
            this.txt_quantity.Mask = "00000";
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(226, 22);
            this.txt_quantity.TabIndex = 129;
            // 
            // TreatmentPresManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dateChange);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prescriptionList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreatmentPresManagement";
            this.Text = "TreatmentManagement";
            this.Load += new System.EventHandler(this.TreatmentPresManagement_Load);
            this.prescriptionList.ResumeLayout(false);
            this.prescriptionList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.FlowLayoutPanel prescriptionList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_visits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_medicines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_addPrescription;
        private System.Windows.Forms.TextBox txt_usageInstructions;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_dateChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_noRec;
        private System.Windows.Forms.MaskedTextBox txt_quantity;
    }
}