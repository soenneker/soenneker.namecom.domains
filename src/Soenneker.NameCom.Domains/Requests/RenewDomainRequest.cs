using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents a request to renew a domain.
/// </summary>
public record RenewDomainRequest
{
    /// <summary>
    /// Gets or sets purchase price.
    /// </summary>
    [JsonPropertyName("purchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// Gets or sets years.
    /// </summary>
    [JsonPropertyName("years")]
    public int? Years { get; set; }

    /// <summary>
    /// Gets or sets promo code.
    /// </summary>
    [JsonPropertyName("promoCode")]
    public string? PromoCode { get; set; }
}