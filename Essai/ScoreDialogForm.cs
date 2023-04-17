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
    public partial class ScoreDialogForm : Form
    {
        public int Score { get; set; }

        public ScoreDialogForm()
        {
            InitializeComponent();
        }

        private void ScoreDialogForm_Load(object sender, EventArgs e)
        {
            // Set the score value to the label
            labelScore.Text = "Score: " + Score.ToString();
        }
       
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            // Close the dialog
            this.Close();
        }
    }
}
