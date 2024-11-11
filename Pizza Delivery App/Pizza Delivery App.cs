using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Delivery_App
{
    public partial class Form1 : Form
    {
        public int menuPos = 0;
        public int newPos = 0;
        List<Order> favs = new List<Order>();

        public Form1()
        {
            InitializeComponent();

            List<MenuItem> test = new List<MenuItem>();
            test.Add(new Extras("Fries"));
            test.Add(new Extras("Cola"));
            test.Add(new Extras("Brownies"));
            favs.Add(new Order(test));
            favs.Add(new Order(test));
            favs.Add(new Order(test));

            //
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
            

            //Back.Hide();

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
    }
}
