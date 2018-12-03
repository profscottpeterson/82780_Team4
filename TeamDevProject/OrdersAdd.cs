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
    public partial class OrdersAdd : Form
    {
        public OrdersAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all text input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetOrdersAdd_Click(object sender, EventArgs e)
        {
            txtCustIDOrdersAdd.Text = "";
        }

        /// <summary>
        /// Returns user to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnOrdersAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates all user inputs, then saves new order to order table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdersAddGo_Click(object sender, EventArgs e)
        {
            bool custCheck = false;

            //Creating needed classes
            Orders ord = new Orders();
            Validation val = new Validation();

            //Running validation and saving validated input to object class
            ord.Date = ordersDatePk.Text;
            ord.CustID = val.numValidate(txtCustIDOrdersAdd.Text);

            //Creating List to hold all customer objects.
            List<Customer> allCustomers = new List<Customer>();

            //Get all customers from the database.
            allCustomers = CustomerSQL.LoadCustomers();

            foreach (Customer c in allCustomers)
            {
                if (c.CustID == ord.CustID)
                {
                    custCheck = true;
                }
            }

            //If all input is valid (returns something other than "" -1) saves results and displays conformation message
            if (ord.CustID != -1 && ord.Date != "" && custCheck == true)
            {
                OrdersSQL.SaveOrder(ord);
                MessageBox.Show("Successfully added order with Customer ID " + ord.CustID +
                                "\nand date " + ord.Date);
            }
            //Else program will cancel the save, and display text fields that caused the error
            else if (ord.CustID == -1 || ord.Date == "")
            {
                string error = "Add canceled due to error in the following fields:";

                if (ord.Date == "")
                {
                    error += " \n   Date";
                }

                if (ord.CustID == -1)
                {
                    error += " \n   Customer ID";
                }

                error += " \n \nPlease ensure all fields are not empty and have proper input.";

                MessageBox.Show(error);
            }
            else
            {
                string error = "Add canceled; the provided Customer ID was not found.";

                MessageBox.Show(error);
            }
        }
    }
}
