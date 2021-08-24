using DIO.Avacloud.Entidades;
using DIO.Avacloud.Infra.InitializeDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Avacloud.Infra.Contexto
{
    public class AvaCloudDB:DbContext
    {
        public AvaCloudDB(DbContextOptions<AvaCloudDB> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.InitDb();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
