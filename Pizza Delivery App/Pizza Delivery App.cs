using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public Form1()
        {
            InitializeComponent();

            Timer tmr = new Timer();
            tmr.Interval = 50;   // milliseconds
            tmr.Tick += Tmr_Tick;  // set handler
            tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)  //run this logic each timer tick
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
