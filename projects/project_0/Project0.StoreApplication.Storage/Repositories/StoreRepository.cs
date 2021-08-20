using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Store> Stores
    {
      get;
    }

    public StoreRepository()
    {
      Stores = new List<Store>()
      {
        new BookStore(),
        new BookStore(){ Name = "Store002" },
        new BookStore(){ Name = "Store003" }
      };
    }
  }
}