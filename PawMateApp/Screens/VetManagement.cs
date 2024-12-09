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
            

        }

        private void btn_addUpdateVet_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(isBusinessAdmin.Checked);
            CheckClass checkinputs = new CheckClass(new string[] { txt_email.Text, txt_fullname.Text, txt_password.Text, txt_phone.Text, txt_title.Text, txt_username.Text });
            if (!checkinputs.Check(""))
            {
                return;
            }
            else
            {
                DatabaseManagament database = new DatabaseManagament();
                database.OpenConnection();
                database.AddUserToDatabase(txt_username.Text, txt_password.Text, txt_email.Text, txt_phone.Text, txt_fullname.Text, isBusinessAdmin.Checked);
            }
        }
    }
}
