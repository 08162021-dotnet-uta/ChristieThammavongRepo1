using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// Singleton for Products
  /// </summary>
  public class ProductSingleton
  {
    public List<Product> Products { get; }
    private static ProductSingleton _productSingleton;
    private static readonly ProductRepository _productRepository = new ProductRepository();
    /// <summary>
    /// Handler of Singleton Design Pattern for Product
    /// </summary>
    /// <value></value>
    public static ProductSingleton Instance 
    {
      get
      {
        if (_productSingleton == null)
        {
          _productSingleton = new ProductSingleton();
        }

        return _productSingleton;
      }
    }
    /// <summary>
    /// Stores repository of products
    /// </summary>
    private ProductSingleton()
    {
      Products = _productRepository.Select();
    }
  }
}