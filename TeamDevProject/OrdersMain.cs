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
    public partial class OrdersMain : Form
    {
        private bool help = false;
        public DataView orderView;

        public OrdersMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns user to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdersReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Brings user to the Add form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            OrdersAdd OrdAdd = new OrdersAdd();
            OrdAdd.ShowDialog();
        }

        /// <summary>
        /// Brings user to the Delete form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            OrdersDelete OrdDelete = new OrdersDelete();
            OrdDelete.ShowDialog();
        }

        /// <summary>
        /// On form load, loads all records from database and displays them in data grid. (Also called by Refresh button)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersMain_Load(object sender, EventArgs e)
        {
            //Resetting search box for Refresh button
            txtBoxSearchOrderID.Text = "";
            txtBoxSearchOrderCustID.Text = "";

            //Creating List to hold all order objects.
            List<Orders> allOrders = new List<Orders>();

            //Get all orders from the database.
            allOrders = OrdersSQL.LoadOrders();

            //Creating DataTable object to present the Customer Table from the database.
            DataTable ordersTable = new DataTable();

            //Adding the Rows that we are going to display.
            ordersTable.Columns.Add("ID");
            ordersTable.Columns.Add("Customer ID");
            ordersTable.Columns.Add("Date");

            //Adding object from the allOrders list as row in our Data Table.
            foreach (var orders in allOrders)
            {
                ordersTable.Rows.Add(orders.OrderID, orders.CustID, orders.Date);
            }

            //Filling our Data Table in a DataView so we can give it to our DataGrid.
            orderView = new DataView(ordersTable);

            //Dynamically adjust the width of the DataGrid depending on how many columns we have.
            dataGridOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Adding the DataView with our Customers to the DataGrid
            dataGridOrder.DataSource = orderView;

            //Making the DataGrid read only.
            dataGridOrder.ReadOnly = true;

            //Removing the option for users to add directly into the database.
            dataGridOrder.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Method run everytime user alters a text box. Used to filter data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxSearchOrder_TextChanged(object sender, EventArgs e)
        {
            dataSearch();
        }

        /// <summary>
        /// Filters data in dataview based on user input.
        /// </summary>
        private void dataSearch()
        {
            //Filtering the DataView with the text we have from the Inventory TextBox.
            orderView.RowFilter = string.Format("ID like '%{0}%' AND [Customer ID] like '%{1}%' AND Date like '%{2}%'", txtBoxSearchOrderID.Text, txtBoxSearchOrderCustID.Text, dpkSearchOrderDate.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridOrder.DataSource = orderView;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help = true;
            btnHelp.Enabled = false;
        }

        private void txtBoxSearchOrderID_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box that filters the adjacent data using your input." +
                                "\nThis box searches for the order's ID, which is a unique number, with one given to every customer.");
                btnHelp.Enabled = true;
                help = false;
            }
        }

        private void txtBoxSearchOrderCustID_Click(object sender, EventArgs e)
        {
            if (help == true)
            {
                MessageBox.Show("Text box that filters the adjacent data using your input." +
                                "\nThis box searches for the ID of the customer making the order (find it in the Customer window),\n which is a unique number, with one given to every customer.");
                btnHelp.Enabled = true;
                help = false;
            }
        }
    }
}
