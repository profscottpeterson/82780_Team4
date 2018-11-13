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


        public DataView orderView;


        

        public OrdersMain()
        {
            InitializeComponent();
        }

        private void btnOrdersReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrdersExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            OrdersSearch OrdSearch = new OrdersSearch();
            OrdSearch.ShowDialog();
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            OrdersAdd OrdAdd = new OrdersAdd();
            OrdAdd.ShowDialog();
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            OrdersDelete OrdDelete = new OrdersDelete();
            OrdDelete.ShowDialog();
        }


        private void OrdersMain_Load(object sender, EventArgs e)
        {
            //Resetting search box for Refresh button
            txtBoxSearchOrderID.Text = "";
            txtBoxSearchOrderCustID.Text = "";
            txtBoxSearchOrderDate.Text = "";

            //Creating List to hold all order objects.
            List<Orders> allOrders = new List<Orders>();

            //Get all orders from the database.
            allOrders = OrdersSQL.LoadOrders();

            DataTable ordersTable = new DataTable();

            ordersTable.Columns.Add("ID");
            ordersTable.Columns.Add("Customer ID");
            ordersTable.Columns.Add("Date");

            foreach (var orders in allOrders)
            {
                ordersTable.Rows.Add(orders.OrderID, orders.CustID, orders.Date);
            }

            orderView = new DataView(ordersTable);

            dataGridOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridOrder.DataSource = orderView;

            dataGridOrder.ReadOnly = true;

            dataGridOrder.AllowUserToAddRows = false;
        }

        private void txtBoxSearchOrder_TextChanged(object sender, EventArgs e)
        {
            dataSearch();
        }

        private void dataSearch()
        {
            //Filtering the DataView with the text we have from the Inventory TextBox.
            orderView.RowFilter = string.Format("ID like '%{0}%' AND [Customer ID] like '%{1}%' AND Date like '%{2}%'", txtBoxSearchOrderID.Text, txtBoxSearchOrderCustID.Text, txtBoxSearchOrderDate.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridOrder.DataSource = orderView;
        }
    }
}
