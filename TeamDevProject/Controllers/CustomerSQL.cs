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
    public class CustomerSQL
    {
        public static List<Customer> LoadCustomers()
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                var output = cnn.Query<Customer>("select * from Customer", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveCustomer(Customer customer)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                cnn.Execute("Insert into Customer (FirstName, LastName, Email) values (@FirstName, @LastName, @Email)", customer);
            }
        }


        public static void DeleteCustomer(Customer cust)
        {
            using (IDbConnection cnn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                // User supplied firstname lastname and email
                if (cust.FirstName != "" && cust.LastName != "" && cust.Email != "" && cust.CustID == 0)
                {
                    cnn.Execute("Delete from Customer where FirstName = '" + cust.FirstName + "'" + "AND where LastName = '" + cust.LastName + "AND where Email = '" + cust.Email);
                }
                // User supplied firstname lastname
                else if (cust.FirstName != "" && cust.LastName != "" && cust.CustID == 0)
                {
                    cnn.Execute("Delete from Customer where FirstName = '" + cust.FirstName + "'" + "AND where LastName = '" + cust.LastName);
                }
                // user supplied firstname email
                else if (cust.FirstName != "" && cust.Email != "" && cust.CustID == 0)
                {
                    cnn.Execute("Delete from Customer where FirstName = '" + cust.FirstName + "'" + "AND where Email = '" + cust.Email);
                }
                // user supplied lastname email
                else if (cust.LastName != "" && cust.Email != "" && cust.CustID == 0)
                {
                    cnn.Execute("Delete from Customer where LastName = '" + cust.LastName + "'" + "AND where Email = '" + cust.Email);
                }
                // user supplied firstname
                else if (cust.FirstName != "" && cust.CustID == 0)
                {
                    cnn.Execute("Delete from Customer where FirstName = " + cust.FirstName);
                }
                // user supplied lastname
                else if (cust.LastName != "" && cust.CustID == 0)
                {
                    cnn.Execute("Delete from Customer where FirstName = " + cust.LastName);
                }
                // user supplied email
                else if (cust.Email != "" && cust.CustID == 0)
                {
                    cnn.Execute("Delete from Customer where Email = " + cust.Email);
                }
                else
                {
                    cnn.Execute("Delete from Customer where CustID = " + cust.CustID);
                }
            }
        }

    }
}
