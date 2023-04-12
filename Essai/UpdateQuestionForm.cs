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
    public partial class UpdateQuestionForm : Form
    {
        Function fn = new Function();
        string query;

        public UpdateQuestionForm()
        {
            InitializeComponent();
        }



        private void textBox_answer_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void UpdateQuestionForm_Load(object sender, EventArgs e)
        {
            comboSet.Items.Clear();
            query = "select distinct qset from questions";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboQuestion.Items.Clear();
            query = "select qNo from questions where qset = '" + comboSet.Text + "' ";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void comboQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = " select question,optionA,optionB,optionC,optionD,ans,photo from questions where qset = '" + comboSet.Text + "' and qNo = '" + comboQuestion.Text + "' ";
            DataSet ds = fn.getData(query);



                if (ds.Tables[0].Rows[0][6] != DBNull.Value)
            {
                textBox_question.Text = ds.Tables[0].Rows[0][0].ToString();
                textBox_option1.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox_option2.Text = ds.Tables[0].Rows[0][2].ToString();
                textBox_option3.Text = ds.Tables[0].Rows[0][3].ToString();
                textBox_option4.Text = ds.Tables[0].Rows[0][4].ToString();
                textBox_answer.Text = ds.Tables[0].Rows[0][5].ToString();

                 byte[] img = (byte[])ds.Tables[0].Rows[0][6];
                 MemoryStream ms = new MemoryStream(img);
                 pictureBox2.Image = Image.FromStream(ms);
                //pictureBox2.Image=ConvertByteArrayToImage((byte[])ds.Tables[0].Rows[0][6]);
               // ConvertImageToBytes(pictureBox2.Image);

            }
            else
            {
                textBox_question.Text = ds.Tables[0].Rows[0][0].ToString();
                textBox_option1.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox_option2.Text = ds.Tables[0].Rows[0][2].ToString();
                textBox_option3.Text = ds.Tables[0].Rows[0][3].ToString();
                textBox_option4.Text = ds.Tables[0].Rows[0][4].ToString();
                textBox_answer.Text = ds.Tables[0].Rows[0][5].ToString();

                label9.Visible = false;
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearAll();
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
            comboSet.SelectedIndex = -1;
            comboQuestion.SelectedIndex = -1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (comboQuestion.SelectedIndex != -1)
            {
                string qSet = comboSet.Text;
                string qNo = comboQuestion.Text;
                string question = textBox_question.Text;
                string option1 = textBox_option1.Text;
                string option2 = textBox_option2.Text;
                string option3 = textBox_option3.Text;
                string option4 = textBox_option4.Text;
                string ans = textBox_answer.Text;

                // to get photo from picture box
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                byte[] img = ms.ToArray();

                query = "update questions set question = '" + question + "',optionA = '" + option1 + "',optionB = '" + option2 + "',optionC = '" + option3 + "',optionD = '" + option4 + "',ans = '" + ans + "' ,photo = '" + img + "' where qset = '" + qSet + "' and qNo = '" + qNo + "' ";

                fn.setData(query, "Question No : " + qNo + "\n Question Set :" + qSet + "\n  is Updated.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Select Question first.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }
    }
}
