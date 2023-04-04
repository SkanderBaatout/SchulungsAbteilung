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
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Excel File | *.xlsx | Excel 2007 |*.xls";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                xlView1.showFile(opf.FileName);
            }
        }
    }
}
