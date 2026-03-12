using Soenneker.NameCom.Client.Abstract;
using Soenneker.NameCom.Domains.Abstract;
using Soenneker.NameCom.Domains.Requests;
using Soenneker.NameCom.Domains.Responses;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Soenneker.Extensions.Object;
using Soenneker.Extensions.HttpClient;
using Soenneker.Extensions.ValueTask;
using Soenneker.NameCom.Domains.Dtos;

namespace Soenneker.NameCom.Domains;

/// <inheritdoc cref="INameComDomainsUtil"/>
public class NameComDomainsUtil: INameComDomainsUtil
{
    private readonly INameComClientUtil _clientUtil;

    public NameComDomainsUtil(INameComClientUtil clientUtil)
    {
        _clientUtil = clientUtil;
    }

    public async ValueTask<ListDomainsResponse?> ListDomains(ListDomainsRequest request, bool test = false, CancellationToken cancellationToken = default)
    {
        string endpoint = "domains" + request.ToQueryString();

        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();

        return await client.SendToType<ListDomainsResponse>(HttpMethod.Get, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> GetDomain(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}";

        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();

        return await client.SendToType<NameComDomain>(HttpMethod.Get, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<CreateDomainResponse?> CreateDomain(CreateDomainRequest request, bool test = false, CancellationToken cancellationToken = default)
    {
        const string endpoint = "domains";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<CreateDomainResponse>(HttpMethod.Post, endpoint, request, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> EnableWhoisPrivacy(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:enableWhoisPrivacy";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<NameComDomain>(HttpMethod.Post, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> DisableWhoisPrivacy(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:disableWhoisPrivacy";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<NameComDomain>(HttpMethod.Post, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> EnableAutorenew(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:enableAutorenew";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<NameComDomain>(HttpMethod.Post, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> DisableAutorenew(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:disableAutorenew";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<NameComDomain>(HttpMethod.Post, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<RenewDomainResponse?> RenewDomain(string domainName, RenewDomainRequest request, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:renew";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<RenewDomainResponse>(HttpMethod.Post, endpoint, request, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<GetDomainPricingResponse?> GetPricingForDomain(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:getPricing";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<GetDomainPricingResponse>(HttpMethod.Get, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<GetAuthCodeResponse?> GetAuthCodeForDomain(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:getAuthCode";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<GetAuthCodeResponse>(HttpMethod.Get, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<PurchasePrivacyResponse?> PurchasePrivacy(string domainName, PurchasePrivacyRequest request, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:purchasePrivacy";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<PurchasePrivacyResponse>(HttpMethod.Post, endpoint, request, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> SetNameservers(string domainName, SetNameserversRequest request, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:setNameservers";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<NameComDomain>(HttpMethod.Post, endpoint, request, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> SetContacts(string domainName, SetContactsRequest request, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:setContacts";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<NameComDomain>(HttpMethod.Post, endpoint, request, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> LockDomain(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:lock";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<NameComDomain>(HttpMethod.Post, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<NameComDomain?> UnlockDomain(string domainName, bool test = false, CancellationToken cancellationToken = default)
    {
        var endpoint = $"domains/{domainName}:unlock";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<NameComDomain>(HttpMethod.Post, endpoint, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<CheckAvailabilityResponse?> CheckAvailability(CheckAvailabilityRequest request, bool test = false, CancellationToken cancellationToken = default)
    {
        const string endpoint = "domains:checkAvailability";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<CheckAvailabilityResponse>(HttpMethod.Post, endpoint, request, cancellationToken: cancellationToken).NoSync();
    }

    public async ValueTask<SearchResponse?> Search(SearchRequest request, bool test = false, CancellationToken cancellationToken = default)
    {
        const string endpoint = "domains:search";
        HttpClient client = await _clientUtil.Get(test, cancellationToken).NoSync();
        return await client.SendToType<SearchResponse>(HttpMethod.Post, endpoint, request, cancellationToken: cancellationToken).NoSync();
    }
}
