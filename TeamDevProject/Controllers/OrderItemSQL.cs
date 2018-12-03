using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SQLite;
using Dapper;
using System.Windows.Forms;

namespace TeamDevProject
{
    public class OrderItemSQL
    {
        public static List<OrderItem> LoadOrderItems()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<OrderItem>("SELECT * FROM Inv_Ord", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveOrderItem(OrderItem ordItem)
        {
            // Opens a connection to access the database and closes after the insert is performed. 
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Insert into Inv_Ord (InvID, OrderID) values ('" + ordItem.invId + "','" + ordItem.orderId + "')");
            }
        }

        public static void DeleteOrderItem(OrderItem ordItem)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                // Delete based on ID.
                cnn.Execute("Delete from Inv_Ord where InvID = " + ordItem.invId + " AND OrderID = " + ordItem.orderId);
            }
        }
    }
}
