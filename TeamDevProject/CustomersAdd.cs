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
    public partial class CustomersAdd : Form
    {
        public CustomersAdd()
        {
            InitializeComponent();
        }

        private void btnResetCustomerAdd_Click(object sender, EventArgs e)
        {
            cbxFNameNullCustomerAdd.Checked = false;
            cbxLNameNullCustomerAdd.Checked = false;
            cbxEMailNullCustomerAdd.Checked = false;
            cbxFNameNullCustomerAdd.Enabled = false;
            cbxLNameNullCustomerAdd.Enabled = false;
            cbxEMailNullCustomerAdd.Enabled = false;
            txtFNameCustomerAdd.Text = "";
            txtLNameCustomerAdd.Text = "";
            txtEMailCustomerAdd.Text = "";
            txtFNameCustomerAdd.Enabled = false;
            txtLNameCustomerAdd.Enabled = false;
            txtEMailCustomerAdd.Enabled = false;
            cbxFNameOnCustomerAdd.Checked = false;
            cbxLNameOnCustomerAdd.Checked = false;
            cbxEMailOnCustomerAdd.Checked = false;
        }

        private void btnReturnCustomerAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitCustomerAdd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxFNameOnCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFNameOnCustomerAdd.Checked)
            {
                txtFNameCustomerAdd.Enabled = true;
                cbxFNameNullCustomerAdd.Enabled = true;
            }
            else
            {
                cbxFNameNullCustomerAdd.Checked = false;
                txtFNameCustomerAdd.Enabled = false;
                cbxFNameNullCustomerAdd.Enabled = false;
                txtFNameCustomerAdd.Text = "";
            }
        }

        private void cbxLNameOnCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLNameOnCustomerAdd.Checked)
            {
                txtLNameCustomerAdd.Enabled = true;
                cbxLNameNullCustomerAdd.Enabled = true;
            }
            else
            {
                cbxLNameNullCustomerAdd.Checked = false;
                txtLNameCustomerAdd.Enabled = false;
                cbxLNameNullCustomerAdd.Enabled = false;
                txtLNameCustomerAdd.Text = "";
            }
        }

        private void cbxEMailOnCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEMailOnCustomerAdd.Checked)
            {
                txtEMailCustomerAdd.Enabled = true;
                cbxEMailNullCustomerAdd.Enabled = true;
            }
            else
            {
                cbxEMailNullCustomerAdd.Checked = false;
                txtEMailCustomerAdd.Enabled = false;
                cbxEMailNullCustomerAdd.Enabled = false;
                txtEMailCustomerAdd.Text = "";
            }
        }

        private void cbxIDOnCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxFNameNullCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFNameNullCustomerAdd.Checked)
            {
                txtFNameCustomerAdd.Text = "<NULL>";
                txtFNameCustomerAdd.Enabled = false;
            }
            else
            {
                txtFNameCustomerAdd.Text = "";
                txtFNameCustomerAdd.Enabled = true;
            }
        }

        private void cbxLNameNullCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLNameNullCustomerAdd.Checked)
            {
                txtLNameCustomerAdd.Text = "<NULL>";
                txtLNameCustomerAdd.Enabled = false;
            }
            else
            {
                txtLNameCustomerAdd.Text = "";
                txtLNameCustomerAdd.Enabled = true;
            }
        }

        private void cbxEMailNullCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEMailNullCustomerAdd.Checked)
            {
                txtEMailCustomerAdd.Text = "<NULL>";
                txtEMailCustomerAdd.Enabled = false;
            }
            else
            {
                txtEMailCustomerAdd.Text = "";
                txtEMailCustomerAdd.Enabled = true;
            }
        }

        private void btnCustomerAddGo_Click(object sender, EventArgs e)
        {
            Boolean fNameCheck = false;
            Boolean lNameCheck = false;
            Boolean emailCheck = false;
            string fName = "";
            string lName = "";
            string email = "";
            string query = "insert into Customer (";
            Validation val = new Validation();

            if (cbxFNameOnCustomerAdd.Checked == true)
            {
                fName = val.stringValidate(txtFNameCustomerAdd.Text);
                fNameCheck = true;
            }

            if (cbxLNameOnCustomerAdd.Checked == true)
            {
                lName = val.stringValidate(txtLNameCustomerAdd.Text);
                lNameCheck = true;
            }

            if (cbxEMailOnCustomerAdd.Checked == true)
            {
                email = val.emailValidate(txtEMailCustomerAdd.Text);
                emailCheck = true;
            }

            if (fName != "[Error]" && lName != "[Error]" && email != "[Error]")
            {
                if (fNameCheck == true)
                {
                    query += "FirstName";
                }

                if (lNameCheck == true)
                {
                    if (fNameCheck == true)
                    {
                        query += ", ";
                    }

                    query += "LastName";
                }

                if (emailCheck == true)
                {
                    if (lNameCheck == true || fNameCheck == true)
                    {
                        query += ", ";
                    }

                    query += "Email";
                }

                query += ") Values (";

                if (fNameCheck == true)
                {
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
                        query += ", ";
                    }

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
                    if (fNameCheck == true || lNameCheck == true)
                    {
                        query += ", ";
                    }

                    if (email == "NULL")
                    {
                        query += email;
                    }
                    else
                    {
                        query += "'" + email + "'";
                    }
                }

                query += ");";
                MessageBox.Show(query);
            }
            else
            {
                MessageBox.Show("There was an error with your inputs, please double check all inputs.");
            }
        }
    }
}
