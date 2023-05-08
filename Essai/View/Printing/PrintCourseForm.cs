using Essai.Classes;
using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essai
{
    public partial class PrintCourseForm : Form
    {
        CourseClass course = new CourseClass();
        DGVPrinter printer = new DGVPrinter();

        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void button_searc_Click(object sender, EventArgs e)
        {
            // to search course and show on datagridview
            DataGridViewCourses.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT (`courseName`) LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // we need DGVprinter helper for print pdf file
            printer.Title = "Draxlmaier Training list";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "2023";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridViewCourses);

        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {

            showData(new MySqlCommand("SELECT * FROM `course` "));
        }
        //create a function to show employee list in datagridview
        public void showData(MySqlCommand command)
        {
            DataGridViewCourses.ReadOnly = true;
            DataGridViewCourses.DataSource = course.getCourse(command);



        }
    }
}
