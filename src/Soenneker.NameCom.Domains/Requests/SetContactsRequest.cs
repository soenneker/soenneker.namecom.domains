using System.Text.Json.Serialization;
using Soenneker.NameCom.Domains.Dtos;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents the set contacts request record.
/// </summary>
public record SetContactsRequest
{
    /// <summary>
    /// Gets or sets contacts.
    /// </summary>
    [JsonPropertyName("contacts")]
    public NameComContacts? Contacts { get; set; }
}