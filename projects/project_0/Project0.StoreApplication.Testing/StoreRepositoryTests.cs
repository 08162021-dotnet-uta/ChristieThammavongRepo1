using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing
{
  public class StoreRepositoryTests
  {
    [Fact]
    public void Test_StoreCollection()
    {
      // arrange = instance of the entity of the entity to test
      var sut = new StoreRepository();

      // act = execute sut for data
      var actual = sut.Bookstores;

      // assert
      Assert.NotNull(actual);
    }
  }
}