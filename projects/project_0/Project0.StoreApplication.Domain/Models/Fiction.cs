using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{
  /// <summary>
  /// Fiction derived from abstract class Product
  /// </summary>
  public class Fiction : Product
  {
    public Fiction()
    {
      BookType = "Fiction";
    }
  }
}