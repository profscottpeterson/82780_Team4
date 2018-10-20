using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using Dapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamDevProject;

namespace UnitTestTeamDev
{
    [TestClass]
    class OrdersUnitTests
    {
        [TestMethod]
        public void createOrder()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                cnn.Query<Orders>("INSERT INTO Orders (Date) VALUES ('11/11/11')");
            }
        }

        [TestMethod]
        public void selectOrders()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                var output = cnn.Query<Orders>("SELECT * FROM Orders", new DynamicParameters());
                output.ToList();
                foreach (var order in output)
                {
                    Console.WriteLine("CustID is {0}, OrderID is {1}, Date is {2}", order.CustID, order.OrderID, order.Date);
                }
            }
        }

        [TestMethod]
        public void updateOrder()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                cnn.Query<Orders>("UPDATE Orders SET Date = '10/10/10' WHERE OrderID = 3");
            }
        }

        [TestMethod]
        public void deleteOrder()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                cnn.Query<Orders>("DELETE FROM Orders WHERE OrderID = 5");
            }
        }
    }
}
