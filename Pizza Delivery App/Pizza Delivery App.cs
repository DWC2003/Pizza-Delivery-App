using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Pizza_Delivery_App
{
    public partial class Form1 : Form
    {
        public int menuPos = 0;
        public int newPos = 0;
        public int pizzaPos = 0;
        int orderToppingNum = 0;
        Order newOrder = new Order();
        Pizza newPizza;
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

            // Populates Sides Menu
            sidesMenu.Add(new Extras("Fries", 3.99, "Side"));
            sidesMenu.Add(new Extras("Wings(5)", 3.99, "Side"));
            sidesMenu.Add(new Extras("Wings(10)", 5.99, "Side"));
            sidesMenu.Add(new Extras("Pasta", 3.99, "Side"));

            for (int i = 0; i < sidesMenu.Count(); i++)
            {
                String[] parts = new String[2];

                parts[0] = sidesMenu[i].itemType;
                parts[1] = "" + sidesMenu[i].cost;

                ListViewItem item = new ListViewItem(parts);
                SidesListView.Items.Add(item);
            }

            // Populates Desserts Menu
            dessertsMenu.Add(new Extras("Brownies", 3.99, "Dessert"));
            dessertsMenu.Add(new Extras("Ice Cream", 3.99, "Dessert"));
            dessertsMenu.Add(new Extras("Lava Cake", 3.99, "Dessert"));

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
            bevMenu.Add(new Extras("Water", 3.99, "Beverage"));

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
            topMenu.Add(new Extras("Mushrooms", 3.99, "Topping"));

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
                FavList.Items.Add(favOrder);

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
                        break;
                    case 3:
                        OrderMainPanel.Hide();
                        break;
                    case 4:
                        FavoritesPanel.Hide();
                        break;
                    case 5:
                        OrderCreationPanel.Hide();
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
                }
            }

            menuPos = newPos;
            
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
                    newPos = 2;
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
                    newPos = 5;
                    break;
            }

        }

        private void InfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogInConfirmButton_Click(object sender, EventArgs e)
        {
            newPos = 3;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            newPos = 4;
        }

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
    }
}
