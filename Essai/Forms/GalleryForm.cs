using Essai.DataAccess;
using Essai.Models;
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
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml.Math;
using WMPLib;
using Vlc.DotNet.Forms;
using System.IO;
using Vlc.DotNet.Core;
using Azure;

namespace Essai.Forms
{
    public partial class GalleryForm : Form
    {
        private readonly SubjectDataAccess subjectDataAccess;
        private List<Subject> subjectList;

        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private int totalPages = 0;

        public GalleryForm()
        {
            InitializeComponent();
            subjectDataAccess = new SubjectDataAccess("data source = SKANDERBAATOUT;database = quiz ;integrated security = True ; TrustServerCertificate=True");

            // Initialize the VLC engine
            var vlcLibDirectory = new DirectoryInfo(@"C:\Program Files\VideoLAN\VLC\");

            // Populate the ContentType filter ComboBox with the available content types
            contentTypeCB.Items.Add("All");
            contentTypeCB.Items.Add("Docs");
            contentTypeCB.Items.Add("Images");
            contentTypeCB.Items.Add("Videos");
            contentTypeCB.Items.Add("Other");
            contentTypeCB.SelectedIndex = 0;

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // Get the filter values from the controls
            string subjectNameFilter = subjectNameFilterTB.Text.Trim();
            string contentTypeFilter = contentTypeCB.SelectedItem.ToString();

            // Retrieve the subjects and their contents from the database
            subjectList = subjectDataAccess.GetAllSubjects().Where(s => s.IsActive).ToList(); // Use GetAllSubjectList() instead of GetActiveSubjectList()
            List<Subject> filteredSubjectList = new List<Subject>();
            foreach (Subject subject in subjectList)
            {
                if (string.IsNullOrWhiteSpace(subjectNameFilter) || subject.Name.Contains(subjectNameFilter))
                {
                    List<Content> contentList = subjectDataAccess.GetMediaContentList(subject.Id, contentTypeFilter);
                    if (contentList.Count > 0)
                    {
                        subject.Content = contentList; // Add the contents to the subject object
                        filteredSubjectList.Add(subject);
                    }
                }
            }

            // Filter the subject list based on the current page and page size
            totalRecords = filteredSubjectList.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);
            filteredSubjectList = filteredSubjectList.GetRange(startIndex, endIndex - startIndex);

            // Clear the existing controls from the TableLayoutPanel
            tableLayoutPanel.Controls.Clear();

            // Set the number of rows and columns in the TableLayoutPanel
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = filteredSubjectList.Count;

            // Set the size of each cell in the TableLayoutPanel
            int cellWidth = (tableLayoutPanel.ClientSize.Width - tableLayoutPanel.Margin.Horizontal) / tableLayoutPanel.ColumnCount;
            int cellHeight = (tableLayoutPanel.ClientSize.Height - tableLayoutPanel.Margin.Vertical) / tableLayoutPanel.RowCount;
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellWidth));
            for (int i = 0; i < filteredSubjectList.Count; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, cellHeight));
            }

            // Add a new control for each subject
            int row = 0;
            foreach (Subject subject in filteredSubjectList)
            {
                // Create a new Button control with the subject name as the text
                Button subjectButton = new Button();
                subjectButton.Text = subject.Name;
                subjectButton.Tag = subject;
                subjectButton.Click += SubjectButton_Click;

                tableLayoutPanel.Controls.Add(subjectButton, 0, row);
                row++;
            }

            // Update the page information labels
            //  pageLabel.Text = $"Page {currentPage} of {totalPages}";
            totalRecordsLabel.Text = $"{totalRecords} records found";
        }
        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
            // Reset the current page to 1 when filters are applied
            currentPage = 1;

            RefreshDataGridView();
        }

        private void ContentButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Content content = button.Tag as Content;

            if (content != null)
            {
                if (videoPlayerControl != null && content.ContentPath != null && content.ContentType == "Videos")
                {
                    // Play the video using VLC
                    Form videoForm = new Form();
                    videoForm.StartPosition = FormStartPosition.CenterParent;
                    videoForm.FormBorderStyle = FormBorderStyle.FixedDialog;

                    // Create a new Vlc.DotNet.Forms.VlcControl instance
                    Vlc.DotNet.Forms.VlcControl videoPlayerVlcControl = new Vlc.DotNet.Forms.VlcControl();
                    Debug.WriteLine("vlcControl: " + videoPlayerVlcControl);

                    videoPlayerVlcControl.Dock = DockStyle.Fill;
                    videoForm.Controls.Add(videoPlayerVlcControl);

                    // Set the VlcLibDirectory property to the directory where the VLC libraries are installed
                    videoPlayerVlcControl.VlcLibDirectory = new DirectoryInfo(@"C:\Program Files\VideoLAN\VLC\");

                    // Subscribe to the Playing event to start playing the video once it has been loaded
                    videoPlayerVlcControl.Playing += (sender, args) =>
                    {
                        // Set the size of the form based onthe size of the video
                        videoForm.ClientSize = new Size(640, 480);

                        // Show the form
                        videoForm.ShowDialog();
                    };

                    // Load the video file and prepare it for playback
                    videoPlayerVlcControl.SetMedia(new Uri(content.ContentPath));
                    videoPlayerVlcControl.Play();
                }
                else if (content.ContentType == "Docs")
                {
                    // Open the document using Microsoft Word
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    Document doc = wordApp.Documents.Open(content.ContentPath);
                    doc.Activate();
                    wordApp.Visible = true;
                }
                else
                {
                    // Open the content using the default program for its file type
                    Process.Start(content.ContentPath);
                }
            }
        }
        private void ContentPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Content content = pictureBox.Tag as Content;

            if (content != null)
            {
                // Create a new form to display the image
                Form imageForm = new Form();
                imageForm.StartPosition = FormStartPosition.CenterParent;
                imageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                imageForm.MaximizeBox = false;
                imageForm.MinimizeBox = false;
                imageForm.Text = content.ContentTitle;

                // Create a new PictureBox control to display the image
                PictureBox bigPictureBox = new PictureBox();
                bigPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                bigPictureBox.Image = Image.FromStream(new MemoryStream(content.ContentData));
                bigPictureBox.Dock = DockStyle.Fill;
                imageForm.Controls.Add(bigPictureBox);

                // Create a new Label control to display the subject name and added date
                Label infoLabel = new Label();
                infoLabel.Text = "Subject: " + content.SubjectId + "\r\nAdded on: " + content.DateAdded.ToString("MMM d, yyyy");
                infoLabel.Dock = DockStyle.Bottom;
                infoLabel.TextAlign = ContentAlignment.MiddleCenter;
                infoLabel.BackColor = Color.LightGray;
                infoLabel.Height = 50;
                imageForm.Controls.Add(infoLabel);

                // Set the size of the form based on the size of the image
                imageForm.ClientSize = new Size(bigPictureBox.Image.Width, bigPictureBox.Image.Height + infoLabel.Height);

                // Show the form
                imageForm.ShowDialog();
            }
        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {
            // Get the selected subject from the Tag property of the button
            Button subjectButton = (Button)sender;
            Subject subject = (Subject)subjectButton.Tag;


            // Create a new ContentForm and pass the contents of the selected subject to it
            ContentForm contentForm = new ContentForm(subject.Content, null);
            contentForm.ShowDialog();
        }
        private void UrlButton_Click(object sender, EventArgs e)
        {

            // Get the selected content from the button tag
            Content selectedContent = (Content)((Button)sender).Tag;

            // Play the content using VLC
            var vlcPlayer = new VlcControl();
            vlcPlayer.VlcLibDirectoryNeeded += (sender, args) =>
            {
                args.VlcLibDirectory = new DirectoryInfo(@"C:\Program Files\VideoLAN\VLC\");
            };
            Controls.Add(vlcPlayer);
            vlcPlayer.SetMedia(new Uri(selectedContent.FilePath));
            vlcPlayer.Play();
        }
    }
}