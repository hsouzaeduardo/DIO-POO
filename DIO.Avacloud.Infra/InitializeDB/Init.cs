using DIO.Avacloud.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Avacloud.Infra.InitializeDB
{
    public static class Init
    {
        public static void InitDb(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { CreateDate = DateTime.Now
                    , Description = "Notebook Avell 32GB 1TB SSD"
                    , Id = 1, Price = 7200, ProductName ="Avell 553", Seller ="Avell Brasil"}
            );
        }
    }
}
