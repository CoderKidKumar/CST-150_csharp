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
            //get mm from textbox
            float mm = float.Parse(txtbx_mm.Text);

            //calulate formulas
            float cm = mm / 10;
            float inch = (float)(mm / 25.4);
            float feet = (float)(mm / 304.8);
            float yard = (float)(mm / 914.4);
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
            //get cm from textbox
            float cm = float.Parse(txtbx_cm.Text);

            //calulate formulas
            float mm = cm * 10;
            float inch = (float)(cm / 2.54);
            float feet = (float)(cm / 30.48);
            float yard = (float)(cm / 91.44);
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
            //get inches from textbox
            float inch = float.Parse(txtbx_in.Text);

            //calulate formulas
            float mm = (float) (inch * 25.4);
            float cm = (float)(inch * 2.54);
            float feet = (float)(inch / 12);
            float yard = (float)(inch / 36);
            float meter = (float)(inch / 39.37);

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_cm.Text = cm.ToString();
            txtbx_ft.Text = feet.ToString();
            txtbx_yd.Text = yard.ToString();
            txtbx_meter.Text = meter.ToString();
        }

        private void btn_ft_Click(object sender, EventArgs e)
        {
            //get feet from textbox
            float feet = float.Parse(txtbx_ft.Text);

            //calulate formulas
            float mm = (float)(feet * 304.8);
            float cm = (float)(feet * 30.48);
            float inches = (float)(feet * 12);
            float yard = (float)(feet / 3);
            float meter = (float)(feet / 3.281);

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_cm.Text = cm.ToString();
            txtbx_in.Text = inches.ToString();
            txtbx_yd.Text = yard.ToString();
            txtbx_meter.Text = meter.ToString();
        }

        private void btn_yd_Click(object sender, EventArgs e)
        {
            //get yards from textbox
            float yard = float.Parse(txtbx_yd.Text);

            //calulate formulas
            float mm = (float)(yard * 914.4);
            float cm = (float)(yard * 91.44);
            float inches = (float)(yard * 36);
            float feet = (float)(yard * 3);
            float meter = (float)(yard / 1.094);

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_cm.Text = cm.ToString();
            txtbx_in.Text = inches.ToString();
            txtbx_ft.Text = feet.ToString();
            txtbx_meter.Text = meter.ToString();
        }

        private void btn_meter_Click(object sender, EventArgs e)
        {
            //get mm from textbox
            float meter = float.Parse(txtbx_meter.Text);

            //calulate formulas
            float mm = (float)(meter * 1000);
            float cm = (float)(meter * 100);
            float inch = (float)(meter * 39.37);
            float feet = (float)(meter * 3.281);
            float yard = (float)(meter * 1.094);

            //display converstion on proper textboxes
            txtbx_mm.Text = mm.ToString();
            txtbx_cm.Text = cm.ToString();
            txtbx_in.Text = inch.ToString();
            txtbx_ft.Text = feet.ToString();
            txtbx_yd.Text = yard.ToString();
        }
    }
}
