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
    public partial class OrderItemAdd : Form
    {
        private bool help = false;
        public OrderItemAdd()
        {
            InitializeComponent();
        }

        private void btnResetOrderItemAdd_Click(object sender, EventArgs e)
        {
            txtInvIDOrderItemAdd.Text = "";
            txtOrderIDOrderItemAdd.Text = "";
        }

        private void btnReturnOrderItemAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderItemAddGo_Click(object sender, EventArgs e)
        {
            bool ordCheck = false;
            bool invCheck = false;

            //Creating needed classes
            OrderItem ordItem = new OrderItem();
            Validation val = new Validation();

            //Running validation and saving validated input to object class
            ordItem.invId = val.numValidate(txtInvIDOrderItemAdd.Text);
            ordItem.orderId = val.numValidate(txtOrderIDOrderItemAdd.Text);

            //Creating List to hold all inventory objects.
            List<Inventory> allInventory = new List<Inventory>();

            //Get all items from the inventory table.
            allInventory = InventorySQL.LoadInventory();

            foreach (Inventory i in allInventory)
            {
                if (i.InvID == ordItem.invId)
                {
                    invCheck = true;
                }
            }

            //Creating List to hold all order objects.
            List<Orders> allOrders = new List<Orders>();

            //Get all orders from the database.
            allOrders = OrdersSQL.LoadOrders();

            foreach (Orders o in allOrders)
            {
                if (o.OrderID == ordItem.orderId)
                {
                    ordCheck = true;
                }
            }

            //If all input is valid (returns something other than -1) saves results and displays conformation message
            if (ordItem.invId != -1 && ordItem.orderId != -1 && invCheck == true && ordCheck == true)
            {
                bool idCheck = false;

                //Creating List to hold all customer objects.
                List<OrderItem> allOrderItems = new List<OrderItem>();

                //Get all customers from the database.
                allOrderItems = OrderItemSQL.LoadOrderItems();

                foreach (OrderItem oi in allOrderItems)
                {
                    if (oi.orderId == ordItem.orderId && oi.invId == ordItem.invId)
                    {
                        idCheck = true;
                    }
                }

                if (idCheck == false)
                {
                    OrderItemSQL.SaveOrderItem(ordItem);
                    MessageBox.Show("Successfully added connection between Inventory ID " + ordItem.invId + " and Order ID " + ordItem.orderId);
                }
                else
                {
                    MessageBox.Show("Add cancelled; provided IDs already exist in database.");
                }
            }
            else if (ordItem.invId == -1 || ordItem.orderId == -1)
            {
                string error = "Add canceled due to error in the following fields:";

                if (ordItem.invId == -1)
                {
                    error += " \n   Inventory ID";
                }

                if (ordItem.orderId == -1)
                {
                    error += " \n   Order ID";
                }

                error += " \n \nPlease ensure all fields are not empty and have proper input.";

                MessageBox.Show(error);
            }
            else
            {
                string error = "Add canceled; the IDs input for the following text fields were not found:";

                if (ordCheck == false)
                {
                    error += "\n   Order ID";
                }

                if (invCheck == false)
                {
                    error += "\n   Inventory ID";
                }

                error += "\n\nPlease ensure that all fields have existing IDs.";

                MessageBox.Show(error);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help = true;
            btnHelp.Enabled = false;
        }

        private void txtOrderIDOrderItemAdd_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the ID of the order that the item is part of." +
                                "\nThe ID must be positive and a whole number.");
                btnHelp.Enabled = true;
                help = false;
            }
        }

        private void txtInvIDOrderItemAdd_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the ID of the item that is being added to an order." +
                                "\nThe ID must be positive and a whole number.");
                btnHelp.Enabled = true;
                help = false;
            }
        }
    }
}
