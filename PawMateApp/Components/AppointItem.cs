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
    public partial class AppointItem : UserControl
    {
        public AppointItem()
        {
            InitializeComponent();
        }

        public string _visitId { get; set; }
        public string _visitDate { get; set; }
        public string _customerName { get; set; }
        public string _customerPhone { get; set; }
        public string _petName { get; set; }
        public string _petImage { get; set; }
        public string _vetName { get; set; }
        public string _reason { get; set; }

        [Category("Props")]
        public string VisitId
        {
            get { return _visitId; }
            set { _visitId = value; }
        }

        [Category("Props")]
        public string VisitDate
        {
            get { return _visitDate; }
            set { _visitDate = value; txt_visitDate.Text = value; }
        }

        [Category("Props")]
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; txt_customerName.Text = value; }
        }

        [Category("Props")]
        public string CustomerPhone
        {
            get { return _customerPhone; }
            set { _customerPhone = value; txt_customerPhone.Text = value; }
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

        [Category("Props")]
        public string Reason
        {
            get { return _reason; }
            set { _reason = value; txt_reason.Text = value; }
        }

    }
}
