using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Essai
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        int key = 0;
        private void Reset()
        {
            subjectTb.Text = "";
            descriptionTB.Text = "";
            contentTB.Text = "";
            contentTypeTB.Text = "";
            dateTimePicker.Value = DateTime.Now;
            isActiveCheckBox.Checked = true;
            currentSubjectId = 0;
            key = 0;
        }
        private int currentSubjectId = 0;


        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");
        private void DisplaySubjects()
        {
            Con.Open();
            string query = "SELECT * FROM SubjectTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            subjectsList.DataSource = table;
            Con.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (subjectTb.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a subject name.");
                return;
            }
            if (currentSubjectId == 0)
            {
                SaveSubject();
            }
            else
            {
                UpdateSubject();
            }
            DisplaySubjects();

            Reset();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = subjectsList.SelectedCells.Count > 0 ? subjectsList.SelectedCells[0].RowIndex : -1;
            if (selectedRowIndex >= 0)
            {
                int selectedSubjectId = (int)subjectsList.Rows[selectedRowIndex].Cells["SId"].Value;
                LoadSubject(selectedSubjectId);
            }
        }
        // Save a new subject to the database
        private void SaveSubject()
        {
            using (SqlConnection con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True"))
            {
                string query = "INSERT INTO SubjectTbl (SName, Description, Content, ContentType, DateAdded, IsActive) " +
                    "VALUES (@SName, @Description, @Content, @ContentType, @DateAdded, @IsActive)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SName", subjectTb.Text);
                cmd.Parameters.AddWithValue("@Description", descriptionTB.Text);

                if (!string.IsNullOrEmpty(contentTB.Text))
                {
                    if (contentTB.Text.StartsWith("file:"))
                    {
                        cmd.Parameters.AddWithValue("@Content", File.ReadAllBytes(contentTB.Text.Substring(5)));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Content", Encoding.UTF8.GetBytes(contentTB.Text));
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Content", DBNull.Value);
                }

                cmd.Parameters.AddWithValue("@ContentType", contentTypeTB.Text);
                cmd.Parameters.AddWithValue("@DateAdded", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@IsActive", isActiveCheckBox.Checked);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void UpdateSubject()
        {
            using (SqlConnection con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True"))
            {
                string query = "UPDATE SubjectTbl SET SName = @SName, Description = @Description, " +
                    "Content = @Content, ContentType = @ContentType, DateAdded = @DateAdded, IsActive = @IsActive " +
                    "WHERE SId = @SId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SId", currentSubjectId);
                cmd.Parameters.AddWithValue("@SName", subjectTb.Text);
                cmd.Parameters.AddWithValue("@Description", descriptionTB.Text);
                cmd.Parameters.AddWithValue("@Content", Encoding.UTF8.GetBytes(contentTB.Text));
                cmd.Parameters.AddWithValue("@ContentType", contentTypeTB.Text);
                cmd.Parameters.AddWithValue("@DateAdded", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@IsActive", isActiveCheckBox.Checked);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // Delete a subject from the database
        private void DeleteSubject(int subjectId)
        {
            using (SqlConnection con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True"))
            {
                string query = "DELETE FROM SubjectTbl WHERE SId = @SId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SId", subjectId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        // Load the data for the selected subject into the form
        private void LoadSubject(int subjectId)
        {
            using (SqlConnection con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True"))
            {
                string query = "SELECT SName, Description, Content, ContentType, DateAdded, IsActive FROM SubjectTbl WHERE SId = @SId";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.SelectCommand.Parameters.AddWithValue("@SId", subjectId);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    subjectTb.Text = row.Field<string>("SName");
                    descriptionTB.Text = row.Field<string>("Description");

                    byte[] contentBytes = row.Field<byte[]>("Content");
                    if (contentBytes != null && contentBytes.Length > 0)
                    {
                        if (contentBytes[0] == 0x66 && contentBytes[1] == 0x69 && contentBytes[2] == 0x6c && contentBytes[3] == 0x65 && contentBytes[4] == 0x3a)
                        {
                            string filePath = Encoding.UTF8.GetString(contentBytes).Substring(5);
                            contentTB.Text = "file:" + filePath;
                        }
                        else
                        {
                            contentTB.Text = Encoding.UTF8.GetString(contentBytes);
                        }
                    }
                    else
                    {
                        contentTB.Text = "";
                    }

                    contentTypeTB.Text = row.Field<string>("ContentType");
                    dateTimePicker.Value = row.Field<DateTime?>("DateAdded") ?? DateTime.Now;
                    isActiveCheckBox.Checked = row.Field<bool?>("IsActive") ?? false;
                    currentSubjectId = subjectId;
                }
            }
        }
        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void subjectsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            subjectTb.Text = subjectsList.SelectedRows[0].Cells[1].Value.ToString();

            if (subjectTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(subjectsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Candidats can = new Candidats();
            can.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
            Candidats can = new Candidats();
            can.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = subjectsList.SelectedCells.Count > 0 ? subjectsList.SelectedCells[0].RowIndex : -1;
            if (selectedRowIndex >= 0)
            {
                // Check if the value of the "SId" cell is not null before casting it to an int
                if (subjectsList.Rows[selectedRowIndex].Cells["SId"].Value != null)
                {
                    int selectedSubjectId = (int)subjectsList.Rows[selectedRowIndex].Cells["SId"].Value;
                    if (MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeleteSubject(selectedSubjectId);
                        DisplaySubjects();
                        Reset();
                    }
                }
                else
                {
                    // Handle the case where the value of the "SId" cell is null
                    MessageBox.Show("Selected subject does not have a valid ID");
                }
            }
        }
        private void subjectsList_SelectionChanged(object sender, EventArgs e)
        {
            Reset();
            int selectedRowIndex = subjectsList.SelectedCells.Count > 0 ? subjectsList.SelectedCells[0].RowIndex : -1;
            if (selectedRowIndex >= 0)
            {
                // Check if the value of the "SId" cell is not DBNull.Value before casting it to an int
                if (subjectsList.Rows[selectedRowIndex].Cells["SId"].Value != DBNull.Value)
                {
                    int selectedSubjectId = Convert.ToInt32(subjectsList.Rows[selectedRowIndex].Cells["SId"].Value);
                    LoadSubject(selectedSubjectId);
                }
                else
                {
                    // Handle the case where the value of the "SId" cell is DBNull.Value
                    MessageBox.Show("Selected subject does not have a valid ID");
                }
            }
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                if (File.Exists(fileName))
                {
                    contentTB.Text = "file:" + fileName;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void descriptionTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}