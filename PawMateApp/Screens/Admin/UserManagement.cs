using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawMateApp.Screens.Admin
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));

        private void UserManagement_Load(object sender, EventArgs e)
        {

            //İşletmeler cb_businesses içine gelmeli
            try
            {
                baglan.Open();
                string query = "SELECT \"userId\", \"username\", \"password\", \"fullName\", \"phone\", \"email\", \"businessId\", \"isBusinessAdmin\", \"isAppAdmin\" FROM \"users\"";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, baglan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userList.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglan.Close();
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            Inputs inputs = new Inputs(txt_fullname, txt_email, txt_password, txt_phone, txt_username,cb_businesses);
            inputs.ClearInputs();
            btn_addUpdateUser.Text = "Ekle";

        }

        private void btn_addUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (userList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellemek için bir kullanıcı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_fullname.Text) || string.IsNullOrWhiteSpace(txt_username.Text) ||
                    string.IsNullOrWhiteSpace(txt_password.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) ||
                    string.IsNullOrWhiteSpace(txt_email.Text) || cb_businesses.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                    baglan.Open();

                string query = "UPDATE \"users\" SET \"username\" = @username, \"password\" = @password, \"fullName\" = @fullName, " +
                               "\"phone\" = @phone, \"email\" = @email, \"businessId\" = @businessId, \"isBusinessAdmin\" = @isBusinessAdmin " +
                               "WHERE \"userId\" = @userId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@fullName", txt_fullname.Text);
                    cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@businessId", Convert.ToInt32(cb_businesses.SelectedValue)); 
                    cmd.Parameters.AddWithValue("@isBusinessAdmin", isBusinessAdmin.Checked);
                    cmd.Parameters.AddWithValue("@userId", Convert.ToInt32(userList.SelectedRows[0].Cells["UserId"].Value));
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                }

                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserManagement_Load(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }

        }

        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = userList.Rows[e.RowIndex]; //Satıra tıklandığında verileri alıyoruz.

                txt_fullname.Text = row.Cells["fullName"].Value?.ToString();
                txt_username.Text = row.Cells["username"].Value?.ToString();
                txt_password.Text = row.Cells["password"].Value?.ToString();
                txt_phone.Text = row.Cells["phone"].Value?.ToString();
                txt_email.Text = row.Cells["email"].Value?.ToString();
                
                if (row.Cells["businessId"].Value != DBNull.Value && row.Cells["businessId"].Value != null)
                {
                    cb_businesses.SelectedValue = Convert.ToInt32(row.Cells["businessId"].Value);//comboboxa verilerin getirilmesi gerekiyor!!!
                }
                else
                {
                    cb_businesses.SelectedIndex = -1; 
                }

                isBusinessAdmin.Checked = Convert.ToBoolean(row.Cells["isBusinessAdmin"].Value);
                btn_addUpdateUser.Text = "Güncelle"; 
            }

        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            if (userList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir kullanıcı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Seçilen kullanıcıyı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    baglan.Open();

                    string query = "DELETE FROM \"users\" WHERE \"userId\" = @userId"; //kullanıcı silme işlemi yaptırıyoruz.

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                        cmd.Parameters.AddWithValue("@userId", Convert.ToInt32(userList.SelectedRows[0].Cells["userId"].Value)); 
                        cmd.ExecuteNonQuery();
                        baglan.Close();//hata yüzünden burada kapattım. Daha sonra kontrol edilecek.
                    }

                    MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserManagement_Load(null, null); 

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
