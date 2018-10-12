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
    public class InventoryUpdate
    {
        [TestMethod]
        public void InvUpdate()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                cnn.Query<Orders>("UPDATE Inventory SET ItemName = 'Adidas Shoes' WHERE InvID = 3;");
            }
        }
    }
}
