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
    public partial class InventorySearch : Form
    {
        public InventorySearch()
        {
            InitializeComponent();
        }
        private void cbxNameOnInventorySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNameOnInventorySearch.Checked)
            {
                txtNameInventorySearch.Enabled = true;
                cbxNameNullInventorySearch.Enabled = true;
            }
            else
            {
                cbxNameNullInventorySearch.Checked = false;
                txtNameInventorySearch.Enabled = false;
                cbxNameNullInventorySearch.Enabled = false;
                txtNameInventorySearch.Text = "";
            }
        }

        private void cbxPriceOnInventorySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPriceOnInventorySearch.Checked)
            {
                txtPriceInventorySearch.Enabled = true;
                cbxPriceNullInventorySearch.Enabled = true;
            }
            else
            {
                cbxPriceNullInventorySearch.Checked = false;
                txtPriceInventorySearch.Enabled = false;
                cbxPriceNullInventorySearch.Enabled = false;
                txtPriceInventorySearch.Text = "";
            }
        }

        private void cbxIDOnInventorySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDOnInventorySearch.Checked)
            {
                txtIDInventorySearch.Enabled = true;
                cbxIDNullInventorySearch.Enabled = true;
            }
            else
            {
                cbxIDNullInventorySearch.Checked = false;
                txtIDInventorySearch.Enabled = false;
                cbxIDNullInventorySearch.Enabled = false;
                txtIDInventorySearch.Text = "";
            }
        }

        private void cbxNameNullInventorySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNameNullInventorySearch.Checked)
            {
                txtNameInventorySearch.Text = "<NULL>";
                txtNameInventorySearch.Enabled = false;
            }
            else
            {
                txtNameInventorySearch.Text = "";
                txtNameInventorySearch.Enabled = true;
            }
        }

        private void cbxPriceNullInventorySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPriceNullInventorySearch.Checked)
            {
                txtPriceInventorySearch.Text = "<NULL>";
                txtPriceInventorySearch.Enabled = false;
            }
            else
            {
                txtPriceInventorySearch.Text = "";
                txtPriceInventorySearch.Enabled = true;
            }
        }

        private void cbxIDNullInventorySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDNullInventorySearch.Checked)
            {
                txtIDInventorySearch.Text = "<NULL>";
                txtIDInventorySearch.Enabled = false;
            }
            else
            {
                txtIDInventorySearch.Text = "";
                txtIDInventorySearch.Enabled = true;
            }
        }

        private void btnResetInventorySearch_Click(object sender, EventArgs e)
        {
            cbxNameNullInventorySearch.Checked = false;
            cbxPriceNullInventorySearch.Checked = false;
            cbxIDNullInventorySearch.Checked = false;
            cbxNameNullInventorySearch.Enabled = false;
            cbxPriceNullInventorySearch.Enabled = false;
            cbxIDNullInventorySearch.Enabled = false;
            txtNameInventorySearch.Text = "";
            txtPriceInventorySearch.Text = "";
            txtIDInventorySearch.Text = "";
            txtNameInventorySearch.Enabled = false;
            txtPriceInventorySearch.Enabled = false;
            txtIDInventorySearch.Enabled = false;
            cbxNameOnInventorySearch.Checked = false;
            cbxPriceOnInventorySearch.Checked = false;
            cbxIDOnInventorySearch.Checked = false;
        }

        private void btnReturnInventorySearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitInventorySearch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInventorySearchGo_Click(object sender, EventArgs e)
        {
            // Create a string to convert to a double for cost.
            string cost = "";

            // Create a temporary inventory object.
            Inventory temp = new Inventory();

            // Assign temp's values based on user input.
            if (txtIDInventorySearch.Text != "")
            {
                temp.InvID = Convert.ToInt32(txtIDInventorySearch.Text);
            }

            if (txtNameInventorySearch.Text != "")
            {
                temp.ItemName = txtNameInventorySearch.Text;
            }
            else
            {
                temp.ItemName = null;
            }

            if (txtPriceInventorySearch.Text != "")
            {
                cost = txtPriceInventorySearch.Text;
                temp.Price = Convert.ToDouble(cost);
            }

            // Create a list of inventory objects.
            List<Inventory> records = new List<Inventory>();

            // Make records equal to the records returned from the SelectInventory method.
            records = InventorySQL.SelectInventory(temp);

            // Display all records in the records list in lbxInventorySearch.
            foreach (Inventory x in records)
            {
                lbxInventorySearch.Items.Add(x.InvID + " " + x.ItemName + " " + x.Price);
            }
        }
    }
}
