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
using static PawMateApp.Login;

namespace PawMateApp.Screens
{
    public partial class VetManagement : Form
    {
        public VetManagement()
        {
            InitializeComponent();
            Debug.WriteLine(Globals.CurrentUserID);

        }

        private void btn_addUpdateVet_Click(object sender, EventArgs e)
        {
            
        }
    }
}
