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
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                string sql = "SELECT \"fullName\", \"username\", \"email\", \"password\", \"phone\" FROM \"users\" WHERE \"userId\" = @UserID";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, baglan))
                {
                    cmd.Parameters.AddWithValue("@UserID", Globals.CurrentUserID);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_fullname.Text = reader["fullName"].ToString();
                            txt_email.Text = reader["email"].ToString();
                            txt_username.Text = reader["username"].ToString();
                            txt_password.Text = reader["password"].ToString();
                            txt_phone.Text = reader["phone"].ToString();
                            lbl_name.Text = $"Hoş geldiniz, {reader["fullName"].ToString()}!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglan.State == ConnectionState.Open)
                    baglan.Close();
            }

        }

        private void btn_updateProfileInfos_Click(object sender, EventArgs e)
        {

            CheckClass checkinputs = new CheckClass(new string[] { txt_fullname.Text, txt_email.Text, txt_username.Text, txt_password.Text, txt_phone.Text });
            if (!checkinputs.Check(""))
            {
                return;
            }

            if (!CheckClass.IsValidEmail(txt_email.Text))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else

            {
                if (CheckClass.IsValidPhone(txt_phone.Text))
                {

                    try
                    {
                        if (baglan.State == ConnectionState.Closed)
                            baglan.Open();

                        string checkQuery = "SELECT COUNT(*) FROM \"users\" WHERE \"username\" = @username AND \"userId\" != @userId";

                        using (NpgsqlCommand cmdCheck = new NpgsqlCommand(checkQuery, baglan))
                        {
                            cmdCheck.Parameters.AddWithValue("@username", txt_username.Text);
                            cmdCheck.Parameters.AddWithValue("@userId", Globals.CurrentUserID);

                            int userExists = Convert.ToInt32(cmdCheck.ExecuteScalar());

                            if (userExists > 0)
                            {
                                MessageBox.Show("Bu kullanıcı adı zaten alınmış. Lütfen başka bir kullanıcı adı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string updateQuery = "UPDATE \"users\" SET \"fullName\" = @fullName, \"email\" = @email, \"username\" = @username, \"password\" = @password, \"phone\" = @phone WHERE \"userId\" = @userId";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, baglan))
                        {
                            cmd.Parameters.AddWithValue("@fullName", txt_fullname.Text);
                            cmd.Parameters.AddWithValue("@email", txt_email.Text);
                            cmd.Parameters.AddWithValue("@username", txt_username.Text);
                            cmd.Parameters.AddWithValue("@password", txt_password.Text);
                            cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                            cmd.Parameters.AddWithValue("@userId", Globals.CurrentUserID);

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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (baglan.State == ConnectionState.Open)
                            baglan.Close();
                    }


                }

            }
        }

              

    }
}
