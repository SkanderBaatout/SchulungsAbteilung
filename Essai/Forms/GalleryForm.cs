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

            RefreshDataGridView("");

        }

        private void RefreshDataGridView(string subjectNameFilter = "")
        {
            // Get the filter values from the controls
            string contentTypeFilter = contentTypeCB.SelectedItem.ToString();

            // Retrieve the subjects and their contents from the database
            subjectList = subjectDataAccess.GetAllSubjects().Where(s => s.IsActive).ToList();
            if (!string.IsNullOrWhiteSpace(subjectNameFilter))
            {
                subjectList = subjectList.Where(s =>
                    s.Name.StartsWith(subjectNameFilter, StringComparison.OrdinalIgnoreCase) ||
                    s.Name.Contains(subjectNameFilter, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            List<Subject> filteredSubjectList = new List<Subject>();
            foreach (Subject subject in subjectList)
            {
                List<Content> contentList = subjectDataAccess.GetMediaContentList(subject.Id, contentTypeFilter);
                if (contentList.Count > 0)
                {
                    subject.Content = contentList; // Add the contents to the subject object
                    filteredSubjectList.Add(subject);
                }
            }

            // Filter the subject list based on the current page and page size
            totalRecords = filteredSubjectList.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);
            filteredSubjectList = filteredSubjectList.GetRange(startIndex, endIndex - startIndex);

            // Set the number of rows and columns in the TableLayoutPanel
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = (int)Math.Ceiling((double)filteredSubjectList.Count / 2);

            // Clear the existing controls from the TableLayoutPanel
            tableLayoutPanel.Controls.Clear();

            // Set the size of each cell in the TableLayoutPanel
            int cellWidth = (tableLayoutPanel.ClientSize.Width - tableLayoutPanel.Margin.Horizontal) / 2;
            int cellHeight = (tableLayoutPanel.ClientSize.Height - tableLayoutPanel.Margin.Vertical) / tableLayoutPanel.RowCount;
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellWidth));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellWidth));
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, cellHeight));
            }

            // Add a new control for each subject
            int row = 0;
            int col = 0;
            foreach (Subject subject in filteredSubjectList)
            {
                // Create a new Button control with the subject name as the text
                Button subjectButton = new Button();
                subjectButton.Text = subject.Name;
                subjectButton.Tag = subject;
                subjectButton.Click += SubjectButton_Click;

                // Set the size and appearance of the button
                subjectButton.Width = cellWidth - 10;
                subjectButton.Height = cellHeight - 10;
                subjectButton.BackColor = Color.FromArgb(0, 204, 204); // blue background color
                subjectButton.ForeColor = Color.White; // white text color
                subjectButton.Font = new System.Drawing.Font("Segoe UI", 14, FontStyle.Bold); // bold, larger font
                subjectButton.FlatStyle = FlatStyle.Flat; // no 3D appearance
                subjectButton.FlatAppearance.BorderSize = 1; // add a border
                subjectButton.FlatAppearance.BorderColor = Color.White; // white border color

                tableLayoutPanel.Controls.Add(subjectButton, col, row);

                col++;
                if (col == 2)
                {
                    col = 0;
                    row++;
                }
            }

            // Update the page information labels
            //  pageLabel.Text = $"Page {currentPage} of {totalPages}";
            totalRecordsLabel.Text = $"{totalRecords} records found";
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            lblPageNumber.Text = $"Page {currentPage} of {totalPages}";

        }
        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
            // Reset the current page to 1 when filters are applied
            currentPage = 1;

            RefreshDataGridView();
        }

        private void ContentButton_Click(object sender, EventArgs e)
        {
            // Get the search text from the subjectNameFilterTB text input
            string subjectNameFilter = subjectNameFilterTB.Text.Trim();

            // Call the SearchSubjects method with the search text
            SearchSubjects(subjectNameFilter);
        }

        private void SearchSubjects(string searchText)
        {
            // Reset the current page to 1 when filters are applied
            currentPage = 1;

            // Refresh the DataGridView with the search text as a filter
            RefreshDataGridView(searchText);
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

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                RefreshDataGridView();
                lblPageNumber.Text = $"Page {currentPage} of {totalPages}";
            }

        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage = 1;
                RefreshDataGridView();
                lblPageNumber.Text = $"Page {currentPage} of {totalPages}";
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                RefreshDataGridView();
                lblPageNumber.Text = $"Page {currentPage} of {totalPages}";
            }
        }
    }
}