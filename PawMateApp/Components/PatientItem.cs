using PawMateApp.Screens;
using PawMateApp.Screens.Admin;
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

namespace PawMateApp.Components
{
    public partial class PatientItem : UserControl
    {
        DatabaseManagament db = new DatabaseManagament();
        public PatientItem()
        {
            InitializeComponent();
        }

        public string _patientId { get; set; }
        public string _customerName { get; set; }
        public string _petName { get; set; }
        public string _petImage { get; set; }
        public string _vetName { get; set; }
        public string _date { get; set; }


        [Category("Props")]
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; txt_customerName.Text = value; }
        }

        [Category("Props")]
        public string Date
        {
            get { return _date; }
            set { _date = value; txt_visitDate.Text = value; }
        }

        [Category("Props")]
        public string PetName
        {
            get { return _petName; }
            set { _petName = value; txt_petName.Text = value; }
        }

        [Category("Props")]
        public string PetImage
        {
            //Pet görselinin pet_image'e eklenmesi gerekiyor
            get { return _petImage; }
            set { _petImage = value; }
        }

        [Category("Props")]
        public string VetName
        {
            get { return _vetName; }
            set { _vetName = value; txt_vetName.Text = value; }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(_patientId);
            PatientEdit editForm = new PatientEdit
            {
                _patientId = this._patientId,
                CustomerName = this._customerName,
                PetName = this._petName,
            };
            editForm.ShowDialog();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                db.OpenConnection();
                if (db.DeletePatient(Convert.ToInt32(_patientId)))
                {
                    MessageBox.Show("Kayıt başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var patientForm = Application.OpenForms["PatientManagement"];
                    if (patientForm != null)
                    {
                        PatientManagement patient = patientForm as PatientManagement;
                        patient?.PatientManagement_Load(null, null); // Eğer form bulunursa yükle
                    }
                    else
                    {
                        MessageBox.Show("PatientManagements formu açık değil!");
                    }

                }
                else
                {
                    MessageBox.Show("Bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void txt_visitDate_Click(object sender, EventArgs e)
        {

        }
    }
}
