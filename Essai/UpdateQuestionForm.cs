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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Essai
{
    public partial class UpdateQuestionForm : Form
    {
        Function fn = new Function();
        string query;
        private readonly string _connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";


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
            string query = "select question, optionA, optionB, optionC, optionD, ans, PhotoData from questions where qset = @qSet and qNo = @qNo";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@qSet", comboSet.Text);
                command.Parameters.AddWithValue("@qNo", comboQuestion.Text);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox_question.Text = reader["question"].ToString();
                    textBox_option1.Text = reader["optionA"].ToString();
                    textBox_option2.Text = reader["optionB"].ToString();
                    textBox_option3.Text = reader["optionC"].ToString();
                    textBox_option4.Text = reader["optionD"].ToString();
                    textBox_answer.Text = reader["ans"].ToString();

                    if (reader["PhotoData"] != DBNull.Value)
                    {
                        byte[] img = (byte[])reader["PhotoData"];
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }
                }
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
            pictureBox.Image = null;
            comboSet.SelectedIndex = -1;
            comboQuestion.SelectedIndex = -1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (comboSet.Text != "" && comboQuestion.Text != "" && textBox_question.Text != "" && textBox_option1.Text != "" && textBox_option2.Text != "" && textBox_option3.Text != "" && textBox_option4.Text != "" && textBox_answer.Text != "")
            {
                string query = "update questions set question=@ques,optionA=@optA,optionB=@optB,optionC=@optC,optionD=@optD,ans=@ans,PhotoData=@img where qset=@qSet and qNo=@qNo";
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ques", textBox_question.Text);
                    command.Parameters.AddWithValue("@optA", textBox_option1.Text);
                    command.Parameters.AddWithValue("@optB", textBox_option2.Text);
                    command.Parameters.AddWithValue("@optC", textBox_option3.Text);
                    command.Parameters.AddWithValue("@optD", textBox_option4.Text);
                    command.Parameters.AddWithValue("@ans", textBox_answer.Text);
                    command.Parameters.AddWithValue("@qSet", comboSet.Text);
                    command.Parameters.AddWithValue("@qNo", comboQuestion.Text);

                    if (pictureBox.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                        byte[] img = ms.ToArray();
                        command.Parameters.AddWithValue("@img", img);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@img", DBNull.Value);
                    }

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Question Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Question Update Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
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
