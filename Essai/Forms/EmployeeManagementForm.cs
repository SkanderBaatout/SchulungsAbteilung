﻿using Essai.DataAccess;
using Essai.Models;
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
        private int _currentPageNumber = 1;

        private readonly EmployeeDataAccess _employeeDataAccess;

        public EmployeeManagementForm()
        {
            InitializeComponent();
            lblPageNumber.Visible = false;
            _employeeDataAccess = new EmployeeDataAccess();
            dgvEmployees.DataSource = GetEmployeesByPageNumber(_currentPageNumber, 10);
        }
        public List<Employee> GetEmployeesByPageNumber(int pageNumber, int pageSize)
        {
            int startIndex = (pageNumber - 1) * pageSize;
            return _employeeDataAccess.GetEmployees().Skip(startIndex).Take(pageSize).ToList();
        }
        private void UpdateDataGridView(int pageNumber)
        {
            _currentPageNumber = pageNumber;
            dgvEmployees.DataSource = GetEmployeesByPageNumber(_currentPageNumber, 10);
            int totalPages = (int)Math.Ceiling((double)_employeeDataAccess.CountEmployees() / 10);


            lblPageNumber.Text = $"Page {_currentPageNumber} of {totalPages}";
            lblPageNumber.Visible = true;
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
                dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
            }
        }
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 1)
            {
                int employeeId = (int)dgvEmployees.SelectedRows[0].Cells["id"].Value;
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(employeeId);

                editEmployeeForm.FillForm();

                DialogResult result = editEmployeeForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
                }
            }
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int employeeId = (int)dgvEmployees.SelectedRows[0].Cells["id"].Value;
            if (MessageBox.Show("Are you sure you want to delete this employee ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _employeeDataAccess.DeleteEmployee(employeeId);
                    MessageBox.Show("Employee deleted successfully.", "Success");
                    dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occured : " + ex.Message, "Error");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = tbSearchKeyword.Text.Trim();
            if (string.IsNullOrEmpty(searchKeyword))
            {
                dgvEmployees.DataSource = _employeeDataAccess.GetEmployees();
            }
            else
            {
                dgvEmployees.DataSource = _employeeDataAccess.SearchEmployees(searchKeyword);
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            UpdateDataGridView(1);

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (_currentPageNumber > 1)
            {
                UpdateDataGridView(_currentPageNumber - 1);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_employeeDataAccess.CountEmployees() / 10);
            if (_currentPageNumber < totalPages)
            {
                UpdateDataGridView(_currentPageNumber + 1);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)_employeeDataAccess.CountEmployees() / 10);
            UpdateDataGridView(totalPages);
        }

        private void EmployeeManagementForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.Columns["id"].Visible = false;

        }
    }
}