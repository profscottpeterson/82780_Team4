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
    public partial class InventoryDelete : Form
    {
        public InventoryDelete()
        {
            InitializeComponent();
        }

        private void btnResetInventoryDelete_Click(object sender, EventArgs e)
        {
            cbxNameNullInventoryDelete.Checked = false;
            cbxPriceNullInventoryDelete.Checked = false;
            cbxIDNullInventoryDelete.Checked = false;
            cbxNameNullInventoryDelete.Enabled = false;
            cbxPriceNullInventoryDelete.Enabled = false;
            cbxIDNullInventoryDelete.Enabled = false;
            txtNameInventoryDelete.Text = "";
            txtPriceInventoryDelete.Text = "";
            txtIDInventoryDelete.Text = "";
            txtNameInventoryDelete.Enabled = false;
            txtPriceInventoryDelete.Enabled = false;
            txtIDInventoryDelete.Enabled = false;
            cbxNameOnInventoryDelete.Checked = false;
            cbxPriceOnInventoryDelete.Checked = false;
            cbxIDOnInventoryDelete.Checked = false;
        }

        private void btnReturnInventoryDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitInventoryDelete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxNameOnInventoryDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNameOnInventoryDelete.Checked)
            {
                txtNameInventoryDelete.Enabled = true;
                cbxNameNullInventoryDelete.Enabled = true;
            }
            else
            {
                cbxNameNullInventoryDelete.Checked = false;
                txtNameInventoryDelete.Enabled = false;
                cbxNameNullInventoryDelete.Enabled = false;
                txtNameInventoryDelete.Text = "";
            }
        }

        private void cbxPriceOnInventoryDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPriceOnInventoryDelete.Checked)
            {
                txtPriceInventoryDelete.Enabled = true;
                cbxPriceNullInventoryDelete.Enabled = true;
            }
            else
            {
                cbxPriceNullInventoryDelete.Checked = false;
                txtPriceInventoryDelete.Enabled = false;
                cbxPriceNullInventoryDelete.Enabled = false;
                txtPriceInventoryDelete.Text = "";
            }
        }

        private void cbxIDOnInventoryDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDOnInventoryDelete.Checked)
            {
                txtIDInventoryDelete.Enabled = true;
                cbxIDNullInventoryDelete.Enabled = true;
            }
            else
            {
                cbxIDNullInventoryDelete.Checked = false;
                txtIDInventoryDelete.Enabled = false;
                cbxIDNullInventoryDelete.Enabled = false;
                txtIDInventoryDelete.Text = "";
            }
        }

        private void cbxNameNullInventoryDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNameNullInventoryDelete.Checked)
            {
                txtNameInventoryDelete.Text = "<NULL>";
                txtNameInventoryDelete.Enabled = false;
            }
            else
            {
                txtNameInventoryDelete.Text = "";
                txtNameInventoryDelete.Enabled = true;
            }
        }

        private void cbxPriceNullInventoryDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPriceNullInventoryDelete.Checked)
            {
                txtPriceInventoryDelete.Text = "<NULL>";
                txtPriceInventoryDelete.Enabled = false;
            }
            else
            {
                txtPriceInventoryDelete.Text = "";
                txtPriceInventoryDelete.Enabled = true;
            }
        }

        private void cbxIDNullInventoryDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIDNullInventoryDelete.Checked)
            {
                txtIDInventoryDelete.Text = "<NULL>";
                txtIDInventoryDelete.Enabled = false;
            }
            else
            {
                txtIDInventoryDelete.Text = "";
                txtIDInventoryDelete.Enabled = true;
            }
        }

        private void btnInventoryDeleteGo_Click(object sender, EventArgs e)
        {
            // Create a cost variable to convert to a double
            string cost = "";

            // Create a temporary inventory object.
            Inventory temp = new Inventory();

            // Assign temp's values based on input.
            if (txtIDInventoryDelete.Text != "")
            {
                temp.InvID = Convert.ToInt32(txtIDInventoryDelete.Text);
            }

            if (txtNameInventoryDelete.Text != "")
            {
                temp.ItemName = txtNameInventoryDelete.Text;
            }
            else
            {
                temp.ItemName = null;
            }

            if (txtPriceInventoryDelete.Text != "")
            {
                cost = txtPriceInventoryDelete.Text;
                temp.Price = Convert.ToDouble(cost);
            }

            // Use the DeleteInventory method and pass temp as an argument.
            InventorySQL.DeleteInventory(temp);
        }
    }
}
