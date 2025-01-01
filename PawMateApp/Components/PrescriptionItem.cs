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
using iText.Layout.Borders;
using iText.IO.Font.Constants;
using iText.Kernel.Geom;

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
            string query2 = @"SELECT p.""prescriptionId"", c.""fullName"", c.""phone"", ""petName"", u.""fullName"" AS ""vetname"", ""medicineName"", ""dosage"", ""usageInstructions""
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
            string fileName = $"{PetName}_recete_{DateTime.Now:yyyyMMdd}.pdf";
            string dest = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            DialogResult result = MessageBox.Show("Reçeteyi PDF olarak kaydetmek istediğinize emin misiniz?", 
                "Reçete PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if (result == DialogResult.Yes)
            {
                try
                {
                    // PDF'i oluştur
                    byte[] pdfBytes = GeneratePrescriptionPDF(Convert.ToInt32(PrescriptionId));
                
                    if (pdfBytes != null)
                    {
                        // Dosyaya kaydet
                        File.WriteAllBytes(dest, pdfBytes);
                
                        MessageBox.Show($"Reçete başarıyla masaüstüne '{fileName}' olarak kaydedildi.", 
                            "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                        // PDF'i otomatik aç
                        System.Diagnostics.Process.Start(dest);
                    }
                    else
                    {
                        MessageBox.Show("PDF oluşturulurken bir hata oluştu.", 
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", 
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine("PDF kaydetme hatası: " + ex.Message);
                }
            }
        }

        private byte[] GeneratePrescriptionPDF(int prescriptionId)
        {
            Document document = null;
            MemoryStream ms = null;

            try
            {
                ms = new MemoryStream();
                PdfWriter writer = new PdfWriter(ms);
                PdfDocument pdf = new PdfDocument(writer);
                document = new Document(pdf);

                // Font tanımlamaları için önce encoding provider'ı kaydet

                // Font tanımlamaları
                PdfFont boldFont = PdfFontFactory.CreateFont("Helvetica-Bold", "Cp1254", PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);
                PdfFont normalFont = PdfFontFactory.CreateFont("Helvetica", "Cp1254", PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);
                PdfFont italicFont = PdfFontFactory.CreateFont("Helvetica-Oblique", "Cp1254", PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

                float pageWidth = pdf.GetDefaultPageSize().GetWidth();
                float pageHeight = pdf.GetDefaultPageSize().GetHeight();

                // Logo ekle - sayfa ortasında yarı saydam
                string imagePath = "https://i.hizliresim.com/jinrkop.jpeg";
                ImageData imageData = ImageDataFactory.Create(new Uri(imagePath));
                Image img = new Image(imageData)
                    .SetWidth(400)  // Logo boyutunu büyüt
                    .SetHeight(150)
                    .SetFixedPosition(
                        (pageWidth - 400) / 2,  // Yatayda ortala
                        (pageHeight - 150) / 2   // Dikeyde ortala
                    )
                    .SetOpacity(0.05f);  // Saydamlık ayarı (0.1 = %90 saydam)

                document.Add(img);

                // Başlık tablosu
                Table headerTable = new Table(UnitValue.CreatePercentArray(1))
                    .SetWidth(UnitValue.CreatePercentValue(100));

                Cell headerCell = new Cell()
                    .Add(new Paragraph(_petName?.ToUpper() ?? "")
                        .SetFont(boldFont)
                        .SetFontSize(16)
                        .SetTextAlignment(TextAlignment.CENTER))
                    .Add(new Paragraph("VETERİNER REÇETESİ")
                        .SetFont(boldFont)
                        .SetFontSize(14)
                        .SetTextAlignment(TextAlignment.CENTER))
                    .SetBorder(Border.NO_BORDER)
                    .SetPaddingTop(20);

                headerTable.AddCell(headerCell);
                document.Add(headerTable);

                // Boşluk ekle
                document.Add(new Paragraph("\n"));

                // Reçete bilgileri tablosu
                Table infoTable = new Table(2)
                    .UseAllAvailableWidth()
                    .SetMarginTop(20);  // Üstten boşluk ekle

                // Tüm bilgileri aynı formatta ekleyelim
                AddInfoRow(infoTable, "Reçete No:", prescriptionId.ToString(), boldFont, normalFont);
                AddInfoRow(infoTable, "Tarih:", DateTime.Now.ToString("dd.MM.yyyy"), boldFont, normalFont);
                AddInfoRow(infoTable, "Hasta Sahibi:", _customerName, boldFont, normalFont);
                AddInfoRow(infoTable, "Telefon:", _customerPhone, boldFont, normalFont);
                AddInfoRow(infoTable, "Hasta Adı:", _petName, boldFont, normalFont);
                AddInfoRow(infoTable, "Veteriner Hekim:", _vetName, boldFont, normalFont);

                document.Add(infoTable);

                // İlaç tablosu
                Table medicineTable = new Table(new float[] { 3, 1, 2 })
                    .UseAllAvailableWidth()
                    .SetMarginBottom(20);

                medicineTable.AddHeaderCell(CreateHeaderCell("İlaç Adı", boldFont));
                medicineTable.AddHeaderCell(CreateHeaderCell("Miktar", boldFont));
                medicineTable.AddHeaderCell(CreateHeaderCell("Kullanım", boldFont));

                medicineTable.AddCell(CreateCell(_medicineName, normalFont));
                medicineTable.AddCell(CreateCell(_medicineUnit, normalFont));
                medicineTable.AddCell(CreateCell(_usageInstructions, normalFont));

                document.Add(medicineTable);

                // Alt bilgi ve notlar
                document.Add(new Paragraph("Önemli Notlar:")
                    .SetFont(boldFont)
                    .SetMarginBottom(10));

                document.Add(new Paragraph("• Bu reçete veteriner hekim tarafından düzenlenmiştir.\n" +
                                                    "• İlaçları belirtilen dozlarda ve sürelerde kullanınız.\n" +
                                                    "• Tedavi süresince herhangi bir yan etki görülmesi durumunda veteriner hekiminize başvurunuz.")
                    .SetFont(italicFont)
                    .SetFontSize(9)
                    .SetMarginBottom(20));

                document.Close();
                return ms.ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("PDF oluşturma hatası: " + ex.Message);
                return null;
            }
            finally
            {
                if (document != null)
                {
                    document.Close();
                }
                if (ms != null)
                {
                    ms.Dispose();
                }
            }
        }

        // Yardımcı metodlar
        private void AddInfoRow(Table table, string label, string value, PdfFont boldFont, PdfFont normalFont)
        {
            table.AddCell(new Cell().Add(new Paragraph(label).SetFont(boldFont))
                .SetBorder(Border.NO_BORDER)
                .SetPaddingRight(10));
            table.AddCell(new Cell().Add(new Paragraph(value ?? "").SetFont(normalFont))
                .SetBorder(Border.NO_BORDER));
        }

        private Cell CreateHeaderCell(string text, PdfFont font)
        {
            return new Cell()
                .Add(new Paragraph(text).SetFont(font))
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetPadding(5)
                .SetTextAlignment(TextAlignment.CENTER);
        }

        private Cell CreateCell(string text, PdfFont font)
        {
            return new Cell()
                .Add(new Paragraph(text ?? "").SetFont(font))
                .SetPadding(5);
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
