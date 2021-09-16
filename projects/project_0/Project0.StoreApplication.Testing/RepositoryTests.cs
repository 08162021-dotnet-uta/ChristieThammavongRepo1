using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing
{
  public class StoreRepositoryTests
  {
    /// <summary>
    /// Testing that Customer Repository has content
    /// </summary>
    [Fact]
    public void Test_CustomerCollection()
    {
      CustomerRepository sut = new CustomerRepository();

      var actual = sut.Select();

      Assert.NotNull(actual);
    }

    /// <summary>
    /// Testing that Store Repository has content
    /// </summary>
    [Fact]
    public void Test_StoreCollection()
    {
      // arrange = instance of the entity of the entity to test
      StoreRepository sut = new StoreRepository();

      // act = execute sut for data
      var actual = sut.Select();

      // assert
      Assert.NotNull(actual);
    }

    /// <summary>
    /// Testing that Product Repository has content
    /// </summary>
    [Fact]
    public void Test_ProductCollection()
    {
      ProductRepository sut = new ProductRepository();

      var actual = sut.Select();

      Assert.NotNull(actual);
    }

    /// <summary>
    /// Testing that Order Repository has content
    /// </summary>
    [Fact]
    public void Test_OrderCollection()
    {
      OrderRepository sut = new OrderRepository();

      var actual = sut.Select();

      Assert.NotNull(actual);
    }
  }
}