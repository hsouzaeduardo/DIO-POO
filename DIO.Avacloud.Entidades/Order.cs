using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Avacloud.Entidades
{
    public class Order : EntityBase
    {
        
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItem { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        public override bool Validate()
        {
           return OrderItem.Count > 0;
        }
    }
}
