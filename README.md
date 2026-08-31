[![](https://img.shields.io/nuget/v/soenneker.namecom.domains.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.namecom.domains/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.namecom.domains/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.namecom.domains/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.namecom.domains.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.namecom.domains/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.namecom.domains/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.namecom.domains/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.NameCom.Domains

Typed operations for listing, searching, registering, renewing, and configuring Name.com domains.

## Installation

```bash
dotnet add package Soenneker.NameCom.Domains
```

## Configuration

```json
{
  "NameCom": {
    "Username": "your-username",
    "Token": "your-api-token"
  }
}
```

## Usage

```csharp
using Soenneker.NameCom.Domains.Abstract;
using Soenneker.NameCom.Domains.Registrars;
using Soenneker.NameCom.Domains.Requests;

services.AddNameComDomainsUtilAsSingleton();

INameComDomainsUtil domains = serviceProvider
    .GetRequiredService<INameComDomainsUtil>();

var page = await domains.ListDomains(
    new ListDomainsRequest { Page = 1, PerPage = 100 },
    cancellationToken: cancellationToken);

var availability = await domains.CheckAvailability(
    new CheckAvailabilityRequest { DomainNames = ["example.com"] },
    cancellationToken: cancellationToken);
```

Pass `test: true` to any operation to use Name.com's test API.

## Available operations

The utility can retrieve domains and pricing, search and check availability, register or renew domains, manage WHOIS privacy and auto-renewal, update contacts and nameservers, lock or unlock domains, and retrieve transfer authorization codes.

`CreateDomain`, `RenewDomain`, and `PurchasePrivacy` can incur charges. Privacy, auto-renewal, contact, nameserver, and lock operations change the domain immediately; use the test API when validating those flows.
