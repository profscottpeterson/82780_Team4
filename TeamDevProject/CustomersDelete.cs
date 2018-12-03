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
    public partial class CustomersDelete : Form
    {
        private bool help = false;

        public CustomersDelete()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all text input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetCustomerDelete_Click(object sender, EventArgs e)
        {
            txtIDCustomerDelete.Text = "";
        }

        /// <summary>
        /// Returns user to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnCustomerDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates all user inputs, then deletes given record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomerDeleteGo_Click(object sender, EventArgs e)
        {
            //Creating needed classes
            Customer cust = new Customer();
            Validation val = new Validation();

            //Running validation and saving validated input to object class
            cust.CustID = val.numValidate(txtIDCustomerDelete.Text);

            //If input is valid...
            if (cust.CustID != -1)
            {
                //Bool to check whether given ID exists in database
                bool idExist = false;

                //Creating List to hold all customer objects.
                List<Customer> allCustomers = new List<Customer>();
                //Get all customers from the database.
                allCustomers = CustomerSQL.LoadCustomers();

                //Loops through database and checks to see if given ID exists
                foreach (Customer c in allCustomers)
                {
                    if (c.CustID == cust.CustID)
                    {
                        idExist = true;

                        //Fills out first and last name of customer if ID is found
                        cust.FirstName = c.FirstName;
                        cust.LastName = c.LastName;
                    }
                }

                //If ID is found, deletes record and displays conformation message
                if (idExist == true)
                {
                    CustomerSQL.DeleteCustomer(cust);
                    MessageBox.Show("Successfully deleted " + cust.FirstName + " " + cust.LastName);
                }
                //Else program will cancel the delete, and display error message
                else
                {
                    MessageBox.Show("Delete cancelled; provided ID could not be found in database.");
                }
            }
            //Else program will cancel the delete, and display error message
            else
            {
                MessageBox.Show("Delete cancelled due to error in Customer ID field." +
                                "\n\nPlease ensure field is not empty and has proper input.");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help = true;
            btnHelp.Enabled = false;
        }

        private void txtIDCustomerDelete_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the ID of the customer you wish to delete." +
                                "\nThe ID must be positive and a whole number.");
                btnHelp.Enabled = true;
                help = false;
            }
        }
    }
}
