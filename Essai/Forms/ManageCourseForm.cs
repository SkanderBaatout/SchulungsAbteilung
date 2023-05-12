using Essai.Utils.Classes;
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
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        //show data of the course
        private void showData()
        {
            //to show course list on datagridview
            DataGridViewCourses.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_courseName.Clear();
            textBox_hour.Clear();
            textBox_description.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_courseName.Text == "" || textBox_hour.Text == "" || textBox_id.Text.Equals(""))
            {
                MessageBox.Show("Need Course Data!! ", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {

                int id = Convert.ToInt32(textBox_id.Text);
                string cName = textBox_courseName.Text;
                int chr = Convert.ToInt32(textBox_hour.Text);
                string desc = textBox_description.Text;

                if (course.updateCourse(id, cName, chr, desc))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("Course updated successfully !! ", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Error Course Not Edited!! ", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Equals(""))
            {
                MessageBox.Show("Need Course ID!! ", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    if (course.deleteCourse(id))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("Course Deleted successfully !! ", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }

        private void DataGridViewCourses_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridViewCourses.CurrentRow.Cells[0].Value.ToString();
            textBox_courseName.Text = DataGridViewCourses.CurrentRow.Cells[1].Value.ToString();
            textBox_hour.Text = DataGridViewCourses.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = DataGridViewCourses.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // to search course and show on datagridview
            DataGridViewCourses.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT (`courseName`) LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }
    }
}
