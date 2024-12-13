using PawMateApp.Components;
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

    public partial class AppointManagement : Form
    {
        DatabaseManagament db = new DatabaseManagament();

        public AppointManagement()
        {
            InitializeComponent();
        }

        private void AppointManagement_Load(object sender, EventArgs e)
        {
            AppointItem appointItem = new AppointItem();
            appointItem.VisitDate = "21.02.2004";
            appointItem.CustomerName = "İlayda";
            appointItem.CustomerPhone = "0541 569 4337";
            appointItem.PetName = "Sıla";
            appointItem.VetName = "Barış";
            appointItem.Reason = "Çok fazla pireye sahip.";

            AppointItem appointItem2 = new AppointItem();
            appointItem2.VisitDate = "21.02.2004";
            appointItem2.CustomerName = "İlayda";
            appointItem2.CustomerPhone = "0541 569 4337";
            appointItem2.PetName = "Sıla";
            appointItem2.VetName = "Barış";
            appointItem2.Reason = "Çok fazla pireye sahip.";

            AppointItem appointItem3 = new AppointItem();
            appointItem3.VisitDate = "21.02.2004";
            appointItem3.CustomerName = "İlayda";
            appointItem3.CustomerPhone = "0541 569 4337";
            appointItem3.PetName = "Sıla";
            appointItem3.VetName = "Barış";
            appointItem3.Reason = "Çok fazla pireye sahip.";
            upcomingAppointments.Controls.Add(appointItem);
            upcomingAppointments.Controls.Add(appointItem2);
            upcomingAppointments.Controls.Add(appointItem3);
            db.OpenConnection();
            db.GetAppoints(Globals.CurrentUserBusinessAdminID, cb_customers);

        }

        private void btn_addVisit_Click(object sender, EventArgs e)
        {

        }
    }
}
