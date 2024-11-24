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

        //Listede herhangi bir işletmeye tıklanılınca soldaki inputlar dolacak. Değişiklik yapıldığında güncelleme yapılacak
        //Dikkat! Üstüne tıklanıldığında ve input içerikleri silindiğinde uyarı verilmeli, dolu olan veriler boş kaydedilmemeli!
        private void btn_addUpdateBusiness_Click(object sender, EventArgs e)
        {

        }

        private void btn_addBusiness_Click(object sender, EventArgs e)
        {
            //Soldaki input alanlarının içi temizlenmeli, btn_addUpdateBusiness buton Texti Ekle olmalı, herhangi listede -
            //bir işletmeye tıklanıldığında Güncelle yazmalı.
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

            }
        }

        private void btn_deleteBusiness_Click(object sender, EventArgs e)
        {

            
            if (businessesList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir işletme seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            
            DialogResult dialogResult = MessageBox.Show("Seçilen işletmeyi silmek istediğinizden emin misiniz?",                                                        "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {                   
                    baglan.Open();//işletme silinse bile 'connection already open' hatası var düzeltilmesi gerek

                    
                    string query = "DELETE FROM \"Businesses\" WHERE \"BusinessId\" = @BusinessId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                        
                        cmd.Parameters.AddWithValue("@BusinessId", Convert.ToInt32(businessesList.SelectedRows[0].Cells["BusinessId"].Value));
                        cmd.ExecuteNonQuery();
                    }
                    
                    MessageBox.Show("İşletme başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BusinessManagement_Load(null, null); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    
                    if (baglan.State == ConnectionState.Open)
                    {
                        baglan.Close();
                    }
                }

            }
        }

    }

}

    





