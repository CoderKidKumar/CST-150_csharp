using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7_MathLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loops = (int)numericLoops.Value;
            double startAt = (double)numericStartAt.Value;
            double f = startAt;

            for (int l = 1; l <= loops; l++)
            {
                double celsius = (f - 32) * 5 / 9;
                listBox1.Items.Add("F: " + f + "............ C: " + celsius);
                f = f + 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericLoops.Value = 1;
            numericStartAt.Value = 0;
            listBox1.Items.Clear();
        }
    }
}
