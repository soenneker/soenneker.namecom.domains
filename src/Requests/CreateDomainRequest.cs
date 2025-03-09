using System.Collections.Generic;
using System.Text.Json.Serialization;
using Soenneker.NameCom.Domains.Dtos;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents a request to create a domain.
/// </summary>
public record CreateDomainRequest
{
    /// <summary>
    /// The domain object to create.
    /// </summary>
    [JsonPropertyName("domain")]
    public NameComDomain? Domain { get; set; }

    /// <summary>
    /// The purchase price in USD.
    /// </summary>
    [JsonPropertyName("purchasePrice")]
    public double? PurchasePrice { get; set; }

    /// <summary>
    /// The type of purchase. Defaults to "registration".
    /// </summary>
    [JsonPropertyName("purchaseType")]
    public string? PurchaseType { get; set; }

    /// <summary>
    /// The number of years to register the domain for.
    /// </summary>
    [JsonPropertyName("years")]
    public int? Years { get; set; }

    /// <summary>
    /// Additional TLD-specific requirements.
    /// </summary>
    [JsonPropertyName("tldRequirements")]
    public Dictionary<string, string>? TldRequirements { get; set; }

    /// <summary>
    /// Promo code for discounts (not yet implemented).
    /// </summary>
    [JsonPropertyName("promoCode")]
    public string? PromoCode { get; set; }
}