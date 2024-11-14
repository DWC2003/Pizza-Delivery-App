using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Pizza_Delivery_App
{
    class Extras : MenuItem
    {
        public String itemSubType;

        public Extras(String type, double cost, String subType) : base(type, cost)
        {
            itemSubType = subType;
        }

        public void setType(String type)
        {

        }

        override
        public List<MenuItem> getToppings()
        {
            return new List<MenuItem>();
        }

        override
        public void removeToppings(int index)
        {

        }

        override
        public int getSize()
        {
            return 0;
        }
    }
}
