using PawMateApp.Components;
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
    public partial class TreatmentPresManagement : Form
    {
        public TreatmentPresManagement()
        {
            InitializeComponent();
            //btn_dateChange.Click += btn_dateChange_Click;
        }

        private void TreatmentPresManagement_Load(object sender, EventArgs e)
        {
            //Randevu tarihi olan checkbox içerikleri(cb_visits) şu şekilde olmalı = "Veteriner Adı - Müşteri Adı - Randevu Tarihi"

            //Burada kullanıcı admin değilse ve başka bir veterinerin randevusu var ise burada reçete yazamamalı, direkt combobox'a gelmemeli
            //Örneğin 2 adet sıla ve ilayda veterineri var, burada sılanın randevusu varsa ve ilayda bu hastaya reçete yazamamalı,-
            //direkt sılanın ve diğer veterinerlerin randevuları cb_visits'e gelmemeli.


            PrescriptionItem prescriptionItem = new PrescriptionItem();
            prescriptionItem.CustomerName = "İlayda";
            prescriptionItem.CustomerPhone = "0541 569 4337";
            prescriptionItem.PetName = "Sıla";
            prescriptionItem.VetName = "Barış";
            prescriptionItem.MedicineName = "Parol";
            prescriptionItem.MedicineUnit = "2";
            prescriptionItem.UsageInstructions = "Şu şekilde kullanılmalı: ..";
            prescriptionList.Controls.Add(prescriptionItem);

        }
        private bool isDateAscending = true;

        private void btn_dateChange_Click(object sender, EventArgs e)
        {
            if (isDateAscending)
            {
                btn_dateChange.Text = "Tarih Azalan";
            }
            else
            {
                btn_dateChange.Text = "Tarih Artan";
            }

            isDateAscending = !isDateAscending;
        }

        private void txt_research_TextChanged(object sender, EventArgs e)
        {
            //Her text değiştiğinde ilgili reçetelerin içindeki tüm veriler taranacak ve ilgili reçeteler gelecek. 
            //Aranan kritere uygun reçete yoksa txt_noRec visible=true olacak.
            //Textboxın içi boş olduğunda eski versiyonuna geri dönecek. 
        }
    }
}
