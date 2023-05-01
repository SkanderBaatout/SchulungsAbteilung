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
    public partial class Candidats : Form
    {
        public Candidats()
        {
            InitializeComponent();

            DisplayCandidates();
        }
        private void Reset()
        {
            CName.Text = "";
            CCin.Text = "";
            dateTimePicker.Value = DateTime.Now;
            CPassword.Text = "";
            CPhone.Text = "";
        }

        SqlConnection Con = new SqlConnection("data source = SKANDERBAATOUT;database = quiz ; integrated security = True ; TrustServerCertificate=True");
        private void DisplayCandidates()
        {
            Con.Open();
            String Query = "select * from employees ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            candidatesList.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || CCin.Text == "" || dateTimePicker.Value == DateTime.Now || CPassword.Text == "" || CPhone.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    // SqlCommand cmd = new SqlCommand("insert into employees values (username,password,mobile,birtday,cin,score ) values (@cn,@cp,@cm,@cb,@cc,@cs)", Con);
                    SqlCommand cmd = new SqlCommand("INSERT INTO employees (username, password, mobile, birthday, cin, score) VALUES (@cn, @cp, @cm, @cb, @cc, @cs)", Con);
                    //(@cn,@cp,@cm,@cb,@cc,@cs)
                    cmd.Parameters.AddWithValue("@cn", CName.Text);
                    cmd.Parameters.AddWithValue("@cp", CPassword.Text);
                    cmd.Parameters.AddWithValue("@cm", CPhone.Text);
                    cmd.Parameters.AddWithValue("@cb", dateTimePicker.Value);
                    //cmd.Parameters.AddWithValue("@cb", CBirthday.Text);
                    cmd.Parameters.AddWithValue("@cc", CCin.Text);
                    cmd.Parameters.AddWithValue("@cs", score);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Saved.");

                    Con.Close();
                    Reset();
                    DisplayCandidates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void candidatesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CName.Text = candidatesList.SelectedRows[0].Cells[1].Value.ToString();
            CCin.Text = candidatesList.SelectedRows[0].Cells[7].Value.ToString();
            dateTimePicker.Value = DateTime.Parse(candidatesList.SelectedRows[0].Cells[6].Value.ToString());
            CPassword.Text = candidatesList.SelectedRows[0].Cells[2].Value.ToString();
            CPhone.Text = candidatesList.SelectedRows[0].Cells[5].Value.ToString();
            if (CName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(candidatesList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || CCin.Text == "" || dateTimePicker.Value == DateTime.Now || CPassword.Text == "" || CPhone.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    // SqlCommand cmd = new SqlCommand("insert into employees values (username,password,mobile,birtday,cin,score ) values (@cn,@cp,@cm,@cb,@cc,@cs)", Con);
                    SqlCommand cmd = new SqlCommand("Update employees set username=@cn, password=@cp ,mobile=@cm, birthday=@cb,cin=@cc WHERE id=@CKey", Con);
                    //(@cn,@cp,@cm,@cb,@cc,@cs)
                    cmd.Parameters.AddWithValue("@cn", CName.Text);
                    cmd.Parameters.AddWithValue("@cp", CPassword.Text);
                    cmd.Parameters.AddWithValue("@cm", CPhone.Text);
                    cmd.Parameters.AddWithValue("@cb", dateTimePicker.Value);
                    //cmd.Parameters.AddWithValue("@cb", CBirthday.Text);
                    cmd.Parameters.AddWithValue("@cc", CCin.Text);
                    cmd.Parameters.AddWithValue("@CKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Updated.");

                    Con.Close();
                    Reset();
                    DisplayCandidates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }
    }
}
