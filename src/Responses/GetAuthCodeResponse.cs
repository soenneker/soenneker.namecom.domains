using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents the response from retrieving an authorization code for a domain.
/// </summary>
public record GetAuthCodeResponse
{
    [JsonPropertyName("authCode")]
    public string? AuthCode { get; set; }
}