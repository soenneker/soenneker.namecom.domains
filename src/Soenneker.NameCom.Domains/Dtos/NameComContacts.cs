using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Dtos;

/// <summary>
/// NameComContacts stores the contact information for the roles related to domains.
/// </summary>
public record NameComContacts
{
    /// <summary>
    /// Registrant is the rightful owner of the domain.
    /// </summary>
    [JsonPropertyName("registrant")]
    public NameComContact? Registrant { get; set; }

    /// <summary>
    /// Administrative contact managing the domain's business details.
    /// </summary>
    [JsonPropertyName("admin")]
    public NameComContact? Admin { get; set; }

    /// <summary>
    /// Technical contact managing and maintaining a domain’s nameservers.
    /// </summary>
    [JsonPropertyName("tech")]
    public NameComContact? Tech { get; set; }

    /// <summary>
    /// Billing contact responsible for payments and renewals.
    /// </summary>
    [JsonPropertyName("billing")]
    public NameComContact? Billing { get; set; }
}