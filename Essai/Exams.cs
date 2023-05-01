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
            FetchQuestions();
            //MultiRandom();
            // timer1.Start();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");
        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        private int GenerateRandom()
        {
            Random rd = new Random();
            int x = rd.Next(1, 4);
            int y = rd.Next(1, 4);
            int z = rd.Next(1, 4);
            MessageBox.Show("" + x + "and" + y + "and" + z);
            return x;
        }
        int[] keys = new int[10];
        private void MultiRandom()
        {
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
            /* for (int y=0; y< 5; y++)
            {
                MessageBox.Show("" + keys[y]);
            } */
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
        private void submitbtn_Click_1(object sender, EventArgs e)
        {

        }
        string[] Ua = new string[10];   
        private void Q1o1_CheckedChanged(object sender, EventArgs e)
        {
            Ua[0] = Q1o1.Text;
            MessageBox.Show("Selected answer is " + Ua[0]);
        }
    }
}
