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
        private readonly int _employeeId;
        private readonly bool _isAdmin;


        public GalleryForm(string role, int employeeId, bool isAdmin)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _isAdmin = isAdmin;

            subjectDataAccess = new SubjectDataAccess("data source = SKANDERBAATOUT;database = quiz ;integrated security = True ; TrustServerCertificate=True");
            if (role == "admin")
            {
                label1.Text = "Subject Gallery";
            }
            else if (role == "employee")
            {
                label1.Text = "Trainings List";
            }


            var vlcLibDirectory = new DirectoryInfo(@"C:\Program Files\VideoLAN\VLC\");

            contentTypeCB.Items.Add("All");
            contentTypeCB.Items.Add("Docs");
            contentTypeCB.Items.Add("Images");
            contentTypeCB.Items.Add("Videos");
            contentTypeCB.Items.Add("Other");
            contentTypeCB.SelectedIndex = 0;

            RefreshDataGridView("");
            _isAdmin = isAdmin;
        }

        private void RefreshDataGridView(string subjectNameFilter = "")
        {
            string contentTypeFilter = contentTypeCB.SelectedItem.ToString();

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
                    subject.Content = contentList; 
                    filteredSubjectList.Add(subject);
                }
            }

            totalRecords = filteredSubjectList.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, totalRecords);
            filteredSubjectList = filteredSubjectList.GetRange(startIndex, endIndex - startIndex);

            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = (int)Math.Ceiling((double)filteredSubjectList.Count / 2);

            tableLayoutPanel.Controls.Clear();

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

            int row = 0;
            int col = 0;
            foreach (Subject subject in filteredSubjectList)
            {
                Button subjectButton = new Button();
                subjectButton.Text = subject.Name;
                subjectButton.Tag = subject;
                subjectButton.Click += SubjectButton_Click;

                subjectButton.Width = cellWidth - 10;
                subjectButton.Height = cellHeight - 10;
                subjectButton.BackColor = Color.FromArgb(110, 157, 152); 
                subjectButton.ForeColor = Color.White;
                subjectButton.Font = new System.Drawing.Font("Segoe UI", 14, FontStyle.Bold); 
                subjectButton.FlatStyle = FlatStyle.Flat; 
                subjectButton.FlatAppearance.BorderSize = 1; 
                subjectButton.FlatAppearance.BorderColor = Color.White; 

                tableLayoutPanel.Controls.Add(subjectButton, col, row);

                col++;
                if (col == 2)
                {
                    col = 0;
                    row++;
                }
            }

            totalRecordsLabel.Text = $"{totalRecords} records found";
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            lblPageNumber.Text = $"Page {currentPage} of {totalPages}";

        }
        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
           
            currentPage = 1;

            RefreshDataGridView();
        }

        private void ContentButton_Click(object sender, EventArgs e)
        {
            string subjectNameFilter = subjectNameFilterTB.Text.Trim();
            SearchSubjects(subjectNameFilter);
        }

        private void SearchSubjects(string searchText)
        {
            currentPage = 1;           
            RefreshDataGridView(searchText);
        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {
            Button subjectButton = (Button)sender;
            Subject subject = (Subject)subjectButton.Tag;

            ContentForm contentForm = new ContentForm(_employeeId, subject.Id,subject,_isAdmin);
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