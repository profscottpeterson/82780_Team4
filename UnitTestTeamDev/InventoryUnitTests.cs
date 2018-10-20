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
    class InventoryUnitTests
    {
        [TestMethod]
        public void InvCreate()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                cnn.Query<Inventory>("INSERT INTO Inventory (ItemName, Price) VALUES ('Nike Shoes', 25.00)");
            }
        }

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
            }
        }

        [TestMethod]
        public void InvUpdate()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                cnn.Query<Orders>("UPDATE Inventory SET ItemName = 'Adidas Shoes' WHERE InvID = 3;");
            }
        }

        [TestMethod]
        public void InvDelete()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                cnn.Query<Orders>("DELETE FROM Inventory WHERE InvID = 3");
            }
        }
    }
}
