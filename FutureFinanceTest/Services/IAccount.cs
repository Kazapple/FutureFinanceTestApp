using FutureFinanceTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureFinanceTest.Services
{
    interface IAccount
    {
        List<AccountModel> GetAccounts();
        AccountModel GetAccountById(int id);
        int Update(AccountModel account);
    }
}
