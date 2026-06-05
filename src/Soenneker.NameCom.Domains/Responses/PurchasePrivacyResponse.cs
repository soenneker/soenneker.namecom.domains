using System.Text.Json.Serialization;
using Soenneker.NameCom.Domains.Dtos;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents the purchase privacy response record.
/// </summary>
public record PurchasePrivacyResponse
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