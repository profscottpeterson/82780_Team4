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
    public partial class OrdersMain : Form
    {
        public OrdersMain()
        {
            InitializeComponent();
        }

        private void btnOrdersReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrdersExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            OrdersSearch OrdSearch = new OrdersSearch();
            OrdSearch.ShowDialog();
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            OrdersAdd OrdAdd = new OrdersAdd();
            OrdAdd.ShowDialog();
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            OrdersDelete OrdDelete = new OrdersDelete();
            OrdDelete.ShowDialog();
        }
    }
}
