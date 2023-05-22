using Essai.DataAccess;
using Essai.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai.Forms
{
    public partial class AddSubjectForm : Form
    {
        private SubjectDataAccess _subjectDataAccess;
        private string _connectionString;
        public AddSubjectForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _subjectDataAccess = new SubjectDataAccess(_connectionString);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the file path of the selected content
            string filePath = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
            }

            // Create a Content object to store the content data
            Content content = new Content
            {
                ContentType = txtContentType.Text,
                ContentTitle = Path.GetFileName(filePath),
                ContentData = File.ReadAllBytes(filePath)
            };

            // Create a Subject object to store the subject data
            Subject subject = new Subject
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                ContentType = txtContentType.Text,
                DateAdded = dtpDateAdded.Value,
                IsActive = chkIsActive.Checked,
                Content = content
            };

            // Insert the subjectinto the database
            int subjectId = _subjectDataAccess.InsertSubject(subject);
            content.SubjectId = subjectId;
            _subjectDataAccess.InsertContent(content);

            MessageBox.Show("Subject added successfully.");

            // Clear the form
            txtName.Text = "";
            txtDescription.Text = "";
            txtContentType.Text = "";
            dtpDateAdded.Value = DateTime.Now;
            chkIsActive.Checked = false;
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}

