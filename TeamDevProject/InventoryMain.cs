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

namespace TeamDevProject
{
    public partial class InventoryMain : Form
    {
        private DataView inventoryView;

        public InventoryMain()
        {
            InitializeComponent();
        }

        private void btnInventorySearch_Click(object sender, EventArgs e)
        {
            InventorySearch InvSearch = new InventorySearch();
            InvSearch.ShowDialog();
        }

        private void btnInventoryAdd_Click(object sender, EventArgs e)
        {
            InventoryAdd InvAdd = new InventoryAdd();
            InvAdd.ShowDialog();
        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            InventoryDelete InvDelete = new InventoryDelete();
            InvDelete.ShowDialog();
        }

        private void btnInventoryReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventoryExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InventoryMain_Load(object sender, EventArgs e)
        {
            //Creating List to hold all customer objects.
            List<Inventory> allInventory = new List<Inventory>();
            //Get all customers from the database.
            allInventory = InventorySQL.LoadInventory();

            //Creating DataTable object to present the Customer Table from the database.
            DataTable inventoryTable = new DataTable();
            //Adding the Rows that we are going to display.
            inventoryTable.Columns.Add("InvID");
            inventoryTable.Columns.Add("ItemName");
            inventoryTable.Columns.Add("Price");
       
            //Adding object from the allCustomers list as row in our Data Table.
            foreach (var item in allInventory)
            {
                inventoryTable.Rows.Add(item.InvID, item.ItemName, item.Price);
            }
            //Filling our Data Table in a DataViewe so we can give it to our DataGrid.
            inventoryView = new DataView(inventoryTable);
            //Dynamicly adjust the width of the DataGrid depending on how many columns we have.
            dataGridInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Adding the DataView with our Customers to the DataGrid
            dataGridInventory.DataSource = inventoryView;
            //Making the DataGrid read only.
            dataGridInventory.ReadOnly = true;
            //Removing the option for users to add directly into the database.
            dataGridInventory.AllowUserToAddRows = false;
        }

        private void txtBoxSearchInventory_TextChanged(object sender, EventArgs e)
        {
            //Filtering the DataView with the text we have from the Customer TextBox.
            inventoryView.RowFilter = string.Format("ItemName like '%{0}%'", txtBoxSearchInventory.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridInventory.DataSource = inventoryView;
        }

     
    }
}
