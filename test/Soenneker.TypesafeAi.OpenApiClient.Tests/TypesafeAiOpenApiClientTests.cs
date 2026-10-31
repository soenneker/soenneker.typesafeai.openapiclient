using Soenneker.Tests.HostedUnit;

namespace Soenneker.TypesafeAi.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TypesafeAiOpenApiClientTests : HostedUnitTest
{
    public TypesafeAiOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
