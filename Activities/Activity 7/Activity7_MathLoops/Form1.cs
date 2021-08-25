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

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fraction = 3;
            int terms = (int)numericLoops.Value;
            decimal answer = 0;
           
            for(int loop = 1; loop<=terms; loop++)
            {
                if (loop == 1)
                {
                    answer = 4;
                }
                else if (loop % 2 == 0)
                {
                    answer = answer - (4 / fraction);
                    fraction = fraction + 2;
                }
                else if (loop != 1 && loop % 2 != 0)
                {
                     answer = answer + (4 / fraction);
                     fraction = fraction + 2;
                }
            }

            label2.Text = "Approx. vale of pi after " + terms + " terms = \n" + answer;
        }
    }
}
