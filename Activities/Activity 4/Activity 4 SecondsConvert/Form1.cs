using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4_SecondsConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            //checks if the entered seconds are days
            if (numberOfSeconds.Value >= 86400)
            {
                days = (int)(numberOfSeconds.Value / 86400);
                int remain1 = (int)(numberOfSeconds.Value % 86400);
                //checks if remain1 can be used for hours
                if(remain1 >= 3600)
                {
                    //calculates hours and remains
                    hours = remain1 / 3600;
                    int remain2 = remain1 % 3600;

                    //checks remains2 for minutes and seconds
                    if (remain2 >= 60)
                    {
                        minutes = remain2 / 60;
                        seconds = remain2 % 60;
                    }
                    else
                    {
                        seconds = remain2;
                    }
                }
                //checks if remain1 can be used for minutes
                else if (remain1 >= 60)
                {
                    minutes = remain1 / 60;
                    seconds = remain1 % 60;
                }
                //checks if the remain1 can be used for seconds
                else
                {
                    seconds = remain1;
                }
            }
            // checks if the entered seconds are hours
            else if (numberOfSeconds.Value >= 3600)
            {
                    hours = (int)numberOfSeconds.Value / 3600;
                    int remain1 = (int)numberOfSeconds.Value % 3600;

                    if (remain1 >= 60)
                    {
                        minutes = remain1 / 60;
                        seconds = remain1 % 60;
                    }
                    else
                    {
                        seconds = remain1;
                    }
                
            }
            //checks if the entered seconds are minutes
            else if (numberOfSeconds.Value >= 60)
            {
                minutes = (int) numberOfSeconds.Value / 60;
                seconds = (int) numberOfSeconds.Value % 60;
            }
            //checks if the entered seconds are seconds
            else if (numberOfSeconds.Value < 60)
            {
                seconds = (int)numberOfSeconds.Value;
            }

            lbl_days.Text = days.ToString();
            lbl_hours.Text = hours.ToString();
            lbl_minutes.Text = minutes.ToString();
            lbl_seconds.Text = seconds.ToString();
        }
    }
}
