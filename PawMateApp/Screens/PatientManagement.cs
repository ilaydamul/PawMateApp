using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PawMateApp.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PawMateApp.Screens
{
    public partial class PatientManagement : Form
    {
        DatabaseManagament db = new DatabaseManagament();
        int businessid = Globals.CurrentUserBusinessAdminID;
        public PatientManagement()
        {
            InitializeComponent();
        }

        private void PatientManagement_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            db.GetCustomers(businessid,cb_customers);
            dt_diagnosisDate.Format = DateTimePickerFormat.Long;
            db.GetTreatmentsForCombo(cb_treatments);
            db.CloseConnection();


        }

        private void cb_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_customers.SelectedItem is ComboBoxItem selecteditem)
            {
                db.OpenConnection();
                db.GetPets(selecteditem.Id, cb_pets);
                db.CloseConnection();
            }
            else
            {
                Debug.WriteLine("No item selected");
            }
        }

        private void btn_addPrescription_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            DateTime dat = dt_diagnosisDate.Value;
            CheckClass check = new CheckClass(new string[] { txt_notes.Text, txt_patientName.Text, txt_treatmentDuration.Text });
            if (cb_customers.SelectedItem is ComboBoxItem selectedcustomers && cb_pets.SelectedItem is ComboBoxItem selectedpet && cb_treatments.SelectedItem is ComboBoxItem treatmentsSelect) {
                if (check.Check(""))
                {
                   if(db.AddHealthRecords(selectedcustomers.Id, selectedpet.Id, txt_patientName.Text, dat, treatmentsSelect.Id, txt_treatmentDuration.Text, txt_notes.Text))
                    {
                        MessageBox.Show("Başarılı bir şekilde eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Debug.WriteLine("Boş döndü geldi");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.CloseConnection();
        }
    }
}
