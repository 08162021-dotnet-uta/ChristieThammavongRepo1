using Project0.StoreApplication.Client.Singletons;
using Xunit;

namespace Project0.StoreApplication.Testing
{
  public class SingletonTests
  {
    /// <summary>
    /// Testing Customer Singleton
    /// </summary>
    [Fact]
    public void Test_CustomerSingleton()
    {
      CustomerSingleton sut = CustomerSingleton.Instance;
      
      Assert.NotNull(sut);
    }

    /// <summary>
    /// Testing Store Singleton
    /// </summary>
    [Fact]
    public void Test_StoreSingleton()
    {
      StoreSingleton sut = StoreSingleton.Instance;
      
      Assert.NotNull(sut);
    }

    /// <summary>
    /// Testing Product Singleton
    /// </summary>
    [Fact]
    public void Test_ProductSingleton()
    {
      ProductSingleton sut = ProductSingleton.Instance;
      
      Assert.NotNull(sut);
    }

    /// <summary>
    /// Testing Order Singleton
    /// </summary>
    [Fact]
    public void Test_OrderSingleton()
    {
      OrderSingleton sut = OrderSingleton.Instance;
      
      Assert.NotNull(sut);
    }
  }
}