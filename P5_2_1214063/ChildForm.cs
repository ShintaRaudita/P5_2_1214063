using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_1214063
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // no 56 OutputLabel.Text = outputText;
            OutputLabel.Text = OutputGroupBox.Text;
        }

        private void DateOption_CheckedChanged(object sender, EventArgs e)
        {
            //outputText = DateTime.Now.ToString("d");
            OutputGroupBox.Text = DateTime.Now.ToString("d");
        }

        private void TimeOption_CheckedChanged(object sender, EventArgs e)
        {
            //outputText = DateTime.Now.ToString("t");
            OutputGroupBox.Text = DateTime.Now.ToString("t");
        }
    }
}
