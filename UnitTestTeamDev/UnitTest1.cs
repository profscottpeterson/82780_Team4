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
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                var output = cnn.Query<Orders>("SELECT * FROM Orders", new DynamicParameters());
                Console.WriteLine(output.ToList()[0].Date);
                Console.WriteLine("asdaskjhdsjfsjdhfg77777777777777777777777777777");
            }
        }
    }
}
