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
        public List<MenuItem> items = new List<MenuItem>();
        public double orderTotal;
        public bool isFavorite;
        public bool isDelivery;

        public Order(List<MenuItem> startItems) { 
            items = startItems;
        }

        public Order()
        {

        }

        public void addItem(MenuItem item)
        {
            items.Add(item);
        }

        public double getTotal()
        {   
            double total = 0;
            for (int i = 0; i < items.Count; i++)
            {
                total += items[i].cost;
            }

            return total;
        }
    }
}
