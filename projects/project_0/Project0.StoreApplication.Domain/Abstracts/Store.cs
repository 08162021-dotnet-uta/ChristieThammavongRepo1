namespace Project0.StoreApplication.Domain.Abstracts
{
  /// <summary>
  /// Abstract class for stores
  /// </summary>
  public abstract class Store
  {
    public string Location { get; set; }

    public override string ToString()
    {
      return $"Bookstore - {Location}, CO";
    }
  }
}