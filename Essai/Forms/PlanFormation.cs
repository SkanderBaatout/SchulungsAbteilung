using ClosedXML.Excel;
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
    public partial class PlanFormation : Form
    {
        public PlanFormation()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new XLWorkbook(openFileDialog.FileName);
                var worksheet = workbook.Worksheet(1);
                var dataTable = new DataTable();

                foreach (var cell in worksheet.FirstRow().Cells())
                {
                    dataTable.Columns.Add(cell.Value.ToString());
                }

                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    var dataRow = dataTable.NewRow();

                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        dataRow[i] = row.Cell(i + 1).Value.ToString();
                    }

                    dataTable.Rows.Add(dataRow);
                }

                dataGridView.DataSource = dataTable;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}