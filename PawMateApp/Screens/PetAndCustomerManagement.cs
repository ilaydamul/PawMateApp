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
    public partial class PetAndCustomerManagement : Form
    {
        string sendMailTo;
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

        private void PetAndCustomerManagement_Load(object sender, EventArgs e)
        {
            //Petlerdeki cb_species için species veritabanından çekilmeli.

            try
            {
                baglan.Open();

                
                string query = "SELECT \"customerId\", \"fullName\", \"phone\", \"email\", \"address\", \"alternateName\", \"alternatePhone\", \"alternateNote\" FROM \"customers\"";

                
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                customerList.DataSource = dt;
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

                        else if (btn_addCustomer.Text == "Ekle")
                        {
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
                            string body = $@"
<table align=""center"" bgcolor=""#ffffff"" style=""border-top:4px solid #ffffff;background-color:#ffffff;padding-bottom:60px;margin: 0 auto;"">
  <tbody>
    <tr>
      <td style=""padding-top:50px; text-align:center;"">
        <img alt=""Logo"" src=""https://i.hizliresim.com/jinrkop.jpeg"" width=""300"" height=""auto"" border=""0"" hspace=""0"" vspace=""0"" style=""display:block; margin-left:auto; margin-right:auto;"">
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
        <strong style=""font-size:32px;line-height:38px;color:#ff6b00;"">Merhabalar, {Globals.CurrentName}! 👋</strong><br><br>
        <span style=""font-size:22px;line-height:30px;color:#2d2d2d;"">
          Veteriner kliniğiniz, {Globals.BusinessName} tarafından başarıyla sisteme kaydınız yapıldı! 🎉
        </span><br><br>
        Harika bir haber! <strong> {Globals.BusinessName} </strong> adlı veteriner kliniğiniz, siz ve sevimli dostunuzun kaydını başarıyla tamamladı🐾<br><br>
        <strong style=""font-size:20px;color:#ff3c00;"">Bundan sonra küçük dostumuzun işlemleri güvenli bir altyapı sağlayan Pawmate'in güvenlikli duvarlaklarının arkasında!🌟</strong><br><br>
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
        <strong style=""font-size:20px;color:#2d2d2d;"">Veteriner kliniğinizle sağlıklı bir yolculuğa çıkmaya hazır olun! 🚀</strong><br><br>
        Sizi ve sevimli dostunuzu daha yakından tanımak için sabırsızlanıyoruz! Kliniğinizle birlikte birçok güzel anı paylaşacağımıza eminiz. <br><br>
        <em style=""font-size:16px;color:#888888;"">Pawmate Destek Ekibi</em><br>
        <span style=""font-size:14px;color:#cccccc;"">Herhangi bir sorunuz olduğunda bizimle iletişime geçebilirsiniz!</span>
      </td>
    </tr>
  </tbody>
</table>

";
                            SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
                            sendMail.SendMail(Globals.BusinessName+ " veteriner bilgilendirmesi", body, sendMailTo);

                            MessageBox.Show("Kayıt talebiniz alınmıştır. Yakın zamanda size mail ile dönüş yapacağız.",
                                            "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //Sahibi müşterilerden çekilmeli
           
        }

        private void btn_addPet_Click(object sender, EventArgs e)
        {
           
        }

      
    }
}

