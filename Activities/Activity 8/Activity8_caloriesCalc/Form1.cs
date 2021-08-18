using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8_caloriesCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int carbs = (int)numericCarbGrams.Value;
            int fats = (int)numericFatGrams.Value;

            calulateFatCalories(fats);
            calulateCarbCalories(carbs);
        }

        private void calulateCarbCalories(int carbsGram)
        {
            int caloriesCarbs = carbsGram * 4;
            lbl_carbs.Text = caloriesCarbs.ToString() + " Calories from Carbs";
        }

        private void calulateFatCalories(int fatsGram)
        {
            int caloriesFat = fatsGram * 9;
            lbl_fat.Text = caloriesFat.ToString() + " Calories from Fat";
        }
    }
}
