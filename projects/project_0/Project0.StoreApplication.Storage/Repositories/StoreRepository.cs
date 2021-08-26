using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    string path = @"/home/christie/revature/christie_repo/data/bookstores.xml";
    public List<Bookstore> Bookstores
    {
      get;
    }

    public StoreRepository()
    {
      var fileAdapter = new FileAdapter();

      if (fileAdapter.ReadFromFile(path) == null)
      {
        fileAdapter.SaveToFile(path, new List<Bookstore>()
        {
          new Bookstore() { Location = "Denver" },
          new Bookstore() { Location = "Boulder" },
          new Bookstore() { Location = "Colorado Springs" }
        });
      }

      Bookstores = fileAdapter.ReadFromFile(path);
    }
  }
}