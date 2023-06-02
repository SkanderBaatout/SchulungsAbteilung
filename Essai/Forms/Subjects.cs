using DocumentFormat.OpenXml.Wordprocessing;
using Essai.DataAccess;
using Essai.Forms;
using Essai.Models;
using Microsoft.Office.Interop.Excel;
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
using DataTable = System.Data.DataTable;

namespace Essai
{
    public partial class Subjects : Form
    {
        private int currentSubjectId = 0;
        private string contentFilePath = "";

        private readonly SubjectDataAccess subjectDataAccess;

        public Subjects()
        {
            InitializeComponent();

            subjectDataAccess = new SubjectDataAccess("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");

            DisplaySubjects();
            contentTypeCB.Items.Add("Docs");
            contentTypeCB.Items.Add("Images");
            contentTypeCB.Items.Add("Videos");
            contentTypeCB.Items.Add("Other");

            subjectsList.Columns[0].Visible = false;


            contentPathLabel.Visible = false;

        }

        private void DisplaySubjects()
        {
            List<Subject> subjects = subjectDataAccess.GetAllSubjects();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("ContentType");
            dataTable.Columns.Add("DateAdded");
            dataTable.Columns.Add("IsActive");
            dataTable.Columns.Add("ContentTitle");

            foreach (Subject subject in subjects)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = subject.Id;
                row["Name"] = subject.Name;
                row["Description"] = subject.Description;
                row["ContentType"] = subject.ContentType;
                row["DateAdded"] = subject.DateAdded.ToString("yyyy-MM-dd");
                row["IsActive"] = subject.IsActive;

                if (subject.Content != null)
                {
                    row["ContentTitle"] = subject.Content.ContentTitle;
                }

                dataTable.Rows.Add(row);
            }

            subjectsList.DataSource = dataTable;
        }
        private void ResetForm()
        {
            subjectTb.Clear();
            descriptionTB.Clear();
            contentTypeCB.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
            isActiveCheckBox.Checked = true;
            contentFilePath = "";
            contentPathLabel.Text = "";
            currentSubjectId = 0;

            savebtn.Text = "Add";
            deleteButton.Enabled = false;
        }
        private void loadBtn_Click(object sender, EventArgs e)
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
                        openFileDialog.Filter = "ImageFiles|*.jpg;*.jpeg;*.png;*.gif";
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
                    contentPathLabel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a content type first.");
            }
        }

        private async void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectTb.Text) || string.IsNullOrWhiteSpace(descriptionTB.Text) ||
                contentTypeCB.SelectedItem == null || string.IsNullOrWhiteSpace(contentTypeCB.SelectedItem.ToString()))
            {
                MessageBox.Show("Please enter a name, description, and content type.");
                return;
            }

            // Disable the "Save" button to prevent multiple clicks
            savebtn.Enabled = false;

            try
            {
                // Create a new Subject object
                Subject subject = new Subject
                {
                    Name = subjectTb.Text,
                    Description = descriptionTB.Text,
                    ContentType = contentTypeCB.SelectedItem.ToString(),
                    DateAdded = dateTimePicker.Value,
                    IsActive = isActiveCheckBox.Checked,
                    Content = new Content() // Initialize Content to an empty Content object
                };

                // If a content file was selected, read its data and create a Content object
                if (!string.IsNullOrWhiteSpace(contentFilePath))
                {
                    byte[] contentData = File.ReadAllBytes(contentFilePath);
                    string contentTitle = Path.GetFileName(contentFilePath);

                    Content content = new Content
                    {
                        ContentId = 0, // The ContentId will be automatically generated by the database
                        SubjectId = 0, // The SubjectId will be set later
                        ContentType = contentTypeCB.SelectedItem.ToString(),
                        ContentTitle = contentTitle,
                        ContentData = contentData
                    };

                    subject.Content = content;
                }

                // Save the subject and content data to the database
                int subjectId = await Task.Run(() => subjectDataAccess.InsertSubject(subject));

                if (subjectId > 0)
                {
                    if (subject.Content != null)
                    {
                        subject.Content.SubjectId = subjectId;
                        await Task.Run(() => subjectDataAccess.InsertContent(subject.Content));
                    }

                    MessageBox.Show("Subject added successfully.");
                    ResetForm();
                    DisplaySubjects();
                }
                else
                {
                    MessageBox.Show("Failed to add subject.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the subject: " + ex.Message);
            }
            finally
            {
                // Re-enable the "Save" button
                savebtn.Enabled = true;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentSubjectId == 0)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Retrieve the subject and its content data
                Subject subject = subjectDataAccess.GetSubjectById(currentSubjectId);

                if (subject != null)
                {
                    // Delete the subject and its content data
                    subjectDataAccess.DeleteSubject(currentSubjectId);

                    MessageBox.Show("Subject deleted successfully.");
                    ResetForm();
                    DisplaySubjects();
                }
                else
                {
                    MessageBox.Show("Failed to retrieve subject.");
                }
            }
        }
        private void resetbtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (currentSubjectId == 0)
            {
                MessageBox.Show("Please select a subject to edit.");
                return;
            }

            Subject subject = subjectDataAccess.GetSubjectById(currentSubjectId);

            if (subject != null)
            {
                // Update the subject object with the new values from the form controls
                subject.Name = subjectTb.Text;
                subject.Description = descriptionTB.Text;
                subject.ContentType = contentTypeCB.SelectedItem.ToString();
                subject.DateAdded = dateTimePicker.Value;
                subject.IsActive = isActiveCheckBox.Checked;

                // Save the updated subject data to the database
                subjectDataAccess.UpdateSubject(subject);

                MessageBox.Show("Subject updated successfully.");
                ResetForm();
                DisplaySubjects();
            }
            else
            {
                MessageBox.Show("Failed to retrieve subject.");
            }
        }
        private void subjectsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = subjectsList.Rows[e.RowIndex];

                currentSubjectId = int.Parse(row.Cells[0].Value.ToString());
                subjectTb.Text = row.Cells[1].Value.ToString();
                descriptionTB.Text = row.Cells[2].Value.ToString();
                contentTypeCB.SelectedItem = row.Cells[3].Value.ToString();
                dateTimePicker.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                isActiveCheckBox.Checked = bool.Parse(row.Cells[5].Value.ToString());

                deleteButton.Enabled = true;
            }
        }
    }
}