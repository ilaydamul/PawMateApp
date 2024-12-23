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
    public partial class PatientEdit : Form
    {
        DatabaseManagament db = new DatabaseManagament();
        Dictionary<String, String> informations;
        public PatientEdit()
        {
            InitializeComponent();
        }
        public string _patientId { get; set; }
        public string _customerName { get; set; }
        public string _customerPhone { get; set; }
        public string _petName { get; set; }
        public string _patientName { get; set; }
        public string _diagnosisDate { get; set; }
        public string _treatmentType { get; set; }
        public string _treatmentDuration { get; set; }
        public string _notes { get; set; }


        [Category("Props")]
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; lbl_customerName.Text = value; }
        }

        [Category("Props")]
        public string CustomerPhone
        {
            get { return _customerPhone; }
            set { _customerPhone = value; lbl_customerPhone.Text = value; }
        }

        [Category("Props")]
        public string PetName
        {
            get { return _petName; }
            set { _petName = value; lbl_petName.Text = value; }
        }

        [Category("Props")]
        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; lbl_patientName.Text = value; txt_patientName.Text = value; }
        }

        [Category("Props")]
        public string DiagnosisDate
        {
            get { return _diagnosisDate; }
            set { _diagnosisDate = value; lbl_diagnosisDate.Text = value;
                //İlgili tarihin seçilmesi
            }
        }

        [Category("Props")]
        public string TreatmentType
        {
            get { return _treatmentType; }
            set { _treatmentType = value;
                lbl_treatmentType.Text = value;
             //İlgili tedavinin seçilmesi
            }
        }

        [Category("Props")]
        public string TreatmentDuration
        {
            get { return _treatmentDuration; }
            set { _treatmentDuration = value; lbl_treatmentDuration.Text = value; txt_treatmentDuration.Text = value; }
        }

        [Category("Props")]
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; txt_notes.Text = value; }
        }

        private void btn_closePatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatientEdit_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            informations = db.GetInformationsForEdit(Convert.ToInt32(this._patientId));
            db.CloseConnection();
            LoadValues();
        }

        private void LoadValues()
        {
            this.PatientName = informations["diagnosis"];
            this.Notes = informations["notes"];
            this.TreatmentDuration = informations["ill_duration"];
            this.PetName = informations["petName"];
            this.CustomerName = informations["customerName"];
            this.CustomerPhone = informations["phone"];
            this.TreatmentType = informations["treatmentName"];
            lbl_customerName.Text = informations["customerName"];
            lbl_customerPhone.Text = informations["phone"];
            lbl_patientName.Text = informations["diagnosis"];
            lbl_petName.Text = informations["petName"];
            lbl_treatmentDuration.Text = informations["ill_duration"];
            lbl_treatmentType.Text = informations["treatmentName"];
            lbl_diagnosisDate.Text = informations["diagnosis_date"];
            this.DiagnosisDate = informations["diagnosis_date"];
            db.GetTreatmentsForCombo(cb_treatments);
            cb_treatments.SelectedIndex = cb_treatments.FindStringExact(informations["treatmentName"]);

        }
    }
}
