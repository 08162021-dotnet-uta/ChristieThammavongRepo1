using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage
{
  /// <summary>
  /// Class for Entity Framework execution
  /// </summary>
  public class EF
  {
    private readonly DataAdapter _da = new DataAdapter();

    public List<Customer> GetCustomers()
    {
      return _da.Customers.FromSqlRaw("select * from Customer.Customer").ToList();

            //_da.Orders.FromSqlRaw("select * from Store.Order where CustomerId = {0}", customers[0].CustomerId);
    }
  }
}