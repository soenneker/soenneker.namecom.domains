using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents a domain search result.
/// </summary>
public record SearchResponse
{
    /// <summary>
    /// Gets or sets domain name.
    /// </summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// Gets or sets purchase price.
    /// </summary>
    [JsonPropertyName("purchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Gets or sets renewal price.
    /// </summary>
    [JsonPropertyName("renewalPrice")]
    public double? RenewalPrice { get; set; }
}