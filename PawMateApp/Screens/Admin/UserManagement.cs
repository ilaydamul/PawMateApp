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
                string query = "SELECT \"UserId\", \"Username\", \"Password\", \"FullName\", \"Phone\", \"Email\", \"BusinessId\", \"IsBusinessAdmin\", \"IsAppAdmin\" FROM \"Users\"";
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

                string query = "UPDATE \"Users\" SET \"Username\" = @Username, \"Password\" = @Password, \"FullName\" = @FullName, " +
                               "\"Phone\" = @Phone, \"Email\" = @Email, \"BusinessId\" = @BusinessId, \"IsBusinessAdmin\" = @IsBusinessAdmin " +
                               "WHERE \"UserId\" = @UserId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                {
                    cmd.Parameters.AddWithValue("@Username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@FullName", txt_fullname.Text);
                    cmd.Parameters.AddWithValue("@Phone", txt_phone.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@BusinessId", Convert.ToInt32(cb_businesses.SelectedValue)); 
                    cmd.Parameters.AddWithValue("@IsBusinessAdmin", isBusinessAdmin.Checked);
                    cmd.Parameters.AddWithValue("@UserId", Convert.ToInt32(userList.SelectedRows[0].Cells["UserId"].Value));
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

                txt_fullname.Text = row.Cells["FullName"].Value?.ToString();
                txt_username.Text = row.Cells["Username"].Value?.ToString();
                txt_password.Text = row.Cells["Password"].Value?.ToString();
                txt_phone.Text = row.Cells["Phone"].Value?.ToString();
                txt_email.Text = row.Cells["Email"].Value?.ToString();
                
                if (row.Cells["BusinessId"].Value != DBNull.Value && row.Cells["BusinessId"].Value != null)
                {
                    cb_businesses.SelectedValue = Convert.ToInt32(row.Cells["BusinessId"].Value);//comboboxa verilerin getirilmesi gerekiyor!!!
                }
                else
                {
                    cb_businesses.SelectedIndex = -1; 
                }

                isBusinessAdmin.Checked = Convert.ToBoolean(row.Cells["IsBusinessAdmin"].Value);
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

                    string query = "DELETE FROM \"Users\" WHERE \"UserId\" = @UserId"; //kullanıcı silme işlemi yaptırıyoruz.

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, baglan))
                    {
                        cmd.Parameters.AddWithValue("@UserId", Convert.ToInt32(userList.SelectedRows[0].Cells["UserId"].Value)); 
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
