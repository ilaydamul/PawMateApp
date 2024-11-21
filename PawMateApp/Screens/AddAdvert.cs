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
    public partial class AddAdvert : Form
    {
        public AddAdvert()
        {
            InitializeComponent();
        }

        private void btn_closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
