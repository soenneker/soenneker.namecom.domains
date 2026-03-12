using System.Text.Json.Serialization;

namespace Soenneker.NameCom.Domains.Dtos;

/// <summary>
/// Contact contains all the contact data.
/// </summary>
public record NameComContact
{
    /// <summary>
    /// First name of the contact.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Last name of the contact.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Company name of the contact. Leave blank if the contact is an individual.
    /// </summary>
    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    /// <summary>
    /// First line of the contact's address.
    /// </summary>
    [JsonPropertyName("address1")]
    public string Address1 { get; set; } = string.Empty;

    /// <summary>
    /// Second line of the contact's address.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? Address2 { get; set; }

    /// <summary>
    /// City of the contact's address.
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// State or Province for the contact's address.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; } = string.Empty;

    /// <summary>
    /// Zip or Postal Code for the contact's address.
    /// </summary>
    [JsonPropertyName("zip")]
    public string Zip { get; set; } = string.Empty;

    /// <summary>
    /// Country code for the contact's address (ISO 3166-1 alpha-2 code required).
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Phone number of the contact. Format: "+cc.llllllll".
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Fax number of the contact. Format: "+cc.llllllll".
    /// </summary>
    [JsonPropertyName("fax")]
    public string? Fax { get; set; }

    /// <summary>
    /// Email of the contact. Should be a valid email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;
}