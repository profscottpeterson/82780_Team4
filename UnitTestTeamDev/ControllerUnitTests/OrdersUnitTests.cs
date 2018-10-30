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
   public class OrdersUnitTests
    {
        // This test selects all records from the Orders table and asserts that there is only 1 record.
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
                Assert.AreEqual(1, output.ToList().Count);
            }
        }

        // This test inserts, updates, and deletes a new record in the Orders table. It edits the inserted record, asserts the total number
        // of records and then deletes the record.
        [TestMethod]
        public void OrdersInsertUpdateAndDelete()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                var output = cnn.Query<Orders>("INSERT INTO Orders (Date, CustID) VALUES ('11/11/11', 1)");
                var Newoutput = cnn.Query<Orders>("SELECT * FROM Orders", new DynamicParameters());
                Assert.AreEqual(2, Newoutput.ToList().Count);
                var Updateoutput = cnn.Query<Orders>("Update Orders Set Date = 'mm/dd/yyyy' where Date = '11/11/11'", new DynamicParameters());
                var NewUpdateoutput = cnn.Query<Orders>("SELECT * FROM Orders where Date = 'mm/dd/yyyy'", new DynamicParameters());
                Assert.AreEqual("mm/dd/yyyy", NewUpdateoutput.ToList()[0].Date);
                var outputDelete = cnn.Query<Orders>("Delete FROM Orders where Date = 'mm/dd/yyyy'", new DynamicParameters());
                var NewoutputDelete = cnn.Query<Orders>("SELECT * FROM Orders", new DynamicParameters());
                Assert.AreEqual(1, NewoutputDelete.ToList().Count);

            }
        }
    }
}
