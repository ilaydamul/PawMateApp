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
            db.OpenConnection();
            db.GetCustomers(Globals.CurrentUserBusinessAdminID, cb_customers);
            db.GetVets(Globals.CurrentUserBusinessAdminID, cb_vets);
            dp_date.Format = DateTimePickerFormat.Long;

            string getallvisitsqueryBefore = @"
SELECT v.""visitId"", v.""visitDate"", v.""visitReason"", p.""petName"", c.""fullName"", c.""phone"", u.""username"" 
FROM ""visits"" v
JOIN ""pets"" p ON p.""petId"" = v.""petId""
JOIN ""customers"" c ON c.""customerId"" = p.""customerId""
JOIN ""users"" u ON u.""userId"" = v.""vetId""
WHERE v.""businessid"" = @businessid AND v.""visitDate"" >= current_date
ORDER BY v.""visitDate"" ASC;";



            
            using (var cmd = new Npgsql.NpgsqlCommand(getallvisitsqueryBefore, db.baglan))
            {     
                 cmd.Parameters.AddWithValue("@businessid", Globals.CurrentUserBusinessAdminID);
                using (var dr = cmd.ExecuteReader()) {

                    while (dr.Read())
                    {
                        AppointItem appointItem = new AppointItem();
                        appointItem.VisitId = dr["visitId"].ToString();
                        appointItem.VisitDate = dr["visitDate"].ToString();
                        appointItem.CustomerName = dr["fullName"].ToString(); 
                        appointItem.CustomerPhone = dr["phone"].ToString(); 
                        appointItem.PetName = dr["petName"].ToString(); 
                        appointItem.VetName = dr["fullName"].ToString();
                        appointItem.Reason = dr["visitReason"].ToString(); 
                        upcomingAppointments.Controls.Add(appointItem);
                    }
                }
            };


            string getallvisitsqueryAfter = @"
SELECT v.""visitId"", v.""visitDate"", v.""visitReason"", p.""petName"", c.""fullName"", c.""phone"", u.""username"" 
FROM ""visits"" v
JOIN ""pets"" p ON p.""petId"" = v.""petId""
JOIN ""customers"" c ON c.""customerId"" = p.""customerId""
JOIN ""users"" u ON u.""userId"" = v.""vetId""
WHERE v.""businessid"" = @businessId AND v.""visitDate"" < current_date
ORDER BY v.""visitDate"" DESC;";




            using (var cmd = new Npgsql.NpgsqlCommand(getallvisitsqueryAfter, db.baglan))
            {
                cmd.Parameters.AddWithValue("@businessId", Globals.CurrentUserBusinessAdminID);
                using (var dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        AppointItem appointItem = new AppointItem();
                        appointItem.VisitId = dr["visitId"].ToString();
                        appointItem.VisitDate = dr["visitDate"].ToString();
                        appointItem.CustomerName = dr["fullName"].ToString();
                        appointItem.CustomerPhone = dr["phone"].ToString();
                        appointItem.PetName = dr["petName"].ToString();
                        appointItem.VetName = dr["fullName"].ToString();
                        appointItem.Reason = dr["visitReason"].ToString();
                        pastAppointments.Controls.Add(appointItem);
                    }
                }
            };
            db.CloseConnection();
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
                        if (db.AddMeeting(petselected.Id, date, txt_visitReason.Text.Trim(), vetsselected.Id))
                        {

                            MessageBox.Show("Randevu başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadAppointments();
                            txt_visitReason.Text = "";
                            cb_customers.SelectedIndex = -1;
                            cb_pets.SelectedIndex = -1;
                            cb_vets.SelectedIndex = -1;

//                            string body = $@"
//<table align=""center"" bgcolor=""#ffffff"" style=""border-top:4px solid #ffffff;background-color:#ffffff;padding-bottom:60px;margin: 0 auto;"">
//  <tbody>
//    <tr>
//      <td style=""padding-top:50px; text-align:center;"">
//        <img alt=""Logo"" src=""https://i.hizliresim.com/jinrkop.jpeg"" width=""300"" height=""auto"" border=""0"" hspace=""0"" vspace=""0"" style=""display:block; margin-left:auto; margin-right:auto;"">
//      </td>
//    </tr>
//    <tr>
//      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
//        <strong style=""font-size:32px;line-height:38px;color:#ff6b00;"">Merhabalar, {customerName}! 👋</strong><br><br>
//        <span style=""font-size:22px;line-height:30px;color:#2d2d2d;"">
//          Veteriner kliniğiniz, {Globals.BusinessName} tarafından başarıyla sisteme kaydınız yapıldı! 🎉
//        </span><br><br>
//        Harika bir haber! <strong> {Globals.BusinessName} </strong> adlı veteriner kliniğiniz, siz ve sevimli dostunuzun kaydını başarıyla tamamladı🐾<br><br>
//        <strong style=""font-size:20px;color:#ff3c00;"">Bundan sonra küçük dostumuzun işlemleri güvenli bir altyapı sağlayan Pawmate'in güvenlikli duvarlaklarının arkasında!🌟</strong><br><br>
//      </td>
//    </tr>
//    <tr>
//      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
//        <strong style=""font-size:20px;color:#2d2d2d;"">Veteriner kliniğinizle sağlıklı bir yolculuğa çıkmaya hazır olun! 🚀</strong><br><br>
//        Sizi ve sevimli dostunuzu daha yakından tanımak için sabırsızlanıyoruz! Kliniğinizle birlikte birçok güzel anı paylaşacağımıza eminiz. <br><br>
//        <em style=""font-size:16px;color:#888888;"">Pawmate Destek Ekibi</em><br>
//        <span style=""font-size:14px;color:#cccccc;"">Herhangi bir sorunuz olduğunda bizimle iletişime geçebilirsiniz!</span>
//      </td>
//    </tr>
//  </tbody>
//</table>
//";
//                            SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
//                            sendMail.SendMail(Globals.BusinessName + " veteriner bilgilendirmesi", body, sendMailTo);
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
