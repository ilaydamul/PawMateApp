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
    public partial class PatientItem : UserControl
    {
        public PatientItem()
        {
            InitializeComponent();
        }

        public string _patientId { get; set; }
        public string _customerName { get; set; }
        public string _petName { get; set; }
        public string _petImage { get; set; }
        public string _vetName { get; set; }
     

        [Category("Props")]
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; txt_customerName.Text = value; }
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
            //PatientEdit sayfası açılacak
        }
    }
}
