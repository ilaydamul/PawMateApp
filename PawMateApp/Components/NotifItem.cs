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
    public partial class NotifItem : UserControl
    {
        public NotifItem()
        {
            InitializeComponent();
        }

        public string _businessId { get; set; }
        public string _businessName { get; set; }

        [Category("Props")]
        public string BusinessName
        {
            get { return _businessName; }
            set { _businessName = value; txt_businessName.Text = value; }
        }

        [Category("Props")]
        public string BusinessId
        {
            get { return _businessId; }
            set { _businessId = value;}
        }

        private void btn_approveBusiness_Click(object sender, EventArgs e)
        {
            //businessId ile işlemleri yapabiliriz. 
        }

        private void btn_declineBusiness_Click(object sender, EventArgs e)
        {
            //businessId ile işlemleri yapabiliriz. 
        }
    }
}
