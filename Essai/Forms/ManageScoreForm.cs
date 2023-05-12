using Essai.Utils.Classes;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
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
    public partial class ManageScoreForm : Form
    {
        CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //populate the comoboBox with courses name
            comboBox_selectCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseName";

            //to show score list in data grid view
            showScore();
        }

        public void showScore()
        {
            DataGridViewScores.DataSource = score.getList(new MySqlCommand("SELECT Score.EmployeeId,employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName,Score.Score,score.Description\r\nFROM employee INNER JOIN score ON Score.EmployeeId=employee.EmployeeId"));

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text == "" || textBox_score.Text == "")
            {
                MessageBox.Show("Need Score Data!! ", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                int stdId = Convert.ToInt32(textBox_studentId.Text);
                string cName = comboBox_selectCourse.Text;
                int scor = Convert.ToInt32(textBox_score.Text);
                string desc = textBox_description.Text;


                if (score.updateScore(stdId, cName, scor, desc))
                {
                    showScore();
                    button_clear.PerformClick();
                    MessageBox.Show(" Score edited successfully !! ", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Score not edited!! ", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_studentId.Text == "")
            {
                MessageBox.Show("Field Error - We need Employee ID!! ", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int id = Convert.ToInt32(textBox_studentId.Text);
                // display a confirmation msg before deleting 

                if (MessageBox.Show("Are you sure you want to delete this score?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(id))
                    {
                        showScore();
                        MessageBox.Show("Employee Removed ", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();

                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_studentId.Clear();
            textBox_search.Clear();
            textBox_score.Clear();
            textBox_description.Clear();
        }

        private void DataGridViewScores_Click(object sender, EventArgs e)
        {
            textBox_studentId.Text = DataGridViewScores.CurrentRow.Cells[0].Value.ToString();
            comboBox_selectCourse.Text = DataGridViewScores.CurrentRow.Cells[3].Value.ToString();
            textBox_score.Text = DataGridViewScores.CurrentRow.Cells[4].Value.ToString();
            textBox_description.Text = DataGridViewScores.CurrentRow.Cells[5].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

            DataGridViewScores.DataSource = score.getList(new MySqlCommand("SELECT Score.EmployeeId,employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName,Score.Score,score.Description FROM employee INNER JOIN score ON Score.EmployeeId=employee.EmployeeId WHERE CONCAT(employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName) LIKE '%"+ textBox_search.Text +"%'"));
            //SELECT Score.EmployeeId,employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName,Score.Score,score.Description FROM employee INNER JOIN score ON Score.EmployeeId=employee.EmployeeId WHERE CONCAT(employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName) LIKE "%IA"

        }
    }
}
