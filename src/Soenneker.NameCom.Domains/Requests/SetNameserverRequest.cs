using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Requests;

/// <summary>
/// Represents the set nameservers request record.
/// </summary>
public record SetNameserversRequest
{
    /// <summary>
    /// Gets or sets nameservers.
    /// </summary>
    [JsonPropertyName("nameservers")]
    public List<string>? Nameservers { get; set; }
}