using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebService.Models;

namespace SalesWebService.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebService.Models.Customer> Customer { get; set; }

        public DbSet<SalesWebService.Models.Product> Product { get; set; }

        public DbSet<SalesWebService.Models.Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(e => { e.HasIndex("Code").IsUnique(); });
        }
    }
}
