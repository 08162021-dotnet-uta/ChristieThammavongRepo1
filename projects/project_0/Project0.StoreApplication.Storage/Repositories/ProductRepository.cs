using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  /// <summary>
  /// Repository for Products
  /// </summary>
  public class ProductRepository : IRepository<Product>
  {
    private const string _path = @"/home/christie/revature/christie_repo/data/products.xml";
    private static readonly FileAdapter _fileAdapter = new FileAdapter();
    public List<Product> Products
    {
      get;
    }

    public ProductRepository()
    {
      if (_fileAdapter.ReadFromFile<Product>(_path) == null)
      {
        _fileAdapter.SaveToFile<Product>(_path, new List<Product>()
        {
          new NonFiction() { Genre = "Autobiography" , Price = 15.00m},
          new NonFiction() { Genre = "Memoir" , Price = 15.00m },
          new Fiction() { Genre = "Manga" , Price = 10.00m },
          new Fiction() { Genre = "Romance" , Price = 18.00m},
          new Fiction() { Genre = "Suspense" , Price = 18.00m}
        });
      }
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public Product Update()
    {
      throw new System.NotImplementedException();
    }

    public List<Product> Select()
    {
      return _fileAdapter.ReadFromFile<Product>(_path);
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}