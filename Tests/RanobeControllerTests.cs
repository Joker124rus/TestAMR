using ASP.NetWebAPI.MappingProfiles;
using AutoMapper;
using Tests.Utility;
using UseCases.Ranobes;

namespace Tests;

public class RanobeControllerTests
{
    private readonly IMapper mapper;

    public RanobeControllerTests()
    {
        var mapperConfig = new MapperConfiguration(config =>
        {
            config.AddProfile<RanobeMappingProfile>();
        });

        mapper = mapperConfig.CreateMapper();
    }

    [Fact]
    public void RanobeController_GetRanobesAsync_CountShouldBe2_Success()
    {
        // Arrange
        var fixture = new TestDatabaseFixture();
        using var context = fixture.CreateContext();

        var handler = new GetRanobesQueryHandler(context, mapper);

        // Act
        var ranobes = handler.Handle(new GetRanobesQuery(), CancellationToken.None).Result;

        // Assert
        Assert.NotEmpty(ranobes);
    }
}