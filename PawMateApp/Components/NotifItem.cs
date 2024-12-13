using PawMateApp.Screens.Admin;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Npgsql;
using System.ComponentModel;
using System.Linq;

namespace PawMateApp.Components
{
    public partial class NotifItem : UserControl
    {
        Npgsql.NpgsqlConnection baglan = new Npgsql.NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
        public NotifItem()
        {
            InitializeComponent();
        }

        public string _businessId { get; set; }
        public string _businessName { get; set; }
        public string _businessEmail { get; set; } 

        [Category("Props")]
        public string BusinessName
        {
            get { return _businessName; }
            set { _businessName = value; txt_businessName.Text = value; }
        }

        [Category("Props")]
        public string BusinessId
        {
            get { return _businessId; }
            set { _businessId = value; }
        }

        [Category("Props")]
        public string BusinessEmail  
        {
            get { return _businessEmail; }
            set { _businessEmail = value; }
        }

      



        private void btn_approveBusiness_Click(object sender, EventArgs e)
        {
            Notifications notificationsForm = Application.OpenForms["notifications"] as Notifications;
            if (notificationsForm != null)
            {
                try
                {
                    baglan.Open();

              
                    string query = "SELECT \"email\", \"authorizedName\" FROM \"businesses\" WHERE \"businessId\" = @businessId";
                    Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, baglan);
                    cmd.Parameters.AddWithValue("@businessId", int.Parse(BusinessId));

                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    string businessEmail = string.Empty;
                    string authorizedName = string.Empty;

                    
                    if (reader.Read())
                    {
                        businessEmail = reader.GetString(0); 
                        authorizedName = reader.GetString(1);
                    }
                    reader.Close();
                    Debug.WriteLine(businessEmail+ " :Mail " + authorizedName + " :AuthorizedName ");
                    
                    string updateQuery = "UPDATE \"notifications\" SET \"isRead\"=true WHERE \"businessId\" = @businessId";
                    Npgsql.NpgsqlCommand updateCmd = new Npgsql.NpgsqlCommand(updateQuery, baglan);
                    updateCmd.Parameters.AddWithValue("@businessId", int.Parse(BusinessId));
                    updateCmd.ExecuteNonQuery();

                    string currentPassword = CheckClass.GenerateRandomPassword(12); // Default password for new businesses

                  
                    string insertToUsers = "INSERT INTO \"users\" (\"username\", \"password\", \"fullName\", \"email\", \"businessId\", \"isBusinessAdmin\")" +
                                           "VALUES (@username, @password, @fullname, @email, @businessId, @isbusinessadmin)";
                    Npgsql.NpgsqlCommand insertCmd = new Npgsql.NpgsqlCommand(insertToUsers, baglan);
                    insertCmd.Parameters.AddWithValue("@username", BusinessName);
                    insertCmd.Parameters.AddWithValue("@password", currentPassword);
                    insertCmd.Parameters.AddWithValue("@fullname", authorizedName);
                    insertCmd.Parameters.AddWithValue("@email", businessEmail);
                    insertCmd.Parameters.AddWithValue("@businessId", int.Parse(BusinessId));
                    insertCmd.Parameters.AddWithValue("@isbusinessadmin", true);
                    insertCmd.ExecuteNonQuery();

                    Debug.WriteLine(BusinessId + " ID'li İşletme onaylandı.");
                    string updateBusinessApproval = "UPDATE \"businesses\" SET \"isApproved\" = TRUE WHERE \"businessId\" = @businessId";
                    Npgsql.NpgsqlCommand UpdateCmdBusiness = new Npgsql.NpgsqlCommand(updateBusinessApproval, baglan);
                    UpdateCmdBusiness.Parameters.AddWithValue("@businessId", int.Parse(BusinessId));
                    UpdateCmdBusiness.ExecuteNonQuery();


                    SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
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
        <strong style=""font-size:32px;line-height:38px;color:#ff6b00;"">Tebrikler! Veteriner Kliniği Başvurunuz Onaylandı 🎉</strong><br><br>
        Harika bir haber! Kliniğiniz başarıyla sisteme kaydedildi. Şimdi, veteriner hizmetlerinizi sunmaya başlamak için tek yapmanız gereken giriş yapmak! 🌟<br><br>
        <strong style=""font-size:20px;color:#ff3c00;"">Hesabınızın Giriş Bilgileri:</strong><br><br>
        <strong style=""font-size:18px;color:#2d2d2d;"">Kullanıcı Adı: <span style=""color:#ff6b00;"">{BusinessName}</span></strong><br>
        <strong style=""font-size:18px;color:#2d2d2d;"">Şifre: <span style=""color:#ff6b00;"">{currentPassword}</span></strong><br><br>
        <strong style=""font-size:20px;color:#ff3c00;"">Veterinerlik hizmetlerinizi kolayca yönetin!</strong><br><br>
        Giriş yaparak, kliniğinizin yönetim paneline erişebilir ve işlerinizi hızlıca organize edebilirsiniz. Hayalinizdeki başarıyı elde etmek için burada olacağız!<br><br>
        <strong style=""font-size:20px;color:#2d2d2d;"">Şimdi Giriş Yapın ve Kliniğinizi Yönetin! 🚀</strong><br><br>
        Unutmayın, her zaman destek ekibimiz yanınızda! Sorularınız olduğunda, bizlere ulaşabilirsiniz.<br><br>
        <em style=""font-size:16px;color:#888888;"">Pawmate Destek Ekibi</em>
      </td>
    </tr>
  </tbody>
</table>
";

                    sendMail.SendMail("Pawmate Onay Süreci", body, businessEmail);
                    Debug.WriteLine("Kayıt Talebi bilgilendirilmesi başarıyla gönderildi..");

                    MessageBox.Show("İşletme onaylandı, bilgilendirme maili yollandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    notificationsForm.RefreshFlowLayoutPanel();
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
            else
            {
                MessageBox.Show("Notifications formu açılamadı.");
            }
        }

        private void btn_declineBusiness_Click(object sender, EventArgs e)
        {
            Notifications notificationsForm = Application.OpenForms["notifications"] as Notifications;
            if (notificationsForm != null)
            {
                try
                {
                    baglan.Open();
                    string query = "UPDATE \"notifications\" SET \"isRead\"=true WHERE \"businessId\"=" + BusinessId;
                    Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, baglan);
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    Debug.WriteLine(BusinessId + " ID'li İşletme red edildi..");
                    SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
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
        <strong style=""font-size:32px;line-height:38px;color:#ff6b00;"">Üzgünüz, Veteriner Kliniğinizin Başvurusu Reddedildi 😞</strong><br><br>
        Ne yazık ki, başvurunuz bazı kriterlere uymadığı için şu anda kabul edilememiştir. Ancak endişelenmeyin, bu son değil!<br><br>
        <strong style=""font-size:20px;color:#ff3c00;"">Başvurunuzu gözden geçirebilir ve tekrar deneyebilirsiniz.</strong><br><br>
        Veteriner kliniğinizin başvurusunu tekrar gönderebilmeniz için gerekli tüm bilgilere sahip olmanız önemli. Sabırlı olun, başarıya ulaşmak sadece bir adım uzağınızda! 🌟<br><br>
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
        <strong style=""font-size:20px;color:#2d2d2d;"">Başvurunuzu Yeniden Göndermek İçin Hazır Mısınız? 🚀</strong><br><br>
        Umutsuz olmayın, birlikte her zaman daha iyisini başarabiliriz!<br><br>
        <em style=""font-size:16px;color:#888888;"">Pawmate Destek Ekibi</em>
      </td>
    </tr>
  </tbody>
</table>
";
                    sendMail.SendMail("Pawmate Onay Süreci", body, BusinessEmail);
                    Debug.WriteLine("Kayıt Talebi bilgilendirilmesi başarıyla gönderildi..");
                    MessageBox.Show("İşletme red edildi., bilgilendirme maili yollandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    notificationsForm.RefreshFlowLayoutPanel();
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
            else
            {
                MessageBox.Show("Notifications formu açılamadı.");
            }
        }

        private void txt_businessName_Click(object sender, EventArgs e)
        {

        }
    }
}
