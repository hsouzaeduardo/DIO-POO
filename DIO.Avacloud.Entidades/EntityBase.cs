using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Avacloud.Entidades
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public abstract bool Validate();
    }
}
