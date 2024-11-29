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

            try
            {
                if (businessesList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellemek için bir işletme seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_businessName.Text) || string.IsNullOrWhiteSpace(txt_authName.Text) ||
                    string.IsNullOrWhiteSpace(txt_businessEmail.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) ||
                    string.IsNullOrWhiteSpace(txt_address.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (baglan.State == ConnectionState.Closed) 
                    
                    baglan.Open();

                string query = "UPDATE \"Businesses\" SET \"BusinessName\" = @BusinessName, \"AuthorizedName\" = @AuthorizedName, " +
                               "\"Email\" = @Email, \"Phone\" = @Phone, \"Address\" = @Address, \"IsApproved\" = @IsApproved " +
                               "WHERE \"BusinessId\" = @BusinessId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("@BusinessName", txt_businessName.Text);
                    cmd.Parameters.AddWithValue("@AuthorizedName", txt_authName.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_businessEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txt_phone.Text);
                    cmd.Parameters.AddWithValue("@Address", txt_address.Text);
                    cmd.Parameters.AddWithValue("@IsApproved", radio_approved.Checked);
                    cmd.Parameters.AddWithValue("@BusinessId", Convert.ToInt32(businessesList.SelectedRows[0].Cells["BusinessId"].Value));

                    cmd.ExecuteNonQuery();
                    baglan.Close();//hata yüzünden bağlantıyı burada kapattım.
                }

                MessageBox.Show("İşletme bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Ekrana gelindiğinde işletme bilgilerinin businessesList'de görünmesi
        private void BusinessManagement_Load(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();
                string query = "SELECT \"BusinessId\", \"BusinessName\", \"AuthorizedName\", \"Email\", \"Phone\", \"Address\", \"IsApproved\" FROM \"Businesses\"";
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
                txt_businessName.Text = row.Cells["BusinessName"].Value?.ToString();
                txt_authName.Text = row.Cells["AuthorizedName"].Value?.ToString();
                txt_businessEmail.Text = row.Cells["Email"].Value?.ToString();
                txt_phone.Text = row.Cells["Phone"].Value?.ToString();
                txt_address.Text = row.Cells["Address"].Value?.ToString();
                radio_approved.Checked = Convert.ToBoolean(row.Cells["IsApproved"].Value);

                btn_addUpdateBusiness.Text = "Güncelle";

            }
        }

        private void btn_deleteBusiness_Click(object sender, EventArgs e)
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

                    
                    string query = "DELETE FROM \"Businesses\" WHERE \"BusinessId\" = @BusinessId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                        
                        cmd.Parameters.AddWithValue("@BusinessId", Convert.ToInt32(businessesList.SelectedRows[0].Cells["BusinessId"].Value));
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

            }
        }

    }

}

    





