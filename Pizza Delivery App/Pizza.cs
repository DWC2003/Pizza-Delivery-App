using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery_App 
{
    internal class Pizza : MenuItem
    {
        public int size;
        public List<MenuItem> toppings = new List<MenuItem>();
        public String crustType;
        public Boolean cheese;
        public Boolean sauce;

        public Pizza(String type, double cost, int size) : base(type, cost)
        {
            this.size = size;
        }

        public void addTopping(MenuItem item)
        {
            toppings.Add(item);
        }

        override
        public void removeToppings(int index)
        {
            cost -= toppings[index].cost;
            toppings.RemoveAt(index);
        }

        public void removeToppings()
        {
            toppings.RemoveAt(toppings.Count - 1);
        }

        public void incCost(double amount)
        {
            cost += amount;
        }

        override
        public List<MenuItem> getToppings()
        {
            return toppings;
        }

        override
        public int getSize()
        {
            return size;
        }
    }
}
