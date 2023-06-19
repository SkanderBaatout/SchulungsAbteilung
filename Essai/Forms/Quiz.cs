using DocumentFormat.OpenXml.Wordprocessing;
using Essai.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Essai.Classes;
using Essai.Utils;
using System.Runtime.Serialization.Formatters.Binary;
using ImageMagick;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using iTextSharp.text;
using Rectangle = System.Drawing.Rectangle;
using System.Drawing.Printing;
using Essai.Singleton;

namespace Essai
{
    public partial class Quiz : Form
    {
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
            string testName = GetRandomTestName();
            label_set.Text = testName;
            SetUpQuiz(testName);
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (_quizEnded)
            {
                string testName = label_set.Text;
                EndQuiz(testName);
                InsertTest(testName);
            }
            else
            {
                if (_currentIndex < _totalQuestions - 1)
                {
                    if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                    {
                        if (GetSelectedOption() == GetCorrectOption())
                        {
                            _score++;
                        }
                        _currentIndex++;
                        DisplayQuestion(_currentIndex);
                        UpdateQuestionNumber(_currentIndex + 1, _totalQuestions);
                        ResetOptionSelection();
                    }
                    else
                    {
                        MessageBox.Show("No question selected ! Select at least one.", "Error");
                    }
                }
                else
                {
                    string testName = label_set.Text;
                    EndQuiz(testName);
                    InsertTest(testName);
                }
            }
        }
        private const int TimerInterval = 1000;
        bool _quizCompleted = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check if quiz has already completed
            if (_quizCompleted)
            {
                return;
            }

            _remainingTime--;
            label_remainingTime.Text = $"{_remainingTime} seconds";

            if (_remainingTime <= 0)
            {
                // Stop the timer
                _quizCompleted = true; // set the flag to true
                timer1.Stop();
                MessageBox.Show("You scored " + _score.ToString() + " Of " + _totalQuestions.ToString() + ".", "Result");
                // Insert the test into the database and return to the login form
                // InsertTest(label_set.Text);
                InsertOrUpdateExamResult(label_set.Text);
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
        private void SetUpQuiz(string testName)
        {
            _query = "SELECT question, optionA, optionB, optionC, optionD, ans, PhotoData FROM questions q INNER JOIN TestsType tt ON q.qset COLLATE Arabic_CI_AS = tt.name COLLATE Arabic_CI_AS WHERE tt.name = @testName COLLATE Arabic_CI_AS";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(_query, connection))
                {
                    command.Parameters.AddWithValue("@testName", testName);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    _dataSet = new DataSet();
                    adapter.Fill(_dataSet);
                    connection.Close();
                }
            }

            // Select 10 random questions
            List<int> allQuestionIndexes = Enumerable.Range(0, _dataSet.Tables[0].Rows.Count).ToList();
            Shuffle(allQuestionIndexes);
            _questionIndexes = allQuestionIndexes.Take(10).ToList();
            _totalQuestions = 10;

            _currentIndex = 0;
            _score = 0;
            int totalQuizTime = _totalQuestions * 30;
            _remainingTime = totalQuizTime;

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += timer1_Tick;
            _timer.Start();

