using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Essai.Models;
using Vlc.DotNet.Forms;

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

            _selectedSubject = selectedSubject;

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
                    Image image = Image.FromStream(new MemoryStream(content.ContentData));
                    pictureBox.Image = image;
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

            Control contentControl = null;

            if (selectedContent.ContentType == "Images")
            {
                PictureBox imagePictureBox = new PictureBox();
                imagePictureBox.Dock = DockStyle.Top;
                imagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                imagePictureBox.Image = Image.FromStream(new MemoryStream(selectedContent.ContentData));
                imagePictureBox.Height = 300;
                contentControl = imagePictureBox;
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
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}