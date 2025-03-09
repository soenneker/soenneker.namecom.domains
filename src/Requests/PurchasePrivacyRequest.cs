using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents a request to purchase Whois Privacy protection.
/// </summary>
public record PurchasePrivacyRequest
{
    [JsonPropertyName("purchasePrice")]
    public double? PurchasePrice { get; set; }

    [JsonPropertyName("years")]
    public int? Years { get; set; }

    [JsonPropertyName("promoCode")]
    public string? PromoCode { get; set; }
}