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
            db.GetMedicines(businessid, cb_treatments);
        }

        private void cb_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_customers.SelectedItem is ComboBoxItem selecteditem)
            {
                db.GetPets(selecteditem.Id, cb_pets);
            }
            else
            {
                Debug.WriteLine("No item selected");
            }
        }

        private void btn_addPrescription_Click(object sender, EventArgs e)
        {
            CheckClass check = new CheckClass(new string[] { txt_notes.Text, txt_patientName.Text, txt_treatmentDuration.Text });
            if (cb_customers.SelectedItem is ComboBoxItem selectedcustomers && cb_pets.SelectedItem is ComboBoxItem selectedpet && cb_treatments.SelectedItem is ComboBoxItem treatmentsSelect) {
                if (check.Check(""))
                {
                    MessageBox.Show("Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
