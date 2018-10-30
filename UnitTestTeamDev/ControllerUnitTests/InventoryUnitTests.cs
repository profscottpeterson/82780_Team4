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
    public class InventoryUnitTests
    {
        // This test selects all records from the Inventory table and asserts that there is only 2 records.
        [TestMethod]
        public void InvSelect()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                var output = cnn.Query<Inventory>("SELECT * FROM Inventory", new DynamicParameters());
                output.ToList();
                foreach (var item in output)
                {
                    Console.WriteLine("InvID is {0}, ItemName is {1}, Price is {2}", item.InvID, item.ItemName, item.Price);
                }
                Assert.AreEqual(2, output.ToList().Count);
            }
        }

        // This test inserts, updates, and deletes a new record in the Inventory table. It edits the inserted record, asserts the total number
        // of records and then deletes the record.
        [TestMethod]
        public void InvInsertUpdateAndDelete()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                var output = cnn.Query<Inventory>("INSERT INTO Inventory (ItemName, Price) VALUES ('Nike Shoes', 25.00)");
                var Newoutput = cnn.Query<Inventory>("SELECT * FROM Inventory", new DynamicParameters());
                Assert.AreEqual(3, Newoutput.ToList().Count);
                var Updateoutput = cnn.Query<Inventory>("Update Inventory Set ItemName = 'UpdateTest' where ItemName = 'Nike Shoes'", new DynamicParameters());
                var NewUpdateoutput = cnn.Query<Inventory>("SELECT * FROM Inventory  where ItemName = 'UpdateTest'", new DynamicParameters());
                Assert.AreEqual("UpdateTest", NewUpdateoutput.ToList()[0].ItemName);
                var outputDelete = cnn.Query<Inventory>("Delete FROM Inventory where ItemName = 'UpdateTest'", new DynamicParameters());
                var NewoutputDelete = cnn.Query<Inventory>("SELECT * FROM Inventory", new DynamicParameters());
                Assert.AreEqual(2, NewoutputDelete.ToList().Count);

            }
        }
    }
}
