using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Messages.Email.Tests;

[Collection("Collection")]
public class EmailMessageTests : FixturedUnitTest
{
    public EmailMessageTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
