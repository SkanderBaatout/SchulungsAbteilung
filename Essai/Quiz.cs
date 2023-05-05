using Essai.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai
{
    public partial class Quiz : Form
    {
        private readonly Function _function = new Function();
        private readonly Random _random = new Random();
        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";
        private string _query;
        private DataSet _dataSet;
        private int _currentIndex = -1;
        private int _score;
        private int _totalQuestions;
        private int _remainingTime;
        private System.Windows.Forms.Timer _timer;
        private List<int> _questionIndexes;
        private bool _quizEnded = false;

        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            label_nameEmp.Text = LoginForm.username;
            label_cinEmp.Text = LoginForm.cin;
            int qset = GetRandomQset();
            label_set.Text = qset.ToString();

            // Set up the quiz
            SetUpQuiz(qset);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeBord form = new EmployeeBord();
            form.Show();
            this.Hide();
        }



        private void btn_next_Click(object sender, EventArgs e)
        {
            // Check if the quiz has ended
            if (_quizEnded)
            {
                // Display the score
                MessageBox.Show("Vous avez marqué " + _score.ToString() + " sur " + _totalQuestions.ToString() + ".", "Score");

                // Move to the EmployeeBordForm
                EmployeeBord form = new EmployeeBord();
                form.Show();
                this.Hide();
            }
            else
            {
                // Check if there are remaining questions
                if (_currentIndex < _totalQuestions - 1)
                {
                    // Check if an option is selected
                    if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                    {
                        // Check if the selected option is correct
                        if (GetSelectedOption() == GetCorrectOption())
                        {
                            _score++;
                        }

                        // Move to the next question
                        _currentIndex++;
                        DisplayQuestion(_currentIndex);
                        UpdateQuestionNumber(_currentIndex + 1, _totalQuestions);
                        ResetOptionSelection();
                        ResetRemainingTime();
                    }
                    else
                    {
                        MessageBox.Show("Aucune question sélectionnée ! Sélectionnez au moins une question.", "Erreur");
                    }
                }
                else
                {
                    // End the quiz
                    int qset = Convert.ToInt32(label_set.Text);
                    EndQuiz(qset);

                    // Insert the score into the database
                    InsertTest(qset);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the remaining time
            _remainingTime--;
            label_remainingTime.Text = _remainingTime.ToString() + " seconds";

            // Check if the time has run out
            if (_remainingTime == 0)
            {
                // Move to the next question
                btn_next.PerformClick();
            }
        }

        private void SetUpQuiz(int qset)
        {
            // Get the questions for the qset
            _query = "SELECT question, optionA, optionB, optionC, optionD, ans, photo FROM questions WHERE qset = @qset";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(_query, connection))
                {
                    command.Parameters.AddWithValue("@qset", qset);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    _dataSet = new DataSet();
                    adapter.Fill(_dataSet);
                    connection.Close();
                }
            }

            // Shuffle the questions
            _questionIndexes = Enumerable.Range(0, _dataSet.Tables[0].Rows.Count).ToList();
            Shuffle(_questionIndexes);

            // Initialize the quiz
            _totalQuestions = _dataSet.Tables[0].Rows.Count;
            _currentIndex = 0;
            _score = 0;
            _remainingTime = _totalQuestions * 30;

            // Start the timer
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += timer1_Tick;
            _timer.Start();

            // Display the first question
            DisplayQuestion(_currentIndex);
            UpdateQuestionNumber(1, _totalQuestions);
            label_total_Time.Text = _remainingTime.ToString() + " seconds";
        }
        private void DisplayQuestion(int index)
        {
            DataRow row = _dataSet.Tables[0].Rows[_questionIndexes[index]];
            string question = row["question"].ToString();
            string optionA = row["optionA"].ToString();
            string optionB = row["optionB"].ToString();
            string optionC = row["optionC"].ToString();
            string optionD = row["optionD"].ToString();
            byte[] imageData = row["photo"] as byte[]; // retrieve the image data as a byte array

            label_question.Text = question;
            radioButton1.Text = optionA;
            radioButton2.Text = optionB;
            radioButton3.Text = optionC;
            radioButton4.Text = optionD;

            if (imageData != null)
            {
                // if the image data is not null, load it as an Image object and display it in the PictureBox
                Image image = LoadImage(imageData);
                pictureBox_question.Image = image;
            }
            else
            {
                pictureBox_question.Image = null;
            }
        }
        private int GetSelectedOption()
        {
            if (radioButton1.Checked)
            {
                return 1;
            }
            else if (radioButton2.Checked)
            {
                return 2;
            }
            else if (radioButton3.Checked)
            {
                return 3;
            }
            else if (radioButton4.Checked)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        private int GetCorrectOption()
        {
            DataRow row = _dataSet.Tables[0].Rows[_questionIndexes[_currentIndex]];
            return Convert.ToInt32(row["ans"]);
        }

        private void UpdateQuestionNumber(int current, int total)
        {
            qNo.Text = "Question " + current.ToString() + " sur " + total.ToString();
        }

        private void ResetOptionSelection()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void ResetRemainingTime()
        {
            _remainingTime = _totalQuestions * 30;
            label_total_Time.Text = _remainingTime.ToString() + " seconds";
        }

        private void EndQuiz(int qset)
        {
            // Stop the timer
            _timer.Stop();

            // Disable the quiz controls
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            btn_next.Text = "Submit";

            // Show the results
            MessageBox.Show("Vous avez marqué " + _score.ToString() + " sur " + _totalQuestions.ToString() + ".", "Résultats");

            // Set quizEnded to true
            _quizEnded = true;
        }

        private int GetRandomQset()
        {
            _query = "SELECT TOP 1 qset FROM questions GROUP BY qset ORDER BY NEWID()";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(_query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int qset = Convert.ToInt32(result);
                        connection.Close();
                        return qset;
                    }
                    else
                    {
                        connection.Close();
                        throw new Exception("No qset found");
                    }
                }
            }
        }

        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private Image LoadImage(object image)
        {
            if (image == DBNull.Value)
            {
                return null;
            }

            if (image is byte[] bytes)
            {
                MemoryStream stream = new MemoryStream(bytes);
                return Image.FromStream(stream);
            }
            else
            {
                throw new ArgumentException("Invalid image type", nameof(image));
            }
        }

        private void InsertTest(int qset)
        {
            try
            {
                _query = "IF NOT EXISTS (SELECT 1 FROM scores WHERE cin = @cin AND qset = @qset) " +
                         "BEGIN " +
                         "INSERT INTO scores (cin, qset, score, date) VALUES (@cin, @qset, @score, @date) " +
                         "END " +
                         "ELSE " +
                         "BEGIN " +
                         "IF @score > (SELECT score FROM scores WHERE cin = @cin AND qset = @qset) " +
                         "UPDATE scores SET score = @score, date = @date WHERE cin = @cin AND qset = @qset " +
                         "END";
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(_query, connection))
                    {
                        command.Parameters.AddWithValue("@cin", LoginForm.cin);
                        command.Parameters.AddWithValue("@qset", qset);
                        command.Parameters.AddWithValue("@score", _score);
                        command.Parameters.AddWithValue("@date", DateTime.Now);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                string errorMessage = $"Error inserting score into database: {ex.Message}";
                MessageBox.Show(errorMessage, "Error");
            }
        }
    }
}