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
    public partial class CustomerSearch : Form
    {
        public DataView customerView;
        public CustomerSearch()
        {
            InitializeComponent();
        }
        private void cbxFNameOnCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFNameOnCustomerSearch.Checked)
            {
                txtFNameCustomerSearch.Enabled = true;
                cbxFNameNullCustomerSearch.Enabled = true;
            }
            else
            {
                cbxFNameNullCustomerSearch.Checked = false;
                txtFNameCustomerSearch.Enabled = false;
                cbxFNameNullCustomerSearch.Enabled = false;
                txtFNameCustomerSearch.Text = "";
            }
        }

        private void cbxLNameOnCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLNameOnCustomerSearch.Checked)
            {
                txtLNameCustomerSearch.Enabled = true;
                cbxLNameNullCustomerSearch.Enabled = true;
            }
            else
            {
                cbxLNameNullCustomerSearch.Checked = false;
                txtLNameCustomerSearch.Enabled = false;
                cbxLNameNullCustomerSearch.Enabled = false;
                txtLNameCustomerSearch.Text = "";
            }
        }

        private void cbxEMailOnCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEMailOnCustomerSearch.Checked)
            {
                txtEMailCustomerSearch.Enabled = true;
                cbxEMailNullCustomerSearch.Enabled = true;
            }
            else
            {
                cbxEMailNullCustomerSearch.Checked = false;
                txtEMailCustomerSearch.Enabled = false;
                cbxEMailNullCustomerSearch.Enabled = false;
                txtEMailCustomerSearch.Text = "";
            }
        }

        private void cbxIDOnCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDOnCustomerSearch.Checked)
            {
                txtIDCustomerSearch.Enabled = true;
                cbxIDNullCustomerSearch.Enabled = true;
            }
            else
            {
                cbxIDNullCustomerSearch.Checked = false;
                txtIDCustomerSearch.Enabled = false;
                cbxIDNullCustomerSearch.Enabled = false;
                txtIDCustomerSearch.Text = "";
            }
        }

        private void cbxFNameNullCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFNameNullCustomerSearch.Checked)
            {
                txtFNameCustomerSearch.Text = "<NULL>";
                txtFNameCustomerSearch.Enabled = false;
            }
            else
            {
                txtFNameCustomerSearch.Text = "";
                txtFNameCustomerSearch.Enabled = true;
            }
        }

        private void cbxLNameNullCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLNameNullCustomerSearch.Checked)
            {
                txtLNameCustomerSearch.Text = "<NULL>";
                txtLNameCustomerSearch.Enabled = false;
            }
            else
            {
                txtLNameCustomerSearch.Text = "";
                txtLNameCustomerSearch.Enabled = true;
            }
        }

        private void cbxEMailNullCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEMailNullCustomerSearch.Checked)
            {
                txtEMailCustomerSearch.Text = "<NULL>";
                txtEMailCustomerSearch.Enabled = false;
            }
            else
            {
                txtEMailCustomerSearch.Text = "";
                txtEMailCustomerSearch.Enabled = true;
            }
        }

        private void cbxIDNullCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDNullCustomerSearch.Checked)
            {
                txtIDCustomerSearch.Text = "<NULL>";
                txtIDCustomerSearch.Enabled = false;
            }
            else
            {
                txtIDCustomerSearch.Text = "";
                txtIDCustomerSearch.Enabled = true;
            }
        }

        private void btnResetCustomerSearch_Click(object sender, EventArgs e)
        {
            cbxFNameNullCustomerSearch.Checked = false;
            cbxLNameNullCustomerSearch.Checked = false;
            cbxEMailNullCustomerSearch.Checked = false;
            cbxIDNullCustomerSearch.Checked = false;
            cbxFNameNullCustomerSearch.Enabled = false;
            cbxLNameNullCustomerSearch.Enabled = false;
            cbxEMailNullCustomerSearch.Enabled = false;
            cbxIDNullCustomerSearch.Enabled = false;
            txtFNameCustomerSearch.Text = "";
            txtLNameCustomerSearch.Text = "";
            txtEMailCustomerSearch.Text = "";
            txtIDCustomerSearch.Text = "";
            txtFNameCustomerSearch.Enabled = false;
            txtLNameCustomerSearch.Enabled = false;
            txtEMailCustomerSearch.Enabled = false;
            txtIDCustomerSearch.Enabled = false;
            cbxFNameOnCustomerSearch.Checked = false;
            cbxLNameOnCustomerSearch.Checked = false;
            cbxEMailOnCustomerSearch.Checked = false;
            cbxIDOnCustomerSearch.Checked = false;
        }

        private void btnReturnCustomerSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitCustomerSearch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerSearchGo_Click(object sender, EventArgs e)
        {

            /*
            Boolean fNameCheck = false;
            Boolean lNameCheck = false;
            Boolean emailCheck = false;
            Boolean idCheck = false;
            string fName = "";
            string lName = "";
            string email = "";
            string id = "";
            string query = "select * from Customer where ";
            Validation val = new Validation();

            if (cbxFNameOnCustomerSearch.Checked == true)
            {
                fName = val.stringValidate(txtFNameCustomerSearch.Text);
                fNameCheck = true;
            }

            if (cbxLNameOnCustomerSearch.Checked == true)
            {
                lName = val.stringValidate(txtLNameCustomerSearch.Text);
                lNameCheck = true;
            }

            if (cbxEMailOnCustomerSearch.Checked == true)
            {
                email = val.emailValidate(txtEMailCustomerSearch.Text);
                emailCheck = true;
            }

            if (cbxIDOnCustomerSearch.Checked == true)
            {
                id = val.numValidate(txtIDCustomerSearch.Text);
                idCheck = true;
            }

            if (fName != "[Error]" && lName != "[Error]" && email != "[Error]" && id != "[Error]")
            {
                if (fNameCheck == true)
                {
                    query += "FirstName = ";

                    if (fName == "NULL")
                    {
                        query += fName;
                    }
                    else
                    {
                        query += "'" + fName + "'";
                    }
                }

                if (lNameCheck == true)
                {
                    if (fNameCheck == true)
                    {
                        query += " AND ";
                    }

                    query += "LastName = ";

                    if (lName == "NULL")
                    {
                        query += lName;
                    }
                    else
                    {
                        query += "'" + lName + "'";
                    }
                }

                if (emailCheck == true)
                {
                    if (lNameCheck == true || fNameCheck == true)
                    {
                        query += " AND ";
                    }

                    query += "Email = ";
                    if (email == "NULL")
                    {
                        query += email;
                    }
                    else
                    {
                        query += "'" + email + "'";
                    }
                }

                if (idCheck == true)
                {
                    if (fNameCheck == true || lNameCheck == true || emailCheck == true)
                    {
                        query += " AND ";
                    }

                    query += "CustID = " + id;
                }

                MessageBox.Show(query);
            }
            else
            {
                MessageBox.Show("There was an error with your inputs, please double check all inputs.");
            }
            */
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
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
            dataGridCustomerSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Adding the DataView with our Customers to the DataGrid
            dataGridCustomerSearch.DataSource = customerView;
            //Making the DataGrid read only.
            dataGridCustomerSearch.ReadOnly = true;
            //Removing the option for users to add directly into the database.
            dataGridCustomerSearch.AllowUserToAddRows = false;
        }

        private void txtFNameCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            //Filtering the DataView with the text we have from the Customer TextBox.
            customerView.RowFilter = string.Format("FirstName like '%{0}%'", txtFNameCustomerSearch.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridCustomerSearch.DataSource = customerView;
        }

        private void txtLNameCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            //Filtering the DataView with the text we have from the Customer TextBox.
            customerView.RowFilter = string.Format("LastName like '%{0}%'", txtLNameCustomerSearch.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridCustomerSearch.DataSource = customerView;
        }

        private void txtEMailCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            //Filtering the DataView with the text we have from the Customer TextBox.
            customerView.RowFilter = string.Format("Email like '%{0}%'", txtEMailCustomerSearch.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridCustomerSearch.DataSource = customerView;
        }

        private void txtIDCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            //Filtering the DataView with the text we have from the Customer TextBox.
            customerView.RowFilter = string.Format("ID like '%{0}%'", txtIDCustomerSearch.Text);
            //Adjusting the DataGrid with the filtered data.
            dataGridCustomerSearch.DataSource = customerView;
        }
    }
}
