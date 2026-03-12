using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents a domain search result.
/// </summary>
public record SearchResponse
{
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    [JsonPropertyName("purchasePrice")]
    public double? PurchasePrice { get; set; }

    [JsonPropertyName("renewalPrice")]
    public double? RenewalPrice { get; set; }
}