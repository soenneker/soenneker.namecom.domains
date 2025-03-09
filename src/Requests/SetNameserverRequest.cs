using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

public record SetNameserversRequest
{
    [JsonPropertyName("nameservers")]
    public List<string>? Nameservers { get; set; }
}