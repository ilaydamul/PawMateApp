using PawMateApp.Components;
using System;
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
                string query = "SELECT * FROM \"notifications\" WHERE \"isRead\"=false ORDER BY \"notificationId\" DESC";
                string countQuery = "SELECT COUNT(*) FROM \"notifications\" WHERE \"isRead\"=false";
                NpgsqlCommand countCmd = new NpgsqlCommand(countQuery, baglan);
                int rowCount = Convert.ToInt32(countCmd.ExecuteScalar());
                if (rowCount == 0)
                {
                    Debug.WriteLine("Bildirim yoktur");
                    txt_noNotif.Visible = true;
                }
                else
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, baglan);
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();
                        while (dr.Read())
                        {
                            NotifItem notifItem = new NotifItem();
                            notifItem.BusinessName = dr["businessName"].ToString();
                            notifItem.BusinessId = dr["businessId"].ToString();
                            notifItem.BusinessEmail = dr["email"].ToString();
                            flowLayoutPanel1.Controls.Add(notifItem); 
                        }
                    }
                    txt_noNotif.Visible = false;
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
