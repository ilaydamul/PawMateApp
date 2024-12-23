namespace PawMateApp.Components
{
    partial class PatientEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientEdit));
            this.btn_closePatient = new System.Windows.Forms.PictureBox();
            this.txt_title = new System.Windows.Forms.Label();
            this.lbl_patientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_petName = new System.Windows.Forms.Label();
            this.lbl_customerPhone = new System.Windows.Forms.Label();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_diagnosisDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_treatments = new System.Windows.Forms.ComboBox();
            this.txt_treatmentDuration = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_diagnosisDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_treatmentType = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_treatmentDuration = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_updatePatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_closePatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_closePatient
            // 
            this.btn_closePatient.BackColor = System.Drawing.Color.Transparent;
            this.btn_closePatient.Image = ((System.Drawing.Image)(resources.GetObject("btn_closePatient.Image")));
            this.btn_closePatient.Location = new System.Drawing.Point(318, 11);
            this.btn_closePatient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_closePatient.Name = "btn_closePatient";
            this.btn_closePatient.Size = new System.Drawing.Size(21, 24);
            this.btn_closePatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_closePatient.TabIndex = 10;
            this.btn_closePatient.TabStop = false;
            this.btn_closePatient.Click += new System.EventHandler(this.btn_closePatient_Click);
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 11);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(199, 32);
            this.txt_title.TabIndex = 12;
            this.txt_title.Text = "Hasta Bilgileri";
            // 
            // lbl_patientName
            // 
            this.lbl_patientName.AutoSize = true;
            this.lbl_patientName.Font = new System.Drawing.Font("Arial", 9.25F);
            this.lbl_patientName.Location = new System.Drawing.Point(103, 106);
            this.lbl_patientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_patientName.Name = "lbl_patientName";
            this.lbl_patientName.Size = new System.Drawing.Size(76, 16);
            this.lbl_patientName.TabIndex = 193;
            this.lbl_patientName.Text = "Hastalık Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 192;
            this.label2.Text = "Hastalık Adı:";
            // 
            // lbl_petName
            // 
            this.lbl_petName.AutoSize = true;
            this.lbl_petName.Font = new System.Drawing.Font("Arial", 9.25F);
            this.lbl_petName.Location = new System.Drawing.Point(76, 89);
            this.lbl_petName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_petName.Name = "lbl_petName";
            this.lbl_petName.Size = new System.Drawing.Size(49, 16);
            this.lbl_petName.TabIndex = 190;
            this.lbl_petName.Text = "Pet Adı";
            // 
            // lbl_customerPhone
            // 
            this.lbl_customerPhone.AutoSize = true;
            this.lbl_customerPhone.Font = new System.Drawing.Font("Arial", 9.25F);
            this.lbl_customerPhone.Location = new System.Drawing.Point(93, 70);
            this.lbl_customerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customerPhone.Name = "lbl_customerPhone";
            this.lbl_customerPhone.Size = new System.Drawing.Size(67, 16);
            this.lbl_customerPhone.TabIndex = 189;
            this.lbl_customerPhone.Text = "Telefon No";
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Font = new System.Drawing.Font("Arial", 9.25F);
            this.lbl_customerName.Location = new System.Drawing.Point(98, 49);
            this.lbl_customerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(72, 16);
            this.lbl_customerName.TabIndex = 188;
            this.lbl_customerName.Text = "Müşteri Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 186;
            this.label5.Text = "Pet Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 185;
            this.label4.Text = "Telefon No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 184;
            this.label3.Text = "Müşteri Adı:";
            // 
            // txt_patientName
            // 
            this.txt_patientName.BackColor = System.Drawing.Color.White;
            this.txt_patientName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_patientName.Location = new System.Drawing.Point(11, 222);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(163, 22);
            this.txt_patientName.TabIndex = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 198;
            this.label1.Text = "Hastalık Adı";
            // 
            // dt_diagnosisDate
            // 
            this.dt_diagnosisDate.Location = new System.Drawing.Point(182, 222);
            this.dt_diagnosisDate.Name = "dt_diagnosisDate";
            this.dt_diagnosisDate.Size = new System.Drawing.Size(161, 20);
            this.dt_diagnosisDate.TabIndex = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(179, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 199;
            this.label7.Text = "Teşhis Tarihi";
            // 
            // txt_notes
            // 
            this.txt_notes.BackColor = System.Drawing.Color.White;
            this.txt_notes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_notes.Location = new System.Drawing.Point(13, 319);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(330, 61);
            this.txt_notes.TabIndex = 205;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 206;
            this.label9.Text = "Ek Notlar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(9, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 204;
            this.label11.Text = "Tedavi Yöntemi";
            // 
            // cb_treatments
            // 
            this.cb_treatments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_treatments.FormattingEnabled = true;
            this.cb_treatments.Location = new System.Drawing.Point(12, 270);
            this.cb_treatments.Name = "cb_treatments";
            this.cb_treatments.Size = new System.Drawing.Size(162, 21);
            this.cb_treatments.TabIndex = 203;
            // 
            // txt_treatmentDuration
            // 
            this.txt_treatmentDuration.BackColor = System.Drawing.Color.White;
            this.txt_treatmentDuration.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_treatmentDuration.Location = new System.Drawing.Point(182, 270);
            this.txt_treatmentDuration.Name = "txt_treatmentDuration";
            this.txt_treatmentDuration.Size = new System.Drawing.Size(161, 22);
            this.txt_treatmentDuration.TabIndex = 201;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(179, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 202;
            this.label12.Text = "Tedavi Süresi";
            // 
            // lbl_diagnosisDate
            // 
            this.lbl_diagnosisDate.AutoSize = true;
            this.lbl_diagnosisDate.Font = new System.Drawing.Font("Arial", 9.25F);
            this.lbl_diagnosisDate.Location = new System.Drawing.Point(105, 125);
            this.lbl_diagnosisDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_diagnosisDate.Name = "lbl_diagnosisDate";
            this.lbl_diagnosisDate.Size = new System.Drawing.Size(78, 16);
            this.lbl_diagnosisDate.TabIndex = 208;
            this.lbl_diagnosisDate.Text = "Teşhis Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 207;
            this.label8.Text = "Teşhis Tarihi:";
            // 
            // lbl_treatmentType
            // 
            this.lbl_treatmentType.AutoSize = true;
            this.lbl_treatmentType.Font = new System.Drawing.Font("Arial", 9.25F);
            this.lbl_treatmentType.Location = new System.Drawing.Point(121, 143);
            this.lbl_treatmentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_treatmentType.Name = "lbl_treatmentType";
            this.lbl_treatmentType.Size = new System.Drawing.Size(94, 16);
            this.lbl_treatmentType.TabIndex = 210;
            this.lbl_treatmentType.Text = "Tedavi Yöntemi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(15, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 209;
            this.label13.Text = "Tedavi Yöntemi:";
            // 
            // lbl_treatmentDuration
            // 
            this.lbl_treatmentDuration.AutoSize = true;
            this.lbl_treatmentDuration.Font = new System.Drawing.Font("Arial", 9.25F);
            this.lbl_treatmentDuration.Location = new System.Drawing.Point(111, 162);
            this.lbl_treatmentDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_treatmentDuration.Name = "lbl_treatmentDuration";
            this.lbl_treatmentDuration.Size = new System.Drawing.Size(83, 16);
            this.lbl_treatmentDuration.TabIndex = 212;
            this.lbl_treatmentDuration.Text = "Tedavi Süresi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(16, 161);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 211;
            this.label15.Text = "Tedavi Süresi:";
            // 
            // btn_updatePatient
            // 
            this.btn_updatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_updatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatePatient.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_updatePatient.ForeColor = System.Drawing.Color.White;
            this.btn_updatePatient.Location = new System.Drawing.Point(13, 395);
            this.btn_updatePatient.Name = "btn_updatePatient";
            this.btn_updatePatient.Size = new System.Drawing.Size(330, 37);
            this.btn_updatePatient.TabIndex = 215;
            this.btn_updatePatient.Text = "Güncelle";
            this.btn_updatePatient.UseVisualStyleBackColor = false;
            // 
            // PatientEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 444);
            this.Controls.Add(this.btn_updatePatient);
            this.Controls.Add(this.lbl_treatmentDuration);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl_treatmentType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_diagnosisDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_notes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_treatments);
            this.Controls.Add(this.txt_treatmentDuration);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dt_diagnosisDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_patientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_patientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_petName);
            this.Controls.Add(this.lbl_customerPhone);
            this.Controls.Add(this.lbl_customerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_closePatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientEdit";
            this.Load += new System.EventHandler(this.PatientEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_closePatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btn_closePatient;
        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Label lbl_patientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_petName;
        private System.Windows.Forms.Label lbl_customerPhone;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_diagnosisDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_treatments;
        private System.Windows.Forms.TextBox txt_treatmentDuration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_diagnosisDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_treatmentType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_treatmentDuration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_updatePatient;
    }
}