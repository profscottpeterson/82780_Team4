using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Data.SQLite;
using Dapper;


namespace TeamDevProject
{
    public partial class InventoryAdd : Form
    {
        public InventoryAdd()
        {
            InitializeComponent();
        }

        private void btnResetInventoryAdd_Click(object sender, EventArgs e)
        {
            cbxNameNullInventoryAdd.Checked = false;
            cbxPriceNullInventoryAdd.Checked = false;
            cbxNameNullInventoryAdd.Enabled = false;
            cbxPriceNullInventoryAdd.Enabled = false;
            txtNameInventoryAdd.Text = "";
            txtPriceInventoryAdd.Text = "";
            txtNameInventoryAdd.Enabled = false;
            txtPriceInventoryAdd.Enabled = false;
            cbxNameOnInventoryAdd.Checked = false;
            cbxPriceOnInventoryAdd.Checked = false;
        }

        private void btnReturnInventoryAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExitInventoryAdd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxPriceOnInventoryAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPriceOnInventoryAdd.Checked)
            {
                txtPriceInventoryAdd.Enabled = true;
                cbxPriceNullInventoryAdd.Enabled = true;
            }
            else
            {
                cbxPriceNullInventoryAdd.Checked = false;
                txtPriceInventoryAdd.Enabled = false;
                cbxPriceNullInventoryAdd.Enabled = false;
                txtPriceInventoryAdd.Text = "";
            }
        }

        private void cbxIDOnInventoryAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxNameNullInventoryAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNameNullInventoryAdd.Checked)
            {
                txtNameInventoryAdd.Text = "<NULL>";
                txtNameInventoryAdd.Enabled = false;
            }
            else
            {
                txtNameInventoryAdd.Text = "";
                txtNameInventoryAdd.Enabled = true;
            }
        }

        private void cbxPriceNullInventoryAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPriceNullInventoryAdd.Checked)
            {
                txtPriceInventoryAdd.Text = "<NULL>";
                txtPriceInventoryAdd.Enabled = false;
            }
            else
            {
                txtPriceInventoryAdd.Text = "";
                txtPriceInventoryAdd.Enabled = true;
            }
        }

        private void cbxNameOnInventoryAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNameOnInventoryAdd.Checked)
            {
                txtNameInventoryAdd.Enabled = true;
                cbxNameNullInventoryAdd.Enabled = true;
            }
            else
            {
                cbxNameNullInventoryAdd.Checked = false;
                txtNameInventoryAdd.Enabled = false;
                cbxNameNullInventoryAdd.Enabled = false;
                txtNameInventoryAdd.Text = "";
            }
        }

        private void btnInventoryAddGo_Click(object sender, EventArgs e)
        {
            // Create a temporary inventory object.
            Inventory temp = new Inventory();

            // Assign temp's values.
            temp.ItemName = txtNameInventoryAdd.Text;
            string cost = "";
            cost = txtPriceInventoryAdd.Text;
            temp.Price = Convert.ToDouble(cost);

            // Call the SaveInventory method and pass temp as an argument.
            InventorySQL.SaveInventory(temp);
        }   
    }
}
