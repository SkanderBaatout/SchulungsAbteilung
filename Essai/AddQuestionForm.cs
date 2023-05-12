﻿using Microsoft.Data.SqlClient;
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
            string query = "SELECT MAX(qset) FROM questions;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && !DBNull.Value.Equals(result))
                {
                    _currentQuestionSet = Convert.ToInt32(result) + 1;
                }

                textBox_set.Text = _currentQuestionSet.ToString();
            }

            questionLabel.Text = _currentQuestionNumber.ToString();
            label_NoSet.Visible = false;
        }

        private void textBox_set_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_set.Text, out int qSet))
            {
                clearAll();

                string query = $"SELECT COUNT(*) FROM questions WHERE qset = {qSet};";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_set.Text, out int qSet))
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

                string query = "INSERT INTO questions (qset, qNo, question, optionA, optionB, optionC, optionD, ans, PhotoData) " +
                    "VALUES (@qset, @qno, @question, @option1, @option2, @option3, @option4, @ans, @image)";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@qset", qSet);
                    command.Parameters.AddWithValue("@qno", qNo);
                    command.Parameters.AddWithValue("@question", question);
                    command.Parameters.AddWithValue("@option1", option1);
                    command.Parameters.AddWithValue("@option2", option2);
                    command.Parameters.AddWithValue("@option3", option3);
                    command.Parameters.AddWithValue("@option4", option4);
                    command.Parameters.AddWithValue("@ans", ans);
                    command.Parameters.AddWithValue("@image", imageBytes);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                clearAll();
                _currentQuestionNumber++;
                questionLabel.Text = _currentQuestionNumber.ToString();
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
            MessageBox.Show("All questions added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
            if (string.IsNullOrWhiteSpace(textBox_question.Text))
            {
                btn_next.Enabled = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_option1.Text) ||
                string.IsNullOrWhiteSpace(textBox_option2.Text) ||
                string.IsNullOrWhiteSpace(textBox_option3.Text) ||
                string.IsNullOrWhiteSpace(textBox_option4.Text) ||
                string.IsNullOrWhiteSpace(textBox_answer.Text))
            {
                btn_next.Enabled = false;
                return;
            }

            btn_next.Enabled = true;
        }
    }
}