using Soenneker.NameCom.Domains.Requests;
using Soenneker.NameCom.Domains.Responses;
using Soenneker.NameCom.Domains.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.NameCom.Domains.Abstract
{
    /// <summary>
    /// Interface for interacting with Name.com domain services.
    /// </summary>
    public interface INameComDomainsUtil
    {
        /// <summary>
        /// Retrieves a list of domains.
        /// </summary>
        ValueTask<ListDomainsResponse?> ListDomains(ListDomainsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets details of a specific domain.
        /// </summary>
        ValueTask<NameComDomain?> GetDomain(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new domain registration.
        /// </summary>
        ValueTask<CreateDomainResponse?> CreateDomain(CreateDomainRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enables Whois privacy for a domain.
        /// </summary>
        ValueTask<NameComDomain?> EnableWhoisPrivacy(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Disables Whois privacy for a domain.
        /// </summary>
        ValueTask<NameComDomain?> DisableWhoisPrivacy(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enables automatic renewal for a domain.
        /// </summary>
        ValueTask<NameComDomain?> EnableAutorenew(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Disables automatic renewal for a domain.
        /// </summary>
        ValueTask<NameComDomain?> DisableAutorenew(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Renews a domain for a specified period.
        /// </summary>
        ValueTask<RenewDomainResponse?> RenewDomain(string domainName, RenewDomainRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets pricing details for a domain.
        /// </summary>
        ValueTask<GetDomainPricingResponse?> GetPricingForDomain(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the authorization code required for domain transfer.
        /// </summary>
        ValueTask<GetAuthCodeResponse?> GetAuthCodeForDomain(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Purchases Whois privacy protection for a domain.
        /// </summary>
        ValueTask<PurchasePrivacyResponse?> PurchasePrivacy(string domainName, PurchasePrivacyRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sets nameservers for a domain.
        /// </summary>
        ValueTask<NameComDomain?> SetNameservers(string domainName, SetNameserversRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sets contact information for a domain.
        /// </summary>
        ValueTask<NameComDomain?> SetContacts(string domainName, SetContactsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Locks a domain to prevent transfer.
        /// </summary>
        ValueTask<NameComDomain?> LockDomain(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unlocks a domain for transfer.
        /// </summary>
        ValueTask<NameComDomain?> UnlockDomain(string domainName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks the availability of one or more domains.
        /// </summary>
        ValueTask<CheckAvailabilityResponse?> CheckAvailability(CheckAvailabilityRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Searches for domain name suggestions based on a keyword.
        /// </summary>
        ValueTask<SearchResponse?> Search(SearchRequest request, CancellationToken cancellationToken = default);
    }
}
