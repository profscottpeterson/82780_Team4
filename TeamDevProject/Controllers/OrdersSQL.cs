using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

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
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Insert into Orders values (@CustID, @OrderID, @Date)", order);
            }
        }


        public static void DeleteOrder(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Delete ORDERS where ORDERID = " + id);
            }
        }

    }
}