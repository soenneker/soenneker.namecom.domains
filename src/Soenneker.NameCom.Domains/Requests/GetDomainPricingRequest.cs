using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents the response from retrieving domain pricing.
/// </summary>
public record GetDomainPricingResponse
{
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

    /// <summary>
    /// Gets or sets transfer price.
    /// </summary>
    [JsonPropertyName("transferPrice")]
    public double? TransferPrice { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether premium.
    /// </summary>
    [JsonPropertyName("premium")]
    public bool? Premium { get; set; }
}