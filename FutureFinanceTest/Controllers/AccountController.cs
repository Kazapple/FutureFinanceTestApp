using FutureFinanceTest.Models;
using FutureFinanceTest.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FutureFinanceTest.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
                AccountsDAO accounts = new AccountsDAO();


                return View(accounts.GetAccounts());
        }

        public IActionResult Account()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlQuery = "SELECT * FROM dbo.Accounts";

            var model = new List<AccountModel>();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var account = new AccountModel();
                    account.AccountId = (int)rdr["AccountId"];
                    account.AccountName = (string)rdr["AccountName"];
                    account.AccountBalance = (decimal)rdr["Balance"];

                    model.Add(account);
                }
            }
            return View(model);
        }
    }
}
