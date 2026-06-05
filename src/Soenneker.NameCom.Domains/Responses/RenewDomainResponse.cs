using Soenneker.NameCom.Domains.Dtos;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents the response from renewing a domain.
/// </summary>
public record RenewDomainResponse
{
    /// <summary>
    /// Gets or sets domain.
    /// </summary>
    [JsonPropertyName("domain")]
    public NameComDomain? Domain { get; set; }

    /// <summary>
    /// Gets or sets order.
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// Gets or sets total paid.
    /// </summary>
    [JsonPropertyName("totalPaid")]
    public double? TotalPaid { get; set; }
}