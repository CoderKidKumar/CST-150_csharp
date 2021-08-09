using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2_MeasureConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mm_Click(object sender, EventArgs e)
        {
            float mm = 0;
            try
            {
                //get mm from textbox
                mm = float.Parse(txtbx_mm.Text);
            } 
            catch
            {
                MessageBox.Show("Please Use Numbers");
            }

            //calulate formulas
            float cm = (float)Math.Round(mm / 10, 3);
            float inch = (float)Math.Round(mm / 25.4, 3);
            float feet = (float)Math.Round(mm / 304.8, 3);
            float yard = (float)Math.Round(mm / 914.4, 3);
            float meter = mm / 1000;

            //display converstion on proper textboxes
            txtbx_cm.Text = cm.ToString();
            txtbx_in.Text = inch.ToString();
            txtbx_ft.Text = feet.ToString();
            txtbx_yd.Text = yard.ToString();
            txtbx_meter.Text = meter.ToString();
        }

        private void btn_cm_Click(object sender, EventArgs e)
        {
            float cm = 0;
            try 
            { 
            //get cm from textbox
            cm = float.Parse(txtbx_cm.Text);
            } 
            catch
            {
                MessageBox.Show("Please Use Numbers");
            }

            //calulate formulas
            float mm = (float)Math.Round(cm * 10, 3);
            float inch = (float)Math.Round(cm / 2.54, 3);
            float feet = (float)Math.Round(cm / 30.48, 3);
            float yard = (float)Math.Round(cm / 91.44, 3);
            float meter = cm / 100;

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_in.Text = inch.ToString();
            txtbx_ft.Text = feet.ToString();
            txtbx_yd.Text = yard.ToString();
            txtbx_meter.Text = meter.ToString();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            float inch = 0;
            try 
            { 
            //get inches from textbox
            inch = float.Parse(txtbx_in.Text);
            }
            catch
            {
                MessageBox.Show("Please Use Numbers");
            }
            //calulate formulas
            float mm = (float)Math.Round(inch * 25.4, 3);
            float cm = (float)Math.Round(inch * 2.54, 3);
            float feet = (float)Math.Round(inch / 12, 3);
            float yard = (float)Math.Round(inch / 36, 3);
            float meter = (float)Math.Round(inch / 39.37, 3);

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_cm.Text = cm.ToString();
            txtbx_ft.Text = feet.ToString();
            txtbx_yd.Text = yard.ToString();
            txtbx_meter.Text = meter.ToString();
        }

        private void btn_ft_Click(object sender, EventArgs e)
        {
            float feet = 0;

            try
            {
                //get feet from textbox
                feet = float.Parse(txtbx_ft.Text);
            } 
            catch
            {
                MessageBox.Show("Please Use Numbers");
            }


            //calulate formulas
            float mm = (float)Math.Round(feet * 304.8, 3);
            float cm = (float)Math.Round(feet * 30.48, 3);
            float inches = (float)Math.Round(feet * 12, 3);
            float yard = (float)Math.Round(feet / 3, 3);
            float meter = (float)Math.Round(feet / 3.281, 3);

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_cm.Text = cm.ToString();
            txtbx_in.Text = inches.ToString();
            txtbx_yd.Text = yard.ToString();
            txtbx_meter.Text = meter.ToString();
        }

        private void btn_yd_Click(object sender, EventArgs e)
        {
            float yard = 0;
            try
            {
                //get yards from textbox
                yard = float.Parse(txtbx_yd.Text);
            }
            catch
            {
                MessageBox.Show("Please Use Numbers");
            }
            

            //calulate formulas
            float mm = (float)Math.Round(yard * 914.4, 3);
            float cm = (float)Math.Round(yard * 91.44, 3);
            float inches = (float)Math.Round(yard * 36, 3);
            float feet = (float)Math.Round(yard * 3, 3);
            float meter = (float)Math.Round(yard / 1.094, 3);

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_cm.Text = cm.ToString();
            txtbx_in.Text = inches.ToString();
            txtbx_ft.Text = feet.ToString();
            txtbx_meter.Text = meter.ToString();
        }

        private void btn_meter_Click(object sender, EventArgs e)
        {
            float meter = 0;
            try
            {
                //get mm from textbox
                meter = float.Parse(txtbx_meter.Text);
            }
            catch
            {
                MessageBox.Show("Please Use Numbers");
            }
            

            //calulate formulas
            float mm = (float)Math.Round(meter * 1000, 3);
            float cm = (float)Math.Round(meter * 100, 3);
            float inch = (float)Math.Round(meter * 39.37, 3);
            float feet = (float)Math.Round(meter * 3.281, 3);
            float yard = (float)Math.Round(meter * 1.094 , 3);

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_cm.Text = cm.ToString();
            txtbx_in.Text = inch.ToString();
            txtbx_ft.Text = feet.ToString();
            txtbx_yd.Text = yard.ToString();
        }
    }
}
