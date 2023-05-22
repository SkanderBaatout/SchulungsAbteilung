using Essai.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace Essai.Forms
{
    public partial class EditSubjectForm : Form
    {
        private string contentFilePath = "";

        public Subject Subject { get; set; }

        public EditSubjectForm(Subject subject)
        {
            InitializeComponent();
            Subject = subject;

            subjectTb.Text = subject.Name;
            descriptionTB.Text = subject.Description;
            contentTypeCB.SelectedItem = subject.ContentType;
            dateTimePicker.Value = subject.DateAdded;
            isActiveCheckBox.Checked = subject.IsActive;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectTb.Text) || string.IsNullOrWhiteSpace(descriptionTB.Text) ||
                contentTypeCB.SelectedItem == null || string.IsNullOrWhiteSpace(contentTypeCB.SelectedItem.ToString()))
            {
                MessageBox.Show("Please enter a name, description, and content type.");
                return;
            }

            Subject.Name = subjectTb.Text;
            Subject.Description = descriptionTB.Text;
            Subject.ContentType = contentTypeCB.SelectedItem.ToString();
            Subject.DateAdded = dateTimePicker.Value;
            Subject.IsActive = isActiveCheckBox.Checked;

            if (Subject.Content == null)
            {
                Subject.Content = new Content();
            }

            Subject.Content.ContentData = File.ReadAllBytes(contentFilePath);
            Subject.Content.ContentTitle = Path.GetFileName(contentFilePath);

            DialogResult = DialogResult.OK;
            Close();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (contentTypeCB.SelectedItem != null)
            {
                switch (contentTypeCB.SelectedItem.ToString())
                {
                    case "Docs":
                        openFileDialog.Filter = "Word Documents|*.doc;*.docx|PDF Files|*.pdf";
                        break;
                    case "Images":
                        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                        break;
                    case "Videos":
                        openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.wmv;*.mov";
                        break;
                    default:
                        openFileDialog.Filter = "All Files|*.*";
                        break;
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    contentFilePath = openFileDialog.FileName;
                    contentPathLabel.Text = Path.GetFileName(contentFilePath);
                }
            }
        }
    }
}