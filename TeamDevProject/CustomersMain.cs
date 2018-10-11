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
    public partial class CustomersMain : Form
    {
        public CustomersMain()
        {
            InitializeComponent();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            CustomerSearch CustSearch = new CustomerSearch();
            CustSearch.ShowDialog();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            CustomersAdd CustAdd = new CustomersAdd();
            CustAdd.ShowDialog();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            CustomersDelete CustDelete = new CustomersDelete();
            CustDelete.ShowDialog();
        }

        private void btnCustomerReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomerExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
