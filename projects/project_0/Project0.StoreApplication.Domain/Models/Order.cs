using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{
  /// <summary>
  /// Order class relating to customer, store, and product
  /// </summary>
  public class Order
  {
    public byte OrderID { get; set; }
    public Customer Customer { get; set; }
    public Bookstore Bookstore { get; set; }
    public Product Product { get; set; }
    public DateTime OrderDate { get; set; }

    public override string ToString()
    {
      return $" {Bookstore} | {Customer} | {Product} | {OrderDate} ";
    }
  }
}