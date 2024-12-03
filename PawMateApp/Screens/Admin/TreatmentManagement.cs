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

namespace PawMateApp.Screens.Admin
{
    public partial class TreatmentManagement : Form
    {
        private bool _isUpdate = false;
        private string treatmentName;
        string treatmentDescription;
        int treatmentId;

        public bool IsUpdate
        {
            get { return _isUpdate; }
            set
            {
                if (_isUpdate != value)
                {
                    _isUpdate = value;
                    UpdateButtonText();
                }
            }
        }
        public TreatmentManagement()
        {
            InitializeComponent();
        }

        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = userList.Rows[e.RowIndex];
                    treatmentName = selectedRow.Cells["TreatmentName"].Value.ToString();
                    treatmentDescription = selectedRow.Cells["TreatmentDescription"].Value.ToString();
                    treatmentId = selectedRow.Cells["TreatmentId"].Value.GetHashCode();
                    Debug.WriteLine(treatmentId);
                    txt_treatmenttitle.Text = treatmentName;
                    txt_treatmentdesc.Text = treatmentDescription;
                    IsUpdate = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_addUpdateUser_Click(object sender, EventArgs e)
        {
            if(btn_addUpdateUser.Text == "Güncelle")
            {
                CheckClass checkclassone = new CheckClass(new string[] { txt_treatmenttitle.Text, txt_treatmentdesc.Text });
                if (checkclassone.Check(""))
                {
                    DatabaseManagament databaseManagament = new DatabaseManagament();
                    databaseManagament.OpenConnection();
                    databaseManagament.UpdateTreatment(treatmentId, txt_treatmenttitle.Text, txt_treatmentdesc.Text);
                    databaseManagament.CloseConnection();
                    MessageBox.Show("Tedavi başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_treatmenttitle.Text = "";
                    txt_treatmentdesc.Text = "";
                    btn_addUpdateUser.Text = "Ekle";
                    LoadTreatments();
                }
            }
            else
            {
                CheckClass checkClasstwo = new CheckClass(new string[] { txt_treatmenttitle.Text, txt_treatmentdesc.Text });
                if (checkClasstwo.Check(""))
                {
                    DatabaseManagament databaseManagament = new DatabaseManagament();
                    databaseManagament.OpenConnection();
                    databaseManagament.AddTreatmentToDatabase(txt_treatmenttitle.Text, txt_treatmentdesc.Text);
                    databaseManagament.CloseConnection();
                    MessageBox.Show("Tedavi başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_treatmenttitle.Text = "";
                    txt_treatmentdesc.Text = "";
                    LoadTreatments();
                }
            }
         
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            txt_treatmenttitle.Text = "";
            txt_treatmentdesc.Text = "";
            IsUpdate = false;
        }

        private void ConfigureDataGridView()
        {
            userList.Columns.Clear(); 
            userList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userList.MultiSelect = false;
            userList.AllowUserToAddRows = false;
            userList.ReadOnly = true;
        }

        private void LoadTreatments()
        {
            try
            {
                userList.Columns.Clear();
                DatabaseManagament databaseManagament = new DatabaseManagament();
                databaseManagament.OpenConnection();
                DataTable treatments = databaseManagament.GetTreatments();
                userList.DataSource = treatments;
                userList.Columns["TreatmentId"].HeaderText = "Tedavi ID";
                userList.Columns["TreatmentName"].HeaderText = "Tedavi Adı";
                userList.Columns["TreatmentDescription"].HeaderText = "Tedavi Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TreatmentManagement_Load_1(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadTreatments();
        }
        private void UpdateButtonText()
        {
            if (IsUpdate)
            {

                btn_addUpdateUser.Text = "Güncelle";
            }
            else
            {
                btn_addUpdateUser.Text = "Ekle";
            }
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            if(userList.SelectedRows.Count == 0 || treatmentId == 0)
            {
                MessageBox.Show("Lütfen silmek için bir tedavi seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                DialogResult result = MessageBox.Show(
                "Seçilen tedavi silinecek. Silmek istediğinizden emin misiniz?",
                "Emin misiniz?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ); 


                if(result == DialogResult.Yes)
                {
                    DatabaseManagament databaseManagament = new DatabaseManagament();
                    databaseManagament.OpenConnection();
                    databaseManagament.DeleteTreatment(treatmentId);
                    databaseManagament.CloseConnection();
                    MessageBox.Show("Tedavi başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTreatments();
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

  
    }
}
