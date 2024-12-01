using PawMateApp.Components;
using System;
using System.Windows.Forms;
using Npgsql;

namespace PawMateApp.Screens.Admin
{
    public partial class Notifications : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));

        public Notifications()
        {
            InitializeComponent();
        }

        // flowLayoutPanel'ı yenileyen metot
        public void RefreshFlowLayoutPanel()
        {
            NotifItems();  // flowLayoutPanel'deki öğeleri yeniden yükle
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
                string query = "SELECT * FROM \"Notifications\" WHERE IsRead=false ORDER BY \"NotificationId\" DESC";
                NpgsqlCommand cmd = new NpgsqlCommand(query, baglan);

                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    flowLayoutPanel1.Controls.Clear();

                    while (dr.Read())
                    {
                        NotifItem notifItem = new NotifItem();
                        notifItem.BusinessName = dr["BusinessName"].ToString();
                        notifItem.BusinessId = dr["BusinessId"].ToString();
                        notifItem.BusinessEmail = dr["businessmail"].ToString();
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

        private void notifItem1_Load(object sender, EventArgs e)
        {
        }
    }
}
