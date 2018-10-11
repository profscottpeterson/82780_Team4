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
            cbxAddressNullCustomerAdd.Checked = false;
            cbxFNameNullCustomerAdd.Enabled = false;
            cbxLNameNullCustomerAdd.Enabled = false;
            cbxAddressNullCustomerAdd.Enabled = false;
            txtFNameCustomerAdd.Text = "";
            txtLNameCustomerAdd.Text = "";
            txtAddressCustomerAdd.Text = "";
            txtFNameCustomerAdd.Enabled = false;
            txtLNameCustomerAdd.Enabled = false;
            txtAddressCustomerAdd.Enabled = false;
            cbxFNameOnCustomerAdd.Checked = false;
            cbxLNameOnCustomerAdd.Checked = false;
            cbxAddressOnCustomerAdd.Checked = false;
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

        private void cbxAddressOnCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddressOnCustomerAdd.Checked)
            {
                txtAddressCustomerAdd.Enabled = true;
                cbxAddressNullCustomerAdd.Enabled = true;
            }
            else
            {
                cbxAddressNullCustomerAdd.Checked = false;
                txtAddressCustomerAdd.Enabled = false;
                cbxAddressNullCustomerAdd.Enabled = false;
                txtAddressCustomerAdd.Text = "";
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

        private void cbxAddressNullCustomerAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddressNullCustomerAdd.Checked)
            {
                txtAddressCustomerAdd.Text = "<NULL>";
                txtAddressCustomerAdd.Enabled = false;
            }
            else
            {
                txtAddressCustomerAdd.Text = "";
                txtAddressCustomerAdd.Enabled = true;
            }
        }
    }
}
