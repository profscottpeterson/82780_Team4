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
            cbxAddressNullCustomerDelete.Checked = false;
            cbxIDNullCustomerDelete.Checked = false;
            cbxFNameNullCustomerDelete.Enabled = false;
            cbxLNameNullCustomerDelete.Enabled = false;
            cbxAddressNullCustomerDelete.Enabled = false;
            cbxIDNullCustomerDelete.Enabled = false;
            txtFNameCustomerDelete.Text = "";
            txtLNameCustomerDelete.Text = "";
            txtAddressCustomerDelete.Text = "";
            txtIDCustomerDelete.Text = "";
            txtFNameCustomerDelete.Enabled = false;
            txtLNameCustomerDelete.Enabled = false;
            txtAddressCustomerDelete.Enabled = false;
            txtIDCustomerDelete.Enabled = false;
            cbxFNameOnCustomerDelete.Checked = false;
            cbxLNameOnCustomerDelete.Checked = false;
            cbxAddressOnCustomerDelete.Checked = false;
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

        private void cbxAddressOnCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddressOnCustomerDelete.Checked)
            {
                txtAddressCustomerDelete.Enabled = true;
                cbxAddressNullCustomerDelete.Enabled = true;
            }
            else
            {
                cbxAddressNullCustomerDelete.Checked = false;
                txtAddressCustomerDelete.Enabled = false;
                cbxAddressNullCustomerDelete.Enabled = false;
                txtAddressCustomerDelete.Text = "";
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

        private void cbxAddressNullCustomerDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddressNullCustomerDelete.Checked)
            {
                txtAddressCustomerDelete.Text = "<NULL>";
                txtAddressCustomerDelete.Enabled = false;
            }
            else
            {
                txtAddressCustomerDelete.Text = "";
                txtAddressCustomerDelete.Enabled = true;
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
    }
}
