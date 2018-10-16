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
    public partial class InventoryMain : Form
    {
        public InventoryMain()
        {
            InitializeComponent();
        }

        private void btnInventorySearch_Click(object sender, EventArgs e)
        {
            InventorySearch InvSearch = new InventorySearch();
            InvSearch.ShowDialog();
        }

        private void btnInventoryAdd_Click(object sender, EventArgs e)
        {
            InventoryAdd InvAdd = new InventoryAdd();
            InvAdd.ShowDialog();
        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            InventoryDelete InvDelete = new InventoryDelete();
            InvDelete.ShowDialog();
        }

        private void btnInventoryReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventoryExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
