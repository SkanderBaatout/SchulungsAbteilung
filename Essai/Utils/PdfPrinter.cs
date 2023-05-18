using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Essai.Utils
{
    public static class PdfPrinter
    {
        public static void PrintPdf(string filePath, string printerName)
        {
            try
            {
                using (var document = new Document())
                {
                    PdfReader reader = new PdfReader(filePath);
                    int numberOfPages = reader.NumberOfPages;
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("temp.pdf", FileMode.Create));
                    document.Open();
                    PdfContentByte cb = writer.DirectContent;
                    PdfImportedPage page;

                    for (int i = 1; i <= numberOfPages; i++)
                    {
                        page = writer.GetImportedPage(reader, i);
                        cb.AddTemplate(page, 0, 0);
                        document.NewPage();
                    }

                    reader.Close();
                    document.Close();
                }

                var printerSettings = new PrinterSettings();
                printerSettings.PrinterName = printerName;

                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    Verb = "print",
                    FileName = "temp.pdf",
                    Arguments = "\"" + printerSettings.PrinterName + "\"",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process process = new Process();
                process.StartInfo = processStartInfo;
                process.Start();
                process.WaitForInputIdle();
                process.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
