using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents the response from retrieving an authorization code for a domain.
/// </summary>
public record GetAuthCodeResponse
{
    /// <summary>
    /// Gets or sets auth code.
    /// </summary>
    [JsonPropertyName("authCode")]
    public string? AuthCode { get; set; }
}