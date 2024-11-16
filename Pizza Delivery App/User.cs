using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery_App
{
    internal class User
    {
        public String email;
        public String password;
        public String firstName;
        public String lastName;
        public bool outgoingOrder;
        public Order currentOrder;
        public int orderTimer;
        public Order[] favs = new Order[3];

        public User(String e, String p, string firstName, string lastName)
        {
            email = e;
            password = p;
            this.firstName = firstName;
            this.lastName = lastName;
            orderTimer = 500;
            outgoingOrder = false;
        }

        public void addFav(Order fav)
        {
            for (int i = 0; i < favs.Length; i++)
            {
                if (favs[i] == null)
                {
                    this.favs[i] = fav;
                    break;
                }
            }
        }
    }
}
