using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents the response from retrieving domain pricing.
/// </summary>
public record GetDomainPricingResponse
{
    [JsonPropertyName("purchasePrice")]
    public double? PurchasePrice { get; set; }

    [JsonPropertyName("renewalPrice")]
    public double? RenewalPrice { get; set; }

    [JsonPropertyName("transferPrice")]
    public double? TransferPrice { get; set; }

    [JsonPropertyName("premium")]
    public bool? Premium { get; set; }
}