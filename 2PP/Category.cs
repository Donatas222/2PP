using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PP
{
    public class Category
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public List<Item> Items { get; private set; }

        public Category(int categoryID, string categoryName)
        {
            ID = categoryID;
            Name = categoryName;
        }

        public void SetItems(List<Item> items)
        {
            Items = items;
        }
    }
}
