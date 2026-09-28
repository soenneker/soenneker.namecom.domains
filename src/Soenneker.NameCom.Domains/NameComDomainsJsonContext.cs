using System.Text.Json.Serialization;
using Soenneker.NameCom.Domains.Requests;

namespace Soenneker.NameCom.Domains;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(ListDomainsRequest))]
internal partial class NameComDomainsJsonContext : JsonSerializerContext
{
}
