using System;
using System.Collections.Generic;

#nullable disable

namespace ModelsLayer.EFModels
{
    /// <summary>
    /// EF Customer
    /// </summary>
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public byte CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
