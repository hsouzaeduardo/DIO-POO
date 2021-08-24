using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Avacloud.Entidades
{
    public class Product :EntityBase
    {
        
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public string Seller { get; set; }
        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(ProductName);
        }
    }
}
