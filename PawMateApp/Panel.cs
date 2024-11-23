﻿using PawMateApp.Screens;
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
       
        public Panel()
        {
            InitializeComponent();
            // Taşıma yapılcak
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
            DialogResult result = MessageBox.Show( "Çıkış yapmak istediğinize emin misiniz?", "Çıkış",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btn_showBlogCategories_Click(object sender, EventArgs e)
        {
            Advertisements advertisements = new Advertisements();
            showForm(advertisements);
        }

        public void showForm(Form form)
        {
            contentPanel.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            contentPanel.Controls.Add(form);
            form.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            showForm(profile);
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            //Panelde 3 kullanıcı girişi var, bunlara göre paneldeki menülerin getirilmesi gerekiyor
            //Admin Paneli; isAppAdmin ise adminPanel görünecek
            //İşletme Paneli; isBusinessAdmin ise businessPanel görünecek ve Veteriner Yönetimi açık olacak
            //Veteriner Paneli; isBusinessAdmin değil ise businessPanel görünecek ve Veteriner Yönetimi KAPALI olacak




        }

        private void btn_showBusinessManagement_Click(object sender, EventArgs e)
        {
            BusinessManagement businessManagement = new BusinessManagement();
            showForm(businessManagement);
        }
    }
}
