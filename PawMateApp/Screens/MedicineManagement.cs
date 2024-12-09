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
            //İlaç ekleme işlemleri yapılacak
            //Birim ve Fiyat INT girilmeli
        }

        private void btn_deleteMedicine_Click(object sender, EventArgs e)
        {
            //Seçili ilaç silinecek
        }

        private void btn_addMedicineBtn_Click(object sender, EventArgs e)
        {
            //İlaç ekleme alanı temizlenecek, önceki yerler gibi
        }
    }
}
