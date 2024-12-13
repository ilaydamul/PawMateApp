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
    public partial class StockItem : UserControl
    {
        public StockItem()
        {
            InitializeComponent();
        }

        public int _stockId { get; set; }
        public string _medicineName { get; set; }
        public string _quantity { get; set; }
        public string _threshold { get; set; }

        [Category("Props")]
        public int StockId
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
            set { _quantity = value; label1.Text = _quantity; }
        }

        [Category("Props")]
        public string Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }

        private void StockItem_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(_quantity + "Kadar Birim var" + _threshold + "Red Line");
            if(Convert.ToInt32(_quantity) < Convert.ToInt32(_threshold))
            {
                img_stock.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\ilaydamul\\PawMateApp\\PawMateApp\\Resources\\green_light.png";
            }
            else
            {
                return;
            }
            
        }

        private void btn_deleteStock_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçilen stoğu silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) {
                Debug.WriteLine(StockId +" Silindi");
                DatabaseManagament db = new DatabaseManagament();
                db.OpenConnection();
                db.DeleteMedicineStock(StockId);
                db.CloseConnection();
                MessageBox.Show("Başarılı bir şekilde silindi!");
            }
        }
    }
}
