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
    public partial class OrdersDelete : Form
    {
        public OrdersDelete()
        {
            InitializeComponent();
        }

        private void btnResetOrdersDelete_Click(object sender, EventArgs e)
        {
            cbxDateNullOrdersDelete.Checked = false;
            cbxCustIDNullOrdersDelete.Checked = false;
            cbxIDNullOrdersDelete.Checked = false;
            cbxDateNullOrdersDelete.Enabled = false;
            cbxCustIDNullOrdersDelete.Enabled = false;
            cbxIDNullOrdersDelete.Enabled = false;
            txtDateOrdersDelete.Text = "";
            txtCustIDOrdersDelete.Text = "";
            txtIDOrdersDelete.Text = "";
            txtDateOrdersDelete.Enabled = false;
            txtCustIDOrdersDelete.Enabled = false;
            txtIDOrdersDelete.Enabled = false;
            cbxDateOnOrdersDelete.Checked = false;
            cbxCustIDOnOrdersDelete.Checked = false;
            cbxIDOnOrdersDelete.Checked = false;
        }

        private void btnReturnOrdersDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitOrdersDelete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxDateOnOrdersDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDateOnOrdersDelete.Checked)
            {
                txtDateOrdersDelete.Enabled = true;
                cbxDateNullOrdersDelete.Enabled = true;
            }
            else
            {
                cbxDateNullOrdersDelete.Checked = false;
                txtDateOrdersDelete.Enabled = false;
                cbxDateNullOrdersDelete.Enabled = false;
                txtDateOrdersDelete.Text = "";
            }
        }

        private void cbxCustIDOnOrdersDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustIDOnOrdersDelete.Checked)
            {
                txtCustIDOrdersDelete.Enabled = true;
                cbxCustIDNullOrdersDelete.Enabled = true;
            }
            else
            {
                cbxCustIDNullOrdersDelete.Checked = false;
                txtCustIDOrdersDelete.Enabled = false;
                cbxCustIDNullOrdersDelete.Enabled = false;
                txtCustIDOrdersDelete.Text = "";
            }
        }

        private void cbxIDOnOrdersDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDOnOrdersDelete.Checked)
            {
                txtIDOrdersDelete.Enabled = true;
                cbxIDNullOrdersDelete.Enabled = true;
            }
            else
            {
                cbxIDNullOrdersDelete.Checked = false;
                txtIDOrdersDelete.Enabled = false;
                cbxIDNullOrdersDelete.Enabled = false;
                txtIDOrdersDelete.Text = "";
            }
        }

        private void cbxDateNullOrdersDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDateNullOrdersDelete.Checked)
            {
                txtDateOrdersDelete.Text = "<NULL>";
                txtDateOrdersDelete.Enabled = false;
            }
            else
            {
                txtDateOrdersDelete.Text = "";
                txtDateOrdersDelete.Enabled = true;
            }
        }

        private void cbxCustIDNullOrdersDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustIDNullOrdersDelete.Checked)
            {
                txtCustIDOrdersDelete.Text = "<NULL>";
                txtCustIDOrdersDelete.Enabled = false;
            }
            else
            {
                txtCustIDOrdersDelete.Text = "";
                txtCustIDOrdersDelete.Enabled = true;
            }
        }

        private void cbxIDNullOrdersDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDNullOrdersDelete.Checked)
            {
                txtIDOrdersDelete.Text = "<NULL>";
                txtIDOrdersDelete.Enabled = false;
            }
            else
            {
                txtIDOrdersDelete.Text = "";
                txtIDOrdersDelete.Enabled = true;
            }
        }
    }
}
