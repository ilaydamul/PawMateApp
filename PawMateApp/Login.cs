﻿using Npgsql;
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
            LoadSavedCredentials();
            
        }

        public static class Globals
        {
            public static int CurrentUserID { get; set; }   
            public static bool CurrentUserBusinessAdminStatus { get; set; }   
            public static bool CurrentUserAppAdminStatus { get; set; }   
            public static int CurrentUserBusinessAdminID { get; set; }   
            public static string BusinessName { get; set; }

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

        private void LoadSavedCredentials()
        {
            var (username, password) = UserSettings.LoadCredentials();
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                txt_username.Text = username;
                txt_password.Text = password;
                chk_rememberMe.Checked = true;
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
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM \"users\" WHERE \"username\"=@P1 AND \"password\"=@P2", baglan);
                    cmd.Parameters.AddWithValue("@P1", txt_username.Text);
                    cmd.Parameters.AddWithValue("@P2", txt_password.Text);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Globals.CurrentUserID = dr["userId"] != DBNull.Value ? Convert.ToInt32(dr["userId"]) : 0;
                        Globals.CurrentUserBusinessAdminStatus = dr["IsBusinessAdmin"] != DBNull.Value ? Convert.ToBoolean(dr["IsBusinessAdmin"]) : false;
                        Globals.CurrentUserAppAdminStatus = dr["IsAppAdmin"] != DBNull.Value ? Convert.ToBoolean(dr["IsAppAdmin"]) : false; 
                        Globals.CurrentUserBusinessAdminID = dr["businessId"] != DBNull.Value ? Convert.ToInt32(dr["businessId"]) : 0; 

                        if (chk_rememberMe.Checked)
                        {
                            UserSettings.SaveCredentials(txt_username.Text, txt_password.Text);
                        }
                        else
                        {
                            UserSettings.ClearCredentials();
                        }

                        this.Hide();
                        Panel panel = new Panel();
                        panel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglan.Close();
                }
                try
                {
                    baglan.Open();
                    string getBusinessName = "SELECT \"businessName\" FROM \"businesses\" WHERE \"businessId\" = @P1";
                    NpgsqlCommand cmd2 = new NpgsqlCommand(getBusinessName, baglan);
                    cmd2.Parameters.AddWithValue("@P1", Globals.CurrentUserBusinessAdminID);
                    NpgsqlDataReader dr2 = cmd2.ExecuteReader();
                    Globals.BusinessName = dr2.Read() ? dr2["businessName"].ToString() : "Business Name Yok";
                    Debug.WriteLine(Globals.BusinessName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglan.Close();
                }
            }
        }

        private bool LoginSuccessful()
        {
            checkinputs = new CheckClass(new string[] { txt_username.Text, txt_password.Text });
            if (!checkinputs.Check(""))
            {
                return false;
            }
            else
            {
                try
                {
                    baglan.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM \"users\" WHERE \"username\"=@P1 AND \"password\"=@P2", baglan);
                    cmd.Parameters.AddWithValue("@P1", txt_username.Text);
                    cmd.Parameters.AddWithValue("@P2", txt_password.Text);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Globals.CurrentUserID = dr["userId"] != DBNull.Value ? Convert.ToInt32(dr["userId"]) : 0;
                        Globals.CurrentUserBusinessAdminStatus = dr["IsBusinessAdmin"] != DBNull.Value ? Convert.ToBoolean(dr["IsBusinessAdmin"]) : false;
                        Globals.CurrentUserAppAdminStatus = dr["IsAppAdmin"] != DBNull.Value ? Convert.ToBoolean(dr["IsAppAdmin"]) : false; 
                        Globals.CurrentUserBusinessAdminID = dr["businessId"] != DBNull.Value ? Convert.ToInt32(dr["businessId"]) : 0; 

                        if (chk_rememberMe.Checked)
                        {
                            UserSettings.SaveCredentials(txt_username.Text, txt_password.Text);
                        }
                        else
                        {
                            UserSettings.ClearCredentials();
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    baglan.Close();
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

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btn_login.PerformClick(); 
                e.Handled = true;        
                e.SuppressKeyPress = true; 
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

    }

}

