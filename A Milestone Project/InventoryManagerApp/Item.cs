using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagerApp
{
    public class Item
    {
        public string name { get; set; }
        public string sku { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
        public double purchasePrice { get; set; }
        public double sellingPrice { get; set; }
    }
}
