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
using Npgsql;
using System.Diagnostics;


namespace PawMateApp.Screens.Admin
{
    public partial class Notifications : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
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
            try
            {
                baglan.Open();
                string query = "SELECT * FROM \"Notifications\" WHERE IsRead=false";
                NpgsqlCommand cmd = new NpgsqlCommand(query, baglan);

                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    flowLayoutPanel1.Controls.Clear();

                    while (dr.Read())
                    {
                        NotifItem notifItem = new NotifItem();
                        notifItem.BusinessName = dr["BusinessName"].ToString();
                        notifItem.BusinessId = dr["BusinessId"].ToString();
                        flowLayoutPanel1.Controls.Add(notifItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                baglan.Close();
            }


        }

    }
}
