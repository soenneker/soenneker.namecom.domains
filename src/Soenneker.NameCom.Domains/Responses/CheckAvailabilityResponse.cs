using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents the response from checking domain availability.
/// </summary>
public record CheckAvailabilityResponse
{
    [JsonPropertyName("results")]
    public List<SearchResponse>? Results { get; set; }
}