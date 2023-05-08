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
    public partial class PrintEmployee : Form
    {
        EmployeeClass employee = new EmployeeClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintEmployee()
        {
            InitializeComponent();
        }

        private void PrintEmployee_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `employee` "));
        }
        //create a function to show employee list in datagridview
        public void showData(MySqlCommand command)
        {
            DataGridViewEmployees.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridViewEmployees.DataSource = employee.getList(command);
            //column 7 is the image column index
            imageColumn = (DataGridViewImageColumn)DataGridViewEmployees.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;


        }

        private void button_searc_Click(object sender, EventArgs e)
        {
            //check the radio button
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM `employee`";
            }
            else if (radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM `employee` WHERE Gender='Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM `employee` WHERE Gender='Female'";
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            // we need DGVprinter helper for print pdf file
            printer.Title = "Draxlmaier employees list";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "2023";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridViewEmployees);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
        }

        private void label_id_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
        }

        private void button_update_Click(object sender, EventArgs e)
        {
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
        }

        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox_employee_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox_session_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
