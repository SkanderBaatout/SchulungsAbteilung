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
    public partial class ManageemployeeForm : Form
    {
        EmployeeClass employee = new EmployeeClass();
        public ManageemployeeForm()
        {
            InitializeComponent();
        }

        private void ManageemployeeForm_Load(object sender, EventArgs e)
        {
            showTable();
        }


        // to display employees list in datagridview
        public void showTable()
        {
            DataGridViewEmployees.DataSource = employee.getEmployeeList(new MySqlCommand("SELECT * FROM `employee` "));

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridViewEmployees.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        // display employee data from employee to textbox
        private void DataGridViewEmployees_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridViewEmployees.CurrentRow.Cells[0].Value.ToString();
            textBox_firstName.Text = DataGridViewEmployees.CurrentRow.Cells[1].Value.ToString();
            textBox_lastName.Text = DataGridViewEmployees.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker1.Value = (DateTime)DataGridViewEmployees.CurrentRow.Cells[3].Value;
            if (DataGridViewEmployees.CurrentRow.Cells[4].Value.ToString() == "Male")

                radioButton_male.Checked = true;
            textBox_phone.Text = DataGridViewEmployees.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = DataGridViewEmployees.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridViewEmployees.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_employee.Image = Image.FromStream(ms);





        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_firstName.Clear();
            textBox_lastName.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            textBox_id.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_employee.Image = null;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            //browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_employee.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridViewEmployees.DataSource = employee.searchEmployee(textBox_search.Text);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridViewEmployees.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
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

        private void button_update_Click(object sender, EventArgs e)
        {
            // update employee record
            int id = Convert.ToInt32(textBox_id.Text);
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
                    if (employee.updateEmployee(id, fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show(" Employee data  Updated successfully !! ", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Empty Field ", "Update Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //remove the selected employee
            int id = Convert.ToInt32(textBox_id.Text);
            // display a confirmation msg before deleting 
            if (MessageBox.Show("Are you sure you want to delete this employee?", "Remove Employee", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (employee.deleteStudent(id))
                {
                    showTable();
                    MessageBox.Show("Employee Removed ", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();

                }
            }

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
