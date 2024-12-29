using PawMateApp.Screens;
using PawMateApp.Screens.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PawMateApp.Login;

namespace PawMateApp
{
    public partial class Panel : Form
    {
        DatabaseManagament db = new DatabaseManagament();
        public Panel()
        {
            MoveForm moveForm = new MoveForm(this);
            InitializeComponent();
            this.topMenuPanel.MouseDown += new MouseEventHandler(moveForm.Form_MouseDown);
            this.topMenuPanel.MouseMove += new MouseEventHandler(moveForm.Form_MouseMove);
            this.topMenuPanel.MouseUp += new MouseEventHandler(moveForm.Form_MouseUp);

        }

        private void btn_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Globals.CurrentUserID = 0;
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void btn_closeApp_MouseEnter(object sender, EventArgs e)
        {
            btn_closeApp.BackColor = Color.FromArgb(138, 134, 218);
        }

        private void btn_closeApp_MouseLeave(object sender, EventArgs e)
        {
            btn_closeApp.BackColor = Color.FromArgb(41, 33, 230);
        }

        private void btn_minimizeApp_MouseEnter(object sender, EventArgs e)
        {
            btn_minimizeApp.BackColor = Color.FromArgb(138, 134, 218);
        }

        private void btn_minimizeApp_MouseLeave(object sender, EventArgs e)
        {
            btn_minimizeApp.BackColor = Color.FromArgb(41, 33, 230);
        }

        private void topMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }


        public void showForm(Form form)
        {
            contentPanel.Controls.Clear(); // Paneli temizle
            form.TopLevel = false;         // Alt form olarak ayarla
            contentPanel.Controls.Add(form); // Panel'e ekle
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();

            //contentPanel.Controls.Clear();
            //form.MdiParent = this;
            //form.FormBorderStyle = FormBorderStyle.None;
            //contentPanel.Controls.Add(form);
            //form.Show();
        }

        //private void ProfileButton_Click(object sender, EventArgs e)
        //{
        //    Profile profile = new Profile();
        //    showForm(profile);
        //}

        public void Panel_Load(object sender, EventArgs e)
        {
            if (Globals.CurrentUserAppAdminStatus == true)
            {
                db.OpenConnection();
                adminPanel.Visible = true;
                btn_profile.Visible = false;
                if (db.HasUnreadNotifications())//Okunmamış bildirim varsa has_notif.Visible=true olacak.
                {
                    has_notif.Visible = true; 
                }
                else
                {
                    has_notif.Visible = false; 
                }
            }
            else if (Globals.CurrentUserBusinessAdminStatus == true)
            {
                businessPanel.Visible = true;
                btn_vetManagement.Visible = true;
                btn_profile.Visible = true;
                //Stok sayısı, kritik ise has_warning.Visible=true olacak.
            }
            else
            {
                businessPanel.Visible = true;
                btn_vetManagement.Visible = false;
                btn_profile.Visible = true;
                //Stok sayısı, kritik ise has_warning.Visible=true olacak.
            }


        }

        private void btn_showBusinessManagement_Click(object sender, EventArgs e)
        {
            BusinessManagement businessManagement = new BusinessManagement();
            showForm(businessManagement);

        }

        private void btn_showUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            showForm(userManagement);

        }

        private void btn_showTreatmentManagement_Click(object sender, EventArgs e)
        {
            TreatmentManagement treatmentManagement = new TreatmentManagement();
            showForm(treatmentManagement);

        }

        private void btn_showNotifications_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications();
            showForm(notifications);

        }

        private void businessPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            showForm(profile);

        }

        private void btn_vetManagement_Click(object sender, EventArgs e)
        {
            VetManagement vetManagement = new VetManagement();
            showForm(vetManagement);

        }

        private void btn_appointManagement_Click(object sender, EventArgs e)
        {
            AppointManagement appointManagement = new AppointManagement();
            showForm(appointManagement);

        }

        private void btn_patientManagement_Click(object sender, EventArgs e)
        {
            PatientManagement patientManagement = new PatientManagement();
            showForm(patientManagement);

        }

        private void btn_medicineManagement_Click(object sender, EventArgs e)
        {
            MedicineManagement medicineManagement = new MedicineManagement();
            showForm(medicineManagement);

        }

        private void btn_stockManagement_Click(object sender, EventArgs e)
        {
            StockManagement stockManagement = new StockManagement();
            showForm(stockManagement);

        }

        private void btn_petManagement_Click(object sender, EventArgs e)
        {
            PetAndCustomerManagement petManagement = new PetAndCustomerManagement();
            showForm(petManagement);

        }

        private void btn_treatmentManagement_Click(object sender, EventArgs e)
        {
            TreatmentPresManagement treatmentManagement = new TreatmentPresManagement();
            showForm(treatmentManagement);

        }
    }
}
