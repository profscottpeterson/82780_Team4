﻿using System;
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
                cnn.Execute("Delete from Customer where CustID = " + cust.CustID);
            }
        }

    }
}
