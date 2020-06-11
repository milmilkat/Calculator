using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            int output = Convert.ToInt32(FirstNumberTextbox.Text) +
                Convert.ToInt32(SecondNumberTextbox.Text);

            OutputTextbox.Text = output.ToString();
        }
    }
}
