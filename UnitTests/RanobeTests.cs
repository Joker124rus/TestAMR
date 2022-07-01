using UnitTests.Utility;
using UseCases.Ranobes;

namespace UnitTests;

[TestClass]
public class RanobeTests
{

    [TestMethod]
    public void GetRanobeTestShouldBe2()
    {
        // Arrange
        var fixture = new TestDatabaseFixture();
        using var context = fixture.CreateContext();

        var query = new GetRanobesQuery();
        var handler = new GetRanobesQueryHandler(context);

        // Act
        var ranobes = handler.Handle(query, CancellationToken.None).Result;

        // Assert
        Assert.IsTrue(ranobes.Count() == 2);
    }
}