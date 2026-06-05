using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents a request to check domain availability.
/// </summary>
public record CheckAvailabilityRequest
{
    /// <summary>
    /// Gets or sets domain names.
    /// </summary>
    [JsonPropertyName("domainNames")]
    public List<string>? DomainNames { get; set; }

    /// <summary>
    /// Gets or sets promo code.
    /// </summary>
    [JsonPropertyName("promoCode")]
    public string? PromoCode { get; set; }
}