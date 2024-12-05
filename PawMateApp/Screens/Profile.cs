using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PawMateApp.Login;

namespace PawMateApp.Screens
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {

                baglan.Open();


                string sql = "SELECT name, surname, username, email, password FROM users WHERE userId = @UserID";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, baglan))
                {

                    cmd.Parameters.AddWithValue("@UserID", Globals.CurrentUserID);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_name.Text = reader["name"].ToString();
                            txt_surname.Text = reader["surname"].ToString();
                            txt_email.Text = reader["email"].ToString();
                            txt_username.Text = reader["username"].ToString();                          
                            txt_password.Text = reader["password"].ToString();
                            lbl_name.Text = $"Hoş geldiniz, {reader["name"].ToString()}!"; 
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

        private void btn_updateProfileInfos_Click(object sender, EventArgs e)
        {

            CheckClass checkinputs = new CheckClass(new string[] { txt_name.Text, txt_surname.Text, txt_email.Text, txt_username.Text, txt_password.Text });
            if (!checkinputs.Check(""))
            {               
                return;
            }

            try
            {
                baglan.Open();

                NpgsqlCommand cmdCheck = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE username = @P1 AND userId != @UserID", baglan);
                cmdCheck.Parameters.AddWithValue("@P1", txt_username.Text);
                cmdCheck.Parameters.AddWithValue("@UserID", Globals.CurrentUserID);
                int userExists = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (userExists > 0)
                {

                    MessageBox.Show("Bu kullanıcı adı zaten alınmış. Lütfen başka bir kullanıcı adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string sql = "UPDATE users SET name = @name, surname = @surname, email = @email, username = @username, password = @password WHERE userId = @UserID";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, baglan))
                    {

                        cmd.Parameters.AddWithValue("@name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@surname", txt_surname.Text);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);
                        cmd.Parameters.AddWithValue("@userID", Globals.CurrentUserID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler güncellenemedi. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                baglan.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    baglan.Open();
                    NpgsqlCommand cmdCheck = new NpgsqlCommand($"UPDATE users SET two_factor_status = TRUE WHERE userId = {Globals.CurrentUserID};", baglan);
                    cmdCheck.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("İki faktörlü kimlik doğrulama etkinleştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox1.Text = "Açık";
                }
                catch (Exception ex)
                {
                    baglan.Close();
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            if (!checkBox1.Checked)
            {
                try
                {
                    baglan.Open();
                    NpgsqlCommand cmdCheck = new NpgsqlCommand($"UPDATE users SET two_factor_status = FALSE WHERE userId = {Globals.CurrentUserID};", baglan);
                    cmdCheck.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("İki faktörlü kimlik doğrulama kapatıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBox1.Text = "Kapalı";
                }
                catch (Exception ex)
                {
                    baglan.Close();
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
