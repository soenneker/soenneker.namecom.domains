using System.Text.Json.Serialization;
using Soenneker.NameCom.Domains.Dtos;

namespace Soenneker.NameCom.Domains.Requests;

public record SetContactsRequest
{
    [JsonPropertyName("contacts")]
    public NameComContacts? Contacts { get; set; }
}