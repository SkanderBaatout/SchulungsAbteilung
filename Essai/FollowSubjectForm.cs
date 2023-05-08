using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PdfiumViewer;
using VLC.DotNet.Core;
using VLC.DotNet.Forms;
using OfficeOpenXml;
using Microsoft.Data.SqlClient;
using Serilog;
using System.Data;
using System.Text;
using Essai.Repository;

namespace Essai
{
    public partial class FollowSubjectForm : Form
    {
        private readonly string _connectionString;
        private readonly ILogger _logger;
        private readonly SubjectRepository _subjectRepository;

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

        private async Task LoadSubjectsAsync()
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
                    DisplayVideo(content);
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

        private void DisplayVideo(byte[] content)
        {
            var media = new VlcMedia(new MemoryStream(content));
            var player = new VlcControl();
            player.Dock = DockStyle.Fill;
            player.Media = media;
            player.Play();
            this.Controls.Add(player);
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
            axWebBrowser1.Navigate("about:blank");
            axWebBrowser1.Document.OpenNew(true);
            axWebBrowser1.Document.Write(Encoding.UTF8.GetString(content));
            axWebBrowser1.Refresh();
            axWebBrowser1.Visible = true;
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

        private void FollowSubjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close database connection when form is closed
            _subjectRepository.Dispose();
        }
    }



}