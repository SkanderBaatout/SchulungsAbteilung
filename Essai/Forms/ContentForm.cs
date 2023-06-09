using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Essai.Models;
using Essai.Utils;
using Microsoft.Data.SqlClient;
using Syncfusion.Windows.Forms.PdfViewer;
using Vlc.DotNet.Forms;

namespace Essai
{
    public partial class ContentForm : Form
    {
        private readonly int _subjectId;
        private int _employeeId;

        private readonly List<Content> _contentList;
        private Subject _selectedSubject;

        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";

        public ContentForm(int employeeId, int subjectId, Subject selectedSubject)
        {
            InitializeComponent();

            _selectedSubject = selectedSubject;
            _employeeId = employeeId;

            _subjectId = subjectId;

            // Load the content list for the selected subject
            _contentList = selectedSubject.Content;

            // Calculate the progress percentage for the current employee and subject
            int numViewedContents = GetNumViewedContents(employeeId, subjectId);
            int totalNumContents = _contentList.Count;
            int progressPercentage = (int)Math.Round(((double)numViewedContents / totalNumContents) * 100);

            // Display the progress percentage using a progress bar
            progressBar.Value = progressPercentage;
            progressBarLabel.Text = numViewedContents + " out of " + totalNumContents + " contents viewed (" + progressPercentage + "%)";

            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoScroll = true; // add scroll bar to the table layout panel

            int row = 0;
            tableLayoutPanel.RowCount = 1; // initialize to 1 row
            foreach (Content content in selectedSubject.Content)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                if (content.ContentType == "Images")
                {
                    if (content.ContentData?.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(content.ContentData))
                            {
                                SerializableImage serializableImage = new SerializableImage(System.Drawing.Image.FromStream(ms));
                                pictureBox.Image = serializableImage.GetImage(pictureBox.Width, pictureBox.Height);
                            }
                        }
                        catch (Exception ex)
                        {
                            // Log the error or display an error message
                            Console.WriteLine("Error loading image: " + ex.Message);
                        }
                    }
                }
                else
                {
                    // Set a default image for non-image content types
                    if (content.ContentType == "Videos")
                    {
                        pictureBox.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\C#\Essai\Essai\bin\Debug\net6.0-windows\vlc.jpg");
                    }
                    else if (content.ContentType == "Docs")
                    {
                        pictureBox.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\C#\Essai\Essai\bin\Debug\net6.0-windows\docs.png");
                    }
                    else
                    {
                        pictureBox.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\C#\Essai\Essai\bin\Debug\net6.0-windows\pdf.png");
                    }
                }

                pictureBox.Tag = content;

                Label titleLabel = new Label();
                titleLabel.Dock = DockStyle.Fill;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Text = content.ContentTitle;

                tableLayoutPanel.RowCount++;
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                tableLayoutPanel.Controls.Add(pictureBox, 0, row);
                tableLayoutPanel.Controls.Add(titleLabel, 1, row);

                pictureBox.Click += PictureBox_Click;

