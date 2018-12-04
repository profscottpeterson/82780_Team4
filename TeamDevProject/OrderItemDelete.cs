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
    public partial class OrderItemDelete : Form
    {
        private bool help = false;
        public OrderItemDelete()
        {
            InitializeComponent();
        }

        private void btnResetOrderItemDelete_Click(object sender, EventArgs e)
        {
            txtInvIDOrderItemDelete.Text = "";
            txtOrderIDOrderItemDelete.Text = "";
        }

        private void btnReturnOrderItemDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderItemDeleteGo_Click(object sender, EventArgs e)
        {
            //Creating needed classes
            OrderItem ordItem = new OrderItem();
            Validation val = new Validation();

            //Running validation and saving validated input to object class
            ordItem.orderId = val.numValidate(txtOrderIDOrderItemDelete.Text);
            ordItem.invId = val.numValidate(txtInvIDOrderItemDelete.Text);

            //If input is valid...
            if (ordItem.orderId != -1 && ordItem.invId != -1)
            {
                //Bool to check whether given ID exists in database
                bool idExist = false;

                //Creating List to hold all customer objects.
                List<OrderItem> allOrderItems = new List<OrderItem>();
                //Get all customers from the database.
                allOrderItems = OrderItemSQL.LoadOrderItems();

                //Loops through database and checks to see if given ID exists
                foreach (OrderItem oi in allOrderItems)
                {
                    if (oi.orderId == ordItem.orderId && oi.invId == ordItem.invId)
                    {
                        idExist = true;
                    }
                }

                //If ID is found, deletes record and displays conformation message
                if (idExist == true)
                {
                    OrderItemSQL.DeleteOrderItem(ordItem);
                    MessageBox.Show("Successfully deleted connection between Order ID " + ordItem.orderId + " and Inventory ID " + ordItem.invId);
                }
                //Else program will cancel the delete, and display error message
                else
                {
                    MessageBox.Show("Delete cancelled; provided IDs could not be found in database.");
                }
            }
            //Else program will cancel the delete, and display error message
            else
            {
                string error = "Delete canceled due to error in the following fields:";

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
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help = true;
            btnHelp.Enabled = false;
        }

        private void txtOrderIDOrderItemDelete_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the Order ID of the record you wish to delete." +
                                "\nThe ID must be positive and a whole number.");
                btnHelp.Enabled = true;
                help = false;
            }
        }

        private void txtInvIDOrderItemDelete_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the Inventory ID of the record you wish to delete." +
                                "\nThe ID must be positive and a whole number.");
                btnHelp.Enabled = true;
                help = false;
            }
        }
    }
}
