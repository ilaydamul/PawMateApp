using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PawMateApp.Login;

namespace PawMateApp.Screens
{
    public partial class PetAndCustomerManagement : Form
    {
        //DatabaseManagament databaseManagament = new DatabaseManagament();
        DatabaseManagament db = new DatabaseManagament();
        string sendMailTo;
        int noCustomer = 0;
        public PetAndCustomerManagement()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));

        private void btn_deleteMedicine_Click(object sender, EventArgs e)
        {

        }

        private void btn_addMedicine_Click(object sender, EventArgs e)
        {

        }
        private void LoadConfig()
        {
            if (noCustomer == 0)
            {
                customerList.Columns["customerId"].HeaderText = "ID";
                customerList.Columns["fullName"].HeaderText = "Ad Soyad";
                customerList.Columns["phone"].HeaderText = "Telefon No";
                customerList.Columns["email"].HeaderText = "Email";
                customerList.Columns["address"].HeaderText = "Adress";
                customerList.Columns["alternateName"].HeaderText = "Alternatif İsim";
                customerList.Columns["alternatePhone"].HeaderText = "Alternatif Telefon";
                petList.Columns["petId"].HeaderText = "Pet ID";
            }
        }

        private void PetAndCustomerManagement_Load(object sender, EventArgs e)
        {

           
            //databaseManagament.GetPetSpecies(cb_species);

            //customer cb  
            db.OpenConnection();
            db.GetCustomers(Globals.CurrentUserBusinessAdminID, cb_customers);

            // cb species
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                string query = "SELECT \"speciesId\", \"speciesTitle\" " +
                               "FROM \"species\" ";


                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                petList.DataSource = dt;

                string query2 = "SELECT \"speciesId\", \"speciesTitle\" FROM \"species\" ORDER BY \"speciesId\" ASC";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(query2, baglan);
                DataTable dtspecies = new DataTable();
                da2.Fill(dtspecies);

                DataRow dr = dtspecies.NewRow();
                dr["speciesId"] = DBNull.Value;
                dr["speciesTitle"] = "Seçiniz";
                dtspecies.Rows.InsertAt(dr, 0);

                cb_species.DataSource = dtspecies;
                cb_species.DisplayMember = "speciesTitle";
                cb_species.ValueMember = "speciesId";
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
          
            try
            {
                baglan.Open();
                string query = "SELECT \"customerId\", \"fullName\", \"phone\", \"email\", \"address\", \"alternateName\", \"alternatePhone\" " +
                               "FROM \"customers\" " +
                               "WHERE \"businessId\" = @businessId";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("@businessId", Globals.CurrentUserBusinessAdminID);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count > 0)
                        {                          
                            customerList.DataSource = null; 
                            customerList.DataSource = dt;
                            customerList.AutoGenerateColumns = true; 
                        }
                        else
                        {
                            MessageBox.Show("Hiçbir müşteri bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            noCustomer = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}\n{ex.StackTrace}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglan.Close();
            }


            try
            {
                baglan.Open();
                string query = "SELECT \"pets\".\"petId\", " +
                               "\"customers\".\"fullName\" AS \"Sahibi\", " +
                               "\"pets\".\"petName\" AS \"Pet Adı\", " +
                               "\"species\".\"speciesTitle\" AS \"Türü\", " +
                               "\"pets\".\"breed\" AS \"Cinsi\", " +
                               "\"pets\".\"gender\" AS \"Cinsiyet\" " +
                               "FROM \"pets\" " +
                               "JOIN \"customers\" ON \"pets\".\"customerId\" = \"customers\".\"customerId\" " +
                               "JOIN \"species\" ON \"pets\".\"speciesId\" = \"species\".\"speciesId\"";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                petList.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadConfig();
                baglan.Close();
            }
            
        }

        private void customerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customerList.Rows[e.RowIndex]; // Satıra tıklandığında verileri alıyoruz.

                txt_customerName.Text = row.Cells["fullName"].Value?.ToString();
                txt_customerPhone.Text = row.Cells["phone"].Value?.ToString();
                txt_customerEmail.Text = row.Cells["email"].Value?.ToString();
                txt_customerAddress.Text = row.Cells["address"].Value?.ToString();
                txt_customerAlternate.Text = row.Cells["alternateName"].Value?.ToString();
                txt_customerAlternatePhone.Text = row.Cells["alternatePhone"].Value?.ToString();                            
                btn_addCustomer.Text = "Güncelle";
            }

        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            var inputsToCheck = new string[]
            {
                txt_customerName.Text,
                txt_customerPhone.Text,
                txt_customerEmail.Text,
                txt_customerAddress.Text
            };

            CheckClass checkClass = new CheckClass(inputsToCheck);
            if (!checkClass.Check(""))
            {
                return;
            }

            if (!CheckClass.IsValidEmail(txt_customerEmail.Text))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (long.TryParse(txt_customerPhone.Text, out long phone) == false)
                {
                    MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    try
                    {
                        if (baglan.State == ConnectionState.Closed)
                            baglan.Open();

                        string query;

                        if (btn_addCustomer.Text == "Güncelle")
                        {
                            // Müşteri güncelleme işlemi
                            if (customerList.SelectedRows.Count == 0)
                            {
                                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (CheckClass.IsValidPhone(txt_customerPhone.Text))
                            {
                                if (CheckClass.IsValidPhone(txt_customerAlternatePhone.Text) == true)
                                {
                                    query = "UPDATE \"customers\" SET \"fullName\" = @fullName, \"phone\" = @phone, " +
                                   "\"email\" = @email, \"address\" = @address, \"alternateName\" = @alternateName, " +
                                   "\"alternatePhone\" = @alternatePhone " +
                                   "WHERE \"customerId\" = @customerId";


                                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                                    {
                                        cmd.Parameters.AddWithValue("@fullName", txt_customerName.Text);
                                        cmd.Parameters.AddWithValue("@phone", txt_customerPhone.Text);
                                        cmd.Parameters.AddWithValue("@email", txt_customerEmail.Text);
                                        cmd.Parameters.AddWithValue("@address", txt_customerAddress.Text);
                                        cmd.Parameters.AddWithValue("@alternateName", txt_customerAlternate.Text);
                                        cmd.Parameters.AddWithValue("@alternatePhone", txt_customerAlternatePhone.Text);

                                        cmd.Parameters.AddWithValue("@customerId", Convert.ToInt32(customerList.SelectedRows[0].Cells["customerId"].Value));
                                        cmd.ExecuteNonQuery();
                                        baglan.Close();
                                        Inputs inputs = new Inputs(txt_customerName, txt_customerPhone, txt_customerEmail, txt_customerAddress, txt_customerAlternate, txt_customerAlternatePhone);
                                        inputs.ClearInputs();
                                    }

                                    MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                        else if (btn_addCustomer.Text == "Ekle")
                        {
                            if (CheckClass.IsValidPhone(txt_customerPhone.Text))
                            { 
                                    string customerName = txt_customerName.Text;
                                    // Müşteri ekleme işlemi
                                    query = "INSERT INTO \"customers\" (\"fullName\", \"phone\", \"email\", \"address\", \"alternateName\", \"alternatePhone\" , \"businessId\") " +
                                            "VALUES (@fullName, @phone, @email, @address, @alternateName, @alternatePhone, @businessid)";

                                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                                    {
                                        cmd.Parameters.AddWithValue("@fullName", txt_customerName.Text);
                                        cmd.Parameters.AddWithValue("@phone", txt_customerPhone.Text);
                                        cmd.Parameters.AddWithValue("@email", txt_customerEmail.Text);
                                        cmd.Parameters.AddWithValue("@address", txt_customerAddress.Text);
                                        cmd.Parameters.AddWithValue("@alternateName", txt_customerAlternate.Text);
                                        cmd.Parameters.AddWithValue("@alternatePhone", txt_customerAlternatePhone.Text);
                                        cmd.Parameters.AddWithValue("@businessid", Globals.CurrentUserBusinessAdminID);

                                        cmd.ExecuteNonQuery();
                                        baglan.Close();
                                        sendMailTo = txt_customerEmail.Text.Trim();
                                        Inputs inputs = new Inputs(txt_customerName, txt_customerPhone, txt_customerEmail, txt_customerAddress, txt_customerAlternate, txt_customerAlternatePhone);
                                        inputs.ClearInputs();
                                    }

                                    MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }

                        PetAndCustomerManagement_Load(null, null); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btn_addCustomerBtn_Click(object sender, EventArgs e)
        {
            Inputs inputs = new Inputs(txt_customerName, txt_customerPhone, txt_customerEmail, txt_customerAddress, txt_customerAlternate, txt_customerAlternatePhone);
            inputs.ClearInputs();
            btn_addCustomer.Text = "Ekle";
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            if (customerList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Seçilen müşteriyi silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    baglan.Open();

                    string query = "DELETE FROM \"customers\" WHERE \"customerId\" = @customerId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                        cmd.Parameters.AddWithValue("@customerId", Convert.ToInt32(customerList.SelectedRows[0].Cells["customerId"].Value));
                        cmd.ExecuteNonQuery();
                        baglan.Close();
                    }

                    MessageBox.Show("Müşteri başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PetAndCustomerManagement_Load(null, null); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Inputs inputs = new Inputs(txt_customerName, txt_customerPhone, txt_customerEmail, txt_customerAddress, txt_customerAlternate, txt_customerAlternatePhone);
                inputs.ClearInputs();
                btn_addCustomer.Text = "Ekle";
            }

        }

        private void tab_pets_Click(object sender, EventArgs e)
        {
                     
        }
        private void btn_addPet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                string query;

                if (btn_addPet.Text == "Güncelle")
                {
                    // Pet güncelleme işlemi
                    if (petList.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Lütfen güncellemek için bir pet seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (cb_customers.SelectedItem is ComboBoxItem selectedcustomer2)
                    {
                        query = "UPDATE \"pets\" SET \"customerId\" = @customerId, \"petName\" = @petName, " +
                            "\"speciesId\" = @speciesId, \"breed\" = @breed, \"gender\" = @gender " +
                            "WHERE \"petId\" = @petId";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                        {
                            cmd.Parameters.AddWithValue("@customerId", selectedcustomer2.Id);
                            cmd.Parameters.AddWithValue("@petName", txt_petName.Text);
                            cmd.Parameters.AddWithValue("@speciesId", Convert.ToInt32(cb_species.SelectedValue));
                            cmd.Parameters.AddWithValue("@breed", txt_breed.Text);
                            cmd.Parameters.AddWithValue("@gender", radio_disi.Checked ? "Dişi" : "Erkek");
                            cmd.Parameters.AddWithValue("@petId", Convert.ToInt32(petList.SelectedRows[0].Cells["petId"].Value));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Pet bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (btn_addPet.Text == "Ekle")
                {
                    if(cb_customers.SelectedItem is ComboBoxItem selectedcustomer)
                    {
                        // Pet ekleme işlemi
                        query = "INSERT INTO \"pets\" (\"customerId\", \"petName\", \"speciesId\", \"breed\", \"gender\") " +
                                "VALUES (@customerId, @petName, @speciesId, @breed, @gender)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                        {
                            cmd.Parameters.AddWithValue("@customerId", selectedcustomer.Id);
                            cmd.Parameters.AddWithValue("@petName", txt_petName.Text);
                            cmd.Parameters.AddWithValue("@speciesId", Convert.ToInt32(cb_species.SelectedValue));
                            cmd.Parameters.AddWithValue("@breed", txt_breed.Text);
                            cmd.Parameters.AddWithValue("@gender", radio_disi.Checked ? "Dişi" : "Erkek");
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Pet başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir müşteri seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            
                Inputs inputs = new Inputs( txt_petName, txt_breed);
                inputs.ClearInputs();
                PetAndCustomerManagement_Load(null,null);
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

        private void btn_addPetBtn_Click(object sender, EventArgs e)
        {
            Inputs inputs = new Inputs( txt_petName, txt_breed);
            inputs.ClearInputs();
            btn_addPet.Text = "Ekle";
        }

        private void petList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = petList.Rows[e.RowIndex];

                txt_petName.Text = row.Cells["Pet Adı"].Value?.ToString();
                cb_customers.Text = row.Cells["Sahibi"].Value?.ToString();
                if (int.TryParse(row.Cells["Türü"].Value?.ToString(), out int selectedSpeciesId))
                {
                    cb_species.SelectedValue = selectedSpeciesId;
                }
                else
                {
                    cb_species.SelectedIndex = 0; //Varsayılan "Seçiniz" seçeneği
                }

                txt_breed.Text = row.Cells["Cinsi"].Value?.ToString();

                if (row.Cells["Cinsiyet"].Value?.ToString() == "Dişi")
                {
                    radio_disi.Checked = true;
                }
                else if (row.Cells["Cinsiyet"].Value?.ToString() == "Erkek")
                {
                    radio_erkek.Checked = true;
                }

                btn_addPet.Text = "Güncelle";
            }

        }

        private void btn_deletePet_Click(object sender, EventArgs e)
        {
            if (petList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir pet seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Seçilen peti silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    baglan.Open();

                    string query = "DELETE FROM \"pets\" WHERE \"petId\" = @petId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                       
                        cmd.Parameters.AddWithValue("@petId", Convert.ToInt32(petList.SelectedRows[0].Cells["petId"].Value));
                        cmd.ExecuteNonQuery();
                    }

                    baglan.Close();
                    MessageBox.Show("Pet başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    PetAndCustomerManagement_Load(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglan.Close();
                }
              
                Inputs inputs = new Inputs( txt_petName,txt_breed);
                inputs.ClearInputs();             
                btn_addPet.Text = "Ekle";
            }

        }
    }
}

