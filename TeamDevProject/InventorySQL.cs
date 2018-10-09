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
    class InventorySQL
    {
        public static List<Inventory> LoadInventory()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<Inventory>("select * from Inventory", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveInventory(Inventory inventory)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Insert into Inventory values (@ItemName, @Price)", inventory);
            }
        }


        public static void DeleteInventory(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Delete Inventory where InvID = " + id);
            }
        }
    }
}
