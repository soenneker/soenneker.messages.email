using Soenneker.Tests.HostedUnit;

namespace Soenneker.Messages.Email.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EmailMessageTests : HostedUnitTest
{
    public EmailMessageTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
