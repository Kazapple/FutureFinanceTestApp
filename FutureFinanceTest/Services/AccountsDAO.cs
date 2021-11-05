using FutureFinanceTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FutureFinanceTest.Services
{
    public class AccountsDAO : IAccount
    {
        string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public AccountModel GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AccountModel> GetAccounts()
        {
            List<AccountModel> allAccounts = new List<AccountModel>();

            string sqlString1 = "SELECT * FROM dbo.Accounts";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlString1, connection);
                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        allAccounts.Add(new AccountModel { AccountId = (int)reader[0], AccountName = (string)reader[2], AccountBalance = (decimal)reader[3] });
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return allAccounts;
            }
        }

        public int Update(AccountModel account)
        {
            throw new NotImplementedException();
        }
    }
}
