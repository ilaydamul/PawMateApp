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
    public partial class TreatmentManagement : Form
    {
        public bool isUpdate = false;
        public TreatmentManagement()
        {
            InitializeComponent();
        }
        private void userList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
      
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = userList.Rows[e.RowIndex];
                    string treatmentName = selectedRow.Cells["TreatmentName"].Value.ToString();
                    string treatmentDescription = selectedRow.Cells["TreatmentDescription"].Value.ToString();
                    txt_treatmenttitle.Text = treatmentName;
                    txt_treatmentdesc.Text = treatmentDescription;
                    isUpdate = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_addUpdateUser_Click(object sender, EventArgs e)
        {
            CheckClass checkClass = new CheckClass(new string[] { txt_treatmenttitle.Text, txt_treatmentdesc.Text });
            if (checkClass.Check(""))
            {
                DatabaseManagament databaseManagament = new DatabaseManagament();
                databaseManagament.OpenConnection();
                databaseManagament.AddTreatmentToDatabase(txt_treatmenttitle.Text, txt_treatmentdesc.Text);
                databaseManagament.CloseConnection();
                MessageBox.Show("Tedavi başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTreatments();

            }
         
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            txt_treatmenttitle.Text = "";
            txt_treatmentdesc.Text = "";
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
    }
}
