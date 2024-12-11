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
    public partial class StockItem : UserControl
    {
        public StockItem()
        {
            InitializeComponent();
        }

        public string _stockId { get; set; }
        public string _medicineName { get; set; }
        public string _quantity { get; set; }
        public string _threshold { get; set; }

        [Category("Props")]
        public string StockId
        {
            get { return _stockId; }
            set { _stockId = value;}
        }

        [Category("Props")]
        public string MedicineName
        {
            get { return _medicineName; }
            set { _medicineName = value; txt_medicineName.Text = _medicineName; }
        }

        [Category("Props")]
        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        [Category("Props")]
        public string Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }

        private void StockItem_Load(object sender, EventArgs e)
        {
            //İlacın miktarı threshold(eşik)'in altında ise img_stock red_light olması gerekiyor. Resources'ın içinde ilgili resim var.
        }

        private void btn_deleteStock_Click(object sender, EventArgs e)
        {
            //Emin misiniz? uyarısından sonra stok silinmeli
        }
    }
}
