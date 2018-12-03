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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Brings user to the inventory form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryMain Inv = new InventoryMain();
            Inv.ShowDialog();
        }

        /// <summary>
        /// Brings user to the order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersMain Ord = new OrdersMain();
            Ord.ShowDialog();
        }

        /// <summary>
        /// Brings user to the customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomersMain cust = new CustomersMain();
            cust.ShowDialog();
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Brings user to the order item form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderItem_Click(object sender, EventArgs e)
        {
            OrderItemMain ordInv = new OrderItemMain();
            ordInv.ShowDialog();
        }
    }
}
