[![](https://img.shields.io/nuget/v/soenneker.namecom.domains.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.namecom.domains/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.namecom.domains/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.namecom.domains/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.namecom.domains.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.namecom.domains/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.NameCom.Domains
### A .NET typesafe implementation of Name.com's Domain API

## Installation

```
dotnet add package Soenneker.NameCom.Domains
```

# NameCom Domains Utility

## Overview
The `NameComDomainsUtil` class provides a set of methods for managing domains using the Name.com API. This utility allows developers to list, retrieve, create, and manage domains programmatically.

## Features
- List available domains
- Retrieve domain details
- Create new domains
- Enable/disable WHOIS privacy
- Enable/disable auto-renewal
- Renew domains
- Retrieve domain pricing
- Get authorization codes
- Purchase domain privacy
- Set nameservers
- Update domain contacts
- Lock/unlock domains
- Check domain availability
- Perform domain searches

### Listing Domains
```csharp
var request = new ListDomainsRequest();
var response = await domainUtil.ListDomains(request);
```

### Getting Domain Details
```csharp
var domainDetails = await domainUtil.GetDomain("example.com");
```

### Creating a Domain
```csharp
var createRequest = new CreateDomainRequest { DomainName = "example.com" };
var createResponse = await domainUtil.CreateDomain(createRequest);
```

### Enabling WHOIS Privacy
```csharp
var response = await domainUtil.EnableWhoisPrivacy("example.com");
```

### Disabling WHOIS Privacy
```csharp
var response = await domainUtil.DisableWhoisPrivacy("example.com");
```

### Renewing a Domain
```csharp
var renewRequest = new RenewDomainRequest { Years = 1 };
var renewResponse = await domainUtil.RenewDomain("example.com", renewRequest);
```

### Checking Domain Availability
```csharp
var checkRequest = new CheckAvailabilityRequest { DomainNames = new[] { "example.com" } };
var availabilityResponse = await domainUtil.CheckAvailability(checkRequest);
```

### Searching for Domains
```csharp
var searchRequest = new SearchRequest { Query = "example" };
var searchResponse = await domainUtil.Search(searchRequest);
```