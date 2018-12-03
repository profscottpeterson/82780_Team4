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
    public partial class OrderItemMain : Form
    {
        public DataView orderItemView;
        public OrderItemMain()
        {
            InitializeComponent();
        }

        private void btnOrderItemReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderItemMain_Load(object sender, EventArgs e)
        {
            //Creating List to hold all customer objects.
            List<OrderItem> allOrderItems = new List<OrderItem>();
            
            //Get all customers from the database.
            allOrderItems = OrderItemSQL.LoadOrderItems();

            //Creating DataTable object to present the Customer Table from the database.
            DataTable orderItemTable = new DataTable();

            //Adding the Rows that we are going to display.
            orderItemTable.Columns.Add("Order ID");
            orderItemTable.Columns.Add("Inventory ID");

            //Adding object from the allCustomers list as row in our Data Table.
            foreach (var orderItem in allOrderItems)
            {
                orderItemTable.Rows.Add(orderItem.orderId, orderItem.invId);
            }

            //Filling our Data Table in a DataView so we can give it to our DataGrid.
            orderItemView = new DataView(orderItemTable);

            //Dynamically adjust the width of the DataGrid depending on how many columns we have.
            dataGridOrderItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Adding the DataView with our Customers to the DataGrid
            dataGridOrderItem.DataSource = orderItemView;

            //Making the DataGrid read only.
            dataGridOrderItem.ReadOnly = true;

            //Removing the option for users to add directly into the database.
            dataGridOrderItem.AllowUserToAddRows = false;
        }

        private void btnOrderItemSearch_Click(object sender, EventArgs e)
        {
            OrderItemSearch ordItemSearch = new OrderItemSearch();
            ordItemSearch.ShowDialog();
        }

        private void btnOrderItemAdd_Click(object sender, EventArgs e)
        {
            OrderItemAdd ordItemAdd = new OrderItemAdd();
            ordItemAdd.ShowDialog();
        }

        private void btnOrderItemDelete_Click(object sender, EventArgs e)
        {
            OrderItemDelete ordItemDelete = new OrderItemDelete();
            ordItemDelete.ShowDialog();
        }
    }
}
