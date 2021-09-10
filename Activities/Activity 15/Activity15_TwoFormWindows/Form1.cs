using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15_TwoFormWindows
{
    public partial class Form1 : Form
    {
        // this will help to place the currentdate into the form
        DateTime thisDay = DateTime.Today;

        //this return value is important for the lucky numbers
        int returnValue;
        public Form1()
        {
            InitializeComponent();
            setTheDate();
        }

        private void setTheDate()
        { // this sets up the comboBox with data, but put it to the current date
            for (int y = 1900; y <= thisDay.Year; y++)
            {
                combo_Year.Items.Add(y);
            }
            combo_Year.SelectedItem = thisDay.Year;

            for (int m = 1; m <= 12; m++)
            {
                combo_Month.Items.Add(m);
            }
            combo_Month.SelectedItem = thisDay.Month;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the data from the form
            string name = textBox1.Text.ToLower();
            int month = (int)combo_Month.SelectedItem;
            int date = (int)combo_Date.SelectedItem;
            int year = (int)combo_Year.SelectedItem;

            //if the name field is empty alret the user
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please insert your name", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            else
            { // if name is filled, show the lucky number in a new window
                int firstNumber = calculateNameNumber(name);
                int secondNumber = calculateBirthNumber(month, date, year);

                int luckyUntimateNumber = firstNumber * secondNumber;
                int luckyNumber = firstNumber + secondNumber;

                Form2 luckyNmberForm = new Form2(name,luckyNumber,luckyUntimateNumber,firstNumber,secondNumber);
                luckyNmberForm.ShowDialog();
            }
        }

        //the following three methods use the name and date for numerology
        private int calculateBirthNumber(int month, int date, int year)
        {
            //calulate lucky number with birthdate
            int monthNumber = reduceToSingleDigit(month);
            int dateNumber = reduceToSingleDigit(date);
            int yearNumber = reduceToSingleDigit(year);

            int totalDateNumber = monthNumber + dateNumber + yearNumber;

            int finalNumber = reduceToSingleDigit(totalDateNumber);

            return finalNumber;
        }

        private int calculateNameNumber(string name)
        {
            // split up the first middle and last name
            char[] splitBy = { ' ' };
            string[] splitNames = name.Split(splitBy, StringSplitOptions.RemoveEmptyEntries);

            int numberTotal = 0;
            for (int i = 0; i < splitNames.Length; i++)
            {
                //for each part of the name, go though the letters and add their value
                string tempName = splitNames[i];
                foreach (char c in tempName)
                {
                    if (c == 'a' || c == 'j' || c == 's')
                        numberTotal += 1;
                    if (c == 'b' || c == 'k' || c == 't')
                        numberTotal += 2;
                    if (c == 'c' || c == 'l' || c == 'u')
                        numberTotal += 3;
                    if (c == 'd' || c == 'm' || c == 'v')
                        numberTotal += 4;
                    if (c == 'e' || c == 'n' || c == 'w')
                        numberTotal += 5;
                    if (c == 'f' || c == 'o' || c == 'x')
                        numberTotal += 6;
                    if (c == 'g' || c == 'p' || c == 'y')
                        numberTotal += 7;
                    if (c == 'h' || c == 'q' || c == 'z')
                        numberTotal += 8;
                    if (c == 'i' || c == 'r')
                        numberTotal += 9;
                }
            }
            //check if the value is a double digit, if it is simplify it to a single number
            int digit = reduceToSingleDigit(numberTotal);
            return digit;
        }

        private int reduceToSingleDigit(int number)
        {
            //chek the number value, split up the number, and then add each indivisual number until it gets to single digit
             if(number >1000 && number < 3000)
            {
                int thousands = (number / 1000) % 10;
                int hundreds = (number / 100) % 10;
                int tens = (number / 10) % 10;
                int ones = (number / 1) % 10;
                int numberNew = thousands + hundreds + tens + ones;
                reduceToSingleDigit(numberNew);
            }
            else if (number > 9 && number < 100)
            {
                if (number == 11 || number == 22 || number == 33)
                    returnValue = number;
                else
                {
                    int tens = (number / 10) % 10;
                    int ones = (number / 1) % 10;
                    int numberNew = tens + ones;
                    if (numberNew == 11 || numberNew == 22 || numberNew == 33)
                        returnValue = numberNew;
                    else
                        reduceToSingleDigit(numberNew);
                }
            }
             else
            {
                returnValue = number;
            }
            return returnValue;
        }

        //chage the number of dates based on chaning the month
        private void combo_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Date.Items.Clear();
            int month = (int)combo_Month.SelectedItem;
            int year = (int)combo_Year.SelectedItem;

            for (int d = 1; d <= DateTime.DaysInMonth(year,month); d++)
            {
                combo_Date.Items.Add(d);
            }
        }
    }
}
