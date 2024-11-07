using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery_App
{
    abstract class MenuItem
    {
        public int itemID;
        public string itemType;
        public bool isVegan;
        public double cost;

        public MenuItem(String type)
        {
            itemType = type;
        }
    }
}
