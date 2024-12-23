using PawMateApp;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using static PawMateApp.Login;
using Npgsql;
using System.Text.RegularExpressions;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;


namespace PawMateApp
{

    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }


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

       public static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                                        .Select(s => s[random.Next(s.Length)])
                                        .ToArray());
        }


        public static string ReplaceTurkishCharacters(string text)
        {

            var replacements = new (string Turkish, string Normal)[]
            {
            ("Ç", "C"), ("ç", "c"),
            ("Ğ", "G"), ("ğ", "g"),
            ("İ", "I"), ("ı", "i"),
            ("Ö", "O"), ("ö", "o"),
            ("Ş", "S"), ("ş", "s"),
            ("Ü", "U"), ("ü", "u")
            };

            foreach (var (Turkish, Normal) in replacements)
            {
                text = Regex.Replace(text, Regex.Escape(Turkish), Normal);
            }

            return text;
        }

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
                mailMessage.Priority = MailPriority.High;
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

            else if (control is MaskedTextBox maskedTextBox)
            {
                maskedTextBox.Text = ""; 
            }
        }
    }
}

public class DatabaseManagament
{
    public Npgsql.NpgsqlConnection baglan;

    public void OpenConnection()
    {
        if (baglan == null)
        {
            baglan = new Npgsql.NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
        }

        if (baglan.State != System.Data.ConnectionState.Open)
        {
            try
            {
                baglan.Open();
                Debug.WriteLine("Bağlantı açıldı.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Bağlantı hatası: " + ex.Message);
                throw; // Hatanın üst seviyede ele alınması için fırlatılır.
            }
        }
        else
        {
            Debug.WriteLine("Bağlantı zaten açık.");
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
        if (baglan != null && baglan.State == System.Data.ConnectionState.Open)
        {
            try
            {
                baglan.Close();
                Debug.WriteLine("Bağlantı kapatıldı.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Bağlantı kapatma hatası: " + ex.Message);
            }
        }
        else
        {
            Debug.WriteLine("Bağlantı zaten kapalı.");
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

    public void GetTreatmentsForCombo(ComboBox comboBox)
    {

        OpenConnection();
        string getTreatmensQuery = "SELECT * FROM \"treatments\"";
        using (var cmd = new Npgsql.NpgsqlCommand(getTreatmensQuery, baglan))
        {
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    var item = new ComboBoxItem
                    {
                        Id = Convert.ToInt32(dr["treatmentId"]),
                        DisplayName = dr["treatmentName"].ToString()
                    };
                    comboBox.Items.Add(item);
                }
            }
        }
    }

    public void UpdateTreatment(int id, string treatmentName, string treatmentDescription)
    {
        try
        {
            Debug.WriteLine(treatmentName + " " + treatmentDescription);
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
            SELECT username, phone 
            FROM users 
            WHERE username = @username OR phone = @phone";

            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("username", username);
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
    public DataTable GetAllUsers()
    {

        Debug.WriteLine("Business id: " + Globals.CurrentUserBusinessAdminID);
        DataTable dataTable = new DataTable();
        try
        {
            if (baglan == null || baglan.State != ConnectionState.Open)
            {
                OpenConnection();
            }

            string query = "SELECT \"userId\", \"username\", \"email\", \"phone\", \"fullName\", \"isBusinessAdmin\", password FROM \"users\" WHERE \"businessId\" = @businessid ORDER BY \"userId\" ASC";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("@businessid", Globals.CurrentUserBusinessAdminID);
                using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                    Debug.WriteLine(dataTable.Rows.Count);
                }
            }
            Debug.WriteLine("Kullanıcılar başarıyla çekildi.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Kullanıcıları çekme hatası: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
        return dataTable;
    }
    public bool DeleteUser(int userid)
    {
        try
        {
            string query = "DELETE FROM \"users\" WHERE \"userId\" = @userid";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("userid", userid);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("Kullanıcı silindi.");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Kullanıcı silme hatası: " + ex.Message);
            return false;
        }
        finally
        {
            CloseConnection();
        }
    }

    public bool UpdateUserToDatabase(int userId, string username, string password, string email, string phone, string fullname, bool isBusinessAdmin)
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
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = "SELECT username, email, phone FROM users WHERE (username = @username OR email = @email OR phone = @phone)AND \"userId\" != @userId";

            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("userId", userId);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
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
            }

            string updateQuery = "UPDATE users SET username = @username, password = @password, email = @email, phone = @phone, \"fullName\" = @fullname, \"isBusinessAdmin\" = @isBusinessAdmin WHERE \"userId\" = @userId";

            using (var cmd = new Npgsql.NpgsqlCommand(updateQuery, baglan))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("fullname", fullname);
                cmd.Parameters.AddWithValue("isBusinessAdmin", isBusinessAdmin);
                cmd.Parameters.AddWithValue("userId", userId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Kullanıcı güncelleme hatası: " + ex.Message);
            MessageBox.Show("Bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            CloseConnection();
        }
    }

    public bool AddMedicineToDatabase(string medicineTitle, string medicineDesc, string medicineUnit, int medicinePrice, int businessid)
    {
        try
        {
            string query = "INSERT INTO \"medicines\" (\"medicineName\", \"businessId\" , \"description\", \"unit\", \"price\") VALUES (@title, @businessId, @desc, @unit, @price)";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("@title", medicineTitle);
                cmd.Parameters.AddWithValue("@desc", medicineDesc);
                cmd.Parameters.AddWithValue("@unit", medicineUnit);
                cmd.Parameters.AddWithValue("@businessId", businessid);
                cmd.Parameters.AddWithValue("@price", medicinePrice);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("İlaç eklendi.");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("İlaç ekleme hatası: " + ex.Message);
            return false;
        }
        finally
        {
            CloseConnection();
        }
    }

    public DataTable GetAllMedicine(int businessId)
    {
        DataTable dataTable = new DataTable();
        try
        {
            if (baglan == null || baglan.State != ConnectionState.Open)
            {
                OpenConnection();
            }
            string query = "SELECT \"medicineId\", \"medicineName\", \"description\", \"unit\", \"price\" FROM \"medicines\" WHERE \"businessId\" = " + businessId;
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                    Debug.WriteLine(dataTable.Rows.Count + " Adet veri çekildi.");
                }
            }
            Debug.WriteLine("İlaçlar başarıyla çekildi.");
        }
        catch (Exception ex)
        {
            Debug.WriteLine("İlaçları çekme hatası: " + ex.Message);
        }
        finally
        {
            CloseConnection();
        }
        return dataTable;
    }
    public bool DeleteMedicine(int medicineId)
    {
        try
        {
            string query = "DELETE FROM \"medicines\" WHERE \"medicineId\" = @medicineId";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("medicineId", medicineId);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("İlaç silindi.");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("İlaç silme hatası: " + ex.Message);
            return false;
        }
        finally
        {
            CloseConnection();
        }
    }
    public bool UpdateMedicine(int medicineId, string medicineTitle, string medicineDesc, string medicineUnit, int medicinePrice)
    {
        try
        {
            string query = "UPDATE \"medicines\" SET \"medicineName\" = @name, \"description\" = @desc, \"unit\" = @unit, \"price\" = @price WHERE \"medicineId\" = @medicineId";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("name", medicineTitle);
                cmd.Parameters.AddWithValue("desc", medicineDesc);
                cmd.Parameters.AddWithValue("unit", medicineUnit);
                cmd.Parameters.AddWithValue("price", medicinePrice);
                cmd.Parameters.AddWithValue("medicineId", medicineId);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("İlaç güncellendi.");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("İlaç güncelleme hatası: " + ex.Message);
            return false;
        }
        finally
        {
            CloseConnection();
        }
    }

