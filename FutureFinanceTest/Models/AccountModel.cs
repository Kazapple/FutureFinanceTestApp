using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureFinanceTest.Models
{
    public class AccountModel
    {
        [DisplayName("Account Id")]
        public int AccountId { get; set; }
        
        [DisplayName("Account Name")]
        public string AccountName { get; set; }

        [DataType(DataType.Currency)]
        [DisplayName("Balance")]
        public decimal AccountBalance { get; set; }
    }
}
