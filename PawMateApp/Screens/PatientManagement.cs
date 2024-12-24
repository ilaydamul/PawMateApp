using PawMateApp.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PawMateApp.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PawMateApp.Screens
{
    public partial class PatientManagement : Form
    {
        DatabaseManagament db = new DatabaseManagament();
        int businessid = Globals.CurrentUserBusinessAdminID;
        string query2 = @"
            SELECT 
                hr.""recordId"",
                c.""fullName"" AS ""customerName"",
                p.""petName"",
                u.""username"" AS ""vetName"",
                TO_CHAR(hr.""diagnosis_date"", 'DD/MM/YYYY') AS Date
            FROM ""healthRecords"" hr
            JOIN ""visits"" v ON hr.""visitid"" = v.""visitId""
            JOIN ""customers"" c ON v.""customerid"" = c.""customerId""
            JOIN ""pets"" p ON v.""petId"" = p.""petId""
            JOIN ""users"" u ON v.""vetId"" = u.""userId""
            WHERE v.""businessid"" = @businessid;
        ";

        public PatientManagement()
        {
            InitializeComponent();
        }

        public void PatientManagement_Load(object sender, EventArgs e)
        {
            db.OpenConnection();
            db.GetCustomers(businessid,cb_customers);
            dt_diagnosisDate.Format = DateTimePickerFormat.Long;
            db.GetTreatmentsForCombo(cb_treatments);
            db.CloseConnection();
            ExecuteQueryAndLoadItems(query2, patientList);

        }
        public void ExecuteQueryAndLoadItems(string query, Control container)
        {
            container.Controls.Clear();
            db.OpenConnection();
            using (var cmd = new Npgsql.NpgsqlCommand(query, db.baglan))
            {
                cmd.Parameters.AddWithValue("@businessid", Globals.CurrentUserBusinessAdminID);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        PatientItem patientItem= new PatientItem
                        {
                            Date = dr["Date"].ToString(),
                            _patientId = dr["recordId"].ToString(),
                            CustomerName = dr["customerName"].ToString(),
                            PetName = dr["petName"].ToString(),
                            VetName = dr["vetName"].ToString()
                            

                        };
                        container.Controls.Add(patientItem);
                    }
                }
            }
            db.CloseConnection();
        }

        private void cb_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_customers.SelectedItem is ComboBoxItem selecteditem)
            {
                db.OpenConnection();
                db.GetVisits(selecteditem.Id, null , cb_pets);
                db.CloseConnection();
            }
            else
            {
                Debug.WriteLine("No item selected");
            }
        }

        private void btn_addPrescription_Click(object sender, EventArgs e)
        {
            db.OpenConnection();
            DateTime dat = dt_diagnosisDate.Value;
            CheckClass check = new CheckClass(new string[] { txt_notes.Text, txt_patientName.Text, txt_treatmentDuration.Text });
            if (cb_customers.SelectedItem is ComboBoxItem selectedcustomers && cb_pets.SelectedItem is ComboBoxItem selectedpet && cb_treatments.SelectedItem is ComboBoxItem treatmentsSelect) {
                if (check.Check(""))
                {
                   if(db.AddHealthRecords(selectedcustomers.Id, selectedpet.Id, txt_patientName.Text, dat, treatmentsSelect.Id, txt_treatmentDuration.Text, txt_notes.Text, Globals.CurrentUserBusinessAdminID))
                    {
                        MessageBox.Show("Başarılı bir şekilde eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cb_customers.SelectedIndex = -1;
                        cb_pets.SelectedIndex = -1;
                        cb_treatments.SelectedIndex = -1;
                        txt_patientName.Text = "";
                        txt_treatmentDuration.Text = "";
                        txt_notes.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Debug.WriteLine("Boş döndü geldi");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PatientManagement_Load(null, null);
            db.CloseConnection();
        }
    }
}
