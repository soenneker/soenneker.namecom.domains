using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Dtos;

/// <summary>
/// Domain lists all the data for a domain.
/// </summary>
public record NameComDomain
{
    /// <summary>
    /// DomainName is the punycode encoded value of the domain name.
    /// </summary>
    [JsonPropertyName("domainName")]
    public string DomainName { get; set; } = string.Empty;

    /// <summary>
    /// Nameservers is the list of nameservers for this domain. If unspecified, it defaults to your account default nameservers.
    /// </summary>
    [JsonPropertyName("nameservers")]
    public string[]? Nameservers { get; set; }

    /// <summary>
    /// NameComContacts for the domain.
    /// </summary>
    [JsonPropertyName("contacts")]
    public NameComContacts? Contacts { get; set; }

    /// <summary>
    /// PrivacyEnabled reflects if Whois Privacy is enabled for this domain.
    /// </summary>
    [JsonPropertyName("privacyEnabled")]
    public bool PrivacyEnabled { get; set; }

    /// <summary>
    /// Locked indicates that the domain cannot be transferred to another registrar.
    /// </summary>
    [JsonPropertyName("locked")]
    public bool Locked { get; set; }

    /// <summary>
    /// AutorenewEnabled indicates if the domain will attempt to renew automatically before expiration.
    /// </summary>
    [JsonPropertyName("autorenewEnabled")]
    public bool AutorenewEnabled { get; set; }

    /// <summary>
    /// ExpireDate is the date the domain will expire (read-only).
    /// </summary>
    [JsonPropertyName("expireDate")]
    public string? ExpireDate { get; init; }

    /// <summary>
    /// CreateDate is the date the domain was created at the registry (read-only).
    /// </summary>
    [JsonPropertyName("createDate")]
    public string? CreateDate { get; init; }

    /// <summary>
    /// RenewalPrice is the price to renew the domain. It may be required for the RenewDomain command (read-only).
    /// </summary>
    [JsonPropertyName("renewalPrice")]
    public float? RenewalPrice { get; init; }
}