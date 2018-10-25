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

        public static List<Inventory> SelectInventory(Inventory inventory)
        {
            
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                if (inventory.ItemName != "" && inventory.Price != 0 && inventory.InvID == 0)
                {
                   var output = cnn.Query<Inventory>("Select InvID, ItemName, Price from Inventory where ItemName = '" + inventory.ItemName + "AND where Price = '" + inventory.Price);
                   return output.ToList();
                }
                else if (inventory.ItemName == "" && inventory.Price != 0 && inventory.InvID == 0)
                {
                   var output = cnn.Query<Inventory>("Select InvID, ItemName, Price from Inventory where Price = " + inventory.Price);
                    return output.ToList();
                }
                else if (inventory.ItemName != "" && inventory.Price == 0 && inventory.InvID == 0)
                {
                    var output = cnn.Query<Inventory>("Select InvID, ItemName, Price from Inventory where ItemName = " + inventory.ItemName);
                    return output.ToList();
                }
                else
                {
                    var output = cnn.Query<Inventory>("Select InvID, ItemName, Price from Inventory where InvID = " + inventory.InvID);
                    return output.ToList();
                }
            }
        }

        public static void SaveInventory(Inventory inventory)
        {

            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Insert into Inventory (ItemName, Price) values ('" + inventory.ItemName + "','" + inventory.Price + "')");
            }
        }


        public static void DeleteInventory(Inventory inventory)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                if (inventory.ItemName != "" && inventory.Price != 0 && inventory.InvID == 0)
                {
                    cnn.Execute("Delete from Inventory where ItemName = '" + inventory.ItemName + "AND where Price = '" + inventory.Price);
                }
                else if (inventory.ItemName == "" && inventory.Price != 0 && inventory.InvID == 0)
                {
                    cnn.Execute("Delete from Inventory where Price = " + inventory.Price);
                }
                else if (inventory.ItemName != "" && inventory.Price == 0 && inventory.InvID == 0)
                {
                    cnn.Execute("Delete from Inventory where ItemName = " + inventory.ItemName);
                }
                else
                {
                    cnn.Execute("Delete from Inventory where InvID = " + inventory.InvID);
                }
                    
            }
        }
    }
}
