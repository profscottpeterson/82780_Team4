﻿using System;
using System.Windows.Forms;

namespace TeamDevProject
{
    public partial class CustomersAdd : Form
    {
        private bool help = false;

        public CustomersAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all text input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetCustomerAdd_Click(object sender, EventArgs e)
        {
            txtFNameCustomerAdd.Text = "";
            txtLNameCustomerAdd.Text = "";
            txtEMailCustomerAdd.Text = "";
        }

        /// <summary>
        /// Returns user to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnCustomerAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates all user inputs, then saves new customer to customer table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomerAddGo_Click(object sender, EventArgs e)
        {
            //Creating needed classes
            Customer cust = new Customer();
            Validation val = new Validation();

            //Running validation and saving validated input to object class
            cust.FirstName = txtFNameCustomerAdd.Text;
            cust.LastName = txtLNameCustomerAdd.Text;
            cust.Email = val.emailValidate(txtEMailCustomerAdd.Text);

            //If all input is valid (returns something other than "") saves results and displays conformation message
            if (cust.FirstName != "" && cust.LastName != "" && cust.Email != "")
            {
                CustomerSQL.SaveCustomer(cust);
                MessageBox.Show("Successfully added " + cust.FirstName + " " + cust.LastName +
                                "\nwith EMail address " + cust.Email);
            }
            //Else program will cancel the save, and display text fields that caused the error
            else
            {
                string error = "Add canceled due to error in the following fields:";

                if (cust.FirstName == "")
                {
                    error += " \n   First Name";
                }

                if (cust.LastName == "")
                {
                    error += " \n   Last Name";
                }

                if (cust.Email == "")
                {
                    error += " \n   EMail";
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

        private void txtFNameCustomerAdd_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter your new customer's first name." +
                                "\nThere are no limitations on the name, but it cannot be empty.");
                btnHelp.Enabled = true;
                help = false;
            }
        }

        private void txtLNameCustomerAdd_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter your new customer's last name." +
                                "\nThere are no limitations on the name, but it cannot be empty.");
                btnHelp.Enabled = true;
                help = false;
            }
        }

        private void txtEMailCustomerAdd_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter your new customer's Email." +
                                "\nIt must be formatted as text@text.text");
                btnHelp.Enabled = true;
                help = false;
            }
        }
    }
}
