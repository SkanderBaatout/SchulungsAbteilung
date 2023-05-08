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
    public partial class PrintScoreForm : Form
    {
        ScoreClass score = new();
        DGVPrinter printer = new DGVPrinter();

        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void button_searc_Click(object sender, EventArgs e)
        {
            DataGridViewScore.DataSource = score.getList(new MySqlCommand("SELECT Score.EmployeeId,employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName,Score.Score,score.Description FROM employee INNER JOIN score ON Score.EmployeeId=employee.EmployeeId WHERE CONCAT(employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName) LIKE '%" + textBox_search.Text + "%'"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // we need DGVprinter helper for print pdf file
            printer.Title = "Draxlmaier Employees Score list";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "2023";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridViewScore);
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showScore();
        }
        public void showScore()
        {
            DataGridViewScore.DataSource = score.getList(new MySqlCommand("SELECT Score.EmployeeId,employee.EmployeeFirstName,employee.EmployeeLastName,Score.CourseName,Score.Score,score.Description\r\nFROM employee INNER JOIN score ON Score.EmployeeId=employee.EmployeeId"));

        }
    }
}
