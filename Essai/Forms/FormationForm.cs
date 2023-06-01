using DocumentFormat.OpenXml.Bibliography;
using Essai.DataAccess;
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

namespace Essai.Forms
{
    public partial class FormationForm : Form
    {
        private readonly FormationDataAccess _dataAccess;
        private readonly DepartmentDataAccess _deptDataAccess;
        private readonly List<Models.Department> _departments;
        private string contentFilePath = "";


        private readonly string connectionString = "data source=SKANDERBAATOUT;database=quiz;integrated security=True;TrustServerCertificate=True;";

        private int _selectedFormationId;
        private int _selectedDepartmentId;

        public FormationForm()
        {
            InitializeComponent();
            _dataAccess = new FormationDataAccess(connectionString);
            _deptDataAccess = new DepartmentDataAccess(connectionString);
            _departments = _deptDataAccess.GetAllDepartments();
            contentTypeCB.Items.AddRange(new string[] { "Docs", "Images", "Videos", "Other" });


            // Handle the CellClick event of the grid view to select a row and load its data
            formationGridView.CellClick += formationGridView_CellClick;
        }
        private async Task LoadFormationsAsync()
        {
            List<Formation> formations = await _dataAccess.GetAllFormationsAsync();

            // Bind the data to the grid view
            formationGridView.DataSource = formations;
            formationGridView.AutoGenerateColumns = false;
        }
        private void FormationForm_Load(object sender, EventArgs e)
        {
            // Define the columns for the grid view
            formationGridView.AutoGenerateColumns = false;


            _dataAccess.LoadFormations(formationGridView);
            LoadFormationsAsync();
            LoadDepartments();
            // Define the columns for the grid view
            formationGridView.AutoGenerateColumns = false;
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false
            });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Name",
                Width = 200
            });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Trainer",
                DataPropertyName = "Trainer",
                HeaderText = "Trainer",
                Width = 150
            });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BeginDate",
                DataPropertyName = "BeginDate",
                HeaderText = "Begin Date",
                Width = 100
            });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EndDate",
                DataPropertyName = "EndDate",
                HeaderText = "End Date",
                Width = 100
            });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ContentType",
                DataPropertyName = "ContentType",
                HeaderText = "Content Type",
                Width = 100
            });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DeptName",
                DataPropertyName = "DeptName",
                HeaderText = "DeptName",
                Width = 150
            });
        }


        private void LoadDepartments()
        {
            departmentCb.DisplayMember = "Name";
            departmentCb.ValueMember = "Id";
            departmentCb.DataSource = _departments;
            departmentCb.SelectedIndexChanged += departmentCb_SelectedIndexChanged;

            departmentCb.SelectionChangeCommitted += departmentCb_SelectionChangeCommitted;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            Models.Department selectedDepartment = (Models.Department)departmentCb.SelectedItem;
            if (selectedDepartment == null)
            {
                MessageBox.Show("Please select a department for the formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] content = null;
            if (contentFilePath != "")
            {
                content = File.ReadAllBytes(contentFilePath);
            }
            else
            {
                content = new byte[0];
            }

            Formation formation = new Formation
            {
                Name = nameTb.Text,
                Trainer = trainerTb.Text,
                BeginDate = beginDate.Value,
                EndDate = endDate.Value,
                ContentType = contentTypeCB.SelectedItem.ToString(),
                DepartmentId = selectedDepartment.Id,
                DeptName = selectedDepartment.Name,
                Content = content
            };

            int formationId = _dataAccess.InsertFormation(formation);

            if (formationId > 0)
            {
                MessageBox.Show("Formation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the UI and reload the formations
                resetbtn.PerformClick();
                LoadFormationsAsync();
            }
            else
            {
                MessageBox.Show("Failed to add formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editbtn_Click(object sender, EventArgs e)
        {
            if (_selectedFormationId == 0)
            {
                MessageBox.Show("Please select a formation to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateForm())
            {
                return;
            }

            Formation formation = new Formation
            {
                Id = _selectedFormationId,
                Name = nameTb.Text,
                Trainer = trainerTb.Text,
                BeginDate = beginDate.Value,
                EndDate = endDate.Value,
                ContentType = contentTypeCB.SelectedItem.ToString(),
                DepartmentId = (int)departmentCb.SelectedValue
            };

            int rowsAffected = _dataAccess.UpdateFormation(formation);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Formation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the UI and reload the formations
                resetbtn.PerformClick();
                LoadFormationsAsync();
            }
            else
            {
                MessageBox.Show("Failed to update formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedFormationId == 0)
            {
                MessageBox.Show("Please select a formation to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected formation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int rowsAffected = _dataAccess.DeleteFormation(_selectedFormationId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Formation deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset the UI and reload the formations
                    resetbtn.PerformClick();
                    LoadFormationsAsync();
                }
                else
                {
                    MessageBox.Show("Failed to delete formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(nameTb.Text))
            {
                MessageBox.Show("Please enter a valid name for the formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(trainerTb.Text))
            {
                MessageBox.Show("Please enter a valid trainer name for the formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (beginDate.Value >= endDate.Value)
            {
                MessageBox.Show("Please select valid begin and end dates for the formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (contentTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a content type for the formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (departmentCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department for the formation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            // Reset the UI elements
            nameTb.Clear();
            trainerTb.Clear();
            beginDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
            contentTypeCB.SelectedIndex = -1;
            departmentCb.SelectedIndex = -1;

            _selectedFormationId = 0;

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (contentTypeCB.SelectedItem != null)
            {
                switch (contentTypeCB.SelectedItem.ToString())
                {
                    case "Docs":
                        openFileDialog.Filter = "Word Documents|*.doc;*.docx|PDF Files|*.pdf";
                        break;
                    case "Images":
                        openFileDialog.Filter = "ImageFiles|*.jpg;*.jpeg;*.png;*.gif";
                        break;
                    case "Videos":
                        openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.wmv;*.mov";
                        break;
                    default:
                        openFileDialog.Filter = "All Files|*.*";
                        break;
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    contentFilePath = openFileDialog.FileName;
                    contentPathLabel.Text = Path.GetFileName(contentFilePath);
                    contentPathLabel.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a content type first.");
            }
        }

        private void formationGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = formationGridView.Rows[e.RowIndex];
                // Set the selected Formation ID
                _selectedFormationId = Convert.ToInt32(row.Cells["Id"].Value);

                // Display the data in the UI elements
                nameTb.Text = row.Cells["Name"].Value != null ? row.Cells["Name"].Value.ToString() : "";
                trainerTb.Text = row.Cells["Trainer"].Value.ToString();
                beginDate.Value = Convert.ToDateTime(row.Cells["BeginDate"].Value);
                endDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);
                contentTypeCB.SelectedItem = row.Cells["ContentType"].Value.ToString();
                string deptName = row.Cells["DeptName"].Value.ToString();
                Models.Department dept = _departments.FirstOrDefault(d => d.Name == deptName);
                if (dept != null)
                {
                    departmentCb.SelectedItem = dept;
                }
            }
        }
        private async Task LoadFormationsByDepartmentAsync(int departmentId)
        {
            List<Formation> formations = await _dataAccess.GetFormationsByDepartmentAsync(departmentId.ToString());

            // Bind the data to the grid view
            formationGridView.DataSource = formations;
            formationGridView.AutoGenerateColumns = false;
        }

        private void departmentCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (departmentCb.SelectedItem != null)
            {
                Models.Department selectedDepartment = (Models.Department)departmentCb.SelectedItem;
                if (selectedDepartment != null)
                {
                    _selectedDepartmentId = selectedDepartment.Id;
                    LoadFormationsByDepartmentAsync(_selectedDepartmentId);
                }
            }
        }

        private void departmentCb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (departmentCb.SelectedItem != null)
            {
                Models.Department selectedDepartment = (Models.Department)departmentCb.SelectedItem;
                if (selectedDepartment != null)
                {
                    _selectedDepartmentId = selectedDepartment.Id;
                    LoadFormationsByDepartmentAsync(_selectedDepartmentId);
                }
            }
        }
    }
}
