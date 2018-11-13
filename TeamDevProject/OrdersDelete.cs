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
        public OrdersDelete()
        {
            InitializeComponent();
        }

        private void btnResetOrdersDelete_Click(object sender, EventArgs e)
        {
            txtIDOrdersDelete.Text = "";
        }

        private void btnReturnOrdersDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitOrdersDelete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrdersDeleteGo_Click(object sender, EventArgs e)
        {
            // Create a temporary inventory object.
            Orders temp = new Orders();
            bool success;
            int result;

            // Assign temp's values based on input.
            if (txtIDOrdersDelete.Text != "")
            {

                success = Int32.TryParse(txtIDOrdersDelete.Text, out result);
                if (success)
                {
                    temp.OrderID = int.Parse(txtIDOrdersDelete.Text);
                    // Use the DeleteInventory method and pass temp as an argument.
                    OrdersSQL.DeleteOrder(temp.OrderID);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Order ID.");
                    txtIDOrdersDelete.Text = "";
                    txtIDOrdersDelete.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter an Order ID.");
                txtIDOrdersDelete.Focus();
            }

            
        }
    }
}
