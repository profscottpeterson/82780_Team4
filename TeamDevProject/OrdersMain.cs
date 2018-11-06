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
        private DataView ordersView;
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
            //Creating List to hold all order objects.
            List<Orders> allOrders = new List<Orders>();
            //Get all orders from the database.
            allOrders = OrdersSQL.LoadOrders();

            //Creating DataTable object to present the Orders Table from the database.
            DataTable ordersTable = new DataTable();
            //Adding the Rows that we are going to display.
            ordersTable.Columns.Add("CustID");
            ordersTable.Columns.Add("OrderID");
            ordersTable.Columns.Add("Date");

            //Adding object from the allOrders list as row in our Data Table.
            foreach (var item in allOrders)
            {
                ordersTable.Rows.Add(item.CustID, item.OrderID, item.Date);
            }
            //Filling our Data Table in a DataView so we can give it to our DataGrid.
            ordersView = new DataView(ordersTable);
            //Dynamically adjust the width of the DataGrid depending on how many columns we have.
            dataGridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Adding the DataView with our Orders to the DataGrid
            dataGridOrders.DataSource = ordersView;
            //Making the DataGrid read only.
            dataGridOrders.ReadOnly = true;
            //Removing the option for users to add directly into the database.
            dataGridOrders.AllowUserToAddRows = false;
        }

        private void txtBoxSearchOrders_TextChanged(object sender, EventArgs e)
        {
            //Filtering the DataView with the text we have from the Orders TextBox.
            ordersView.RowFilter = string.Format("OrderID like '%{0}%'", txtBoxSearchOrders.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridOrders.DataSource = ordersView;
        }
    }
}
