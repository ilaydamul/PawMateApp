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
    public partial class MyAdverts : Form
    {
        public MyAdverts()
        {
            InitializeComponent();
        }
        private AddAdvert addAdvertForm = null;
        private void btn_addAdvert_Click(object sender, EventArgs e)
        {
            // Eğer form hâlâ açık ise tekrar açmaya çalışma
            if (addAdvertForm == null || addAdvertForm.IsDisposed)
            {
                addAdvertForm = new AddAdvert();
                addAdvertForm.Show();
            }
            else
            {
                // Form zaten açık ise öne getir
                addAdvertForm.Focus();
            }
        }
    }
}
