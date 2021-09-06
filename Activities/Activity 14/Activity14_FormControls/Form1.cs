using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14_FormControls
{
    public partial class Form1 : Form
    {
        string chosenFlavors, chosenToppings, creation_Message;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createOrder();
            resetMessage();
        }

        private void resetMessage()
        {
            creation_Message = "";
            chosenToppings = "";
            chosenFlavors = "";
        }

        private void createOrder()
        {
            //get the radio button choice
            string iceCreamBase = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(btn => btn.Checked).Text;

            //set up a string that holds all the chosen flavors
            foreach (String flavor in listBox1.SelectedItems)
                chosenFlavors += flavor + "\n";

            // get all the topping that were selected
            if (checkBox_Sprinkles.Checked)
                chosenToppings += "sprinkles\n";
            if (checkBox_Oreros.Checked)
                chosenToppings += "crushed oreos\n";
            if (checkBox_Fudge.Checked)
                chosenToppings += "hot fudge\n";
            if (checkBox_ChocSyrup.Checked)
                chosenToppings += "chocolate syrup\n";
            if (checkBox_StrawSyrup.Checked)
                chosenToppings += "strawberry syrup\n";
            if (checkBox_CarmSyrup.Checked)
                chosenToppings += "caramel syrup\n";
            if (checkBox_CarmMS.Checked)
                chosenToppings += "caramel magic shell\n";
            if (checkBox_ChocMS.Checked)
                chosenToppings += "chocolate magic shell\n";


            creation_Message = "You made an order for: \n"+chosenFlavors+"\nTopped with:\n"+chosenToppings+"\nAll served in a " + iceCreamBase;
            MessageBox.Show(creation_Message);
        }
    }
}
