using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pizza_Delivery_App
{
    public partial class Form1 : Form
    {
        // List of users
        List<User> users = new List<User>();
        // Menu Logic Variables
        public int menuPos = 0;
        public int newPos = 0;
        public int pizzaPos = 0;
        int orderToppingNum = 0;
        bool payFlag = false;
        bool orderedFlag = false;
        bool trackFlag = false;
        int orderTimer = 500;
        // Order and Pizza and User Construction Variables
        Order newOrder = new Order();

        User currentUser = new User("", "", "", "");
        Pizza newPizza;
        // Menus
        List<MenuItem> sidesMenu = new List<MenuItem>();
        List<MenuItem> dessertsMenu = new List<MenuItem>();
        List<MenuItem> bevMenu = new List<MenuItem>();
        List<MenuItem> crustMenu = new List<MenuItem>();
        List<MenuItem> sauceMenu = new List<MenuItem>();
        List<MenuItem> topMenu = new List<MenuItem>();
        List<Order> favs = new List<Order>();

        public Form1()
        {
            InitializeComponent();
            // Sample user information
            users.Add(new User("sampleemail@gmail.com", "examplePass!", "John", "Doe"));
            users[0].addFav(new Order());
            users[0].favs[0].addItem(new Extras("Fries", 3.99, "Side"));
            users[0].favs[0].addItem(new Extras("Breadsticks", 3.99, "Side"));
            users[0].addFav(new Order());
            users[0].favs[1].addItem(new Extras("Cheese Sticks", 2.99, "Side"));


            users.Add(new User("sampleemail2@gmail.com", "examplePass2!", "Jane", "Doe"));


            // Populates Sides Menu
            sidesMenu.Add(new Extras("Fries", 3.99, "Side"));
            sidesMenu.Add(new Extras("Breadsticks", 3.99, "Side"));
            sidesMenu.Add(new Extras("Cheese Sticks", 3.99, "Side"));
            sidesMenu.Add(new Extras("Wings(5)", 3.99, "Side"));
            sidesMenu.Add(new Extras("Wings(10)", 5.99, "Side"));
            sidesMenu.Add(new Extras("Pasta", 3.99, "Side"));
            sidesMenu.Add(new Extras("Salad", 3.99, "Side"));

            for (int i = 0; i < sidesMenu.Count(); i++)
            {
                String[] parts = new String[2];

                parts[0] = sidesMenu[i].itemType;
                parts[1] = "" + sidesMenu[i].cost;

                ListViewItem item = new ListViewItem(parts);
                SidesListView.Items.Add(item);
            }

            // Populates Desserts Menu
            dessertsMenu.Add(new Extras("Brownies", 4.99, "Dessert"));
            dessertsMenu.Add(new Extras("Cookies(5)", 3.99, "Dessert"));
            dessertsMenu.Add(new Extras("Ice Cream", 2.99, "Dessert"));
            dessertsMenu.Add(new Extras("Cinnamon Twists", 3.99, "Dessert"));
            dessertsMenu.Add(new Extras("Cheesecake Bites", 3.99, "Dessert"));


            for (int i = 0; i < dessertsMenu.Count(); i++)
            {
                String[] parts = new String[2];

                parts[0] = dessertsMenu[i].itemType;
                parts[1] = "" + dessertsMenu[i].cost;

                ListViewItem item = new ListViewItem(parts);
                DessertsListView.Items.Add(item);
            }

            // Populates Beverages Menu
            bevMenu.Add(new Extras("Coke", 3.99, "Beverage"));
            bevMenu.Add(new Extras("Sprite", 3.99, "Beverage"));
            bevMenu.Add(new Extras("Fanta", 3.99, "Beverage"));
            bevMenu.Add(new Extras("Water Bottle", 1.99, "Beverage"));
            bevMenu.Add(new Extras("Apple Juice", 2.99, "Beverage"));


            for (int i = 0; i < bevMenu.Count(); i++)
            {
                String[] parts = new String[2];

                parts[0] = bevMenu[i].itemType;
                parts[1] = "" + bevMenu[i].cost;

                ListViewItem item = new ListViewItem(parts);
                BeveragesListView.Items.Add(item);
            }

            // Populates Crust Menu
            crustMenu.Add(new Extras("Regular", 3.99, "Crust"));
            crustMenu.Add(new Extras("Gluten Free", 4.99, "Crust"));
            crustMenu.Add(new Extras("Thin", 2.99, "Crust"));
            crustMenu.Add(new Extras("Deep Dish", 5.99, "Crust"));

            for (int i = 0; i < crustMenu.Count(); i++)
            {
                String[] parts = new String[2];

                parts[0] = crustMenu[i].itemType;
                parts[1] = "" + crustMenu[i].cost;

                ListViewItem item = new ListViewItem(parts);
                CrustListView.Items.Add(item);
            }

            // Populates Sauce Menu
            sauceMenu.Add(new Extras("Red Sauce", 1.99, "Sauce"));
            sauceMenu.Add(new Extras("White Sauce", 2.99, "Sauce"));
            sauceMenu.Add(new Extras("Green Sauce", 3.99, "Sauce"));

            for (int i = 0; i < sauceMenu.Count(); i++)
            {
                String[] parts = new String[2];

                parts[0] = sauceMenu[i].itemType;
                parts[1] = "" + sauceMenu[i].cost;

                ListViewItem item = new ListViewItem(parts);
                SauceListView.Items.Add(item);
            }

            // Populates Toppings Menu
            topMenu.Add(new Extras("Pepperoni", 1.99, "Topping"));
            topMenu.Add(new Extras("Sausage", 2.99, "Topping"));
            topMenu.Add(new Extras("Chicken", 3.99, "Topping"));
            topMenu.Add(new Extras("Steak", 3.99, "Topping"));
            topMenu.Add(new Extras("Shrimp", 4.99, "Topping"));
            topMenu.Add(new Extras("Spinach", 1.99, "Topping"));
            topMenu.Add(new Extras("Feta", 2.99, "Topping"));
            topMenu.Add(new Extras("Fresh Mozzarella", 3.99, "Topping"));
            topMenu.Add(new Extras("Red Peppers", 2.99, "Topping"));
            topMenu.Add(new Extras("Mushrooms", 2.99, "Topping"));

            for (int i = 0; i < topMenu.Count(); i++)
            {
                String[] parts = new String[2];

                parts[0] = topMenu[i].itemType;
                parts[1] = "" + topMenu[i].cost;

                ListViewItem item = new ListViewItem(parts);
                ToppingListView.Items.Add(item);
            }

            // Populates Favorites List
            List<MenuItem> test = new List<MenuItem>();
            test.Add(new Extras("Fries", 0, "Side"));
            test.Add(new Extras("Cola", 0, "Beverage"));
            test.Add(new Extras("Brownies", 0, "Dessert"));
            favs.Add(new Order(test));
            favs.Add(new Order(test));
            favs.Add(new Order(test));
            for (int i = 0; i < favs.Count; i++)
            {
                String[] items = new string[6];
                items[0] = "" + i;
                for (int j = 0; j < items.Length-1; j++)
                {
                    if (j > favs.ElementAt(i).items.Count-1)
                    {
                        items[j + 1] = "N/A";
                    }
                    else
                    {
                        items[j + 1] = favs.ElementAt(i).items[j].itemType;

                    }
                }
                ListViewItem favOrder = new ListViewItem(items);


            }
            

            Back.Hide();

            // Timer for menu logic
            Timer tmr = new Timer();
            tmr.Interval = 50;   // milliseconds
            tmr.Tick += Tmr_Tick;  // set handler
            tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)  //run this logic each timer tick
        {
            // Hides/shows menus based on current menuPos and newPos. If they don't match, then menu is changed.
            if (menuPos != newPos)
            {
                switch (menuPos)
                {
                    case 0:
                        startPanel.Hide();
                        Back.Show();
                        break;
                    case 1:
                        InfoPanel.Hide();
                        break;
                    case 2: 
                        LogInPanel.Hide();
                        LogInErrorLabel.Text = "";
                        break;
                    case 3:
                        OrderMainPanel.Hide();
                        break;
                    case 4:
                        FavoritesPanel.Hide();
                        break;
                    case 5:
                        OrderCreationPanel.Hide();
                        OrderCreationErrorLabel.Text = "";
                        break;
                    case 6:
                        SidesPanel.Hide();
                        SidesAddedLabel.Text = string.Empty;
                        break;
                    case 7:
                        PizzaCreationPanel.Hide();
                        break;
                    case 8:
                        BeveragesOrderPanel.Hide();
                        BevAddedLabel.Text = string.Empty;
                        break;
                    case 9:
                        ViewOrderPanel.Hide();
                        ViewOrderList.Items.Clear();
                        ViewOrderTotalLabel.Text = ("Total: $0.00");
                        RemoveItemsLabel.Text = string.Empty;
                        ViewOrderErrorLabel.Text = "";
                        break;
                    case 10:
                        PayPanel.Hide();
                        break;
                    case 11:
                        OrderTrackingPanel.Hide();
                        break;
                    case 12:
                        SignUpPanel.Hide();
                        break;

                }
                switch (newPos)
                {
                    case 0:
                        startPanel.Show();
                        Back.Hide();
                        break;
                    case 1:
                        InfoPanel.Show();
                        break;
                    case 2:
                        LogInPanel.Show();
                        break;
                    case 3:
                        OrderMainPanel.Show();
                        WelcomeLabel.Text = "Welcome, " + currentUser.firstName + ".\nBegin Your Order!";
                        break;
                    case 4:
                        FavoritesPanel.Show();
                        break;
                    case 5:
                        OrderCreationPanel.Show();
                        break;
                    case 6:
                        SidesPanel.Show();
                        break;
                    case 7:
                        PizzaCreationPanel.Show();
                        break;
                    case 8:
                        BeveragesOrderPanel.Show();
                        break;
                    case 9:
                        ViewOrderPanel.Show();
                        break;
                    case 10:
                        PayPanel.Show();
                        TotalLabelPay.Text = ("Total: $" + newOrder.getTotal());
                        break;
                    case 11:
                        OrderTrackingPanel.Show();
                        break;
                    case 12:
                        SignUpPanel.Show();
                        break;
                }
            }

            menuPos = newPos;
            
            if (DeliveryCheckBox.Checked)
            {
                AddressTextBox.Show();
                StateTextBox.Show();
                ZipTextBox.Show();
            }
            else
            {
                AddressTextBox.Hide();
                StateTextBox.Hide();
                ZipTextBox.Hide();
            }

            foreach (User user in users)
            {
                if (user.outgoingOrder)
                {
                    if (user.orderTimer > 0)
                    {
                        user.orderTimer--;

                    }
                }
            }
            if (currentUser.outgoingOrder)
            {
                OrderProgressBar.Value = 100 - ((int)(currentUser.orderTimer / 100)) * 25;
            }
            switch (currentUser.orderTimer / 100 + 1)
            {
                case 4:
                    OrderStatusLabel.Text = "Order Status: Cooking";
                    break;
                case 3:
                    OrderStatusLabel.Text = "Order Status: Packing";
                    break;
                case 2:
                    if (DeliveryCheckBox.Checked)
                    {
                        OrderStatusLabel.Text = "Order Status: Delivering";
                    }
                    else
                    {
                        OrderStatusLabel.Text = "Order Status: Quality Assurance";
                    }
                    break;
                case 1:
                    if (DeliveryCheckBox.Checked)
                    {
                        OrderStatusLabel.Text = "Order Status: Delivered";
                    }
                    else
                    {
                        OrderStatusLabel.Text = "Order Status: Ready For Pickup";
                    }
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newPos = 2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            newPos = 1;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // Back button behaviour changes depending on current menuPos. Determines which menu to return to.
            switch(menuPos)
            {
                case 1:
                    newPos = 0;
                    break;
                case 2:
                    newPos = 0;
                    break;
                case 3:
                    var logout = MessageBox.Show(this, "Are you sure you want to log out?",
                        "Confirm",
                        MessageBoxButtons.YesNo);
                    if (logout == DialogResult.Yes)
                    {
                        newPos = 2;
                        newOrder = new Order();
                    }
                    break;
                case 4:
                    newPos = 3;
                    break;
                case 5:
                    newPos = 3;
                    break;
                case 6:
                    newPos = 5;
                    break;
                case 7:
                    // Pizza construction screen has its own logic so that it can use one panel. This was a nightmare!
                    switch (pizzaPos)
                    {
                        case 0:
                            newPos = 5;
                            break;
                        case 1:
                            pizzaPos--;
                            CrustListView.Hide();
                            CrustContinueButton.Hide();
                            PizzaErrorLabel.Text = "";
                            SmallButton.Show();
                            MediumButton.Show();
                            LargeButton.Show();
                            XLButton.Show();
                            PizzaLabel.Text = "Create a Pizza! (Step 1/4)";
                            break;
                        case 2:
                            pizzaPos--;
                            CrustListView.Show();
                            CrustContinueButton.Show();
                            PizzaErrorLabel.Text = "";
                            SauceListView.Hide();
                            SauceContinueButton.Hide();
                            SauceCheckBox.Hide();
                            PizzaLabel.Text = "Create a Pizza! (Step 2/4)";
                            break;
                        case 3:
                            pizzaPos--;
                            if (newPizza.sauce)
                            {
                                newPizza.removeToppings();
                            }
                            SauceListView.Show();
                            SauceContinueButton.Show();
                            PizzaErrorLabel.Text = "";
                            ToppingListView.Hide();
                            PizzaFinishButton.Hide();
                            CheeseCheckBox.Hide();
                            SauceCheckBox.Show();
                            PizzaLabel.Text = "Create a Pizza! (Step 3/4)";
                            break;

                    }
                    break;
                case 8:
                    newPos = 5;
                    break;
                case 9:
                    if (payFlag)
                    {
                        newPos = 10;
                        payFlag = false;
                    }
                    else if (trackFlag)
                    {
                        newPos = 11;
                        RemoveItemButton.Show();
                        NewFavButton.Show();
                        ViewOrderList.CheckBoxes = true;
                        trackFlag = false;
                    }
                    else
                    {
                        newPos = 5;
                    }
                    break;
                case 10:
                    newPos = 5;
                    break;
                case 11:
                    var logout2 = MessageBox.Show(this, "Are you sure you want to log out?",
                        "Confirm",
                        MessageBoxButtons.YesNo);
                    if (logout2 == DialogResult.Yes)
                    {
                        newPos = 2;
                        newOrder = new Order();
                    }
                    break;
                    break;
                case 12:
                    newPos = 0;
                    break;
            }

        }

        private void InfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogInConfirmButton_Click(object sender, EventArgs e)
        {
            bool emailVerified = false;
            bool passVerified = false;
            if (LogInEmailField.Text.Equals("") || LogInPassField.Text.Equals(""))
            {
                LogInErrorLabel.Text = "Email and Password fields cannot be empty.";
            }
            else
            {
                foreach(User user in users)
                {
                    if (LogInEmailField.Text.Equals(user.email))
                    {
                        emailVerified = true;
                    }
                    if (LogInPassField.Text.Equals(user.password))
                    {
                        passVerified = true;
                    }
                    if (emailVerified && passVerified)
                    {
                        currentUser = user;
                        FavListView1.Items.Clear();
                        FavListView2.Items.Clear();
                        FavListView3.Items.Clear();
                        FavTotalLabel1.Text = "Total: ";
                        FavTotalLabel2.Text = "Total: ";
                        FavTotalLabel3.Text = "Total: ";

                        if (currentUser.outgoingOrder)
                        {
                            newPos = 11;
                        }
                        else
                        {
                            newPos = 3;

                        }

                        break;
                    }
                }
            
                if (!emailVerified && !passVerified)
                {
                    LogInErrorLabel.Text = "               Invalid email or password.";
                }
            }

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            newPos = 4;
            FavListView1.Items.Clear();
            FavListView2.Items.Clear();
            FavListView3.Items.Clear();

            for (int m = 0; m < currentUser.favs.Length; m++)
            {
                Order favorite = currentUser.favs[m];
                if (favorite == null)
                {
                    continue;
                }
                for (int i = 0; i < favorite.items.Count(); i++)
                {
                    String[] parts = new string[2];
                    if (favorite.items[i] is Pizza)
                    {
                        switch (favorite.items[i].getSize())
                        {
                            case 1:
                                parts[0] = favorite.items[i].itemType + " S";
                                break;
                            case 2:
                                parts[0] = favorite.items[i].itemType + " M";
                                break;
                            case 3:
                                parts[0] = favorite.items[i].itemType + " L";
                                break;
                            case 4:
                                parts[0] = favorite.items[i].itemType + " XL";
                                break;
                        }
                        if (!favorite.items[i].getCheese())
                        {
                            parts[0] += " NO CHEESE";
                        }
                    }
                    else
                    {
                        parts[0] = favorite.items[i].itemType;
                    }
                    parts[1] = favorite.items[i].cost + "";
                    ListViewItem item = new ListViewItem(parts);
                    switch (m)
                    {
                        case 0:
                            FavListView1.Items.Add(item);
                            break;
                        case 1:
                            FavListView2.Items.Add(item);
                            break;
                        case 2:
                            FavListView3.Items.Add(item);
                            break;
                    }


                    if (favorite.items[i] is Pizza)
                    {
                        for (int j = 0; j < favorite.items[i].getToppings().Count; j++)
                        {
                            orderToppingNum++;
                            String[] pizzaParts = new string[2];
                            pizzaParts[0] = " ^" + favorite.items[i].getToppings()[j].itemType;
                            pizzaParts[1] = favorite.items[i].getToppings()[j].cost + "";
                            ListViewItem topping = new ListViewItem(pizzaParts);
                            switch (m)
                            {
                                case 0:
                                    FavListView1.Items.Add(topping);
                                    break;
                                case 1:
                                    FavListView2.Items.Add(topping);
                                    break;
                                case 2:
                                    FavListView3.Items.Add(topping);
                                    break;
                            }
                        }
                    }
                }
                switch (m)
                {
                    case 0:
                        FavTotalLabel1.Text = ("Total: $" + favorite.getTotal());
                        break;
                    case 1:
                        FavTotalLabel2.Text = ("Total: $" + favorite.getTotal());
                        break;
                    case 2:
                        FavTotalLabel3.Text = ("Total: $" + favorite.getTotal());
                        break;
                }
                
            }

        }

        // The below three methods do absolutely nothing but I can't figure out how to get rid of them without everything breaking so :/
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersTestDataSet1.Orders' table. You can move, or remove it, as needed.
            

        }

        private void testToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Test(this.ordersTestDataSet.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Fill(this.ordersTestDataSet.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            newPos = 5;
        }

        private void NewSideButton_Click(object sender, EventArgs e)
        {
            newPos = 6;
        }

        private void NewPizzaButton_Click(object sender, EventArgs e)
        {
            newPos = 7;
        }

        private void NewBevButton_Click(object sender, EventArgs e)
        {
            newPos = 8;
        }

        private void AddExtraButton_Click(object sender, EventArgs e)
        {
            // Adds a side or dessert to newOrder depending on what is selected.
            int numAdded = 0;
            if (SidesListView.Visible)
            {
                for (int i = 0; i < SidesListView.Items.Count; i++)
                {
                    if (SidesListView.Items[i].Checked)
                    {
                        newOrder.addItem(sidesMenu[i]);
                        numAdded++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < DessertsListView.Items.Count; i++)
                {
                    if (DessertsListView.Items[i].Checked)
                    {
                        newOrder.addItem(dessertsMenu[i]);
                        numAdded++;
                    }
                }
            }

            SidesAddedLabel.Text = numAdded + " items added to order.";
        }

        private void ViewOrderButton1_Click(object sender, EventArgs e)
        {
            // Switches to the view order screen and fills up the list which contains the order information.
            // Pizzas are special cases. When one is encounter in the item list, it adds each topping on its own row.
            newPos = 9;

            for (int i = 0; i < newOrder.items.Count(); i++)
            {
                String[] parts = new string[2];
                if (newOrder.items[i] is Pizza)
                {
                    switch (newOrder.items[i].getSize())
                    {
                        case 1:
                            parts[0] = newOrder.items[i].itemType + " S";
                            break;
                        case 2:
                            parts[0] = newOrder.items[i].itemType + " M";
                            break;
                        case 3:
                            parts[0] = newOrder.items[i].itemType + " L";
                            break;
                        case 4:
                            parts[0] = newOrder.items[i].itemType + " XL";
                            break;
                    }
                    if (!newOrder.items[i].getCheese())
                    {
                        parts[0] += " NO CHEESE";
                    }
                }
                else
                {
                    parts[0] = newOrder.items[i].itemType;
                }
                parts[1] = newOrder.items[i].cost + "";
                ListViewItem item = new ListViewItem(parts);
                ViewOrderList.Items.Add(item);

                if (newOrder.items[i] is Pizza)
                {
                    for (int j = 0; j < newOrder.items[i].getToppings().Count; j++)
                    {
                        orderToppingNum++;
                        String[] pizzaParts = new string[2];
                        pizzaParts[0] = " ^" + newOrder.items[i].getToppings()[j].itemType;
                        pizzaParts[1] = newOrder.items[i].getToppings()[j].cost + "";
                        ListViewItem topping = new ListViewItem(pizzaParts);
                        ViewOrderList.Items.Add(topping);
                    }
                }
            }
            ViewOrderTotalLabel.Text = ("Total: $" + newOrder.getTotal());
        }

        // The below two methods toggle between the sides menu and desserts menu on the extras screen.
        private void SwitchSidesButton_Click(object sender, EventArgs e)
        {
            SidesListView.Show();
            DessertsListView.Hide();
        }

        private void DessertsButtonSwitch_Click(object sender, EventArgs e)
        {
            DessertsListView.Show();
            SidesListView.Hide();
        }

        private void AddBevButton_Click(object sender, EventArgs e)
        {
            // Adds selected beverage to newOrder.
            int numAdded = 0;
            for (int i = 0; i < BeveragesListView.Items.Count; i++)
            {
                if (BeveragesListView.Items[i].Checked)
                {
                    newOrder.addItem(bevMenu[i]);
                    numAdded++;
                }
            }
            BevAddedLabel.Text = numAdded + " items added to order.";

        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            // Removes selected items from order, including toppings.
            // I have no idea how I made this work.
            int numRemoved = 0;
            int menuOffset = 0;
            int recentPizzaPos = 0;
            int truePos = 0;
            for (int i = 0; i < ViewOrderList.Items.Count; i++)
            {
                if (ViewOrderList.Items[i].Text.Substring(1, 1).Equals("^"))
                {
                    menuOffset++;
                }
                if (ViewOrderList.Items[i].Text.Length > 5)
                {
                    if (ViewOrderList.Items[i].Text.Substring(0, 5).Equals("Pizza"))
                    {
                        recentPizzaPos = i - menuOffset;
                        truePos = i;
                    }
                }
                

                if (ViewOrderList.Items[i].Checked)
                {
                    String pizzaCheck = "--";
                    if (ViewOrderList.Items[i].Text.Length > 5)
                    {
                        pizzaCheck = ViewOrderList.Items[i].Text.Substring(0, 5);
                    }
                    if (pizzaCheck.Equals("Pizza"))
                    {
                        for (int j = i + 1; j < i + newOrder.items[i - menuOffset].getToppings().Count; j++)
                        {
                            ViewOrderList.Items[j].Remove();
                            newOrder.items[i - menuOffset].removeToppings(0);
                            j--;

                        }
                        ViewOrderList.Items[i].Remove();
                        newOrder.removeItem(i - menuOffset);
                        i--;
                        numRemoved++;
                    }
                    else if (ViewOrderList.Items[i].Text.Substring(1, 1).Equals("^"))
                    {
                        if (ViewOrderList.Items[i - 1].Text.Substring(0, 5).Equals("Pizza"))
                        {
                            continue;
                        }
                        newOrder.items[recentPizzaPos].removeToppings(i - 1 - truePos);
                        ViewOrderList.Items[i].Remove();
                        menuOffset--;
                        i--;
                        numRemoved++;
                    }
                    else
                    {
                        ViewOrderList.Items[i].Remove();
                        newOrder.removeItem(i - menuOffset);
                        i--;
                        numRemoved++;
                    }
                }
            }

            ViewOrderList.Items.Clear();
            for (int i = 0; i < newOrder.items.Count(); i++)
            {
                String[] parts = new string[2];
                if (newOrder.items[i] is Pizza)
                {
                    switch (newOrder.items[i].getSize())
                    {
                        case 1:
                            parts[0] = newOrder.items[i].itemType + " S";
                            break;
                        case 2:
                            parts[0] = newOrder.items[i].itemType + " M";
                            break;
                        case 3:
                            parts[0] = newOrder.items[i].itemType + " L";
                            break;
                        case 4:
                            parts[0] = newOrder.items[i].itemType + " XL";
                            break;
                    }
                    if (!newOrder.items[i].getCheese())
                    {
                        parts[0] += " NO CHEESE";
                    }
                }
                else
                {
                    parts[0] = newOrder.items[i].itemType;
                }
                parts[1] = newOrder.items[i].cost + "";
                ListViewItem item = new ListViewItem(parts);
                ViewOrderList.Items.Add(item);

                if (newOrder.items[i] is Pizza)
                {
                    for (int j = 0; j < newOrder.items[i].getToppings().Count; j++)
                    {
                        String[] pizzaParts = new string[2];
                        pizzaParts[0] = " ^" + newOrder.items[i].getToppings()[j].itemType;
                        pizzaParts[1] = newOrder.items[i].getToppings()[j].cost + "";
                        ListViewItem topping = new ListViewItem(pizzaParts);
                        ViewOrderList.Items.Add(topping);
                    }
                }
            }
            ViewOrderTotalLabel.Text = ("Total: $" + newOrder.getTotal());
            RemoveItemsLabel.Text = numRemoved + " items removed from order.";

        }

        // The below four methods create new pizzas of the respective size.
        private void SmallButton_Click(object sender, EventArgs e)
        {
            newPizza = new Pizza("Pizza", 5.99, 1);
            SmallButton.Hide();
            MediumButton.Hide();
            LargeButton.Hide();
            XLButton.Hide();
            CrustListView.Show();
            CrustContinueButton.Show();

            pizzaPos++;
            PizzaLabel.Text = "Create a Pizza! (Step 2/4)";
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            newPizza = new Pizza("Pizza", 5.99, 2);
            SmallButton.Hide();
            MediumButton.Hide();
            LargeButton.Hide();
            XLButton.Hide();
            CrustListView.Show();
            CrustContinueButton.Show();

            pizzaPos++;
            PizzaLabel.Text = "Create a Pizza! (Step 2/4)";
        }

        private void LargeButton_Click(object sender, EventArgs e)
        {
            newPizza = new Pizza("Pizza", 5.99, 3);
            SmallButton.Hide();
            MediumButton.Hide();
            LargeButton.Hide();
            XLButton.Hide();
            CrustListView.Show();
            CrustContinueButton.Show();

            pizzaPos++;
            PizzaLabel.Text = "Create a Pizza! (Step 2/4)";
        }

        private void XLButton_Click(object sender, EventArgs e)
        {
            newPizza = new Pizza("Pizza", 5.99, 4);
            SmallButton.Hide();
            MediumButton.Hide();
            LargeButton.Hide();
            XLButton.Hide();
            CrustListView.Show();
            CrustContinueButton.Show();
            pizzaPos++;
            PizzaLabel.Text = "Create a Pizza! (Step 2/4)";
        }

        private void CrustContinueButton_Click(object sender, EventArgs e)
        {
            // Adds selected crust to pizza and continues to next step.
            int selected = 0;
            int selectedIndex = 0;
            for (int i = 0; i < CrustListView.Items.Count; i++)
            {
                if (CrustListView.Items[i].Checked)
                {
                    selected++;
                    selectedIndex = i;
                }
            }
            if (selected == 1)
            {
                pizzaPos++;
                newPizza.addTopping(crustMenu[selectedIndex]);
                newPizza.incCost(crustMenu[selectedIndex].cost);
                CrustListView.Hide();
                CrustContinueButton.Hide();
                SauceListView.Show();
                SauceContinueButton.Show();
                SauceCheckBox.Show();
                PizzaErrorLabel.Text = "";
                PizzaLabel.Text = "Create a Pizza! (Step 3/4)";
            }
            else
            {
                PizzaErrorLabel.Text = "Exactly one type of crust must be selected.";
            }

        }

        private void SauceContinueButton_Click(object sender, EventArgs e)
        {
            // Adds selected sauce to pizza and continues to next step.
            int selected = 0;
            int selectedIndex = 0;
            for (int i = 0; i < SauceListView.Items.Count; i++)
            {
                if (SauceListView.Items[i].Checked)
                {
                    selected++;
                    selectedIndex = i;
                }
            }
            if (selected == 1 && SauceCheckBox.Checked)
            {
                pizzaPos++;
                newPizza.addTopping(sauceMenu[selectedIndex]);
                newPizza.incCost(sauceMenu[selectedIndex].cost);
                SauceListView.Hide();
                SauceContinueButton.Hide();
                SauceCheckBox.Hide();
                ToppingListView.Show();
                PizzaFinishButton.Show();
                CheeseCheckBox.Show();
                newPizza.sauce = true;
                PizzaErrorLabel.Text = "";
                PizzaLabel.Text = "Create a Pizza! (Step 4/4)";
            }
            else
            {
                if (SauceCheckBox.Checked)
                {
                    PizzaErrorLabel.Text = "Exactly one type of sauce must be selected.";

                }
                else
                {   
                    if (selected > 0)
                    {
                        PizzaErrorLabel.Text = "Sauce cannot be added when sauce checkbox is unchecked.";

                    }
                    else
                    {
                        pizzaPos++;
                        SauceListView.Hide();
                        SauceContinueButton.Hide();
                        SauceCheckBox.Hide();
                        newPizza.sauce = false;
                        ToppingListView.Show();
                        PizzaFinishButton.Show();
                        CheeseCheckBox.Show();
                        PizzaErrorLabel.Text = "";
                        PizzaLabel.Text = "Create a Pizza! (Step 4/4)";
                    }

                }
            }
        }

        private void PizzaFinishButton_Click(object sender, EventArgs e)
        {
            // Finishes construction of pizza and adds it to the order. Returns to order creation screen.
            for (int i = 0; i < ToppingListView.Items.Count; i++)
            {
                if (ToppingListView.Items[i].Checked)
                {
                    newPizza.addTopping(topMenu[i]);
                    newPizza.incCost(topMenu[i].cost);
                }
            }
            if (CheeseCheckBox.Checked)
            {
                newPizza.cheese = true;
            }
            else
            {
                newPizza.cheese = false;
            }
            newOrder.addItem(newPizza);
            ToppingListView.Hide();
            PizzaFinishButton.Hide();
            CheeseCheckBox.Hide();
            SmallButton.Show();
            MediumButton.Show();
            LargeButton.Show();
            XLButton.Show();
            pizzaPos = 0;
            newPos = 5;
            PizzaErrorLabel.Text = "";
            PizzaLabel.Text = "Create a Pizza! (Step 1/4)";
        }

        private void ImDoneButton_Click(object sender, EventArgs e)
        {
            if (newOrder.items.Count == 0)
            {
                OrderCreationErrorLabel.Text = "Order must contain at least one item to proceed to payment.";
            }
            else
            {
                newPos = 10;
                
            }
        }

        private void ViewOrderButton2_Click(object sender, EventArgs e)
        {
            payFlag = true;
            newPos = 9;
            for (int i = 0; i < newOrder.items.Count(); i++)
            {
                String[] parts = new string[2];
                if (newOrder.items[i] is Pizza)
                {
                    switch (newOrder.items[i].getSize())
                    {
                        case 1:
                            parts[0] = newOrder.items[i].itemType + " S";
                            break;
                        case 2:
                            parts[0] = newOrder.items[i].itemType + " M";
                            break;
                        case 3:
                            parts[0] = newOrder.items[i].itemType + " L";
                            break;
                        case 4:
                            parts[0] = newOrder.items[i].itemType + " XL";
                            break;
                    }
                    if (!newOrder.items[i].getCheese())
                    {
                        parts[0] += " NO CHEESE";
                    }
                }
                else
                {
                    parts[0] = newOrder.items[i].itemType;
                }
                parts[1] = newOrder.items[i].cost + "";
                ListViewItem item = new ListViewItem(parts);
                ViewOrderList.Items.Add(item);

                if (newOrder.items[i] is Pizza)
                {
                    for (int j = 0; j < newOrder.items[i].getToppings().Count; j++)
                    {
                        orderToppingNum++;
                        String[] pizzaParts = new string[2];
                        pizzaParts[0] = " ^" + newOrder.items[i].getToppings()[j].itemType;
                        pizzaParts[1] = newOrder.items[i].getToppings()[j].cost + "";
                        ListViewItem topping = new ListViewItem(pizzaParts);
                        ViewOrderList.Items.Add(topping);
                    }
                }
            }
            ViewOrderTotalLabel.Text = ("Total: $" + newOrder.getTotal());
        }

        private void PickupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PickupCheckBox.Checked)
            {
                DeliveryCheckBox.Checked = false;
            }
        }

        private void DeliveryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DeliveryCheckBox.Checked)
            {
                PickupCheckBox.Checked = false;
            }
        }

        private void ConfirmPaymentButton_Click(object sender, EventArgs e)
        {
            var confirmPay = MessageBox.Show(this, "Are you sure you want to place this order?",
                "Confirm",
                MessageBoxButtons.YesNo);
            if (confirmPay == DialogResult.Yes)
            {
                newPos = 11;
                orderedFlag = true;
                currentUser.outgoingOrder = true;
                trackFlag = true;
                payFlag = false;
                orderTimer = 500;
                currentUser.currentOrder = newOrder;
                OrderProgressBar.Value = 0;
                OrderStatusLabel.Text = "Order Status: Prepping";
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            
            newPos = 12;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            bool hasspecial = false;
            bool hasUpper = false;
            String[] specialChars = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "/", "|", "[", "]", "{", "}", ";", ":", "?", ".", ",", ">", "<" };
            for (int i = 0; i < specialChars.Count(); i++)
            {
                if (SignUpPassField.Text.Contains(specialChars[i])){
                    hasspecial = true;
                }
            }
            for (int i = 0; i < SignUpPassField.Text.Length; i++)
            {
                if (Char.IsUpper((Char)SignUpPassField.Text[i]))
                {
                    hasUpper = true;
                }
            }

            if (SignUpEmailField.Text.Equals("") || SignUpPassField.Text.Equals("") || SignUpFirstNameField.Text.Equals("") || SignUpLastNameField.Text.Equals(""))
            {
                SignUpErrorLabel.Text = "                                                   User information fields cannot be empty.";
            }
            else
            {
                if (hasUpper && hasspecial && SignUpPassField.Text.Length >= 8)
                {
                    users.Add(new User(SignUpEmailField.Text, SignUpPassField.Text, SignUpFirstNameField.Text, SignUpLastNameField.Text));
                    SignUpInfoLabel.Text = "User account created. You may now log in with specified information.";
                }
                else
                {
                    SignUpErrorLabel.Text = "Invalid password. Must be at least 8 characters long and contain a special character and an uppercase character.";
                }
            }

            
        }

        private void FavCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (FavCheckBox1.Checked)
            {
                FavCheckBox2.Checked = false;
                FavCheckBox3.Checked = false;
            }

        }

        private void FavCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (FavCheckBox2.Checked)
            {
                FavCheckBox1.Checked = false;
                FavCheckBox3.Checked = false;
            }
        }

        private void FavCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (FavCheckBox3.Checked)
            {
                FavCheckBox1.Checked = false;
                FavCheckBox2.Checked = false;
            }
        }

        private void ReorderButton_Click(object sender, EventArgs e)
        {
            int decision = -1;
            if (FavCheckBox1.Checked)
            {
                decision = 1;
            }
            else if (FavCheckBox2.Checked) {
                decision = 2;
            }
            else if (FavCheckBox3.Checked)
            {
                decision = 3;
            }
            switch (decision)
            {
                case -1:
                    FavErrorLabel.Text = "    Must select a favorite to reorder.";
                    break;
                case 1:
                    if (currentUser.favs[0] == null)
                    {
                        FavErrorLabel.Text = "        Order cannot be empty.";
                        break;
                    }
                    newOrder = currentUser.favs[0];
                    newPos = 10;
                    payFlag = true;
                    break;
                case 2:
                    if (currentUser.favs[1] == null)
                    {
                        FavErrorLabel.Text = "        Order cannot be empty.";
                        break;
                    }
                    newOrder = currentUser.favs[1];
                    newPos = 10;
                    payFlag = true;
                    break;
                case 3:
                    if (currentUser.favs[2] == null)
                    {
                        FavErrorLabel.Text = "        Order cannot be empty.";
                        break;
                    }
                    newOrder = currentUser.favs[2];
                    newPos = 10;
                    payFlag = true;
                    break;
            }
        }

        private void NewFavButton_Click(object sender, EventArgs e)
        {
            if (newOrder.items.Count() > 0)
            {
                currentUser.addFav(newOrder);
                RemoveItemsLabel.Text = "Order added to favorites.";
            }
            else
            {
                ViewOrderErrorLabel.Text = "Cannot favorite an empty order.";
            }
        }

        private void ViewOrderButton3_Click(object sender, EventArgs e)
        {
            trackFlag = true;
            RemoveItemButton.Hide();
            NewFavButton.Hide();
            ViewOrderList.CheckBoxes = false;

            newPos = 9;
            for (int i = 0; i < currentUser.currentOrder.items.Count(); i++)
            {
                String[] parts = new string[2];
                if (currentUser.currentOrder.items[i] is Pizza)
                {
                    switch (currentUser.currentOrder.items[i].getSize())
                    {
                        case 1:
                            parts[0] = currentUser.currentOrder.items[i].itemType + " S";
                            break;
                        case 2:
                            parts[0] = currentUser.currentOrder.items[i].itemType + " M";
                            break;
                        case 3:
                            parts[0] = currentUser.currentOrder.items[i].itemType + " L";
                            break;
                        case 4:
                            parts[0] = currentUser.currentOrder.items[i].itemType + " XL";
                            break;
                    }
                    if (!currentUser.currentOrder.items[i].getCheese())
                    {
                        parts[0] += " NO CHEESE";
                    }
                }
                else
                {
                    parts[0] = currentUser.currentOrder.items[i].itemType;
                }
                parts[1] = currentUser.currentOrder.items[i].cost + "";
                ListViewItem item = new ListViewItem(parts);
                ViewOrderList.Items.Add(item);

                if (currentUser.currentOrder.items[i] is Pizza)
                {
                    for (int j = 0; j < currentUser.currentOrder.items[i].getToppings().Count; j++)
                    {
                        orderToppingNum++;
                        String[] pizzaParts = new string[2];
                        pizzaParts[0] = " ^" + currentUser.currentOrder.items[i].getToppings()[j].itemType;
                        pizzaParts[1] = currentUser.currentOrder.items[i].getToppings()[j].cost + "";
                        ListViewItem topping = new ListViewItem(pizzaParts);
                        ViewOrderList.Items.Add(topping);
                    }
                }
            }
            ViewOrderTotalLabel.Text = ("Total: $" + currentUser.currentOrder.getTotal());
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = MessageBox.Show(this, "Are you sure you want to cancel?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (confirmCancel == DialogResult.Yes)
            {
                currentUser.outgoingOrder = false;
                currentUser.orderTimer = 500;
                newPos = 5;
            }
        }
    }
}
