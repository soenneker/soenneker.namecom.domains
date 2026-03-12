using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents a request to renew a domain.
/// </summary>
public record RenewDomainRequest
{
    [JsonPropertyName("purchasePrice")]
    public double? PurchasePrice { get; set; }

    [JsonPropertyName("years")]
    public int? Years { get; set; }

    [JsonPropertyName("promoCode")]
    public string? PromoCode { get; set; }
}