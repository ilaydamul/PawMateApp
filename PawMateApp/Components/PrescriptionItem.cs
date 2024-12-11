using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PawMateApp.Login;

namespace PawMateApp.Components
{
    public partial class PrescriptionItem : UserControl
    {
        public PrescriptionItem()
        {
            InitializeComponent();
        }

        public string _prescriptionId { get; set; }
        public string _customerName { get; set; }
        public string _customerPhone { get; set; }
        public string _petName { get; set; }
        public string _vetName { get; set; }
        public string _medicineName { get; set; }
        public string _medicineUnit { get; set; }
        public string _usageInstructions { get; set; }

        [Category("Props")]
        public string PrescriptionId
        {
            get { return _prescriptionId; }
            set { _prescriptionId = value; }
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
        public string VetName
        {
            get { return _vetName; }
            set { _vetName = value; txt_vetName.Text = value; }
        }

        [Category("Props")]
        public string MedicineName
        {
            get { return _medicineName; }
            set { _medicineName = value; txt_medicineName.Text = value; }
        }

        [Category("Props")]
        public string MedicineUnit
        {
            get { return _medicineUnit; }
            set { _medicineUnit = value; txt_medicineUnit.Text = value; }
        }

        [Category("Props")]
        public string UsageInstructions
        {
            get { return _usageInstructions; }
            set { _usageInstructions = value; txt_usageInstructions.Text = value; }
        }
        private void PrescriptionItem_Load(object sender, EventArgs e)
        {
            //Kullanıcı Admin ise silme butonu görünecek.
            if (Globals.CurrentUserBusinessAdminStatus == true)
            {
                btn_deletePresp.Visible = true;
            }
            else
            {
                btn_deletePresp.Visible = false;
            }
        }

        private void btn_deletePresp_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
