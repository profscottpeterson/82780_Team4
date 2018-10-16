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
    public partial class OrdersAdd : Form
    {
        public OrdersAdd()
        {
            InitializeComponent();
        }
        private void btnResetOrdersAdd_Click(object sender, EventArgs e)
        {
            cbxDateNullOrdersAdd.Checked = false;
            cbxCustIDNullOrdersAdd.Checked = false;
            cbxDateNullOrdersAdd.Enabled = false;
            cbxCustIDNullOrdersAdd.Enabled = false;
            txtDateOrdersAdd.Text = "";
            txtCustIDOrdersAdd.Text = "";
            txtDateOrdersAdd.Enabled = false;
            txtCustIDOrdersAdd.Enabled = false;
            cbxDateOnOrdersAdd.Checked = false;
            cbxCustIDOnOrdersAdd.Checked = false;
        }

        private void btnReturnOrdersAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitOrdersAdd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxCustIDOnOrdersAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustIDOnOrdersAdd.Checked)
            {
                txtCustIDOrdersAdd.Enabled = true;
                cbxCustIDNullOrdersAdd.Enabled = true;
            }
            else
            {
                cbxCustIDNullOrdersAdd.Checked = false;
                txtCustIDOrdersAdd.Enabled = false;
                cbxCustIDNullOrdersAdd.Enabled = false;
                txtCustIDOrdersAdd.Text = "";
            }
        }

        private void cbxIDOnOrdersAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxDateNullOrdersAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDateNullOrdersAdd.Checked)
            {
                txtDateOrdersAdd.Text = "<NULL>";
                txtDateOrdersAdd.Enabled = false;
            }
            else
            {
                txtDateOrdersAdd.Text = "";
                txtDateOrdersAdd.Enabled = true;
            }
        }

        private void cbxCustIDNullOrdersAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustIDNullOrdersAdd.Checked)
            {
                txtCustIDOrdersAdd.Text = "<NULL>";
                txtCustIDOrdersAdd.Enabled = false;
            }
            else
            {
                txtCustIDOrdersAdd.Text = "";
                txtCustIDOrdersAdd.Enabled = true;
            }
        }

        private void cbxDateOnOrdersAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDateOnOrdersAdd.Checked)
            {
                txtDateOrdersAdd.Enabled = true;
                cbxDateNullOrdersAdd.Enabled = true;
            }
            else
            {
                cbxDateNullOrdersAdd.Checked = false;
                txtDateOrdersAdd.Enabled = false;
                cbxDateNullOrdersAdd.Enabled = false;
                txtDateOrdersAdd.Text = "";
            }
        }
    }
}
