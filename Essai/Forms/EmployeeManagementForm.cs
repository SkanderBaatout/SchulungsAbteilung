using Essai.DataAccess;
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
    public partial class EmployeeManagementForm : Form
    {
        private readonly EmployeeDataAccess _employeeDataAccess;

        public EmployeeManagementForm()
        {
            InitializeComponent();
            _employeeDataAccess = new EmployeeDataAccess();
            dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 1)
            {
                btnEditEmployee.Enabled = true;
                btnDeleteEmployee.Enabled = true;
            }
            else
            {
                btnEditEmployee.Enabled = false;
                btnDeleteEmployee.Enabled = false;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            DialogResult result = addEmployeeForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Refresh the data grid view to show the new employee
                dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 1)
            {
                int employeeId = (int)dgvEmployees.SelectedRows[0].Cells["id"].Value;
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(employeeId);

                // Fill the edit form with the data of the selected employee
                editEmployeeForm.FillForm();

                DialogResult result = editEmployeeForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh the data grid view to show the updated employee
                    dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int employeeId = (int)dgvEmployees.SelectedRows[0].Cells["id"].Value;
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet employé ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _employeeDataAccess.DeleteEmployee(employeeId);
                    MessageBox.Show("Employé supprimé avec succès.", "Succès");
                    dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Erreur");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = tbSearchKeyword.Text.Trim();
            if (string.IsNullOrEmpty(searchKeyword))
            {
                // If the search box is empty, show all employees
                dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
            }
            else
            {
                // Perform the search and show the results
                dgvEmployees.DataSource = _employeeDataAccess.SearchEmployees(searchKeyword);
            }
        }
    }
}