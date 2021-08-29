using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// Repository for Customers
  /// </summary>
  public class CustomerRepository
  {
    string path = @"/home/christie/revature/christie_repo/data/customers.xml";
    public List<Customer> Customers
    {
      get;
    }

    public CustomerRepository()
    {
      var fileAdapter = new FileAdapter();

      if (fileAdapter.ReadFromFile<Customer>(path) == null)
      {
        fileAdapter.SaveToFile<Customer>(path, new List<Customer>()
        {
          new Customer() { firstName = "Tanjiro" , lastName = "Kamado"},
          new Customer() { firstName = "Naruto" , lastName = "Uzumaki"},
          new Customer() { firstName = "Kyo" , lastName = "Sohma" }
        });
      }

      Customers = fileAdapter.ReadFromFile<Customer>(path);
    }
  }
}