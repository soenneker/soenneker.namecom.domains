using Soenneker.NameCom.Domains.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.NameCom.Domains.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class NameComDomainsUtilTests : HostedUnitTest
{
    private readonly INameComDomainsUtil _util;

    public NameComDomainsUtilTests(Host host) : base(host)
    {
        _util = Resolve<INameComDomainsUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
