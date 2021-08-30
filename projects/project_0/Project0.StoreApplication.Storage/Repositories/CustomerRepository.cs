using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// Repository for Customers
  /// </summary>
  public class CustomerRepository : IRepository<Customer>
  {
    private const string _path = @"/home/christie/revature/christie_repo/data/customers.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public CustomerRepository()
    {
      if (_fileAdapter.ReadFromFile<Customer>(_path) == null)
      {
        _fileAdapter.SaveToFile<Customer>(_path, new List<Customer>()
        {
          new Customer() { firstName = "Tanjiro" , lastName = "Kamado"},
          new Customer() { firstName = "Naruto" , lastName = "Uzumaki"},
          new Customer() { firstName = "Kyo" , lastName = "Sohma" }
        });
      }
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Customer> Select()
    {
      return _fileAdapter.ReadFromFile<Customer>(_path);
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}