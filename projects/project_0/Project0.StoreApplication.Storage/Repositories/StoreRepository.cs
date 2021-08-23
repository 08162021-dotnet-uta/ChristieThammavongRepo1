using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Bookstore> Bookstores
    {
      get;
    }

    public StoreRepository()
    {
      Bookstores = new List<Bookstore>()
      {
        new Bookstore() { Location = "Denver" },
        new Bookstore() { Location = "Boulder" },
        new Bookstore() { Location = "Colorado Springs" }
      };
    }
  }
}