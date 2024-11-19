using Npgsql;
using PawMateApp.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public CheckClass checkinputs;
        public Login()
        {
         
            MoveForm moveForm = new MoveForm(this);
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(moveForm.Form_MouseDown);
            this.MouseMove += new MouseEventHandler(moveForm.Form_MouseMove);
            this.MouseUp += new MouseEventHandler(moveForm.Form_MouseUp);
            
        }

        public static class Globals
        {
            public static int CurrentUserID { get; set; }   
            
        }

        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
                                                                                                                          
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
         

            checkinputs = new CheckClass(new string[] { txt_username.Text, txt_password.Text });
            if (!checkinputs.Check(""))
            {
                return;
            }
            else
            {
                try
                {
                    baglan.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("Select * from users where username=@P1 AND password=@P2", baglan);
                    cmd.Parameters.AddWithValue("@P1", txt_username.Text);
                    cmd.Parameters.AddWithValue("@P2", txt_password.Text);
                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        if (dr["otp_status"].ToString() != "0")
                        {
                            this.Hide();
                            OtpScreen otpScreen = new OtpScreen();
                            otpScreen.Show();
                        }
                        else
                        {
                            Panel panel = new Panel();//messagebox yerine panel eklendi. 
                            this.Hide();
                            panel.Show();
                            Globals.CurrentUserID = Convert.ToInt32(dr["user_id"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    baglan.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
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

        private void btn_exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_goRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }

}

