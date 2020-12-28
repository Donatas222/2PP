using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PP
{
    public class Item
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }

        public Item (int itemID, string itemName, double itemPrice, string itemDescription, string itemPicture)
        {
            ID = itemID;
            Name = itemName;
            Price = itemPrice;
            Description = itemDescription;
            Picture = itemPicture;
        }
    }
}
