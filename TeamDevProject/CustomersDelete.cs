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
    public partial class CustomersDelete : Form
    {
        public CustomersDelete()
        {
            InitializeComponent();
        }

        private void btnResetCustomerDelete_Click(object sender, EventArgs e)
        {
            cbxFNameNullCustomerDelete.Checked = false;
            cbxLNameNullCustomerDelete.Checked = false;
            cbxEMailNullCustomerDelete.Checked = false;
            cbxIDNullCustomerDelete.Checked = false;
            cbxFNameNullCustomerDelete.Enabled = false;
            cbxLNameNullCustomerDelete.Enabled = false;
            cbxEMailNullCustomerDelete.Enabled = false;
            cbxIDNullCustomerDelete.Enabled = false;
            txtFNameCustomerDelete.Text = "";
            txtLNameCustomerDelete.Text = "";
            txtEMailCustomerDelete.Text = "";
            txtIDCustomerDelete.Text = "";
            txtFNameCustomerDelete.Enabled = false;
            txtLNameCustomerDelete.Enabled = false;
            txtEMailCustomerDelete.Enabled = false;
            txtIDCustomerDelete.Enabled = false;
            cbxFNameOnCustomerDelete.Checked = false;
            cbxLNameOnCustomerDelete.Checked = false;
            cbxEMailOnCustomerDelete.Checked = false;
            cbxIDOnCustomerDelete.Checked = false;
        }

        private void btnReturnCustomerDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitCustomerDelete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxFNameOnCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFNameOnCustomerDelete.Checked)
            {
                txtFNameCustomerDelete.Enabled = true;
                cbxFNameNullCustomerDelete.Enabled = true;
            }
            else
            {
                cbxFNameNullCustomerDelete.Checked = false;
                txtFNameCustomerDelete.Enabled = false;
                cbxFNameNullCustomerDelete.Enabled = false;
                txtFNameCustomerDelete.Text = "";
            }
        }

        private void cbxLNameOnCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLNameOnCustomerDelete.Checked)
            {
                txtLNameCustomerDelete.Enabled = true;
                cbxLNameNullCustomerDelete.Enabled = true;
            }
            else
            {
                cbxLNameNullCustomerDelete.Checked = false;
                txtLNameCustomerDelete.Enabled = false;
                cbxLNameNullCustomerDelete.Enabled = false;
                txtLNameCustomerDelete.Text = "";
            }
        }

        private void cbxEMailOnCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEMailOnCustomerDelete.Checked)
            {
                txtEMailCustomerDelete.Enabled = true;
                cbxEMailNullCustomerDelete.Enabled = true;
            }
            else
            {
                cbxEMailNullCustomerDelete.Checked = false;
                txtEMailCustomerDelete.Enabled = false;
                cbxEMailNullCustomerDelete.Enabled = false;
                txtEMailCustomerDelete.Text = "";
            }
        }

        private void cbxIDOnCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDOnCustomerDelete.Checked)
            {
                txtIDCustomerDelete.Enabled = true;
                cbxIDNullCustomerDelete.Enabled = true;
            }
            else
            {
                cbxIDNullCustomerDelete.Checked = false;
                txtIDCustomerDelete.Enabled = false;
                cbxIDNullCustomerDelete.Enabled = false;
                txtIDCustomerDelete.Text = "";
            }
        }

        private void cbxFNameNullCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFNameNullCustomerDelete.Checked)
            {
                txtFNameCustomerDelete.Text = "<NULL>";
                txtFNameCustomerDelete.Enabled = false;
            }
            else
            {
                txtFNameCustomerDelete.Text = "";
                txtFNameCustomerDelete.Enabled = true;
            }
        }

        private void cbxLNameNullCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLNameNullCustomerDelete.Checked)
            {
                txtLNameCustomerDelete.Text = "<NULL>";
                txtLNameCustomerDelete.Enabled = false;
            }
            else
            {
                txtLNameCustomerDelete.Text = "";
                txtLNameCustomerDelete.Enabled = true;
            }
        }

        private void cbxIDNullCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDNullCustomerDelete.Checked)
            {
                txtIDCustomerDelete.Text = "<NULL>";
                txtIDCustomerDelete.Enabled = false;
            }
            else
            {
                txtIDCustomerDelete.Text = "";
                txtIDCustomerDelete.Enabled = true;
            }
        }

        private void cbxEMailNullCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEMailNullCustomerDelete.Checked)
            {
                txtEMailCustomerDelete.Text = "<NULL>";
                txtEMailCustomerDelete.Enabled = false;
            }
            else
            {
                txtEMailCustomerDelete.Text = "";
                txtEMailCustomerDelete.Enabled = true;
            }
        }

        private void btnCustomerDeleteGo_Click(object sender, EventArgs e)
        {
            // Create a temporary inventory object.
            Customer cust = new Customer();

            // Assign temp's values based on input.
            if (txtIDCustomerDelete.Text != "")
            {
                cust.CustID = Convert.ToInt32(txtIDCustomerDelete.Text);
            }

            if (txtFNameCustomerDelete.Text != "")
            {
                cust.FirstName = txtFNameCustomerDelete.Text;
            }
            else
            {
                cust.FirstName = null;
            }

            if (txtLNameCustomerDelete.Text != "")
            {
                cust.LastName = txtLNameCustomerDelete.Text;
            }
            else
            {
                cust.LastName = null;
            }

            if (txtEMailCustomerDelete.Text != "")
            {
                cust.Email = txtEMailCustomerDelete.Text;
            }
            else
            {
                cust.Email = null;
            }

            //Call delete method on customer
            CustomerSQL.DeleteCustomer(cust);

            /*
            Boolean fNameCheck = false;
            Boolean lNameCheck = false;
            Boolean emailCheck = false;
            Boolean idCheck = false;
            string fName = "";
            string lName = "";
            string email = "";
            string id = "";
            string query = "delete from Customer where ";
            Validation val = new Validation();

            if (cbxFNameOnCustomerDelete.Checked == true)
            {
                fName = val.stringValidate(txtFNameCustomerDelete.Text);
                fNameCheck = true;
            }

            if (cbxLNameOnCustomerDelete.Checked == true)
            {
                lName = val.stringValidate(txtLNameCustomerDelete.Text);
                lNameCheck = true;
            }

            if (cbxEMailOnCustomerDelete.Checked == true)
            {
                email = val.emailValidate(txtEMailCustomerDelete.Text);
                emailCheck = true;
            }

            if (cbxIDOnCustomerDelete.Checked == true)
            {
                id = val.numValidate(txtIDCustomerDelete.Text);
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
    }
}
