using Domain.Models;
using UnitTests.Utility;
using UseCases.Products;

namespace UnitTests;

[TestClass]
public class AnimesTests
{

    [TestMethod]
    public void GetAnimesTestShouldBe2()
    {
        // Arrange
        var fixture = new TestDatabaseFixture();
        using var context = fixture.CreateContext();

        var query = new GetProductsQuery(ProductType.Anime);
        var handler = new GetProductsQueryHandler(context);

        // Act
        var animes = handler.Handle(query, CancellationToken.None).Result;

        // Assert
        Assert.IsTrue(animes.Count() == 2);
    }
}