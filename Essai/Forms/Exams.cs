using Essai.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai
{
    public partial class Exams : Form
    {

        public Exams()
        {
            InitializeComponent();
            // Qn = CountQuestions();
            labelName.Text = LoginForm.username;
            labelSubject.Text = EmployeeBord.trainingName;
            MultiRandom();
            FetchQuestions();



        }
        int Qn;
        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");

        string[] Ua = new string[10];

        int[] keys = new int[10];

        private void MultiRandom()
        {
            //Generate 10 random numbers
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count < 10)
            {
                numbers.Add(rnd.Next(1, 14));
            }
            for (int i = 0; i < 10; i++)
            {
                keys[i] = numbers.ElementAt(i);
            }
        }

        private void FetchQuestions()
        {
            try
            {
                // Get the selected subject name from the EmployeeBord form
                string subjectName = EmployeeBord.trainingName;

                // Fetch all questions where the subject matches the selected subject name
                Con.Open();
                string query = "SELECT * FROM QuestionTbl WHERE QS = @subjectName";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@subjectName", subjectName);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                // Check if there are any questions for the selected subject
                if (dt.Rows.Count == 0)
                {
                    // Display a message box indicating that there are no questions for the selected subject
                    MessageBox.Show("There are no questions for this subject. Please contact the administrator to add questions");
                    return;
                }

                // Create an array of groupboxes
                GroupBox[] questionGroupBoxes = { Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10 };

                // Shuffle the rows in the DataTable to get a random selection of questions
                Random rnd = new Random();
                var randomRows = dt.AsEnumerable().OrderBy(r => rnd.Next()).Take(10).ToList();

                // Iterate through the randomly selected rows and assign the questions to their respective groupboxes
                int i = 0;
                foreach (DataRow dr in randomRows)
                {
                    if (i >= questionGroupBoxes.Length)
                    {
                        break; // Stop adding questions if we have more rows than groupboxes
                    }

                    // Assign the question and answer choices to the corresponding controls in the groupbox
                    questionGroupBoxes[i].Text = dr["QDesc"].ToString();
                    ((RadioButton)questionGroupBoxes[i].Controls["Q" + (i + 1) + "o1"]).Text = dr["QQ1"].ToString();
                    ((RadioButton)questionGroupBoxes[i].Controls["Q" + (i + 1) + "o2"]).Text = dr["QQ2"].ToString();
                    ((RadioButton)questionGroupBoxes[i].Controls["Q" + (i + 1) + "o3"]).Text = dr["QQ3"].ToString();
                    ((RadioButton)questionGroupBoxes[i].Controls["Q" + (i + 1) + "o4"]).Text = dr["QQ4"].ToString();

                    // Store the correct answer for this question
                    Ua[i] = dr["QA"].ToString();

                    i++;
                }

                // Hide unused groupboxes if there are fewer than 10 questions
                for (int j = i; j < questionGroupBoxes.Length; j++)
                {
                    questionGroupBoxes[j].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void SaveHighest()
        {
            try
            {
                Con.Open();

                // Check if the candidate has a highest score
                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT MAX(RScore) FROM ResultTbl WHERE RCandidate = @candidate", Con);
                sda2.SelectCommand.Parameters.AddWithValue("@candidate", labelName.Text);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);

                if (dt2.Rows[0][0] != DBNull.Value)
                {
                    int BestScore;
                    if (int.TryParse(dt2.Rows[0][0].ToString(), out BestScore))
                    {
                        // Updatethe employee record with the highest score
                        SqlCommand cmd = new SqlCommand("UPDATE employees SET score = @score WHERE username = @username", Con);
                        cmd.Parameters.AddWithValue("@score", BestScore);
                        cmd.Parameters.AddWithValue("@username", labelName.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Highest score saved!");
                    }
                    else
                    {
                        MessageBox.Show("Error: The highest score is not a valid number.");
                    }
                }
                else
                {
                    MessageBox.Show("Error: There are no scores for this candidate.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        int chrono = 350;
        int count = 0;
        private bool isTimeOver = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            chrono -= 1;
            count += 1;
            TimingBar.Value = count;
            TimeLabel.Text = "" + chrono;

            // Check if the time is over and the submit button has not been clicked yet
            if (TimingBar.Value == 350 && !submitbtn.Enabled && !isTimeOver)
            {
                // Set the flag to indicate that the "Time Over" message box has been displayed
                isTimeOver = true;

                TimingBar.Value = 0;

                // Display the "Time Over" message box
                MessageBox.Show("Time Over");

                // Move to the EmployeeBord form
                EmployeeBord empbord = new EmployeeBord();
                empbord.Show();
                this.Hide();
            }
            else if (TimingBar.Value == 350 && submitbtn.Enabled && !isTimeOver)
            {
                // Set the flag to indicate that the "Time Over" message box has been displayed
                isTimeOver = true;

                // Disable the submit button
                submitbtn.Enabled = false;

                // Display the "Time Over" message box
                MessageBox.Show("Time Over");

                // Move to the EmployeeBord form
                EmployeeBord empbord = new EmployeeBord();
                empbord.Show();
                this.Hide();
            }
        }
        private void Exams_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int score = 0;


        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();
            int numQuestionsDisplayed = this.Controls.OfType<GroupBox>().Count(gb => gb.Name.StartsWith("Q") && gb.Visible);
            if (numQuestionsDisplayed < 10)
            {
                MessageBox.Show("Only " + numQuestionsDisplayed + " questions were displayed in this exam because there are not enough questions available. Please contact the administrator to add more questions.");
            }

            score = 0;

            // Check each question's selected radio button for the correct answer
            for (int i = 1; i <= numQuestionsDisplayed; i++)
            {
                GroupBox groupBox = (GroupBox)this.Controls["Q" + i];
                RadioButton radioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radioButton != null && radioButton.Text == Ua[i - 1])
                {
                    score++;
                }
            }

            // Display the score
            MessageBox.Show("Your score is " + score + " out of " + numQuestionsDisplayed);

            // Insert the result into the database and save the highest score if applicable
            InsertResult();
            SaveHighest();

            // Return to the login form
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }
        private void InsertResult()
        {
            try
            {
                Con.Open();

                // Check if the candidate has taken the same exam before
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM ResultTbl WHERE RCandidate=@candidate AND RSubject=@subject AND RDate=@date", Con);
                cmd1.Parameters.AddWithValue("@candidate", labelName.Text);
                cmd1.Parameters.AddWithValue("@subject", labelSubject.Text);
                cmd1.Parameters.AddWithValue("@date", QdateTimeP.Value.Date);
                int count = Convert.ToInt32(cmd1.ExecuteScalar());

                if (count > 0)
                {
                    // Get the highest score for the candidate and subject
                    SqlCommand cmd2 = new SqlCommand("SELECT MAX(RScore) FROM ResultTbl WHERE RCandidate=@candidate AND RSubject=@subject AND RDate=@date", Con);
                    cmd2.Parameters.AddWithValue("@candidate", labelName.Text);
                    cmd2.Parameters.AddWithValue("@subject", labelSubject.Text);
                    cmd2.Parameters.AddWithValue("@date", QdateTimeP.Value.Date);
                    int highestScore = Convert.ToInt32(cmd2.ExecuteScalar());

                    //Compare the new score with the highest score and update the record if the new score is higher
                    if (score > highestScore)
                    {
                        SqlCommand cmd3 = new SqlCommand("UPDATE ResultTbl SET RScore=@score WHERE RCandidate=@candidate AND RSubject=@subject AND RDate=@date", Con);
                        cmd3.Parameters.AddWithValue("@score", score);
                        cmd3.Parameters.AddWithValue("@candidate", labelName.Text);
                        cmd3.Parameters.AddWithValue("@subject", labelSubject.Text);
                        cmd3.Parameters.AddWithValue("@date", QdateTimeP.Value.Date);
                        cmd3.ExecuteNonQuery();

                        MessageBox.Show("Score updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Score is not higher than the previous score.");
                    }
                }
                else
                {
                    // Insert a new record
                    SqlCommand cmd4 = new SqlCommand("INSERT INTO ResultTbl (RCandidate, RSubject, RScore, RDate,RTime) VALUES (@candidate, @subject, @score, @date,GETDATE())", Con);
                    cmd4.Parameters.AddWithValue("@candidate", labelName.Text);
                    cmd4.Parameters.AddWithValue("@subject", labelSubject.Text);
                    cmd4.Parameters.AddWithValue("@score", score);
                    cmd4.Parameters.AddWithValue("@date", QdateTimeP.Value.Date);
                    cmd4.ExecuteNonQuery();

                    MessageBox.Show("Score inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}