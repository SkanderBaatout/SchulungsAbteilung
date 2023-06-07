using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Essai.Models;

namespace Essai
{
    public partial class ContentForm : Form
    {
        private readonly int _subjectId;
        private readonly List<Content> _contentList;
        private Subject _selectedSubject;


        public ContentForm(Subject selectedSubject)
        {
            InitializeComponent();

            // Set the selectedSubject field
            _selectedSubject = selectedSubject;

            // Create the tablePanel layout
            tableLayoutPanel.ColumnCount = 4;
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel.AutoSize = true;

            // Add the content items to the tablePanel layout
            int row = 0;
            foreach (Content content in selectedSubject.Content)
            {
                // Create the PictureBox control for the content item
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                // Check if the content data is a valid image format
                Image image = null;
                try
                {
                    image = Image.FromStream(new MemoryStream(content.ContentData));
                }
                catch (ArgumentException)
                {
                    // The content data is not a valid image format, do nothing
                }

                if (image != null)
                {
                    pictureBox.Image = image;
                    pictureBox.Tag = content;

                    // Create the Label control for the content title
                    Label titleLabel = new Label();
                    titleLabel.Dock = DockStyle.Fill;
                    titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                    titleLabel.Text = content.ContentTitle;

                    // Add the controls to the tablePanel layout
                    tableLayoutPanel.RowCount++;
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    tableLayoutPanel.Controls.Add(pictureBox, 0, row);
                    tableLayoutPanel.Controls.Add(titleLabel, 1, row);

                    // Add the click event handler to display the content item details
                    pictureBox.Click += PictureBox_Click;

                    row++;
                }
            }
            // Set the size of the form to fit the tablePanel layout
            Size = new Size(tableLayoutPanel.Width + 50, tableLayoutPanel.Height + 100);
        }

        private void FilePathLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the content file in its default associated application when the LinkLabel is clicked
            LinkLabel linkLabel = (LinkLabel)sender;
            try
            {
                System.Diagnostics.Process.Start(linkLabel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Get the selected content item from the PictureBox control and display its details
            PictureBox pictureBox = (PictureBox)sender;
            Content selectedContent = (Content)pictureBox.Tag;

            // Clear the existing controls from the detailsPanel
            detailsPanel.Controls.Clear();

            // Create the PictureBox control for the content item
            PictureBox contentPictureBox = new PictureBox();
            contentPictureBox.Dock = DockStyle.Top;
            contentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            contentPictureBox.Image = Image.FromStream(new MemoryStream(selectedContent.ContentData));
            contentPictureBox.Height = 300;

            // Create the Label control for the content title
            Label titleLabel = new Label();
            titleLabel.Dock = DockStyle.Top;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
            titleLabel.Text = selectedContent.ContentTitle;

            // Create the Label control for the content description
            Label descriptionLabel = new Label();
            descriptionLabel.Dock = DockStyle.Top;
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            descriptionLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            descriptionLabel.Text = _selectedSubject.Description;

            // Create the Label control for the subject title
            Label subjectTitleLabel = new Label();
            subjectTitleLabel.Dock = DockStyle.Top;
            subjectTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            subjectTitleLabel.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold);
            subjectTitleLabel.Text = _selectedSubject.Name;

            // Create the LinkLabel control for the content file path
            LinkLabel filePathLinkLabel = new LinkLabel();
            filePathLinkLabel.Dock = DockStyle.Top;
            filePathLinkLabel.TextAlign = ContentAlignment.MiddleLeft;
            filePathLinkLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            filePathLinkLabel.Text = selectedContent.FilePath;
            filePathLinkLabel.LinkClicked += FilePathLinkLabel_LinkClicked;

            // Add the controls to the detailsPanel
            detailsPanel.Controls.Add(contentPictureBox);
            detailsPanel.Controls.Add(titleLabel);
            detailsPanel.Controls.Add(descriptionLabel);
            detailsPanel.Controls.Add(subjectTitleLabel);
            detailsPanel.Controls.Add(filePathLinkLabel);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}