                row++;
            }
            Size = new Size(tableLayoutPanel.Width + 50, tableLayoutPanel.Height + 100);
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Content selectedContent = (Content)control.Tag;

            detailsPanel.Controls.Clear();

            // Update viewed contents in database
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Check if the employee progression record exists
                SqlCommand selectCommand = new SqlCommand("SELECT ViewedContents FROM EmployeeProgression WHERE EmployeeId = @employeeId AND SubjectId = @subjectId", connection);
                selectCommand.Parameters.AddWithValue("@employeeId", _employeeId);
                selectCommand.Parameters.AddWithValue("@subjectId", _subjectId);
                SqlDataReader reader = selectCommand.ExecuteReader();

                string viewedContents = null;
                if (reader.Read())
                {
                    viewedContents = reader.GetString(0);
                }
                reader.Close();

                // Update the viewed contents list
                List<int> viewedContentIds = viewedContents?.Split(',').Select(int.Parse).ToList() ?? new List<int>();
                if (!viewedContentIds.Contains(selectedContent.ContentId))
                {
                    viewedContentIds.Add(selectedContent.ContentId);

                    string viewedContentsStr = string.Join(",", viewedContentIds);
                    SqlCommand updateCommand = new SqlCommand("IF EXISTS(SELECT 1 FROM EmployeeProgression WHERE EmployeeId = @employeeId AND SubjectId = @subjectId) " +
                                                                "UPDATE EmployeeProgression SET ViewedContents = @viewedContents WHERE EmployeeId = @employeeId AND SubjectId = @subjectId " +
                                                                "ELSE " +
                                                                "INSERT INTO EmployeeProgression (EmployeeId, SubjectId, ViewedContents) VALUES (@employeeId, @subjectId, @viewedContents)", connection);
                    updateCommand.Parameters.AddWithValue("@employeeId", _employeeId);
                    updateCommand.Parameters.AddWithValue("@subjectId", _subjectId);
                    updateCommand.Parameters.AddWithValue("@viewedContents", viewedContentsStr);
                    updateCommand.ExecuteNonQuery();
                }
            }
            Control contentControl = null;

            if (selectedContent.ContentType == "Images")
            {
                if (selectedContent.ContentData?.Length > 0)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(selectedContent.ContentData))
                        {
                            SerializableImage serializableImage = new SerializableImage(Image.FromStream(ms));
                            PictureBox imagePictureBox = new PictureBox();
                            imagePictureBox.Dock = DockStyle.Top;
                            imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            imagePictureBox.Image = serializableImage.GetImage(detailsPanel.Width, 300);
                            imagePictureBox.Height = 300;
                            contentControl = imagePictureBox;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the error or display an error message
                        Console.WriteLine("Error loading image: " + ex.Message);
                    }
                }
            }
            else if (selectedContent.ContentType == "Videos")
            {
                VlcControl vlcControl = new VlcControl();
                vlcControl.Dock = DockStyle.Top;
                vlcControl.Play(new Uri(Path.GetTempFileName()).AbsolutePath);
                MemoryStream videoStream = new MemoryStream(selectedContent.ContentData);
                vlcControl.SetMedia(videoStream);
                contentControl = vlcControl;
            }
            else if (selectedContent.ContentType == "Docs")
            {
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Dock = DockStyle.Top;
                webBrowser.DocumentStream = new MemoryStream(selectedContent.ContentData);
                contentControl = webBrowser;
            }
            else if (selectedContent.ContentType == "Other")
            {
                PdfViewerControl pdfViewerControl = new PdfViewerControl();
                pdfViewerControl.Dock = DockStyle.Top;
                MemoryStream pdfStream = new MemoryStream(selectedContent.ContentData);
                pdfViewerControl.Load(pdfStream);
                pdfViewerControl.Height = 300;

                Panel scrollPanel = new Panel();
                scrollPanel.Dock = DockStyle.Top;
                scrollPanel.AutoScroll = true;
                scrollPanel.Height = 300;
                scrollPanel.Controls.Add(pdfViewerControl);
                pdfViewerControl.Dock = DockStyle.Top;
                pdfViewerControl.Width = scrollPanel.Width - SystemInformation.VerticalScrollBarWidth;

                contentControl = scrollPanel;
            }
            else
            {
                TextBox contentTextBox = new TextBox();
                contentTextBox.Dock = DockStyle.Top;
                contentTextBox.Multiline = true;
                contentTextBox.ScrollBars = ScrollBars.Vertical;
                contentTextBox.Text = Encoding.UTF8.GetString(selectedContent.ContentData);
                contentControl = contentTextBox;
            }

            Label descriptionLabel = new Label();
            descriptionLabel.Dock = DockStyle.Top;
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            descriptionLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            descriptionLabel.Text = _selectedSubject.Description;

            Label subjectTitleLabel = new Label();
            subjectTitleLabel.Dock = DockStyle.Top;
            subjectTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            subjectTitleLabel.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            subjectTitleLabel.Text = _selectedSubject.Name;

            detailsPanel.Controls.Add(contentControl);
            detailsPanel.Controls.Add(new Label() { Dock = DockStyle.Top, Height = 20 });
            detailsPanel.Controls.Add(descriptionLabel);
            detailsPanel.Controls.Add(new Label() { Dock = DockStyle.Top, Height = 20 });
            detailsPanel.Controls.Add(subjectTitleLabel);
        }
        private int GetNumViewedContents(int employeeId, int subjectId)
        {
            int numViewedContents = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ViewedContents FROM EmployeeProgression WHERE EmployeeId = @employeeId AND SubjectId = @subjectId", connection);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                command.Parameters.AddWithValue("@subjectId", subjectId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string viewedContentIdsStr = reader.GetString(0);
                    List<int> viewedContentIds = viewedContentIdsStr.Split(',').Select(int.Parse).ToList();
                    numViewedContents = _contentList.Count(c => viewedContentIds.Contains(c.ContentId));
                }
                reader.Close();
            }

            return numViewedContents;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}