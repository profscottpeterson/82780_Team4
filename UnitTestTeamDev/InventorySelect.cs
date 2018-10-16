using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using Dapper;
using TeamDevProject;

namespace UnitTestTeamDev
{
    [TestClass]
    public class InventorySelect
    {
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
    }
}
