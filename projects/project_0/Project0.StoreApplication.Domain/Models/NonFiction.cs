using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Domain.Models
{
  /// <summary>
  /// NonFiction derived from abstract class Product
  /// </summary>
  public class NonFiction : Product
  {
    public NonFiction()
    {
      BookType = "Non-Fiction";
    }
  }
}