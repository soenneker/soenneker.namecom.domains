using System.Collections.Generic;
using System.Text.Json.Serialization;
using Soenneker.NameCom.Domains.Dtos;

namespace Soenneker.NameCom.Domains.Responses;

/// <summary>
/// Represents the response returned by the ListDomains API.
/// </summary>
public record ListDomainsResponse
{
    /// <summary> List of domains in the account. </summary>
    [JsonPropertyName("domains")]
    public List<NameComDomain>? Domains { get; set; }

    /// <summary> The current page of results returned. </summary>
    [JsonPropertyName("currentPage")]
    public int CurrentPage { get; set; }

    /// <summary> Identifier for the next page of results (if available). </summary>
    [JsonPropertyName("nextPage")]
    public int? NextPage { get; set; }

    /// <summary> Identifier for the last page of results (if available). </summary>
    [JsonPropertyName("lastPage")]
    public int? LastPage { get; set; }

    /// <summary> Total number of domains returned for the request. </summary>
    [JsonPropertyName("totalCount")]
    public int TotalCount { get; set; }

    /// <summary> The starting record count for the current page. </summary>
    [JsonPropertyName("from")]
    public int From { get; set; }

    /// <summary> The ending record count for the current page. </summary>
    [JsonPropertyName("to")]
    public int To { get; set; }
}