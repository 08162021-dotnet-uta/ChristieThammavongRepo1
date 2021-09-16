using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Xunit;

namespace Project0.StoreApplication.Testing
{
  public class DomainTests
  {
    /// <summary>
    /// Testing Customer constructor
    /// </summary>
    [Fact]
    public void Test_CustomerConstructor()
    {
      Customer sut = new Customer();

      sut.firstName = "customer";
      sut.lastName = "test";

      Assert.Equal("customer", sut.firstName);
      Assert.Equal("test", sut.lastName);
    }

    /// <summary>
    /// Testing Store constructor
    /// </summary>
    [Fact]
    public void Test_StoreConstructor()
    {
      Bookstore sut = new Bookstore();

      sut.Location = "Colorado";

      Assert.Equal("Colorado", sut.Location);
    }

    /// <summary>
    /// Testing Product Non-Fiction constructor
    /// </summary>
    [Fact]
    public void Test_ProductNonFictionConstructor()
    {
      NonFiction sut = new NonFiction();

      sut.Genre = "autobiography";
      sut.Price = 5.00m;

      Assert.Equal("Non-Fiction", sut.BookType);
      Assert.Equal("autobiography", sut.Genre);
      Assert.Equal(5.00m, sut.Price);
    }

    /// <summary>
    /// Testing Product Fiction constructor
    /// </summary>
    [Fact]
    public void Test_ProductFictionConstructor()
    {
      Fiction sut = new Fiction();

      sut.Genre = "romance";
      sut.Price = 18.00m;

      Assert.Equal("Fiction", sut.BookType);
      Assert.Equal("romance", sut.Genre);
      Assert.Equal(18.00m, sut.Price);
    }
  }
}