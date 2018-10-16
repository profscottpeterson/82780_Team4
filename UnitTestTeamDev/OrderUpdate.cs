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
    public class OrderUpdate
    {
        [TestMethod]
        public void updateOrder()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                cnn.Query<Orders>("UPDATE Orders SET Date = '10/10/10' WHERE OrderID = 3");
            }
        }
    }
}
