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
    public class SendMailClass
    {
        private string mailadress;
        private string fromadress;
        private string frompassword;
        private string smtp;
        private int port;
        private SmtpClient smtpClient;

        public SendMailClass(string fromadress, string frompassword, string smtp, int port)
        {
            this.fromadress = fromadress;
            this.frompassword = frompassword;
            this.smtp = smtp;
            this.port = port;
            this.smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(this.fromadress, this.frompassword),
                EnableSsl = true
            };
        }

        public void SendMail(string subject , string body , string mailadress)
        {
            try
            {
                string toAddress = mailadress;
                Debug.WriteLine("mailadress: " + mailadress);
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(this.fromadress, "PawMate"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(toAddress);
                smtpClient.Send(mailMessage);
                Debug.WriteLine("Mail gönderildi.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Mail gönderme hatası: " + ex.Message);

            }
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

public class DatabaseManagament
{
    private Npgsql.NpgsqlConnection baglan;

    public void OpenConnection()
    {
        this.baglan = new Npgsql.NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
        try
        {
            this.baglan.Open();
            Debug.WriteLine("Bağlantı açıldı.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Bağlantı hatası: " + ex.Message);
        }
    }

    public void AddTreatmentToDatabase(string treatmentName, string treatmentDescription)
    {
        try
        {
            string query = "INSERT INTO \"Treatments\" (\"TreatmentName\", \"TreatmentDescription\") VALUES ('" + treatmentName + "', '" + treatmentDescription + "')";
            Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            Debug.WriteLine("Tedavi eklendi.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Tedavi ekleme hatası: " + ex.Message);
        }
    }

    public void CloseConnection()
    {
        try
        {
            this.baglan.Close();
            Debug.WriteLine("Bağlantı kapatıldı.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Bağlantı kapatma hatası: " + ex.Message);
        }
    }
}

