using ExcelDataReader;
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
    public partial class SuivrePlanFormation : Form
    {
        private byte[] planData;

        public SuivrePlanFormation(byte[] planData)
        {
            InitializeComponent();
            this.planData = planData;
        }

        private void SuivrePlanFormation_Load(object sender, EventArgs e)
        {
            try
            {
                // Load the Excel file into a DataTable
                DataTable dataTable = new DataTable();
                using (var stream = new MemoryStream(planData))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        dataTable = result.Tables[0];
                    }
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Excel file: " + ex.Message);
                this.Close();
            }
        }


    }
}
