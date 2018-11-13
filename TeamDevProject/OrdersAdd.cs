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
        private void btnResetOrdersAdd_Click(object sender, EventArgs e)
        {
            txtCustIDOrdersAdd.Text = "";
        }

        private void btnReturnOrdersAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitOrdersAdd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrdersAddGo_Click(object sender, EventArgs e)
        {
            // Create a temporary inventory object.
            Orders temp = new Orders();
            bool success;
            int result;

            temp.Date = ordersDatePk.Text;

            // Assign temp's values.
            if (txtCustIDOrdersAdd.Text != "")
            {
                success = Int32.TryParse(txtCustIDOrdersAdd.Text, out result);
                if (success)
                {
                    temp.CustID = Int32.Parse(txtCustIDOrdersAdd.Text);

                    // Call the SaveInventory method and pass temp as an argument.
                    OrdersSQL.SaveOrder(temp);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Customer ID.");
                    txtCustIDOrdersAdd.Text = "";
                    txtCustIDOrdersAdd.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a Customer ID.");
                txtCustIDOrdersAdd.Focus();
            }
        }
    }
}
