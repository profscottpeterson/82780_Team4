using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Data.SQLite;
using Dapper;


namespace TeamDevProject
{
    public partial class InventoryAdd : Form
    {
        private bool help = false;

        public InventoryAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all text input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetInventoryAdd_Click(object sender, EventArgs e)
        {
            txtNameInventoryAdd.Text = "";
            txtPriceInventoryAdd.Text = "";
        }

        /// <summary>
        /// Returns user to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnInventoryAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates all user inputs, then saves new item to inventory table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryAddGo_Click(object sender, EventArgs e)
        {
            //Creating needed classes
            Inventory inv = new Inventory();
            Validation val = new Validation();

            //Running validation and saving validated input to object class
            inv.ItemName = txtNameInventoryAdd.Text;
            inv.Price = val.moneyValidate(txtPriceInventoryAdd.Text);

            //If all input is valid (returns something other than "" or -1) saves results and displays conformation message
            if (inv.ItemName != "" && inv.Price != -1)
            {
                InventorySQL.SaveInventory(inv);
                MessageBox.Show("Successfully saved item " + inv.ItemName +
                                "\nwith price of " + inv.Price);
            }
            //Else program will cancel the save, and display text fields that caused the error
            else
            {
                string error = "Add canceled due to error in the following fields:";

                if (inv.ItemName == "")
                {
                    error += " \n   Item Name";
                }

                if (inv.Price == -1)
                {
                    error += " \n   Price";
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

        private void txtNameInventoryAdd_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the new item's name." +
                                "\nThere are no limitations on the name, but it cannot be empty.");
                btnHelp.Enabled = true;
                help = false;
            }
        }

        private void txtPriceInventoryAdd_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the new item's price." +
                                "\nThe price must be a positive number, and will be rounded to two decimals.");
                btnHelp.Enabled = true;
                help = false;
            }
        }
    }
}
