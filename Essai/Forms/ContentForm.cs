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

namespace Essai
{
    public partial class ContentForm : Form
    {
        private List<Content> contentList;

        public ContentForm(List<Content> contentList, Content selectedContent)
        {
            InitializeComponent();

            // Set the DataSource of the contentDataGridView to the contentList
            this.contentList = contentList;
            contentDataGridView.DataSource = contentList;

            // Select the specified content item by default, or the first item if none was specified
            if (selectedContent != null && contentList.Contains(selectedContent))
            {
                contentDataGridView.CurrentCell = contentDataGridView.Rows[contentList.IndexOf(selectedContent)].Cells[0];
            }
            else if (contentList.Count > 0)
            {
                contentDataGridView.CurrentCell = contentDataGridView.Rows[0].Cells[0];
            }
        }
        private void OpenContent(Content content)
        {
            // Define a dictionary to map ContentType values to open methods
            Dictionary<string, Action<string>> openMethods = new Dictionary<string, Action<string>>
{
    { ContentType.Document.ToString(), OpenDocument },
    { ContentType.Image.ToString(), OpenImage },
    { ContentType.Video.ToString(), OpenVideo },
    { ContentType.Other.ToString(), OpenFile }
};

            // Get the open method for the content type, or show an error message if it's invalid
            if (openMethods.TryGetValue(content.ContentType.ToString(), out Action<string> openMethod))
            {
                openMethod(content.FilePath);
            }
            else
            {
                MessageBox.Show("Invalid content type.");
            }
        }
        private void OpenDocument(string path)
        {
            // Open the document in Microsoft Word
            try
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                word.Documents.Open(path);
                word.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening document: " + ex.Message);
            }
        }

        private void OpenImage(string path)
        {
            // Open the image in Windows Photo Viewer
            try
            {
                Process.Start("rundll32.exe", $"\"{Environment.GetEnvironmentVariable("SystemRoot")}\\System32\\shimgvw.dll\",ImageView_Fullscreen {path}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening image: " + ex.Message);
            }
        }

        private void OpenVideo(string path)
        {
            // Open the video in VLC player
            try
            {
                Vlc.DotNet.Forms.VlcControl vlcControl = new Vlc.DotNet.Forms.VlcControl();
                vlcControl.Dock = DockStyle.Fill;
                Controls.Add(vlcControl);
                vlcControl.Play(new Uri(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening video: " + ex.Message);
            }
        }

        private void OpenFile(string path)
        {
            // Open the file in its default associated application
            try
            {
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contentDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected content item from the DataGridView and open it
            if (e.RowIndex >= 0 && e.RowIndex < contentList.Count)
            {
                Content selectedContent = contentList[e.RowIndex];
                OpenContent(selectedContent);
            }
        }
    }
}