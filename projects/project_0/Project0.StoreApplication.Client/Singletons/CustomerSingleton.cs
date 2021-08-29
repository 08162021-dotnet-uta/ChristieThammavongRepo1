using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// Singleton for Customers
  /// </summary>
  public class CustomerSingleton
  {
    public List<Customer> Customers { get; }
    private static CustomerSingleton _customerSingleton;
    private static readonly CustomerRepository _customerRepository = new CustomerRepository();
    /// <summary>
    /// Handler of Singleton Design Pattern for Customer
    /// </summary>
    /// <value></value>
    public static CustomerSingleton Instance 
    {
      get
      {
        if (_customerSingleton == null)
        {
          _customerSingleton = new CustomerSingleton();
        }

        return _customerSingleton;
      }
    }
    /// <summary>
    /// Stores repository of customers
    /// </summary>
    private CustomerSingleton()
    {
      Customers = _customerRepository.Customers;
    }
  }
}