using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawMateApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            public static int CurrentUserID { get; set; } 
        }

        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432; Database=pawmatedb; user ID=postgres; password=sila123");
                                                                                                                           //şifreyi kendi veritabanı şifrenize göre değiştirin.
        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Color leftColor = ColorTranslator.FromHtml("#B5B3F1");
            Color rightColor = ColorTranslator.FromHtml("#2A21DC");

            using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, leftColor, rightColor, 0F))
            {
                e.Graphics.FillRectangle(lgb, this.ClientRectangle);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglan.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Select * from users where username=@P1 AND password=@P2", baglan);
                cmd.Parameters.AddWithValue("@P1", txt_username.Text);
                cmd.Parameters.AddWithValue("@P2", txt_password.Text);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarıyla Yapıldı!" );
                    int user_id = Convert.ToInt32(dr["user_id"]);
                    Globals.CurrentUserID = user_id;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglan.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Şifreyi görünür yap
                txt_password.PasswordChar = '\0';
            }
            else
            {
                // Şifreyi gizle
                txt_password.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

