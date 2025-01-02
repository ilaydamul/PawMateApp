using PawMateApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PawMateApp.Login;

namespace PawMateApp.Screens
{

    public partial class AppointManagement : Form
    {
        string customerName;
        DatabaseManagament db = new DatabaseManagament();

        public AppointManagement()
        {
            InitializeComponent();
        }

        private void AppointManagement_Load(object sender, EventArgs e)
        {
            try
            {
                db.OpenConnection();
                db.GetCustomers(Globals.CurrentUserBusinessAdminID, cb_customers);
                db.GetVets(Globals.CurrentUserBusinessAdminID, cb_vets);
                //dp_date.Format = DateTimePickerFormat.Long;

                ExecuteQueryAndLoadItems(@"
            SELECT v.""visitId"", v.""visitDate"", v.""visitReason"", p.""petName"", c.""fullName"", c.""phone"", u.""username"" 
            FROM ""visits"" v
            JOIN ""pets"" p ON p.""petId"" = v.""petId""
            JOIN ""customers"" c ON c.""customerId"" = p.""customerId""
            JOIN ""users"" u ON u.""userId"" = v.""vetId""
            WHERE v.""businessid"" = @businessid AND v.""visitDate"" >= current_date
            ORDER BY v.""visitDate"" ASC;", upcomingAppointments);

                ExecuteQueryAndLoadItems(@"
            SELECT v.""visitId"", v.""visitDate"", v.""visitReason"", p.""petName"", c.""fullName"", c.""phone"", u.""username"" 
            FROM ""visits"" v
            JOIN ""pets"" p ON p.""petId"" = v.""petId""
            JOIN ""customers"" c ON c.""customerId"" = p.""customerId""
            JOIN ""users"" u ON u.""userId"" = v.""vetId""
            WHERE v.""businessid"" = @businessId AND v.""visitDate"" < current_date
            ORDER BY v.""visitDate"" DESC;", pastAppointments);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection(); // Bağlantıyı yalnızca bir kez kapat
            }
        }


        private void ExecuteQueryAndLoadItems(string query, Control container)
        {
            using (var cmd = new Npgsql.NpgsqlCommand(query, db.baglan))
            {
                cmd.Parameters.AddWithValue("@businessid", Globals.CurrentUserBusinessAdminID);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        AppointItem appointItem = new AppointItem
                        {
                            VisitId = dr["visitId"].ToString(),
                            VisitDate = dr["visitDate"].ToString(),
                            CustomerName = dr["fullName"].ToString(),
                            CustomerPhone = dr["phone"].ToString(),
                            PetName = dr["petName"].ToString(),
                            VetName = dr["fullName"].ToString(),
                            Reason = dr["visitReason"].ToString()
                        };
                        container.Controls.Add(appointItem);
                    }
                }
            }
        }

        public void ReloadAppointments()
        {
            upcomingAppointments.Controls.Clear();
            pastAppointments.Controls.Clear();
            AppointManagement_Load(null, null);
        }


        private void btn_addVisit_Click(object sender, EventArgs e)
        {
            DateTime date = dp_date.Value;
            db.OpenConnection();
            if (cb_customers.SelectedItem != null && cb_pets.SelectedItem != null && cb_vets.SelectedItem != null)
            {
                if (cb_customers.SelectedItem is ComboBoxItem selected && cb_pets.SelectedItem is ComboBoxItem petselected && cb_vets.SelectedItem is ComboBoxItem vetsselected)
                {
                    customerName = selected.DisplayName;
                    CheckClass check = new CheckClass(new string[] { txt_visitReason.Text, dp_date.Value.ToString() });
                    if (!check.Check(""))
                    {
                        return;
                    }
                    else
                    {
                        if (db.AddMeeting(petselected.Id, date, txt_visitReason.Text.Trim(), vetsselected.Id, selected.Id))
                        {
                            //Mail Gönderme islemleri
                            string getCustomerMail = db.getCustomerMail(selected.Id);
                            string body = $@"
<table align=""center"" bgcolor=""#ffffff"" style=""border-top:4px solid #ffffff;background-color:#ffffff;padding-bottom:60px;margin: 0 auto;"">
  <tbody>
    <tr>
      <td style=""padding-top:50px; text-align:center;"">
        <img alt=""Logo"" src=""https://i.hizliresim.com/8wrfqod.png"" width=""300"" height=""auto"" border=""0"" hspace=""0"" vspace=""0"" style=""display:block; margin-left:auto; margin-right:auto;"">
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
        <strong style=""font-size:32px;line-height:38px;color:#ff6b00;"">Randevunuz Başarıyla Kaydedildi 🎉</strong><br><br>
        Sayın {customerName}, aşağıdaki detaylarla randevunuz başarıyla oluşturulmuştur:<br><br>
        <table style=""margin:0 auto;border-collapse:collapse;width:80%;"">
          <tr>
            <td style=""text-align:left;padding:10px;border:1px solid #ddd;""><strong>Randevu Tarihi:</strong></td>
            <td style=""text-align:left;padding:10px;border:1px solid #ddd;"">{dp_date.Value:dd.MM.yyyy HH:mm}</td>
          </tr>
          <tr>
            <td style=""text-align:left;padding:10px;border:1px solid #ddd;""><strong>Randevu Nedeni:</strong></td>
            <td style=""text-align:left;padding:10px;border:1px solid #ddd;"">{txt_visitReason.Text}</td>
          </tr>
          <tr>
            <td style=""text-align:left;padding:10px;border:1px solid #ddd;""><strong>Evcil Hayvan:</strong></td>
            <td style=""text-align:left;padding:10px;border:1px solid #ddd;"">{cb_pets.SelectedItem}</td>
          </tr>
          <tr>
            <td style=""text-align:left;padding:10px;border:1px solid #ddd;""><strong>Veteriner:</strong></td>
            <td style=""text-align:left;padding:10px;border:1px solid #ddd;"">{cb_vets.SelectedItem}</td>
          </tr>
        </table>
        <br><br>
        Veteriner kliniğimize randevu saatinden en az 10 dakika önce gelmenizi rica ederiz.<br><br>
        <strong style=""font-size:20px;color:#ff3c00;"">Herhangi bir sorunuz varsa bizimle iletişime geçmekten çekinmeyin.</strong>
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
        <strong style=""font-size:20px;color:#2d2d2d;"">Veteriner Kliniğinizde Görüşmek Üzere! 🐾</strong><br><br>
        <em style=""font-size:16px;color:#888888;"">Pawmate Destek Ekibi</em>
      </td>
    </tr>
  </tbody>
</table>
";
                            SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
                            sendMail.SendMail("Pawmate Randevu Bilgilendirme", body, getCustomerMail);
                            //Mail Gönderme islemleri
                            MessageBox.Show("Randevu başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadAppointments();
                            txt_visitReason.Text = "";
                            cb_customers.SelectedIndex = -1;
                            cb_pets.SelectedIndex = -1;
                            cb_vets.SelectedIndex = -1;

                        }
                        else
                        {
                            MessageBox.Show("Randevu eklenirken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.CloseConnection();
        }

        private void cb_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_customers.SelectedItem is ComboBoxItem comboboxitem)
            {
                db.OpenConnection();
                db.GetPets(comboboxitem.Id, cb_pets);
                db.CloseConnection();
            }
            
        }
    }
}
