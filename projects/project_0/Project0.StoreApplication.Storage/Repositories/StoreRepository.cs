using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// Repository for Bookstores
  /// </summary>
  public class StoreRepository : IRepository<Bookstore>
  {
    private const string _path = @"/home/christie/revature/christie_repo/data/bookstores.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();
    public List<Bookstore> Bookstores
    {
      get;
    }

    public StoreRepository()
    {
      if (_fileAdapter.ReadFromFile<Bookstore>(_path) == null)
      {
        _fileAdapter.SaveToFile<Bookstore>(_path, new List<Bookstore>()
        {
          new Bookstore() { Location = "Denver" },
          new Bookstore() { Location = "Boulder" },
          new Bookstore() { Location = "Colorado Springs" }
        });
      }
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public Bookstore Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Bookstore> Select()
    {
      return _fileAdapter.ReadFromFile<Bookstore>(_path);
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}