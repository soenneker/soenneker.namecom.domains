using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.NameCom.Client.Registrars;
using Soenneker.NameCom.Domains.Abstract;

namespace Soenneker.NameCom.Domains.Registrars;

/// <summary>
/// A .NET typesafe implementation of Name.com's Domain API
/// </summary>
public static class NameComDomainsUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="INameComDomainsUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddNameComDomainsUtilAsSingleton(this IServiceCollection services)
    {
        services.AddNameComClientUtilAsSingleton();
        services.TryAddSingleton<INameComDomainsUtil, NameComDomainsUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="INameComDomainsUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddNameComDomainsUtilAsScoped(this IServiceCollection services)
    {
        services.AddNameComClientUtilAsScoped();
        services.TryAddScoped<INameComDomainsUtil, NameComDomainsUtil>();

        return services;
    }
}
