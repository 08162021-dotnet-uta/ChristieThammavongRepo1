using System;
using System.Collections.Generic;

#nullable disable

namespace ModelsLayer.EFModels
{
    public partial class Order
    {
        public short OrderId { get; set; }
        public byte CustomerId { get; set; }
        public byte StoreId { get; set; }
        public byte BookId { get; set; }
        public byte Quantity { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
    }
}
