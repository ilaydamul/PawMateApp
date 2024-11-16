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
            this.cb_showPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_goRegister = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exitApp = new System.Windows.Forms.PictureBox();
            this.btn_minimizeApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exitApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizeApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // cb_showPass
            // 
            this.cb_showPass.AutoSize = true;
            this.cb_showPass.Location = new System.Drawing.Point(227, 168);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(15, 14);
            this.cb_showPass.TabIndex = 2;
            this.cb_showPass.UseVisualStyleBackColor = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.cb_showPass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // lbl_goRegister
            // 
            this.lbl_goRegister.AutoSize = true;
            this.lbl_goRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_goRegister.LinkColor = System.Drawing.Color.Black;
            this.lbl_goRegister.Location = new System.Drawing.Point(14, 192);
            this.lbl_goRegister.Name = "lbl_goRegister";
            this.lbl_goRegister.Size = new System.Drawing.Size(156, 13);
            this.lbl_goRegister.TabIndex = 99;
            this.lbl_goRegister.TabStop = true;
            this.lbl_goRegister.Text = "Henüz hesabın mı yok? Kayıt Ol";
            this.lbl_goRegister.VisitedLinkColor = System.Drawing.Color.Black;
            this.lbl_goRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_goRegister_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(17, 218);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(226, 37);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(17, 164);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(226, 20);
            this.txt_password.TabIndex = 1;
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(17, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(226, 72);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(17, 117);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(226, 20);
            this.txt_username.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logoBox);
            this.panel1.Controls.Add(this.cb_showPass);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.lbl_goRegister);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Location = new System.Drawing.Point(271, 88);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(258, 273);
            this.panel1.TabIndex = 2;
            // 
            // btn_exitApp
            // 
            this.btn_exitApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_exitApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_exitApp.Image")));
            this.btn_exitApp.Location = new System.Drawing.Point(756, 11);
            this.btn_exitApp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exitApp.Name = "btn_exitApp";
            this.btn_exitApp.Size = new System.Drawing.Size(33, 28);
            this.btn_exitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exitApp.TabIndex = 3;
            this.btn_exitApp.TabStop = false;
            this.btn_exitApp.Click += new System.EventHandler(this.btn_exitApp_Click);
            // 
            // btn_minimizeApp
            // 
            this.btn_minimizeApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizeApp.Image")));
            this.btn_minimizeApp.Location = new System.Drawing.Point(707, 12);
            this.btn_minimizeApp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizeApp.Name = "btn_minimizeApp";
            this.btn_minimizeApp.Size = new System.Drawing.Size(32, 28);
            this.btn_minimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizeApp.TabIndex = 4;
            this.btn_minimizeApp.TabStop = false;
            this.btn_minimizeApp.Click += new System.EventHandler(this.btn_minimizeApp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_minimizeApp);
            this.Controls.Add(this.btn_exitApp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exitApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizeApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_showPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbl_goRegister;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exitApp;
        private System.Windows.Forms.PictureBox btn_minimizeApp;
    }
}

