using Microsoft.Data.SqlClient;
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

namespace Essai
{
    public partial class AddQuestionForm : Form
    {
        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
        private int _currentQuestionNumber = 1;
        private int _currentQuestionSet = 1;

        public AddQuestionForm()
        {
            InitializeComponent();
            label_NoSet.Visible = false;
            textBox_set.Visible = false; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            btn_next.Enabled = true; // Enable the "Next" button

            // Load the available TestsType names into the ComboBox
            string query = "SELECT name FROM TestsType;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    testsCB.Items.Add(reader.GetString(0));
                }

                reader.Close();
            }

            // Set the default value of the ComboBox to the first item
            if (testsCB.Items.Count > 0)
            {
                testsCB.SelectedIndex = 0;
            }

            questionLabel.Text = _currentQuestionNumber.ToString();
            label_NoSet.Visible = false;
        }
        private void textBox_set_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_set.Text))
            {
                clearAll();

                string query = "SELECT COUNT(*) FROM questions q JOIN TestsType t ON q.qset COLLATE Arabic_CI_AS = t.name COLLATE Arabic_CI_AS WHERE t.name = @name;";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", textBox_set.Text);

                    connection.Open();

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0)
                    {
                        _currentQuestionNumber = result + 1;
                        questionLabel.Text = _currentQuestionNumber.ToString();
                    }
                    else
                    {
                        _currentQuestionNumber = 1;
                        questionLabel.Text = _currentQuestionNumber.ToString();
                        //label_NoSet.Visible = true;
                    }
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(testsCB.SelectedItem?.ToString()))
            {
                string qNo = _currentQuestionNumber.ToString();
                string question = textBox_question.Text;
                string option1 = textBox_option1.Text;
                string option2 = textBox_option2.Text;
                string option3 = textBox_option3.Text;
                string option4 = textBox_option4.Text;
                string ans = textBox_answer.Text;
                byte[] imageBytes = null;

                if (pictureBox2.Image != null)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        pictureBox2.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        imageBytes = stream.ToArray();
                    }
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        // Get the name for the selected name from the TestsType table
                        using (SqlCommand getIdCommand = new SqlCommand("SELECT name FROM TestsType WHERE name = @name", connection))
                        {
                            getIdCommand.Parameters.AddWithValue("@name", testsCB.SelectedItem.ToString());
                            string qSet = (string)getIdCommand.ExecuteScalar();

                            // Insert the question into the questions table
                            using (SqlCommand command = new SqlCommand("INSERT INTO questions (qset, qNo, question, optionA, optionB, optionC, optionD, ans" +
                                (imageBytes != null ? ", PhotoData" : "") + ") " +
                                "VALUES (@qset, @qno, @question, @option1, @option2, @option3, @option4, @ans" +
                                (imageBytes != null ? ", @image" : "") + ");", connection))
                            {
                                command.Parameters.AddWithValue("@qset", qSet);
                                command.Parameters.AddWithValue("@qno", qNo);
                                command.Parameters.AddWithValue("@question", question);
                                command.Parameters.AddWithValue("@option1", option1);
                                command.Parameters.AddWithValue("@option2", option2);
                                command.Parameters.AddWithValue("@option3", option3);
                                command.Parameters.AddWithValue("@option4", option4);
                                command.Parameters.AddWithValue("@ans", ans);

                                if (imageBytes != null)
                                {
                                    command.Parameters.AddWithValue("@image", imageBytes);
                                }

                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    clearAll();
                    _currentQuestionNumber++;
                    questionLabel.Text = _currentQuestionNumber.ToString();

                    MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a question set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearAll()
        {
            textBox_question.Clear();
            textBox_option1.Clear();
            textBox_option2.Clear();
            textBox_option3.Clear();
            textBox_option4.Clear();
            textBox_answer.Clear();
            pictureBox2.Image = null;
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearAll();
            _currentQuestionNumber = 1;
            _currentQuestionSet = 1;
            textBox_set.Text = _currentQuestionSet.ToString();
            questionLabel.Text = _currentQuestionNumber.ToString();
            label_NoSet.Visible = false;
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Test Will be Changed.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                textBox_set.Text = (Int64.Parse(textBox_set.Text.ToString()) + 1).ToString();
                questionLabel.Text = "1";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void textBox_question_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_question.Text.Trim()) ||
                 string.IsNullOrWhiteSpace(textBox_option1.Text.Trim()) ||
                 string.IsNullOrWhiteSpace(textBox_option2.Text.Trim()) ||
                 string.IsNullOrWhiteSpace(textBox_option3.Text.Trim()) ||
                 string.IsNullOrWhiteSpace(textBox_option4.Text.Trim()) ||
                 string.IsNullOrWhiteSpace(textBox_answer.Text.Trim()))
            {
                btn_next.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
            }
            btn_next.Enabled = true;


        }

        private void testsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(testsCB.SelectedItem.ToString()))
            {
                clearAll();

                string query = "SELECT COUNT(*) FROM questions q JOIN TestsType t ON q.qset COLLATE Arabic_CI_AS = t.name COLLATE Arabic_CI_AS WHERE t.name = @name;";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", testsCB.SelectedItem.ToString());

                    connection.Open();

                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0)
                    {
                        _currentQuestionNumber = result + 1;
                        questionLabel.Text = _currentQuestionNumber.ToString();
                    }
                    else
                    {
                        _currentQuestionNumber = 1;
                        questionLabel.Text = _currentQuestionNumber.ToString();
                        label_NoSet.Visible = true;
                    }
                }
            }
        }
    }
}