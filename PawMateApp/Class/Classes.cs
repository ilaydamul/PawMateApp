using PawMateApp;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using static PawMateApp.Login;

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
            form.Icon = Properties.Resources.favicon;
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
                if (string.IsNullOrEmpty(input.Trim()))
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
        public static bool IsValidPhone(string phone)
        {
            if (long.TryParse(phone, out long result))
            {
                phone = phone.ToString();
                if (phone.Substring(0, 1) == "0")
                {
                    MessageBox.Show("Lütfen telefon numarasının başına 0 koymayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (phone.Length == 10)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (control is CheckBox checkBox)
            {
                checkBox.Checked = false;
            }
            else if (control is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Value = DateTime.Now;
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
            string query = "INSERT INTO \"treatments\" (\"treatmentName\", \"treatmentDescription\") VALUES (@name, @description)";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("name", treatmentName);
                cmd.Parameters.AddWithValue("description", treatmentDescription);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("Tedavi eklendi.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Tedavi ekleme hatası: " + ex.Message);
        }
    }

    public void CloseConnection()
    {
        if (baglan != null && baglan.State == ConnectionState.Open)
        {
            baglan.Close();
            Debug.WriteLine("Bağlantı kapatıldı.");
        }
    }

    public DataTable GetTreatments()
    {
        DataTable dataTable = new DataTable();
        try
        {
            if (baglan == null || baglan.State != ConnectionState.Open)
            {
                OpenConnection();
            }

            string query = "SELECT \"treatmentId\", \"treatmentName\", \"treatmentDescription\" FROM \"treatments\"";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
                {
                    Debug.WriteLine("Tedaviler çekildi.");
                    adapter.Fill(dataTable);
                    CloseConnection();
                }
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Veri çekme hatası: " + ex.Message);
        }
        return dataTable;
    }
    public void UpdateTreatment(int id, string treatmentName, string treatmentDescription)
    {
        try
        {
            Debug.WriteLine(treatmentName +" "+ treatmentDescription);
            string query = "UPDATE \"treatments\" SET \"treatmentName\" = @name, \"treatmentDescription\" = @description WHERE \"treatmentId\" = @id";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("name", treatmentName);
                cmd.Parameters.AddWithValue("description", treatmentDescription);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("Tedavi güncellendi.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Tedavi güncelleme hatası: " + ex.Message);
        }
    }

    public void DeleteTreatment(int id)
    {
        try
        {
            string query = "DELETE FROM \"treatments\" WHERE \"treatmentId\" = @id";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("Tedavi silindi.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Tedavi silme hatası: " + ex.Message);
        }
    }

    public bool AddUserToDatabase(string username, string password, string email, string phone, string fullname, bool isBusinessAdmin)
    {
        try
        {
            if (!CheckClass.IsValidEmail(email))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!CheckClass.IsValidPhone(phone))
            {
                return false;
            }

            string query = @"
            SELECT username, email, phone 
            FROM users 
            WHERE username = @username OR email = @email OR phone = @phone";

            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("phone", phone);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (dr["username"].ToString() == username)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kullanılmakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (dr["email"].ToString() == email)
                        {
                            MessageBox.Show("Bu e-posta adresi zaten kullanılmakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; 
                        }

                        if (dr["phone"].ToString() == phone)
                        {
                            MessageBox.Show("Bu telefon numarası zaten kullanılmakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }

            string insertQuery = "INSERT INTO users (username, password, email, phone, \"fullName\", \"isBusinessAdmin\", \"businessId\") VALUES (@username, @password, @email, @phone, @fullname, @isBusinessAdmin , @businessid)";
            int id = Globals.CurrentUserBusinessAdminID;
            using (var cmd = new Npgsql.NpgsqlCommand(insertQuery, baglan))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("fullname", fullname);
                cmd.Parameters.AddWithValue("isBusinessAdmin", isBusinessAdmin);
                cmd.Parameters.AddWithValue("businessid", id);
                cmd.Parameters.AddWithValue("isAppAdmin", false);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Kullanıcı ekleme hatası: " + ex.Message);
            MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            CloseConnection();
        }
    }
}

