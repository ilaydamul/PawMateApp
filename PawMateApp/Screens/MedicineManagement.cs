using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawMateApp.Screens
{
    public partial class MedicineManagement : Form
    {
        public MedicineManagement()
        {
            InitializeComponent();
        }

        private void btn_addMedicine_Click(object sender, EventArgs e)
        {
            CheckClass check = new CheckClass(new string[] { txt_medicineDesc.Text, txt_medicinePrice.Text, txt_medicineTitle.Text, txt_medicineUnit.Text });
            if (!check.Check(""))
            {
                return;
            }
            else
            {
                MessageBox.Show("İlaç eklenicek.");
            }
        }

        private void btn_deleteMedicine_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("İlaç silinecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("İlaç silindi." , "Başarılı" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            
        }

        private void btn_addMedicineBtn_Click(object sender, EventArgs e)
        {
            Inputs inputs = new Inputs(new Control[] {txt_medicineDesc,txt_medicinePrice,txt_medicineTitle,txt_medicineUnit});
            inputs.ClearInputs();
        }
    }
}
