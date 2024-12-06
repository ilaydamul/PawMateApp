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

namespace PawMateApp.Screens.Admin
{
    public partial class BusinessManagement : Form
    {
        
        public BusinessManagement()
        {
            InitializeComponent();           
        }

        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));

        private void btn_addUpdateBusiness_Click(object sender, EventArgs e)
        {
            
            var inputsToCheck = new string[]

                {
                    txt_businessName.Text,
                    txt_authName.Text,
                    txt_businessEmail.Text,
                    txt_phone.Text,
                    txt_address.Text
                };

            CheckClass checkClass = new CheckClass(inputsToCheck);
            if (!checkClass.Check(""))
            {
                return; 
            }

            if (!CheckClass.IsValidEmail(txt_businessEmail.Text))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();

                string query;

                if (btn_addUpdateBusiness.Text == "Güncelle")
                {
                    // İşletme güncelleme işlemi
                    if (businessesList.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Lütfen güncellemek için bir işletme seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    query = "UPDATE \"businesses\" SET \"businessName\" = @businessName, \"authorizedName\" = @authorizedName, " +
                            "\"email\" = @email, \"phone\" = @phone, \"address\" = @address, \"isApproved\" = @isApproved " +
                            "WHERE \"businessId\" = @businessId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                        cmd.Parameters.AddWithValue("@businessName", txt_businessName.Text);
                        cmd.Parameters.AddWithValue("@authorizedName", txt_authName.Text);
                        cmd.Parameters.AddWithValue("@email", txt_businessEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                        cmd.Parameters.AddWithValue("@address", txt_address.Text);
                        cmd.Parameters.AddWithValue("@isApproved", radio_approved.Checked);
                        cmd.Parameters.AddWithValue("@businessId", Convert.ToInt32(businessesList.SelectedRows[0].Cells["businessId"].Value));
                        cmd.ExecuteNonQuery();
                        baglan.Close();
                        
                    }

                    MessageBox.Show("İşletme bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (btn_addUpdateBusiness.Text == "Ekle")
                {
                    
                    // işletme ekleme işlemi
                    query = "INSERT INTO \"businesses\" (\"businessName\", \"authorizedName\", \"email\", \"phone\", \"address\", \"isApproved\") " +
                     "VALUES (@businessName, @authorizedName, @email, @phone, @address, @isApproved)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                        cmd.Parameters.AddWithValue("@businessName", txt_businessName.Text);
                        cmd.Parameters.AddWithValue("@authorizedName", txt_authName.Text);
                        cmd.Parameters.AddWithValue("@email", txt_businessEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                        cmd.Parameters.AddWithValue("@address", txt_address.Text);
                        cmd.Parameters.AddWithValue("@isApproved", radio_approved.Checked);
                        cmd.ExecuteNonQuery();
                        baglan.Close();
                        Inputs inputs = new Inputs(txt_businessName, txt_authName, txt_businessEmail, txt_phone, txt_address);
                        inputs.ClearInputs();
                    }

                    MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                BusinessManagement_Load(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_addBusiness_Click(object sender, EventArgs e)
        {
            Inputs inputs = new Inputs(txt_businessName, txt_authName, txt_businessEmail, txt_phone,txt_address);
            inputs.ClearInputs();
            btn_addUpdateBusiness.Text = "Ekle";
        }

        private void BusinessManagement_Load(object sender, EventArgs e)//Ekrana gelindiğinde işletme bilgilerinin businessesList'de görünmesi
        {

            try
            {
                baglan.Open();
                string query = "SELECT \"businessId\", \"businessName\", \"authorizedName\", \"email\", \"phone\", \"address\", \"isApproved\" FROM \"businesses\"";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                businessesList.DataSource = dt;
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

        private void businessesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = businessesList.Rows[e.RowIndex];//satıra tıklandığında inputların dolması
                txt_businessName.Text = row.Cells["businessName"].Value?.ToString();
                txt_authName.Text = row.Cells["authorizedName"].Value?.ToString();
                txt_businessEmail.Text = row.Cells["email"].Value?.ToString();
                txt_phone.Text = row.Cells["phone"].Value?.ToString();
                txt_address.Text = row.Cells["address"].Value?.ToString();
                radio_approved.Checked = Convert.ToBoolean(row.Cells["isApproved"].Value);
                btn_addUpdateBusiness.Text = "Güncelle";

            }
        }

        private void btn_deleteBusiness_Click(object sender, EventArgs e)//işletme silme işlemi yaptırıyoruz.
        {
          
            if (businessesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir işletme seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            
            DialogResult dialogResult = MessageBox.Show("Seçilen işletmeyi silmek istediğinizden emin misiniz?","Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {                   
                    baglan.Open();

                    string query = "DELETE FROM \"businesses\" WHERE \"businessId\" = @businessId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                        cmd.Parameters.AddWithValue("@businessId", Convert.ToInt32(businessesList.SelectedRows[0].Cells["businessId"].Value));
                        cmd.ExecuteNonQuery();
                        baglan.Close();
                    }
                    MessageBox.Show("İşletme başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BusinessManagement_Load(null, null); 
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Inputs inputs = new Inputs(txt_businessName, txt_authName, txt_businessEmail, txt_phone, txt_address);
                inputs.ClearInputs();



            }
        }

    }

}

    





