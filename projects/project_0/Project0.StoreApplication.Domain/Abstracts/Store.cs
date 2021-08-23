namespace Project0.StoreApplication.Domain.Abstracts
{
  public abstract class Store
  {
    public string Location { get; set; }

    public override string ToString()
    {
      return "Bookstore - " + Location + ", CO";
    }
  }
}