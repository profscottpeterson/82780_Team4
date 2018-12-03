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
    public partial class InventoryDelete : Form
    {
        private bool help = false;

        public InventoryDelete()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all text input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetInventoryDelete_Click(object sender, EventArgs e)
        {
            txtIDInventoryDelete.Text = "";
        }

        /// <summary>
        /// Returns user to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnInventoryDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates all user inputs, then deletes given record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventoryDeleteGo_Click(object sender, EventArgs e)
        {
            // Create a temporary inventory object.
            Inventory inv = new Inventory();
            Validation val = new Validation();

            //Running validation and saving validated input to object class
            inv.InvID = val.numValidate(txtIDInventoryDelete.Text);

            //If input is valid...
            if (inv.InvID != -1)
            {
                //Bool to check whether given ID exists in database
                bool idExist = false;

                //Creating List to hold all inventory objects.
                List<Inventory> allInventory = new List<Inventory>();

                //Get all items from the inventory table.
                allInventory = InventorySQL.LoadInventory();

                //Loops through database and checks to see if given ID exists
                foreach (Inventory i in allInventory)
                {
                    if (i.InvID == inv.InvID)
                    {
                        idExist = true;

                        //Fills out item name of inventory if ID is found
                        inv.ItemName = i.ItemName;
                    }
                }

                //If ID is found, deletes record and displays conformation message
                if (idExist == true)
                {
                    InventorySQL.DeleteInventory(inv);
                    MessageBox.Show("Successfully deleted " + inv.ItemName);
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
                MessageBox.Show("Delete cancelled due to error in Inventory ID field." +
                                "\n\nPlease ensure field is not empty and has proper input.");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help = true;
            btnHelp.Enabled = false;
        }

        private void txtIDInventoryDelete_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the ID of the item you wish to delete." +
                                "\nThe ID must be positive and a whole number.");
                btnHelp.Enabled = true;
                help = false;
            }
        }
    }
}
