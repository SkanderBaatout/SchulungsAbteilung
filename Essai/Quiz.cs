using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        
        public Quiz()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
           // score = 0;
            getSet();
            nextQuestions();
            i = 0;
            
           
   

        }

        private void nextQuestions()
        {
            query = "select question,optionA,optionB,optionC,optionD,ans from questions  where qset = '" + label_totalQuestions.Text + "'";
            ds = fn.getData(query);


            //query= "select COUNT (question) from questions where qset = '" + label_totalQuestions.Text + "'";
            int QuestNum = ds.Tables[0].Rows.Count;
            if (i < QuestNum)
            {
                if(radioButton1.Checked | radioButton2.Checked | radioButton3.Checked | radioButton4.Checked)
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
                       
                    } else
                    {
                      
                        i++;
                    }
                   
                }
                else
                {
                    MessageBox.Show("No Question Selected !!, Select One At Least", "Error");
                }

             
            } else
            {
                QuestNum = 0;
                MessageBox.Show(score + "");
            }



        }
        int c;
        int score;
        private void correct()
        {
            if (radioButton1.Checked)
            {
                c = 1;
            } else if (radioButton2.Checked)
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
            nextQuestions();
        }
        private void getSet()
        {
            query = "SELECT   TOP 1 qset FROM questions ORDER BY NewID();";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                label_totalQuestions.Text = ds.Tables[0].Rows[i][0].ToString();
            }
        }
        private int getQuestionId(int id )
        {
            query = "select * from questions  ";
            ds = fn.getData(query);

            id = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());

            return id; 
        }
    }
}
