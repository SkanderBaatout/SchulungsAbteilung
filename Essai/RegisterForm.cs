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
    public partial class RegisterForm : Form
    {

        EmployeeClass employee = new EmployeeClass();
        public RegisterForm()
        {
            InitializeComponent();
        }


        //create a function to verify
        bool verify()
        {
            if ((textBox_firstName.Text == "") || (textBox_lastName.Text == "") || (textBox_phone.Text == "")
                || (textBox_address.Text == "") || (pictureBox_employee.Image == null))
            {
                return false;
            }
            else
                return true;
        }



        // to display employees list in datagridview
        public void showTable()
        {
            DataGridViewEmployees.DataSource = employee.getEmployeeList(new MySqlCommand("SELECT * FROM `employee` "));

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridViewEmployees.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void button_upload_Click_1(object sender, EventArgs e)
        {
            //browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_employee.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_firstName.Clear();
            textBox_lastName.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_employee.Image = null;
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            // add new employee 
            string fname = textBox_firstName.Text;
            string lname = textBox_lastName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";


            // we will check employee age if it is between 20 and 100 or not 
            int bornYear = dateTimePicker1.Value.Year;
            int thisYear = DateTime.Now.Year;
            if ((thisYear - bornYear) < 20 || (thisYear - bornYear) > 100)
            {
                MessageBox.Show("The employee age must be between 20 and 100", "Invalid BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    // to get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_employee.Image.Save(ms, pictureBox_employee.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (employee.insertEmployee(fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Employee Added successfully !! ", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Empty Field ", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox_lastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
