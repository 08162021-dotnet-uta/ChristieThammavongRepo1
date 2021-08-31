using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
  /// <summary>
  /// Abstract class for stores
  /// </summary>
  public abstract class Store
  {
    public byte StoreID { get; set; }
    public string Location { get; set; }
    public List<Order> Orders { get; set; }
    public List<Product> Products { get; set; }

    public Store()
    {
      if (Orders.Count == 0)
      {
        Orders = new List<Order>();
      }
      Products = new List<Product>();
    }

    /// <summary>
    /// Overriding display of store location
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"Bookstore - {Location}, CO";
    }
  }
}