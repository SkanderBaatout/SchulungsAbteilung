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

namespace Essai.Forms
{
    public partial class GalleryForm : Form
    {

        private readonly SubjectDataAccess subjectDataAccess;

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

            // Retrieve the media content data from the database
            List<Content> mediaContentList = new List<Content>();

            if (!string.IsNullOrWhiteSpace(subjectNameFilter))
            {
                // Retrieve the subject ID by name
                Subject subject = subjectDataAccess.GetSubjectByName(subjectNameFilter);

                if (subject != null && subject.IsActive)
                {
                    // Retrieve the media content for the subject and content type filter
                    mediaContentList = subjectDataAccess.GetMediaContentList(subject.Id, contentTypeFilter);
                }
            }
            else
            {
                // Retrieve all active subjects and their media content for the content type filter
                List<Subject> subjectList = subjectDataAccess.GetActiveSubjectList();
                foreach (Subject subject in subjectList)
                {
                    List<Content> contentList = subjectDataAccess.GetMediaContentList(subject.Id, contentTypeFilter);
                    mediaContentList.AddRange(contentList);
                }
            }
            // Filter the media content list based on the current page and page size
            totalRecords = mediaContentList.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);
            mediaContentList = mediaContentList.GetRange(startIndex, endIndex - startIndex);

            // Clear the existing controls from the TableLayoutPanel
            tableLayoutPanel.Controls.Clear();

            // Set the number of rows and columns in the TableLayoutPanel
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.RowCount = 2;

            // Set the size of each cell in the TableLayoutPanel
            int cellWidth = (tableLayoutPanel.ClientSize.Width - tableLayoutPanel.Margin.Horizontal) / tableLayoutPanel.ColumnCount;
            int cellHeight = (tableLayoutPanel.ClientSize.Height - tableLayoutPanel.Margin.Vertical) / tableLayoutPanel.RowCount;
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellWidth));
            }
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, cellHeight));
            }

            // Add a new control for each content item
            int row = 0;
            int col = 0;
            foreach (Content content in mediaContentList)
            {
                if (content.ContentType == "Images")
                {
                    // Create a new PictureBox control to display the image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = Image.FromStream(new MemoryStream(content.ContentData));

                    // Add the subject name and added date to the PictureBox
                    pictureBox.Tag = content;
                    pictureBox.Click += ContentPictureBox_Click;
                    tableLayoutPanel.Controls.Add(pictureBox, col, row);
                }
                else
                {
                    //Create a new Button control with the content title and subject name as the text
                    Button button = new Button();
                    button.Text = content.ContentTitle + " (" + content.SubjectId + ")";
                    button.Tag = content;
                    button.Click += ContentButton_Click;

                    // Add the added date to the button as a tooltip
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(button, "Added on " + content.DateAdded.ToString("MMM d, yyyy"));

                    tableLayoutPanel.Controls.Add(button, col, row);
                }

                // Increment the row andcolumn counters
                col++;
                if (col == tableLayoutPanel.ColumnCount)
                {
                    col = 0;
                    row++;
                }
            }
            // Update the paging controls
            totalRecordsLabel.Text = "Total records: " + totalRecords;

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
    }
}