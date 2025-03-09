using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Dtos;

/// <summary>
/// SearchResult is returned by the CheckAvailability, Search, and SearchStream functions.
/// </summary>
public record NameComSearchResult
{
    /// <summary>
    /// DomainName is the punycode encoding of the result domain name.
    /// </summary>
    [JsonPropertyName("domainName")]
    public string DomainName { get; set; } = string.Empty;

    /// <summary>
    /// SLD is the first portion of the domain name.
    /// </summary>
    [JsonPropertyName("sld")]
    public string Sld { get; set; } = string.Empty;

    /// <summary>
    /// TLD is the rest of the domain name after the SLD.
    /// </summary>
    [JsonPropertyName("tld")]
    public string Tld { get; set; } = string.Empty;

    /// <summary>
    /// Purchaseable indicates whether the search result is available for purchase.
    /// Note: If the domain is not purchasable, this value may not be returned, indicating that the domain is unavailable for purchase.
    /// </summary>
    [JsonPropertyName("purchasable")]
    public bool? Purchasable { get; set; }

    /// <summary>
    /// Premium indicates that this search result is a premium result and the purchase price needs to be passed to the DomainCreate command.
    /// </summary>
    [JsonPropertyName("premium")]
    public bool Premium { get; set; }

    /// <summary>
    /// PurchasePrice is the price for purchasing this domain for the minimum time period (typically 1 year). Purchase price is always in USD.
    /// </summary>
    [JsonPropertyName("purchasePrice")]
    public float PurchasePrice { get; set; }

    /// <summary>
    /// PurchaseType indicates what kind of purchase this result is for. It should be passed to the DomainCreate command.
    /// </summary>
    [JsonPropertyName("purchaseType")]
    public string PurchaseType { get; set; } = string.Empty;

    /// <summary>
    /// RenewalPrice is the annual renewal price for this domain as it may be different than the purchase price.
    /// </summary>
    [JsonPropertyName("renewalPrice")]
    public float RenewalPrice { get; set; }
}