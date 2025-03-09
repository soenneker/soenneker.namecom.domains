using Soenneker.NameCom.Domains.Dtos;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents the response from creating a domain.
/// </summary>
public record CreateDomainResponse
{
    /// <summary>
    /// The newly created domain.
    /// </summary>
    [JsonPropertyName("domain")]
    public NameComDomain? Domain { get; set; }

    /// <summary>
    /// An identifier for the purchase.
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// The total amount paid, including VAT and whois protection.
    /// </summary>
    [JsonPropertyName("totalPaid")]
    public double? TotalPaid { get; set; }
}