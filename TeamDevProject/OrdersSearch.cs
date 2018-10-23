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
    public partial class OrdersSearch : Form
    {
        public OrdersSearch()
        {
            InitializeComponent();
        }
        private void cbxDateOnOrdersSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDateOnOrdersSearch.Checked)
            {
                txtDateOrdersSearch.Enabled = true;
                cbxDateNullOrdersSearch.Enabled = true;
            }
            else
            {
                cbxDateNullOrdersSearch.Checked = false;
                txtDateOrdersSearch.Enabled = false;
                cbxDateNullOrdersSearch.Enabled = false;
                txtDateOrdersSearch.Text = "";
            }
        }

        private void cbxCustIDOnOrdersSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustIDOnOrdersSearch.Checked)
            {
                txtCustIDOrdersSearch.Enabled = true;
                cbxCustIDNullOrdersSearch.Enabled = true;
            }
            else
            {
                cbxCustIDNullOrdersSearch.Checked = false;
                txtCustIDOrdersSearch.Enabled = false;
                cbxCustIDNullOrdersSearch.Enabled = false;
                txtCustIDOrdersSearch.Text = "";
            }
        }

        private void cbxIDOnOrdersSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDOnOrdersSearch.Checked)
            {
                txtIDOrdersSearch.Enabled = true;
                cbxIDNullOrdersSearch.Enabled = true;
            }
            else
            {
                cbxIDNullOrdersSearch.Checked = false;
                txtIDOrdersSearch.Enabled = false;
                cbxIDNullOrdersSearch.Enabled = false;
                txtIDOrdersSearch.Text = "";
            }
        }

        private void cbxDateNullOrdersSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDateNullOrdersSearch.Checked)
            {
                txtDateOrdersSearch.Text = "<NULL>";
                txtDateOrdersSearch.Enabled = false;
            }
            else
            {
                txtDateOrdersSearch.Text = "";
                txtDateOrdersSearch.Enabled = true;
            }
        }

        private void cbxCustIDNullOrdersSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustIDNullOrdersSearch.Checked)
            {
                txtCustIDOrdersSearch.Text = "<NULL>";
                txtCustIDOrdersSearch.Enabled = false;
            }
            else
            {
                txtCustIDOrdersSearch.Text = "";
                txtCustIDOrdersSearch.Enabled = true;
            }
        }

        private void cbxIDNullOrdersSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDNullOrdersSearch.Checked)
            {
                txtIDOrdersSearch.Text = "<NULL>";
                txtIDOrdersSearch.Enabled = false;
            }
            else
            {
                txtIDOrdersSearch.Text = "";
                txtIDOrdersSearch.Enabled = true;
            }
        }

        private void btnResetOrdersSearch_Click(object sender, EventArgs e)
        {
            cbxDateNullOrdersSearch.Checked = false;
            cbxCustIDNullOrdersSearch.Checked = false;
            cbxIDNullOrdersSearch.Checked = false;
            cbxDateNullOrdersSearch.Enabled = false;
            cbxCustIDNullOrdersSearch.Enabled = false;
            cbxIDNullOrdersSearch.Enabled = false;
            txtDateOrdersSearch.Text = "";
            txtCustIDOrdersSearch.Text = "";
            txtIDOrdersSearch.Text = "";
            txtDateOrdersSearch.Enabled = false;
            txtCustIDOrdersSearch.Enabled = false;
            txtIDOrdersSearch.Enabled = false;
            cbxDateOnOrdersSearch.Checked = false;
            cbxCustIDOnOrdersSearch.Checked = false;
            cbxIDOnOrdersSearch.Checked = false;
        }

        private void btnReturnOrdersSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitOrdersSearch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrdersSearchGo_Click(object sender, EventArgs e)
        {
            Validation val = new Validation();
            string dateCheck = val.dateValidate(txtDateOrdersSearch.Text);
            MessageBox.Show(dateCheck);
        }
    }
}
