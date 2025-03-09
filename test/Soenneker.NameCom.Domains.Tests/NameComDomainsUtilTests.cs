using Soenneker.NameCom.Domains.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.NameCom.Domains.Tests;

[Collection("Collection")]
public class NameComDomainsUtilTests : FixturedUnitTest
{
    private readonly INameComDomainsUtil _util;

    public NameComDomainsUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<INameComDomainsUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
