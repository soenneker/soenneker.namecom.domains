using Soenneker.NameCom.Domains.Dtos;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents the response from renewing a domain.
/// </summary>
public record RenewDomainResponse
{
    [JsonPropertyName("domain")]
    public NameComDomain? Domain { get; set; }

    [JsonPropertyName("order")]
    public int? Order { get; set; }

    [JsonPropertyName("totalPaid")]
    public double? TotalPaid { get; set; }
}