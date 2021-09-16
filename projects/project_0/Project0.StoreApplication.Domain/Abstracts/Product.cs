using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{
  /// <summary>
  /// Abstract class for products
  /// </summary>
  [XmlInclude(typeof(NonFiction))]
  [XmlInclude(typeof(Fiction))]
  public abstract class Product
  {
    public byte ProductID { get; set; }
    public string BookType { get; set; }
    public string Genre { get; set; }
    public decimal Price { get; set; }

    /// <summary>
    /// Overriding display of products
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{BookType} - {Genre}: ${Price}";
    }
  }
}