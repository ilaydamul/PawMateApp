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

namespace PawMateApp.Screens.Admin
{
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            NotifItems();
            
        }

        private void NotifItems()
        {
            NotifItem[] notifItems = new NotifItem[20];

            for (int i = 0; i < notifItems.Length; i++)
            {
                notifItems[i] = new NotifItem();
                notifItems[i].BusinessName = "İşletme Adı";
                
                //if (flowLayoutPanel1.Controls.Count>0) {
                //    flowLayoutPanel1.Controls.Clear();
                //}
                //else
                flowLayoutPanel1.Controls.Add(notifItems[i]);
            }
        }

        

    }
}
