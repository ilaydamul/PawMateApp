﻿using Npgsql;
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

    public partial class StockManagement : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
        DatabaseManagament databaseManagament = new DatabaseManagament();
        int businessid = Globals.CurrentUserBusinessAdminID;
        public StockManagement()
        {
            InitializeComponent();
        }

        public void StockManagement_Load(object sender, EventArgs e)
        {
            databaseManagament.OpenConnection();
            databaseManagament.GetMedicines(Globals.CurrentUserBusinessAdminID, cb_medicines);
            StockItem();
            
        }

        public void StockItem()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                databaseManagament.OpenConnection();
                baglan.Open();
                string query = "SELECT * FROM \"medicineStocks\" WHERE businessid = "+businessid+" ORDER BY \"stockId\" DESC";
                string countQuery = "SELECT * FROM \"medicineStocks\" WHERE \"businessid\" = " + businessid + " ORDER BY CASE WHEN \"quantity\" <= \"threshold\" THEN 0 ELSE 1 END, \"stockId\" DESC;";


                NpgsqlCommand countCmd = new NpgsqlCommand(countQuery, baglan);
                int rowCount = Convert.ToInt32(countCmd.ExecuteScalar());
                Debug.WriteLine(rowCount+ "tane stok var");
                if (rowCount == 0)
                {
                    Debug.WriteLine("Stok yoktur");
                    txt_noStock.Visible = true;
                }
                else
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, baglan);
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            StockItem stockItem = new StockItem();
                            stockItem.MedicineName = dr["medicinename"].ToString();
                            stockItem.StockId = Convert.ToInt32(dr["stockId"]);
                            stockItem.Quantity = dr["quantity"].ToString();
                            stockItem.Threshold = dr["threshold"].ToString();
                            flowLayoutPanel1.Controls.Add(stockItem);
                        }
                    }
                    txt_noStock.Visible = false;
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
        private void btn_addStock_Click(object sender, EventArgs e)
        {
            if (cb_medicines.SelectedItem != null)
            {
                if (Convert.ToInt32(txt_stockUnit.Text) < Convert.ToInt32(txt_stockThreshold.Text))
                {
                    MessageBox.Show("Stok birim sayısı, eşik değerinden küçük olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    if (cb_medicines.SelectedItem is ComboBoxItem selected)
                    {
                        CheckClass check = new CheckClass(new string[] { txt_stockThreshold.Text, txt_stockUnit.Text });
                        if (!check.Check(""))
                        {
                            return;
                        }
                        else
                        {
                            databaseManagament.AddMedicineStocksToDatabase(businessid, selected.Id, selected.DisplayName, int.Parse(txt_stockUnit.Text), int.Parse(txt_stockThreshold.Text));
                            flowLayoutPanel1.Controls.Clear();
                            StockItem();
                            Panel panelForm = Application.OpenForms.OfType<Panel>().FirstOrDefault();
                            if (panelForm != null)
                            {
                                panelForm.Panel_Load(null, EventArgs.Empty);
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
