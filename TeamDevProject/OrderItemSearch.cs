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
    public partial class OrderItemSearch : Form
    {
        private DataView orderItemView;

        //Creating List to hold all inventory objects.
        List<Inventory> allInventory = new List<Inventory>();

        //Creating List to hold all customer objects.
        List<OrderItem> allOrderItems = new List<OrderItem>();

        public OrderItemSearch()
        {
            InitializeComponent();
        }

        private void OrderItemSearch_Load(object sender, EventArgs e)
        {
            //Get all items from the inventory table.
            allInventory = InventorySQL.LoadInventory();

            //Get all customers from the database.
            allOrderItems = OrderItemSQL.LoadOrderItems();

            //Creating DataTable object to present the OrderItem Table from the database.
            DataTable orderItemTable = new DataTable();

            //Adding the Rows that we are going to display.
            orderItemTable.Columns.Add("InvID");
            orderItemTable.Columns.Add("ItemName");
            orderItemTable.Columns.Add("Price");

            //Adding object from the allInventory list as row in our Data Table.
            foreach (var item in allInventory)
            {
                orderItemTable.Rows.Add(item.InvID, item.ItemName, item.Price);
            }

            //Filling our Data Table in a DataView so we can give it to our DataGrid.
            orderItemView = new DataView(orderItemTable);

            //Dynamically adjust the width of the DataGrid depending on how many columns we have.
            dataGridOrderItemSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Adding the DataView with our Inventory to the DataGrid
            dataGridOrderItemSearch.DataSource = orderItemView;

            //Making the DataGrid read only.
            dataGridOrderItemSearch.ReadOnly = true;

            //Removing the option for users to add directly into the database.
            dataGridOrderItemSearch.AllowUserToAddRows = false;
        }

        private void btnOrderItemReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataSearch()
        {
            List<int> itemIDs = new List<int>();
            try
            {
                int orderID = Convert.ToInt32(txtBoxSearchOrderItemID.Text);

                foreach (var order in allOrderItems)
                {
                    if (orderID == order.orderId)
                    {
                        itemIDs.Add(order.invId);
                    }
                }

                List<Inventory> searchInventory = new List<Inventory>();

                foreach (var item in allInventory)
                {
                    if (itemIDs.IndexOf(item.InvID) != -1)
                    {
                        searchInventory.Add(item);
                    }
                }

                //Creating DataTable object to present the OrderItem Table from the database.
                DataTable orderItemTable = new DataTable();

                //Adding the Rows that we are going to display.
                orderItemTable.Columns.Add("InvID");
                orderItemTable.Columns.Add("ItemName");
                orderItemTable.Columns.Add("Price");

                //Adding object from the allInventory list as row in our Data Table.
                foreach (var item in searchInventory)
                {
                    orderItemTable.Rows.Add(item.InvID, item.ItemName, item.Price);
                }

                //Filling our Data Table in a DataView so we can give it to our DataGrid.
                orderItemView = new DataView(orderItemTable);

                //Dynamically adjust the width of the DataGrid depending on how many columns we have.
                dataGridOrderItemSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //Adding the DataView with our Inventory to the DataGrid
                dataGridOrderItemSearch.DataSource = orderItemView;

                //Making the DataGrid read only.
                dataGridOrderItemSearch.ReadOnly = true;

                //Removing the option for users to add directly into the database.
                dataGridOrderItemSearch.AllowUserToAddRows = false;
            } catch
            {
                MessageBox.Show("Please make sure you've input a number.");
            }
        }

        private void btnOrderItemGo_Click(object sender, EventArgs e)
        {
            dataSearch();
        }
    }
}
