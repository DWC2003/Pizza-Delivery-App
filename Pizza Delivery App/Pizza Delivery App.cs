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
        Order newOrder = new Order();
        List<MenuItem> sidesMenu = new List<MenuItem>();
        List<MenuItem> dessertsMenu = new List<MenuItem>();
        List<MenuItem> bevMenu = new List<MenuItem>();
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
                parts[0] = newOrder.items[i].itemType;
                parts[1] = newOrder.items[i].cost + "";
                ListViewItem item = new ListViewItem(parts);
                ViewOrderList.Items.Add(item);
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
            for (int i = 0; i < ViewOrderList.Items.Count; i++)
            {
                if (ViewOrderList.Items[i].Checked)
                {
                    ViewOrderList.Items[i].Remove();
                    newOrder.removeItem(i);
                    i--;
                    numRemoved++;
                }
            }

            ViewOrderList.Items.Clear();
            for (int i = 0; i < newOrder.items.Count(); i++)
            {
                String[] parts = new string[2];
                parts[0] = newOrder.items[i].itemType;
                parts[1] = newOrder.items[i].cost + "";
                ListViewItem item = new ListViewItem(parts);
                ViewOrderList.Items.Add(item);
            }
            ViewOrderTotalLabel.Text = ("Total: $" + newOrder.getTotal());

            RemoveItemsLabel.Text = numRemoved + " items removed from order.";

        }
    }
}
