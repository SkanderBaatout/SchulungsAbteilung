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
    public partial class AddQuestionForm : Form
    {
        Function fn = new Function();
        string query;
        DataSet ds;
        Int64 questionNo = 1;
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
            query = "select max(qset) from questions";

            ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                textBox_set.Text = (id + 1).ToString();

            }
            else
            {
                textBox_set.Text = "1";
            }
            questionLabel.Text = questionNo.ToString();
            label_NoSet.Visible = false;


        }

        private void textBox_set_TextChanged(object sender, EventArgs e)
        {
            if (textBox_set.Text != "")
            {
                clearAll();
                query = "select qNo from questions where qset = '" + textBox_set.Text + "' ";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    questionLabel.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(questionLabel.Text.ToString());

                }
                else
                {
                    questionLabel.Text = "1";
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                    label_NoSet.Visible = true;
                }
            }
        }

        private void textBox_question_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string qSet = textBox_set.Text;
            string qNo = questionNo.ToString();
            string question = textBox_question.Text;
            string option1 = textBox_option1.Text;
            string option2 = textBox_option2.Text;
            string option3 = textBox_option3.Text;
            string option4 = textBox_option4.Text;
            string ans = textBox_answer.Text;
            // Image image = pictureBox2.Image;
            byte[] imageBytes = null; // Déclarer un tableau d'octets pour stocker les données de l'image




            if (pictureBox2.Image != null)
            {
                // Convertir l'image en tableau d'octets
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }

                query = "insert into questions (qset,qNo,question,optionA,optionB,optionC,optionD,ans,photo) values ('" + qSet + "','" + qNo + "','" + question + "','" + option1 + "','" + option2 + "','" + option3 + "','" + option4 + "','" + ans + "', CONVERT(varbinary,'" + imageBytes + "') )";
                fn.setData(query, "Question Added");

            }
            else
            {

                query = "insert into questions (qset,qNo,question,optionA,optionB,optionC,optionD,ans,photo) values ('" + qSet + "','" + qNo + "','" + question + "','" + option1 + "','" + option2 + "','" + option3 + "','" + option4 + "','" + ans + "',(NULL) )";
                fn.setData(query, "Question Added");
            }

            clearAll();

            questionNo++;
            questionLabel.Text = questionNo.ToString();
        }

        public void clearAll()
        {
            textBox_question.Clear();
            textBox_option1.Clear();
            textBox_option2.Clear();
            textBox_option3.Clear();
            textBox_option4.Clear();
            textBox_answer.Clear();
            pictureBox2.Image = null;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Set Will be Changed.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                textBox_set.Text = (Int64.Parse(textBox_set.Text.ToString()) + 1).ToString();
                questionLabel.Text = "1";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
