using Essai.Classes;
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
    public partial class ScoreForm : Form
    {
        CourseClass course = new CourseClass();
        EmployeeClass employee = new EmployeeClass();
        ScoreClass score = new ScoreClass();
        public ScoreForm()
        {
            InitializeComponent();
        }
        // function to show data on datagridview score
        private void showScore()
        {
            DataGridViewEmployeeList.DataSource = score.getList(new MySqlCommand("SELECT Score.EmployeeId,employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName,Score.Score,score.Description\r\nFROM employee INNER JOIN score ON Score.EmployeeId=employee.EmployeeId"));
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            //populate the comoboBox with courses name
            comboBox_selectCourse.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseName";
            //to show data on score datagridview
            // showScore();

            //To display employee list in datagridview
            DataGridViewEmployeeList.DataSource = employee.getList(new MySqlCommand("SELECT `EmployeeId`,`EmployeeFirstName`,`EmployeeLastName` FROM `employee` "));
        }

        private void button_add_Click(object sender, EventArgs e)
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

                if (!score.checkScore(stdId, cName))
                {



                    if (score.insertScore(stdId, cName, scor, desc))
                    {
                        showScore();
                        button_clear.PerformClick();
                        MessageBox.Show("New Score added successfully !! ", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Score not added!! ", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
                else
                {
                    MessageBox.Show("The score for this course already exists ", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_studentId.Clear();
            textBox_score.Clear();
            comboBox_selectCourse.SelectedIndex = 0;
            textBox_description.Clear();
        }

        private void DataGridViewEmployeeList_Click(object sender, EventArgs e)
        {
            textBox_studentId.Text = DataGridViewEmployeeList.CurrentRow.Cells[0].Value.ToString();
        }



        private void button_sStudent_Click(object sender, EventArgs e)
        {
            DataGridViewEmployeeList.DataSource = employee.getList(new MySqlCommand("SELECT `EmployeeId`,`EmployeeFirstName`,`EmployeeLastName` FROM `employee` "));

        }

        private void button_sScore_Click(object sender, EventArgs e)
        {
            showScore();

        }


    }
}
