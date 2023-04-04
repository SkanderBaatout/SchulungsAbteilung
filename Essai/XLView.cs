using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai
{
    public partial class XLView : UserControl
    {
        WebBrowser webBrowser1;
        Microsoft.Office.Interop.Excel.Application excel;
        public XLView()
        {
            InitializeComponent();
        }


        private void showFile(string fileName)
        {
            if (fileName != "")
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook xlworkbook = excel.Workbooks.Open(fileName);
                var xlworksheet = xlworkbook.Sheets[1];
                var tempFileName = GetTempFile("html");
                object missing = System.Reflection.Missing.Value;
                object newFileName = (object)tempFileName;
                object fileType = (object)Microsoft.Office.Interop.Excel.XlFileFormat.xlHtml;

                xlworkbook.SaveAs(tempFileName, fileType, missing, missing, missing, missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    missing, missing, missing, missing, missing);
                webBrowser1 = new WebBrowser();
                webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
                webBrowser1.Dock = DockStyle.Fill;
                webBrowser1.Navigate(tempFileName);
                this.Controls.Clear();
                this.Controls.Add(webBrowser1);


            }
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string tmpFile = "";
            try
            {
                if (tmpFile != string.Empty)
                {
                    //delete the tmp file we created
                    File.Delete(tmpFile);

                    //set the temFile to an empty string
                    tmpFile = string.Empty;
                }
            }
            catch (Exception ex) { }
            {

            }
        }
        private string GetTempFile(string extension)
        {
            //Uses the combine ,Get TempPath,changeExtension
            //and GetRandomFile methods of path to create a temp file of the extension 
            // we are looking for 
            return Path.Combine(Path.GetTempPath(),
                Path.ChangeExtension(Path.GetRandomFileName(), extension));
        }
    }
}
