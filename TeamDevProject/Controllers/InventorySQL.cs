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
            // Opens a connection to access the database and closes after the load is performed. 
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                // Return the list of items.
                var output = cnn.Query<Inventory>("select * from Inventory", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Inventory> SelectInventory(Inventory inventory)
        {
            // Opens a connection to access the database and closes after the select is performed. 
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                // The item name and price is provided, but the ID is not. Select based on name and price.
                if (inventory.ItemName != "" && inventory.Price != 0 && inventory.InvID == 0)
                {
                   var output = cnn.Query<Inventory>("Select InvID, ItemName, Price from Inventory where ItemName = '" + inventory.ItemName + "'"+  "AND where Price = '" + inventory.Price);
                   return output.ToList();
                }
                // The item price is provided, but the name and ID are not. Select based on name and price.
                else if (inventory.ItemName == "" && inventory.Price != 0 && inventory.InvID == 0)
                {
                   var output = cnn.Query<Inventory>("Select InvID, ItemName, Price from Inventory where Price = " + inventory.Price);
                    return output.ToList();
                }
                // The item name is provided, but the price and ID are not. Select based on name.
                else if (inventory.ItemName != "" && inventory.Price == 0 && inventory.InvID == 0)
                {
                    var output = cnn.Query<Inventory>("Select InvID, ItemName, Price from Inventory where ItemName = '" + inventory.ItemName + "'");
                    return output.ToList();
                }
                // Select based on ID.
                else
                {
                    var output = cnn.Query<Inventory>("Select InvID, ItemName, Price from Inventory where InvID = " + inventory.InvID);
                    return output.ToList();
                }
            }
        }

        public static void SaveInventory(Inventory inventory)
        {
            // Opens a connection to access the database and closes after the insert is performed. 
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Insert into Inventory (ItemName, Price) values ('" + inventory.ItemName + "','" + inventory.Price + "')");
            }
        }


        public static void DeleteInventory(Inventory inventory)
        {
            // Opens a connection to access the database and closes after the delete is performed. 
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                // The item name and price is provided, but the ID is not. Delete based on name and price.
                if (inventory.ItemName != "" && inventory.Price != 0 && inventory.InvID == 0)
                {
                    cnn.Execute("Delete from Inventory where ItemName = '" + inventory.ItemName + "'" + "AND where Price = '" + inventory.Price);
                }
                // The item price is provided, but the name and ID are not. Delete based on name and price.
                else if (inventory.ItemName == "" && inventory.Price != 0 && inventory.InvID == 0)
                {
                    cnn.Execute("Delete from Inventory where Price = " + inventory.Price);
                }
                // The item name is provided, but the price and ID are not. Delete based on name.
                else if (inventory.ItemName != "" && inventory.Price == 0 && inventory.InvID == 0)
                {
                    cnn.Execute("Delete from Inventory where ItemName = '" + inventory.ItemName + "'");
                }
                // Delete based on ID.
                else
                {
                    cnn.Execute("Delete from Inventory where InvID = " + inventory.InvID);
                }
                    
            }
        }
    }
}
