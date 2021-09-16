using System;
using System.Collections.Generic;

#nullable disable

namespace ModelsLayer.EFModels
{
    public partial class Store
    {
        public Store()
        {
            Orders = new HashSet<Order>();
        }

        public byte StoreId { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
