using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagerApp
{
    public partial class Form1 : Form
    {
        int selectedItemValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadRandomItems();
        }

        private void loadRandomItems()
        { // Load some preset random items
            string[] newRow = { "non pretium quis", "WI-5021", "Home", "91", "205.61", "583.91" };
            string[] newRow1 = { "nulla suscipit", "NG - 5314", "Grocery", "71", "490.05", "864.3" };
            string[] newRow2 = { "nunc", "RK - 0337", "Toys", "87", "773.9", "143.04" };
            string[] newRow3 = { "amet", "YP - 3575", "Home", "20", "953.94", "909.01" };
            string[] newRow4 = { "imperdiet nullam orci", "KU - 4069", "Computers", "96", "143.96", "118.74" };
            string[] newRow5= { "cubilia", "FH - 7559", "Sports", "59", "675.82", "127.39" };
            ListViewItem newItem = new ListViewItem(newRow);
            ListViewItem newItem1 = new ListViewItem(newRow1);
            ListViewItem newItem2 = new ListViewItem(newRow2);
            ListViewItem newItem3 = new ListViewItem(newRow3);
            ListViewItem newItem4 = new ListViewItem(newRow4);
            ListViewItem newItem5 = new ListViewItem(newRow5);
            listView1.Items.Add(newItem);
            listView1.Items.Add(newItem1);
            listView1.Items.Add(newItem2);
            listView1.Items.Add(newItem3);
            listView1.Items.Add(newItem4);
            listView1.Items.Add(newItem5);
        }

        private void createItems()
        { // this creates the item
            //propteis of an item
            string givenName = text_name.Text;
            string givenSku = text_SKU.Text;
            string givenCategory = text_category.Text;
            int givenQuant = 0;
            double givenPurchase = 0;
            double givenSell = 0;

            //check that the texbox is not empty
            if (String.IsNullOrWhiteSpace(givenName)|| 
                String.IsNullOrWhiteSpace(givenSku) ||
                String.IsNullOrWhiteSpace(givenCategory) ) 
            {
                MessageBox.Show("Please check your text inputs! All forms must be filled out properly.", "Input Fields Not Correct...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {//check that each textbox that requires a number has a number
                if (Int32.TryParse(text_qty.Text, out givenQuant))
                {
                    if (Double.TryParse(text_purchase.Text, out givenPurchase))
                    {
                        if (Double.TryParse(text_sell.Text, out givenSell))
                        {
                            //round the prices to two decimals
                           double roundedPurchase = Math.Round(givenPurchase, 2, MidpointRounding.AwayFromZero);
                           double roundedSell = Math.Round(givenSell, 2, MidpointRounding.AwayFromZero);
                            //create item
                            Item item = new Item()
                            {
                                name = givenName,
                                sku = givenSku,
                                category = givenCategory,
                                quantity = givenQuant,
                                purchasePrice = roundedPurchase,
                                sellingPrice = roundedSell
                            };
                            //add item
                            string[] newRow = { item.name, item.sku, item.category, item.quantity.ToString(), item.purchasePrice.ToString(), item.sellingPrice.ToString() };
                            ListViewItem newItem = new ListViewItem(newRow);
                            listView1.Items.Add(newItem);
                            //clear all textboxes for next item
                            text_name.Text = "";
                            text_SKU.Text = "";
                            text_category.Text = "";
                            text_qty.Text = "";
                            text_purchase.Text = "";
                            text_sell.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Please check your selling input! All forms must be filled out properly.", "Input Fields Not Correct...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your purchase input! All forms must be filled out properly.", "Input Fields Not Correct...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please check your quantity input! All forms must be filled out properly.", "Input Fields Not Correct...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {//the add button will create the item
            createItems();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {// the delete button launch a message if you selected an item and chosen to delete it
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    var deleteThis = MessageBox.Show("Are you sure you want to delete " + listView1.Items[i].Text + "?","Delete This Item?",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                    if (deleteThis == DialogResult.Yes) // if chosen yes to delete, it will remove that item
                        listView1.Items[i].Remove();
                }     
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        { // also launch delete function if delete is pressed
            if (e.KeyCode == Keys.Delete)
                button_Delete_Click(sender, e);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        { // double clicking on an item will allow for edits
            //put all items back into the form
            text_name.Text = listView1.SelectedItems[0].SubItems[0].Text;
            text_SKU.Text =listView1.SelectedItems[0].SubItems[1].Text;
            text_category.Text =listView1.SelectedItems[0].SubItems[2].Text;
            text_qty.Text =listView1.SelectedItems[0].SubItems[3].Text;
            text_purchase.Text =listView1.SelectedItems[0].SubItems[4].Text;
            text_sell.Text =listView1.SelectedItems[0].SubItems[5].Text;
           
            //get the index of the item for later use, and only enable the "update" button
            selectedItemValue = listView1.SelectedItems[0].Index;
            button_Add.Enabled = false;
            button_update.Enabled = true;
        }

        private void updateItems()
        { // like add function, but updates the item at the index
            string givenName = text_name.Text;
            string givenSku = text_SKU.Text;
            string givenCategory = text_category.Text;
            int givenQuant = 0;
            double givenPurchase = 0;
            double givenSell = 0;


            if (String.IsNullOrWhiteSpace(givenName) ||
                String.IsNullOrWhiteSpace(givenSku) ||
                String.IsNullOrWhiteSpace(givenCategory))
            {
                MessageBox.Show("Please check your text inputs! All forms must be filled out properly.", "Input Fields Not Correct...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Int32.TryParse(text_qty.Text, out givenQuant))
                {
                    if (Double.TryParse(text_purchase.Text, out givenPurchase))
                    {
                        if (Double.TryParse(text_sell.Text, out givenSell))
                        {
                            double roundedPurchase = Math.Round(givenPurchase, 2, MidpointRounding.AwayFromZero);
                            double roundedSell = Math.Round(givenSell, 2, MidpointRounding.AwayFromZero);
                            listView1.Items.RemoveAt(selectedItemValue);
                            Item item = new Item()
                            {
                                name = givenName,
                                sku = givenSku,
                                category = givenCategory,
                                quantity = givenQuant,
                                purchasePrice = roundedPurchase,
                                sellingPrice = roundedSell
                            };

                            string[] newRow = { item.name, item.sku, item.category, item.quantity.ToString(), item.purchasePrice.ToString(), item.sellingPrice.ToString() };
                            ListViewItem newItem = new ListViewItem(newRow);
                            listView1.Items.Insert(selectedItemValue, newItem); // here we put back the item at the index it was chosen

                            text_name.Text = "";
                            text_SKU.Text = "";
                            text_category.Text = "";
                            text_qty.Text = "";
                            text_purchase.Text = "";
                            text_sell.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Please check your selling input! All forms must be filled out properly.", "Input Fields Not Correct...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your purchase input! All forms must be filled out properly.", "Input Fields Not Correct...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please check your quantity input! All forms must be filled out properly.", "Input Fields Not Correct...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }
        private void button_update_Click(object sender, EventArgs e)
        {// when the update button is clicked, run the update function, and set things back to normal
            updateItems();
            button_update.Enabled = false;
            button_Add.Enabled = true;
            selectedItemValue = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        { //forgot naming this, but this is the search button, find item and sub itmes by the textbox and highlight it
            foreach (ListViewItem item in listView1.Items)
            {
                foreach (ListViewItem.ListViewSubItem allItems in item.SubItems)
                {
                    if (allItems.Text.Contains(textBox7.Text.Trim()) == true)
                    {
                        item.Selected = true;
                    }
                }
            }
            button_clear.Enabled = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        { // when clicking "clear results" it will stop the search and tun everything back to normal 
            textBox7.Text = "";
            foreach (ListViewItem item in listView1.Items)
            {
                item.Selected = false;
            }
            button_clear.Enabled = false;
        }
    }
}
