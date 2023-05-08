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
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            if (textBox_courseName.Text == "" || textBox_hour.Text == "")
            {
                MessageBox.Show("Need Course Data!! ", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {


                string cName = textBox_courseName.Text;
                int chr = Convert.ToInt32(textBox_hour.Text);
                string desc = textBox_description.Text;

                if (course.insertCourse(cName, chr, desc))
                {
                    button_clear.PerformClick();
                    MessageBox.Show("New Course inserted successfully !! ", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Course not inserted!! ", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_courseName.Clear();
            textBox_hour.Clear();
            textBox_description.Clear();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {

            // to show courses list in DataGridView
            DataGridViewCourses.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }
    }
}
