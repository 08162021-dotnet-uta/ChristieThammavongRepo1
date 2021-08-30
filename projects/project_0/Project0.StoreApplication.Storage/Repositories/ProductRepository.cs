using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// Repository for Products
  /// </summary>
  public class ProductRepository
  {
    private const string path = @"/home/christie/revature/christie_repo/data/products.xml";
    public List<Product> Products
    {
      get;
    }

    public ProductRepository()
    {
      var fileAdapter = new FileAdapter();

      if (fileAdapter.ReadFromFile<Product>(path) == null)
      {
        fileAdapter.SaveToFile<Product>(path, new List<Product>()
        {
          new NonFiction() { Genre = "Autobiography" , Price = 15.00m},
          new NonFiction() { Genre = "Memoir" , Price = 15.00m },
          new Fiction() { Genre = "Manga" , Price = 10.00m },
          new Fiction() { Genre = "Romance" , Price = 18.00m},
          new Fiction() { Genre = "Suspense" , Price = 18.00m}
        });
      }

      Products = fileAdapter.ReadFromFile<Product>(path);
    }
  }
}