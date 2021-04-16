using Microsoft.EntityFrameworkCore;
using OM.EntityRepo.Entity;
using OrderManagement.EF.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.EF.Context
{
    public class OMContext : DbContext 
    {
        public OMContext() { }
        public OMContext(DbContextOptions<OMContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info= False; 
                                        Integrated Security = true; 
                                        Initial Catalog = OrderManag; 
                                        Server = .\SQLEXPRESS ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Client>(new ClientConfiguration());
            modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());

        }
    }
    
    
}
