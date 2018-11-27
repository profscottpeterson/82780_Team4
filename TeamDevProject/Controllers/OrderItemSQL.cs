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

        public static void DeleteOrder(int ordId, int invId)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var validate = cnn.Query<OrderItem>("SELECT InvID, OrderID FROM Inv_Ord where OrderID = " + ordId + " AND InvID = " + invId, new DynamicParameters());

                if (validate.ToList().Count == 1)
                {
                    cnn.Execute("Delete from Inv_Ord where OrderID = " + ordId + " AND InvID = " + invId);
                    MessageBox.Show("The record has been deleted.");
                }
                else
                {
                    MessageBox.Show("Please enter an existing record.");
                }
            }
        }
    }
}
