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
            List<Customer> allCustomers = new List<Customer>();
            allCustomers = CustomerSQL.LoadCustomers();

            DataTable customersTable = new DataTable();
            customersTable.Columns.Add("ID");
            customersTable.Columns.Add("FirstName");
            customersTable.Columns.Add("LastName");
            customersTable.Columns.Add("Email");
            foreach (var customer in allCustomers)
            {
                customersTable.Rows.Add(customer.CustID, customer.FirstName, customer.LastName, customer.Email);
            }
            customerView = new DataView(customersTable);
            dataGridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCustomer.DataSource = customerView;
            dataGridCustomer.ReadOnly = true;
            dataGridCustomer.AllowUserToAddRows = false;
        }

        private void txtBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            customerView.RowFilter = string.Format("FirstName like '%{0}%'", txtBoxSearchCustomer.Text);
            dataGridCustomer.DataSource = customerView;
        }
    }
}
