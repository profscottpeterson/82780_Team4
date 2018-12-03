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
    public partial class OrdersDelete : Form
    {
        private bool help = false;
        public OrdersDelete()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears all text input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResetOrdersDelete_Click(object sender, EventArgs e)
        {
            txtIDOrdersDelete.Text = "";
        }

        /// <summary>
        /// Returns user to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnOrdersDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validates all user inputs, then deletes given record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdersDeleteGo_Click(object sender, EventArgs e)
        {
            //Creating needed classes
            Orders ord = new Orders();
            Validation val = new Validation();

            //Running validation and saving validated input to object class
            ord.OrderID = val.numValidate(txtIDOrdersDelete.Text);

            //If input is valid...
            if (ord.OrderID != -1)
            {
                OrdersSQL.DeleteOrder(ord.OrderID);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help = true;
            btnHelp.Enabled = false;
        }

        private void txtIDOrdersDelete_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box to enter the ID of the order you wish to delete." +
                                "\nThe ID must be positive and a whole number.");
                btnHelp.Enabled = true;
                help = false;
            }
        }
    }
}
