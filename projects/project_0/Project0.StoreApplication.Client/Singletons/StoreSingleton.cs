using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// Singleton for Stores
  /// </summary>
  public class StoreSingleton
  {
    public List<Bookstore> Bookstores { get; }
    private static StoreSingleton _storeSingleton;
    private static readonly StoreRepository _storeRepository = new StoreRepository();
    /// <summary>
    /// Handler of Singleton Design Pattern for Stores
    /// </summary>
    /// <value></value>
    public static StoreSingleton Instance 
    {
      get
      {
        if (_storeSingleton == null)
        {
          _storeSingleton = new StoreSingleton();
        }

        return _storeSingleton;
      }
    }
    /// <summary>
    /// Stores repository of bookstores
    /// </summary>
    private StoreSingleton()
    {
      Bookstores = _storeRepository.Bookstores;
    }
  }
}