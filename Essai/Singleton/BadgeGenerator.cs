
using iTextSharp.text;
using iTextSharp.text.pdf;

using Essai.Utils;
using Essai.Models;
using Microsoft.Data.SqlClient;

namespace Essai.Singleton
{
    public class BadgeGenerator
    {
        private static BadgeGenerator _instance;
        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";

        private BadgeGenerator()
        {
        }

        public static BadgeGenerator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BadgeGenerator();
                }

                return _instance;
            }
        }

        public void GenerateBadge(string logoPath, string testName, string name, string cin, int score, int totalQuestions, string fileName)
        {
            var badgeSize = new iTextSharp.text.Rectangle(180, 200);
            var logoScale = new iTextSharp.text.Rectangle(badgeSize.Width / 3, badgeSize.Height / 3);
            var logoAlignment = iTextSharp.text.Image.ALIGN_CENTER;
            var headerFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 14, iTextSharp.text.Font.BOLD);
            var testsTypeFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 8, iTextSharp.text.Font.NORMAL);
            var nameFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 8, iTextSharp.text.Font.NORMAL);
            var scoreFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 20, iTextSharp.text.Font.BOLD);
            var footerFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 12, iTextSharp.text.Font.BOLD);

            try
            {
                using (var document = new iTextSharp.text.Document(badgeSize, 0, 0, 0, 0))
                {
                    PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                    document.Open();

                    var logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(logoScale.Width, logoScale.Height);
                    logo.Alignment = logoAlignment;
                    document.Add(logo);

                    var headerParagraph = new iTextSharp.text.Paragraph("Training Service", headerFont);
                    headerParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(headerParagraph);
                    document.Add(new iTextSharp.text.Paragraph("\n"));

                    var testsTypes = GetTestsTypes();
                    var table = CreateTestsTypeTable(testsTypes, testName, testsTypeFont);
                    document.Add(table);

                    var nameParagraph = new iTextSharp.text.Paragraph("Nom: " + name, nameFont);
                    nameParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(nameParagraph);
                    var cinParagraph = new iTextSharp.text.Paragraph("CIN: " + cin, nameFont);
                    cinParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(cinParagraph);

                    var scoreParagraph = new iTextSharp.text.Paragraph(string.Format("{0}/{1}", score, totalQuestions), scoreFont);
                    scoreParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(scoreParagraph);

                    var footerParagraph = new iTextSharp.text.Paragraph("WE CREATE CHARACTER", footerFont);
                    footerParagraph.Alignment = Element.ALIGN_CENTER;
                    footerParagraph.SpacingBefore = 10f;
                    document.Add(footerParagraph);

                    document.Close();
                }

                PdfPrinter.PrintPdf(fileName, "Microsoft Print to PDF");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<TestsType> GetTestsTypes()
        {
            var testsTypes = new List<TestsType>();
            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("SELECT id, name FROM TestsType", con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = Convert.ToInt32(reader["id"]);
                        var name = Convert.ToString(reader["name"]);
                        testsTypes.Add(new TestsType { Id = id, Name = name });
                    }
                }
            }
            return testsTypes;
        }


        private PdfPTable CreateTestsTypeTable(List<TestsType> testsTypes, string passedTestType, iTextSharp.text.Font font)
        {
            var table = new PdfPTable(testsTypes.Count);
            table.WidthPercentage = 100;

            foreach (var testsType in testsTypes)
            {
                var testsTypeInitials = testsType.Name.Substring(0, Math.Min(3, testsType.Name.Length));
                var cell = new PdfPCell(new Phrase(testsTypeInitials, testsType.Name.Equals(passedTestType) ? new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 8, iTextSharp.text.Font.BOLD, BaseColor.BLUE) : font));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                table.AddCell(cell);
            }

            return table;
        }
    }
}
