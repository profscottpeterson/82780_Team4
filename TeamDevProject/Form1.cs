using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamDevProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = CustomerSQL.LoadCustomers();
            foreach(var blah in test)
            {
                listBox1.Items.Add(blah.FirstName + " " + blah.LastName);
            }
            
        }

        private void ordBtn_Click(object sender, EventArgs e)
        {
            ordBox.Items.Clear();

            var orders = OrdersSQL.LoadOrders();
            foreach (var ord in orders)
            {
                ordBox.Items.Add("CustID: " + ord.CustID + " OrderID: " + ord.OrderID + " Date: " + ord.Date);
            }
        }
    }
}
