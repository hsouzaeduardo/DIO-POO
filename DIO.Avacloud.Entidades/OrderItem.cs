using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Avacloud.Entidades
{
    public class OrderItem : EntityBase
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                if(Product != null)
                    totalPrice = Product.Price * Quantity;
                return totalPrice;
            }
        }

        public override bool Validate()
        {
            bool isValid = true;
            if (Quantity <= 0) isValid = false;
            if(ProductId <= 0) isValid = false;

            return isValid;
        }

    }
}
