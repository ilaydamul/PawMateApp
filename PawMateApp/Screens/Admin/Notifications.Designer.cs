namespace PawMateApp.Screens.Admin
{
    partial class Notifications
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_noNotif = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_title.Location = new System.Drawing.Point(6, 9);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(154, 32);
            this.txt_title.TabIndex = 7;
            this.txt_title.Text = "Bildirimler";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.txt_noNotif);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 534);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // txt_noNotif
            // 
            this.txt_noNotif.AutoSize = true;
            this.txt_noNotif.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_noNotif.Location = new System.Drawing.Point(3, 0);
            this.txt_noNotif.Name = "txt_noNotif";
            this.txt_noNotif.Size = new System.Drawing.Size(241, 24);
            this.txt_noNotif.TabIndex = 9;
            this.txt_noNotif.Text = "Henüz bir bildiriminiz yok.";
            this.txt_noNotif.Visible = false;
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(808, 590);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txt_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifications";
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.Notifications_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label txt_noNotif;
    }
}