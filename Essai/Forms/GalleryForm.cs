using Essai.DataAccess;
using Essai.Models;
using Microsoft.VisualBasic;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai.Forms
{
    public partial class GalleryForm : Form
    {
        private readonly SubjectDataAccess _subjectDataAccess;
        private readonly int _subjectId;
        private List<Content> _contents;
        private ListView listViewContents;
        private PictureBox pictureBoxContent;
        private Button buttonAdd;
        private Button buttonView;
        private Button buttonEdit;
        private Button buttonDelete;
        private int _pageSize = 10;
        private int _currentPage = 1;

        public GalleryForm(SubjectDataAccess subjectDataAccess, int subjectId)
        {
            InitializeComponent();

            _subjectDataAccess = subjectDataAccess;
            _subjectId = subjectId;


            _contents = new List<Content>();

            // Create the controls
            listViewContents = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                HideSelection = false,
                MultiSelect = false,
                Dock = DockStyle.Fill
            };
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonView = new Button();


            listViewContents.Columns.Add("Type", 100);
            listViewContents.Columns.Add("Title", 200);
            listViewContents.Columns.Add("Date Added", 120);
            listViewContents.SelectedIndexChanged += ListViewContents_SelectedIndexChanged;

            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;

           
            buttonAdd.Click += ButtonAdd_Click;

           
            buttonView.Click += ButtonView_Click;

           
            buttonEdit.Click += ButtonEdit_Click;

            buttonChangeFile.Click += buttonChangeFile_Click;

          
            buttonDelete.Click += ButtonDelete_Click;

            // Add the controls to the form
            Controls.Add(tableLayoutPanel);
            Controls.Add(buttonAdd);
            Controls.Add(buttonView);
            Controls.Add(buttonEdit);
            Controls.Add(buttonChangeFile);
            Controls.Add(buttonDelete);

            // Load the contents
            LoadContents();
        }

        private async void LoadContents()
        {
            try
            {
                _contents = await _subjectDataAccess.GetContentsBySubjectIdAsync(_subjectId);

                // Clear the ListView to avoid duplicates
                listViewContents.Items.Clear();

                // Add each content item to the ListView
                foreach (var content in _contents)
                {
                    var item = new ListViewItem(new[] { content.ContentType, content.ContentTitle, content.DateAdded.ToString() });
                    item.Tag = content;
                    listViewContents.Items.Add(item);
                }
                // Update the filter ComboBox
                UpdateFilterComboBox();

                // Update the navigation buttons
                UpdateNavigationButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the contents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFilterComboBox()
        {
            // Get the distinct content types
            var contentTypes = _contents.Select(c => c.ContentType).Distinct().ToList();

            // Update the filter ComboBox
            comboBox.SelectedIndex = -1;
            comboBox.Items[0] = $"All ({_contents.Count})";
            for (int i = 1; i < comboBox.Items.Count; i++)
            {
                var contentType = comboBox.Items[i].ToString();
                var count = _contents.Count(c => c.ContentType.StartsWith(contentType));
                comboBox.Items[i] = $"{contentType} ({count})";
            }
        }

        private void UpdateNavigationButtons()
        {
            // Enable or disable the navigation buttons based on the current page and pageSize
            buttonView.Enabled = listViewContents.SelectedItems.Count > 0;
            buttonEdit.Enabled = listViewContents.SelectedItems.Count > 0;
            buttonChangeFile.Enabled = listViewContents.SelectedItems.Count > 0;
            buttonDelete.Enabled = listViewContents.SelectedItems.Count > 0;

            var pageCount = (int)Math.Ceiling((double)_contents.Count / _pageSize);
            var startIndex = (_currentPage - 1) * _pageSize + 1;
            var endIndex = Math.Min(startIndex + _pageSize - 1, _contents.Count);
            var count = endIndex - startIndex + 1;

            buttonView.Text = $"View ({count})";
            buttonEdit.Text = $"Edit ({count})";
            buttonChangeFile.Text = $"Change File ({count})";
            buttonDelete.Text = $"Delete ({count})";

            buttonView.Enabled = buttonView.Enabled && _currentPage <= pageCount;
            buttonEdit.Enabled = buttonEdit.Enabled && _currentPage <= pageCount;
            buttonChangeFile.Enabled = buttonChangeFile.Enabled && _currentPage <= pageCount;
            buttonDelete.Enabled = buttonDelete.Enabled && _currentPage <= pageCount;
        }

        private void ListViewContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewContents.SelectedItems.Count > 0)
            {
                var selectedContent = (Content)listViewContents.SelectedItems[0].Tag;

                // Check if the selected content is an audio file
                if (selectedContent.ContentType.StartsWith("audio"))
                {
                    // Use Naudio to play the audio file
                    using (var audioStream = new MemoryStream(selectedContent.ContentData))
                    {
                        var waveOut = new WaveOut();
                        var waveStream = new WaveFileReader(audioStream);
                        waveOut.Init(waveStream);
                        waveOut.Play();
                    }
                }
                else if (selectedContent.ContentType.StartsWith("video"))
                {
                    // Use another library to play the video file
                }
                else if (selectedContent.ContentType.StartsWith("image"))
                {
                    // Use a PictureBox or other control to display the image file
                    // For example, you can use the following code to display a PNG or JPG image:
                    var imageStream = new MemoryStream(selectedContent.ContentData);
                    var image = Image.FromStream(imageStream);
                    pictureBoxContent.Image = image;
                }

                // Update the navigation buttons
                UpdateNavigationButtons();
            }
            else
            {
                // Clear the multimedia display if no content is selected
                pictureBoxContent.Image = null;

                // Update the navigation buttons
                UpdateNavigationButtons();
            }
        }



        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select a multimedia file
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Multimedia Files (*.mp3;*.mp4;*.png;*.jpg)|*.mp3;*.mp4;*.png;*.jpg",
                Title = "Select a multimedia file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the file contents as a byte array
                var contentData = System.IO.File.ReadAllBytes(openFileDialog.FileName);

                // Create a new Content object with the selected file
                var contentType = Path.GetExtension(openFileDialog.FileName).ToLower();
                var contentTitle = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                var content = new Content
                {
                    ContentType = contentType,
                    ContentTitle = contentTitle,
                    ContentData = contentData,
                    DateAdded = DateTime.Now,
                    SubjectId = _subjectId
                };

                try
                {
                    // Save the new content to the database
                    _subjectDataAccess.InsertContent(content);

                    // Add the new content to the list and select it
                    _contents.Add(content);
                    var item = new ListViewItem(new[] { content.ContentType, content.ContentTitle, content.DateAdded.ToString() });
                    item.Tag = content;
                    listViewContents.Items.Add(item);
                    listViewContents.Items[listViewContents.Items.Count - 1].Selected = true;

                    // Update the filter ComboBox
                    UpdateFilterComboBox();

                    // Update the navigation buttons
                    UpdateNavigationButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Confirm with the user before deleting the selected content
            var confirmResult = MessageBox.Show("Are you sure you want to delete this content?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var selectedContent = (Content)listViewContents.SelectedItems[0].Tag;

                    // Delete the selected content from the database
                    await _subjectDataAccess.DeleteContentByIdAsync(selectedContent.ContentId);

                    // Remove the selected content from the list and clear the multimedia display
                    _contents.Remove(selectedContent);
                    listViewContents.Items.Remove(listViewContents.SelectedItems[0]);
                    pictureBoxContent.Image = null;

                    // Update the filter ComboBox
                    UpdateFilterComboBox();

                    // Update the navigation buttons
                    UpdateNavigationButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var selectedContent = (Content)listViewContents.SelectedItems[0].Tag;

            // Allow the user to edit the title of the selected content
            var newTitle = Interaction.InputBox("Enter a new title for the content:", "Edit Title", selectedContent.ContentTitle);
            if (!string.IsNullOrEmpty(newTitle))
            {
                try
                {
                    // Update the title of the selected content in the database
                    selectedContent.ContentTitle = newTitle;
                    _subjectDataAccess.UpdateContent(selectedContent);

                    // Update the title of the selected content in the list
                    listViewContents.SelectedItems[0].SubItems[1].Text = newTitle;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while editing the content: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            if (listViewContents.SelectedItems.Count > 0)
            {
                var selectedContent = (Content)listViewContents.SelectedItems[0].Tag;

                // Save the content data to a temporary file
                string tempFilePath = Path.GetTempFileName();
                File.WriteAllBytes(tempFilePath, selectedContent.ContentData);

                // Open the file using the default application associated with its file type
                System.Diagnostics.Process.Start(tempFilePath);
            }
        }
        private void buttonChangeFile_Click(object sender, EventArgs e)
        {
            var selectedContent = (Content)listViewContents.SelectedItems[0].Tag;


            // Allow the user to select a new multimedia file
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Multimedia Files (*.mp3;*.mp4;*.png;*.jpg)|*.mp3;*.mp4;*.png;*.jpg",
                Title = "Select a new multimedia file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the file contents as a byte array
                var newContentData = System.IO.File.ReadAllBytes(openFileDialog.FileName);

                // Update the selected content with the new file
                try
                {
                    selectedContent.ContentType = Path.GetExtension(openFileDialog.FileName).ToLower();
                    selectedContent.ContentTitle = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    selectedContent.ContentData = newContentData;
                    selectedContent.DateAdded = DateTime.Now;

                    // Update the selected content in the database
                    _subjectDataAccess.UpdateContent(selectedContent);

                    // Update the selected content in the list and select it
                    listViewContents.SelectedItems[0].SubItems[0].Text = selectedContent.ContentType;
                    listViewContents.SelectedItems[0].SubItems[1].Text = selectedContent.ContentTitle;
                    listViewContents.SelectedItems[0].SubItems[2].Text = selectedContent.DateAdded.ToString();
                    listViewContents.SelectedItems[0].Tag = selectedContent;

                    // Update the navigation buttons
                    UpdateNavigationButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while changing the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContents();
        }
    }
}