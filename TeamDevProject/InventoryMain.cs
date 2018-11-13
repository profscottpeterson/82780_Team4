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
            //Resetting search box for Refresh button
            txtBoxSearchInventoryItemName.Text = "";
            txtBoxSearchInventoryID.Text = "";
            txtBoxSearchInventoryPrice.Text = "";

            //Creating List to hold all inventory objects.
            List<Inventory> allInventory = new List<Inventory>();
            //Get all items from the inventory table.
            allInventory = InventorySQL.LoadInventory();

            //Creating DataTable object to present the Inventory Table from the database.
            DataTable inventoryTable = new DataTable();
            //Adding the Rows that we are going to display.
            inventoryTable.Columns.Add("InvID");
            inventoryTable.Columns.Add("ItemName");
            inventoryTable.Columns.Add("Price");

            //Adding object from the allInventory list as row in our Data Table.
            foreach (var item in allInventory)
            {
                inventoryTable.Rows.Add(item.InvID, item.ItemName, item.Price);
            }
            //Filling our Data Table in a DataView so we can give it to our DataGrid.
            inventoryView = new DataView(inventoryTable);
            //Dynamically adjust the width of the DataGrid depending on how many columns we have.
            dataGridInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Adding the DataView with our Inventory to the DataGrid
            dataGridInventory.DataSource = inventoryView;
            //Making the DataGrid read only.
            dataGridInventory.ReadOnly = true;
            //Removing the option for users to add directly into the database.
            dataGridInventory.AllowUserToAddRows = false;
        }

        private void txtBoxSearchInventory_TextChanged(object sender, EventArgs e)
        {
            dataSearch();
        }

        private void dataSearch()
        {
            //Filtering the DataView with the text we have from the Inventory TextBox.
            inventoryView.RowFilter = string.Format("InvID like '%{0}%' AND ItemName like '%{1}%' AND Price like '%{2}%'", txtBoxSearchInventoryID.Text, txtBoxSearchInventoryItemName.Text, txtBoxSearchInventoryPrice.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridInventory.DataSource = inventoryView;
        }
    }
}
