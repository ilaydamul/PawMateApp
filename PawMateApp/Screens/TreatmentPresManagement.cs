﻿using PawMateApp.Components;
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
    
    public partial class TreatmentPresManagement : Form
    {
        DatabaseManagament db = new DatabaseManagament();
        string query = @"SELECT p.""prescriptionId"", c.""fullName"", c.""phone"", ""petName"", u.""fullName"" AS ""vetname"", ""medicineName"", ""dosage"", ""usageInstructions""
            FROM ""prescriptions"" p
            JOIN ""healthRecords"" hr ON p.""recordId"" = hr.""recordId""
			JOIN ""visits"" v ON hr.""visitid"" = v.""visitId""
            JOIN ""customers"" c ON hr.""customerid"" = c.""customerId""
            JOIN ""pets"" pe ON v.""petId"" = pe.""petId""
            JOIN ""users"" u ON v.""vetId"" = u.""userId""
            JOIN ""medicineStocks"" ms ON p.""medicineId"" = ms.""medicineId""
			JOIN ""medicines"" m ON ms.""medicineId"" = m.""medicineId""
            WHERE v.""businessid"" = @businessid
";
        public TreatmentPresManagement()
        {
            InitializeComponent();
        }

        private void TreatmentPresManagement_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            db.GetPatientForCombobox(cb_visits);
            db.GetMedicineStocks(cb_medicines);
            ExecuteQueryAndLoadItems(query, prescriptionList);

        }

        public void ExecuteQueryAndLoadItems(string query, Control container)
        {
            container.Controls.Clear();
            using (var cmd = new Npgsql.NpgsqlCommand(query, db.baglan))
            {
                cmd.Parameters.AddWithValue("@businessid", Globals.CurrentUserBusinessAdminID);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PrescriptionItem prescriptionItem = new PrescriptionItem()
                        {
                            _prescriptionId = dr["prescriptionId"].ToString(),
                            CustomerName = dr["fullName"].ToString(),
                            CustomerPhone = dr["phone"].ToString(),
                            PetName = dr["petName"].ToString(),
                            VetName = dr["fullName"].ToString(),
                            MedicineName = dr["medicineName"].ToString(),
                            MedicineUnit = dr["dosage"].ToString(),
                            UsageInstructions = dr["usageInstructions"].ToString()
                        };
                        container.Controls.Add(prescriptionItem);
                    }
                }
            }
        }
        private async void btn_addPrescription_Click(object sender, EventArgs e)
        {
            CheckClass check = new CheckClass(new string[] { txt_quantity.Text, txt_usageInstructions.Text, cb_medicines.Text, cb_visits.Text});
            if (check.Check(""))
            {
                if(cb_medicines.SelectedItem is ComboBoxItem cb_medicine_item && cb_visits.SelectedItem is ComboBoxItem cb_visit_item)
                {
                    await db.CheckMedicineStocksAsync(cb_medicine_item.Id, Convert.ToInt32(txt_quantity.Text),cb_visit_item.Id,Convert.ToInt32(txt_quantity.Text),txt_usageInstructions.Text);
                    ExecuteQueryAndLoadItems(query, prescriptionList);
                    Inputs inp = new Inputs(new Control[] {txt_usageInstructions,txt_quantity,cb_medicines,cb_visits});
                    inp.ClearInputs();
                    Panel panelForm = Application.OpenForms.OfType<Panel>().FirstOrDefault();
                    if (panelForm != null)
                    {
                        panelForm.Panel_Load(null, EventArgs.Empty);
                    }
                }
                
            }
            
        }
    }
}
