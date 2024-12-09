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
            DataTable usersTable = db.GetAllUsers();
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
