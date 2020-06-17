using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstEfCoreApp
{
    public class AppDbContext :DbContext
    {
        private const string _conectionString = @"Server=(localdb)\mssqllocaldb;
                                                Database=MyFirstEfCoreDB;
                                                Trusted_Connection=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conectionString);
        }

        public DbSet<Book> Books { get; set; }
            
    }
}
