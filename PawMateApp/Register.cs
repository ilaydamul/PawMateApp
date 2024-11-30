using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;

namespace PawMateApp
{
    public partial class Register : Form
    {

        public Register()
        {
            MoveForm moveForm = new MoveForm(this);
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(moveForm.Form_MouseDown);
            this.MouseMove += new MouseEventHandler(moveForm.Form_MouseMove);
            this.MouseUp += new MouseEventHandler(moveForm.Form_MouseUp);
        }

        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
        
        private void Register_Paint(object sender, PaintEventArgs e)
        {
            Color leftColor = ColorTranslator.FromHtml("#B5B3F1");
            Color rightColor = ColorTranslator.FromHtml("#2A21DC");

            using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, leftColor, rightColor, 0F))
            {
                e.Graphics.FillRectangle(lgb, this.ClientRectangle);
            }
        }

        private void lbl_goLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btn_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btn_register_Click(object sender, EventArgs e)
        {

            //businesses veritabanına ilgili veriler gelecek, boş olanlar boş kalacak.
            //Bu bilgiler girildikten sonra "Kayıt talebiniz alınmıştır. Yakın zamanda size mail ile dönüş yapacağız."  yazısı gelecek.  

            //Bunların ardından notifications veritabanına bilgi gidecek. businesses veritabanına ilgili veri eklendikten sonra
            //idsi ile birlikte kaydedilecek.
            CheckClass checkClass = new CheckClass(new string[] { });
            if (!CheckClass.IsValidEmail(txt_businessEmail.Text))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                if(int)
                try
                {

                    baglan.Open();
                    string insertBusinessQuery = "INSERT INTO \"Businesses\" (\"BusinessName\", \"AuthorizedName\", \"Email\", \"Phone\", \"IsApproved\") " +
                                                 "VALUES (@BusinessName, @AuthorizedName, @Email, @Phone, FALSE) RETURNING \"BusinessId\"";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertBusinessQuery, baglan))
                    {

                        cmd.Parameters.AddWithValue("@BusinessName", txt_businessName.Text);
                        cmd.Parameters.AddWithValue("@AuthorizedName", txt_authName.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_businessEmail.Text);
                        cmd.Parameters.AddWithValue("@Phone", txt_phone.Text);


                        int businessId = Convert.ToInt32(cmd.ExecuteScalar());


                        string insertNotificationQuery = "INSERT INTO \"Notifications\" (\"BusinessId\", \"BusinessName\", \"NotificationDescription\", \"IsRead\") " +
                                                         "VALUES (@BusinessId, @BusinessName, @Description, FALSE)";

                        using (NpgsqlCommand notificationCmd = new NpgsqlCommand(insertNotificationQuery, baglan))
                        {

                            notificationCmd.Parameters.AddWithValue("@BusinessId", businessId);
                            notificationCmd.Parameters.AddWithValue("@BusinessName", txt_businessName.Text);
                            notificationCmd.Parameters.AddWithValue("@Description", "Yeni işletme kaydı talebi alındı.");
                            notificationCmd.ExecuteNonQuery();
                        }
                    }
                    string body = $@"<td bgcolor=""#ffffff"" style=""border-top:4px solid #ffffff;background-color:#ffffff;padding-bottom:60px"">
  <table class=""m_2678050691631740021email-width"" align=""center"" width=""500"" border=""0"" cellpadding=""0"" cellspacing=""0"" role=""presentation"" style=""width:500px"">
    <tbody>
      <tr>
        <td style=""color:#ff3c00;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:12px;line-height:18px;padding-top:50px"">
          <img alt=""Logo"" src=""https://i.hizliresim.com/8wrfqod.png"" width=""300"" height=""auto"" border=""0"" hspace=""0"" vspace=""0"" style=""color:#ff3c00;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:12px;line-height:18px;display:block;vertical-align:top"" class=""CToWUd"" data-bit=""iit"">
        </td>
      </tr>
      <tr>
        <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:65px"">
          Doğrulama kodunuz:<br><br> 
          <strong style=""font-size:28px;line-height:32px"">Deneme</strong><br><br>
          Bu istek sizin tarafınızdan gönderilmemiş olsa bile hesabınız bu doğrulama kodu olmadan oluşturulamaz.<br><br>
        </td>
      </tr>
      <tr>
        <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px"">
          Sorularınız varsa lütfen Destek birimiyle iletişime geçin.
        </td>
      </tr>
    </tbody>
  </table>
</td>
";
                    SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
                    sendMail.SendMail("Pawmate Kayıt Talebi", body, txt_businessEmail.Text);

                    MessageBox.Show("Kayıt talebiniz alınmıştır. Yakın zamanda size mail ile dönüş yapacağız.",
                                    "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    baglan.Close();
                }

            }
        }

    }
}

