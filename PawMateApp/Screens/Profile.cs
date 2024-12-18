﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
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
            //İşletme sahibi ise toplam veteriner sayısı kısmı gösterilecek, değilse visible hide olacak
            try
            {

                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
             
                string sqlAdminCheck = "SELECT \"isBusinessAdmin\" FROM \"users\" WHERE \"userId\" = @UserID";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlAdminCheck, baglan))
                {
                    cmd.Parameters.AddWithValue("@UserID", Globals.CurrentUserID);

                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            
                            Globals.CurrentUserBusinessAdminStatus = dr["isBusinessAdmin"] != DBNull.Value
                                ? Convert.ToBoolean(dr["isBusinessAdmin"])
                                : false;

                            // Admin durumuna göre panel görünürlüğü ayarlıyoruz.
                            pc_vets.Visible = Globals.CurrentUserBusinessAdminStatus;
                            lbl_vets.Visible = Globals.CurrentUserBusinessAdminStatus;
                            txtt_vets.Visible = Globals.CurrentUserBusinessAdminStatus;
                        }
                    }

                }
              
                     
                    if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                string sql = "SELECT \"fullName\", \"username\", \"email\", \"password\", \"phone\", \"image\" FROM \"users\" WHERE \"userId\" = @UserID";

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
                            lbl_name.Text = $"{reader["fullName"].ToString()}!";


                            if (reader["image"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader["image"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    userImage.Image = Image.FromStream(ms); 
                                }
                            }
                            else
                            {
                                userImage.Image = Properties.Resources.user;
                            }

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

            baglan.Open();

            // 1. Randevu sayısını alıyoruz
            NpgsqlCommand cmdVisits = new NpgsqlCommand("SELECT COUNT(*) FROM \"visits\" WHERE \"userId\" = @userId", baglan);
            cmdVisits.Parameters.AddWithValue("@userId", Globals.CurrentUserID);
            int randevuSayisi = Convert.ToInt32(cmdVisits.ExecuteScalar());
            lbl_totalAppo.Text = randevuSayisi.ToString(); 

            // 2. İlaç stoğu sayısını alıyoruz
            NpgsqlCommand cmdMedicineStock = new NpgsqlCommand("SELECT COUNT(*) FROM \"medicineStocks\" WHERE \"userId\" = @userid", baglan);
            cmdMedicineStock.Parameters.AddWithValue("@userid", Globals.CurrentUserID);
            int ilacStogu = Convert.ToInt32(cmdMedicineStock.ExecuteScalar());
            lbl_totalMedicine.Text = ilacStogu.ToString(); 

            // 3. Yazılan reçetelerin sayısını alıyoruz
            NpgsqlCommand cmdPrescriptions = new NpgsqlCommand("SELECT COUNT(*) FROM \"prescriptions\" WHERE \"userId\" = @userid", baglan);
            cmdPrescriptions.Parameters.AddWithValue("@userid", Globals.CurrentUserID);
            int receteSayisi = Convert.ToInt32(cmdPrescriptions.ExecuteScalar());
            lbl_allPresp.Text = receteSayisi.ToString();

            // 4. Müşterilerin sayısını alıyoruz
            NpgsqlCommand cmdCostumers = new NpgsqlCommand("SELECT COUNT(*) FROM \"costumers\" WHERE \"userId\" = @userid", baglan);
            cmdCostumers.Parameters.AddWithValue("@userid", Globals.CurrentUserID);
            int musterisayisi = Convert.ToInt32(cmdPrescriptions.ExecuteScalar());
            lbl_customers.Text = musterisayisi.ToString();

            // 5. Aktif randevu sayısını alıyoruz
            NpgsqlCommand cmdAppo = new NpgsqlCommand("SELECT COUNT(*) FROM \"visits\" WHERE \"userId\" = @userid", baglan);
            cmdAppo.Parameters.AddWithValue("@userid", Globals.CurrentUserID);
            int aktifRandevusayisi = Convert.ToInt32(cmdPrescriptions.ExecuteScalar());
            lbl_activeAppo.Text =aktifRandevusayisi.ToString();


            // 6. Hayvan sayısını alıyoruz
            NpgsqlCommand cmdPets = new NpgsqlCommand(@"
            SELECT COUNT(*) 
            FROM ""pets"" 
            WHERE ""customerId"" IN (
                SELECT ""customerId"" 
                FROM ""customers"" 
                WHERE ""businessId"" IN (
                    SELECT ""businessId"" 
                    FROM ""users"" 
                    WHERE ""userId"" = @userid
                )
            )", baglan);

            cmdPets.Parameters.AddWithValue("@userid", Globals.CurrentUserID);
            int hayvanSayisi = Convert.ToInt32(cmdPets.ExecuteScalar());
            lbl_pets.Text = hayvanSayisi.ToString();        
            baglan.Close();

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

        private void btn_updateImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";


            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    byte[] imageData = File.ReadAllBytes(imagePath);


                    using (baglan)
                    {
                        baglan.Open();

                        string query = "UPDATE \"users\" SET \"image\" = @ImageData WHERE \"userId\" = @userId";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, baglan))
                        {
                            command.Parameters.AddWithValue("@ImageData", imageData);
                            command.Parameters.AddWithValue("@userId", Globals.CurrentUserID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Görsel başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                userImage.Image = Image.FromStream(ms);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Bir hata meydana  geldi!"+ ex, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                baglan.Close();
            }
           
        }
    }
}
