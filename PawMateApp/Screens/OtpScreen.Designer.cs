namespace PawMateApp.Screens
{
    partial class OtpScreen
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
            this.lbl_text = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_emailVerification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_text.Location = new System.Drawing.Point(86, 142);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(429, 26);
            this.lbl_text.TabIndex = 2;
            this.lbl_text.Text = "adresine gelen doğrulama kodunu giriniz.";
            this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.Location = new System.Drawing.Point(143, 107);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(323, 26);
            this.lbl_mail.TabIndex = 3;
            this.lbl_mail.Text = "ilaydamulazimoglu@gmail.com";
            this.lbl_mail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Location = new System.Drawing.Point(206, 216);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(196, 20);
            this.txt_name.TabIndex = 100;
            // 
            // btn_emailVerification
            // 
            this.btn_emailVerification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_emailVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emailVerification.ForeColor = System.Drawing.Color.White;
            this.btn_emailVerification.Location = new System.Drawing.Point(206, 251);
            this.btn_emailVerification.Name = "btn_emailVerification";
            this.btn_emailVerification.Size = new System.Drawing.Size(196, 37);
            this.btn_emailVerification.TabIndex = 102;
            this.btn_emailVerification.Text = "Doğrula";
            this.btn_emailVerification.UseVisualStyleBackColor = false;
            // 
            // OtpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 424);
            this.Controls.Add(this.btn_emailVerification);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OtpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_emailVerification;
    }
}