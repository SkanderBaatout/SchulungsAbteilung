﻿using Microsoft.Data.SqlClient;
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
           
            labelName.Text = LoginForm.username;
            labelSubject.Text = EmployeeBord.trainingName;
            Qn = CountQuestions();
            FetchQuestions();
            //SaveHighest();

        }
        int Qn;
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");
        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        string[] Ua = new string[10];

        private int CountQuestions()
        {
            int Qnum;
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from QuestionTbl where QS ='" + labelSubject.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Qnum = Convert.ToInt32(dt.Rows[0][0]);
            Con.Close();
           // MessageBox.Show("" + Qnum);
            return Qnum;
        }
        private void SaveHighest()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(RScore) from  ResultTbl Where RCandidate = '"+labelName.Text+"' ", Con);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            int BestScore = Convert.ToInt32(dt2.Rows[0][0].ToString());
            try
            {
                SqlCommand cmd = new SqlCommand("Update employees set score=@sc WHERE username=@cn", Con);
                cmd.Parameters.AddWithValue("@cn", labelName.Text);
                cmd.Parameters.AddWithValue("@cs", BestScore);
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Candidate Updated.");

                Con.Close();
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Con.Close();
        }
       
        int[] keys = new int[10];

        private void MultiRandom()
        {
            //Generate 10 random numbers
            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count < 10)
            {
                numbers.Add(rnd.Next(1, Qn));
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
                // int QNum = GenerateRandom();
                MultiRandom();
                Con.Open();
                String Query = "select * from QuestionTbl WHERE QId = '" + keys[0] + "'  ";
                SqlCommand cmd = new SqlCommand(Query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q1.Text = dr["QDesc"].ToString();
                    Q1o1.Text = dr["QQ1"].ToString();
                    Q1o2.Text = dr["QQ2"].ToString();
                    Q1o3.Text = dr["QQ3"].ToString();
                    Q1o4.Text = dr["QQ4"].ToString();
                    a1 = dr["QA"].ToString();

                }
                String Query1 = "select * from QuestionTbl WHERE QId = '" + keys[1] + "'  ";
                cmd = new SqlCommand(Query1, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q2.Text = dr["QDesc"].ToString();
                    Q2o1.Text = dr["QQ1"].ToString();
                    Q2o2.Text = dr["QQ2"].ToString();
                    Q2o3.Text = dr["QQ3"].ToString();
                    Q2o4.Text = dr["QQ4"].ToString();
                    a2 = dr["QA"].ToString();

                }
                String Query2 = "select * from QuestionTbl WHERE QId = '" + keys[2] + "'  ";
                cmd = new SqlCommand(Query2, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q3.Text = dr["QDesc"].ToString();
                    Q3o1.Text = dr["QQ1"].ToString();
                    Q3o2.Text = dr["QQ2"].ToString();
                    Q3o3.Text = dr["QQ3"].ToString();
                    Q3o4.Text = dr["QQ4"].ToString();
                    a3 = dr["QA"].ToString();

                }
                String Query3 = "select * from QuestionTbl WHERE QId = '" + keys[3] + "'  ";
                cmd = new SqlCommand(Query3, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q4.Text = dr["QDesc"].ToString();
                    Q4o1.Text = dr["QQ1"].ToString();
                    Q4o2.Text = dr["QQ2"].ToString();
                    Q4o3.Text = dr["QQ3"].ToString();
                    Q4o4.Text = dr["QQ4"].ToString();
                    a4 = dr["QA"].ToString();

                }
                String Query4 = "select * from QuestionTbl WHERE QId = '" + keys[4] + "'  ";
                cmd = new SqlCommand(Query4, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q5.Text = dr["QDesc"].ToString();
                    Q5o1.Text = dr["QQ1"].ToString();
                    Q5o2.Text = dr["QQ2"].ToString();
                    Q5o3.Text = dr["QQ3"].ToString();
                    Q5o4.Text = dr["QQ4"].ToString();
                    a5 = dr["QA"].ToString();

                }
                String Query5 = "select * from QuestionTbl WHERE QId = '" + keys[5] + "'  ";
                cmd = new SqlCommand(Query5, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q6.Text = dr["QDesc"].ToString();
                    Q6o1.Text = dr["QQ1"].ToString();
                    Q6o2.Text = dr["QQ2"].ToString();
                    Q6o3.Text = dr["QQ3"].ToString();
                    Q6o4.Text = dr["QQ4"].ToString();
                    a6 = dr["QA"].ToString();

                }
                String Query6 = "select * from QuestionTbl WHERE QId = '" + keys[6] + "'  ";
                cmd = new SqlCommand(Query6, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q7.Text = dr["QDesc"].ToString();
                    Q7o1.Text = dr["QQ1"].ToString();
                    Q7o2.Text = dr["QQ2"].ToString();
                    Q7o3.Text = dr["QQ3"].ToString();
                    Q7o4.Text = dr["QQ4"].ToString();
                    a7 = dr["QA"].ToString();

                }
                String Query7 = "select * from QuestionTbl WHERE QId = '" + keys[7] + "'  ";
                cmd = new SqlCommand(Query7, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q8.Text = dr["QDesc"].ToString();
                    Q8o1.Text = dr["QQ1"].ToString();
                    Q8o2.Text = dr["QQ2"].ToString();
                    Q8o3.Text = dr["QQ3"].ToString();
                    Q8o4.Text = dr["QQ4"].ToString();
                    a8 = dr["QA"].ToString();

                }
                String Query8 = "select * from QuestionTbl WHERE QId = '" + keys[8] + "'  ";
                cmd = new SqlCommand(Query8, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q9.Text = dr["QDesc"].ToString();
                    Q9o1.Text = dr["QQ1"].ToString();
                    Q9o2.Text = dr["QQ2"].ToString();
                    Q9o3.Text = dr["QQ3"].ToString();
                    Q9o4.Text = dr["QQ4"].ToString();
                    a9 = dr["QA"].ToString();

                }
                String Query9 = "select * from QuestionTbl WHERE QId = '" + keys[9] + "'  ";
                cmd = new SqlCommand(Query9, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q10.Text = dr["QDesc"].ToString();
                    Q10o1.Text = dr["QQ1"].ToString();
                    Q10o2.Text = dr["QQ2"].ToString();
                    Q10o3.Text = dr["QQ3"].ToString();
                    Q10o4.Text = dr["QQ4"].ToString();
                    a10 = dr["QA"].ToString();

                }
                Con.Close();
            }
            catch (Exception ex)
            {

            }

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

        }
        int chrono = 350;
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            chrono -= 1;
            count += 1;
            TimingBar.Value = count;
            TimeLabel.Text = "" + chrono;
            if (TimingBar.Value == 350)
            {
                TimingBar.Value = 0;
                timer1.Stop();
                MessageBox.Show("Time Over");
                this.Hide();
                LoginForm log = new LoginForm();
                log.Show();
            }
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int score = 0;
        private void checkQ1()
        {
            if (Q1o1.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1o1.Text;
            }
            else if (Q1o2.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1o2.Text;
            }
            else if (Q1o3.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1o3.Text;
            }
            else if (Q1o4.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1o4.Text;
            }
            if (Ua[0] == a1)
            {
                score = score + 1;
            }
            else
            {
                score = score;
            }
        }
        private void checkQ2()
        {
            if (Q2o1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2o1.Text;
            }
            else if (Q2o2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2o2.Text;
            }
            else if (Q2o3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2o3.Text;
            }
            else if (Q2o4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2o4.Text;
            }
            if (Ua[1] == a2)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ3()
        {
            if (Q3o1.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3o1.Text;
            }
            else if (Q3o2.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3o2.Text;
            }
            else if (Q3o3.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3o3.Text;
            }
            else if (Q3o4.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3o4.Text;
            }
            if (Ua[2] == a3)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ4()
        {
            if (Q4o1.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4o1.Text;
            }
            else if (Q4o2.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4o2.Text;
            }
            else if (Q4o3.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4o3.Text;
            }
            else if (Q4o4.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4o4.Text;
            }
            if (Ua[3] == a4)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ5()
        {
            if (Q5o1.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5o1.Text;
            }
            else if (Q5o2.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5o2.Text;
            }
            else if (Q5o3.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5o3.Text;
            }
            else if (Q5o4.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5o4.Text;
            }
            if (Ua[4] == a5)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ6()
        {
            if (Q6o1.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6o1.Text;
            }
            else if (Q6o2.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6o2.Text;
            }
            else if (Q6o3.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6o3.Text;
            }
            else if (Q6o4.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6o4.Text;
            }
            if (Ua[5] == a6)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ7()
        {
            if (Q7o1.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7o1.Text;
            }
            else if (Q7o2.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7o2.Text;
            }
            else if (Q7o3.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7o3.Text;
            }
            else if (Q7o4.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7o4.Text;
            }
            if (Ua[6] == a7)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ8()
        {
            if (Q8o1.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8o1.Text;
            }
            else if (Q8o2.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8o2.Text;
            }
            else if (Q8o3.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8o3.Text;
            }
            else if (Q8o4.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8o4.Text;
            }
            if (Ua[7] == a8)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ9()
        {
            if (Q9o1.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9o1.Text;
            }
            else if (Q9o2.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9o2.Text;
            }
            else if (Q9o3.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9o3.Text;
            }
            else if (Q9o4.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9o4.Text;
            }
            if (Ua[8] == a9)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }
        private void checkQ10()
        {
            if (Q10o1.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10o1.Text;
            }
            else if (Q10o2.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10o2.Text;
            }
            else if (Q10o3.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10o3.Text;
            }
            else if (Q10o4.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10o4.Text;
            }
            if (Ua[9] == a10)
            {
                score = score + 1;
            }
            else
            {
                //score = score;
            }
        }



        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            score = 0;
            checkQ1();
            checkQ2();
            checkQ3();
            checkQ4();
            checkQ5();
            checkQ6();
            checkQ7();
            checkQ8();
            checkQ9();
            checkQ10();
            MessageBox.Show("" + score);
            InsertResult();
            SaveHighest();
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();

        }
        private void Reset()
        {

        }
        private void InsertResult()
        {
            try
            {

                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ResultTbl (RSubject, RCandidate, RDate, RTime,RScore) VALUES (@rs, @rc, @rd, @rt, @rsc)", Con);
                //@rs, @rc, @rd, @rt, @rsc
                cmd.Parameters.AddWithValue("@rs", labelSubject.Text);
                cmd.Parameters.AddWithValue("@rc", labelName.Text);
                cmd.Parameters.AddWithValue("@rd", QdateTimeP.Value.Date);
                cmd.Parameters.AddWithValue("@rt", QTime.Text);
                cmd.Parameters.AddWithValue("@rsc", score);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Result Saved.");

                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Q1o1_CheckedChanged(object sender, EventArgs e)
        {
            // Ua[0] = Q1o1.Text;
            //MessageBox.Show("Selected answer is " + Ua[0]);
        }

        private void Q1o2_CheckedChanged(object sender, EventArgs e)
        {
            // Ua[0] = Q1o2.Text;
            // MessageBox.Show("Selected answer is " + Ua[0]);
            // 
        }
    }
}