using BLL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ExpenseTypeDM> ExpenseTypes { get; set; }
        public DbSet<ExpenseTypeDM> Balance { get; set; }
        public DbSet<ExpenseTypeDM> Expenses { get; set; }
        public DbSet<ExpenseTypeDM> TotalExpenses { get; set; }
    }
}
