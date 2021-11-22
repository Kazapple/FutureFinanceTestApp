﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class ExpenseTypeDM
    {

        [Required]
        [Display(Name = "Expense Category")]
        public string ExpenseType { get; set; }
        public int Id { get; set; }

        [Required]
        [Display(Name = "Expenses")]
        public decimal Expenses { get; set; }

        public decimal TotalExpenses { get; set; }

        [Required]
        [Display(Name = "Category budget")]
        public decimal Balance { get; set; }


        public void MoneySum()
        {
            Balance -= Expenses;
            TotalExpenses += Expenses;
        }
    }
}