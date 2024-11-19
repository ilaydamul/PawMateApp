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
using System.Net.Mail;
using System.Net;
using System.Diagnostics;

namespace PawMateApp
{
    public partial class Register : Form
    {

       

     

        public Register()
        {
            MoveForm moveForm = new MoveForm(this);
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(moveForm.Form_MouseDown);
            this.MouseMove += new MouseEventHandler(moveForm.Form_MouseMove);
            this.MouseUp += new MouseEventHandler(moveForm.Form_MouseUp);
            
        }

     

        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
        //şifreyi kendi veritabanı şifrenize göre değiştirin.
        private void Register_Paint(object sender, PaintEventArgs e)
        {
            Color leftColor = ColorTranslator.FromHtml("#B5B3F1");
            Color rightColor = ColorTranslator.FromHtml("#2A21DC");

            using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, leftColor, rightColor, 0F))
            {
                e.Graphics.FillRectangle(lgb, this.ClientRectangle);
            }
        }

        private void lbl_goLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btn_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btn_register_Click(object sender, EventArgs e)
        {
            CheckClass checkInputs = new CheckClass(new string[] { txt_username.Text, txt_password.Text, txt_email.Text, txt_name.Text, txt_surname.Text });
            if (!checkInputs.Check(""))
            {
                return;
            }
            else
            {
                if (!CheckClass.IsValidEmail(txt_email.Text))
                {
                    MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        baglan.Open();
                        NpgsqlCommand cmdCheck = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE username = @P1", baglan);
                        cmdCheck.Parameters.AddWithValue("@P1", txt_username.Text);
                        int userExists = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (userExists > 0)
                        {

                            MessageBox.Show("Bu kullanıcı adı zaten alınmış. Lütfen başka bir kullanıcı adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            NpgsqlCommand cmdCheckEmail = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE email = @P1", baglan);
                            cmdCheckEmail.Parameters.AddWithValue("@P1", txt_email.Text);
                            int userExitsEmail = Convert.ToInt32(cmdCheckEmail.ExecuteScalar());
                            if (userExitsEmail > 0)
                            {
                                MessageBox.Show("Bu e-posta adresi zaten alınmış. Lütfen başka bir e-posta adresi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                SendMail sendMail = new SendMail(txt_name.Text, txt_email.Text);
                                int user_otp_code = sendMail.SendMailForOTP();
                                if (user_otp_code != 0)
                                {
                                    try
                                    {
                                        NpgsqlCommand komut = new NpgsqlCommand("insert into users(name,surname,username,email,password,isadmin,otp_code,otp_status,two_factor_code) values(@name,@surname,@username,@email,@password,@isadmin,@otp_code,@otp_status,@two_factor_code)", baglan);
                                        komut.Parameters.AddWithValue("@name", txt_name.Text);
                                        komut.Parameters.AddWithValue("@surname", txt_surname.Text);
                                        komut.Parameters.AddWithValue("@username", txt_username.Text);
                                        komut.Parameters.AddWithValue("@email", txt_email.Text);
                                        komut.Parameters.AddWithValue("@password", txt_password.Text);
                                        komut.Parameters.AddWithValue("@isadmin", false);
                                        komut.Parameters.AddWithValue("@otp_code", user_otp_code);
                                        komut.Parameters.AddWithValue("@otp_status", 0);
                                        komut.Parameters.AddWithValue("@two_factor_code", 0);
                                        komut.Parameters.AddWithValue("@two_factor_status", false);
                                        komut.ExecuteNonQuery();
                                        MessageBox.Show("Başarılı bir şekilde kayıt oldunuz! Giriş yapmak için mail adresinize gönderilen doğrulama kodunu giriş yaparken giriniz.", "Başarılı Kayıt", MessageBoxButtons.OK);
                                    }catch(Exception exception)
                                    {
                                        MessageBox.Show("Bir hata oluştu: " + exception.Message);
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                                }
                              
    
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
                this.Close();
                Login login = new Login();
                this.Hide();
                login.Show();

            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_register.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}

