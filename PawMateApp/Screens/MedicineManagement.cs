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
    public partial class MedicineManagement : Form
    {
        public Inputs inputs;
         DatabaseManagament db = new DatabaseManagament();
        public MedicineManagement()
        {
            InitializeComponent();
            LoadMedicines();
            ConfigureDataTable();
            inputs = new Inputs(new Control[] { txt_medicineDesc, txt_medicinePrice, txt_medicineTitle});
        }

        private void btn_addMedicine_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            CheckClass check = new CheckClass(new string[] { txt_medicineDesc.Text, txt_medicinePrice.Text, txt_medicineTitle.Text});
            if (!check.Check(""))
            {
                return;
            }
            else
            {
                if (btn_addMedicine.Text == "Ekle")
                {

                    if (db.AddMedicineToDatabase(txt_medicineTitle.Text, txt_medicineDesc.Text ,Convert.ToInt32(txt_medicinePrice.Text), Globals.CurrentUserBusinessAdminID))
                    {
                        MessageBox.Show("İlaç eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        inputs.ClearInputs();
                        LoadMedicines();
                    }
                    else
                    {
                        MessageBox.Show("İlaç eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int medicineId = int.Parse(medicineList.SelectedRows[0].Cells["medicineId"].Value.ToString());
                    if (db.UpdateMedicine(medicineId, txt_medicineTitle.Text, txt_medicineDesc.Text ,int.Parse(txt_medicinePrice.Text)))
                    {
                        MessageBox.Show("İlaç güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMedicines();
                        btn_addMedicine.Text = "Ekle";
                        inputs.ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("İlaç güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                db.CloseConnection();
            }
        }
        public void ConfigureDataTable()
        {
            medicineList.ReadOnly = true;
            medicineList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            medicineList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            medicineList.AllowUserToAddRows = false;
            medicineList.Columns["medicineId"].HeaderText = "ID";
            medicineList.Columns["medicineName"].HeaderText = "İlaç Adı";
            medicineList.Columns["description"].HeaderText = "Açıklama";
            medicineList.Columns["price"].HeaderText = "Fiyat";
        }

        public void LoadMedicines()
        {
            db.OpenConnection();
            DataTable dt = db.GetAllMedicine(Globals.CurrentUserBusinessAdminID);
            db.CloseConnection();
            medicineList.DataSource = dt;
        }
        private void btn_deleteMedicine_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("İlaç silinecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int medicineId = int.Parse(medicineList.SelectedRows[0].Cells["medicineId"].Value.ToString());
                db.OpenConnection();
                if (db.DeleteMedicine(medicineId))
                {
                    Debug.WriteLine(medicineList.SelectedRows[0].Cells["medicineId"].Value.ToString());
                    LoadMedicines();
                    Inputs inputs = new Inputs(new Control[] {txt_medicineDesc,txt_medicinePrice,txt_medicineTitle});
                    inputs.ClearInputs();
                }
                else
                {
                    MessageBox.Show("İlaç silinirken bir hata oluştu!.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btn_addMedicine.Text = "Ekle";

        }

        private void btn_addMedicineBtn_Click(object sender, EventArgs e)
        {
            Inputs inputs = new Inputs(new Control[] {txt_medicineDesc,txt_medicinePrice,txt_medicineTitle});
            inputs.ClearInputs();
            btn_addMedicine.Text = "Ekle";
        }

        private void medicineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_medicineDesc.Text = medicineList.SelectedRows[0].Cells["description"].Value.ToString();
            txt_medicinePrice.Text = medicineList.SelectedRows[0].Cells["price"].Value.ToString();
            txt_medicineTitle.Text = medicineList.SelectedRows[0].Cells["medicineName"].Value.ToString();
            btn_addMedicine.Text = "Güncelle";
        }
    }
}
