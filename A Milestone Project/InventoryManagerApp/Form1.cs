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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createItems();
        }

        private void createItems()
        {
            Item item = new Item()
            {
                name = "HP Pavilion x360 (Windows 10)",
                sku = "Comput-7-1",
                category = "Computers",
                quantity = 12,
                purchasePrice = 99.99,
                sellingPrice = 124.99
            };

            string[] newRow = { item.name, item.sku, item.category, item.quantity.ToString(), item.purchasePrice.ToString(), item.sellingPrice.ToString() };
            ListViewItem newItem = new ListViewItem(newRow);
            listView1.Items.Add(newItem);
        }
    }
}
