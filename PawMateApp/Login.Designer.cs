namespace PawMateApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_goSignUp = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(303, 207);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // lbl_goSignUp
            // 
            this.lbl_goSignUp.AutoSize = true;
            this.lbl_goSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_goSignUp.LinkColor = System.Drawing.Color.Black;
            this.lbl_goSignUp.Location = new System.Drawing.Point(19, 236);
            this.lbl_goSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_goSignUp.Name = "lbl_goSignUp";
            this.lbl_goSignUp.Size = new System.Drawing.Size(193, 16);
            this.lbl_goSignUp.TabIndex = 4;
            this.lbl_goSignUp.TabStop = true;
            this.lbl_goSignUp.Text = "Henüz hesabın mı yok? Kayıt Ol";
            this.lbl_goSignUp.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(23, 268);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(301, 46);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(23, 202);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(300, 22);
            this.txt_password.TabIndex = 1;
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(23, 15);
            this.logoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(301, 89);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(23, 144);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(300, 22);
            this.txt_username.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logoBox);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.lbl_goSignUp);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Location = new System.Drawing.Point(361, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(344, 336);
            this.panel1.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbl_goSignUp;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Panel panel1;
    }
}

