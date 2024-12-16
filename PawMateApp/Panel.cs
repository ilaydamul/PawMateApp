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
        // Formları önbelleğe alalım
        private BusinessManagement businessManagementForm;
        private UserManagement userManagementForm;
        private TreatmentManagement treatmentManagementForm;
        private Notifications notificationsForm;
        private Profile profileForm;
        private VetManagement vetManagementForm;
        private AppointManagement appointManagementForm;
        private PatientManagement patientManagementForm;
        private MedicineManagement medicineManagementForm;
        private StockManagement stockManagementForm;
        private PetAndCustomerManagement petManagementForm;
        private TreatmentPresManagement treatmentPresManagementForm;

        public Panel()
        {
            MoveForm moveForm = new MoveForm(this);
            InitializeComponent();
            this.topMenuPanel.MouseDown += new MouseEventHandler(moveForm.Form_MouseDown);
            this.topMenuPanel.MouseMove += new MouseEventHandler(moveForm.Form_MouseMove);
            this.topMenuPanel.MouseUp += new MouseEventHandler(moveForm.Form_MouseUp);
            this.businessPanel.Paint += new PaintEventHandler(businessPanel_Paint);
            this.topMenuPanel.MouseDown += new MouseEventHandler(topMenuPanel_MouseDown);
        }

        private void btn_closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void businessPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
        private void topMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
           
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

        // Formları önbellekten göster
        public void showForm(Form form)
        {
            contentPanel.Controls.Clear(); // Paneli temizle
            form.TopLevel = false;         // Alt form olarak ayarla
            contentPanel.Controls.Add(form); // Panel'e ekle
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            if (Globals.CurrentUserAppAdminStatus == true)
            {
                adminPanel.Visible = true;
                btn_profile.Visible = false;
            }
            else if (Globals.CurrentUserBusinessAdminStatus == true)
            {
                businessPanel.Visible = true;
                btn_vetManagement.Visible = true;
                btn_profile.Visible = true;
            }
            else
            {
                businessPanel.Visible = true;
                btn_vetManagement.Visible = false;
                btn_profile.Visible = true;
            }


            this.businessPanel.Paint += new PaintEventHandler(businessPanel_Paint);
            this.topMenuPanel.MouseDown += new MouseEventHandler(topMenuPanel_MouseDown);
        }



        private void btn_showBusinessManagement_Click(object sender, EventArgs e)
        {
            if (businessManagementForm == null || businessManagementForm.IsDisposed)
            {
                businessManagementForm = new BusinessManagement();
            }
            showForm(businessManagementForm);
        }

        private void btn_showUserManagement_Click(object sender, EventArgs e)
        {
            if (userManagementForm == null || userManagementForm.IsDisposed)
            {
                userManagementForm = new UserManagement();
            }
            showForm(userManagementForm);
        }

        private void btn_showTreatmentManagement_Click(object sender, EventArgs e)
        {
            if (treatmentManagementForm == null || treatmentManagementForm.IsDisposed)
            {
                treatmentManagementForm = new TreatmentManagement();
            }
            showForm(treatmentManagementForm);
        }

        private void btn_showNotifications_Click(object sender, EventArgs e)
        {
            if (notificationsForm == null || notificationsForm.IsDisposed)
            {
                notificationsForm = new Notifications();
            }
            showForm(notificationsForm);
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            if (profileForm == null || profileForm.IsDisposed)
            {
                profileForm = new Profile();
            }
            showForm(profileForm);
        }

        private void btn_vetManagement_Click(object sender, EventArgs e)
        {
            if (vetManagementForm == null || vetManagementForm.IsDisposed)
            {
                vetManagementForm = new VetManagement();
            }
            showForm(vetManagementForm);
        }

        private void btn_appointManagement_Click(object sender, EventArgs e)
        {
            if (appointManagementForm == null || appointManagementForm.IsDisposed)
            {
                appointManagementForm = new AppointManagement();
            }
            showForm(appointManagementForm);
        }

        private void btn_patientManagement_Click(object sender, EventArgs e)
        {
            if (patientManagementForm == null || patientManagementForm.IsDisposed)
            {
                patientManagementForm = new PatientManagement();
            }
            showForm(patientManagementForm);
        }

        private void btn_medicineManagement_Click(object sender, EventArgs e)
        {
            if (medicineManagementForm == null || medicineManagementForm.IsDisposed)
            {
                medicineManagementForm = new MedicineManagement();
            }
            showForm(medicineManagementForm);
        }

        private void btn_stockManagement_Click(object sender, EventArgs e)
        {
            if (stockManagementForm == null || stockManagementForm.IsDisposed)
            {
                stockManagementForm = new StockManagement();
            }
            showForm(stockManagementForm);
        }

        private void btn_petManagement_Click(object sender, EventArgs e)
        {
            if (petManagementForm == null || petManagementForm.IsDisposed)
            {
                petManagementForm = new PetAndCustomerManagement();
            }
            showForm(petManagementForm);
        }

        private void btn_treatmentManagement_Click(object sender, EventArgs e)
        {
            if (treatmentPresManagementForm == null || treatmentPresManagementForm.IsDisposed)
            {
                treatmentPresManagementForm = new TreatmentPresManagement();
            }
            showForm(treatmentPresManagementForm);
        }
    }
}
