using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace PawMateApp
{
    public class MoveForm
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private Form form;

        public MoveForm(Form form)
        {
            this.form = form;
        }

        public void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = form.Location;
        }

        public void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = new Point(Cursor.Position.X - dragCursorPoint.X, Cursor.Position.Y - dragCursorPoint.Y);
                form.Location = new Point(dragFormPoint.X + diff.X, dragFormPoint.Y + diff.Y);
            }
        }

        public void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
    public class CheckClass
    {
        private string[] strings;
        /// <param name="Inputs">txt_degiskenismi.Text olarak değerleri array şeklinde girin.</param
        public CheckClass(string[] Inputs)
        {

            this.strings = Inputs;
        }
        /// 
        /// <returns>Boş alan olursa messagebox ile false döner, boş alan yok ise true ile messagebox döner</returns>
        public bool Check(string MessageBoxTextForSuccess)
        {
            foreach (string input in strings)
            {
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (MessageBoxTextForSuccess == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(MessageBoxTextForSuccess, "Başarılı", MessageBoxButtons.OK);
                return true;
            }
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true; 
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
    public class SendMail
    {
        private string name;
        private string mailadress;
        private string fromadress;
        private string frompassword;
        private string smtp;
        private int port;

        public SendMail(string name, string mailadress, string fromadress, string frompassword, string smtp, int port)
        {
            this.name = name;
            this.mailadress = mailadress;
            this.fromadress = fromadress;
            this.frompassword = frompassword;
            this.smtp = smtp;
            this.port = port;
        }
        

        public int SendMailForOTP()
        {
            try
            {
                string user_otp = GenerateOtpCode();
                string fromAddress = "pawmateinfo@gmail.com";
                string fromPassword = "shiw ndqo tvfw dzte";
                string toAddress = mailadress;
                string subject = "Merhaba " + name + " ! Doğrulama Kodun:" + user_otp;
                Debug.WriteLine("mailadress: "+mailadress +" name: "+ name);
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
          <strong style=""font-size:28px;line-height:32px"">{user_otp}</strong><br><br>
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
"
;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(fromAddress, fromPassword),
                    EnableSsl = true
                };
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(fromAddress, "PawMate"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(toAddress);
                smtpClient.Send(mailMessage);
                Debug.WriteLine("E-posta başarıyla gönderildi!");
                Debug.WriteLine("Gönderilen OTP kodu: " + user_otp);
                return Convert.ToInt32(user_otp);
            }catch(SmtpException smtpexception)
            {
                MessageBox.Show("E-posta gönderilirken hata oluştu! Lütfen daha sonra tekrar deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("E-posta gönderilirken hata oluştu: " + smtpexception.Message);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilirken hata oluştu! Lütfen daha sonra tekrar deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("E-posta gönderilirken hata oluştu: " + ex.Message);
                return 0;
            }
            
        }
        public string GenerateOtpCode()
        {
            Random random = new Random();
            return random.Next(100000, 1000000).ToString();
        }
    }
}

public class Inputs
{
    private Control[] controls;

    public Inputs(params Control[] controls)
    {
        this.controls = controls;
    }

    public void ClearInputs()
    {
        foreach (var control in controls)
        {
            if (control is TextBox textBox)
            {
                textBox.Text = ""; 
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.SelectedIndex = -1; 
                comboBox.Text = "";        
            }
        }
    }
}

