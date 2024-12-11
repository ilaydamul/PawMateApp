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

            if (!CheckClass.IsValidEmail(txt_businessEmail.Text))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckClass.IsValidPhone(txt_phone.Text))
                {
                    try
                    {

                        baglan.Open();
                        string insertBusinessQuery = "INSERT INTO \"businesses\" (\"businessName\", \"authorizedName\", \"email\", \"phone\", \"isApproved\") " +
                                                     "VALUES (@businessName, @authorizedName, @email, @phone, FALSE) RETURNING \"businessId\"";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(insertBusinessQuery, baglan))
                        {

                            cmd.Parameters.AddWithValue("@businessName", txt_businessName.Text);
                            cmd.Parameters.AddWithValue("@authorizedName", txt_authName.Text);
                            cmd.Parameters.AddWithValue("@email", txt_businessEmail.Text);
                            cmd.Parameters.AddWithValue("@phone", txt_phone.Text);


                            int businessId = Convert.ToInt32(cmd.ExecuteScalar());


                            string insertNotificationQuery = "INSERT INTO \"notifications\" (\"businessId\", \"businessName\", \"notificationDescription\", \"isRead\", \"email\") " +
                                                             "VALUES (@businessId, @businessName, @description, FALSE, @email)";

                            using (NpgsqlCommand notificationCmd = new NpgsqlCommand(insertNotificationQuery, baglan))
                            {

                                notificationCmd.Parameters.AddWithValue("@businessId", businessId);
                                notificationCmd.Parameters.AddWithValue("@businessName", txt_businessName.Text);
                                notificationCmd.Parameters.AddWithValue("@email", txt_businessEmail.Text);
                                notificationCmd.Parameters.AddWithValue("@description", "Yeni işletme kaydı talebi alındı.");
                                notificationCmd.ExecuteNonQuery();
                            }
                        }
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
        <strong style=""font-size:32px;line-height:38px;color:#ff6b00;"">Tebrikler! Veteriner Kliniğiniz Başarıyla Oluşturuldu 🎉</strong><br><br>
        Harika bir haber! Veteriner kliniğiniz başarıyla sistemimize kaydedildi. Artık onay sürecini başlatabiliriz! 🐾<br><br>
        <strong style=""font-size:20px;color:#ff3c00;"">Hesabınız onaylandığında bilgilendirme maili alacaksınız.</strong><br><br>
        Veteriner kliniğinizin onayı tamamlandığında, giriş yapabilmeniz için size bir bilgilendirme maili gönderilecektir. Sabırlı olduğunuz için teşekkür ederiz! 🌟<br><br>
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
        <strong style=""font-size:20px;color:#2d2d2d;"">Veteriner kliniğinizi yönetin ve başarılı bir başlangıç yapın! 🚀</strong><br><br>
        Sabırsızlanıyoruz, birlikte büyük işler başaracağız!<br><br>
        <em style=""font-size:16px;color:#888888;"">Pawmate Destek Ekibi</em>
      </td>
    </tr>
  </tbody>
</table>
";
                        SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
                        sendMail.SendMail("Pawmate Kayıt Bilgilendirme", body, txt_businessEmail.Text);

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
}

