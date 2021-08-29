using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// Repository for Bookstores
  /// </summary>
  public class StoreRepository
  {
    private const string path = @"/home/christie/revature/christie_repo/data/bookstores.xml";
    public List<Bookstore> Bookstores
    {
      get;
    }

    public StoreRepository()
    {
      var fileAdapter = new FileAdapter();

      if (fileAdapter.ReadFromFile<Bookstore>(path) == null)
      {
        fileAdapter.SaveToFile<Bookstore>(path, new List<Bookstore>()
        {
          new Bookstore() { Location = "Denver" },
          new Bookstore() { Location = "Boulder" },
          new Bookstore() { Location = "Colorado Springs" }
        });
      }

      Bookstores = fileAdapter.ReadFromFile<Bookstore>(path);
    }
  }
}