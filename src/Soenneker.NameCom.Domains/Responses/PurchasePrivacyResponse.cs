using System.Text.Json.Serialization;
using Soenneker.NameCom.Domains.Dtos;

namespace Soenneker.NameCom.Domains.Responses;

public record PurchasePrivacyResponse
{
    [JsonPropertyName("domain")]
    public NameComDomain? Domain { get; set; }

    [JsonPropertyName("order")]
    public int? Order { get; set; }

    [JsonPropertyName("totalPaid")]
    public double? TotalPaid { get; set; }
}