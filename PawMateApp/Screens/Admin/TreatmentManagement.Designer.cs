namespace PawMateApp.Screens.Admin
{
    partial class TreatmentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreatmentManagement));
            this.txt_title = new System.Windows.Forms.Label();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_treatmentdesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_treatmenttitle = new System.Windows.Forms.TextBox();
            this.btn_addUpdateUser = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(252, 32);
            this.txt_title.TabIndex = 6;
            this.txt_title.Text = "Tedavi Yöntemleri";
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_deleteUser.Location = new System.Drawing.Point(638, 545);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(158, 30);
            this.btn_deleteUser.TabIndex = 138;
            this.btn_deleteUser.Text = "Sil";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.ForeColor = System.Drawing.Color.White;
            this.btn_addUser.Location = new System.Drawing.Point(638, 39);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(158, 33);
            this.btn_addUser.TabIndex = 135;
            this.btn_addUser.Text = "Tedavi Ekle";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(269, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 137;
            this.label5.Text = "Tedaviler";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_treatmentdesc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_treatmenttitle);
            this.panel1.Controls.Add(this.btn_addUpdateUser);
            this.panel1.Location = new System.Drawing.Point(12, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 354);
            this.panel1.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 120;
            this.label3.Text = "Açıklama";
            // 
            // txt_treatmentdesc
            // 
            this.txt_treatmentdesc.BackColor = System.Drawing.Color.White;
            this.txt_treatmentdesc.Location = new System.Drawing.Point(13, 70);
            this.txt_treatmentdesc.Multiline = true;
            this.txt_treatmentdesc.Name = "txt_treatmentdesc";
            this.txt_treatmentdesc.Size = new System.Drawing.Size(226, 113);
            this.txt_treatmentdesc.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 118;
            this.label8.Text = "Tedavi Adı";
            // 
            // txt_treatmenttitle
            // 
            this.txt_treatmenttitle.BackColor = System.Drawing.Color.White;
            this.txt_treatmenttitle.Location = new System.Drawing.Point(13, 30);
            this.txt_treatmenttitle.Name = "txt_treatmenttitle";
            this.txt_treatmenttitle.Size = new System.Drawing.Size(226, 20);
            this.txt_treatmenttitle.TabIndex = 0;
            // 
            // btn_addUpdateUser
            // 
            this.btn_addUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btn_addUpdateUser.Location = new System.Drawing.Point(13, 305);
            this.btn_addUpdateUser.Name = "btn_addUpdateUser";
            this.btn_addUpdateUser.Size = new System.Drawing.Size(226, 37);
            this.btn_addUpdateUser.TabIndex = 6;
            this.btn_addUpdateUser.Text = "Ekle";
            this.btn_addUpdateUser.UseVisualStyleBackColor = false;
            this.btn_addUpdateUser.Click += new System.EventHandler(this.btn_addUpdateUser_Click);
            // 
            // userList
            // 
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList.Location = new System.Drawing.Point(274, 75);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(522, 466);
            this.userList.TabIndex = 134;
            this.userList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userList_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // TreatmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreatmentManagement";
            this.Text = "TreatmentManagement";
            this.Load += new System.EventHandler(this.TreatmentManagement_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_treatmentdesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_treatmenttitle;
        private System.Windows.Forms.Button btn_addUpdateUser;
        private System.Windows.Forms.DataGridView userList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}