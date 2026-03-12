using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents a request to search for domains.
/// </summary>
public record SearchRequest
{
    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    [JsonPropertyName("tldFilter")]
    public List<string>? TldFilter { get; set; }

    [JsonPropertyName("promoCode")]
    public string? PromoCode { get; set; }
}