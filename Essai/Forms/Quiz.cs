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
            string testName = GetRandomTestName();
            label_set.Text = testName;

            // Set up the quiz
            SetUpQuiz(testName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeBord form = new EmployeeBord();
            form.Show();
            this.Hide();
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
                        ResetRemainingTime();
                    }
                    else
                    {
                        MessageBox.Show("Aucune question sélectionnée ! Sélectionnez au moins une question.", "Erreur");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the remaining time
            _remainingTime--;
            label_remainingTime.Text = $"{_remainingTime} seconds";

            // Check if the time has run out
            if (_remainingTime == 0)
            {
                // Move to the next question
                btn_next.PerformClick();
            }
        }
        private void SetUpQuiz(string testName)
        {
            // Get the questions for the test
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
                    // Log the error or display an error message
                    Console.WriteLine("Error loading image: " + ex.Message);
                }
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
            qNo.Text = $"Question {current} sur {total}";
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

        private void EndQuiz(string testName)
        {
            _timer.Stop();

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            btn_next.Text = "Submit";

            MessageBox.Show("Vous avez marqué " + _score.ToString() + " sur " + _totalQuestions.ToString() + ".", "Résultats");

            _quizEnded = true;

            string logoPath = "C:\\Users\\ASUS\\Desktop\\icons\\logo.png";
            string fileName = "badge.pdf";
            try
            {
                using (var document = new iTextSharp.text.Document(new iTextSharp.text.Rectangle(200, 150), 0, 0, 0, 0))
                {
                    PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                    document.Open();

                    var logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(document.PageSize.Width / 3, document.PageSize.Height / 3);
                    logo.Alignment = iTextSharp.text.Image.ALIGN_LEFT;
                    document.Add(logo);

                    var headerFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 14, iTextSharp.text.Font.BOLD);
                    var headerParagraph = new iTextSharp.text.Paragraph("Training Service", headerFont);
                    headerParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(headerParagraph);
                    document.Add(new iTextSharp.text.Paragraph("\n"));

                    var squareSize = 80;
                    var x = (int)document.PageSize.Width / 2 - squareSize / 2;
                    var y = (int)document.PageSize.Height / 2 - squareSize / 2;
                    var rectangle = new RectangleWithBackground(x, y, x + squareSize, y + squareSize, 0, 0, BaseColor.BLACK, BaseColor.LIGHT_GRAY);
                    rectangle.BackgroundColor = new BaseColor(GetBadgeColor(_score));
                    document.Add(rectangle);

                    var font = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 10, iTextSharp.text.Font.NORMAL);
                    var nameParagraph = new iTextSharp.text.Paragraph("Nom: " + label_nameEmp.Text, font);
                    nameParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(nameParagraph);
                    var cinParagraph = new iTextSharp.text.Paragraph("CIN: " + label_cinEmp.Text, font);
                    cinParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(cinParagraph);
                    var scoreParagraph = new iTextSharp.text.Paragraph("Score: " + _score.ToString() + " sur " + _totalQuestions.ToString(), font);
                    scoreParagraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(scoreParagraph);

                    var footerFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 16, iTextSharp.text.Font.BOLD);
                    var footerParagraph = new iTextSharp.text.Paragraph("WE CREATE CHARACTER", footerFont);
                    footerParagraph.Alignment = Element.ALIGN_CENTER;
                    footerParagraph.SpacingBefore = 10f;
                    document.Add(footerParagraph);

                    document.SetPageSize(rectangle);
                    document.SetMargins(0f, 0f, 0f, 0f);

                    document.Close();

                    MessageBox.Show("Votre badge a été créé avec succès. Vous pouvez le trouver ici: " + Path.GetFullPath(fileName), "Badge créé");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la création du badge: " + ex.Message, "Erreur");
            }
        }
        private void PrintPdf(string fileName, string printerName)
        {
            if (!File.Exists(fileName))
            {
                throw new ArgumentException("File not found", nameof(fileName));
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files\Adobe\Acrobat DC\Acrobat\Acrobat.exe";
            startInfo.Arguments = "/h /t \"" + fileName + "\" \"" + printerName + "\""; // set printer name
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
            }
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
            Console.WriteLine("InsertTest called with testName = " + testName);
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
    }
}