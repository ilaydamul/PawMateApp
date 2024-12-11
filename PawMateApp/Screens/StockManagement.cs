using PawMateApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawMateApp.Screens
{
    public partial class StockManagement : Form
    {
        public StockManagement()
        {
            InitializeComponent();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            StockItem stockItem = new StockItem();
            stockItem.StockId = "1";
            stockItem.MedicineName = "İlaaaç";
            stockItem.Quantity = "32";
            stockItem.Quantity = "30";
            flowLayoutPanel1.Controls.Add(stockItem);
        }
    }
}
