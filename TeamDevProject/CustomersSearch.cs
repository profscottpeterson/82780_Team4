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

        private void cbxAddressOnCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddressOnCustomerSearch.Checked)
            {
                txtAddressCustomerSearch.Enabled = true;
                cbxAddressNullCustomerSearch.Enabled = true;
            }
            else
            {
                cbxAddressNullCustomerSearch.Checked = false;
                txtAddressCustomerSearch.Enabled = false;
                cbxAddressNullCustomerSearch.Enabled = false;
                txtAddressCustomerSearch.Text = "";
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

        private void cbxAddressNullCustomerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddressNullCustomerSearch.Checked)
            {
                txtAddressCustomerSearch.Text = "<NULL>";
                txtAddressCustomerSearch.Enabled = false;
            }
            else
            {
                txtAddressCustomerSearch.Text = "";
                txtAddressCustomerSearch.Enabled = true;
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
            cbxAddressNullCustomerSearch.Checked = false;
            cbxIDNullCustomerSearch.Checked = false;
            cbxFNameNullCustomerSearch.Enabled = false;
            cbxLNameNullCustomerSearch.Enabled = false;
            cbxAddressNullCustomerSearch.Enabled = false;
            cbxIDNullCustomerSearch.Enabled = false;
            txtFNameCustomerSearch.Text = "";
            txtLNameCustomerSearch.Text = "";
            txtAddressCustomerSearch.Text = "";
            txtIDCustomerSearch.Text = "";
            txtFNameCustomerSearch.Enabled = false;
            txtLNameCustomerSearch.Enabled = false;
            txtAddressCustomerSearch.Enabled = false;
            txtIDCustomerSearch.Enabled = false;
            cbxFNameOnCustomerSearch.Checked = false;
            cbxLNameOnCustomerSearch.Checked = false;
            cbxAddressOnCustomerSearch.Checked = false;
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
    }
}
