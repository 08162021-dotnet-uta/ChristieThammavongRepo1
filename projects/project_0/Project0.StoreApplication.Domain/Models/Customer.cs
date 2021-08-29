namespace Project0.StoreApplication.Domain.Models
{
  /// <summary>
  /// Customer class
  /// </summary>
  public class Customer
  {
    public string firstName { get; set; }
    public string lastName { get; set; }

    public override string ToString()
    {
      return $"{firstName} {lastName}";
    }
    public Customer()
    {
      
    }
  }
}