namespace PawMateApp.Components
{
    partial class NotifItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifItem));
            this.btn_declineBusiness = new System.Windows.Forms.Button();
            this.btn_approveBusiness = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.Label();
            this.txt_businessName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_declineBusiness
            // 
            this.btn_declineBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_declineBusiness.FlatAppearance.BorderSize = 0;
            this.btn_declineBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_declineBusiness.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_declineBusiness.ForeColor = System.Drawing.Color.Black;
            this.btn_declineBusiness.Location = new System.Drawing.Point(610, 10);
            this.btn_declineBusiness.Name = "btn_declineBusiness";
            this.btn_declineBusiness.Size = new System.Drawing.Size(138, 40);
            this.btn_declineBusiness.TabIndex = 137;
            this.btn_declineBusiness.Text = "Yoksay";
            this.btn_declineBusiness.UseVisualStyleBackColor = false;
            this.btn_declineBusiness.Click += new System.EventHandler(this.btn_declineBusiness_Click);
            // 
            // btn_approveBusiness
            // 
            this.btn_approveBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_approveBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approveBusiness.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_approveBusiness.ForeColor = System.Drawing.Color.White;
            this.btn_approveBusiness.Location = new System.Drawing.Point(466, 10);
            this.btn_approveBusiness.Name = "btn_approveBusiness";
            this.btn_approveBusiness.Size = new System.Drawing.Size(138, 42);
            this.btn_approveBusiness.TabIndex = 138;
            this.btn_approveBusiness.Text = "Onayla";
            this.btn_approveBusiness.UseVisualStyleBackColor = false;
            this.btn_approveBusiness.Click += new System.EventHandler(this.btn_approveBusiness_Click);
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_description.Location = new System.Drawing.Point(60, 39);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(400, 13);
            this.txt_description.TabIndex = 140;
            this.txt_description.Text = "Hesabını onaylatmak istiyor, onaylansın mı?";
            // 
            // txt_businessName
            // 
            this.txt_businessName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_businessName.Location = new System.Drawing.Point(58, 10);
            this.txt_businessName.Name = "txt_businessName";
            this.txt_businessName.Size = new System.Drawing.Size(402, 26);
            this.txt_businessName.TabIndex = 139;
            this.txt_businessName.Text = "İşletme Adı";
            this.txt_businessName.Click += new System.EventHandler(this.txt_businessName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // NotifItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_businessName);
            this.Controls.Add(this.btn_approveBusiness);
            this.Controls.Add(this.btn_declineBusiness);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "NotifItem";
            this.Size = new System.Drawing.Size(760, 64);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_declineBusiness;
        private System.Windows.Forms.Button btn_approveBusiness;
        private System.Windows.Forms.Label txt_description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_businessName;
    }
}
