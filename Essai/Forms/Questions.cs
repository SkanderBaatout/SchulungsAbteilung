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
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
        }
        private void Reset()
        {
            question.Text = "";
            option1.Text = "";
            option2.Text = "";
            option3.Text = "";
            option4.Text = "";
            answer.Text = "";
            SubjectcomboBox.SelectedIndex = 0;
        }
        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");
        private void DisplayQuestions()
        {
            using (SqlConnection con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True"))
            {
                con.Open();
                String Query = "select * from QuestionTbl  ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                questionListDGV.DataSource = ds.Tables[0];
            }
        }
        private void GetSubjects()
        {
            using (SqlConnection con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select SName from SubjectTbl  ", con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("SName", typeof(string));
                dt.Load(rdr);
                SubjectcomboBox.ValueMember = "SName";
                SubjectcomboBox.DataSource = dt;
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (question.Text == "" || option1.Text == "" || option2.Text == "" || option3.Text == "" || option4.Text == "" || answer.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO QuestionTbl (QDesc, QQ1, QQ2, QQ3, QQ4,QA,QS) VALUES (@qd, @o1, @o2, @o3, @o4, @qa,@qs)", con);
                        //@qd, @o1, @o2, @o3, @o4, @qa,@qs
                        cmd.Parameters.AddWithValue("@qd", question.Text);
                        cmd.Parameters.AddWithValue("@o1", option1.Text);
                        cmd.Parameters.AddWithValue("@o2", option2.Text);
                        cmd.Parameters.AddWithValue("@o3", option3.Text);
                        cmd.Parameters.AddWithValue("@o4", option4.Text);
                        cmd.Parameters.AddWithValue("@qa", answer.Text);
                        cmd.Parameters.AddWithValue("@qs", SubjectcomboBox.SelectedValue.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Question Saved.");
                    }
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (question.Text == "" || option1.Text == "" || option2.Text == "" || option3.Text == "" || option4.Text == "" || answer.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True"))
                    {
                        con.Open();
                        // SqlCommand cmd = new SqlCommand("insert into employees values (username,password,mobile,birtday,cin,score ) values (@cn,@cp,@cm,@cb,@cc,@cs)", Con);
                        SqlCommand cmd = new SqlCommand("Update QuestionTbl set QDesc=@qd, QQ1=@o1, QQ2=@o2, QQ3=@o3, QQ4=@o4,QA=@qa,QS=@qs WHERE QId=@QKey", con);
                        cmd.Parameters.AddWithValue("@qd", question.Text);
                        cmd.Parameters.AddWithValue("@o1", option1.Text);
                        cmd.Parameters.AddWithValue("@o2", option2.Text);
                        cmd.Parameters.AddWithValue("@o3", option3.Text);
                        cmd.Parameters.AddWithValue("@o4", option4.Text);
                        cmd.Parameters.AddWithValue("@qa", answer.Text);
                        cmd.Parameters.AddWithValue("@qs", SubjectcomboBox.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@QKey", key);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Question Updated.");
                    }
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void questionListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            question.Text = questionListDGV.SelectedRows[0].Cells[1].Value.ToString();
            option1.Text = questionListDGV.SelectedRows[0].Cells[2].Value.ToString();
            option2.Text = questionListDGV.SelectedRows[0].Cells[3].Value.ToString();
            option3.Text = questionListDGV.SelectedRows[0].Cells[4].Value.ToString();
            option4.Text = questionListDGV.SelectedRows[0].Cells[5].Value.ToString();
            answer.Text = questionListDGV.SelectedRows[0].Cells[6].Value.ToString();
            SubjectcomboBox.SelectedValue = questionListDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (question.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(questionListDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Questions_Load(object sender, EventArgs e)
        {
            questionListDGV.Columns["QId"].Visible = false;
        }

        private void SubjectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSubject = SubjectcomboBox.SelectedValue?.ToString();

            // If no subject is selected, display all questions
            if (string.IsNullOrEmpty(selectedSubject))
            {
                DisplayQuestions();
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "SELECT * FROM QuestionTbl WHERE QS = @selectedSubject";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@selectedSubject", selectedSubject);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    questionListDGV.DataSource = ds.Tables[0];
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
