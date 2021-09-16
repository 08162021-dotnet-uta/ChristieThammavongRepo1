using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  /// <summary>
  /// Customer class
  /// </summary>
  public class Customer
  {
    public byte CustomerID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    // public List<Order> Orders { get; set; }

    public Customer()
    {
      // if (Orders.Count == 0)
      // {
      //   Orders = new List<Order>();
      // }
    }

    /// <summary>
    /// Overriding display of customer name
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{firstName} {lastName}";
    }
  }
}