using System;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Colors;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font;
using iText.IO.Image;
using static PawMateApp.Login;
using System.ComponentModel;
using System.Diagnostics;
using PawMateApp.Screens;

namespace PawMateApp.Components
{
    public partial class PrescriptionItem : UserControl
    {
        DatabaseManagament db = new DatabaseManagament();
        public PrescriptionItem()
        {
            InitializeComponent();
        }

        public string _prescriptionId { get; set; }
        public string _customerName { get; set; }
        public string _customerPhone { get; set; }
        public string _petName { get; set; }
        public string _vetName { get; set; }
        public string _medicineName { get; set; }
        public string _medicineUnit { get; set; }
        public string _usageInstructions { get; set; }

        [Category("Props")]
        public string PrescriptionId
        {
            get { return _prescriptionId; }
            set { _prescriptionId = value; }
        }

        [Category("Props")]
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; txt_customerName.Text = value; }
        }

        [Category("Props")]
        public string CustomerPhone
        {
            get { return _customerPhone; }
            set { _customerPhone = value; txt_customerPhone.Text = value; }
        }

        [Category("Props")]
        public string PetName
        {
            get { return _petName; }
            set { _petName = value; txt_petName.Text = value; }
        }

        [Category("Props")]
        public string VetName
        {
            get { return _vetName; }
            set { _vetName = value; txt_vetName.Text = value; }
        }

        [Category("Props")]
        public string MedicineName
        {
            get { return _medicineName; }
            set { _medicineName = value; txt_medicineName.Text = value; }
        }

        [Category("Props")]
        public string MedicineUnit
        {
            get { return _medicineUnit; }
            set { _medicineUnit = value; txt_medicineUnit.Text = value; }
        }

        [Category("Props")]
        public string UsageInstructions
        {
            get { return _usageInstructions; }
            set { _usageInstructions = value; txt_usageInstructions.Text = value; }
        }

        private void PrescriptionItem_Load(object sender, EventArgs e)
        {
            if (Globals.CurrentUserBusinessAdminStatus == true)
            {
                btn_deletePresp.Visible = true;
            }
            else
            {
                btn_deletePresp.Visible = false;
            }
        }

        private void btn_deletePresp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reçeteyi Silmek İstediğinize Emin Misiniz?", "Reçete Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.OpenConnection();
                string query = @"DELETE FROM prescriptions WHERE ""prescriptionId"" = @psid";
                using (var cmd = new Npgsql.NpgsqlCommand(query, db.baglan))
                {
                    cmd.Parameters.AddWithValue("@psid", Convert.ToInt32(PrescriptionId));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reçete başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                db.CloseConnection();
            }
            TreatmentPresManagement treatmentPresManagement = Application.OpenForms["TreatmentPresManagement"] as TreatmentPresManagement;
            string query2 = @"SELECT p.""prescriptionId"", c.""fullName"", c.""phone"", ""petName"", u.""fullName"" AS ""vetname"", ""medicineName"", ""quantity"", ""usageInstructions""
            FROM ""prescriptions"" p
            JOIN ""healthRecords"" hr ON p.""recordId"" = hr.""recordId""
			JOIN ""visits"" v ON hr.""visitid"" = v.""visitId""
            JOIN ""customers"" c ON hr.""customerid"" = c.""customerId""
            JOIN ""pets"" pe ON v.""petId"" = pe.""petId""
            JOIN ""users"" u ON v.""vetId"" = u.""userId""
            JOIN ""medicineStocks"" ms ON p.""medicineId"" = ms.""medicineId""
			JOIN ""medicines"" m ON ms.""medicineId"" = m.""medicineId""
            WHERE v.""businessid"" = @businessid";
            treatmentPresManagement.ExecuteQueryAndLoadItems(query2, treatmentPresManagement.prescriptionList);
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_pdf_Click_1(object sender, EventArgs e)
        {
            string fileName = PetName + " adli hayvanin recetesi.pdf";
            DialogResult result = MessageBox.Show("Reçeteyi PDF olarak kaydetmek istediğinize emin misiniz?", "Reçete PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string dest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                try
                {
                    using (PdfWriter writer = new PdfWriter(dest))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document document = new Document(pdf))
                    {
                        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "tahoma.ttf");
                        PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
                        document.SetFont(font);

                        string imageUrl = "https://i.hizliresim.com/jinrkop.jpeg";
                        iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(imageUrl))
                            .SetWidth(210)
                            .SetHeight(62)
                            .SetFixedPosition(30, 780);

                        document.Add(img);

                        string headerText = TurkishCharacterConverter.ConvertTurkishCharacters("VETERİNER KLİNİĞİ REÇETESİ");
                        Paragraph header = new Paragraph(headerText)
                            .SetFontSize(16)
                            .SetFont(font)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetMarginBottom(20)
                            .SetMarginTop(30)
                            .SetFontColor(ColorConstants.DARK_GRAY);
                        document.Add(header);

                        Table infoTable = new Table(2).UseAllAvailableWidth();
                        infoTable.AddCell(new Cell().Add(new Paragraph("Hasta Adı:").SetFont(font)));
                        infoTable.AddCell(new Cell().Add(new Paragraph(PetName)));
                        infoTable.AddCell(new Cell().Add(new Paragraph("Sahip Adı:").SetFont(font)));
                        infoTable.AddCell(new Cell().Add(new Paragraph(CustomerName)));
                        infoTable.AddCell(new Cell().Add(new Paragraph("Tarih:").SetFont(font)));
                        infoTable.AddCell(new Cell().Add(new Paragraph(DateTime.Now.ToShortDateString())));
                        infoTable.SetMarginBottom(20);
                        document.Add(infoTable);

                        string medHeaderText = TurkishCharacterConverter.ConvertTurkishCharacters("Reçete Detayları");
                        Paragraph medHeader = new Paragraph(medHeaderText)
                            .SetFontSize(14)
                            .SetFont(font)
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetMarginBottom(10)
                            .SetFontColor(ColorConstants.BLUE);
                        document.Add(medHeader);

                        Table medsTable = new Table(3).UseAllAvailableWidth();
                        medsTable.AddHeaderCell(new Cell().Add(new Paragraph("İlaç Adı").SetFont(font)));
                        medsTable.AddHeaderCell(new Cell().Add(new Paragraph("Doz").SetFont(font)));
                        medsTable.AddHeaderCell(new Cell().Add(new Paragraph("Kullanım Detayları").SetFont(font)));

                        medsTable.AddCell(new Paragraph($"{MedicineName}").SetFont(font));
                        medsTable.AddCell(new Paragraph($"{MedicineUnit}").SetFont(font));
                        medsTable.AddCell(new Paragraph($"{UsageInstructions}").SetFont(font));


                        medsTable.SetMarginBottom(20);
                        document.Add(medsTable);

                        string footerText = TurkishCharacterConverter.ConvertTurkishCharacters("Bu reçete veteriner hekiminizin önerilerine göre düzenlenmiştir.");
                        Paragraph footer = new Paragraph(footerText)
                            .SetFontSize(10)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontColor(ColorConstants.GRAY)
                            .SetMarginTop(30);
                        document.Add(footer);
                        document.Close();
                        Console.WriteLine("PDF başarıyla oluşturuldu: " + dest);
                        MessageBox.Show("Reçete başarıyla PDF olarak masaüstüne " + fileName + " olarak kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }

    public class TurkishCharacterConverter
    {
        public static string ConvertTurkishCharacters(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            input = input.Replace("ı", "i")
                         .Replace("ğ", "g")
                         .Replace("Ğ", "G");

            return input;
        }
    }
}
