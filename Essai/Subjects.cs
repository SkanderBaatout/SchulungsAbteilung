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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        int key = 0;
        private void Reset()
        {
            subjectTb.Text = "";
            key = 0;
        }

        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");
        private void DisplaySubjects()
        {
            Con.Open();
            String Query = "select * from SubjectTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            subjectsList.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (subjectTb.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO SubjectTbl (SName) VALUES (@sn)", Con);

                    cmd.Parameters.AddWithValue("@sn", subjectTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Saved.");

                    Con.Close();
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (subjectTb.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update SubjectTbl set SName=@sn WHERE SId=@CKey", Con);

                    cmd.Parameters.AddWithValue("@sn", subjectTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated.");

                    Con.Close();
                    Reset();
                    DisplaySubjects();
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

        private void subjectsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            subjectTb.Text = subjectsList.SelectedRows[0].Cells[1].Value.ToString();

            if (subjectTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(subjectsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Candidats can = new Candidats();
            can.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
            Candidats can = new Candidats();
            can.Show();
            this.Hide();
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }
    }
}
