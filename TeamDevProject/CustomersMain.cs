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
    public partial class CustomersMain : Form
    {
        public DataView customerView;
        public CustomersMain()
        {
            InitializeComponent();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            CustomerSearch CustSearch = new CustomerSearch();
            CustSearch.ShowDialog();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            CustomersAdd CustAdd = new CustomersAdd();
            CustAdd.ShowDialog();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            CustomersDelete CustDelete = new CustomersDelete();
            CustDelete.ShowDialog();
        }

        private void btnCustomerReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomerExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomersMain_Load(object sender, EventArgs e)
        {
            //Creating List to hold all customer objects.
            List<Customer> allCustomers = new List<Customer>();
            //Get all customers from the database.
            allCustomers = CustomerSQL.LoadCustomers();

            //Creating DataTable object to present the Customer Table from the database.
            DataTable customersTable = new DataTable();
            //Adding the Rows that we are going to display.
            customersTable.Columns.Add("ID");
            customersTable.Columns.Add("FirstName");
            customersTable.Columns.Add("LastName");
            customersTable.Columns.Add("Email");
            //Adding object from the allCustomers list as row in our Data Table.
            foreach (var customer in allCustomers)
            {
                customersTable.Rows.Add(customer.CustID, customer.FirstName, customer.LastName, customer.Email);
            }
            //Filling our Data Table in a DataViewe so we can give it to our DataGrid.
            customerView = new DataView(customersTable);
            //Dynamicly adjust the width of the DataGrid depending on how many columns we have.
            dataGridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Adding the DataView with our Customers to the DataGrid
            dataGridCustomer.DataSource = customerView;
            //Making the DataGrid read only.
            dataGridCustomer.ReadOnly = true;
            //Removing the option for users to add directly into the database.
            dataGridCustomer.AllowUserToAddRows = false;
        }

        private void txtBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            //Filtering the DataView with the text we have from the Customer TextBox.
            customerView.RowFilter = string.Format("FirstName like '%{0}%'", txtBoxSearchCustomer.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridCustomer.DataSource = customerView;
        }
    }
}