    public void GetCustomers(int businessId, ComboBox comboBox)
    {
        using (var connection = new Npgsql.NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")))
        {
            try
            {
                connection.Open();
                Debug.WriteLine("Bağlantı açıldı.");

                string query = @"SELECT ""customerId"", ""fullName"" FROM ""customers"" WHERE ""businessId"" = @businessid";
                using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@businessid", businessId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (reader.Read())
                        {
                            comboBox.Items.Add(new ComboBoxItem
                            {
                                Id = reader.GetInt32(0), // customerId sütunu integer olduğu için GetInt32 kullanılır.
                                DisplayName = reader.GetString(1) // fullName sütunu string olduğu için GetString kullanılır.
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Hayvanları çekme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Debug.WriteLine("Bağlantı kapatıldı.");
            }
        }
    }


    public void GetMedicines(int businessid, Control combobox)
    {
        if (combobox is ComboBox comboBox)
        {
            try
            {
                string query = "SELECT \"medicineId\", \"medicineName\" FROM \"medicines\" WHERE \"businessId\" = @businessid";
                using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("businessid", businessid);

                    using (var dr = cmd.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (dr.Read())
                        {
                            var item = new ComboBoxItem
                            {
                                Id = Convert.ToInt32(dr["medicineId"]),
                                DisplayName = dr["medicineName"].ToString()
                            };

                            comboBox.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Randevuları çekme hatası: " + ex.Message);
            }
        }
        else
        {
            Debug.WriteLine("Verilen kontrol bir ComboBox değil.");
        }
    }



    public void AddMedicineStocksToDatabase(int businessid, int medicineid, string medicinename, int medicinequantity, int redflag)
    {
        try
        {
            string checkQuery = "SELECT COUNT(*) FROM \"medicineStocks\" WHERE \"medicineId\" = @medicineid";
            using (var cmd2 = new Npgsql.NpgsqlCommand(checkQuery, baglan))
            {
                cmd2.Parameters.AddWithValue("medicineid", medicineid);

                int count = Convert.ToInt32(cmd2.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Bu ilaç zaten stoklarda mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "INSERT INTO \"medicineStocks\" (\"medicineId\", quantity , threshold, medicinename, businessid) VALUES (@medicineid, @quantity, @redflag, @medicinename, @businessid)";
                    using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
                    {
                        cmd.Parameters.AddWithValue("medicineid", medicineid);
                        cmd.Parameters.AddWithValue("quantity", medicinequantity);
                        cmd.Parameters.AddWithValue("redflag", redflag);
                        cmd.Parameters.AddWithValue("medicinename", medicinename);
                        cmd.Parameters.AddWithValue("businessid", businessid);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Stok başarılı bir şekilde eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Stok eklenirken hata oluştu: " + ex.Message);
        }
        //Debug.WriteLine("Business Id: " + businessid + " Name: " + medicinename + " quantity: " + medicinequantity + " redflag: "+ redflag);
    }

    public void DeleteMedicineStock(int stockid)
    {
        try
        {
            // Veritabanı bağlantısını kontrol et
            if (baglan.State != ConnectionState.Open)
            {
                baglan.Open();
            }

            // Silme işlemi öncesinde kontrol
            string checkQuery = "SELECT COUNT(*) FROM \"medicineStocks\" WHERE \"stockId\" = @id";
            using (var checkCmd = new Npgsql.NpgsqlCommand(checkQuery, baglan))
            {
                checkCmd.Parameters.AddWithValue("id", stockid);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count == 0)
                {
                    Debug.WriteLine("Belirtilen Stockıd için kayıt bulunamadı.");
                    return; // İşlemden çık
                }
            }

            // Silme sorgusu
            string query = "DELETE FROM \"medicineStocks\" WHERE \"stockId\" = @id";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("id", stockid);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Debug.WriteLine("Stok başarıyla silindi.");
                }
                else
                {
                    Debug.WriteLine("Stok silinemedi.");
                }
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Stok silme hatası: " + ex.Message);
        }
        finally
        {
            // Bağlantıyı kapat
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }


    }

    public void GetPets(int customerid, Control combobox)
    {
        if (combobox is ComboBox comboBox)
        {
            try
            {
                string query = "SELECT * FROM \"pets\" WHERE \"customerId\" = @customerid";
                using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("customerid", customerid);
                    using (var dr = cmd.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (dr.Read())
                        {
                            var item = new ComboBoxItem
                            {
                                Id = Convert.ToInt32(dr["petId"]),
                                DisplayName = dr["petName"].ToString()
                            };
                            comboBox.Items.Add(item);
                            Debug.WriteLine("Müşteriler: " + item.DisplayName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Hayvanları çekme hatası: " + ex.Message);
            }
        }
        else
        {
            Debug.WriteLine("Verilen kontrol bir ComboBox değil.");
        }
    }

    public void GetVets(int businessId, ComboBox comboBox)
    {
        using (var connection = new Npgsql.NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")))
        {
            try
            {
                connection.Open();
                Debug.WriteLine("Bağlantı açıldı.");

                string query = @"SELECT ""userId"", ""username"" FROM ""users"" WHERE ""businessId"" = @businessid";
                using (var cmd = new Npgsql.NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@businessid", businessId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (reader.Read())
                        {
                            comboBox.Items.Add(new ComboBoxItem
                            {
                                Id = reader.GetInt32(0), // vetId sütunu integer olduğu için GetInt32 kullanılır.
                                DisplayName = reader.GetString(1) // vetName sütunu string olduğu için GetString kullanılır.
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Veterinerleri çekme hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
                Debug.WriteLine("Bağlantı kapatıldı.");
            }
        }
    }


    public bool AddMeeting(int petid, DateTime visitdate, string visitreason, int vetid, int customerid)
    {
        try
        {
            string query = "INSERT INTO \"visits\" (\"petId\", \"visitDate\", \"visitReason\", \"vetId\", \"businessid\" , \"customerid\") VALUES (@petid, @visitdate, @visitreason, @vetid, @businessid,@customerid)";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("petid", petid);
                cmd.Parameters.AddWithValue("visitdate", visitdate);
                cmd.Parameters.AddWithValue("visitreason", visitreason);
                cmd.Parameters.AddWithValue("vetid", vetid);
                cmd.Parameters.AddWithValue("businessid", Globals.CurrentUserBusinessAdminID);
                cmd.Parameters.AddWithValue("customerid", customerid);
                Debug.WriteLine(vetid);
                cmd.ExecuteNonQuery();

            }
            Debug.WriteLine("Randevu eklendi.");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Randevu ekleme hatası: " + ex.Message);
        }
        return false;
    }

    public bool DeleteVisits(int visitid)
    {
        try
        {
            string query = "DELETE FROM \"visits\" WHERE \"visitId\" = @visitid";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("visitid", visitid);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("Randevu silindi.");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Randevu silme hatası: " + ex.Message);
            return false;
        }
    }
    public bool AddHealthRecords(int customer_id, int pet_id, string ill_name, DateTime diagnosis_date, int medicine_id, string diagnosis_time, string diagnosis_note)
    {
        try
        {
            string query = "INSERT INTO \"healthRecords\" (customerid, \"visitid\", \"diagnosis\", \"diagnosis_date\", \"treatmentId\", \"ill_duration\", \"notes\") VALUES (@customer_id, @pet_id, @ill_name, @diagnosis_date, @medicine_id, @diagnosis_time, @diagnosis_note)";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("customer_id", customer_id);
                cmd.Parameters.AddWithValue("pet_id", pet_id);
                cmd.Parameters.AddWithValue("ill_name", ill_name);
                cmd.Parameters.AddWithValue("diagnosis_date", diagnosis_date);
                cmd.Parameters.AddWithValue("medicine_id", medicine_id);
                cmd.Parameters.AddWithValue("diagnosis_time", diagnosis_time);
                cmd.Parameters.AddWithValue("diagnosis_note", diagnosis_note);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("Sağlık kaydı eklendi");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Sağlık kaydı ekleme hatası: " + ex.Message);
        }
        finally
        {
            Debug.WriteLine("Sağlık kaydı metodu başarıyla çalıştırıldı!");
        }
        return false;
    }

    public void GetVisits(int customerId, Control combobox)
    {
        if (combobox is ComboBox comboBox)
        {
            try
            {
                string query = @"
SELECT v.""visitId"", p.""petName"" , v.""visitDate""
FROM ""visits"" v
JOIN ""pets"" p ON v.""petId"" = p.""petId""
WHERE v.""customerid"" = @customerId";
                using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    using (var dr = cmd.ExecuteReader())
                    {
                        comboBox.Items.Clear();
                        while (dr.Read())
                        {
                            var item = new ComboBoxItem
                            {
                                Id = Convert.ToInt32(dr["visitId"]),
                                DisplayName = dr["petName"].ToString() + " " + dr["visitDate"].ToString()
                            };

                            comboBox.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Randevuları çekme hatası: " + ex.Message);
            }
        }
        else
        {
            Debug.WriteLine("Verilen kontrol bir ComboBox değil.");
        }
    }

    public bool DeletePatient(int patientid)
    {
        try
        {
            string query = "DELETE FROM \"healthRecords\" WHERE \"recordId\" = @patientid";
            using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
            {
                cmd.Parameters.AddWithValue("patientid", patientid);
                cmd.ExecuteNonQuery();
            }
            Debug.WriteLine("Kayıt silindi.");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Kayıt silme hatası: " + ex.Message);
            return false;
        }
    }

    public bool InsertUserManagementAdmin(string username, string password, string fullname, string phone, string email, int businessid, bool isbusinessadmin)
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
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {

                string query = "SELECT username, email, phone FROM users WHERE (username = @username OR email = @email OR phone = @phone)";

                using (var cmd = new Npgsql.NpgsqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("phone", phone);
                    cmd.Parameters.AddWithValue("email", email);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
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
                }

                string query2 = "INSERT INTO \"users\" (\"username\", \"password\", \"fullName\", \"phone\", \"email\", \"businessId\", \"isBusinessAdmin\") " +
                "VALUES (@username, @password, @fullName, @phone, @email, @businessId, @isBusinessAdmin)";

                using (var cmd = new Npgsql.NpgsqlCommand(query2, baglan))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@businessId", businessid);
                    cmd.Parameters.AddWithValue("@isBusinessAdmin", isbusinessadmin);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kullanıcı başarılı bir şekilde eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
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