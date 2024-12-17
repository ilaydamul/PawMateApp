namespace PawMateApp.Screens
{
    partial class PatientManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patientList = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_noPat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_treatments = new System.Windows.Forms.ComboBox();
            this.dt_diagnosisDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pets = new System.Windows.Forms.ComboBox();
            this.txt_treatmentDuration = new System.Windows.Forms.TextBox();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_customers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_addPrescription = new System.Windows.Forms.Button();
            this.patientList.SuspendLayout();
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
            this.txt_title.Size = new System.Drawing.Size(214, 32);
            this.txt_title.TabIndex = 6;
            this.txt_title.Text = "Hasta Yönetimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(272, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 176;
            this.label2.Text = "Arama Yapın:";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.White;
            this.txt_search.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(378, 50);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(185, 22);
            this.txt_search.TabIndex = 169;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(270, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 173;
            this.label5.Text = "Hastalar";
            // 
            // patientList
            // 
            this.patientList.AutoScroll = true;
            this.patientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.patientList.Controls.Add(this.txt_noPat);
            this.patientList.Location = new System.Drawing.Point(274, 107);
            this.patientList.Name = "patientList";
            this.patientList.Size = new System.Drawing.Size(522, 471);
            this.patientList.TabIndex = 172;
            // 
            // txt_noPat
            // 
            this.txt_noPat.AutoSize = true;
            this.txt_noPat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_noPat.Location = new System.Drawing.Point(3, 0);
            this.txt_noPat.Name = "txt_noPat";
            this.txt_noPat.Size = new System.Drawing.Size(336, 18);
            this.txt_noPat.TabIndex = 10;
            this.txt_noPat.Text = "Aranan kriterlere uygun hasta kaydı bulunamadı.";
            this.txt_noPat.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PawMateApp.Properties.Resources.patient_img;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 171;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_notes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_treatments);
            this.panel1.Controls.Add(this.dt_diagnosisDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_pets);
            this.panel1.Controls.Add(this.txt_treatmentDuration);
            this.panel1.Controls.Add(this.txt_patientName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_customers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_addPrescription);
            this.panel1.Location = new System.Drawing.Point(12, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 412);
            this.panel1.TabIndex = 170;
            // 
            // txt_notes
            // 
            this.txt_notes.BackColor = System.Drawing.Color.White;
            this.txt_notes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_notes.Location = new System.Drawing.Point(14, 292);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(226, 50);
            this.txt_notes.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 137;
            this.label9.Text = "Ek Notlar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 135;
            this.label7.Text = "Tedavi Yöntemi";
            // 
            // cb_treatments
            // 
            this.cb_treatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_treatments.FormattingEnabled = true;
            this.cb_treatments.Location = new System.Drawing.Point(15, 204);
            this.cb_treatments.Name = "cb_treatments";
            this.cb_treatments.Size = new System.Drawing.Size(226, 21);
            this.cb_treatments.TabIndex = 134;
            // 
            // dt_diagnosisDate
            // 
            this.dt_diagnosisDate.Location = new System.Drawing.Point(15, 162);
            this.dt_diagnosisDate.Name = "dt_diagnosisDate";
            this.dt_diagnosisDate.Size = new System.Drawing.Size(225, 20);
            this.dt_diagnosisDate.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 132;
            this.label3.Text = "Teşhis Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 131;
            this.label1.Text = "Pet";
            // 
            // cb_pets
            // 
            this.cb_pets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pets.FormattingEnabled = true;
            this.cb_pets.Location = new System.Drawing.Point(15, 73);
            this.cb_pets.Name = "cb_pets";
            this.cb_pets.Size = new System.Drawing.Size(227, 21);
            this.cb_pets.TabIndex = 130;
            // 
            // txt_treatmentDuration
            // 
            this.txt_treatmentDuration.BackColor = System.Drawing.Color.White;
            this.txt_treatmentDuration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_treatmentDuration.Location = new System.Drawing.Point(14, 248);
            this.txt_treatmentDuration.Name = "txt_treatmentDuration";
            this.txt_treatmentDuration.Size = new System.Drawing.Size(226, 22);
            this.txt_treatmentDuration.TabIndex = 3;
            // 
            // txt_patientName
            // 
            this.txt_patientName.BackColor = System.Drawing.Color.White;
            this.txt_patientName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_patientName.Location = new System.Drawing.Point(15, 116);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(226, 22);
            this.txt_patientName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = "Müşteri";
            // 
            // cb_customers
            // 
            this.cb_customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_customers.FormattingEnabled = true;
            this.cb_customers.Location = new System.Drawing.Point(15, 29);
            this.cb_customers.Name = "cb_customers";
            this.cb_customers.Size = new System.Drawing.Size(227, 21);
            this.cb_customers.TabIndex = 1;
            this.cb_customers.SelectedIndexChanged += new System.EventHandler(this.cb_customers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 126;
            this.label4.Text = "Hastalık Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 118;
            this.label8.Text = "Tedavi Süresi";
            // 
            // btn_addPrescription
            // 
            this.btn_addPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addPrescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addPrescription.ForeColor = System.Drawing.Color.White;
            this.btn_addPrescription.Location = new System.Drawing.Point(14, 358);
            this.btn_addPrescription.Name = "btn_addPrescription";
            this.btn_addPrescription.Size = new System.Drawing.Size(226, 37);
            this.btn_addPrescription.TabIndex = 4;
            this.btn_addPrescription.Text = "Ekle";
            this.btn_addPrescription.UseVisualStyleBackColor = false;
            this.btn_addPrescription.Click += new System.EventHandler(this.btn_addPrescription_Click);
            // 
            // PatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patientList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientManagement";
            this.Text = "PatientManagement";
            this.Load += new System.EventHandler(this.PatientManagement_Load);
            this.patientList.ResumeLayout(false);
            this.patientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel patientList;
        private System.Windows.Forms.Label txt_noPat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_treatmentDuration;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_customers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_addPrescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_pets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_treatments;
        private System.Windows.Forms.DateTimePicker dt_diagnosisDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label9;
    }
}