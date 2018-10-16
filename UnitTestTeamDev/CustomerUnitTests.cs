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
    public class CustomerUnitTests
    {
        [TestMethod]
        public void CustomerSelect()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                var output = cnn.Query<Customer>("SELECT * FROM Customer", new DynamicParameters());
                Assert.AreEqual(2, output.ToList().Count);
            }
        }

        [TestMethod]
        public void CustomerInsertAndUpdate()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                var output = cnn.Query<Customer>("INSERT INTO Customer values('3', 'TestFirstName', 'TestLastName', 'TestEmail')", new DynamicParameters());
                var Newoutput = cnn.Query<Customer>("SELECT * FROM Customer", new DynamicParameters());
                Assert.AreEqual(3, Newoutput.ToList().Count);
                var Updateoutput = cnn.Query<Customer>("Update Customer Set FirstName = 'UpdateTest' where CustID not in ('1', '2')", new DynamicParameters());
                var NewUpdateoutput = cnn.Query<Customer>("SELECT * FROM Customer  where CustID not in ('1', '2')", new DynamicParameters());
                Assert.AreEqual("UpdateTest", NewUpdateoutput.ToList()[0].FirstName);

            }
        }

        [TestMethod]
        public void CustomerDelete()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString))
            {
                var output = cnn.Query<Customer>("Delete FROM Customer where CustID not in ('1', '2')", new DynamicParameters());
                var Newoutput = cnn.Query<Customer>("SELECT * FROM Customer", new DynamicParameters());
                Assert.AreEqual(2, Newoutput.ToList().Count);
            }
        }
    }
}
