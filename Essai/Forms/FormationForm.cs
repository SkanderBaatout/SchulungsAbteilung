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

        public FormationForm()
        {
            InitializeComponent();
            _dataAccess = new FormationDataAccess(connectionString);
            _deptDataAccess = new DepartmentDataAccess(connectionString);
            _departments = _deptDataAccess.GetAllDepartments();

            contentTypeCB.Items.Add("Docs");
            contentTypeCB.Items.Add("Images");
            contentTypeCB.Items.Add("Videos");
            contentTypeCB.Items.Add("Other");
        }

        private void FormationForm_Load(object sender, EventArgs e)
        {
            LoadFormationsAsync();
            LoadDepartments();
        }
        private async Task LoadFormationsAsync()
        {
            List<Formation> formations = await _dataAccess.GetAllFormationsAsync();

            formationGridView.AutoGenerateColumns = false;
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id" });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trainer", DataPropertyName = "Trainer" });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Begin Date", DataPropertyName = "BeginDate" });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "End Date", DataPropertyName = "EndDate" });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Content Type", DataPropertyName = "ContentType" });
            formationGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Department", DataPropertyName = "DeptName" });

            formationGridView.DataSource = formations;
        }
        private void LoadDepartments()
        {
            departmentCb.DisplayMember = "Name";
            departmentCb.ValueMember = "Id";
            departmentCb.DataSource = _departments;
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
                int rowsAffected =  _dataAccess.DeleteFormation(_selectedFormationId);

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
            if (e.RowIndex >= 0 && e.RowIndex < formationGridView.Rows.Count - 1)
            {
                DataGridViewRow row = formationGridView.Rows[e.RowIndex];
                _selectedFormationId = (int)row.Cells["Id"].Value;

                // Load the formation content into the appropriate UI elements
                nameTb.Text = row.Cells["Name"].Value.ToString();
                trainerTb.Text = row.Cells["Trainer"].Value.ToString();
                beginDate.Value = (DateTime)row.Cells["BeginDate"].Value;
                endDate.Value = (DateTime)row.Cells["EndDate"].Value;
                contentTypeCB.SelectedItem = row.Cells["ContentType"].Value.ToString();

                Models.Department department = _departments.FirstOrDefault(d => d.Id == (int)row.Cells["DepartmentId"].Value);
                departmentCb.SelectedItem = department;
            }
        }
    }
}
