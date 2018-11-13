using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using Dapper;
using System.Windows.Forms;

namespace TeamDevProject
{
    public class OrdersSQL
    {
        public static List<Orders> LoadOrders()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<Orders>("SELECT * FROM Orders", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveOrder(Orders order)
        {
            // Opens a connection to access the database and closes after the insert is performed. 
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var validate = cnn.Query<Customer>("SELECT CustID FROM Customer where CustID = " + order.CustID, new DynamicParameters());

                if (validate.ToList().Count == 1)
                {
                    cnn.Execute("Insert into Orders (Date, CustID) values ('" + order.Date + "','" + order.CustID + "')");
                    MessageBox.Show("Order has been added.");
                }
                else
                {
                    MessageBox.Show("Please enter an existing Customer ID.");
                }
            }
        }


        public static void DeleteOrder(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var validate = cnn.Query<Orders>("SELECT OrderID FROM Orders where OrderID = " + id, new DynamicParameters());

                if (validate.ToList().Count == 1)
                {
                    cnn.Execute("Delete from ORDERS where OrderID = " + id);
                    MessageBox.Show("Order " + id.ToString() + " has been deleted.");
                }
                else
                {
                    MessageBox.Show("Please enter an existing Order ID.");
                }
            }
        }

    }
}