using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDatabase
{
    public class MovieContext : DbContext
    {
        private const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb;Database=MovieDatabase;Trusted_Connection=True;";
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
    }
}