            DisplayQuestion(_currentIndex);
            UpdateQuestionNumber(1, _totalQuestions);
            label_total_Time.Text = $"{totalQuizTime} seconds";
            label_remainingTime.Text = $"{totalQuizTime} seconds";
        }
        private void DisplayQuestion(int index)
        {
            DataRow row = _dataSet.Tables[0].Rows[_questionIndexes[index]];
            string question = row.Field<string>("question");
            string optionA = row.Field<string>("optionA");
            string optionB = row.Field<string>("optionB");
            string optionC = row.Field<string>("optionC");
            string optionD = row.Field<string>("optionD");
            byte[] imageData = row.Field<byte[]>("PhotoData");

            label_question.Text = question;
            radioButton1.Text = optionA;
            radioButton2.Text = optionB;
            radioButton3.Text = optionC;
            radioButton4.Text = optionD;

            if (imageData?.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        SerializableImage serializableImage = new SerializableImage(System.Drawing.Image.FromStream(ms));
                        pictureBox_question.Image = serializableImage.GetImage(pictureBox_question.Width, pictureBox_question.Height);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                }
            }
            else
            {
                pictureBox_question.Image = null;
            }
        }
        

       
        private void EndQuiz(string testName)
        {
            _timer.Stop();

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            btn_next.Text = "Submit";

            MessageBox.Show("You scored " + _score.ToString() + " Of " + _totalQuestions.ToString() + ".", "Result");

            _quizEnded = true;
            InsertOrUpdateExamResult(testName);

            var logoPath = "C:\\Users\\ASUS\\Desktop\\icons\\logo.png";
            var name = label_nameEmp.Text;
            var cin = label_cinEmp.Text;
            var fileName = "badge_" + name + ".pdf";

            BadgeGenerator.Instance.GenerateBadge(logoPath, testName, name, cin, _score, _totalQuestions, fileName);
        }

        private string GetRandomTestName()
        {
            _query = "SELECT TOP 1 tt.name FROM questions q INNER JOIN TestsType tt ON q.qset COLLATE Arabic_CI_AS = tt.name COLLATE Arabic_CI_AS GROUP BY tt.name ORDER BY NEWID()";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(_query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string testName = Convert.ToString(result);
                        connection.Close();
                        return testName;
                    }
                    else
                    {
                        connection.Close();
                        throw new Exception("No test name found");
                    }
                }
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
            qNo.Text = $"Question {current} sur {total}";
        }
        private void ResetOptionSelection()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
        private void InsertOrUpdateExamResult(string testName)
        {
            int examCount;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ExamResult WHERE TestName = @TestName AND Name = @Name AND CIN = @CIN", connection))
                {
                    command.Parameters.AddWithValue("@TestName", testName);
                    command.Parameters.AddWithValue("@Name", label_nameEmp.Text);
                    command.Parameters.AddWithValue("@CIN", label_cinEmp.Text);
                    connection.Open();
                    examCount = (int)command.ExecuteScalar();
                    connection.Close();
                }
            }

            // Check if the user has taken the exam twice
            if (examCount < 2)
            {
                // Calculate the percentage score
                int percentageScore = (_score * 100) / _totalQuestions;

                // Determine the status (passed or rejected)
                bool isPassed = percentageScore > 75;

                // Insert or update the exam result in the database
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    string query;
                    if (examCount == 0)
                    {
                        // The user has not taken the exam before, so insert a new record
                        query = "INSERT INTO ExamResult(TestName, NumberOfQuestions, Date, Name, CIN, Score, Status) VALUES(@TestName, @NumberOfQuestions, @Date, @Name, @CIN, @Score, @Status)";
                    }
                    else
                    {
                        // The user has taken the exam once before, so update the existing record
                        query = "UPDATE ExamResult SET NumberOfQuestions = @NumberOfQuestions, Date = @Date, Score = @Score, Status = @Status WHERE TestName = @TestName AND Name = @Name AND CIN = @CIN";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestName", testName);
                        command.Parameters.AddWithValue("@NumberOfQuestions", _totalQuestions);
                        command.Parameters.AddWithValue("@Date", DateTime.Now);
                        command.Parameters.AddWithValue("@Name", label_nameEmp.Text);
                        command.Parameters.AddWithValue("@CIN", label_cinEmp.Text);
                        command.Parameters.AddWithValue("@Score", _score.ToString() + "/" + _totalQuestions.ToString());
                        command.Parameters.AddWithValue("@Status", isPassed);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            else
            {
                // The user has already taken the exam twice, so display an error message
                MessageBox.Show("You've passed this exam twice.", "Error");
            }
        }
        private void Shuffle<T>(IList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            int n = list.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = _random.Next(i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        private T ExecuteScalar<T>(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        return default(T);
                    }
                    return (T)Convert.ChangeType(result, typeof(T));
                }
            }
        }
        private void InsertTest(string testName)
        {
            Console.WriteLine("Insert Test called with testName = " + testName);
            try
            {
                int scoreInDatabase = ExecuteScalar<int>("SELECT ISNULL(MAX(score), 0) FROM scores WHERE cin = @cin AND qset = @qset",
                    new SqlParameter("@cin", LoginForm.cin),
                    new SqlParameter("@qset", testName));

                if (_score > scoreInDatabase)
                {
                    int qsetId = ExecuteScalar<int>("SELECT id FROM TestsType WHERE name = @name",
                        new SqlParameter("@name", testName));

                    ExecuteNonQuery($"IF NOT EXISTS (SELECT 1 FROM scores WHERE cin = @cin AND qset = @qset) " +
                                     $"INSERT INTO scores (cin, qset, score, date) VALUES (@cin, @qset, @score, @date) " +
                                     $"ELSE " +
                                     $"UPDATE scores SET score = @score, date = @date WHERE cin = @cin AND qset = @qset",
                                     new SqlParameter("@cin", LoginForm.cin),
                                     new SqlParameter("@qset", qsetId),
                                     new SqlParameter("@score", _score),
                                     new SqlParameter("@date", DateTime.Now));
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error inserting score into database: {ex.Message}";
                MessageBox.Show(errorMessage, "Error");
            }
        }
        private int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeBord form = new EmployeeBord();
            form.Show();
            this.Hide();
        }
        private System.Drawing.Color GetBadgeColor(int score)
        {
            if (score >= 0 && score <= 5)
            {
                return System.Drawing.Color.Yellow;
            }
            else if (score > 5 && score <= 10)
            {
                return System.Drawing.Color.Green;
            }
            else if (score > 10 && score <= 15)
            {
                return System.Drawing.Color.Blue;
            }
            else if (score > 15)
            {
                return System.Drawing.Color.Red;
            }
            else
            {
                throw new ArgumentException("Invalid score");
            }
        }
        private SerializableImage LoadImage(byte[] imageData)
        {
            if (imageData == null)
            {
                return null;
            }

            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    SerializableImage serializableImage = new SerializableImage(System.Drawing.Image.FromStream(ms));
                    return serializableImage;
                }
            }
            catch (Exception ex)
            {
                // Log the error or display an error message
                Console.WriteLine("Error loading image: " + ex.Message);
                return null;
            }
        }
    }
}