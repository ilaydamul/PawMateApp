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
    public partial class TreatmentManagement : Form
    {
        public TreatmentManagement()
        {
            InitializeComponent();
        }

        private void userList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addUpdateUser_Click(object sender, EventArgs e)
        {
            DatabaseManagament databaseManagament = new DatabaseManagament();
            databaseManagament.OpenConnection();
            databaseManagament.AddTreatmentToDatabase(txt_treatmenttitle.Text, txt_treatmentdesc.Text);
            databaseManagament.CloseConnection();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {

        }
    }
}
