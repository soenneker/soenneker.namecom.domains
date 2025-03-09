using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents the request parameters for the ListDomains API.
/// </summary>
public record ListDomainsRequest
{
    /// <summary> Number of records to return per request (default: 1,000). </summary>
    [JsonPropertyName("perPage")]
    public int? PerPage { get; set; } = 1000;

    /// <summary> Specifies which page to return. </summary>
    [JsonPropertyName("page")]
    public int? Page { get; set; }

    /// <summary> Specifies which domain property to order by. </summary>
    [JsonPropertyName("sort")]
    public string? Sort { get; set; }

    /// <summary> Direction of sorting (Possible values: "asc" (default) or "desc"). </summary>
    [JsonPropertyName("dir")]
    public string Dir { get; set; } = "asc";

    /// <summary> Filters domains by exact domain name or wildcard (starts with '*'). </summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary> Filters domains based on specific top-level domain (TLD). </summary>
    [JsonPropertyName("tld")]
    public string? Tld { get; set; }

    /// <summary> Filters domains based on their locked status. </summary>
    [JsonPropertyName("locked")]
    public bool? Locked { get; set; }

    /// <summary> Filters domains created on this specific date. </summary>
    [JsonPropertyName("createDate")]
    public string? CreateDate { get; set; }

    /// <summary> Filters domains created on or after this date. </summary>
    [JsonPropertyName("createDateStart")]
    public string? CreateDateStart { get; set; }

    /// <summary> Filters domains created on or before this date. </summary>
    [JsonPropertyName("createDateEnd")]
    public string? CreateDateEnd { get; set; }

    /// <summary> Filters domains expiring on this specific date. </summary>
    [JsonPropertyName("expireDate")]
    public string? ExpireDate { get; set; }

    /// <summary> Filters domains expiring on or after this date. </summary>
    [JsonPropertyName("expireDateStart")]
    public string? ExpireDateStart { get; set; }

    /// <summary> Filters domains expiring on or before this date. </summary>
    [JsonPropertyName("expireDateEnd")]
    public string? ExpireDateEnd { get; set; }

    /// <summary> Indicates whether privacy protection is enabled. </summary>
    [JsonPropertyName("privacyEnabled")]
    public bool? PrivacyEnabled { get; set; }

    /// <summary> Filters premium domains. </summary>
    [JsonPropertyName("isPremium")]
    public bool? IsPremium { get; set; }

    /// <summary> Indicates if the domain will attempt automatic renewal before expiration. </summary>
    [JsonPropertyName("autorenewEnabled")]
    public bool? AutorenewEnabled { get; set; }

    /// <summary> Specifies the order number of the domain purchase. </summary>
    [JsonPropertyName("orderId")]
    public int? OrderId { get; set; }
}