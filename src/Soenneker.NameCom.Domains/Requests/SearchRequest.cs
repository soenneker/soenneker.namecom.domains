using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents a request to search for domains.
/// </summary>
public record SearchRequest
{
    /// <summary>
    /// Gets or sets timeout.
    /// </summary>
    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    /// <summary>
    /// Gets or sets keyword.
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>
    /// Gets or sets tld filter.
    /// </summary>
    [JsonPropertyName("tldFilter")]
    public List<string>? TldFilter { get; set; }

    /// <summary>
    /// Gets or sets promo code.
    /// </summary>
    [JsonPropertyName("promoCode")]
    public string? PromoCode { get; set; }
}