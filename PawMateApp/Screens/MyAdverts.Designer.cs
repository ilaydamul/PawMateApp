namespace PawMateApp.Screens
{
    partial class MyAdverts
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_addAdvert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title.Location = new System.Drawing.Point(6, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(130, 32);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "İlanlarım";
            // 
            // btn_addAdvert
            // 
            this.btn_addAdvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(33)))), ((int)(((byte)(230)))));
            this.btn_addAdvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addAdvert.ForeColor = System.Drawing.Color.White;
            this.btn_addAdvert.Location = new System.Drawing.Point(12, 44);
            this.btn_addAdvert.Name = "btn_addAdvert";
            this.btn_addAdvert.Size = new System.Drawing.Size(166, 37);
            this.btn_addAdvert.TabIndex = 7;
            this.btn_addAdvert.Text = "İlan Ekle";
            this.btn_addAdvert.UseVisualStyleBackColor = false;
            this.btn_addAdvert.Click += new System.EventHandler(this.btn_addAdvert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 320);
            this.dataGridView1.TabIndex = 8;
            // 
            // MyAdverts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_addAdvert);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyAdverts";
            this.Text = "MyAdverts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_addAdvert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}