using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Added for MemoryStream
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai
{
    public partial class Quiz : Form
    {
        Function fn = new Function();
        string query;
        DataSet ds;
        static int i = 0;
        Int64 questionNo = 1;
        private int currentQuestionNo = 1; // Track the current question number
        private int totalQuestions = 0; // Track the total number of questions
        private int remainingTime = 0; // Track the remaining time in seconds
        private System.Windows.Forms.Timer timer; // Timer to update the label with remaining time


        public Quiz()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeBord form = new EmployeeBord();
            form.Show();
            this.Hide();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            label_nameEmp.Text = LoginForm.username;
            label_cinEmp.Text = LoginForm.cin;
            // score = 0;
            getSet();
            nextQuestions();
            i = 0;
            questionNumber();
            // Calculate the total time for all questions
            int totalTime = totalQuestions * 30;

            // Update the label with the total time
            label_total_Time.Text = totalTime.ToString() + " seconds";

            // Call the questionNo() method to get the total number of questions
            totalQuestions = questionNumber();

            // Set the initial remaining time to 30 seconds for the first question
            remainingTime = totalQuestions * 30;

            // Initialize the timer
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // Set the interval of the timer in milliseconds
            timer1.Tick += timer1_Tick_1; // Add an event handler for the Tick event of the timer
            timer1.Start(); // Start the timer

            // Update the label with the initial question number and remaining time
            qNo.Text = "Question " + currentQuestionNo.ToString() + " / " + totalQuestions.ToString();
            label_remainingTime.Text = remainingTime.ToString() + " seconds";
            label_total_Time.Text = remainingTime.ToString() + " seconds";

        }



        private void nextQuestions()
        {
            query = "select question,optionA,optionB,optionC,optionD,ans,photo from questions  where qset = '" + label_set.Text + "'";
            ds = fn.getData(query);

            int questNum = ds.Tables[0].Rows.Count;
            if (i < questNum)
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {

                    if (ds.Tables[0].Rows[i][6] != DBNull.Value)
                    {
                        label_question.Text = ds.Tables[0].Rows[i][0].ToString();
                        radioButton1.Text = ds.Tables[0].Rows[i][1].ToString();
                        radioButton2.Text = ds.Tables[0].Rows[i][2].ToString();
                        radioButton3.Text = ds.Tables[0].Rows[i][3].ToString();
                        radioButton4.Text = ds.Tables[0].Rows[i][4].ToString();

                        // Récupérer les données d'image depuis la colonne de la base de données
                        byte[] img = (byte[])ds.Tables[0].Rows[i][6];

                        if (img != null && img.Length > 0)
                        {
                            try
                            {
                                // Créer une image à partir des données d'image
                                using (MemoryStream ms = new MemoryStream(img))
                                {
                                    Image image = Image.FromStream(ms);
                                    pictureBox.Image = image;
                                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Une erreur s'est produite lors de la manipulation de l'image : " + ex.Message, "Erreur");
                            }
                        }
                        else
                        {
                            MessageBox.Show("L'image est vide ou nulle", "Erreur");
                        }


                        correct();
                        if (c == Convert.ToInt32(ds.Tables[0].Rows[i][5].ToString()))
                        {
                            score = score + 1;
                            i++;
                        }
                        else
                        {
                            i++;
                        }

                    }
                    else
                    {
                        label_question.Text = ds.Tables[0].Rows[i][0].ToString();
                        radioButton1.Text = ds.Tables[0].Rows[i][1].ToString();
                        radioButton2.Text = ds.Tables[0].Rows[i][2].ToString();
                        radioButton3.Text = ds.Tables[0].Rows[i][3].ToString();
                        radioButton4.Text = ds.Tables[0].Rows[i][4].ToString();

                        correct();
                        if (c == Convert.ToInt32(ds.Tables[0].Rows[i][5].ToString()))
                        {
                            score = score + 1;
                            i++;

                        }
                        else
                        {
                            i++;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Aucune question sélectionnée ! Sélectionnez au moins une question.", "Erreur");
                }
            }
            else
            {
                questNum = 0;
                // MessageBox.Show(score + "");
                // Display the score in custom dialog
                using (ScoreDialogForm scoreDialog = new ScoreDialogForm())
                {
                    scoreDialog.Score = score;
                    scoreDialog.ShowDialog();
                }
            }
        }

        int c;
        int score;
        private void correct()
        {
            if (radioButton1.Checked)
            {
                c = 1;
            }
            else if (radioButton2.Checked)
            {
                c = 2;
            }
            else if (radioButton3.Checked)
            {
                c = 3;
            }
            else if (radioButton4.Checked)
            {
                c = 4;
            }
        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentQuestionNo <= totalQuestions)
            {
                nextQuestions();
                qNo.Text = "Question " + (currentQuestionNo += 1).ToString() + " / " + totalQuestions.ToString();
            }


            else
            {
                timer1.Stop();

                MessageBox.Show("Vous avez terminé le quiz!", "Quiz terminé");

                btn_next.Text = "Submit";
                // Display the score in custom dialog
                using (ScoreDialogForm scoreDialog = new ScoreDialogForm())
                {
                    scoreDialog.Score = score;
                    scoreDialog.ShowDialog();
                }

                // Perform any other actions needed when all questions are finished
                // e.g. calculate final score, show result, etc.
            }
        }
        private void getSet()
        {
            query = "SELECT   TOP 1 qset FROM questions ORDER BY NewID();";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                label_set.Text = ds.Tables[0].Rows[i][0].ToString();
            }
        }

        private int questionNumber()
        {
            query = "select COUNT(question) from questions where qset = '" + label_set.Text + "' ";
            ds = fn.getData(query);
            int count = 0;

            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    count = Convert.ToInt32(ds.Tables[0].Rows[0][0]); // Retrieve the count from the first row of the result set
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Une erreur s'est produite lors de la récupération du nombre de questions : " + ex.Message, "Erreur");
            }
            qNo.Text = count.ToString();
            return count;


        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Update the remaining time and label
            remainingTime--;
            label_remainingTime.Text = remainingTime.ToString() + " seconds";

            // Check if the remaining time has reached 0
            if (remainingTime == 0)
            {
                // Move on to the next question
                currentQuestionNo++;

                // Check if all questions have been answered
                if (currentQuestionNo > totalQuestions)
                {
                    // Stop the timer
                    timer1.Stop();

                    // Show a message indicating the end of the quiz
                    MessageBox.Show("Quiz ended.", "Quiz Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Update the label with the next question number and reset the remaining time
                    qNo.Text = "Question " + currentQuestionNo.ToString() + " / " + totalQuestions.ToString();
                    remainingTime = 30;
                    label_remainingTime.Text = remainingTime.ToString() + " seconds";
                }
            }
        }
    }
}
