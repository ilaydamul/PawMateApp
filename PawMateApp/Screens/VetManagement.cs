using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PawMateApp.Login;

namespace PawMateApp.Screens
{
    public partial class VetManagement : Form
    {
        public DatabaseManagament db = new DatabaseManagament();
        public VetManagement()
        {
            InitializeComponent();
            LoadUsersToDataGridView();
            CustomizeDataGridView();
        }

        private void LoadUsersToDataGridView()
        {
            DataTable usersTable = db.GetAllUsers(Globals.CurrentUserBusinessAdminID);
            vetList.DataSource = usersTable;
        }
        private void CustomizeDataGridView()
        {
                vetList.ReadOnly = true;
                vetList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                vetList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                vetList.AllowUserToAddRows = false;
                vetList.Columns["userId"].HeaderText = "ID";
                vetList.Columns["username"].HeaderText = "Kullanıcı Adı";
                vetList.Columns["email"].HeaderText = "E-posta";
                vetList.Columns["phone"].HeaderText = "Telefon";
                vetList.Columns["fullName"].HeaderText = "Ad Soyad";
                vetList.Columns["isBusinessAdmin"].HeaderText = "Yönetici mi?";
                vetList.Columns["password"].HeaderText= "Şifre";
        }
                

        private void btn_addUpdateVet_Click(object sender, EventArgs e)
        {
            if (btn_addUpdateVet.Text == "Ekle")
            {
                db.OpenConnection();
                Debug.WriteLine(isBusinessAdmin.Checked);
                CheckClass checkinputs = new CheckClass(new string[] { txt_email.Text, txt_fullname.Text, txt_password.Text, txt_phone.Text, txt_title.Text, txt_username.Text });
                if (!checkinputs.Check(""))
                {
                    return;
                }
                else
                {


                    if (db.AddUserToDatabase(txt_username.Text, txt_password.Text, txt_email.Text, txt_phone.Text, txt_fullname.Text, isBusinessAdmin.Checked))
                    {
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
        <strong style=""font-size:32px;line-height:38px;color:#ff6b00;"">Tebrikler! Kullanıcı Hesabınız Başarıyla Oluşturuldu 🎉</strong><br><br>
        Veteriner kliniğiniz tarafından sisteme yeni bir kullanıcı olarak kaydedildiniz. Artık kliniğinizin yönetim süreçlerine kolayca erişebilirsiniz! 🐾<br><br>
        <strong style=""font-size:20px;color:#ff3c00;"">Aşağıda giriş bilgileriniz bulunmaktadır:</strong><br><br>
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding:20px;text-align:center;border:1px solid #ddd;background-color:#f9f9f9;"">
        <strong>Kullanıcı Adı:</strong> {txt_username.Text.Trim()}<br>
        <strong>Şifre:</strong> {txt_password.Text.Trim()}<br><br>
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
        <strong style=""font-size:20px;color:#2d2d2d;"">Hemen giriş yaparak sistemi keşfetmeye başlayın! 🚀</strong><br><br>
        Sistemimize giriş yaptıktan sonra, tüm araçlara erişebilir ve işlerinizi kolayca organize edebilirsiniz.<br><br>
        <em style=""font-size:16px;color:#888888;"">Pawmate Destek Ekibi</em>
      </td>
    </tr>
  </tbody>
</table>
";
                        SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
                        sendMail.SendMail("Pawmate Kayıt Bilgilendirmesi", body, txt_email.Text);
                        Inputs inputs = new Inputs(new Control[] { txt_email, txt_fullname, txt_password, txt_phone, txt_username, isBusinessAdmin });
                        inputs.ClearInputs();
                        LoadUsersToDataGridView();
                        MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                    db.CloseConnection();
                }
            }
            else
            {
               
                db.OpenConnection();
                Debug.WriteLine(isBusinessAdmin.Checked);
                CheckClass checkinputs = new CheckClass(new string[] { txt_email.Text, txt_fullname.Text, txt_password.Text, txt_phone.Text, txt_title.Text, txt_username.Text });
                if (!checkinputs.Check(""))
                {
                    return;
                }
                else
                {


                    if (db.UpdateUserToDatabase(Convert.ToInt32(vetList.CurrentRow.Cells["userId"].Value), txt_username.Text, txt_password.Text, txt_email.Text, txt_phone.Text, txt_fullname.Text, isBusinessAdmin.Checked))
                    {
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
        <strong style=""font-size:32px;line-height:38px;color:#ff6b00;"">Bilgileriniz Başarıyla Güncellendi 🎉</strong><br><br>
        Harika bir haber! Hesap bilgileriniz başarıyla güncellendi. Artık sistemimize yeni bilgilerinizle erişebilirsiniz. 🌟<br><br>
        <strong style=""font-size:20px;color:#ff3c00;"">Aşağıda güncellenen bilgileriniz yer almaktadır:</strong><br><br>
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding:20px;text-align:center;border:1px solid #ddd;background-color:#f9f9f9;"">
        <strong>Kullanıcı Adı:</strong> {txt_username.Text.Trim()}<br>
        <strong>Şifre:</strong> {txt_password.Text.Trim()}<br><br>
      </td>
    </tr>
    <tr>
      <td style=""color:#505050;font-family:adobe-clean,Helvetica Neue,Helvetica,Verdana,Arial,sans-serif;font-size:18px;line-height:26px;padding-top:40px;text-align:center;"">
        <strong style=""font-size:20px;color:#2d2d2d;"">Güncellenen bilgilerinizle sistemimizi keşfetmeye devam edin! 🚀</strong><br><br>
        Sistemimizdeki araçlar ve hizmetler her zaman elinizin altında! Sorularınız için bizimle iletişime geçebilirsiniz.<br><br>
        <em style=""font-size:16px;color:#888888;"">Pawmate Destek Ekibi</em>
      </td>
    </tr>
  </tbody>
</table>
";
                        SendMailClass sendMail = new SendMailClass("pawmateinfo@gmail.com", "shiw ndqo tvfw dzte", "smtp.gmail.com", 587);
                        sendMail.SendMail("Pawmate Kayıt Bilgilendirmesi", body, txt_email.Text);
                        Inputs inputs = new Inputs(new Control[] { txt_email, txt_fullname, txt_password, txt_phone, txt_username, isBusinessAdmin });
                        inputs.ClearInputs();
                        LoadUsersToDataGridView();

                    }
                    else
                    {
                        return;
                    }
                    db.CloseConnection();
                }

            }
        }

        private void vetList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addUpdateVet.Text = "Güncelle";
            txt_email.Text = vetList.CurrentRow.Cells["email"].Value.ToString();
            txt_fullname.Text = vetList.CurrentRow.Cells["fullName"].Value.ToString();
            txt_password.Text = vetList.CurrentRow.Cells["password"].Value.ToString();
            txt_phone.Text = vetList.CurrentRow.Cells["phone"].Value.ToString();
            txt_fullname.Text = vetList.CurrentRow.Cells["fullName"].Value.ToString();
            txt_username.Text = vetList.CurrentRow.Cells["username"].Value.ToString();
            isBusinessAdmin.Checked = Convert.ToBoolean(vetList.CurrentRow.Cells["isBusinessAdmin"].Value);


        }

        private void btn_addVet_Click(object sender, EventArgs e)
        {
            Inputs inputs = new Inputs(new Control[] { txt_email, txt_fullname, txt_password, txt_phone, txt_username, isBusinessAdmin });
            inputs.ClearInputs();
            btn_addUpdateVet.Text = "Ekle";
        }

        private void btn_deleteVet_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            DialogResult result = MessageBox.Show(
                "Seçilen veteriner silinecek. Silmek istediğinizden emin misiniz?",
                "Emin misiniz?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.Yes)
            {
                int user_id = Convert.ToInt32(vetList.CurrentRow.Cells["userId"].Value);
                
                
                if (db.DeleteUser(user_id))
                {
                    LoadUsersToDataGridView();
                    MessageBox.Show("Veteriner başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inputs inputs = new Inputs(new Control[] {txt_email, txt_fullname, txt_password, txt_phone,txt_username, isBusinessAdmin});
                    inputs.ClearInputs();
                    btn_addUpdateVet.Text = "Ekle";
                }
                else
                {
                    MessageBox.Show("Veteriner silinirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
            db.CloseConnection();
        }
    }
}
