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


                string sql = "SELECT name, surname, username, email, password FROM users WHERE user_id = @UserID";

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

                NpgsqlCommand cmdCheck = new NpgsqlCommand("SELECT COUNT(*) FROM users WHERE username = @P1 AND user_id != @UserID", baglan);
                cmdCheck.Parameters.AddWithValue("@P1", txt_username.Text);
                cmdCheck.Parameters.AddWithValue("@UserID", Globals.CurrentUserID);
                int userExists = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (userExists > 0)
                {

                    MessageBox.Show("Bu kullanıcı adı zaten alınmış. Lütfen başka bir kullanıcı adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string sql = "UPDATE users SET name = @Name, surname = @Surname, email = @Email, username = @Username, password = @Password WHERE user_id = @UserID";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, baglan))
                    {

                        cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@Surname", txt_surname.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@Username", txt_username.Text);
                        cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                        cmd.Parameters.AddWithValue("@UserID", Globals.CurrentUserID);

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
    }
}
