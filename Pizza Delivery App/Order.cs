using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery_App
{
    internal class Order
    {
        public int orderID;
        public List<MenuItem> items;
        public double orderTotal;
        public bool isFavorite;
        public bool isDelivery;

        public Order(List<MenuItem> startItems) { 
            items = startItems;
        }

        public void addItem(MenuItem item)
        {
            items.Add(item);
        }
    }
}
