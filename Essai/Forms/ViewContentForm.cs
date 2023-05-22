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
    public partial class ViewContentForm : Form
    {
        private SubjectDataAccess _subjectDataAccess;
        private string _connectionString;
        private int _subjectId;

        public ViewContentForm(string connectionString, int subjectId)
        {
            InitializeComponent();
            _connectionString = connectionString;
            _subjectDataAccess = new SubjectDataAccess(_connectionString);
            _subjectId = subjectId;
        }

        private void ViewContentForm_Load(object sender, EventArgs e)
        {
            // Get the content data from the database
            byte[] contentData = _subjectDataAccess.GetContentBySubjectId(_subjectId);

            if (contentData != null)
            {
                // Convert the byte array to a stream
                using (MemoryStream stream = new MemoryStream(contentData))
                {
                    // Set the Source property of the MediaElement control to the stream
                    // mediaElement1.Source = new Uri(stream.ToString());
                }
            }
            else
            {
                MessageBox.Show("No content found for this subject.");
                this.Close();
            }

            // Get the subject data from the database
            Subject subject = _subjectDataAccess.GetSubjectById(_subjectId);

            if (subject != null)
            {
                // Display the subject data
                lblTitle.Text = subject.Name;
                lblDescription.Text = subject.Description;
                lblContentType.Text = subject.ContentType;
            }
            if (subject.Content != null)
            {
                lblContentTitle.Text = subject.Content.ContentTitle;
            }
            else
            {
                MessageBox.Show("No subject found with the specified ID.");
                this.Close();
            }
        }
    }
}
