using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawMateApp.Components
{
    public partial class PatientEdit : Form
    {
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
    }
}
