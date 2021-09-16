using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// Repository for Orders
  /// </summary>
  public class OrderRepository : IRepository<Order>
  {
    private const string _path = @"/home/christie/revature/christie_repo/data/orders.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public OrderRepository()
    {
      if (_fileAdapter.ReadFromFile<Order>(_path) == null)
      {
        _fileAdapter.SaveToFile<Order>(_path, new List<Order>()
        {
        });
      }
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Order entry)
    {
      _fileAdapter.SaveToFile<Order>(_path, new List<Order> { entry });

      return true;
    }
    /// <summary>
    /// This will save an order
    /// Save method from Akil Tomlinson
    /// </summary>
    public bool Save(List<Order> entry)
    {
      _fileAdapter.SaveToFile<Order>(_path, entry);

      return true;
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public List<Order> Select()
    {
      return _fileAdapter.ReadFromFile<Order>(_path);
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }
  }
}