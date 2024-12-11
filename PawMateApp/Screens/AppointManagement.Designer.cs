namespace PawMateApp.Screens
{
    partial class AppointManagement
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.upcomingAppointments = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_visitReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_vets = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_pets = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_customers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_addVisit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pastAppointments = new System.Windows.Forms.FlowLayoutPanel();
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
            this.txt_title.Size = new System.Drawing.Size(260, 32);
            this.txt_title.TabIndex = 6;
            this.txt_title.Text = "Randevu Planlama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(8, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 159;
            this.label3.Text = "Randevu Planla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(270, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 23);
            this.label5.TabIndex = 158;
            this.label5.Text = "Yaklaşan Randevular";
            // 
            // upcomingAppointments
            // 
            this.upcomingAppointments.AutoScroll = true;
            this.upcomingAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.upcomingAppointments.Location = new System.Drawing.Point(274, 77);
            this.upcomingAppointments.Name = "upcomingAppointments";
            this.upcomingAppointments.Size = new System.Drawing.Size(522, 312);
            this.upcomingAppointments.TabIndex = 157;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::PawMateApp.Properties.Resources.appoint_img;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_visitReason);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dp_date);
            this.panel1.Controls.Add(this.cb_vets);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_pets);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_customers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_addVisit);
            this.panel1.Location = new System.Drawing.Point(12, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 326);
            this.panel1.TabIndex = 155;
            // 
            // txt_visitReason
            // 
            this.txt_visitReason.BackColor = System.Drawing.Color.White;
            this.txt_visitReason.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_visitReason.Location = new System.Drawing.Point(14, 205);
            this.txt_visitReason.Multiline = true;
            this.txt_visitReason.Name = "txt_visitReason";
            this.txt_visitReason.Size = new System.Drawing.Size(228, 54);
            this.txt_visitReason.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 130;
            this.label2.Text = "Randevu Nedeni";
            // 
            // dp_date
            // 
            this.dp_date.Location = new System.Drawing.Point(15, 163);
            this.dp_date.Name = "dp_date";
            this.dp_date.Size = new System.Drawing.Size(226, 20);
            this.dp_date.TabIndex = 4;
            // 
            // cb_vets
            // 
            this.cb_vets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vets.FormattingEnabled = true;
            this.cb_vets.Location = new System.Drawing.Point(15, 119);
            this.cb_vets.Name = "cb_vets";
            this.cb_vets.Size = new System.Drawing.Size(227, 21);
            this.cb_vets.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = "İlgili Veteriner";
            // 
            // cb_pets
            // 
            this.cb_pets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pets.FormattingEnabled = true;
            this.cb_pets.Location = new System.Drawing.Point(14, 75);
            this.cb_pets.Name = "cb_pets";
            this.cb_pets.Size = new System.Drawing.Size(227, 21);
            this.cb_pets.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 126;
            this.label4.Text = "Pet";
            // 
            // cb_customers
            // 
            this.cb_customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_customers.FormattingEnabled = true;
            this.cb_customers.Location = new System.Drawing.Point(14, 31);
            this.cb_customers.Name = "cb_customers";
            this.cb_customers.Size = new System.Drawing.Size(227, 21);
            this.cb_customers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Tarih Seçiniz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 118;
            this.label8.Text = "Müşteri";
            // 
            // btn_addVisit
            // 
            this.btn_addVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addVisit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addVisit.ForeColor = System.Drawing.Color.White;
            this.btn_addVisit.Location = new System.Drawing.Point(14, 276);
            this.btn_addVisit.Name = "btn_addVisit";
            this.btn_addVisit.Size = new System.Drawing.Size(228, 37);
            this.btn_addVisit.TabIndex = 6;
            this.btn_addVisit.Text = "Ekle";
            this.btn_addVisit.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(274, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 23);
            this.label7.TabIndex = 160;
            this.label7.Text = "Geçmiş Randevular";
            // 
            // pastAppointments
            // 
            this.pastAppointments.AutoScroll = true;
            this.pastAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.pastAppointments.Location = new System.Drawing.Point(274, 421);
            this.pastAppointments.Name = "pastAppointments";
            this.pastAppointments.Size = new System.Drawing.Size(522, 154);
            this.pastAppointments.TabIndex = 158;
            // 
            // AppointManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.pastAppointments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upcomingAppointments);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointManagement";
            this.Text = "AppointManagement";
            this.Load += new System.EventHandler(this.AppointManagement_Load);
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
        private System.Windows.Forms.FlowLayoutPanel upcomingAppointments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_customers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_addVisit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dp_date;
        private System.Windows.Forms.ComboBox cb_vets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_pets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_visitReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel pastAppointments;
    }
}