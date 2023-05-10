using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Essai.Repository;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using PdfiumViewer;
using Serilog;
using Microsoft.Web.WebView2.WinForms;
using System.Diagnostics;

namespace Essai
{
    public partial class FollowSubjectForm : Form
    {
        private readonly string _connectionString;
        private readonly ILogger _logger;
        private readonly SubjectRepository _subjectRepository;
        private WebView2 webView;

        public FollowSubjectForm()
        {
            InitializeComponent();

            // Initialize logger
            _logger = new LoggerConfiguration()
                .WriteTo.File("log.txt")
                .CreateLogger();

            // Initialize database connection
            _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
            _subjectRepository = new SubjectRepository(_connectionString);

            // Load subjects into ComboBox
            LoadSubjectsAsync();
        }

        private async void LoadSubjectsAsync()
        {
            try
            {
                var subjects = await _subjectRepository.GetActiveSubjectsAsync();

                foreach (var subject in subjects)
                {
                    comboBox_subjects.Items.Add(subject.Name);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error loading subjects");
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }

        private async void comboBox_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_subjects.SelectedItem == null)
                {
                    textBox_content.Text = "";
                    label_subjectName.Text = "";
                    return;
                }

                string selectedSubject = comboBox_subjects.SelectedItem.ToString();

                var subject = await _subjectRepository.GetSubjectAsync(selectedSubject);

                if (subject != null)
                {
                    string contentType = subject.ContentType;
                    byte[] content = subject.Content;

                    // Check if the content is a file
                    if (Encoding.UTF8.GetString(content).StartsWith("file:"))
                    {
                        string filePath = Encoding.UTF8.GetString(content).Substring(5);
                        content = File.ReadAllBytes(filePath);
                        contentType = Path.GetExtension(filePath);
                    }

                    // Display content in TextBox
                    textBox_content.Text = Encoding.UTF8.GetString(content);

                    // Set content type
                    DisplayContent(content, contentType);

                    // Display subject name
                    label_subjectName.Text = selectedSubject;
                }
                else
                {
                    textBox_content.Text = "";
                    label_subjectName.Text = "";
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error loading subject content");
                MessageBox.Show("Error loading subject content: " + ex.Message);
            }
        }

        private void DisplayContent(byte[] content, string contentType)
        {
            switch (contentType)
            {
                case ".txt":
                    textBox_content.Multiline = true;
                    textBox_content.Text = Encoding.UTF8.GetString(content);
                    break;
                case ".pdf":
                    DisplayPdf(content);
                    break;
                case ".mp4":
                    PlayVideo(content);
                    break;
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                    DisplayImage(content);
                    break;
                case ".doc":
                case ".docx":
                    DisplayWordDoc(content);
                    break;
                case ".xls":
                case ".xlsx":
                    DisplayExcel(content);
                    break;
                default:
                    textBox_content.Multiline = true;
                    textBox_content.Text = "Unsupported file type.";
                    break;
            }
        }

        private void DisplayPdf(byte[] content)
        {
            using (var stream = new MemoryStream(content))
            {
                using (var document = PdfDocument.Load(stream))
                {
                    var image = document.Render(0, 300, 300, false);
                    pictureBox1.Image = image as Bitmap;
                }
            }
        }

        private void PlayVideo(byte[] content)
        {
            try
            {
                string vlcPath = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
                string videoPath = Path.Combine(Path.GetTempPath(), "video.mp4");

                // Write the video content to a temporary file
                File.WriteAllBytes(videoPath, content);

                // Launch VLC and play the video
                Process.Start(vlcPath, $"\"{videoPath}\" --fullscreen");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error playing video");
                MessageBox.Show("Error playing video: " + ex.Message);
            }
        }

        private void DisplayImage(byte[] content)
        {
            using (var stream = new MemoryStream(content))
            {
                pictureBox1.Image = Image.FromStream(stream) as Bitmap;
            }
        }

        private void DisplayWordDoc(byte[] content)
        {
            // You could use another third-party library, such as Spire.Doc, to display Word documents
            webView.NavigateToString(Encoding.UTF8.GetString(content));
            webView.Visible = true;
        }

        private void DisplayExcel(byte[] content)
        {
            using (var stream = new MemoryStream(content))
            {
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[1];
                    var range = worksheet.Cells[worksheet.Dimension.Address];
                    DataTable dataTable = new DataTable();
                    foreach (var cell in range)
                    {
                        if (cell.Start.Row == 1)
                        {
                            dataTable.Columns.Add(cell.Text);
                        }
                        else
                        {
                            DataRow row = dataTable.NewRow();
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                row[i] = worksheet.Cells[cell.Start.Row, i + 1].Text;
                            }
                            dataTable.Rows.Add(row);
                        }
                    }
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        private async void FollowSubjectForm_Load(object sender, EventArgs e)
        {
            // Initialize WebView2 control
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(webView);
            await webView.EnsureCoreWebView2Async();
            webView.Visible = false;
        }

        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                _subjectRepository.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/
    }
}