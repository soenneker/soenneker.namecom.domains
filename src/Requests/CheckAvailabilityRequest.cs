using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents a request to check domain availability.
/// </summary>
public record CheckAvailabilityRequest
{
    [JsonPropertyName("domainNames")]
    public List<string>? DomainNames { get; set; }

    [JsonPropertyName("promoCode")]
    public string? PromoCode { get; set; }
}